S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.5
Build-Number: R730VVRU2BPC7
Build-Date: 2016.04.01 13:23:02

Crash Information
Process Name: metronomo
PID: 24164
Date: 2017-02-18 20:38:14-0500
Executable File Path: /opt/usr/apps/org.example.metronomo/bin/metronomo
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xc

Register Information
r0   = 0x00000001, r1   = 0x0000037c
r2   = 0x00000000, r3   = 0xb6f0d788
r4   = 0xb6f1bb18, r5   = 0x00000140
r6   = 0x00000000, r7   = 0xb6f9e1c1
r8   = 0x00000000, r9   = 0x00000000
r10  = 0xb6faec90, fp   = 0x00000000
ip   = 0xb6efc70d, sp   = 0xbeabb508
lr   = 0xb6efc745, pc   = 0xb6ef506a
cpsr = 0x20000030

Memory Information
MemTotal:   389300 KB
MemFree:     12212 KB
Buffers:      4700 KB
Cached:     100060 KB
VmPeak:      51236 KB
VmSize:      51232 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7480 KB
VmRSS:        7480 KB
VmData:       2556 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:       21828 KB
VmPTE:          38 KB
VmSwap:          0 KB

Maps Information
b3f52000 b401c000 r-xp /usr/lib/libCOREGL.so.4.0
b4033000 b4036000 r-xp /lib/libattr.so.1.1.0
b403e000 b4045000 r-xp /lib/libcrypt-2.13.so
b4076000 b4079000 r-xp /lib/libcap.so.2.21
b4081000 b4083000 r-xp /usr/lib/libiri.so
b408b000 b40a8000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b40b1000 b40ba000 r-xp /usr/lib/libresourced.so.0.2.86
b40c3000 b40c4000 r-xp /usr/lib/librd-network.so.0.2.86
b40cc000 b40d9000 r-xp /usr/lib/libail.so.0.1.0
b40e2000 b40e9000 r-xp /usr/lib/libminizip.so.1.0.0
b40f1000 b411e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4126000 b4128000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b4130000 b4137000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b4141000 b415d000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b4166000 b416e000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
b4176000 b417c000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b4184000 b4189000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
b4192000 b41b3000 r-xp /usr/lib/libexif.so.12.3.3
b41c6000 b41df000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
b41e7000 b41ea000 r-xp /usr/lib/libsmack.so.1.0.0
b41f2000 b41f7000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b41ff000 b4204000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b5795000 b57a0000 r-xp /usr/lib/libgpg-error.so.0.15.0
b57a8000 b5950000 r-xp /usr/lib/libcrypto.so.1.0.0
b5969000 b59b6000 r-xp /usr/lib/libssl.so.1.0.0
b59c2000 b59f0000 r-xp /usr/lib/libidn.so.11.5.44
b59f8000 b5a01000 r-xp /usr/lib/libcares.so.2.1.0
b5a0b000 b5a0d000 r-xp /usr/lib/libXau.so.6.0.0
b5a15000 b5aa9000 r-xp /usr/lib/libstdc++.so.6.0.16
b5abc000 b5abd000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b5ac6000 b5ac9000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
b5ad2000 b5bb6000 r-xp /usr/lib/libicuuc.so.51.1
b5bcb000 b5d08000 r-xp /usr/lib/libicui18n.so.51.1
b5d18000 b5d1a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5d22000 b5d24000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5d2e000 b5daa000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5db6000 b5dce000 r-xp /usr/lib/liblzma.so.5.0.3
b5dd6000 b5e1a000 r-xp /usr/lib/libcurl.so.4.3.0
b5e23000 b5e46000 r-xp /usr/lib/libjpeg.so.8.0.2
b5e5f000 b5e65000 r-xp /usr/lib/libxcb-render.so.0.0.0
b5e6d000 b5e6e000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b5e77000 b5e8f000 r-xp /usr/lib/libpng12.so.0.50.0
b5e97000 b5e9a000 r-xp /usr/lib/libEGL.so.1.4
b5ea2000 b5eb0000 r-xp /usr/lib/libGLESv2.so.2.0
b5eb9000 b5eba000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5ec3000 b5eda000 r-xp /usr/lib/liblua-5.1.so
b5ee3000 b5eea000 r-xp /usr/lib/libembryo.so.1.7.99
b5ef2000 b5f05000 r-xp /usr/lib/libxcb.so.1.1.0
b5f0e000 b5f2f000 r-xp /usr/lib/libui-extension.so.0.1.0
b5f39000 b5f4b000 r-xp /usr/lib/libtts.so
b5f53000 b5f69000 r-xp /lib/libexpat.so.1.5.2
b5f73000 b5f76000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b5f7e000 b5f82000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b5f8b000 b5f90000 r-xp /usr/lib/libecore_fb.so.1.7.99
b5f9a000 b5fa4000 r-xp /usr/lib/libXext.so.6.4.0
b5fad000 b5fb3000 r-xp /usr/lib/libXrender.so.1.3.0
b5fbb000 b5fc1000 r-xp /usr/lib/libXrandr.so.2.2.0
b5fc9000 b5fca000 r-xp /usr/lib/libXinerama.so.1.0.0
b5fd3000 b5fd6000 r-xp /usr/lib/libXfixes.so.3.1.0
b5fde000 b5fe0000 r-xp /usr/lib/libXgesture.so.7.0.0
b5fe9000 b5feb000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5ff3000 b5ffa000 r-xp /usr/lib/libXcursor.so.1.0.2
b6002000 b6012000 r-xp /lib/libresolv-2.13.so
b6016000 b602c000 r-xp /lib/libz.so.1.2.5
b6034000 b6036000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b603f000 b6044000 r-xp /usr/lib/libffi.so.5.0.10
b604c000 b604d000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6055000 b60ca000 r-xp /usr/lib/libsqlite3.so.0.8.6
b60d4000 b60ea000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b60f2000 b60f5000 r-xp /usr/lib/libproc-stat.so.0.2.86
b60fe000 b613a000 r-xp /usr/lib/libsystemd.so.0.4.0
b6143000 b6148000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6150000 b6167000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b616f000 b6171000 r-xp /usr/lib/libiniparser.so.0
b617a000 b6180000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6189000 b618c000 r-xp /usr/lib/libbundle.so.0.1.22
b6194000 b619a000 r-xp /usr/lib/libappsvc.so.0.1.0
b61a2000 b61f8000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6205000 b625b000 r-xp /usr/lib/libfreetype.so.6.11.3
b6267000 b62a4000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62ae000 b62c1000 r-xp /usr/lib/libfribidi.so.0.3.1
b62c9000 b62e3000 r-xp /usr/lib/libecore_con.so.1.7.99
b62ec000 b6316000 r-xp /usr/lib/libdbus-1.so.3.8.12
b631f000 b6328000 r-xp /usr/lib/libedbus.so.1.7.99
b6330000 b6341000 r-xp /usr/lib/libecore_input.so.1.7.99
b634a000 b634f000 r-xp /usr/lib/libecore_file.so.1.7.99
b6357000 b6370000 r-xp /usr/lib/libeet.so.1.7.99
b6381000 b638a000 r-xp /usr/lib/libXi.so.6.1.0
b6392000 b644a000 r-xp /usr/lib/libcairo.so.2.11200.14
b6455000 b64b2000 r-xp /usr/lib/libedje.so.1.7.99
b64bd000 b6526000 r-xp /lib/libm-2.13.so
b652f000 b6535000 r-xp /lib/librt-2.13.so
b653e000 b661f000 r-xp /usr/lib/libX11.so.6.3.0
b662a000 b662e000 r-xp /usr/lib/libXtst.so.6.1.0
b6636000 b663c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b6646000 b664d000 r-xp /usr/lib/libtbm.so.1.0.0
b6655000 b665d000 r-xp /usr/lib/libdrm.so.2.4.0
b6665000 b6667000 r-xp /usr/lib/libXdamage.so.1.1.0
b666f000 b6671000 r-xp /usr/lib/libdri2.so.0.0.0
b6679000 b667c000 r-xp /usr/lib/libXv.so.1.0.0
b6684000 b6689000 r-xp /usr/lib/libutilX.so.1.1.0
b6692000 b66a4000 r-xp /usr/lib/libefl-assist.so.0.1.0
b66ac000 b6778000 r-xp /usr/lib/libxml2.so.2.7.8
b6785000 b67ad000 r-xp /usr/lib/libfontconfig.so.1.8.0
b67ae000 b67d0000 r-xp /usr/lib/libecore_evas.so.1.7.99
b67d9000 b6829000 r-xp /usr/lib/libecore_x.so.1.7.99
b682c000 b68fc000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b68fd000 b6931000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b693a000 b6a0d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6a18000 b6a1d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6a25000 b6a29000 r-xp /usr/lib/libvconf.so.0.2.45
b6a31000 b6a45000 r-xp /lib/libpthread-2.13.so
b6a50000 b6a91000 r-xp /usr/lib/libeina.so.1.7.99
b6a9a000 b6abc000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6ac4000 b6ad0000 r-xp /usr/lib/libaul.so.0.1.0
b6ada000 b6adf000 r-xp /usr/lib/libappcore-common.so.1.1
b6ae7000 b6aec000 r-xp /usr/lib/libappcore-efl.so.1.1
b6af4000 b6af6000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b6aff000 b6b03000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b6b0c000 b6b0e000 r-xp /lib/libdl-2.13.so
b6b17000 b6b22000 r-xp /lib/libunwind.so.8.0.1
b6b4f000 b6b57000 r-xp /lib/libgcc_s-4.6.so.1
b6b58000 b6c73000 r-xp /lib/libc-2.13.so
b6c81000 b6d4f000 r-xp /usr/lib/libevas.so.1.7.99
b6d74000 b6eaf000 r-xp /usr/lib/libelementary.so.1.7.99
b6ec5000 b6ee6000 r-xp /usr/lib/libefl-extension.so.0.1.0
b6eee000 b6f05000 r-xp /usr/lib/libecore.so.1.7.99
b6f1c000 b6f1e000 r-xp /usr/lib/libdlog.so.0.0.0
b6f26000 b6f2a000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.1.5
b6f32000 b6f3a000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b6f3b000 b6f40000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b6f48000 b6f4c000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b6f6a000 b6f6e000 r-xp /usr/lib/libsys-assert.so
b6f77000 b6f94000 r-xp /lib/ld-2.13.so
b6f9d000 b6f9f000 r-xp /opt/usr/apps/org.example.metronomo/bin/metronomo
b7a22000 b7a64000 rw-p [heap]
bea9b000 beabc000 rw-p [stack]
End of Maps Information

