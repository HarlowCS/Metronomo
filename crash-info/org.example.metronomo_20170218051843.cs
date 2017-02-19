S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.5
Build-Number: R730VVRU2BPC7
Build-Date: 2016.04.01 13:23:02

Crash Information
Process Name: metronomo
PID: 4005
Date: 2017-02-18 05:18:43-0500
Executable File Path: /opt/usr/apps/org.example.metronomo/bin/metronomo
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xbc4

Register Information
r0   = 0x00000003, r1   = 0xb583e5a9
r2   = 0xb583e50c, r3   = 0x00000000
r4   = 0xb7dff690, r5   = 0xb2f36e48
r6   = 0xb6cc8b18, r7   = 0xbebc1448
r8   = 0xb6cba16c, r9   = 0x00000001
r10  = 0xb6cba8ec, fp   = 0xb6cba8ec
ip   = 0xb584e82c, sp   = 0xbebc1428
lr   = 0xb583df7b, pc   = 0x00000bc4
cpsr = 0x20000010

Memory Information
MemTotal:   389300 KB
MemFree:     19724 KB
Buffers:     13120 KB
Cached:      91544 KB
VmPeak:      70476 KB
VmSize:      69392 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15136 KB
VmRSS:       15136 KB
VmData:      13228 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23056 KB
VmPTE:          48 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4005 TID = 4005
4005 4093 

