S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.5
Build-Number: R730VVRU2BPC7
Build-Date: 2016.04.01 13:23:02

Crash Information
Process Name: metronomo
PID: 4572
Date: 2017-02-18 04:29:38-0500
Executable File Path: /opt/usr/apps/org.example.metronomo/bin/metronomo
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb2f0a740

Register Information
r0   = 0xb2f0a740, r1   = 0xbe9f65e8
r2   = 0xb2f05790, r3   = 0xb583421d
r4   = 0xbe9f654c, r5   = 0xb5b69980
r6   = 0xb2f05730, r7   = 0xb6f9ca70
r8   = 0x00000041, r9   = 0xb6c29824
r10  = 0xb8cc8980, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbe9f5d28
lr   = 0xb5b6906b, pc   = 0xb2f0a740
cpsr = 0x60000010

Memory Information
MemTotal:   389300 KB
MemFree:     11992 KB
Buffers:     16720 KB
Cached:     101020 KB
VmPeak:      71008 KB
VmSize:      68384 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14360 KB
VmRSS:       14080 KB
VmData:      12868 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23056 KB
VmPTE:          46 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4572 TID = 4572
4572 4672 

Maps Information
b2e79000 b2f00000 rw-s anon_inode:dmabuf
b303f000 b3040000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
b3048000 b304b000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b30d3000 b38d2000 rw-p [stack:4672]
b38d2000 b38e9000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b38f6000 b38f8000 r-xp /usr/lib/libgenlock.so
b3908000 b390a000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3916000 b391b000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b3923000 b392e000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b3c96000 b3d60000 r-xp /usr/lib/libCOREGL.so.4.0
b3d71000 b3d7a000 r-xp /usr/lib/libresourced.so.0.2.86
b3d82000 b3d83000 r-xp /usr/lib/librd-network.so.0.2.86
b3d8b000 b3d98000 r-xp /usr/lib/libail.so.0.1.0
b3da1000 b3da8000 r-xp /usr/lib/libminizip.so.1.0.0
b3db0000 b3db2000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b3dba000 b3dc1000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b3dca000 b3de6000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b3def000 b3df7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
b3dff000 b3e05000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b3e0d000 b3e12000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
b3e1a000 b3e3b000 r-xp /usr/lib/libexif.so.12.3.3
b3e4e000 b3e67000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
b3e6f000 b3e74000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3e7c000 b3e81000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b5411000 b5413000 r-xp /usr/lib/libdri2.so.0.0.0
b541b000 b5423000 r-xp /usr/lib/libdrm.so.2.4.0
b542b000 b542c000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b5435000 b5438000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
b5440000 b5524000 r-xp /usr/lib/libicuuc.so.51.1
b5539000 b5676000 r-xp /usr/lib/libicui18n.so.51.1
b5686000 b568c000 r-xp /usr/lib/libxcb-render.so.0.0.0
b5694000 b5695000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b569e000 b56a1000 r-xp /usr/lib/libEGL.so.1.4
b56a9000 b56b7000 r-xp /usr/lib/libGLESv2.so.2.0
b56c0000 b56c7000 r-xp /usr/lib/libtbm.so.1.0.0
b56cf000 b56f0000 r-xp /usr/lib/libui-extension.so.0.1.0
b56f9000 b570b000 r-xp /usr/lib/libtts.so
b5713000 b57cb000 r-xp /usr/lib/libcairo.so.2.11200.14
b57d6000 b57e8000 r-xp /usr/lib/libefl-assist.so.0.1.0
b57f0000 b57f5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b57fd000 b581e000 r-xp /usr/lib/libefl-extension.so.0.1.0
b5826000 b582b000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b5833000 b5835000 r-xp /opt/usr/apps/org.example.metronomo/bin/metronomo
b59e4000 b59ee000 r-xp /lib/libnss_files-2.13.so
b59f7000 b5ac6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5adc000 b5b00000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5b09000 b5b0f000 r-xp /usr/lib/libappsvc.so.0.1.0
b5b17000 b5b19000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5b22000 b5b26000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5b32000 b5b3d000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b5b45000 b5b47000 r-xp /usr/lib/libiniparser.so.0
b5b50000 b5b55000 r-xp /usr/lib/libappcore-common.so.1.1
b5b5e000 b5b66000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b5b67000 b5b6b000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5b78000 b5b7a000 r-xp /usr/lib/libXau.so.6.0.0
b5b83000 b5b8a000 r-xp /lib/libcrypt-2.13.so
b5bba000 b5bbc000 r-xp /usr/lib/libiri.so
b5bc4000 b5d6c000 r-xp /usr/lib/libcrypto.so.1.0.0
b5d85000 b5dd2000 r-xp /usr/lib/libssl.so.1.0.0
b5ddf000 b5e0d000 r-xp /usr/lib/libidn.so.11.5.44
b5e15000 b5e1e000 r-xp /usr/lib/libcares.so.2.1.0
b5e27000 b5e3a000 r-xp /usr/lib/libxcb.so.1.1.0
b5e43000 b5e45000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5e4e000 b5e50000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5e59000 b5f25000 r-xp /usr/lib/libxml2.so.2.7.8
b5f32000 b5f34000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5f3c000 b5f41000 r-xp /usr/lib/libffi.so.5.0.10
b5f49000 b5f4a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5f53000 b5f5e000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5f66000 b5f69000 r-xp /lib/libattr.so.1.1.0
b5f71000 b6005000 r-xp /usr/lib/libstdc++.so.6.0.16
b6018000 b6035000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b603e000 b6056000 r-xp /usr/lib/libpng12.so.0.50.0
b605f000 b6075000 r-xp /lib/libexpat.so.1.5.2
b607f000 b60c3000 r-xp /usr/lib/libcurl.so.4.3.0
b60cc000 b60d6000 r-xp /usr/lib/libXext.so.6.4.0
b60df000 b60e3000 r-xp /usr/lib/libXtst.so.6.1.0
b60eb000 b60f1000 r-xp /usr/lib/libXrender.so.1.3.0
b60fa000 b6100000 r-xp /usr/lib/libXrandr.so.2.2.0
b6108000 b6109000 r-xp /usr/lib/libXinerama.so.1.0.0
b6112000 b611b000 r-xp /usr/lib/libXi.so.6.1.0
b6123000 b6126000 r-xp /usr/lib/libXfixes.so.3.1.0
b612e000 b6130000 r-xp /usr/lib/libXgesture.so.7.0.0
b6138000 b613a000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6143000 b6145000 r-xp /usr/lib/libXdamage.so.1.1.0
b614d000 b6154000 r-xp /usr/lib/libXcursor.so.1.0.2
b615c000 b615f000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6167000 b616b000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6174000 b6179000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6183000 b6264000 r-xp /usr/lib/libX11.so.6.3.0
b626f000 b6292000 r-xp /usr/lib/libjpeg.so.8.0.2
b62aa000 b62c0000 r-xp /lib/libz.so.1.2.5
b62c8000 b633d000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6347000 b635d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6366000 b639a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b63a3000 b6476000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6481000 b6491000 r-xp /lib/libresolv-2.13.so
b6495000 b6511000 r-xp /usr/lib/libgcrypt.so.20.0.3
b651d000 b6535000 r-xp /usr/lib/liblzma.so.5.0.3
b653e000 b6541000 r-xp /lib/libcap.so.2.21
b6549000 b6576000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b657e000 b657f000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b6587000 b658d000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6595000 b65ac000 r-xp /usr/lib/liblua-5.1.so
b65b6000 b65bd000 r-xp /usr/lib/libembryo.so.1.7.99
b65c5000 b65cb000 r-xp /lib/librt-2.13.so
b65d4000 b662a000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6637000 b668d000 r-xp /usr/lib/libfreetype.so.6.11.3
b6699000 b66c1000 r-xp /usr/lib/libfontconfig.so.1.8.0
b66c3000 b6700000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6709000 b671c000 r-xp /usr/lib/libfribidi.so.0.3.1
b6724000 b673e000 r-xp /usr/lib/libecore_con.so.1.7.99
b6747000 b6750000 r-xp /usr/lib/libedbus.so.1.7.99
b6758000 b67a8000 r-xp /usr/lib/libecore_x.so.1.7.99
b67ab000 b67af000 r-xp /usr/lib/libvconf.so.0.2.45
b67b7000 b67c8000 r-xp /usr/lib/libecore_input.so.1.7.99
b67d0000 b67d5000 r-xp /usr/lib/libecore_file.so.1.7.99
b67dd000 b67ff000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6808000 b6849000 r-xp /usr/lib/libeina.so.1.7.99
b6852000 b686b000 r-xp /usr/lib/libeet.so.1.7.99
b687c000 b68e5000 r-xp /lib/libm-2.13.so
b68ee000 b68f4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b68fd000 b6900000 r-xp /usr/lib/libproc-stat.so.0.2.86
b6908000 b692a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6932000 b6937000 r-xp /usr/lib/libxdgmime.so.1.1.0
b693f000 b6969000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6972000 b6989000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6991000 b699c000 r-xp /lib/libunwind.so.8.0.1
b69c9000 b6a05000 r-xp /usr/lib/libsystemd.so.0.4.0
b6a0e000 b6b29000 r-xp /lib/libc-2.13.so
b6b37000 b6b3f000 r-xp /lib/libgcc_s-4.6.so.1
b6b40000 b6b43000 r-xp /usr/lib/libsmack.so.1.0.0
b6b4b000 b6b51000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6b59000 b6c29000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c2a000 b6c87000 r-xp /usr/lib/libedje.so.1.7.99
b6c91000 b6ca8000 r-xp /usr/lib/libecore.so.1.7.99
b6cbf000 b6d8d000 r-xp /usr/lib/libevas.so.1.7.99
b6db2000 b6eed000 r-xp /usr/lib/libelementary.so.1.7.99
b6f03000 b6f17000 r-xp /lib/libpthread-2.13.so
b6f22000 b6f24000 r-xp /usr/lib/libdlog.so.0.0.0
b6f2c000 b6f2f000 r-xp /usr/lib/libbundle.so.0.1.22
b6f37000 b6f39000 r-xp /lib/libdl-2.13.so
b6f42000 b6f4e000 r-xp /usr/lib/libaul.so.0.1.0
b6f60000 b6f65000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f6e000 b6f72000 r-xp /usr/lib/libsys-assert.so
b6f7b000 b6f98000 r-xp /lib/ld-2.13.so
b6fa1000 b6fa6000 r-xp /usr/bin/launchpad-loader
b8c8d000 b8dcf000 rw-p [heap]
be9d6000 be9f7000 rw-p [stack]
b8c8d000 b8dcf000 rw-p [heap]
be9d6000 be9f7000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4572)
Call Stack Count: 1
 0: (0xb2f0a740) (null)
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
06) > _watch_core_time_tick
02-18 04:29:32.200-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:32.290-0500 E/PKGMGR_SERVER( 4883): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
02-18 04:29:32.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:32.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:32.600-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:32.600-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:32.620-0500 E/rpm-installer( 4884): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
02-18 04:29:32.730-0500 W/MM_CAMCORDER( 4888): mm_camcorder_internal.c: _mmcamcorder_constructor(204) >  start
02-18 04:29:32.730-0500 W/MM_CAMCORDER( 4888): mm_camcorder_internal.c: _mmcamcorder_constructor(214) >  done
02-18 04:29:32.740-0500 I/efl-extension( 4888): efl_extension.c: eext_mod_init(40) > Init
02-18 04:29:32.800-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:32.800-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:33.000-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:33.000-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:33.200-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:33.200-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:33.250-0500 W/WATCH_CORE( 1240): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
02-18 04:29:33.250-0500 W/STARTER ( 1109): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
02-18 04:29:33.250-0500 W/STARTER ( 1109): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
02-18 04:29:33.250-0500 E/STARTER ( 1109): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
02-18 04:29:33.250-0500 W/STARTER ( 1109): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
02-18 04:29:33.250-0500 W/STARTER ( 1109): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
02-18 04:29:33.260-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : -1226675444[0;m
02-18 04:29:33.260-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
02-18 04:29:33.260-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
02-18 04:29:33.260-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Disable start
02-18 04:29:33.270-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Disable end. (ret: 0x0)
02-18 04:29:33.270-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-18 04:29:33.270-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
02-18 04:29:33.270-0500 I/HIGEAR  ( 1580): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
02-18 04:29:33.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:33.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:33.480-0500 W/MUSIC_CONTROL_SERVICE( 1307): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1307]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
02-18 04:29:33.490-0500 W/W_HOME  ( 1163): dbus.c: _dbus_message_recv_cb(204) > LCD off
02-18 04:29:33.490-0500 W/W_HOME  ( 1163): gesture.c: _manual_render_disable_timer_del(151) > timer del
02-18 04:29:33.490-0500 W/W_HOME  ( 1163): gesture.c: _manual_render_enable(133) > 1
02-18 04:29:33.490-0500 W/W_HOME  ( 1163): event_manager.c: _lcd_off_cb(699) > lcd state: 0
02-18 04:29:33.500-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 04:29:33.500-0500 W/STARTER ( 1109): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
02-18 04:29:33.500-0500 W/STARTER ( 1109): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
02-18 04:29:33.500-0500 W/STARTER ( 1109): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
02-18 04:29:33.500-0500 W/STARTER ( 1109): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[1]
02-18 04:29:33.510-0500 I/APP_CORE( 1163): appcore-efl.c: __do_app(429) > [APP 1163] Event: PAUSE State: RUNNING
02-18 04:29:33.510-0500 I/CAPI_APPFW_APPLICATION( 1163): app_main.c: app_appcore_pause(202) > app_appcore_pause
02-18 04:29:33.510-0500 W/W_HOME  ( 1163): main.c: _appcore_pause_cb(692) > appcore pause
02-18 04:29:33.510-0500 W/W_HOME  ( 1163): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
02-18 04:29:33.510-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 04:29:33.510-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 04:29:33.510-0500 W/W_HOME  ( 1163): main.c: home_pause(762) > clock/widget paused
02-18 04:29:33.510-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 04:29:33.510-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:29:33.510-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:29:33.510-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:29:33.510-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 04:29:33.510-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 04:29:33.510-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:29:33.510-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 04:29:33.510-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:29:33.510-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:29:33.510-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:29:33.510-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:29:33.510-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 04:29:33.510-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 04:29:33.510-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:29:33.510-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 04:29:33.510-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 04:29:33.510-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 04:29:33.510-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:29:33.510-0500 E/CAPI_APPFW_APP_CONTROL( 1307): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
02-18 04:29:33.510-0500 W/MUSIC_CONTROL_SERVICE( 1307): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1307]   [com.samsung.w-home]register msg port [false][0m
02-18 04:29:33.510-0500 I/SHealth_Common( 1619): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
02-18 04:29:33.510-0500 I/SHealth_Service( 1619): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
02-18 04:29:33.510-0500 W/GESTURE (  249): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
02-18 04:29:33.560-0500 W/WATCH_CORE( 1240): appcore-watch.c: __widget_pause(1001) > widget_pause
02-18 04:29:33.560-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppPause(713) > 
02-18 04:29:33.560-0500 E/watchface-viewer( 1240): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 04:29:33.560-0500 E/watchface-viewer( 1240): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 04:29:33.560-0500 E/watchface-viewer( 1240): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 04:29:33.560-0500 E/watchface-viewer( 1240): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 04:29:33.650-0500 I/AUL     ( 4888): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 04:29:33.690-0500 I/AUL     ( 4888): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 04:29:33.690-0500 E/AUL     ( 4888): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-18 04:29:33.690-0500 E/AUL     ( 4888): aul_path.c: __get_path(169) > root_path is NULL!
02-18 04:29:33.710-0500 I/AUL     ( 4888): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 04:29:33.720-0500 I/AUL     ( 4888): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 04:29:33.740-0500 E/AUL     ( 4888): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-18 04:29:33.740-0500 E/AUL     ( 4888): aul_path.c: __get_path(169) > root_path is NULL!
02-18 04:29:33.740-0500 E/EFL     ( 4888): elementary<4888> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 04:29:33.740-0500 E/EFL     ( 4888): elementary<4888> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 04:29:33.760-0500 E/EFL     ( 4888): elementary<4888> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 04:29:33.760-0500 I/UXT     ( 4888): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
02-18 04:29:33.760-0500 E/EFL     ( 4888): elementary<4888> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 04:29:33.800-0500 E/EFL     ( 4888): elementary<4888> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 04:29:33.800-0500 E/EFL     ( 4888): elementary<4888> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 04:29:33.800-0500 E/EFL     ( 4888): elementary<4888> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 04:29:33.800-0500 E/EFL     ( 4888): elementary<4888> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 04:29:33.800-0500 E/EFL     ( 4888): elementary<4888> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 04:29:33.820-0500 E/EFL     ( 4888): elementary<4888> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 04:29:33.820-0500 E/EFL     ( 4888): elementary<4888> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 04:29:33.820-0500 E/EFL     ( 4888): elementary<4888> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 04:29:33.840-0500 E/EFL     ( 4888): elementary<4888> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 04:29:33.850-0500 E/EFL     ( 4888): elementary<4888> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 04:29:33.850-0500 E/EFL     ( 4888): elementary<4888> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 04:29:33.850-0500 E/EFL     ( 4888): elementary<4888> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 04:29:33.850-0500 E/EFL     ( 4888): elementary<4888> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 04:29:33.850-0500 E/EFL     ( 4888): elementary<4888> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 04:29:33.850-0500 E/EFL     ( 4888): elementary<4888> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 04:29:33.870-0500 I/Adreno-EGL( 4888): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
02-18 04:29:33.870-0500 I/Adreno-EGL( 4888): OpenGL ES Shader Compiler Version: E031.24.00.16
02-18 04:29:33.870-0500 I/Adreno-EGL( 4888): Build Date: 09/02/15 Wed
02-18 04:29:33.870-0500 I/Adreno-EGL( 4888): Local Branch: 
02-18 04:29:33.870-0500 I/Adreno-EGL( 4888): Remote Branch: 
02-18 04:29:33.870-0500 I/Adreno-EGL( 4888): Local Patches: 
02-18 04:29:33.870-0500 I/Adreno-EGL( 4888): Reconstruct Branch: 
02-18 04:29:33.940-0500 W/Adreno-ES20( 4888): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:29:33.940-0500 W/Adreno-ES20( 4888): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:29:33.940-0500 W/Adreno-ES20( 4888): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:29:33.940-0500 W/Adreno-ES20( 4888): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:29:33.940-0500 W/Adreno-ES20( 4888): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:29:33.940-0500 W/Adreno-ES20( 4888): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:29:33.940-0500 W/Adreno-ES20( 4888): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:29:33.940-0500 W/Adreno-ES20( 4888): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:29:33.940-0500 W/Adreno-ES20( 4888): <get_simple_queries:1550>: GL_INVALID_ENUM
02-18 04:29:34.010-0500 I/APP_CORE( 1163): appcore-efl.c: __do_app(429) > [APP 1163] Event: MEM_FLUSH State: PAUSED
02-18 04:29:34.290-0500 E/PKGMGR_SERVER( 4883): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
02-18 04:29:34.600-0500 W/WATCH_CORE( 1240): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
02-18 04:29:34.600-0500 W/W_HOME  ( 1163): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
02-18 04:29:34.600-0500 I/WATCH_CORE( 1240): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
02-18 04:29:34.600-0500 W/W_HOME  ( 1163): gesture.c: _manual_render_schedule(211) > schedule, manual render
02-18 04:29:34.600-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:34.600-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:34.600-0500 I/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
02-18 04:29:34.600-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : -1216381368[0;m
02-18 04:29:34.600-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
02-18 04:29:34.600-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
02-18 04:29:34.600-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 0
02-18 04:29:34.610-0500 W/WATCH_CORE( 1240): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
02-18 04:29:34.610-0500 I/WATCH_CORE( 1240): appcore-watch.c: __signal_lcd_status_handler(1149) > Call the time_tick_cb
02-18 04:29:34.610-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:34.610-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:34.610-0500 I/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
02-18 04:29:34.610-0500 W/W_HOME  ( 1163): dbus.c: _dbus_message_recv_cb(186) > LCD on
02-18 04:29:34.610-0500 W/W_HOME  ( 1163): gesture.c: _manual_render_disable_timer_set(161) > timer set
02-18 04:29:34.610-0500 W/W_HOME  ( 1163): gesture.c: _manual_render_disable_timer_del(151) > timer del
02-18 04:29:34.610-0500 W/W_HOME  ( 1163): gesture.c: _apps_status_get(123) > apps status:0
02-18 04:29:34.610-0500 W/W_HOME  ( 1163): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:1 info->offtime:1372
02-18 04:29:34.610-0500 W/W_HOME  ( 1163): gesture.c: _manual_render_schedule(211) > schedule, manual render
02-18 04:29:34.610-0500 W/W_HOME  ( 1163): event_manager.c: _lcd_on_cb(691) > lcd state: 1
02-18 04:29:34.610-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 04:29:34.620-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 04:29:34.620-0500 W/STARTER ( 1109): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [gesture] after screen off time [1372]ms
02-18 04:29:34.620-0500 W/STARTER ( 1109): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
02-18 04:29:34.620-0500 I/APP_CORE( 1163): appcore-efl.c: __do_app(429) > [APP 1163] Event: RESUME State: PAUSED
02-18 04:29:34.620-0500 I/CAPI_APPFW_APPLICATION( 1163): app_main.c: app_appcore_resume(223) > app_appcore_resume
02-18 04:29:34.620-0500 W/W_HOME  ( 1163): main.c: _appcore_resume_cb(683) > appcore resume
02-18 04:29:34.620-0500 W/W_HOME  ( 1163): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
02-18 04:29:34.620-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 04:29:34.620-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupServiceStart(395) > [0;32mINFO: 500[0;m
02-18 04:29:34.620-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 500
02-18 04:29:34.620-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 04:29:34.620-0500 W/W_HOME  ( 1163): main.c: home_resume(731) > journal_appcore_app_fully_loaded called
02-18 04:29:34.620-0500 W/W_HOME  ( 1163): main.c: home_resume(735) > clock/widget resumed
02-18 04:29:34.620-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 04:29:34.620-0500 W/GESTURE (  249): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
02-18 04:29:34.630-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 04:29:34.630-0500 W/WATCH_CORE( 1240): appcore-watch.c: __widget_resume(1012) > widget_resume
02-18 04:29:34.630-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppResume(721) > 
02-18 04:29:34.630-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:34.630-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:34.650-0500 W/W_HOME  ( 1163): gesture.c: _widget_updated_cb(190) > widget updated
02-18 04:29:34.650-0500 W/W_HOME  ( 1163): gesture.c: _manual_render_disable_timer_del(151) > timer del
02-18 04:29:34.650-0500 W/W_HOME  ( 1163): gesture.c: _manual_render(176) > 
02-18 04:29:34.670-0500 W/W_HOME  ( 1163): gesture.c: _manual_render(176) > 
02-18 04:29:34.700-0500 W/W_HOME  ( 1163): gesture.c: _manual_render_enable(133) > 0
02-18 04:29:34.710-0500 W/MUSIC_CONTROL_SERVICE( 1307): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1307]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
02-18 04:29:34.710-0500 I/SHealth_Common( 1619): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
02-18 04:29:34.710-0500 I/SHealth_Service( 1619): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
02-18 04:29:34.740-0500 W/STARTER ( 1109): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [gesture]
02-18 04:29:34.740-0500 W/STARTER ( 1109): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
02-18 04:29:34.830-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:34.830-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:34.840-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1619): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
02-18 04:29:34.840-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1619): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
02-18 04:29:34.840-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1619): preference.c: preference_get_double(1214) > preference_get_double(1619) : pedometer_inactive_period error
02-18 04:29:34.840-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1619): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
02-18 04:29:34.840-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1619): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-18 04:29:34.840-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1619): preference.c: preference_get_double(1214) > preference_get_double(1619) : inactive_10min_precaution_millisec error
02-18 04:29:34.840-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1619): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
02-18 04:29:34.840-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1619): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-18 04:29:34.840-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1619): preference.c: preference_get_double(1214) > preference_get_double(1619) : inactive_before_10min_precaution_millisec error
02-18 04:29:35.020-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:35.020-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:35.100-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Enable start
02-18 04:29:35.120-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Enable end. (ret: 0x0)
02-18 04:29:35.120-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-18 04:29:35.120-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
02-18 04:29:35.120-0500 I/HIGEAR  ( 1580): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
02-18 04:29:35.120-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : -1226675444[0;m
02-18 04:29:35.120-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
02-18 04:29:35.120-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
02-18 04:29:35.120-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 0
02-18 04:29:35.120-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 04:29:35.120-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupServiceStart(395) > [0;32mINFO: 500[0;m
02-18 04:29:35.120-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 500
02-18 04:29:35.130-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 04:29:35.130-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Enable start
02-18 04:29:35.130-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Enable end. (ret: 0x0)
02-18 04:29:35.130-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-18 04:29:35.130-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
02-18 04:29:35.130-0500 I/HIGEAR  ( 1580): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
02-18 04:29:35.220-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:35.220-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:35.410-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:35.410-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:35.610-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:35.610-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:35.620-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:29:35.620-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:29:35.620-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:29:35.620-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 04:29:35.620-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 04:29:35.620-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:29:35.620-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 04:29:35.620-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:29:35.620-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:29:35.620-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:29:35.620-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:29:35.620-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 04:29:35.620-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 04:29:35.620-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:29:35.620-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 04:29:35.620-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 04:29:35.620-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 04:29:35.620-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:29:35.620-0500 E/CAPI_APPFW_APP_CONTROL( 1307): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
02-18 04:29:35.620-0500 W/MUSIC_CONTROL_SERVICE( 1307): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1307]   [com.samsung.w-home]register msg port [true][0m
02-18 04:29:35.620-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
02-18 04:29:35.630-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1163
02-18 04:29:35.640-0500 W/MUSIC_CONTROL_SERVICE( 1307): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1307]   [MUSIC_PLAYER_EVENT][0m
02-18 04:29:35.640-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1307): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
02-18 04:29:35.640-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1307): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
02-18 04:29:35.640-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1307): preference.c: preference_get_int(1132) > preference_get_int(1307) : key(music-control-service_native/playing_diration) error
02-18 04:29:35.640-0500 W/MUSIC_CONTROL_SERVICE( 1307): music-control-info.c: music_control_info_get_player_position(582) > [31m[TID:1307]   preference_get_int() .. [0xfef00030][0m
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:29:35.640-0500 W/W_HOME  ( 1163): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
02-18 04:29:35.640-0500 E/W_HOME  ( 1163): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
02-18 04:29:35.640-0500 W/MUSIC_CONTROL_SERVICE( 1307): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1307]   [MUSIC_PLAYER_EVENT][0m
02-18 04:29:35.640-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1307): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
02-18 04:29:35.640-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1307): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
02-18 04:29:35.640-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1307): preference.c: preference_get_int(1132) > preference_get_int(1307) : key(music-control-service_native/playing_diration) error
02-18 04:29:35.640-0500 W/MUSIC_CONTROL_SERVICE( 1307): music-control-info.c: music_control_info_get_player_position(582) > [31m[TID:1307]   preference_get_int() .. [0xfef00030][0m
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:29:35.640-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:29:35.650-0500 W/W_HOME  ( 1163): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
02-18 04:29:35.650-0500 E/W_HOME  ( 1163): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
02-18 04:29:35.650-0500 I/TIZEN_N_SOUND_MANAGER( 1307): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
02-18 04:29:35.650-0500 W/TIZEN_N_SOUND_MANAGER( 1307): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 04:29:35.650-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:29:35.810-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:35.810-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:36.010-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:36.010-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:36.200-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:36.200-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:36.240-0500 E/PKGMGR_SERVER( 4883): pkgmgr-server.c: sighandler(409) > child NORMAL exit [4884]
02-18 04:29:36.260-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
02-18 04:29:36.270-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, COMPLETED]
02-18 04:29:36.270-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6946) > package install complete
02-18 04:29:36.270-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_package_install_event(4818) > 
02-18 04:29:36.270-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1758) > Found in install_req_list?[0], index[-1]
02-18 04:29:36.290-0500 E/PKGMGR_SERVER( 4883): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
02-18 04:29:36.290-0500 E/PKGMGR_SERVER( 4883): pkgmgr-server.c: main(2185) > package manager server terminated.
02-18 04:29:36.290-0500 W/W_HOME  ( 1163): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.example.metronomo is updated, need to check validation
02-18 04:29:36.290-0500 W/W_HOME  ( 1163): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:com.samsung.watchface
02-18 04:29:36.360-0500 W/APPS    ( 1163): pkgmgr.c: _update_app(739) >  old order:[26]
02-18 04:29:36.400-0500 E/STARTER ( 1109): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
02-18 04:29:36.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:36.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:36.450-0500 E/EFL     ( 1163): elementary<1163> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0xb78abaf0 into part 'elm.swallow.event.0'
02-18 04:29:36.450-0500 E/APPS    ( 1163): AppsViewNecklace.cpp: onShow(597) >  AppsItemList[27]
02-18 04:29:36.460-0500 E/PKGMGR_INFO(  898): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
02-18 04:29:36.510-0500 E/Vi::Animations( 1163): result Vi::Animations::_AnimationManager::addAnimation(Vi::Animations::Visual&, const string*, Vi::Animations::Animation&)(288) > [E_OBJ_ALREADY_EXIST] Animation with keyName already exists. key name = hide
02-18 04:29:36.510-0500 I/Vi::Animations( 1163): result Vi::Animations::_VisualImpl::addAnimation(const string*, Vi::Animations::Animation&)(6999) > [E_OBJ_ALREADY_EXIST] Propagating.
02-18 04:29:36.510-0500 E/EFL     ( 1163): elementary<1163> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0xb78abaf0 into part 'elm.swallow.event.0'
02-18 04:29:36.510-0500 E/APPS    ( 1163): AppsViewNecklace.cpp: onShow(597) >  AppsItemList[28]
02-18 04:29:36.600-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:36.600-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:36.800-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:36.800-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:37.000-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:37.000-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:37.020-0500 W/APPS    ( 1163): pkgmgr.c: _update_app_cb(718) >  Update apps order
02-18 04:29:37.020-0500 W/APPS    ( 1163): AppsViewNecklace.cpp: onTouchEventCancel(4360) >  touch cancel
02-18 04:29:37.200-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:37.200-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:37.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:37.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:37.600-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:37.600-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:37.800-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:37.800-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:38.000-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:38.000-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:38.140-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 0
02-18 04:29:38.150-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
02-18 04:29:38.160-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
02-18 04:29:38.160-0500 E/AUL_AMD (  934): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
02-18 04:29:38.160-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(1708) > caller pid : 4955
02-18 04:29:38.170-0500 W/AUL_AMD (  934): amd_launch.c: __nofork_processing(1151) > __nofork_processing, cmd: 0, pid: 4572
02-18 04:29:38.170-0500 I/APP_CORE( 4572): appcore-efl.c: __do_app(429) > [APP 4572] Event: RESET State: PAUSED
02-18 04:29:38.170-0500 I/CAPI_APPFW_APPLICATION( 4572): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
02-18 04:29:38.180-0500 W/AUL_AMD (  934): amd_launch.c: __reply_handler(922) > listen fd(20) , send fd(15), pid(4572), cmd(0)
02-18 04:29:38.200-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:29:38.200-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:29:38.390-0500 W/CRASH_MANAGER( 4956): worker.c: worker_job(1199) > 11045726d6574148741017
