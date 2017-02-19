S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.5
Build-Number: R730VVRU2BPC7
Build-Date: 2016.04.01 13:23:02

Crash Information
Process Name: metronomo
PID: 6307
Date: 2017-02-18 04:39:36-0500
Executable File Path: /opt/usr/apps/org.example.metronomo/bin/metronomo
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xb94

Register Information
r0   = 0xff4646ff, r1   = 0xbeb755e8
r2   = 0xb90a4470, r3   = 0xb5887245
r4   = 0xbeb7554c, r5   = 0xb5bbc980
r6   = 0xb9066f00, r7   = 0x00000285
r8   = 0x00000041, r9   = 0xb6c7c824
r10  = 0xb905c800, fp   = 0x00000000
ip   = 0xb58977c0, sp   = 0xbeb74d10
lr   = 0xb588724b, pc   = 0x00000b94
cpsr = 0x60000010

Memory Information
MemTotal:   389300 KB
MemFree:     19896 KB
Buffers:     16732 KB
Cached:      98112 KB
VmPeak:      69820 KB
VmSize:      68736 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       13692 KB
VmRSS:       13304 KB
VmData:      13220 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23056 KB
VmPTE:          50 KB
VmSwap:          0 KB

Maps Information
b2e68000 b2eef000 rw-s anon_inode:dmabuf
b2eef000 b2ef2000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b2efa000 b2f81000 rw-s anon_inode:dmabuf
b311c000 b311d000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
b3925000 b393c000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3949000 b394b000 r-xp /usr/lib/libgenlock.so
b395b000 b395d000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3969000 b396e000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b3976000 b3981000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b3ce9000 b3db3000 r-xp /usr/lib/libCOREGL.so.4.0
b3dc4000 b3dcd000 r-xp /usr/lib/libresourced.so.0.2.86
b3dd5000 b3dd6000 r-xp /usr/lib/librd-network.so.0.2.86
b3dde000 b3deb000 r-xp /usr/lib/libail.so.0.1.0
b3df4000 b3dfb000 r-xp /usr/lib/libminizip.so.1.0.0
b3e03000 b3e05000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b3e0d000 b3e14000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b3e1d000 b3e39000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b3e42000 b3e4a000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
b3e52000 b3e58000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b3e60000 b3e65000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
b3e6d000 b3e8e000 r-xp /usr/lib/libexif.so.12.3.3
b3ea1000 b3eba000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
b3ec2000 b3ec7000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3ecf000 b3ed4000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b5464000 b5466000 r-xp /usr/lib/libdri2.so.0.0.0
b546e000 b5476000 r-xp /usr/lib/libdrm.so.2.4.0
b547e000 b547f000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b5488000 b548b000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
b5493000 b5577000 r-xp /usr/lib/libicuuc.so.51.1
b558c000 b56c9000 r-xp /usr/lib/libicui18n.so.51.1
b56d9000 b56df000 r-xp /usr/lib/libxcb-render.so.0.0.0
b56e7000 b56e8000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b56f1000 b56f4000 r-xp /usr/lib/libEGL.so.1.4
b56fc000 b570a000 r-xp /usr/lib/libGLESv2.so.2.0
b5713000 b571a000 r-xp /usr/lib/libtbm.so.1.0.0
b5722000 b5743000 r-xp /usr/lib/libui-extension.so.0.1.0
b574c000 b575e000 r-xp /usr/lib/libtts.so
b5766000 b581e000 r-xp /usr/lib/libcairo.so.2.11200.14
b5829000 b583b000 r-xp /usr/lib/libefl-assist.so.0.1.0
b5843000 b5848000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b5850000 b5871000 r-xp /usr/lib/libefl-extension.so.0.1.0
b5879000 b587e000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b5886000 b5888000 r-xp /opt/usr/apps/org.example.metronomo/bin/metronomo
b5a37000 b5a41000 r-xp /lib/libnss_files-2.13.so
b5a4a000 b5b19000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5b2f000 b5b53000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5b5c000 b5b62000 r-xp /usr/lib/libappsvc.so.0.1.0
b5b6a000 b5b6c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5b75000 b5b79000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5b85000 b5b90000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b5b98000 b5b9a000 r-xp /usr/lib/libiniparser.so.0
b5ba3000 b5ba8000 r-xp /usr/lib/libappcore-common.so.1.1
b5bb1000 b5bb9000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b5bba000 b5bbe000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5bcb000 b5bcd000 r-xp /usr/lib/libXau.so.6.0.0
b5bd6000 b5bdd000 r-xp /lib/libcrypt-2.13.so
b5c0d000 b5c0f000 r-xp /usr/lib/libiri.so
b5c17000 b5dbf000 r-xp /usr/lib/libcrypto.so.1.0.0
b5dd8000 b5e25000 r-xp /usr/lib/libssl.so.1.0.0
b5e32000 b5e60000 r-xp /usr/lib/libidn.so.11.5.44
b5e68000 b5e71000 r-xp /usr/lib/libcares.so.2.1.0
b5e7a000 b5e8d000 r-xp /usr/lib/libxcb.so.1.1.0
b5e96000 b5e98000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5ea1000 b5ea3000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5eac000 b5f78000 r-xp /usr/lib/libxml2.so.2.7.8
b5f85000 b5f87000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5f8f000 b5f94000 r-xp /usr/lib/libffi.so.5.0.10
b5f9c000 b5f9d000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5fa6000 b5fb1000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5fb9000 b5fbc000 r-xp /lib/libattr.so.1.1.0
b5fc4000 b6058000 r-xp /usr/lib/libstdc++.so.6.0.16
b606b000 b6088000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b6091000 b60a9000 r-xp /usr/lib/libpng12.so.0.50.0
b60b2000 b60c8000 r-xp /lib/libexpat.so.1.5.2
b60d2000 b6116000 r-xp /usr/lib/libcurl.so.4.3.0
b611f000 b6129000 r-xp /usr/lib/libXext.so.6.4.0
b6132000 b6136000 r-xp /usr/lib/libXtst.so.6.1.0
b613e000 b6144000 r-xp /usr/lib/libXrender.so.1.3.0
b614d000 b6153000 r-xp /usr/lib/libXrandr.so.2.2.0
b615b000 b615c000 r-xp /usr/lib/libXinerama.so.1.0.0
b6165000 b616e000 r-xp /usr/lib/libXi.so.6.1.0
b6176000 b6179000 r-xp /usr/lib/libXfixes.so.3.1.0
b6181000 b6183000 r-xp /usr/lib/libXgesture.so.7.0.0
b618b000 b618d000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6196000 b6198000 r-xp /usr/lib/libXdamage.so.1.1.0
b61a0000 b61a7000 r-xp /usr/lib/libXcursor.so.1.0.2
b61af000 b61b2000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b61ba000 b61be000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b61c7000 b61cc000 r-xp /usr/lib/libecore_fb.so.1.7.99
b61d6000 b62b7000 r-xp /usr/lib/libX11.so.6.3.0
b62c2000 b62e5000 r-xp /usr/lib/libjpeg.so.8.0.2
b62fd000 b6313000 r-xp /lib/libz.so.1.2.5
b631b000 b6390000 r-xp /usr/lib/libsqlite3.so.0.8.6
b639a000 b63b0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b63b9000 b63ed000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b63f6000 b64c9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b64d4000 b64e4000 r-xp /lib/libresolv-2.13.so
b64e8000 b6564000 r-xp /usr/lib/libgcrypt.so.20.0.3
b6570000 b6588000 r-xp /usr/lib/liblzma.so.5.0.3
b6591000 b6594000 r-xp /lib/libcap.so.2.21
b659c000 b65c9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b65d1000 b65d2000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b65da000 b65e0000 r-xp /usr/lib/libecore_imf.so.1.7.99
b65e8000 b65ff000 r-xp /usr/lib/liblua-5.1.so
b6609000 b6610000 r-xp /usr/lib/libembryo.so.1.7.99
b6618000 b661e000 r-xp /lib/librt-2.13.so
b6627000 b667d000 r-xp /usr/lib/libpixman-1.so.0.28.2
b668a000 b66e0000 r-xp /usr/lib/libfreetype.so.6.11.3
b66ec000 b6714000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6716000 b6753000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b675c000 b676f000 r-xp /usr/lib/libfribidi.so.0.3.1
b6777000 b6791000 r-xp /usr/lib/libecore_con.so.1.7.99
b679a000 b67a3000 r-xp /usr/lib/libedbus.so.1.7.99
b67ab000 b67fb000 r-xp /usr/lib/libecore_x.so.1.7.99
b67fe000 b6802000 r-xp /usr/lib/libvconf.so.0.2.45
b680a000 b681b000 r-xp /usr/lib/libecore_input.so.1.7.99
b6823000 b6828000 r-xp /usr/lib/libecore_file.so.1.7.99
b6830000 b6852000 r-xp /usr/lib/libecore_evas.so.1.7.99
b685b000 b689c000 r-xp /usr/lib/libeina.so.1.7.99
b68a5000 b68be000 r-xp /usr/lib/libeet.so.1.7.99
b68cf000 b6938000 r-xp /lib/libm-2.13.so
b6941000 b6947000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b6950000 b6953000 r-xp /usr/lib/libproc-stat.so.0.2.86
b695b000 b697d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6985000 b698a000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6992000 b69bc000 r-xp /usr/lib/libdbus-1.so.3.8.12
b69c5000 b69dc000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b69e4000 b69ef000 r-xp /lib/libunwind.so.8.0.1
b6a1c000 b6a58000 r-xp /usr/lib/libsystemd.so.0.4.0
b6a61000 b6b7c000 r-xp /lib/libc-2.13.so
b6b8a000 b6b92000 r-xp /lib/libgcc_s-4.6.so.1
b6b93000 b6b96000 r-xp /usr/lib/libsmack.so.1.0.0
b6b9e000 b6ba4000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6bac000 b6c7c000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c7d000 b6cda000 r-xp /usr/lib/libedje.so.1.7.99
b6ce4000 b6cfb000 r-xp /usr/lib/libecore.so.1.7.99
b6d12000 b6de0000 r-xp /usr/lib/libevas.so.1.7.99
b6e05000 b6f40000 r-xp /usr/lib/libelementary.so.1.7.99
b6f56000 b6f6a000 r-xp /lib/libpthread-2.13.so
b6f75000 b6f77000 r-xp /usr/lib/libdlog.so.0.0.0
b6f7f000 b6f82000 r-xp /usr/lib/libbundle.so.0.1.22
b6f8a000 b6f8c000 r-xp /lib/libdl-2.13.so
b6f95000 b6fa1000 r-xp /usr/lib/libaul.so.0.1.0
b6fb3000 b6fb8000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fc1000 b6fc5000 r-xp /usr/lib/libsys-assert.so
b6fce000 b6feb000 r-xp /lib/ld-2.13.so
b6ff4000 b6ff9000 r-xp /usr/bin/launchpad-loader
b8f6c000 b9108000 rw-p [heap]
beb55000 beb76000 rw-p [stack]
b8f6c000 b9108000 rw-p [heap]
beb55000 beb76000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6307)
Call Stack Count: 1
 0: (0xb94) (null)
