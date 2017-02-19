/*All code below written and owned by Jordan Harlow
 *  Metronomo App 2017, HackFSU '17
 */

/*TODO
 * accents - do not do until added meter changes
 * disable/enable metronome
 * when display is turned off, metronome uninterupted
 * 		that issue is fixed, now their is a stutter between when the display is off or on :C
 * visual indictation of tempo (screen flashing)
 */

#include "metronomo.h"		/*hehe, spells homonortem backwards */
#include<device/haptic.h> 	/*for vibration functionality, must set privilege in .xml file */
#include<device/callback.h> /*rotary bezel functionality */
#include<sys/time.h> 		/*for the metronome time*/
#include <device/power.h>	/*For keeping the display from turning off, really doesn't work how it should*/


int bpm = 120;			 	/*beats per minute, defaulted to 120*/
Evas_Object *labpointer; 	/*for the labe3 object*/
Ecore_Timer *globtimer;  	/*Ecore timer value*/

typedef struct appdata {
	Evas_Object *win;		/*window object*/
	Evas_Object *conform;	/*conformant object*/
	Evas_Object *label;		/*label objects*/
	Evas_Object *label2;
	Evas_Object *label3;
	Evas_Object *layout;	/*layout, not used, am bad programmer*/
	Evas_Object *background;/*background for dat colorrrr*/
	Evas_Object *naviframe;	/*naviframe, not used*/
	Ecore_Timer *timer;		/*timer for.... timing*/

} appdata_s;

/* simple vibrate function using haptic.h library*/
static void device_vibrate()
{
	haptic_device_h m_haptic = 0;
	haptic_effect_h m_effect = 0;
	device_haptic_open( 0, &m_haptic );

	/*device_haptic_vibrate( device, microseconds, percentage intensity, effect);*/
	device_haptic_vibrate ( m_haptic, 100, 100, &m_effect );

	/*device_haptic_close( m_haptic );*/
}

/*tempo function, gets called by ecore_timer_add functions */
Eina_Bool tempo_funct_cb(void *data)
{
	device_vibrate();
	return ECORE_CALLBACK_RENEW;
}

/*built in rotary event handler, made it so it changes the current bpm*/
Eina_Bool _rotary_handler_cb(void *data, Eext_Rotary_Event_Info *ev)
{
	char beats[10];
	Evas_Object *templabel;


   if (ev->direction == EEXT_ROTARY_DIRECTION_CLOCKWISE)
   {
      dlog_print(DLOG_DEBUG, LOG_TAG, "ROTARY HANDLER: Rotary device rotated in clockwise direction");
      /*device_vibrate(100, 1000);*/
      if(bpm < 300)
      {
    	  bpm++;
    	  sprintf(beats, "%d bpm", bpm);
    	  templabel = labpointer;
    	  elm_object_text_set(templabel, beats);
    	  ecore_timer_interval_set(globtimer, (60.0/bpm));


      }
   }
   else
   {
      dlog_print(DLOG_DEBUG, LOG_TAG, "Rotary device rotated in counter clockwise direction");
      /*device_vibrate(80, 200);*/
      if(bpm > 40)
      {
    	  bpm--;
    	  sprintf(beats, "%d bpm", bpm);
    	  templabel = labpointer;
    	  elm_object_text_set(templabel, beats);
    	  ecore_timer_interval_set(globtimer, (60.0/bpm));
      }
   }

   return EINA_FALSE;
}

static void
win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

static void
win_back_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

static void
create_base_gui(appdata_s *ad)
{
	/* Window */
	/* Create and initialize elm_win.
	   elm_win is mandatory to manipulate window. */
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
	}

	/*efl_util_set_window_screen_mode(ad->win, EFL_UTIL_SCREEN_MODE_ALWAYS_ON);
	*/
	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);
	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);

	/* Conformant */
	/* Create and initialize elm_conformant.
	   elm_conformant is mandatory for base gui to have proper size
	   when indicator or virtual keypad is visible. */
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	/*Naviframe*/
	ad->naviframe = elm_naviframe_add(ad->conform);
	elm_object_content_set(ad->conform, ad->naviframe);
	evas_object_show(ad->naviframe);

	/* Label */
	/* Create an actual view of the base gui.
	   Modify this part to change the view. */
	ad->label = elm_label_add(ad->conform);
	elm_object_text_set(ad->label, "<align=center>Metronomo!</align>");
	evas_object_size_hint_weight_set(ad->label, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
    /*elm_object_content_set(ad->conform, ad->label);*/
	evas_object_move(ad->label, -25, 100);
	evas_object_resize(ad->label, 400, 100);
	evas_object_show(ad->label);

	ad->label2 = elm_label_add(ad->conform);
	elm_object_text_set(ad->label2, "<align=center>Rotate the bezel!</align>");
	evas_object_size_hint_weight_set(ad->label2, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_move(ad->label2, 30, 130);
	evas_object_resize(ad->label2, 300, 100);
	evas_object_show(ad->label2);


	char beats[10];
	sprintf(beats, "%d bpm", bpm);
	ad->label3 = elm_label_add(ad->conform);
	elm_object_text_set(ad->label3, beats);
	evas_object_size_hint_weight_set(ad->label3, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_move(ad->label3, 120, 200);
	evas_object_resize(ad->label3, 400, 100);
	evas_object_show(ad->label3);

	labpointer = ad->label3;

	/*Layout*/
    ad->layout = elm_layout_add(ad->win);



	/*Background I fuckin' guess*/
    ad->background = elm_bg_add(ad->win);
    elm_bg_color_set(ad->background, 255, 70, 70);
    elm_object_content_set(ad->conform, ad->background);
    evas_object_show(ad->background);



	/* Show window after base gui is set up */
	evas_object_show(ad->win);
}

static bool
app_create(void *data)
{
	/* Hook to take necessary actions before main event loop starts
		Initialize UI resources and application's data
		If this function returns true, the main loop of application starts
		If this function returns false, the application is terminated */
	appdata_s *ad = data;
	device_power_request_lock(POWER_LOCK_DISPLAY, 0);

	eext_rotary_event_handler_add(_rotary_handler_cb, NULL);

	create_base_gui(ad);

	return true;
}

static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void
app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
	device_power_request_lock(POWER_LOCK_DISPLAY, 0);

}

static void
app_resume(void *data)
{
	/* Take necessary actions when application becomes visible. */
	device_power_release_lock(POWER_LOCK_DISPLAY);
}

static void
app_terminate(void *data)
{
	/* Release all resources. */
	eext_rotary_event_handler_del(_rotary_handler_cb);


}

static void
ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void
ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void
ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

static void
ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

int
main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	Ecore_Timer * timer = ecore_timer_add(0.5, tempo_funct_cb, NULL); /*calls tempo every 0.5 seconds*/
	globtimer = timer;

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}