Callstack Information (PID:24164)
Call Stack Count: 5
 0: (0xb6ef506a) [/usr/lib/libecore.so.1] + 0x706a
 1: ecore_timer_add + 0x38 (0xb6efc745) [/usr/lib/libecore.so.1] + 0xe745
 2: main + 0x84 (0xb6f9e419) [/opt/usr/apps/org.example.metronomo/bin/metronomo] + 0x1419
 3: __libc_start_main + 0x114 (0xb6b6f82c) [/lib/libc.so.6] + 0x1782c
 4: (0xb6f9e034) [/opt/usr/apps/org.example.metronomo/bin/metronomo] + 0x1034
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
32.400-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:32.600-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:32.600-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:32.800-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:32.800-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:33.000-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:33.000-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:33.200-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:33.200-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:33.400-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:33.400-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:33.600-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:33.600-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:33.800-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:33.800-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:34.000-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:34.000-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:34.200-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:34.200-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:34.400-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:34.400-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:34.610-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:34.610-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:34.800-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:34.800-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:34.900-0500 W/WATCH_CORE( 1244): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 2
02-18 20:37:34.900-0500 I/WATCH_CORE( 1244): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
02-18 20:37:34.900-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:34.900-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:34.900-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : -1205531064[0;m
02-18 20:37:34.900-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
02-18 20:37:34.900-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
02-18 20:37:34.900-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 0
02-18 20:37:34.960-0500 W/W_HOME  ( 1156): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
02-18 20:37:34.980-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 20:37:34.980-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupServiceStart(395) > [0;32mINFO: 500[0;m
02-18 20:37:34.980-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 500
02-18 20:37:35.000-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 20:37:35.000-0500 W/MUSIC_CONTROL_SERVICE( 1614): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1614]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
02-18 20:37:35.000-0500 I/SHealth_Common( 1633): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
02-18 20:37:35.000-0500 I/SHealth_Service( 1633): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
02-18 20:37:35.000-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:35.000-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:35.000-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Enable start
02-18 20:37:35.010-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Enable end. (ret: 0x0)
02-18 20:37:35.010-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-18 20:37:35.010-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
02-18 20:37:35.010-0500 I/HIGEAR  ( 1580): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
02-18 20:37:35.200-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:35.200-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:35.400-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:35.400-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:35.600-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:35.600-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:35.800-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:35.800-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:36.000-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:36.000-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:36.200-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:36.200-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:36.400-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:36.400-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:36.600-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:36.600-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:36.800-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:36.800-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:37.000-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:37.000-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:37.200-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:37.200-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:37.410-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:37.410-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:37.610-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:37.610-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:37.810-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:37.810-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:38.010-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:38.010-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:38.210-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:38.210-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:38.410-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:38.410-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:38.610-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:38.610-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:38.810-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:38.810-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:39.010-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:39.010-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:39.200-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:39.200-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:39.400-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:39.410-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:39.610-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:39.610-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:39.810-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:39.810-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:40.000-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:40.000-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:40.200-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:40.200-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:40.400-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:40.400-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:40.600-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:40.600-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:40.800-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:40.800-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:41.000-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:41.000-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:41.200-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:41.200-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:41.400-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:41.400-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:41.480-0500 W/WATCH_CORE( 1244): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
02-18 20:37:41.490-0500 W/W_HOME  ( 1156): dbus.c: _dbus_message_recv_cb(204) > LCD off
02-18 20:37:41.490-0500 W/W_HOME  ( 1156): gesture.c: _manual_render_disable_timer_del(151) > timer del
02-18 20:37:41.490-0500 W/W_HOME  ( 1156): gesture.c: _manual_render_enable(133) > 1
02-18 20:37:41.490-0500 W/W_HOME  ( 1156): event_manager.c: _lcd_off_cb(699) > lcd state: 0
02-18 20:37:41.490-0500 W/W_HOME  ( 1156): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 20:37:41.490-0500 W/STARTER ( 1093): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
02-18 20:37:41.490-0500 W/STARTER ( 1093): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
02-18 20:37:41.490-0500 E/STARTER ( 1093): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
02-18 20:37:41.490-0500 W/STARTER ( 1093): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
02-18 20:37:41.490-0500 W/STARTER ( 1093): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
02-18 20:37:41.510-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : -1226593524[0;m
02-18 20:37:41.510-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
02-18 20:37:41.510-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
02-18 20:37:41.510-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Disable start
02-18 20:37:41.520-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Disable end. (ret: 0x0)
02-18 20:37:41.520-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-18 20:37:41.520-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
02-18 20:37:41.520-0500 I/HIGEAR  ( 1580): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
02-18 20:37:41.600-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:41.600-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:41.700-0500 I/SHealth_Common( 1633): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
02-18 20:37:41.780-0500 W/STARTER ( 1093): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
02-18 20:37:41.780-0500 W/STARTER ( 1093): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
02-18 20:37:41.780-0500 W/STARTER ( 1093): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
02-18 20:37:41.780-0500 W/STARTER ( 1093): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[1]
02-18 20:37:41.790-0500 I/APP_CORE( 1156): appcore-efl.c: __do_app(429) > [APP 1156] Event: PAUSE State: RUNNING
02-18 20:37:41.790-0500 I/CAPI_APPFW_APPLICATION( 1156): app_main.c: app_appcore_pause(202) > app_appcore_pause
02-18 20:37:41.790-0500 W/W_HOME  ( 1156): main.c: _appcore_pause_cb(692) > appcore pause
02-18 20:37:41.790-0500 W/W_HOME  ( 1156): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
02-18 20:37:41.790-0500 W/W_HOME  ( 1156): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 20:37:41.790-0500 W/W_HOME  ( 1156): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 20:37:41.790-0500 W/W_HOME  ( 1156): main.c: home_pause(762) > clock/widget paused
02-18 20:37:41.790-0500 W/W_HOME  ( 1156): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 20:37:41.790-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 20:37:41.790-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 20:37:41.790-0500 I/MESSAGE_PORT(  876): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 20:37:41.790-0500 I/MESSAGE_PORT(  876): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 20:37:41.790-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 20:37:41.790-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 20:37:41.790-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 20:37:41.790-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 20:37:41.790-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 20:37:41.790-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 20:37:41.790-0500 I/MESSAGE_PORT(  876): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 20:37:41.790-0500 I/MESSAGE_PORT(  876): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 20:37:41.790-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 20:37:41.790-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 20:37:41.790-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 20:37:41.790-0500 I/MESSAGE_PORT(  876): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 20:37:41.790-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 20:37:41.790-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 20:37:41.790-0500 W/GESTURE (  257): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
02-18 20:37:41.800-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 20:37:41.800-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 20:37:41.840-0500 W/MUSIC_CONTROL_SERVICE( 1614): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1614]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
02-18 20:37:41.870-0500 W/WATCH_CORE( 1244): appcore-watch.c: __widget_pause(1001) > widget_pause
02-18 20:37:41.870-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppPause(713) > 
02-18 20:37:41.870-0500 E/watchface-viewer( 1244): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 20:37:41.870-0500 E/watchface-viewer( 1244): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 20:37:41.870-0500 E/watchface-viewer( 1244): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 20:37:41.870-0500 E/watchface-viewer( 1244): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 20:37:41.880-0500 E/CAPI_APPFW_APP_CONTROL( 1614): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
02-18 20:37:41.880-0500 W/MUSIC_CONTROL_SERVICE( 1614): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1614]   [com.samsung.w-home]register msg port [false][0m
02-18 20:37:41.880-0500 I/SHealth_Service( 1633): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
02-18 20:37:42.300-0500 I/APP_CORE( 1156): appcore-efl.c: __do_app(429) > [APP 1156] Event: MEM_FLUSH State: PAUSED
02-18 20:37:46.809-0500 I/APP_CORE( 1156): appcore-efl.c: __do_app(429) > [APP 1156] Event: MEM_FLUSH State: PAUSED
02-18 20:37:55.509-0500 E/SHealth_Common( 1633): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
02-18 20:38:05.360-0500 E/PKGMGR  (24081): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
02-18 20:38:05.610-0500 E/PKGMGR_SERVER(24090): pkgmgr-server.c: main(2131) > package manager server start
02-18 20:38:05.700-0500 E/PKGMGR_SERVER(24090): pkgmgr-server.c: req_cb(650) > req_id=[org.example.metronomo_851694493], req_type=[1], pkg_type=[rpm], pkgid=[org.example.metronomo], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.metronomo_851694493' '-r' 'org.example.metronomo'], cookie=[QwoW30IOIT6Dld0pbQCr4s+U7UE=], backend_flag=[0]
02-18 20:38:05.700-0500 E/PKGMGR  (24090): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.metronomo]
02-18 20:38:05.700-0500 E/PKGMGR_SERVER(24090): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.metronomo 
02-18 20:38:05.710-0500 E/PKGMGR  (24081): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[240810002]
02-18 20:38:05.710-0500 E/PKGMGR_SERVER(24091): pkgmgr-server.c: queue_job(1815) > INSTALL start, pkg path=[org.example.metronomo]
02-18 20:38:05.890-0500 W/W_HOME  ( 1156): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.metronomo is being updateded:1
02-18 20:38:05.900-0500 W/AUL_AMD (  935): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
02-18 20:38:05.900-0500 E/WMS     (  901): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, STARTED]
02-18 20:38:05.910-0500 E/WMS     (  901): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
02-18 20:38:06.050-0500 W/CERT_SVC(24091): DUID.cpp: CheckCertifiedDevice(675) > No device id on distributor certificate
02-18 20:38:06.100-0500 E/rpm-installer(24091): coretpk-parser.c: __coretpk_parser_check_ese_metadata(749) > (ret == 1) metadata(watchface) is empty.
02-18 20:38:06.100-0500 E/rpm-installer(24091): coretpk-parser.c: __coretpk_parser_check_backkey_long_press_metadata(825) > (ret == 1) metadata is empty.
02-18 20:38:06.100-0500 E/rpm-installer(24091): coretpk-parser.c: __coretpk_parser_append_path(218) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
02-18 20:38:06.100-0500 E/rpm-installer(24091): coretpk-parser.c: __coretpk_parser_append_path(218) > (ret == 1) NodeSet is empty. (//*[name()='widget-application']//*[name()='support-size']/@preview)
02-18 20:38:06.100-0500 E/rpm-installer(24091): coretpk-parser.c: __coretpk_parser_widget_replace_widget_tag(272) > (ret == 1) NodeSet is empty. (//*[name() = 'widget-application'])
02-18 20:38:06.110-0500 E/PKGMGR_PARSER(24091): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2107) > Manifest is Valid
02-18 20:38:06.140-0500 E/PKGMGR_CERT(24091): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(611) > Transaction Begin
02-18 20:38:06.150-0500 E/PKGMGR_CERT(24091): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(616) > Certificate Deletion Success
02-18 20:38:06.160-0500 E/PKGMGR_CERT(24091): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(629) > Transaction Commit and End
02-18 20:38:06.250-0500 I/PRIVACY-MANAGER-CLIENT(24091): SocketClient.cpp: SocketClient(37) > Client created
02-18 20:38:06.250-0500 I/PRIVACY-MANAGER-CLIENT(24091): SocketStream.h: SocketStream(31) > Created
02-18 20:38:06.250-0500 I/PRIVACY-MANAGER-CLIENT(24091): SocketConnection.h: SocketConnection(44) > Created
02-18 20:38:06.250-0500 I/PRIVACY-MANAGER-CLIENT(24091): SocketClient.cpp: connect(62) > Client connected
02-18 20:38:06.250-0500 I/PRIVACY-MANAGER-SERVER(  869): SocketService.cpp: mainloop(227) > Got incoming connection
02-18 20:38:06.260-0500 I/PRIVACY-MANAGER-SERVER(  869): SocketService.cpp: connectionThread(253) > Starting connection thread
02-18 20:38:06.260-0500 I/PRIVACY-MANAGER-SERVER(  869): SocketStream.h: SocketStream(31) > Created
02-18 20:38:06.260-0500 I/PRIVACY-MANAGER-SERVER(  869): SocketConnection.h: SocketConnection(44) > Created
02-18 20:38:06.260-0500 I/PRIVACY-MANAGER-SERVER(  869): SocketService.cpp: connectionService(304) > Calling service
02-18 20:38:06.270-0500 I/PRIVACY-MANAGER-CLIENT(24091): SocketClient.cpp: disconnect(72) > Client disconnected
02-18 20:38:06.270-0500 I/PRIVACY-MANAGER-SERVER(  869): SocketService.cpp: connectionService(307) > Removing client
02-18 20:38:06.270-0500 I/PRIVACY-MANAGER-SERVER(  869): SocketService.cpp: connectionService(311) > Call served
02-18 20:38:06.270-0500 I/PRIVACY-MANAGER-SERVER(  869): SocketService.cpp: connectionThread(262) > Client serviced
02-18 20:38:06.390-0500 I/efl-extension(24091): efl_extension.c: eext_mod_init(40) > Init
02-18 20:38:06.390-0500 I/efl-extension(24091): efl_extension.c: eext_mod_shutdown(46) > Shutdown
02-18 20:38:06.450-0500 E/PKGMGR_CERT(24091): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
02-18 20:38:06.450-0500 E/PKGMGR_CERT(24091): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 101
02-18 20:38:06.450-0500 E/PKGMGR_CERT(24091): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 101
02-18 20:38:06.450-0500 E/PKGMGR_CERT(24091): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 1
02-18 20:38:06.450-0500 E/PKGMGR_CERT(24091): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 1
02-18 20:38:06.450-0500 E/PKGMGR_CERT(24091): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 1
02-18 20:38:06.450-0500 E/PKGMGR_CERT(24091): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 26 1
02-18 20:38:06.460-0500 E/WMS     (  901): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
02-18 20:38:06.480-0500 E/PKGMGR_CERT(24091): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
02-18 20:38:06.710-0500 I/AUL_AMD (  935): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 23304
02-18 20:38:06.780-0500 I/AUL_AMD (  935): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 23694
02-18 20:38:06.930-0500 I/AUL_AMD (  935): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 19174
02-18 20:38:06.960-0500 E/EFL     (24093): elementary<24093> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 20:38:06.960-0500 E/EFL     (24093): elementary<24093> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 20:38:06.990-0500 E/EFL     (24093): elementary<24093> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 20:38:06.990-0500 E/EFL     (24093): elementary<24093> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 20:38:07.020-0500 E/EFL     (24093): elementary<24093> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 20:38:07.020-0500 E/EFL     (24093): elementary<24093> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 20:38:07.020-0500 E/EFL     (24093): elementary<24093> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 20:38:07.030-0500 E/EFL     (24093): elementary<24093> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 20:38:07.030-0500 E/EFL     (24093): elementary<24093> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 20:38:07.050-0500 E/EFL     (24093): elementary<24093> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 20:38:07.050-0500 E/EFL     (24093): elementary<24093> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 20:38:07.060-0500 E/EFL     (24093): elementary<24093> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 20:38:07.150-0500 E/EFL     (24093): elementary<24093> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 20:38:07.160-0500 E/EFL     (24093): elementary<24093> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 20:38:07.160-0500 E/EFL     (24093): elementary<24093> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 20:38:07.160-0500 E/EFL     (24093): elementary<24093> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 20:38:07.160-0500 E/EFL     (24093): elementary<24093> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 20:38:07.160-0500 E/EFL     (24093): elementary<24093> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 20:38:07.160-0500 E/EFL     (24093): elementary<24093> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 20:38:07.160-0500 I/AUL_PAD (24093): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
02-18 20:38:07.340-0500 I/efl-extension(24094): efl_extension.c: eext_mod_init(40) > Init
02-18 20:38:07.370-0500 E/EFL     (24094): elementary<24094> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 20:38:07.370-0500 E/EFL     (24094): elementary<24094> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 20:38:07.390-0500 E/EFL     (24094): elementary<24094> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 20:38:07.390-0500 I/UXT     (24094): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
02-18 20:38:07.390-0500 E/EFL     (24094): elementary<24094> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 20:38:07.430-0500 E/EFL     (24094): elementary<24094> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 20:38:07.430-0500 E/EFL     (24094): elementary<24094> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 20:38:07.430-0500 E/EFL     (24094): elementary<24094> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 20:38:07.430-0500 E/EFL     (24094): elementary<24094> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 20:38:07.430-0500 E/EFL     (24094): elementary<24094> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 20:38:07.450-0500 E/EFL     (24094): elementary<24094> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 20:38:07.470-0500 E/EFL     (24094): elementary<24094> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 20:38:07.470-0500 I/AUL_AMD (  935): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 24095
02-18 20:38:07.480-0500 E/EFL     (24094): elementary<24094> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 20:38:07.550-0500 I/AUL_AMD (  935): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 24093
02-18 20:38:07.580-0500 E/EFL     (24094): elementary<24094> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 20:38:07.580-0500 E/EFL     (24094): elementary<24094> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 20:38:07.580-0500 E/EFL     (24094): elementary<24094> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 20:38:07.580-0500 E/EFL     (24094): elementary<24094> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 20:38:07.580-0500 E/EFL     (24094): elementary<24094> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 20:38:07.590-0500 E/EFL     (24094): elementary<24094> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 20:38:07.590-0500 E/EFL     (24094): elementary<24094> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 20:38:07.590-0500 I/AUL_PAD (24094): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
02-18 20:38:07.640-0500 I/Adreno-EGL(24094): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
02-18 20:38:07.640-0500 I/Adreno-EGL(24094): OpenGL ES Shader Compiler Version: E031.24.00.16
02-18 20:38:07.640-0500 I/Adreno-EGL(24094): Build Date: 09/02/15 Wed
02-18 20:38:07.640-0500 I/Adreno-EGL(24094): Local Branch: 
02-18 20:38:07.640-0500 I/Adreno-EGL(24094): Remote Branch: 
02-18 20:38:07.640-0500 I/Adreno-EGL(24094): Local Patches: 
02-18 20:38:07.640-0500 I/Adreno-EGL(24094): Reconstruct Branch: 
02-18 20:38:08.380-0500 W/MM_CAMCORDER(24096): mm_camcorder_internal.c: _mmcamcorder_constructor(204) >  start
02-18 20:38:08.380-0500 W/MM_CAMCORDER(24096): mm_camcorder_internal.c: _mmcamcorder_constructor(214) >  done
02-18 20:38:08.380-0500 I/efl-extension(24096): efl_extension.c: eext_mod_init(40) > Init
02-18 20:38:08.400-0500 E/PKGMGR_SERVER(24090): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
02-18 20:38:08.690-0500 E/rpm-installer(24091): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
02-18 20:38:09.230-0500 I/AUL     (24096): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 20:38:09.240-0500 I/AUL     (24096): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 20:38:09.240-0500 E/AUL     (24096): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-18 20:38:09.240-0500 E/AUL     (24096): aul_path.c: __get_path(169) > root_path is NULL!
02-18 20:38:09.250-0500 I/AUL     (24096): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 20:38:09.260-0500 I/AUL     (24096): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 20:38:09.260-0500 E/AUL     (24096): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-18 20:38:09.260-0500 E/AUL     (24096): aul_path.c: __get_path(169) > root_path is NULL!
02-18 20:38:09.270-0500 E/EFL     (24096): elementary<24096> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 20:38:09.270-0500 E/EFL     (24096): elementary<24096> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 20:38:09.290-0500 E/EFL     (24096): elementary<24096> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 20:38:09.290-0500 I/UXT     (24096): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
02-18 20:38:09.290-0500 E/EFL     (24096): elementary<24096> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 20:38:09.330-0500 E/EFL     (24096): elementary<24096> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 20:38:09.330-0500 E/EFL     (24096): elementary<24096> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 20:38:09.330-0500 E/EFL     (24096): elementary<24096> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 20:38:09.330-0500 E/EFL     (24096): elementary<24096> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 20:38:09.330-0500 E/EFL     (24096): elementary<24096> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 20:38:09.350-0500 E/EFL     (24096): elementary<24096> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 20:38:09.350-0500 E/EFL     (24096): elementary<24096> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 20:38:09.350-0500 E/EFL     (24096): elementary<24096> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 20:38:09.390-0500 E/EFL     (24096): elementary<24096> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 20:38:09.410-0500 E/EFL     (24096): elementary<24096> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 20:38:09.410-0500 E/EFL     (24096): elementary<24096> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 20:38:09.410-0500 E/EFL     (24096): elementary<24096> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 20:38:09.410-0500 E/EFL     (24096): elementary<24096> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 20:38:09.410-0500 E/EFL     (24096): elementary<24096> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 20:38:09.410-0500 E/EFL     (24096): elementary<24096> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 20:38:09.440-0500 I/Adreno-EGL(24096): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
02-18 20:38:09.440-0500 I/Adreno-EGL(24096): OpenGL ES Shader Compiler Version: E031.24.00.16
02-18 20:38:09.440-0500 I/Adreno-EGL(24096): Build Date: 09/02/15 Wed
02-18 20:38:09.440-0500 I/Adreno-EGL(24096): Local Branch: 
02-18 20:38:09.440-0500 I/Adreno-EGL(24096): Remote Branch: 
02-18 20:38:09.440-0500 I/Adreno-EGL(24096): Local Patches: 
02-18 20:38:09.440-0500 I/Adreno-EGL(24096): Reconstruct Branch: 
02-18 20:38:09.490-0500 W/Adreno-ES20(24096): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 20:38:09.490-0500 W/Adreno-ES20(24096): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 20:38:09.500-0500 W/Adreno-ES20(24096): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 20:38:09.500-0500 W/Adreno-ES20(24096): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 20:38:09.500-0500 W/Adreno-ES20(24096): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 20:38:09.500-0500 W/Adreno-ES20(24096): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 20:38:09.500-0500 W/Adreno-ES20(24096): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 20:38:09.500-0500 W/Adreno-ES20(24096): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 20:38:09.500-0500 W/Adreno-ES20(24096): <get_simple_queries:1550>: GL_INVALID_ENUM
02-18 20:38:10.400-0500 E/PKGMGR_SERVER(24090): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
02-18 20:38:11.810-0500 E/WMS     (  901): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
02-18 20:38:11.820-0500 E/PKGMGR_SERVER(24090): pkgmgr-server.c: sighandler(409) > child NORMAL exit [24091]
02-18 20:38:11.840-0500 W/W_HOME  ( 1156): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.example.metronomo is updated, need to check validation
02-18 20:38:11.840-0500 W/W_HOME  ( 1156): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:com.samsung.watchface
02-18 20:38:11.860-0500 E/WMS     (  901): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, COMPLETED]
02-18 20:38:11.860-0500 E/WMS     (  901): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6946) > package install complete
02-18 20:38:11.860-0500 E/WMS     (  901): wms_event_handler.c: _wms_event_handler_package_install_event(4818) > 
02-18 20:38:11.860-0500 E/WMS     (  901): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1758) > Found in install_req_list?[0], index[-1]
02-18 20:38:11.960-0500 W/APPS    ( 1156): pkgmgr.c: _update_app(739) >  old order:[25]
02-18 20:38:11.970-0500 E/PKGMGR_INFO(  900): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
02-18 20:38:11.980-0500 E/STARTER ( 1093): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
02-18 20:38:12.030-0500 E/EFL     ( 1156): elementary<1156> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0xb7fc2518 into part 'elm.swallow.event.0'
02-18 20:38:12.030-0500 E/APPS    ( 1156): AppsViewNecklace.cpp: onShow(597) >  AppsItemList[26]
02-18 20:38:12.080-0500 E/Vi::Animations( 1156): result Vi::Animations::_AnimationManager::addAnimation(Vi::Animations::Visual&, const string*, Vi::Animations::Animation&)(288) > [E_OBJ_ALREADY_EXIST] Animation with keyName already exists. key name = hide
02-18 20:38:12.080-0500 I/Vi::Animations( 1156): result Vi::Animations::_VisualImpl::addAnimation(const string*, Vi::Animations::Animation&)(6999) > [E_OBJ_ALREADY_EXIST] Propagating.
02-18 20:38:12.080-0500 E/Vi::Animations( 1156): result Vi::Animations::_AnimationManager::addAnimation(Vi::Animations::Visual&, const string*, Vi::Animations::Animation&)(288) > [E_OBJ_ALREADY_EXIST] Animation with keyName already exists. key name = hide
02-18 20:38:12.080-0500 I/Vi::Animations( 1156): result Vi::Animations::_VisualImpl::addAnimation(const string*, Vi::Animations::Animation&)(6999) > [E_OBJ_ALREADY_EXIST] Propagating.
02-18 20:38:12.090-0500 E/EFL     ( 1156): elementary<1156> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0xb7fc2518 into part 'elm.swallow.event.0'
02-18 20:38:12.090-0500 E/APPS    ( 1156): AppsViewNecklace.cpp: onShow(597) >  AppsItemList[27]
02-18 20:38:12.400-0500 E/PKGMGR_SERVER(24090): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
02-18 20:38:12.400-0500 E/PKGMGR_SERVER(24090): pkgmgr-server.c: main(2185) > package manager server terminated.
02-18 20:38:12.600-0500 W/APPS    ( 1156): pkgmgr.c: _update_app_cb(718) >  Update apps order
02-18 20:38:12.600-0500 W/APPS    ( 1156): AppsViewNecklace.cpp: onTouchEventCancel(4360) >  touch cancel
02-18 20:38:13.870-0500 W/AUL_AMD (  935): amd_request.c: __request_handler(646) > __request_handler: 0
02-18 20:38:13.890-0500 I/AUL_AMD (  935): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
02-18 20:38:13.910-0500 I/AUL_AMD (  935): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
02-18 20:38:13.910-0500 E/AUL_AMD (  935): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
02-18 20:38:13.910-0500 W/AUL_AMD (  935): amd_launch.c: _start_app(1708) > caller pid : 24162
02-18 20:38:13.920-0500 E/RESOURCED(  936): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.metronomo, table num : 1
02-18 20:38:13.920-0500 E/RESOURCED(  936): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
02-18 20:38:13.920-0500 W/AUL_AMD (  935): amd_launch.c: _start_app(2086) > pad pid(-5)
02-18 20:38:13.920-0500 W/AUL_PAD ( 1713): launchpad.c: __launchpad_main_loop(607) > Candidate is not prepared, enter legacy logic
02-18 20:38:13.920-0500 W/AUL_PAD ( 1713): launchpad.c: __send_result_to_caller(272) > Check app launching
02-18 20:38:13.920-0500 W/AUL_AMD (  935): amd_launch.c: _start_app(2097) > Launch with legacy way : no launchpad
02-18 20:38:13.920-0500 W/AUL_AMD (  935): amd_launch.c: start_process(580) > child process: 24164
02-18 20:38:13.980-0500 W/AUL_AMD (  935): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 24164
02-18 20:38:13.980-0500 E/RESOURCED(  936): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.metronomo
02-18 20:38:14.020-0500 W/AUL_AMD (  935): amd_request.c: __request_handler(646) > __request_handler: 14
02-18 20:38:14.030-0500 W/AUL_AMD (  935): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 24164
02-18 20:38:14.030-0500 W/AUL_AMD (  935): amd_request.c: __request_handler(646) > __request_handler: 12
02-18 20:38:14.080-0500 I/efl-extension(24164): efl_extension.c: eext_mod_init(40) > Init
02-18 20:38:14.120-0500 E/EFL     (24163): elementary<24163> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 20:38:14.120-0500 E/EFL     (24163): elementary<24163> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 20:38:14.150-0500 E/EFL     (24163): elementary<24163> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 20:38:14.150-0500 E/EFL     (24163): elementary<24163> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 20:38:14.180-0500 E/EFL     (24163): elementary<24163> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 20:38:14.190-0500 E/EFL     (24163): elementary<24163> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 20:38:14.190-0500 E/EFL     (24163): elementary<24163> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 20:38:14.190-0500 E/EFL     (24163): elementary<24163> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 20:38:14.190-0500 E/EFL     (24163): elementary<24163> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 20:38:14.210-0500 E/EFL     (24163): elementary<24163> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 20:38:14.210-0500 E/EFL     (24163): elementary<24163> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 20:38:14.210-0500 E/EFL     (24163): elementary<24163> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 20:38:14.220-0500 W/AUL_AMD (  935): amd_request.c: __request_handler(646) > __request_handler: 23
02-18 20:38:14.220-0500 W/AUL_AMD (  935): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
02-18 20:38:14.220-0500 W/AUL_AMD (  935): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 24164
02-18 20:38:14.220-0500 W/AUL_AMD (  935): amd_request.c: __send_app_termination_signal(511) > send dead signal done
02-18 20:38:14.220-0500 I/AUL_AMD (  935): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 24164
02-18 20:38:14.240-0500 E/EFL     (24163): elementary<24163> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 20:38:14.250-0500 E/EFL     (24163): elementary<24163> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 20:38:14.250-0500 E/EFL     (24163): elementary<24163> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 20:38:14.250-0500 E/EFL     (24163): elementary<24163> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 20:38:14.250-0500 E/EFL     (24163): elementary<24163> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 20:38:14.250-0500 E/EFL     (24163): elementary<24163> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 20:38:14.250-0500 E/EFL     (24163): elementary<24163> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 20:38:14.250-0500 I/AUL_PAD (24163): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
02-18 20:38:14.370-0500 W/CRASH_MANAGER(24171): worker.c: worker_job(1199) > 11241646d6574148746829