End of Call Stack

Package Information
Package Name: org.example.metronomo
Package ID : org.example.metronomo
Version: 1.0.0
Package Type: rpm
App Name: metronomo
App ID: org.example.metronomo
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
e-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:17.810-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:17.810-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:18.000-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:18.000-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:18.200-0500 I/efl-extension( 1125): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb896be50, elm_scroller, _activated_obj : 0xb896be50, activated : 0
02-18 04:39:18.200-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:18.200-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:18.230-0500 I/efl-extension( 1125): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0xb896be50, obj: 0xb896be50
02-18 04:39:18.240-0500 I/efl-extension( 1125): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
02-18 04:39:18.250-0500 I/efl-extension( 1125): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
02-18 04:39:18.250-0500 I/efl-extension( 1125): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
02-18 04:39:18.250-0500 I/efl-extension( 1125): efl_extension_rotary.c: _object_deleted_cb(601) > done
02-18 04:39:18.250-0500 I/efl-extension( 1125): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
02-18 04:39:18.250-0500 I/efl-extension( 1125): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0xb8998b98 is freed
02-18 04:39:18.250-0500 I/efl-extension( 1125): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
02-18 04:39:18.250-0500 I/efl-extension( 1125): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xb896be50, elm_scroller, func : 0xb6a1e2f9
02-18 04:39:18.250-0500 I/efl-extension( 1125): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
02-18 04:39:18.260-0500 I/efl-extension( 1125): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
02-18 04:39:18.260-0500 I/efl-extension( 1125): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xb8986ab0, elm_image, func : 0xb6a1e2f9
02-18 04:39:18.260-0500 I/efl-extension( 1125): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
02-18 04:39:18.260-0500 I/efl-extension( 1125): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0xb896be50 : elm_scroller] rotary callabck is deleted
02-18 04:39:18.280-0500 W/PROCESSMGR(  668): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
02-18 04:39:18.280-0500 W/W_HOME  ( 1163): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
02-18 04:39:18.280-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 04:39:18.280-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 04:39:18.280-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 04:39:18.280-0500 W/W_HOME  ( 1163): main.c: _ecore_x_message_cb(1233) > main_info.is_win_on_top: 1
02-18 04:39:18.280-0500 W/GESTURE (  249): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
02-18 04:39:18.290-0500 W/WATCH_CORE( 1240): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
02-18 04:39:18.290-0500 I/WATCH_CORE( 1240): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
02-18 04:39:18.290-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:18.290-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:18.330-0500 W/APP_CORE( 1125): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:1c00020
02-18 04:39:18.330-0500 I/APP_CORE( 1125): appcore-efl.c: __do_app(429) > [APP 1125] Event: PAUSE State: RUNNING
02-18 04:39:18.330-0500 I/CAPI_APPFW_APPLICATION( 1125): app_main.c: app_appcore_pause(202) > app_appcore_pause
02-18 04:39:18.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:18.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:18.600-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:18.600-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:18.810-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:18.810-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:19.010-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:19.010-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:19.210-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:19.210-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:19.410-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:19.410-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:19.510-0500 I/APP_CORE( 6307): appcore-efl.c: __do_app(429) > [APP 6307] Event: MEM_FLUSH State: PAUSED
02-18 04:39:19.610-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:19.610-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:19.810-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:19.810-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:20.010-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:20.010-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:20.210-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:20.210-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:20.410-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:20.410-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:20.610-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:20.610-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:20.810-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:20.810-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:21.010-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:21.010-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:21.210-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:21.210-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:21.410-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:21.410-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:21.610-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:21.610-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:21.810-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:21.810-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:22.010-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:22.010-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:22.210-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:22.210-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:22.410-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:22.410-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:22.610-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:22.610-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:22.810-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:22.810-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:23.010-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:23.010-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:23.210-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:23.210-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:23.340-0500 I/APP_CORE( 1125): appcore-efl.c: __do_app(429) > [APP 1125] Event: MEM_FLUSH State: PAUSED
02-18 04:39:23.410-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:23.410-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:23.610-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:23.610-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:23.810-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:23.810-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:24.010-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:24.010-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:24.210-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:24.210-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:24.410-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:24.410-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:24.610-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:24.610-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:24.810-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:24.810-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:25.010-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:25.010-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:25.210-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:25.210-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:25.410-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:25.410-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:25.600-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:25.600-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:25.800-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:25.800-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:26.000-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:26.000-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:26.200-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:26.210-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:26.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:26.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:26.610-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:26.610-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:26.810-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:26.810-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:27.010-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:27.010-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:27.210-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:27.210-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:27.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:27.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:27.600-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:27.600-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:27.800-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:27.800-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:27.880-0500 W/WATCH_CORE( 1240): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 2
02-18 04:39:27.880-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : -1216381368[0;m
02-18 04:39:27.880-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
02-18 04:39:27.880-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
02-18 04:39:27.880-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 0
02-18 04:39:27.880-0500 I/WATCH_CORE( 1240): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
02-18 04:39:27.880-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:27.880-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:27.890-0500 W/W_HOME  ( 1163): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
02-18 04:39:27.900-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 04:39:27.900-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupServiceStart(395) > [0;32mINFO: 500[0;m
02-18 04:39:27.900-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 500
02-18 04:39:27.900-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 04:39:27.900-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Enable start
02-18 04:39:27.910-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Enable end. (ret: 0x0)
02-18 04:39:27.910-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-18 04:39:27.910-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
02-18 04:39:27.920-0500 I/HIGEAR  ( 1580): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
02-18 04:39:28.000-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:28.000-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:28.200-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:28.200-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:28.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:28.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:28.600-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:28.600-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:28.800-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:28.800-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:29.010-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:29.010-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:29.190-0500 E/PKGMGR  ( 6611): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
02-18 04:39:29.200-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:29.200-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:29.330-0500 E/PKGMGR_SERVER( 6613): pkgmgr-server.c: main(2131) > package manager server start
02-18 04:39:29.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:29.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:29.420-0500 E/PKGMGR_SERVER( 6613): pkgmgr-server.c: req_cb(650) > req_id=[org.example.metronomo_-829899341], req_type=[1], pkg_type=[rpm], pkgid=[org.example.metronomo], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.metronomo_-829899341' '-r' 'org.example.metronomo'], cookie=[eblZgcAdJ3fg7hCt5QG8krXBYNE=], backend_flag=[0]
02-18 04:39:29.420-0500 E/PKGMGR  ( 6613): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.metronomo]
02-18 04:39:29.420-0500 E/PKGMGR_SERVER( 6613): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.metronomo 
02-18 04:39:29.420-0500 E/PKGMGR  ( 6611): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[66110002]
02-18 04:39:29.420-0500 E/PKGMGR_SERVER( 6614): pkgmgr-server.c: queue_job(1815) > INSTALL start, pkg path=[org.example.metronomo]
02-18 04:39:29.570-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, STARTED]
02-18 04:39:29.580-0500 W/AUL_AMD (  934): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
02-18 04:39:29.580-0500 W/W_HOME  ( 1163): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.metronomo is being updateded:0
02-18 04:39:29.590-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
02-18 04:39:29.600-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:29.600-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:29.740-0500 W/CERT_SVC( 6614): DUID.cpp: CheckCertifiedDevice(675) > No device id on distributor certificate
02-18 04:39:29.790-0500 E/PKGMGR_CERT( 6614): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
02-18 04:39:29.790-0500 E/PKGMGR_CERT( 6614): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 101
02-18 04:39:29.800-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
02-18 04:39:29.800-0500 E/PKGMGR_CERT( 6614): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 101
02-18 04:39:29.800-0500 E/PKGMGR_CERT( 6614): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 1
02-18 04:39:29.800-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:29.800-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:29.800-0500 E/PKGMGR_CERT( 6614): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 1
02-18 04:39:29.800-0500 E/PKGMGR_CERT( 6614): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 1
02-18 04:39:29.800-0500 E/PKGMGR_CERT( 6614): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 26 1
02-18 04:39:29.830-0500 E/PKGMGR_CERT( 6614): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
02-18 04:39:29.990-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 6471
02-18 04:39:30.000-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:30.000-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:30.110-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 6308
02-18 04:39:30.200-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:30.200-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:30.260-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 6309
02-18 04:39:30.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:30.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:30.450-0500 E/EFL     ( 6616): elementary<6616> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 04:39:30.470-0500 E/EFL     ( 6616): elementary<6616> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 04:39:30.510-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 6615
02-18 04:39:30.520-0500 E/EFL     ( 6616): elementary<6616> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 04:39:30.520-0500 E/EFL     ( 6616): elementary<6616> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 04:39:30.560-0500 E/EFL     ( 6616): elementary<6616> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 04:39:30.560-0500 E/EFL     ( 6616): elementary<6616> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 04:39:30.560-0500 E/EFL     ( 6616): elementary<6616> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 04:39:30.560-0500 E/EFL     ( 6616): elementary<6616> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 04:39:30.570-0500 E/EFL     ( 6616): elementary<6616> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 04:39:30.590-0500 E/EFL     ( 6616): elementary<6616> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 04:39:30.590-0500 E/EFL     ( 6616): elementary<6616> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 04:39:30.600-0500 E/EFL     ( 6616): elementary<6616> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 04:39:30.600-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:30.600-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:30.630-0500 E/EFL     ( 6616): elementary<6616> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 04:39:30.630-0500 E/EFL     ( 6616): elementary<6616> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 04:39:30.630-0500 E/EFL     ( 6616): elementary<6616> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 04:39:30.630-0500 E/EFL     ( 6616): elementary<6616> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 04:39:30.630-0500 E/EFL     ( 6616): elementary<6616> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 04:39:30.630-0500 E/EFL     ( 6616): elementary<6616> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 04:39:30.630-0500 E/EFL     ( 6616): elementary<6616> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 04:39:30.630-0500 I/AUL_PAD ( 6616): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
02-18 04:39:30.800-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:30.800-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:30.850-0500 I/efl-extension( 6617): efl_extension.c: eext_mod_init(40) > Init
02-18 04:39:30.880-0500 E/EFL     ( 6617): elementary<6617> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 04:39:30.880-0500 E/EFL     ( 6617): elementary<6617> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 04:39:30.910-0500 E/EFL     ( 6617): elementary<6617> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 04:39:30.910-0500 I/UXT     ( 6617): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
02-18 04:39:30.910-0500 E/EFL     ( 6617): elementary<6617> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 04:39:30.960-0500 E/EFL     ( 6617): elementary<6617> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 04:39:30.960-0500 E/EFL     ( 6617): elementary<6617> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 04:39:30.960-0500 E/EFL     ( 6617): elementary<6617> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 04:39:30.960-0500 E/EFL     ( 6617): elementary<6617> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 04:39:30.960-0500 E/EFL     ( 6617): elementary<6617> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 04:39:30.990-0500 E/EFL     ( 6617): elementary<6617> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 04:39:30.990-0500 E/EFL     ( 6617): elementary<6617> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 04:39:30.990-0500 E/EFL     ( 6617): elementary<6617> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 04:39:31.000-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:31.000-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:31.030-0500 E/EFL     ( 6617): elementary<6617> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 04:39:31.070-0500 E/EFL     ( 6617): elementary<6617> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 04:39:31.070-0500 E/EFL     ( 6617): elementary<6617> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 04:39:31.070-0500 E/EFL     ( 6617): elementary<6617> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 04:39:31.070-0500 E/EFL     ( 6617): elementary<6617> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 04:39:31.070-0500 E/EFL     ( 6617): elementary<6617> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 04:39:31.070-0500 E/EFL     ( 6617): elementary<6617> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 04:39:31.070-0500 I/AUL_PAD ( 6617): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
02-18 04:39:31.130-0500 I/Adreno-EGL( 6617): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
02-18 04:39:31.130-0500 I/Adreno-EGL( 6617): OpenGL ES Shader Compiler Version: E031.24.00.16
02-18 04:39:31.130-0500 I/Adreno-EGL( 6617): Build Date: 09/02/15 Wed
02-18 04:39:31.130-0500 I/Adreno-EGL( 6617): Local Branch: 
02-18 04:39:31.130-0500 I/Adreno-EGL( 6617): Remote Branch: 
02-18 04:39:31.130-0500 I/Adreno-EGL( 6617): Local Patches: 
02-18 04:39:31.130-0500 I/Adreno-EGL( 6617): Reconstruct Branch: 
02-18 04:39:31.200-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:31.200-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:31.290-0500 E/PKGMGR_SERVER( 6613): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
02-18 04:39:31.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:31.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:31.400-0500 W/WATCH_CORE( 1240): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 2
02-18 04:39:31.400-0500 I/WATCH_CORE( 1240): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
02-18 04:39:31.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:31.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:31.400-0500 W/W_HOME  ( 1163): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
02-18 04:39:31.410-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : -1216381368[0;m
02-18 04:39:31.410-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
02-18 04:39:31.410-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
02-18 04:39:31.410-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 0
02-18 04:39:31.410-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 04:39:31.410-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupServiceStart(395) > [0;32mINFO: 500[0;m
02-18 04:39:31.410-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 500
02-18 04:39:31.500-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 04:39:31.500-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Enable start
02-18 04:39:31.540-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Enable end. (ret: 0x0)
02-18 04:39:31.540-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-18 04:39:31.540-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
02-18 04:39:31.540-0500 I/HIGEAR  ( 1580): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
02-18 04:39:31.600-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:31.600-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:31.800-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:31.800-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:31.860-0500 E/rpm-installer( 6614): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
02-18 04:39:32.000-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:32.000-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:32.040-0500 W/MM_CAMCORDER( 6618): mm_camcorder_internal.c: _mmcamcorder_constructor(204) >  start
02-18 04:39:32.040-0500 W/MM_CAMCORDER( 6618): mm_camcorder_internal.c: _mmcamcorder_constructor(214) >  done
02-18 04:39:32.050-0500 I/efl-extension( 6618): efl_extension.c: eext_mod_init(40) > Init
02-18 04:39:32.200-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:32.200-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:32.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:32.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:32.600-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:32.600-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:32.800-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:32.800-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:32.890-0500 I/AUL     ( 6618): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 04:39:32.920-0500 I/AUL     ( 6618): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 04:39:32.920-0500 E/AUL     ( 6618): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-18 04:39:32.920-0500 E/AUL     ( 6618): aul_path.c: __get_path(169) > root_path is NULL!
02-18 04:39:32.950-0500 I/AUL     ( 6618): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 04:39:32.970-0500 I/AUL     ( 6618): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 04:39:32.990-0500 E/AUL     ( 6618): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-18 04:39:32.990-0500 E/AUL     ( 6618): aul_path.c: __get_path(169) > root_path is NULL!
02-18 04:39:32.990-0500 E/EFL     ( 6618): elementary<6618> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 04:39:32.990-0500 E/EFL     ( 6618): elementary<6618> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 04:39:33.000-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:33.000-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:33.010-0500 E/EFL     ( 6618): elementary<6618> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 04:39:33.010-0500 I/UXT     ( 6618): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
02-18 04:39:33.010-0500 E/EFL     ( 6618): elementary<6618> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 04:39:33.050-0500 E/EFL     ( 6618): elementary<6618> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 04:39:33.050-0500 E/EFL     ( 6618): elementary<6618> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 04:39:33.050-0500 E/EFL     ( 6618): elementary<6618> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 04:39:33.050-0500 E/EFL     ( 6618): elementary<6618> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 04:39:33.050-0500 E/EFL     ( 6618): elementary<6618> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 04:39:33.080-0500 E/EFL     ( 6618): elementary<6618> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 04:39:33.080-0500 E/EFL     ( 6618): elementary<6618> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 04:39:33.080-0500 E/EFL     ( 6618): elementary<6618> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 04:39:33.110-0500 E/EFL     ( 6618): elementary<6618> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 04:39:33.120-0500 E/EFL     ( 6618): elementary<6618> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 04:39:33.120-0500 E/EFL     ( 6618): elementary<6618> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 04:39:33.120-0500 E/EFL     ( 6618): elementary<6618> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 04:39:33.120-0500 E/EFL     ( 6618): elementary<6618> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 04:39:33.120-0500 E/EFL     ( 6618): elementary<6618> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 04:39:33.120-0500 E/EFL     ( 6618): elementary<6618> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 04:39:33.150-0500 I/Adreno-EGL( 6618): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
02-18 04:39:33.150-0500 I/Adreno-EGL( 6618): OpenGL ES Shader Compiler Version: E031.24.00.16
02-18 04:39:33.150-0500 I/Adreno-EGL( 6618): Build Date: 09/02/15 Wed
02-18 04:39:33.150-0500 I/Adreno-EGL( 6618): Local Branch: 
02-18 04:39:33.150-0500 I/Adreno-EGL( 6618): Remote Branch: 
02-18 04:39:33.150-0500 I/Adreno-EGL( 6618): Local Patches: 
02-18 04:39:33.150-0500 I/Adreno-EGL( 6618): Reconstruct Branch: 
02-18 04:39:33.200-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:33.200-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:33.210-0500 W/Adreno-ES20( 6618): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:39:33.210-0500 W/Adreno-ES20( 6618): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:39:33.210-0500 W/Adreno-ES20( 6618): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:39:33.220-0500 W/Adreno-ES20( 6618): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:39:33.220-0500 W/Adreno-ES20( 6618): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:39:33.220-0500 W/Adreno-ES20( 6618): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:39:33.220-0500 W/Adreno-ES20( 6618): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:39:33.220-0500 W/Adreno-ES20( 6618): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:39:33.220-0500 W/Adreno-ES20( 6618): <get_simple_queries:1550>: GL_INVALID_ENUM
02-18 04:39:33.290-0500 E/PKGMGR_SERVER( 6613): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
02-18 04:39:33.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:33.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:33.600-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:33.600-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:33.800-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:33.800-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:34.000-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:34.000-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:34.200-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:34.200-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:34.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:34.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:34.600-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:34.600-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:34.800-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:34.800-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:35.000-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:35.000-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:35.200-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:35.200-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:35.250-0500 E/PKGMGR_SERVER( 6613): pkgmgr-server.c: sighandler(409) > child NORMAL exit [6614]
02-18 04:39:35.260-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
02-18 04:39:35.290-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, COMPLETED]
02-18 04:39:35.290-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6946) > package install complete
02-18 04:39:35.290-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_package_install_event(4818) > 
02-18 04:39:35.290-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1758) > Found in install_req_list?[0], index[-1]
02-18 04:39:35.290-0500 E/PKGMGR_SERVER( 6613): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
02-18 04:39:35.290-0500 E/PKGMGR_SERVER( 6613): pkgmgr-server.c: main(2185) > package manager server terminated.
02-18 04:39:35.310-0500 W/W_HOME  ( 1163): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.example.metronomo is updated, need to check validation
02-18 04:39:35.330-0500 W/W_HOME  ( 1163): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:com.samsung.watchface
02-18 04:39:35.390-0500 E/STARTER ( 1109): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
02-18 04:39:35.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:35.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:35.450-0500 W/APPS    ( 1163): pkgmgr.c: _update_app(739) >  old order:[25]
02-18 04:39:35.470-0500 E/PKGMGR_INFO(  898): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
02-18 04:39:35.550-0500 E/EFL     ( 1163): elementary<1163> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0xb78abaf0 into part 'elm.swallow.event.0'
02-18 04:39:35.550-0500 E/APPS    ( 1163): AppsViewNecklace.cpp: onShow(597) >  AppsItemList[26]
02-18 04:39:35.600-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:35.600-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:35.620-0500 E/Vi::Animations( 1163): result Vi::Animations::_AnimationManager::addAnimation(Vi::Animations::Visual&, const string*, Vi::Animations::Animation&)(288) > [E_OBJ_ALREADY_EXIST] Animation with keyName already exists. key name = hide
02-18 04:39:35.620-0500 I/Vi::Animations( 1163): result Vi::Animations::_VisualImpl::addAnimation(const string*, Vi::Animations::Animation&)(6999) > [E_OBJ_ALREADY_EXIST] Propagating.
02-18 04:39:35.630-0500 E/EFL     ( 1163): elementary<1163> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0xb78abaf0 into part 'elm.swallow.event.0'
02-18 04:39:35.640-0500 E/APPS    ( 1163): AppsViewNecklace.cpp: onShow(597) >  AppsItemList[27]
02-18 04:39:35.800-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:35.800-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:36.000-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:36.000-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:36.140-0500 W/APPS    ( 1163): pkgmgr.c: _update_app_cb(718) >  Update apps order
02-18 04:39:36.140-0500 W/APPS    ( 1163): AppsViewNecklace.cpp: onTouchEventCancel(4360) >  touch cancel
02-18 04:39:36.200-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:36.200-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:36.260-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 0
02-18 04:39:36.270-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
02-18 04:39:36.280-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
02-18 04:39:36.280-0500 E/AUL_AMD (  934): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
02-18 04:39:36.280-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(1708) > caller pid : 6681
02-18 04:39:36.300-0500 W/AUL_AMD (  934): amd_launch.c: __nofork_processing(1151) > __nofork_processing, cmd: 0, pid: 6307
02-18 04:39:36.300-0500 I/APP_CORE( 6307): appcore-efl.c: __do_app(429) > [APP 6307] Event: RESET State: PAUSED
02-18 04:39:36.300-0500 I/CAPI_APPFW_APPLICATION( 6307): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
02-18 04:39:36.300-0500 W/AUL_AMD (  934): amd_launch.c: __reply_handler(922) > listen fd(21) , send fd(20), pid(6307), cmd(0)
02-18 04:39:36.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:39:36.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:39:36.500-0500 W/CRASH_MANAGER( 6682): worker.c: worker_job(1199) > 11063076d6574148741077
