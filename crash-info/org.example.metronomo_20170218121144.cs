S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.5
Build-Number: R730VVRU2BPC7
Build-Date: 2016.04.01 13:23:02

Crash Information
Process Name: metronomo
PID: 13200
Date: 2017-02-18 12:11:44-0500
Executable File Path: /opt/usr/apps/org.example.metronomo/bin/metronomo
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xc

Register Information
r0   = 0x00000001, r1   = 0x0000037c
r2   = 0x00000000, r3   = 0xb6f48788
r4   = 0xb6f56b18, r5   = 0x00000140
r6   = 0x00000000, r7   = 0xb6fcd0ad
r8   = 0x00000000, r9   = 0x00000000
r10  = 0xb6fdda2c, fp   = 0x00000000
ip   = 0xb6f3770d, sp   = 0xbef8a508
lr   = 0xb6f37745, pc   = 0xb6f3006a
cpsr = 0x60000030

Memory Information
MemTotal:   389300 KB
MemFree:      7376 KB
Buffers:      3788 KB
Cached:      85468 KB
VmPeak:      51076 KB
VmSize:      51072 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7428 KB
VmRSS:        7428 KB
VmData:       2540 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:       21780 KB
VmPTE:          36 KB
VmSwap:          0 KB

Maps Information
b3fa5000 b406f000 r-xp /usr/lib/libCOREGL.so.4.0
b4087000 b408a000 r-xp /lib/libattr.so.1.1.0
b4092000 b4099000 r-xp /lib/libcrypt-2.13.so
b40c9000 b40cc000 r-xp /lib/libcap.so.2.21
b40d4000 b40d6000 r-xp /usr/lib/libiri.so
b40df000 b40fc000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4105000 b410e000 r-xp /usr/lib/libresourced.so.0.2.86
b4116000 b4117000 r-xp /usr/lib/librd-network.so.0.2.86
b411f000 b412c000 r-xp /usr/lib/libail.so.0.1.0
b4135000 b413c000 r-xp /usr/lib/libminizip.so.1.0.0
b4145000 b4172000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b417a000 b417c000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b4184000 b418b000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b4194000 b41b0000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b41b9000 b41c1000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
b41ca000 b41d0000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b41d8000 b41dd000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
b41e5000 b4206000 r-xp /usr/lib/libexif.so.12.3.3
b4219000 b4232000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
b423b000 b423e000 r-xp /usr/lib/libsmack.so.1.0.0
b4246000 b424b000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4253000 b4258000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b57e8000 b57f3000 r-xp /usr/lib/libgpg-error.so.0.15.0
b57fc000 b59a4000 r-xp /usr/lib/libcrypto.so.1.0.0
b59bd000 b5a0a000 r-xp /usr/lib/libssl.so.1.0.0
b5a16000 b5a44000 r-xp /usr/lib/libidn.so.11.5.44
b5a4c000 b5a55000 r-xp /usr/lib/libcares.so.2.1.0
b5a5e000 b5a60000 r-xp /usr/lib/libXau.so.6.0.0
b5a69000 b5a6b000 r-xp /usr/lib/libdri2.so.0.0.0
b5a73000 b5a7b000 r-xp /usr/lib/libdrm.so.2.4.0
b5a83000 b5b17000 r-xp /usr/lib/libstdc++.so.6.0.16
b5b2a000 b5b2b000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b5b34000 b5b37000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
b5b40000 b5c24000 r-xp /usr/lib/libicuuc.so.51.1
b5c39000 b5d76000 r-xp /usr/lib/libicui18n.so.51.1
b5d86000 b5d88000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5d90000 b5d92000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5d9c000 b5e18000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5e24000 b5e3c000 r-xp /usr/lib/liblzma.so.5.0.3
b5e44000 b5e4a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b5e53000 b5e97000 r-xp /usr/lib/libcurl.so.4.3.0
b5ea1000 b5ec4000 r-xp /usr/lib/libjpeg.so.8.0.2
b5edc000 b5eef000 r-xp /usr/lib/libxcb.so.1.1.0
b5ef8000 b5efe000 r-xp /usr/lib/libxcb-render.so.0.0.0
b5f06000 b5f07000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b5f10000 b5f28000 r-xp /usr/lib/libpng12.so.0.50.0
b5f31000 b5f34000 r-xp /usr/lib/libEGL.so.1.4
b5f3c000 b5f4a000 r-xp /usr/lib/libGLESv2.so.2.0
b5f53000 b5f54000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5f5c000 b5f73000 r-xp /usr/lib/liblua-5.1.so
b5f7c000 b5f83000 r-xp /usr/lib/libembryo.so.1.7.99
b5f8c000 b5f93000 r-xp /usr/lib/libtbm.so.1.0.0
b5f9b000 b5fbc000 r-xp /usr/lib/libui-extension.so.0.1.0
b5fc5000 b5fd7000 r-xp /usr/lib/libtts.so
b5fdf000 b5ff5000 r-xp /lib/libexpat.so.1.5.2
b5fff000 b6002000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b600b000 b600f000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6018000 b601d000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6026000 b6030000 r-xp /usr/lib/libXext.so.6.4.0
b6039000 b603d000 r-xp /usr/lib/libXtst.so.6.1.0
b6045000 b604b000 r-xp /usr/lib/libXrender.so.1.3.0
b6054000 b605a000 r-xp /usr/lib/libXrandr.so.2.2.0
b6062000 b6063000 r-xp /usr/lib/libXinerama.so.1.0.0
b606c000 b606f000 r-xp /usr/lib/libXfixes.so.3.1.0
b6077000 b6079000 r-xp /usr/lib/libXgesture.so.7.0.0
b6081000 b6083000 r-xp /usr/lib/libXcomposite.so.1.0.0
b608b000 b608d000 r-xp /usr/lib/libXdamage.so.1.1.0
b6096000 b609d000 r-xp /usr/lib/libXcursor.so.1.0.2
b60a5000 b60b5000 r-xp /lib/libresolv-2.13.so
b60b9000 b60cf000 r-xp /lib/libz.so.1.2.5
b60d7000 b60d9000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b60e1000 b60e6000 r-xp /usr/lib/libffi.so.5.0.10
b60ef000 b60f0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b60f8000 b616d000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6177000 b618d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6195000 b6198000 r-xp /usr/lib/libproc-stat.so.0.2.86
b61a0000 b61dc000 r-xp /usr/lib/libsystemd.so.0.4.0
b61e6000 b61eb000 r-xp /usr/lib/libxdgmime.so.1.1.0
b61f3000 b620a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6212000 b6214000 r-xp /usr/lib/libiniparser.so.0
b621d000 b6223000 r-xp /usr/lib/libecore_imf.so.1.7.99
b622b000 b622e000 r-xp /usr/lib/libbundle.so.0.1.22
b6237000 b623d000 r-xp /usr/lib/libappsvc.so.0.1.0
b6245000 b629b000 r-xp /usr/lib/libpixman-1.so.0.28.2
b62a8000 b62fe000 r-xp /usr/lib/libfreetype.so.6.11.3
b630a000 b6347000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6350000 b6363000 r-xp /usr/lib/libfribidi.so.0.3.1
b636c000 b6386000 r-xp /usr/lib/libecore_con.so.1.7.99
b638f000 b63b9000 r-xp /usr/lib/libdbus-1.so.3.8.12
b63c2000 b63cb000 r-xp /usr/lib/libedbus.so.1.7.99
b63d3000 b63e4000 r-xp /usr/lib/libecore_input.so.1.7.99
b63ec000 b63f1000 r-xp /usr/lib/libecore_file.so.1.7.99
b63f9000 b6412000 r-xp /usr/lib/libeet.so.1.7.99
b6424000 b642d000 r-xp /usr/lib/libXi.so.6.1.0
b6435000 b6516000 r-xp /usr/lib/libX11.so.6.3.0
b6521000 b65d9000 r-xp /usr/lib/libcairo.so.2.11200.14
b65e4000 b6641000 r-xp /usr/lib/libedje.so.1.7.99
b664b000 b66b4000 r-xp /lib/libm-2.13.so
b66be000 b66c4000 r-xp /lib/librt-2.13.so
b66cd000 b66df000 r-xp /usr/lib/libefl-assist.so.0.1.0
b66e7000 b67b3000 r-xp /usr/lib/libxml2.so.2.7.8
b67c0000 b67e8000 r-xp /usr/lib/libfontconfig.so.1.8.0
b67e9000 b680b000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6815000 b6865000 r-xp /usr/lib/libecore_x.so.1.7.99
b6867000 b6937000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6938000 b696c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6975000 b6a48000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6a53000 b6a58000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6a60000 b6a64000 r-xp /usr/lib/libvconf.so.0.2.45
b6a6c000 b6a80000 r-xp /lib/libpthread-2.13.so
b6a8b000 b6acc000 r-xp /usr/lib/libeina.so.1.7.99
b6ad5000 b6af7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6aff000 b6b0b000 r-xp /usr/lib/libaul.so.0.1.0
b6b15000 b6b1a000 r-xp /usr/lib/libappcore-common.so.1.1
b6b22000 b6b27000 r-xp /usr/lib/libappcore-efl.so.1.1
b6b2f000 b6b31000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b6b3a000 b6b3e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b6b47000 b6b49000 r-xp /lib/libdl-2.13.so
b6b52000 b6b5d000 r-xp /lib/libunwind.so.8.0.1
b6b8a000 b6b92000 r-xp /lib/libgcc_s-4.6.so.1
b6b93000 b6cae000 r-xp /lib/libc-2.13.so
b6cbc000 b6d8a000 r-xp /usr/lib/libevas.so.1.7.99
b6daf000 b6eea000 r-xp /usr/lib/libelementary.so.1.7.99
b6f00000 b6f21000 r-xp /usr/lib/libefl-extension.so.0.1.0
b6f29000 b6f40000 r-xp /usr/lib/libecore.so.1.7.99
b6f57000 b6f59000 r-xp /usr/lib/libdlog.so.0.0.0
b6f61000 b6f69000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b6f6a000 b6f6f000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b6f77000 b6f7b000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b6f99000 b6f9d000 r-xp /usr/lib/libsys-assert.so
b6fa6000 b6fc3000 r-xp /lib/ld-2.13.so
b6fcc000 b6fce000 r-xp /opt/usr/apps/org.example.metronomo/bin/metronomo
b75bb000 b75fd000 rw-p [heap]
bef6a000 bef8b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13200)
Call Stack Count: 5
 0: (0xb6f3006a) [/usr/lib/libecore.so.1] + 0x706a
 1: ecore_timer_add + 0x38 (0xb6f37745) [/usr/lib/libecore.so.1] + 0xe745
 2: main + 0x92 (0xb6fcd25b) [/opt/usr/apps/org.example.metronomo/bin/metronomo] + 0x125b
 3: __libc_start_main + 0x114 (0xb6baa82c) [/lib/libc.so.6] + 0x1782c
 4: (0xb6fccf24) [/opt/usr/apps/org.example.metronomo/bin/metronomo] + 0xf24
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
7) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
02-18 12:11:38.379-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
02-18 12:11:38.379-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: preference_get_double(1214) > preference_get_double(1631) : pedometer_inactive_period error
02-18 12:11:38.379-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
02-18 12:11:38.379-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-18 12:11:38.379-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: preference_get_double(1214) > preference_get_double(1631) : inactive_10min_precaution_millisec error
02-18 12:11:38.379-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
02-18 12:11:38.379-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-18 12:11:38.379-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: preference_get_double(1214) > preference_get_double(1631) : inactive_before_10min_precaution_millisec error
02-18 12:11:38.529-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:38.529-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:38.629-0500 W/WATCH_CORE( 1242): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 2
02-18 12:11:38.629-0500 I/WATCH_CORE( 1242): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
02-18 12:11:38.629-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:38.629-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:38.649-0500 W/WATCH_CORE( 1242): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
02-18 12:11:38.649-0500 W/STARTER ( 1102): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [gesture]
02-18 12:11:38.649-0500 W/STARTER ( 1102): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
02-18 12:11:38.649-0500 E/STARTER ( 1102): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
02-18 12:11:38.649-0500 W/STARTER ( 1102): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
02-18 12:11:38.649-0500 W/STARTER ( 1102): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
02-18 12:11:38.649-0500 W/WAKEUP-SERVICE( 1594): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : -1226986740[0;m
02-18 12:11:38.649-0500 W/WAKEUP-SERVICE( 1594): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
02-18 12:11:38.649-0500 W/WAKEUP-SERVICE( 1594): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
02-18 12:11:38.659-0500 I/TIZEN_N_SOUND_MANAGER( 1594): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Disable start
02-18 12:11:38.659-0500 I/TIZEN_N_SOUND_MANAGER( 1594): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Disable end. (ret: 0x0)
02-18 12:11:38.659-0500 W/TIZEN_N_SOUND_MANAGER( 1594): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-18 12:11:38.659-0500 W/WAKEUP-SERVICE( 1594): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
02-18 12:11:38.659-0500 I/HIGEAR  ( 1594): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
02-18 12:11:38.699-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:38.699-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:38.799-0500 E/PKGMGR_SERVER(13115): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
02-18 12:11:38.799-0500 E/PKGMGR_SERVER(13115): pkgmgr-server.c: main(2185) > package manager server terminated.
02-18 12:11:38.839-0500 W/MUSIC_CONTROL_SERVICE( 1312): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1312]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
02-18 12:11:38.839-0500 W/APPS    ( 1180): pkgmgr.c: _update_app_cb(718) >  Update apps order
02-18 12:11:38.839-0500 W/APPS    ( 1180): AppsViewNecklace.cpp: onTouchEventCancel(4360) >  touch cancel
02-18 12:11:38.849-0500 I/SHealth_Common( 1631): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
02-18 12:11:38.849-0500 I/SHealth_Service( 1631): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
02-18 12:11:38.879-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:38.879-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:38.889-0500 W/STARTER ( 1102): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [gesture]
02-18 12:11:38.889-0500 W/STARTER ( 1102): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
02-18 12:11:38.889-0500 W/STARTER ( 1102): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
02-18 12:11:38.889-0500 W/STARTER ( 1102): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[1]
02-18 12:11:38.909-0500 W/W_HOME  ( 1180): dbus.c: _dbus_message_recv_cb(204) > LCD off
02-18 12:11:38.909-0500 W/W_HOME  ( 1180): gesture.c: _manual_render_disable_timer_del(151) > timer del
02-18 12:11:38.909-0500 W/W_HOME  ( 1180): gesture.c: _manual_render_enable(133) > 1
02-18 12:11:38.909-0500 W/W_HOME  ( 1180): event_manager.c: _lcd_off_cb(699) > lcd state: 0
02-18 12:11:38.909-0500 W/W_HOME  ( 1180): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 12:11:38.909-0500 I/APP_CORE( 1180): appcore-efl.c: __do_app(429) > [APP 1180] Event: PAUSE State: RUNNING
02-18 12:11:38.909-0500 I/CAPI_APPFW_APPLICATION( 1180): app_main.c: app_appcore_pause(202) > app_appcore_pause
02-18 12:11:38.909-0500 W/W_HOME  ( 1180): main.c: _appcore_pause_cb(692) > appcore pause
02-18 12:11:38.909-0500 W/W_HOME  ( 1180): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
02-18 12:11:38.909-0500 W/W_HOME  ( 1180): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 12:11:38.909-0500 W/W_HOME  ( 1180): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 12:11:38.909-0500 W/W_HOME  ( 1180): main.c: home_pause(762) > clock/widget paused
02-18 12:11:38.909-0500 W/W_HOME  ( 1180): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 12:11:38.909-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 12:11:38.909-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 12:11:38.909-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 12:11:38.909-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 12:11:38.909-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 12:11:38.909-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 12:11:38.909-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 12:11:38.909-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 12:11:38.919-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 12:11:38.919-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 12:11:38.919-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 12:11:38.919-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 12:11:38.919-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 12:11:38.919-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 12:11:38.919-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 12:11:38.919-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 12:11:38.919-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 12:11:38.919-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 12:11:38.919-0500 E/CAPI_APPFW_APP_CONTROL( 1312): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
02-18 12:11:38.919-0500 W/MUSIC_CONTROL_SERVICE( 1312): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1312]   [com.samsung.w-home]register msg port [false][0m
02-18 12:11:38.919-0500 W/GESTURE (  258): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
02-18 12:11:38.959-0500 W/WATCH_CORE( 1242): appcore-watch.c: __widget_pause(1001) > widget_pause
02-18 12:11:38.959-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppPause(713) > 
02-18 12:11:38.959-0500 E/watchface-viewer( 1242): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 12:11:38.959-0500 E/watchface-viewer( 1242): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 12:11:38.959-0500 E/watchface-viewer( 1242): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 12:11:38.959-0500 E/watchface-viewer( 1242): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 12:11:38.989-0500 W/APPS    ( 1180): AppsItem.cpp: onItemBadgeShow(599) >  badge show:[0:1]
02-18 12:11:38.999-0500 W/WAKEUP-SERVICE( 1594): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : -1200554192[0;m
02-18 12:11:38.999-0500 W/WAKEUP-SERVICE( 1594): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
02-18 12:11:38.999-0500 W/WAKEUP-SERVICE( 1594): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
02-18 12:11:38.999-0500 I/TIZEN_N_SOUND_MANAGER( 1594): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 0
02-18 12:11:38.999-0500 W/WATCH_CORE( 1242): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
02-18 12:11:38.999-0500 I/WATCH_CORE( 1242): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
02-18 12:11:39.009-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:39.009-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:39.009-0500 I/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
02-18 12:11:39.019-0500 W/W_HOME  ( 1180): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
02-18 12:11:39.019-0500 W/W_HOME  ( 1180): gesture.c: _manual_render_schedule(211) > schedule, manual render
02-18 12:11:39.019-0500 W/W_HOME  ( 1180): gesture.c: _widget_updated_cb(190) > widget updated
02-18 12:11:39.019-0500 W/W_HOME  ( 1180): gesture.c: _manual_render_disable_timer_del(151) > timer del
02-18 12:11:39.019-0500 W/W_HOME  ( 1180): gesture.c: _manual_render(176) > 
02-18 12:11:39.019-0500 W/wnotibp ( 2913): wnotiboard-popup-view.c: _wnotibp_event_lcd_on_cb(1419) > ::APP:: view state=0, 2, 0
02-18 12:11:39.019-0500 W/WATCH_CORE( 1242): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
02-18 12:11:39.019-0500 I/WATCH_CORE( 1242): appcore-watch.c: __signal_lcd_status_handler(1149) > Call the time_tick_cb
02-18 12:11:39.019-0500 W/TIZEN_N_SOUND_MANAGER( 1594): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 12:11:39.019-0500 W/WAKEUP-SERVICE( 1594): WakeupService.cpp: WakeupServiceStart(395) > [0;32mINFO: 500[0;m
02-18 12:11:39.019-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:39.019-0500 I/TIZEN_N_SOUND_MANAGER( 1594): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 500
02-18 12:11:39.019-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:39.019-0500 I/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
02-18 12:11:39.019-0500 W/STARTER ( 1102): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [gesture] after screen off time [376]ms
02-18 12:11:39.019-0500 W/STARTER ( 1102): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
02-18 12:11:39.029-0500 W/TIZEN_N_SOUND_MANAGER( 1594): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 12:11:39.039-0500 W/W_HOME  ( 1180): gesture.c: _manual_render(176) > 
02-18 12:11:39.039-0500 I/TIZEN_N_SOUND_MANAGER( 1594): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Enable start
02-18 12:11:39.049-0500 W/W_HOME  ( 1180): gesture.c: _manual_render_enable(133) > 0
02-18 12:11:39.049-0500 I/APP_CORE( 1180): appcore-efl.c: __do_app(429) > [APP 1180] Event: RESUME State: PAUSED
02-18 12:11:39.049-0500 I/CAPI_APPFW_APPLICATION( 1180): app_main.c: app_appcore_resume(223) > app_appcore_resume
02-18 12:11:39.049-0500 W/W_HOME  ( 1180): main.c: _appcore_resume_cb(683) > appcore resume
02-18 12:11:39.049-0500 W/W_HOME  ( 1180): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
02-18 12:11:39.049-0500 W/W_HOME  ( 1180): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 12:11:39.059-0500 W/W_HOME  ( 1180): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 12:11:39.059-0500 W/W_HOME  ( 1180): main.c: home_resume(731) > journal_appcore_app_fully_loaded called
02-18 12:11:39.059-0500 W/W_HOME  ( 1180): main.c: home_resume(735) > clock/widget resumed
02-18 12:11:39.059-0500 W/W_HOME  ( 1180): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 12:11:39.059-0500 I/TIZEN_N_SOUND_MANAGER( 1594): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Enable end. (ret: 0x0)
02-18 12:11:39.059-0500 W/GESTURE (  258): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
02-18 12:11:39.069-0500 W/TIZEN_N_SOUND_MANAGER( 1594): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-18 12:11:39.069-0500 W/WAKEUP-SERVICE( 1594): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
02-18 12:11:39.069-0500 I/HIGEAR  ( 1594): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
02-18 12:11:39.069-0500 W/WAKEUP-SERVICE( 1594): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : -1226986740[0;m
02-18 12:11:39.069-0500 W/WAKEUP-SERVICE( 1594): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
02-18 12:11:39.069-0500 W/WAKEUP-SERVICE( 1594): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
02-18 12:11:39.069-0500 I/TIZEN_N_SOUND_MANAGER( 1594): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 0
02-18 12:11:39.069-0500 W/W_HOME  ( 1180): dbus.c: _dbus_message_recv_cb(186) > LCD on
02-18 12:11:39.069-0500 W/W_HOME  ( 1180): gesture.c: _manual_render_disable_timer_set(161) > timer set
02-18 12:11:39.069-0500 W/W_HOME  ( 1180): gesture.c: _manual_render_disable_timer_del(151) > timer del
02-18 12:11:39.069-0500 W/W_HOME  ( 1180): gesture.c: _apps_status_get(123) > apps status:0
02-18 12:11:39.079-0500 W/W_HOME  ( 1180): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:1 info->offtime:376
02-18 12:11:39.079-0500 W/W_HOME  ( 1180): gesture.c: _manual_render_schedule(211) > schedule, manual render
02-18 12:11:39.079-0500 W/W_HOME  ( 1180): event_manager.c: _lcd_on_cb(691) > lcd state: 1
02-18 12:11:39.079-0500 W/W_HOME  ( 1180): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 12:11:39.079-0500 W/W_HOME  ( 1180): gesture.c: _widget_updated_cb(190) > widget updated
02-18 12:11:39.079-0500 W/W_HOME  ( 1180): gesture.c: _manual_render_disable_timer_del(151) > timer del
02-18 12:11:39.079-0500 W/WATCH_CORE( 1242): appcore-watch.c: __widget_resume(1012) > widget_resume
02-18 12:11:39.079-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppResume(721) > 
02-18 12:11:39.079-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:39.079-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:39.079-0500 W/W_HOME  ( 1180): gesture.c: _manual_render(176) > 
02-18 12:11:39.079-0500 W/W_HOME  ( 1180): gesture.c: _manual_render_enable(133) > 0
02-18 12:11:39.089-0500 W/TIZEN_N_SOUND_MANAGER( 1594): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 12:11:39.089-0500 W/WAKEUP-SERVICE( 1594): WakeupService.cpp: WakeupServiceStart(395) > [0;32mINFO: 500[0;m
02-18 12:11:39.089-0500 I/TIZEN_N_SOUND_MANAGER( 1594): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 500
02-18 12:11:39.089-0500 W/TIZEN_N_SOUND_MANAGER( 1594): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 12:11:39.089-0500 I/TIZEN_N_SOUND_MANAGER( 1594): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Enable start
02-18 12:11:39.099-0500 I/TIZEN_N_SOUND_MANAGER( 1594): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Enable end. (ret: 0x0)
02-18 12:11:39.099-0500 W/TIZEN_N_SOUND_MANAGER( 1594): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-18 12:11:39.099-0500 W/WAKEUP-SERVICE( 1594): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
02-18 12:11:39.099-0500 I/HIGEAR  ( 1594): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
02-18 12:11:39.109-0500 W/MUSIC_CONTROL_SERVICE( 1312): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1312]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
02-18 12:11:39.149-0500 W/STARTER ( 1102): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [gesture]
02-18 12:11:39.149-0500 W/STARTER ( 1102): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
02-18 12:11:39.159-0500 I/SHealth_Common( 1631): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
02-18 12:11:39.159-0500 I/SHealth_Service( 1631): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
02-18 12:11:39.199-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
02-18 12:11:39.199-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
02-18 12:11:39.199-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: preference_get_double(1214) > preference_get_double(1631) : pedometer_inactive_period error
02-18 12:11:39.199-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
02-18 12:11:39.199-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-18 12:11:39.199-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: preference_get_double(1214) > preference_get_double(1631) : inactive_10min_precaution_millisec error
02-18 12:11:39.199-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
02-18 12:11:39.199-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-18 12:11:39.199-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: preference_get_double(1214) > preference_get_double(1631) : inactive_before_10min_precaution_millisec error
02-18 12:11:39.259-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:39.259-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:39.449-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:39.449-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:39.639-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:39.639-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:39.829-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:39.829-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:40.019-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:40.019-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:40.059-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 12:11:40.059-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 12:11:40.059-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 12:11:40.059-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 12:11:40.059-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 12:11:40.059-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 12:11:40.059-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 12:11:40.059-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 12:11:40.059-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 12:11:40.059-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 12:11:40.059-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 12:11:40.059-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 12:11:40.059-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 12:11:40.059-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 12:11:40.059-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 12:11:40.059-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 12:11:40.059-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 12:11:40.059-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 12:11:40.059-0500 E/CAPI_APPFW_APP_CONTROL( 1312): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
02-18 12:11:40.059-0500 W/MUSIC_CONTROL_SERVICE( 1312): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1312]   [com.samsung.w-home]register msg port [true][0m
02-18 12:11:40.059-0500 W/AUL_AMD (  937): amd_request.c: __request_handler(646) > __request_handler: 14
02-18 12:11:40.099-0500 W/AUL_AMD (  937): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1180
02-18 12:11:40.109-0500 W/MUSIC_CONTROL_SERVICE( 1312): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1312]   [MUSIC_PLAYER_EVENT][0m
02-18 12:11:40.119-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
02-18 12:11:40.119-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
02-18 12:11:40.119-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: preference_get_int(1132) > preference_get_int(1312) : key(music-control-service_native/playing_diration) error
02-18 12:11:40.119-0500 W/MUSIC_CONTROL_SERVICE( 1312): music-control-info.c: music_control_info_get_player_position(582) > [31m[TID:1312]   preference_get_int() .. [0xfef00030][0m
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 12:11:40.119-0500 W/MUSIC_CONTROL_SERVICE( 1312): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1312]   [MUSIC_PLAYER_EVENT][0m
02-18 12:11:40.119-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
02-18 12:11:40.119-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
02-18 12:11:40.119-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: preference_get_int(1132) > preference_get_int(1312) : key(music-control-service_native/playing_diration) error
02-18 12:11:40.119-0500 W/MUSIC_CONTROL_SERVICE( 1312): music-control-info.c: music_control_info_get_player_position(582) > [31m[TID:1312]   preference_get_int() .. [0xfef00030][0m
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-18 12:11:40.119-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 12:11:40.129-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 12:11:40.129-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 12:11:40.129-0500 I/TIZEN_N_SOUND_MANAGER( 1312): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
02-18 12:11:40.129-0500 W/TIZEN_N_SOUND_MANAGER( 1312): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
02-18 12:11:40.129-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 12:11:40.129-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 12:11:40.129-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 12:11:40.129-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 12:11:40.129-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 12:11:40.129-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 12:11:40.129-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-18 12:11:40.129-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 12:11:40.129-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 12:11:40.129-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 12:11:40.129-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 12:11:40.129-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 12:11:40.129-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 12:11:40.129-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 12:11:40.129-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-18 12:11:40.129-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 12:11:40.129-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 12:11:40.129-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 12:11:40.129-0500 W/W_HOME  ( 1180): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
02-18 12:11:40.129-0500 E/W_HOME  ( 1180): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
02-18 12:11:40.129-0500 W/W_HOME  ( 1180): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
02-18 12:11:40.129-0500 E/W_HOME  ( 1180): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
02-18 12:11:40.219-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:40.219-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:40.409-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:40.409-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:40.609-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:40.609-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:40.809-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:40.809-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:41.009-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:41.009-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:41.209-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:41.209-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:41.399-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:41.399-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:41.599-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:41.599-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:41.799-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:41.799-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:41.999-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:41.999-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:42.199-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:42.199-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:42.399-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:42.399-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:42.599-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:42.599-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:42.799-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:42.799-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:42.999-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:42.999-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:43.199-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:43.199-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:43.399-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:43.399-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:43.599-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:43.599-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:43.799-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:43.799-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:43.909-0500 W/AUL_AMD (  937): amd_request.c: __request_handler(646) > __request_handler: 0
02-18 12:11:43.929-0500 I/AUL_AMD (  937): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
02-18 12:11:43.949-0500 I/AUL_AMD (  937): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
02-18 12:11:43.949-0500 E/AUL_AMD (  937): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
02-18 12:11:43.949-0500 W/AUL_AMD (  937): amd_launch.c: _start_app(1708) > caller pid : 13198
02-18 12:11:43.969-0500 E/RESOURCED(  938): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.metronomo, table num : 1
02-18 12:11:43.969-0500 E/RESOURCED(  938): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
02-18 12:11:43.969-0500 W/AUL_AMD (  937): amd_launch.c: _start_app(2086) > pad pid(-5)
02-18 12:11:43.969-0500 W/AUL_PAD ( 1700): launchpad.c: __launchpad_main_loop(607) > Candidate is not prepared, enter legacy logic
02-18 12:11:43.969-0500 W/AUL_PAD ( 1700): launchpad.c: __send_result_to_caller(272) > Check app launching
02-18 12:11:43.969-0500 W/AUL_AMD (  937): amd_launch.c: _start_app(2097) > Launch with legacy way : no launchpad
02-18 12:11:43.979-0500 W/AUL_AMD (  937): amd_launch.c: start_process(580) > child process: 13200
02-18 12:11:43.999-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:43.999-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:44.029-0500 W/AUL_AMD (  937): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 13200
02-18 12:11:44.039-0500 E/RESOURCED(  938): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.metronomo
02-18 12:11:44.109-0500 W/AUL_AMD (  937): amd_request.c: __request_handler(646) > __request_handler: 14
02-18 12:11:44.119-0500 W/AUL_AMD (  937): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 13200
02-18 12:11:44.139-0500 W/AUL_AMD (  937): amd_request.c: __request_handler(646) > __request_handler: 12
02-18 12:11:44.189-0500 I/efl-extension(13200): efl_extension.c: eext_mod_init(40) > Init
02-18 12:11:44.199-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:44.199-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:44.229-0500 E/EFL     (13199): elementary<13199> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 12:11:44.229-0500 E/EFL     (13199): elementary<13199> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 12:11:44.259-0500 E/EFL     (13199): elementary<13199> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 12:11:44.259-0500 E/EFL     (13199): elementary<13199> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 12:11:44.299-0500 E/EFL     (13199): elementary<13199> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 12:11:44.299-0500 E/EFL     (13199): elementary<13199> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 12:11:44.309-0500 E/EFL     (13199): elementary<13199> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 12:11:44.309-0500 E/EFL     (13199): elementary<13199> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 12:11:44.309-0500 E/EFL     (13199): elementary<13199> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 12:11:44.329-0500 W/AUL_AMD (  937): amd_request.c: __request_handler(646) > __request_handler: 23
02-18 12:11:44.329-0500 W/AUL_AMD (  937): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
02-18 12:11:44.329-0500 W/AUL_AMD (  937): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 13200
02-18 12:11:44.329-0500 W/AUL_AMD (  937): amd_request.c: __send_app_termination_signal(511) > send dead signal done
02-18 12:11:44.329-0500 I/AUL_AMD (  937): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 13200
02-18 12:11:44.359-0500 E/EFL     (13199): elementary<13199> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 12:11:44.359-0500 E/EFL     (13199): elementary<13199> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 12:11:44.359-0500 E/EFL     (13199): elementary<13199> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 12:11:44.399-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 12:11:44.399-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 12:11:44.409-0500 E/EFL     (13199): elementary<13199> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 12:11:44.409-0500 E/EFL     (13199): elementary<13199> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 12:11:44.419-0500 E/EFL     (13199): elementary<13199> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 12:11:44.419-0500 E/EFL     (13199): elementary<13199> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 12:11:44.419-0500 E/EFL     (13199): elementary<13199> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 12:11:44.419-0500 E/EFL     (13199): elementary<13199> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 12:11:44.419-0500 E/EFL     (13199): elementary<13199> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 12:11:44.419-0500 I/AUL_PAD (13199): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
02-18 12:11:44.449-0500 W/CRASH_MANAGER(13203): worker.c: worker_job(1199) > 11132006d6574148743790