Maps Information
b2d68000 b2def000 rw-s anon_inode:dmabuf
b2def000 b2df2000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b2dfa000 b2e81000 rw-s anon_inode:dmabuf
b302a000 b302b000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
b30dd000 b38dc000 rw-p [stack:4093]
b38dc000 b38f3000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3900000 b3902000 r-xp /usr/lib/libgenlock.so
b3912000 b3914000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3920000 b3925000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b392d000 b3938000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b3ca0000 b3d6a000 r-xp /usr/lib/libCOREGL.so.4.0
b3d7b000 b3d84000 r-xp /usr/lib/libresourced.so.0.2.86
b3d8c000 b3d8d000 r-xp /usr/lib/librd-network.so.0.2.86
b3d95000 b3da2000 r-xp /usr/lib/libail.so.0.1.0
b3dab000 b3db2000 r-xp /usr/lib/libminizip.so.1.0.0
b3dba000 b3dbc000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b3dc4000 b3dcb000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b3dd4000 b3df0000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b3df9000 b3e01000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
b3e09000 b3e0f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b3e17000 b3e1c000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
b3e24000 b3e45000 r-xp /usr/lib/libexif.so.12.3.3
b3e58000 b3e71000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
b3e79000 b3e7e000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3e86000 b3e8b000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b541b000 b541d000 r-xp /usr/lib/libdri2.so.0.0.0
b5425000 b542d000 r-xp /usr/lib/libdrm.so.2.4.0
b5435000 b5436000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b543f000 b5442000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
b544a000 b552e000 r-xp /usr/lib/libicuuc.so.51.1
b5543000 b5680000 r-xp /usr/lib/libicui18n.so.51.1
b5690000 b5696000 r-xp /usr/lib/libxcb-render.so.0.0.0
b569e000 b569f000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b56a8000 b56ab000 r-xp /usr/lib/libEGL.so.1.4
b56b3000 b56c1000 r-xp /usr/lib/libGLESv2.so.2.0
b56ca000 b56d1000 r-xp /usr/lib/libtbm.so.1.0.0
b56d9000 b56fa000 r-xp /usr/lib/libui-extension.so.0.1.0
b5703000 b5715000 r-xp /usr/lib/libtts.so
b571d000 b57d5000 r-xp /usr/lib/libcairo.so.2.11200.14
b57e0000 b57f2000 r-xp /usr/lib/libefl-assist.so.0.1.0
b57fa000 b57ff000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b5807000 b5828000 r-xp /usr/lib/libefl-extension.so.0.1.0
b5830000 b5835000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b583d000 b583f000 r-xp /opt/usr/apps/org.example.metronomo/bin/metronomo
b59ee000 b59f8000 r-xp /lib/libnss_files-2.13.so
b5a01000 b5ad0000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5ae6000 b5b0a000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5b13000 b5b19000 r-xp /usr/lib/libappsvc.so.0.1.0
b5b21000 b5b23000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5b2c000 b5b30000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5b3c000 b5b47000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b5b4f000 b5b51000 r-xp /usr/lib/libiniparser.so.0
b5b5a000 b5b5f000 r-xp /usr/lib/libappcore-common.so.1.1
b5b68000 b5b70000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b5b71000 b5b75000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5b82000 b5b84000 r-xp /usr/lib/libXau.so.6.0.0
b5b8d000 b5b94000 r-xp /lib/libcrypt-2.13.so
b5bc4000 b5bc6000 r-xp /usr/lib/libiri.so
b5bce000 b5d76000 r-xp /usr/lib/libcrypto.so.1.0.0
b5d8f000 b5ddc000 r-xp /usr/lib/libssl.so.1.0.0
b5de9000 b5e17000 r-xp /usr/lib/libidn.so.11.5.44
b5e1f000 b5e28000 r-xp /usr/lib/libcares.so.2.1.0
b5e31000 b5e44000 r-xp /usr/lib/libxcb.so.1.1.0
b5e4d000 b5e4f000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5e58000 b5e5a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5e63000 b5f2f000 r-xp /usr/lib/libxml2.so.2.7.8
b5f3c000 b5f3e000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5f46000 b5f4b000 r-xp /usr/lib/libffi.so.5.0.10
b5f53000 b5f54000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5f5d000 b5f68000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5f70000 b5f73000 r-xp /lib/libattr.so.1.1.0
b5f7b000 b600f000 r-xp /usr/lib/libstdc++.so.6.0.16
b6022000 b603f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b6048000 b6060000 r-xp /usr/lib/libpng12.so.0.50.0
b6069000 b607f000 r-xp /lib/libexpat.so.1.5.2
b6089000 b60cd000 r-xp /usr/lib/libcurl.so.4.3.0
b60d6000 b60e0000 r-xp /usr/lib/libXext.so.6.4.0
b60e9000 b60ed000 r-xp /usr/lib/libXtst.so.6.1.0
b60f5000 b60fb000 r-xp /usr/lib/libXrender.so.1.3.0
b6104000 b610a000 r-xp /usr/lib/libXrandr.so.2.2.0
b6112000 b6113000 r-xp /usr/lib/libXinerama.so.1.0.0
b611c000 b6125000 r-xp /usr/lib/libXi.so.6.1.0
b612d000 b6130000 r-xp /usr/lib/libXfixes.so.3.1.0
b6138000 b613a000 r-xp /usr/lib/libXgesture.so.7.0.0
b6142000 b6144000 r-xp /usr/lib/libXcomposite.so.1.0.0
b614d000 b614f000 r-xp /usr/lib/libXdamage.so.1.1.0
b6157000 b615e000 r-xp /usr/lib/libXcursor.so.1.0.2
b6166000 b6169000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6171000 b6175000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b617e000 b6183000 r-xp /usr/lib/libecore_fb.so.1.7.99
b618d000 b626e000 r-xp /usr/lib/libX11.so.6.3.0
b6279000 b629c000 r-xp /usr/lib/libjpeg.so.8.0.2
b62b4000 b62ca000 r-xp /lib/libz.so.1.2.5
b62d2000 b6347000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6351000 b6367000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6370000 b63a4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b63ad000 b6480000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b648b000 b649b000 r-xp /lib/libresolv-2.13.so
b649f000 b651b000 r-xp /usr/lib/libgcrypt.so.20.0.3
b6527000 b653f000 r-xp /usr/lib/liblzma.so.5.0.3
b6548000 b654b000 r-xp /lib/libcap.so.2.21
b6553000 b6580000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6588000 b6589000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b6591000 b6597000 r-xp /usr/lib/libecore_imf.so.1.7.99
b659f000 b65b6000 r-xp /usr/lib/liblua-5.1.so
b65c0000 b65c7000 r-xp /usr/lib/libembryo.so.1.7.99
b65cf000 b65d5000 r-xp /lib/librt-2.13.so
b65de000 b6634000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6641000 b6697000 r-xp /usr/lib/libfreetype.so.6.11.3
b66a3000 b66cb000 r-xp /usr/lib/libfontconfig.so.1.8.0
b66cd000 b670a000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6713000 b6726000 r-xp /usr/lib/libfribidi.so.0.3.1
b672e000 b6748000 r-xp /usr/lib/libecore_con.so.1.7.99
b6751000 b675a000 r-xp /usr/lib/libedbus.so.1.7.99
b6762000 b67b2000 r-xp /usr/lib/libecore_x.so.1.7.99
b67b5000 b67b9000 r-xp /usr/lib/libvconf.so.0.2.45
b67c1000 b67d2000 r-xp /usr/lib/libecore_input.so.1.7.99
b67da000 b67df000 r-xp /usr/lib/libecore_file.so.1.7.99
b67e7000 b6809000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6812000 b6853000 r-xp /usr/lib/libeina.so.1.7.99
b685c000 b6875000 r-xp /usr/lib/libeet.so.1.7.99
b6886000 b68ef000 r-xp /lib/libm-2.13.so
b68f8000 b68fe000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b6907000 b690a000 r-xp /usr/lib/libproc-stat.so.0.2.86
b6912000 b6934000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b693c000 b6941000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6949000 b6973000 r-xp /usr/lib/libdbus-1.so.3.8.12
b697c000 b6993000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b699b000 b69a6000 r-xp /lib/libunwind.so.8.0.1
b69d3000 b6a0f000 r-xp /usr/lib/libsystemd.so.0.4.0
b6a18000 b6b33000 r-xp /lib/libc-2.13.so
b6b41000 b6b49000 r-xp /lib/libgcc_s-4.6.so.1
b6b4a000 b6b4d000 r-xp /usr/lib/libsmack.so.1.0.0
b6b55000 b6b5b000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6b63000 b6c33000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c34000 b6c91000 r-xp /usr/lib/libedje.so.1.7.99
b6c9b000 b6cb2000 r-xp /usr/lib/libecore.so.1.7.99
b6cc9000 b6d97000 r-xp /usr/lib/libevas.so.1.7.99
b6dbc000 b6ef7000 r-xp /usr/lib/libelementary.so.1.7.99
b6f0d000 b6f21000 r-xp /lib/libpthread-2.13.so
b6f2c000 b6f2e000 r-xp /usr/lib/libdlog.so.0.0.0
b6f36000 b6f39000 r-xp /usr/lib/libbundle.so.0.1.22
b6f41000 b6f43000 r-xp /lib/libdl-2.13.so
b6f4c000 b6f58000 r-xp /usr/lib/libaul.so.0.1.0
b6f6a000 b6f6f000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f78000 b6f7c000 r-xp /usr/lib/libsys-assert.so
b6f85000 b6fa2000 r-xp /lib/ld-2.13.so
b6fab000 b6fb0000 r-xp /usr/bin/launchpad-loader
b7d3f000 b7edd000 rw-p [heap]
beba1000 bebc2000 rw-p [stack]
b7d3f000 b7edd000 rw-p [heap]
beba1000 bebc2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4005)
Call Stack Count: 1
 0: (0xbc4) (null)
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
ence_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-18 05:18:24.837-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: preference_get_double(1214) > preference_get_double(1631) : inactive_10min_precaution_millisec error
02-18 05:18:24.837-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
02-18 05:18:24.837-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-18 05:18:24.837-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: preference_get_double(1214) > preference_get_double(1631) : inactive_before_10min_precaution_millisec error
02-18 05:18:24.957-0500 I/efl-extension( 4248): efl_extension.c: eext_mod_init(40) > Init
02-18 05:18:25.017-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 05:18:25.017-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 05:18:25.037-0500 E/EFL     ( 4248): elementary<4248> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 05:18:25.037-0500 E/EFL     ( 4248): elementary<4248> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 05:18:25.067-0500 W/WATCH_CORE( 1240): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 2
02-18 05:18:25.067-0500 I/WATCH_CORE( 1240): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
02-18 05:18:25.067-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 05:18:25.067-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 05:18:25.077-0500 W/WATCH_CORE( 1240): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
02-18 05:18:25.077-0500 W/W_HOME  ( 1175): dbus.c: _dbus_message_recv_cb(204) > LCD off
02-18 05:18:25.077-0500 W/W_HOME  ( 1175): gesture.c: _manual_render_disable_timer_del(151) > timer del
02-18 05:18:25.077-0500 W/W_HOME  ( 1175): gesture.c: _manual_render_enable(133) > 1
02-18 05:18:25.077-0500 W/W_HOME  ( 1175): event_manager.c: _lcd_off_cb(699) > lcd state: 0
02-18 05:18:25.077-0500 W/W_HOME  ( 1175): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 05:18:25.077-0500 W/W_HOME  ( 1175): event_manager.c: _state_control(333) > appcore paused manually
02-18 05:18:25.077-0500 W/W_HOME  ( 1175): main.c: home_appcore_pause(719) > Home Appcore Paused
02-18 05:18:25.077-0500 W/W_HOME  ( 1175): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
02-18 05:18:25.077-0500 W/W_HOME  ( 1175): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 05:18:25.077-0500 W/W_HOME  ( 1175): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 05:18:25.077-0500 W/W_HOME  ( 1175): main.c: home_pause(762) > clock/widget paused
02-18 05:18:25.077-0500 W/W_HOME  ( 1175): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 05:18:25.077-0500 I/MESSAGE_PORT(  883): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 05:18:25.077-0500 I/MESSAGE_PORT(  883): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 05:18:25.077-0500 I/MESSAGE_PORT(  883): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 05:18:25.077-0500 I/MESSAGE_PORT(  883): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 05:18:25.077-0500 I/MESSAGE_PORT(  883): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 05:18:25.077-0500 I/MESSAGE_PORT(  883): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 05:18:25.077-0500 I/MESSAGE_PORT(  883): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 05:18:25.077-0500 I/MESSAGE_PORT(  883): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 05:18:25.077-0500 I/MESSAGE_PORT(  883): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 05:18:25.077-0500 I/MESSAGE_PORT(  883): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 05:18:25.087-0500 I/MESSAGE_PORT(  883): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 05:18:25.087-0500 I/MESSAGE_PORT(  883): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 05:18:25.087-0500 I/MESSAGE_PORT(  883): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 05:18:25.087-0500 I/MESSAGE_PORT(  883): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 05:18:25.087-0500 I/MESSAGE_PORT(  883): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 05:18:25.087-0500 I/MESSAGE_PORT(  883): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 05:18:25.087-0500 I/MESSAGE_PORT(  883): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 05:18:25.087-0500 I/MESSAGE_PORT(  883): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 05:18:25.087-0500 E/CAPI_APPFW_APP_CONTROL( 1312): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
02-18 05:18:25.087-0500 W/MUSIC_CONTROL_SERVICE( 1312): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1312]   [com.samsung.w-home]register msg port [false][0m
02-18 05:18:25.087-0500 W/STARTER ( 1101): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [gesture]
02-18 05:18:25.087-0500 W/STARTER ( 1101): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
02-18 05:18:25.087-0500 E/STARTER ( 1101): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
02-18 05:18:25.087-0500 W/STARTER ( 1101): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
02-18 05:18:25.087-0500 W/STARTER ( 1101): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
02-18 05:18:25.097-0500 W/WATCH_CORE( 1240): appcore-watch.c: __widget_pause(1001) > widget_pause
02-18 05:18:25.097-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppPause(713) > 
02-18 05:18:25.097-0500 E/watchface-viewer( 1240): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 05:18:25.097-0500 E/watchface-viewer( 1240): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 05:18:25.097-0500 E/watchface-viewer( 1240): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 05:18:25.097-0500 E/watchface-viewer( 1240): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 05:18:25.107-0500 W/WAKEUP-SERVICE( 1584): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : -1226196212[0;m
02-18 05:18:25.107-0500 W/WAKEUP-SERVICE( 1584): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
02-18 05:18:25.107-0500 W/WAKEUP-SERVICE( 1584): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
02-18 05:18:25.107-0500 I/TIZEN_N_SOUND_MANAGER( 1584): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Disable start
02-18 05:18:25.117-0500 I/TIZEN_N_SOUND_MANAGER( 1584): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Disable end. (ret: 0x0)
02-18 05:18:25.117-0500 W/TIZEN_N_SOUND_MANAGER( 1584): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-18 05:18:25.117-0500 W/WAKEUP-SERVICE( 1584): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
02-18 05:18:25.117-0500 I/HIGEAR  ( 1584): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
02-18 05:18:25.127-0500 E/EFL     ( 4248): elementary<4248> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 05:18:25.127-0500 I/UXT     ( 4248): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
02-18 05:18:25.127-0500 E/EFL     ( 4248): elementary<4248> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 05:18:25.157-0500 E/EFL     ( 4248): elementary<4248> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 05:18:25.157-0500 E/EFL     ( 4248): elementary<4248> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 05:18:25.167-0500 E/EFL     ( 4248): elementary<4248> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 05:18:25.167-0500 E/EFL     ( 4248): elementary<4248> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 05:18:25.167-0500 E/EFL     ( 4248): elementary<4248> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 05:18:25.187-0500 E/EFL     ( 4248): elementary<4248> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 05:18:25.187-0500 E/EFL     ( 4248): elementary<4248> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 05:18:25.187-0500 E/EFL     ( 4248): elementary<4248> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 05:18:25.237-0500 W/GESTURE (  256): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
02-18 05:18:25.247-0500 W/MUSIC_CONTROL_SERVICE( 1312): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1312]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
02-18 05:18:25.267-0500 W/STARTER ( 1101): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [gesture]
02-18 05:18:25.267-0500 W/STARTER ( 1101): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
02-18 05:18:25.267-0500 W/STARTER ( 1101): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
02-18 05:18:25.267-0500 W/STARTER ( 1101): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
02-18 05:18:25.267-0500 I/APP_CORE( 1175): appcore-efl.c: __do_app(429) > [APP 1175] Event: PAUSE State: RUNNING
02-18 05:18:25.267-0500 I/CAPI_APPFW_APPLICATION( 1175): app_main.c: app_appcore_pause(202) > app_appcore_pause
02-18 05:18:25.267-0500 W/W_HOME  ( 1175): main.c: _appcore_pause_cb(692) > appcore pause
02-18 05:18:25.267-0500 E/W_HOME  ( 1175): main.c: _pause_cb(670) > paused already
02-18 05:18:25.307-0500 E/ALARM_MANAGER( 1101): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(18-2-2017, 05:18:45), repeat(1), interval(20), type(-1073741822)
02-18 05:18:25.307-0500 W/ALARM_MANAGER(  901): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
02-18 05:18:25.307-0500 W/ALARM_MANAGER(  901): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
02-18 05:18:25.357-0500 E/ALARM_MANAGER(  901): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1124941619, next duetime: 1487413125
02-18 05:18:25.357-0500 E/ALARM_MANAGER(  901): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1124941619)
02-18 05:18:25.357-0500 E/ALARM_MANAGER(  901): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1487413309), due_time(1487413125)
02-18 05:18:25.357-0500 E/ALARM_MANAGER(  901): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
02-18 05:18:25.357-0500 E/ALARM_MANAGER(  901): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 18-2-2017, 10:18:45 (UTC).
02-18 05:18:25.357-0500 E/ALARM_MANAGER(  901): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
02-18 05:18:25.367-0500 I/SHealth_Common( 1631): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
02-18 05:18:25.367-0500 I/SHealth_Service( 1631): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
02-18 05:18:25.367-0500 E/PKGMGR_SERVER( 4244): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
02-18 05:18:25.397-0500 E/EFL     ( 4248): elementary<4248> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 05:18:25.407-0500 E/EFL     ( 4248): elementary<4248> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 05:18:25.407-0500 E/EFL     ( 4248): elementary<4248> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 05:18:25.407-0500 E/EFL     ( 4248): elementary<4248> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 05:18:25.407-0500 E/EFL     ( 4248): elementary<4248> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 05:18:25.407-0500 E/EFL     ( 4248): elementary<4248> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 05:18:25.407-0500 E/EFL     ( 4248): elementary<4248> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 05:18:25.407-0500 I/AUL_PAD ( 4248): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
02-18 05:18:25.427-0500 I/Adreno-EGL( 4248): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
02-18 05:18:25.427-0500 I/Adreno-EGL( 4248): OpenGL ES Shader Compiler Version: E031.24.00.16
02-18 05:18:25.427-0500 I/Adreno-EGL( 4248): Build Date: 09/02/15 Wed
02-18 05:18:25.427-0500 I/Adreno-EGL( 4248): Local Branch: 
02-18 05:18:25.427-0500 I/Adreno-EGL( 4248): Remote Branch: 
02-18 05:18:25.427-0500 I/Adreno-EGL( 4248): Local Patches: 
02-18 05:18:25.427-0500 I/Adreno-EGL( 4248): Reconstruct Branch: 
02-18 05:18:25.587-0500 I/APP_CORE( 1175): appcore-efl.c: __do_app(429) > [APP 1175] Event: MEM_FLUSH State: PAUSED
02-18 05:18:25.637-0500 E/rpm-installer( 4245): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
02-18 05:18:25.727-0500 W/MM_CAMCORDER( 4249): mm_camcorder_internal.c: _mmcamcorder_constructor(204) >  start
02-18 05:18:25.727-0500 W/MM_CAMCORDER( 4249): mm_camcorder_internal.c: _mmcamcorder_constructor(214) >  done
02-18 05:18:25.737-0500 I/efl-extension( 4249): efl_extension.c: eext_mod_init(40) > Init
02-18 05:18:26.367-0500 I/AUL     ( 4249): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 05:18:26.377-0500 I/AUL     ( 4249): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 05:18:26.377-0500 E/AUL     ( 4249): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-18 05:18:26.377-0500 E/AUL     ( 4249): aul_path.c: __get_path(169) > root_path is NULL!
02-18 05:18:26.387-0500 I/AUL     ( 4249): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 05:18:26.397-0500 I/AUL     ( 4249): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 05:18:26.397-0500 E/AUL     ( 4249): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-18 05:18:26.397-0500 E/AUL     ( 4249): aul_path.c: __get_path(169) > root_path is NULL!
02-18 05:18:26.397-0500 E/EFL     ( 4249): elementary<4249> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 05:18:26.397-0500 E/EFL     ( 4249): elementary<4249> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 05:18:26.417-0500 E/EFL     ( 4249): elementary<4249> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 05:18:26.417-0500 I/UXT     ( 4249): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
02-18 05:18:26.417-0500 E/EFL     ( 4249): elementary<4249> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 05:18:26.447-0500 E/EFL     ( 4249): elementary<4249> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 05:18:26.447-0500 E/EFL     ( 4249): elementary<4249> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 05:18:26.447-0500 E/EFL     ( 4249): elementary<4249> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 05:18:26.447-0500 E/EFL     ( 4249): elementary<4249> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 05:18:26.447-0500 E/EFL     ( 4249): elementary<4249> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 05:18:26.477-0500 E/EFL     ( 4249): elementary<4249> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 05:18:26.477-0500 E/EFL     ( 4249): elementary<4249> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 05:18:26.477-0500 E/EFL     ( 4249): elementary<4249> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 05:18:26.497-0500 E/EFL     ( 4249): elementary<4249> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 05:18:26.507-0500 E/EFL     ( 4249): elementary<4249> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 05:18:26.507-0500 E/EFL     ( 4249): elementary<4249> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 05:18:26.507-0500 E/EFL     ( 4249): elementary<4249> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 05:18:26.507-0500 E/EFL     ( 4249): elementary<4249> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 05:18:26.507-0500 E/EFL     ( 4249): elementary<4249> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 05:18:26.507-0500 E/EFL     ( 4249): elementary<4249> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 05:18:26.537-0500 I/Adreno-EGL( 4249): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
02-18 05:18:26.537-0500 I/Adreno-EGL( 4249): OpenGL ES Shader Compiler Version: E031.24.00.16
02-18 05:18:26.537-0500 I/Adreno-EGL( 4249): Build Date: 09/02/15 Wed
02-18 05:18:26.537-0500 I/Adreno-EGL( 4249): Local Branch: 
02-18 05:18:26.537-0500 I/Adreno-EGL( 4249): Remote Branch: 
02-18 05:18:26.537-0500 I/Adreno-EGL( 4249): Local Patches: 
02-18 05:18:26.537-0500 I/Adreno-EGL( 4249): Reconstruct Branch: 
02-18 05:18:26.597-0500 W/Adreno-ES20( 4249): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 05:18:26.597-0500 W/Adreno-ES20( 4249): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 05:18:26.597-0500 W/Adreno-ES20( 4249): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 05:18:26.597-0500 W/Adreno-ES20( 4249): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 05:18:26.597-0500 W/Adreno-ES20( 4249): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 05:18:26.597-0500 W/Adreno-ES20( 4249): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 05:18:26.597-0500 W/Adreno-ES20( 4249): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 05:18:26.597-0500 W/Adreno-ES20( 4249): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 05:18:26.597-0500 W/Adreno-ES20( 4249): <get_simple_queries:1550>: GL_INVALID_ENUM
02-18 05:18:27.367-0500 E/PKGMGR_SERVER( 4244): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
02-18 05:18:28.787-0500 E/PKGMGR_SERVER( 4244): pkgmgr-server.c: sighandler(409) > child NORMAL exit [4245]
02-18 05:18:28.787-0500 E/WMS     (  908): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
02-18 05:18:28.797-0500 W/W_HOME  ( 1175): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.example.metronomo is updated, need to check validation
02-18 05:18:28.797-0500 W/W_HOME  ( 1175): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:com.samsung.watchface
02-18 05:18:28.807-0500 E/WMS     (  908): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, COMPLETED]
02-18 05:18:28.807-0500 E/WMS     (  908): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6946) > package install complete
02-18 05:18:28.807-0500 E/WMS     (  908): wms_event_handler.c: _wms_event_handler_package_install_event(4818) > 
02-18 05:18:28.807-0500 E/WMS     (  908): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1758) > Found in install_req_list?[0], index[-1]
02-18 05:18:28.887-0500 E/STARTER ( 1101): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
02-18 05:18:28.907-0500 W/APPS    ( 1175): pkgmgr.c: _update_app(739) >  old order:[25]
02-18 05:18:28.927-0500 E/PKGMGR_INFO(  906): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
02-18 05:18:28.957-0500 E/EFL     ( 1175): elementary<1175> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0xb8331ff0 into part 'elm.swallow.event.0'
02-18 05:18:28.967-0500 E/APPS    ( 1175): AppsViewNecklace.cpp: onShow(597) >  AppsItemList[26]
02-18 05:18:29.007-0500 E/Vi::Animations( 1175): result Vi::Animations::_AnimationManager::addAnimation(Vi::Animations::Visual&, const string*, Vi::Animations::Animation&)(288) > [E_OBJ_ALREADY_EXIST] Animation with keyName already exists. key name = hide
02-18 05:18:29.007-0500 I/Vi::Animations( 1175): result Vi::Animations::_VisualImpl::addAnimation(const string*, Vi::Animations::Animation&)(6999) > [E_OBJ_ALREADY_EXIST] Propagating.
02-18 05:18:29.007-0500 E/EFL     ( 1175): elementary<1175> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0xb8331ff0 into part 'elm.swallow.event.0'
02-18 05:18:29.007-0500 E/APPS    ( 1175): AppsViewNecklace.cpp: onShow(597) >  AppsItemList[27]
02-18 05:18:29.367-0500 E/PKGMGR_SERVER( 4244): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
02-18 05:18:29.367-0500 E/PKGMGR_SERVER( 4244): pkgmgr-server.c: main(2185) > package manager server terminated.
02-18 05:18:29.507-0500 W/APPS    ( 1175): pkgmgr.c: _update_app_cb(718) >  Update apps order
02-18 05:18:29.507-0500 W/APPS    ( 1175): AppsViewNecklace.cpp: onTouchEventCancel(4360) >  touch cancel
02-18 05:18:30.267-0500 I/APP_CORE( 1175): appcore-efl.c: __do_app(429) > [APP 1175] Event: MEM_FLUSH State: PAUSED
02-18 05:18:35.487-0500 W/AUL_AMD (  933): amd_request.c: __request_handler(646) > __request_handler: 0
02-18 05:18:35.497-0500 I/AUL_AMD (  933): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
02-18 05:18:35.507-0500 I/AUL_AMD (  933): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
02-18 05:18:35.507-0500 E/AUL_AMD (  933): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
02-18 05:18:35.507-0500 W/AUL_AMD (  933): amd_launch.c: _start_app(1708) > caller pid : 4319
02-18 05:18:35.527-0500 W/AUL_AMD (  933): amd_launch.c: __nofork_processing(1151) > __nofork_processing, cmd: 0, pid: 4005
02-18 05:18:35.527-0500 I/APP_CORE( 4005): appcore-efl.c: __do_app(429) > [APP 4005] Event: RESET State: PAUSED
02-18 05:18:35.527-0500 I/CAPI_APPFW_APPLICATION( 4005): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
02-18 05:18:35.527-0500 I/APP_CORE( 4005): appcore-efl.c: __do_app(479) > Legacy lifecycle: 0
02-18 05:18:35.527-0500 I/APP_CORE( 4005): appcore-efl.c: __do_app(481) > [APP 4005] App already running, raise the window
02-18 05:18:35.537-0500 W/AUL_AMD (  933): amd_launch.c: __reply_handler(922) > listen fd(20) , send fd(15), pid(4005), cmd(0)
02-18 05:18:35.537-0500 E/E17     (  678): e_manager.c: _e_manager_cb_client_message(1506) > ACTIVE REQUEST(0x02e00002)
02-18 05:18:35.537-0500 W/AUL_AMD (  933): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
02-18 05:18:35.537-0500 W/AUL_AMD (  933): amd_launch.c: __e17_status_handler(2254) > back key ungrab error
02-18 05:18:35.547-0500 I/APP_CORE( 4005): appcore-efl.c: __do_app(485) > [APP 4005] Call the resume_cb
02-18 05:18:35.547-0500 I/CAPI_APPFW_APPLICATION( 4005): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
02-18 05:18:35.547-0500 W/W_HOME  ( 1175): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
02-18 05:18:35.547-0500 W/W_HOME  ( 1175): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 05:18:35.547-0500 W/W_HOME  ( 1175): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 05:18:35.547-0500 W/W_HOME  ( 1175): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 05:18:35.547-0500 W/W_HOME  ( 1175): main.c: _ecore_x_message_cb(1233) > main_info.is_win_on_top: 0
02-18 05:18:35.597-0500 W/W_HOME  ( 1175): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(1)
02-18 05:18:35.597-0500 W/W_HOME  ( 1175): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
02-18 05:18:35.597-0500 W/W_HOME  ( 1175): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 05:18:35.597-0500 W/W_HOME  ( 1175): main.c: _window_visibility_cb(1200) > Window [0x2600003] is now visible(1)
02-18 05:18:35.597-0500 I/APP_CORE( 1175): appcore-efl.c: __do_app(429) > [APP 1175] Event: PAUSE State: PAUSED
02-18 05:18:35.597-0500 I/APP_CORE( 1175): appcore-efl.c: __visibility_cb(868) > LCD status is off, skip the AE_RESUME event
02-18 05:18:35.597-0500 I/wnotib  ( 1175): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
02-18 05:18:35.597-0500 E/wnotib  ( 1175): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
02-18 05:18:35.597-0500 I/APP_CORE( 4005): appcore-efl.c: __visibility_cb(855) > LCD status is off, skip the AE_RESUME event
02-18 05:18:35.997-0500 E/AUL     (  933): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
02-18 05:18:42.117-0500 W/WATCH_CORE( 1240): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
02-18 05:18:42.117-0500 I/WATCH_CORE( 1240): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
02-18 05:18:42.117-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 05:18:42.117-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 05:18:42.117-0500 I/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
02-18 05:18:42.117-0500 W/WAKEUP-SERVICE( 1584): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : -1209413968[0;m
02-18 05:18:42.117-0500 W/WAKEUP-SERVICE( 1584): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
02-18 05:18:42.117-0500 W/WAKEUP-SERVICE( 1584): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
02-18 05:18:42.117-0500 I/TIZEN_N_SOUND_MANAGER( 1584): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 0
02-18 05:18:42.127-0500 W/W_HOME  ( 1175): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
02-18 05:18:42.127-0500 W/W_HOME  ( 1175): gesture.c: _manual_render_schedule(211) > schedule, manual render
02-18 05:18:42.167-0500 W/W_HOME  ( 1175): gesture.c: _widget_updated_cb(190) > widget updated
02-18 05:18:42.167-0500 W/W_HOME  ( 1175): gesture.c: _manual_render_disable_timer_del(151) > timer del
02-18 05:18:42.167-0500 W/W_HOME  ( 1175): gesture.c: _manual_render(176) > 
02-18 05:18:42.177-0500 W/TIZEN_N_SOUND_MANAGER( 1584): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 05:18:42.177-0500 W/WAKEUP-SERVICE( 1584): WakeupService.cpp: WakeupServiceStart(395) > [0;32mINFO: 500[0;m
02-18 05:18:42.177-0500 I/TIZEN_N_SOUND_MANAGER( 1584): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 500
02-18 05:18:42.187-0500 W/WATCH_CORE( 1240): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
02-18 05:18:42.187-0500 I/WATCH_CORE( 1240): appcore-watch.c: __signal_lcd_status_handler(1149) > Call the time_tick_cb
02-18 05:18:42.187-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 05:18:42.187-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 05:18:42.187-0500 I/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
02-18 05:18:42.187-0500 W/STARTER ( 1101): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [gesture] after screen off time [17067]ms
02-18 05:18:42.187-0500 W/STARTER ( 1101): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
02-18 05:18:42.187-0500 W/TIZEN_N_SOUND_MANAGER( 1584): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 05:18:42.187-0500 I/APP_CORE( 4005): appcore-efl.c: __do_app(429) > [APP 4005] Event: RESUME State: RUNNING
02-18 05:18:42.197-0500 I/TIZEN_N_SOUND_MANAGER( 1584): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Enable start
02-18 05:18:42.197-0500 W/ALARM_MANAGER(  901): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
02-18 05:18:42.197-0500 W/ALARM_MANAGER(  901): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
02-18 05:18:42.197-0500 E/ALARM_MANAGER(  901): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1124941619)
02-18 05:18:42.197-0500 E/ALARM_MANAGER(  901): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
02-18 05:18:42.197-0500 E/ALARM_MANAGER(  901): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 18-2-2017, 10:21:49 (UTC).
02-18 05:18:42.197-0500 E/ALARM_MANAGER(  901): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
02-18 05:18:42.197-0500 E/ALARM_MANAGER(  901): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[1124941619] is removed.
02-18 05:18:42.197-0500 W/W_HOME  ( 1175): gesture.c: _manual_render(176) > 
02-18 05:18:42.207-0500 I/TIZEN_N_SOUND_MANAGER( 1584): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Enable end. (ret: 0x0)
02-18 05:18:42.207-0500 W/TIZEN_N_SOUND_MANAGER( 1584): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-18 05:18:42.207-0500 W/WAKEUP-SERVICE( 1584): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
02-18 05:18:42.217-0500 I/HIGEAR  ( 1584): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
02-18 05:18:42.217-0500 W/WAKEUP-SERVICE( 1584): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : -1226196212[0;m
02-18 05:18:42.217-0500 W/WAKEUP-SERVICE( 1584): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
02-18 05:18:42.217-0500 W/WAKEUP-SERVICE( 1584): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
02-18 05:18:42.217-0500 I/TIZEN_N_SOUND_MANAGER( 1584): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 0
02-18 05:18:42.227-0500 W/TIZEN_N_SOUND_MANAGER( 1584): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 05:18:42.227-0500 W/WAKEUP-SERVICE( 1584): WakeupService.cpp: WakeupServiceStart(395) > [0;32mINFO: 500[0;m
02-18 05:18:42.227-0500 I/TIZEN_N_SOUND_MANAGER( 1584): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 500
02-18 05:18:42.227-0500 W/W_HOME  ( 1175): gesture.c: _manual_render_enable(133) > 0
02-18 05:18:42.227-0500 W/TIZEN_N_SOUND_MANAGER( 1584): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 05:18:42.227-0500 I/TIZEN_N_SOUND_MANAGER( 1584): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Enable start
02-18 05:18:42.237-0500 W/W_HOME  ( 1175): dbus.c: _dbus_message_recv_cb(186) > LCD on
02-18 05:18:42.237-0500 W/W_HOME  ( 1175): gesture.c: _manual_render_disable_timer_set(161) > timer set
02-18 05:18:42.237-0500 W/W_HOME  ( 1175): gesture.c: _manual_render_disable_timer_del(151) > timer del
02-18 05:18:42.237-0500 W/W_HOME  ( 1175): gesture.c: _apps_status_get(123) > apps status:0
02-18 05:18:42.237-0500 W/W_HOME  ( 1175): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:0 info->offtime:17067
02-18 05:18:42.237-0500 W/W_HOME  ( 1175): gesture.c: _manual_render_schedule(211) > schedule, manual render
02-18 05:18:42.237-0500 W/W_HOME  ( 1175): event_manager.c: _lcd_on_cb(691) > lcd state: 1
02-18 05:18:42.237-0500 W/W_HOME  ( 1175): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 05:18:42.237-0500 W/W_HOME  ( 1175): gesture.c: _widget_updated_cb(190) > widget updated
02-18 05:18:42.237-0500 W/W_HOME  ( 1175): gesture.c: _manual_render_disable_timer_del(151) > timer del
02-18 05:18:42.237-0500 W/W_HOME  ( 1175): gesture.c: _manual_render(176) > 
02-18 05:18:42.237-0500 W/W_HOME  ( 1175): gesture.c: _manual_render_enable(133) > 0
02-18 05:18:42.247-0500 I/SHealth_Common( 1631): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
02-18 05:18:42.247-0500 I/SHealth_Service( 1631): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
02-18 05:18:42.247-0500 W/MUSIC_CONTROL_SERVICE( 1312): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1312]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
02-18 05:18:42.247-0500 I/TIZEN_N_SOUND_MANAGER( 1584): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Enable end. (ret: 0x0)
02-18 05:18:42.247-0500 W/TIZEN_N_SOUND_MANAGER( 1584): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-18 05:18:42.247-0500 W/WAKEUP-SERVICE( 1584): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
02-18 05:18:42.247-0500 I/HIGEAR  ( 1584): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
02-18 05:18:42.257-0500 W/STARTER ( 1101): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [gesture]
02-18 05:18:42.257-0500 W/STARTER ( 1101): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
02-18 05:18:42.387-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
02-18 05:18:42.387-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
02-18 05:18:42.387-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: preference_get_double(1214) > preference_get_double(1631) : pedometer_inactive_period error
02-18 05:18:42.387-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
02-18 05:18:42.387-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-18 05:18:42.387-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: preference_get_double(1214) > preference_get_double(1631) : inactive_10min_precaution_millisec error
02-18 05:18:42.387-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
02-18 05:18:42.397-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-18 05:18:42.397-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1631): preference.c: preference_get_double(1214) > preference_get_double(1631) : inactive_before_10min_precaution_millisec error
02-18 05:18:43.217-0500 I/efl-extension( 4005): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
02-18 05:18:43.227-0500 I/efl-extension( 1175): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
02-18 05:18:43.407-0500 W/AUL_AMD (  933): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
02-18 05:18:43.407-0500 W/AUL_AMD (  933): amd_launch.c: __e17_status_handler(2254) > back key ungrab error
02-18 05:18:43.427-0500 W/PROCESSMGR(  678): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
02-18 05:18:43.427-0500 W/W_HOME  ( 1175): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
02-18 05:18:43.427-0500 W/W_HOME  ( 1175): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 05:18:43.427-0500 W/W_HOME  ( 1175): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 05:18:43.427-0500 W/W_HOME  ( 1175): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 05:18:43.427-0500 W/W_HOME  ( 1175): main.c: _ecore_x_message_cb(1233) > main_info.is_win_on_top: 1
02-18 05:18:43.427-0500 W/WATCH_CORE( 1240): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
02-18 05:18:43.427-0500 I/WATCH_CORE( 1240): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
02-18 05:18:43.427-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 05:18:43.427-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 05:18:43.427-0500 I/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
02-18 05:18:43.447-0500 I/efl-extension( 1175): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
02-18 05:18:43.447-0500 I/efl-extension( 1175): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0xb824cac8, elm_box, time_stamp : 1626088
02-18 05:18:43.447-0500 I/wnotib  ( 1175): w-notification-board-broker-main.c: _wnotib_rotary_cb(568) > Pass rotary event to home.
02-18 05:18:43.467-0500 W/W_HOME  ( 1175): home_navigation.c: _is_rightedge(188) > (360 360) not right edge: 0 0 0xb829a188 -> 360 0 0xb8341830
02-18 05:18:43.467-0500 I/efl-extension( 1175): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(616) > [0xb824a610 : elm_scroller] rotary callabck is called.
02-18 05:18:43.467-0500 I/efl-extension( 1175): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(646) > [0xb824a610 : elm_scroller] block(2)
02-18 05:18:43.467-0500 I/efl-extension( 1175): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(647) > [0xb824a610 : elm_scroller] scroll_locked_x(0), scroll_locked_y(1)
02-18 05:18:43.467-0500 I/efl-extension( 1175): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(648) > [0xb824a610 : elm_scroller] content size (w, h)(3960, 360)
02-18 05:18:43.467-0500 I/efl-extension( 1175): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(649) > [0xb824a610 : elm_scroller] viewport size (w, h)(360, 360)
02-18 05:18:43.467-0500 I/efl-extension( 1175): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(712) > [0xb824a610 : elm_scroller] CurrentPage(1) DetentCount(1)
02-18 05:18:43.467-0500 I/efl-extension( 1175): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xb824a610 : elm_scroller] mx(3600), my(0), minx(0), miny(0), px(360), py(0)
02-18 05:18:43.467-0500 I/efl-extension( 1175): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xb824a610 : elm_scroller] mx(3600), my(0), minx(0), miny(0), px(360), py(0)
02-18 05:18:43.467-0500 I/efl-extension( 1175): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_can_scroll(405) > [0xb824a610 : elm_scroller] mx(3600), my(0), minx(0), miny(0), px(360), py(0)
02-18 05:18:43.467-0500 I/efl-extension( 1175): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_rotary_changed_cb(744) > [0xb824a610 : elm_scroller] bring in 2 page
02-18 05:18:43.467-0500 W/W_HOME  ( 1175): event_manager.c: _home_scroll_cb(564) > scroll,start
02-18 05:18:43.467-0500 W/W_HOME  ( 1175): event_manager.c: _window_visibility_cb(448) > Window [0x2600003] is now visible(0)
02-18 05:18:43.467-0500 W/W_HOME  ( 1175): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
02-18 05:18:43.467-0500 W/W_HOME  ( 1175): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 05:18:43.467-0500 W/W_HOME  ( 1175): main.c: _window_visibility_cb(1200) > Window [0x2600003] is now visible(0)
02-18 05:18:43.467-0500 I/APP_CORE( 1175): appcore-efl.c: __do_app(429) > [APP 1175] Event: RESUME State: PAUSED
02-18 05:18:43.467-0500 I/CAPI_APPFW_APPLICATION( 1175): app_main.c: app_appcore_resume(223) > app_appcore_resume
02-18 05:18:43.467-0500 W/W_HOME  ( 1175): main.c: _appcore_resume_cb(683) > appcore resume
02-18 05:18:43.467-0500 W/W_HOME  ( 1175): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
02-18 05:18:43.467-0500 W/W_HOME  ( 1175): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 05:18:43.467-0500 W/W_HOME  ( 1175): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 05:18:43.467-0500 W/W_HOME  ( 1175): main.c: home_resume(731) > journal_appcore_app_fully_loaded called
02-18 05:18:43.467-0500 W/W_HOME  ( 1175): main.c: home_resume(735) > clock/widget resumed
02-18 05:18:43.467-0500 W/W_HOME  ( 1175): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 05:18:43.467-0500 I/wnotib  ( 1175): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
02-18 05:18:43.467-0500 E/wnotib  ( 1175): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
02-18 05:18:43.467-0500 W/wnotib  ( 1175): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1699) > No postponed update.
02-18 05:18:43.487-0500 W/GESTURE (  256): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
02-18 05:18:43.497-0500 W/WATCH_CORE( 1240): appcore-watch.c: __widget_resume(1012) > widget_resume
02-18 05:18:43.497-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppResume(721) > 
02-18 05:18:43.497-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 05:18:43.497-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 05:18:43.497-0500 W/W_HOME  ( 1175): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
02-18 05:18:43.497-0500 W/W_HOME  ( 1175): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 05:18:43.497-0500 I/ELM_RPANEL( 1175): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
02-18 05:18:43.497-0500 I/ELM_RPANEL( 1175): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
02-18 05:18:43.507-0500 W/GESTURE (  256): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
02-18 05:18:43.537-0500 W/CRASH_MANAGER( 4341): worker.c: worker_job(1199) > 11040056d6574148741312
