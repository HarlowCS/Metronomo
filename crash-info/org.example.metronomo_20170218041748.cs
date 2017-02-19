S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.5
Build-Number: R730VVRU2BPC7
Build-Date: 2016.04.01 13:23:02

Crash Information
Process Name: metronomo
PID: 2013
Date: 2017-02-18 04:17:48-0500
Executable File Path: /opt/usr/apps/org.example.metronomo/bin/metronomo
Signal: 4
      (SIGILL)
      si_code: 4
      illegal trap
      si_addr: 0xb5b43c58

Register Information
r0   = 0xb7bb1d80, r1   = 0xbec155e8
r2   = 0xb7bafbd8, r3   = 0xb580e295
r4   = 0xbec1554c, r5   = 0xb5b43980
r6   = 0xb7bafb30, r7   = 0xb5b43e0f
r8   = 0x00000041, r9   = 0xb6c03824
r10  = 0xb7aad980, fp   = 0x00000000
ip   = 0x00000000, sp   = 0xbec14d18
lr   = 0xb5b4306b, pc   = 0xb5b43c5c
cpsr = 0x60000010

Memory Information
MemTotal:   389300 KB
MemFree:     11084 KB
Buffers:     12176 KB
Cached:     103492 KB
VmPeak:      70836 KB
VmSize:      68672 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14204 KB
VmRSS:       14204 KB
VmData:      13156 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23056 KB
VmPTE:          50 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 2013 TID = 2013
2013 2210 

Maps Information
b2cd9000 b2d60000 rw-s anon_inode:dmabuf
b2d60000 b2de7000 rw-s anon_inode:dmabuf
b2de7000 b2e6e000 rw-s anon_inode:dmabuf
b2e6e000 b2e71000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b2e79000 b2f00000 rw-s anon_inode:dmabuf
b3024000 b3025000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
b30ad000 b38ac000 rw-p [stack:2210]
b38ac000 b38c3000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b38d0000 b38d2000 r-xp /usr/lib/libgenlock.so
b38e2000 b38e4000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b38f0000 b38f5000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b38fd000 b3908000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b3c70000 b3d3a000 r-xp /usr/lib/libCOREGL.so.4.0
b3d4b000 b3d54000 r-xp /usr/lib/libresourced.so.0.2.86
b3d5c000 b3d5d000 r-xp /usr/lib/librd-network.so.0.2.86
b3d65000 b3d72000 r-xp /usr/lib/libail.so.0.1.0
b3d7b000 b3d82000 r-xp /usr/lib/libminizip.so.1.0.0
b3d8a000 b3d8c000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b3d94000 b3d9b000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b3da4000 b3dc0000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b3dc9000 b3dd1000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
b3dd9000 b3ddf000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b3de7000 b3dec000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
b3df4000 b3e15000 r-xp /usr/lib/libexif.so.12.3.3
b3e28000 b3e41000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
b3e49000 b3e4e000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3e56000 b3e5b000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b53eb000 b53ed000 r-xp /usr/lib/libdri2.so.0.0.0
b53f5000 b53fd000 r-xp /usr/lib/libdrm.so.2.4.0
b5405000 b5406000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b540f000 b5412000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
b541a000 b54fe000 r-xp /usr/lib/libicuuc.so.51.1
b5513000 b5650000 r-xp /usr/lib/libicui18n.so.51.1
b5660000 b5666000 r-xp /usr/lib/libxcb-render.so.0.0.0
b566e000 b566f000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b5678000 b567b000 r-xp /usr/lib/libEGL.so.1.4
b5683000 b5691000 r-xp /usr/lib/libGLESv2.so.2.0
b569a000 b56a1000 r-xp /usr/lib/libtbm.so.1.0.0
b56a9000 b56ca000 r-xp /usr/lib/libui-extension.so.0.1.0
b56d3000 b56e5000 r-xp /usr/lib/libtts.so
b56ed000 b57a5000 r-xp /usr/lib/libcairo.so.2.11200.14
b57b0000 b57c2000 r-xp /usr/lib/libefl-assist.so.0.1.0
b57ca000 b57cf000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b57d7000 b57f8000 r-xp /usr/lib/libefl-extension.so.0.1.0
b5800000 b5805000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b580d000 b580f000 r-xp /opt/usr/apps/org.example.metronomo/bin/metronomo
b59be000 b59c8000 r-xp /lib/libnss_files-2.13.so
b59d1000 b5aa0000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5ab6000 b5ada000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5ae3000 b5ae9000 r-xp /usr/lib/libappsvc.so.0.1.0
b5af1000 b5af3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5afc000 b5b00000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5b0c000 b5b17000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b5b1f000 b5b21000 r-xp /usr/lib/libiniparser.so.0
b5b2a000 b5b2f000 r-xp /usr/lib/libappcore-common.so.1.1
b5b38000 b5b40000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b5b41000 b5b45000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5b52000 b5b54000 r-xp /usr/lib/libXau.so.6.0.0
b5b5d000 b5b64000 r-xp /lib/libcrypt-2.13.so
b5b94000 b5b96000 r-xp /usr/lib/libiri.so
b5b9e000 b5d46000 r-xp /usr/lib/libcrypto.so.1.0.0
b5d5f000 b5dac000 r-xp /usr/lib/libssl.so.1.0.0
b5db9000 b5de7000 r-xp /usr/lib/libidn.so.11.5.44
b5def000 b5df8000 r-xp /usr/lib/libcares.so.2.1.0
b5e01000 b5e14000 r-xp /usr/lib/libxcb.so.1.1.0
b5e1d000 b5e1f000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5e28000 b5e2a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5e33000 b5eff000 r-xp /usr/lib/libxml2.so.2.7.8
b5f0c000 b5f0e000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5f16000 b5f1b000 r-xp /usr/lib/libffi.so.5.0.10
b5f23000 b5f24000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5f2d000 b5f38000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5f40000 b5f43000 r-xp /lib/libattr.so.1.1.0
b5f4b000 b5fdf000 r-xp /usr/lib/libstdc++.so.6.0.16
b5ff2000 b600f000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b6018000 b6030000 r-xp /usr/lib/libpng12.so.0.50.0
b6039000 b604f000 r-xp /lib/libexpat.so.1.5.2
b6059000 b609d000 r-xp /usr/lib/libcurl.so.4.3.0
b60a6000 b60b0000 r-xp /usr/lib/libXext.so.6.4.0
b60b9000 b60bd000 r-xp /usr/lib/libXtst.so.6.1.0
b60c5000 b60cb000 r-xp /usr/lib/libXrender.so.1.3.0
b60d4000 b60da000 r-xp /usr/lib/libXrandr.so.2.2.0
b60e2000 b60e3000 r-xp /usr/lib/libXinerama.so.1.0.0
b60ec000 b60f5000 r-xp /usr/lib/libXi.so.6.1.0
b60fd000 b6100000 r-xp /usr/lib/libXfixes.so.3.1.0
b6108000 b610a000 r-xp /usr/lib/libXgesture.so.7.0.0
b6112000 b6114000 r-xp /usr/lib/libXcomposite.so.1.0.0
b611d000 b611f000 r-xp /usr/lib/libXdamage.so.1.1.0
b6127000 b612e000 r-xp /usr/lib/libXcursor.so.1.0.2
b6136000 b6139000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6141000 b6145000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b614e000 b6153000 r-xp /usr/lib/libecore_fb.so.1.7.99
b615d000 b623e000 r-xp /usr/lib/libX11.so.6.3.0
b6249000 b626c000 r-xp /usr/lib/libjpeg.so.8.0.2
b6284000 b629a000 r-xp /lib/libz.so.1.2.5
b62a2000 b6317000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6321000 b6337000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6340000 b6374000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b637d000 b6450000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b645b000 b646b000 r-xp /lib/libresolv-2.13.so
b646f000 b64eb000 r-xp /usr/lib/libgcrypt.so.20.0.3
b64f7000 b650f000 r-xp /usr/lib/liblzma.so.5.0.3
b6518000 b651b000 r-xp /lib/libcap.so.2.21
b6523000 b6550000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6558000 b6559000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b6561000 b6567000 r-xp /usr/lib/libecore_imf.so.1.7.99
b656f000 b6586000 r-xp /usr/lib/liblua-5.1.so
b6590000 b6597000 r-xp /usr/lib/libembryo.so.1.7.99
b659f000 b65a5000 r-xp /lib/librt-2.13.so
b65ae000 b6604000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6611000 b6667000 r-xp /usr/lib/libfreetype.so.6.11.3
b6673000 b669b000 r-xp /usr/lib/libfontconfig.so.1.8.0
b669d000 b66da000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b66e3000 b66f6000 r-xp /usr/lib/libfribidi.so.0.3.1
b66fe000 b6718000 r-xp /usr/lib/libecore_con.so.1.7.99
b6721000 b672a000 r-xp /usr/lib/libedbus.so.1.7.99
b6732000 b6782000 r-xp /usr/lib/libecore_x.so.1.7.99
b6785000 b6789000 r-xp /usr/lib/libvconf.so.0.2.45
b6791000 b67a2000 r-xp /usr/lib/libecore_input.so.1.7.99
b67aa000 b67af000 r-xp /usr/lib/libecore_file.so.1.7.99
b67b7000 b67d9000 r-xp /usr/lib/libecore_evas.so.1.7.99
b67e2000 b6823000 r-xp /usr/lib/libeina.so.1.7.99
b682c000 b6845000 r-xp /usr/lib/libeet.so.1.7.99
b6856000 b68bf000 r-xp /lib/libm-2.13.so
b68c8000 b68ce000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b68d7000 b68da000 r-xp /usr/lib/libproc-stat.so.0.2.86
b68e2000 b6904000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b690c000 b6911000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6919000 b6943000 r-xp /usr/lib/libdbus-1.so.3.8.12
b694c000 b6963000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b696b000 b6976000 r-xp /lib/libunwind.so.8.0.1
b69a3000 b69df000 r-xp /usr/lib/libsystemd.so.0.4.0
b69e8000 b6b03000 r-xp /lib/libc-2.13.so
b6b11000 b6b19000 r-xp /lib/libgcc_s-4.6.so.1
b6b1a000 b6b1d000 r-xp /usr/lib/libsmack.so.1.0.0
b6b25000 b6b2b000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6b33000 b6c03000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c04000 b6c61000 r-xp /usr/lib/libedje.so.1.7.99
b6c6b000 b6c82000 r-xp /usr/lib/libecore.so.1.7.99
b6c99000 b6d67000 r-xp /usr/lib/libevas.so.1.7.99
b6d8c000 b6ec7000 r-xp /usr/lib/libelementary.so.1.7.99
b6edd000 b6ef1000 r-xp /lib/libpthread-2.13.so
b6efc000 b6efe000 r-xp /usr/lib/libdlog.so.0.0.0
b6f06000 b6f09000 r-xp /usr/lib/libbundle.so.0.1.22
b6f11000 b6f13000 r-xp /lib/libdl-2.13.so
b6f1c000 b6f28000 r-xp /usr/lib/libaul.so.0.1.0
b6f3a000 b6f3f000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f48000 b6f4c000 r-xp /usr/lib/libsys-assert.so
b6f55000 b6f72000 r-xp /lib/ld-2.13.so
b6f7b000 b6f80000 r-xp /usr/bin/launchpad-loader
b7a72000 b7bf6000 rw-p [heap]
bebf5000 bec16000 rw-p [stack]
bebf5000 bec16000 rw-p [stack]
End of Maps Information

Callstack Information (PID:2013)
Call Stack Count: 1
 0: (0xb5b43c5c) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c5c
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
63): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
02-18 04:17:41.860-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
02-18 04:17:41.860-0500 W/W_HOME  ( 1163): rotary.c: rotary_deattach(156) > rotary_deattach:0xb781bf10
02-18 04:17:41.860-0500 I/efl-extension( 1163): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
02-18 04:17:41.860-0500 I/efl-extension( 1163): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xb781bf10, elm_layout, func : 0xb6f2b7f1
02-18 04:17:41.860-0500 I/efl-extension( 1163): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
02-18 04:17:41.860-0500 I/efl-extension( 1163): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
02-18 04:17:41.860-0500 I/efl-extension( 1163): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
02-18 04:17:41.860-0500 I/efl-extension( 1163): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb776dd08, elm_box, _activated_obj : 0xb781bf10, activated : 1
02-18 04:17:41.860-0500 I/efl-extension( 1163): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
02-18 04:17:41.860-0500 E/wnotib  ( 1163): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
02-18 04:17:41.860-0500 I/wnotib  ( 1163): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
02-18 04:17:41.870-0500 E/ALARM_MANAGER( 1109): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(18-2-2017, 04:18:02), repeat(1), interval(20), type(-1073741822)
02-18 04:17:41.870-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:17:41.870-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:17:41.870-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:17:41.870-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 04:17:41.870-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 04:17:41.870-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:17:41.870-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 04:17:41.870-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:17:41.880-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:17:41.880-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:17:41.880-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:17:41.880-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 04:17:41.880-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 04:17:41.880-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:17:41.880-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 04:17:41.880-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 04:17:41.880-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 04:17:41.880-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:17:41.880-0500 E/CAPI_APPFW_APP_CONTROL( 1307): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
02-18 04:17:41.880-0500 W/MUSIC_CONTROL_SERVICE( 1307): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1307]   [com.samsung.w-home]register msg port [false][0m
02-18 04:17:41.880-0500 W/GESTURE (  249): gesture.c: BackGestureSetProperty(4505) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
02-18 04:17:41.880-0500 W/GESTURE (  249): gesture.c: BackGestureSetProperty(4510) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
02-18 04:17:41.890-0500 I/SHealth_Common( 1619): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
02-18 04:17:41.900-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2431
02-18 04:17:41.900-0500 W/ALARM_MANAGER(  896): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
02-18 04:17:41.910-0500 W/ALARM_MANAGER(  896): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
02-18 04:17:41.950-0500 E/ALARM_MANAGER(  896): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1272701434, next duetime: 1487409482
02-18 04:17:41.950-0500 E/ALARM_MANAGER(  896): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1272701434)
02-18 04:17:41.950-0500 E/ALARM_MANAGER(  896): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1487409906), due_time(1487409482)
02-18 04:17:41.950-0500 E/ALARM_MANAGER(  896): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
02-18 04:17:41.950-0500 E/ALARM_MANAGER(  896): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 18-2-2017, 09:18:02 (UTC).
02-18 04:17:41.950-0500 E/ALARM_MANAGER(  896): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
02-18 04:17:41.960-0500 I/SHealth_Service( 1619): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
02-18 04:17:41.980-0500 W/APPS    ( 1163): AppsViewNecklace.cpp: onPausedIdlerCb(4559) >  elm_cache_all_flush
02-18 04:17:42.010-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2337
02-18 04:17:42.150-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2338
02-18 04:17:42.210-0500 E/EFL     ( 2856): elementary<2856> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 04:17:42.240-0500 E/EFL     ( 2856): elementary<2856> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 04:17:42.260-0500 E/EFL     ( 2856): elementary<2856> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 04:17:42.260-0500 E/EFL     ( 2856): elementary<2856> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 04:17:42.300-0500 E/EFL     ( 2856): elementary<2856> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 04:17:42.300-0500 E/EFL     ( 2856): elementary<2856> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 04:17:42.300-0500 E/EFL     ( 2856): elementary<2856> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 04:17:42.300-0500 E/EFL     ( 2856): elementary<2856> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 04:17:42.300-0500 E/EFL     ( 2856): elementary<2856> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 04:17:42.330-0500 E/EFL     ( 2856): elementary<2856> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 04:17:42.330-0500 E/EFL     ( 2856): elementary<2856> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 04:17:42.330-0500 E/EFL     ( 2856): elementary<2856> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 04:17:42.380-0500 I/APP_CORE( 1163): appcore-efl.c: __do_app(429) > [APP 1163] Event: MEM_FLUSH State: PAUSED
02-18 04:17:42.400-0500 E/EFL     ( 2856): elementary<2856> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 04:17:42.400-0500 E/EFL     ( 2856): elementary<2856> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 04:17:42.400-0500 E/EFL     ( 2856): elementary<2856> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 04:17:42.400-0500 E/EFL     ( 2856): elementary<2856> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 04:17:42.400-0500 E/EFL     ( 2856): elementary<2856> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 04:17:42.400-0500 E/EFL     ( 2856): elementary<2856> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 04:17:42.400-0500 E/EFL     ( 2856): elementary<2856> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 04:17:42.400-0500 I/AUL_PAD ( 2856): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
02-18 04:17:42.460-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2858
02-18 04:17:42.970-0500 I/efl-extension( 2857): efl_extension.c: eext_mod_init(40) > Init
02-18 04:17:43.020-0500 E/EFL     ( 2857): elementary<2857> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 04:17:43.060-0500 E/EFL     ( 2857): elementary<2857> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 04:17:43.120-0500 E/EFL     ( 2857): elementary<2857> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 04:17:43.150-0500 I/UXT     ( 2857): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
02-18 04:17:43.150-0500 E/EFL     ( 2857): elementary<2857> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 04:17:43.190-0500 E/EFL     ( 2857): elementary<2857> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 04:17:43.190-0500 E/EFL     ( 2857): elementary<2857> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 04:17:43.190-0500 E/EFL     ( 2857): elementary<2857> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 04:17:43.200-0500 E/EFL     ( 2857): elementary<2857> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 04:17:43.200-0500 E/EFL     ( 2857): elementary<2857> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 04:17:43.220-0500 E/EFL     ( 2857): elementary<2857> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 04:17:43.220-0500 E/EFL     ( 2857): elementary<2857> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 04:17:43.230-0500 E/EFL     ( 2857): elementary<2857> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 04:17:43.260-0500 E/EFL     ( 2857): elementary<2857> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 04:17:43.260-0500 E/EFL     ( 2857): elementary<2857> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 04:17:43.260-0500 E/EFL     ( 2857): elementary<2857> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 04:17:43.260-0500 E/EFL     ( 2857): elementary<2857> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 04:17:43.260-0500 E/EFL     ( 2857): elementary<2857> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 04:17:43.260-0500 E/EFL     ( 2857): elementary<2857> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 04:17:43.260-0500 E/EFL     ( 2857): elementary<2857> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 04:17:43.260-0500 I/AUL_PAD ( 2857): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
02-18 04:17:43.290-0500 I/Adreno-EGL( 2857): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
02-18 04:17:43.290-0500 I/Adreno-EGL( 2857): OpenGL ES Shader Compiler Version: E031.24.00.16
02-18 04:17:43.290-0500 I/Adreno-EGL( 2857): Build Date: 09/02/15 Wed
02-18 04:17:43.290-0500 I/Adreno-EGL( 2857): Local Branch: 
02-18 04:17:43.290-0500 I/Adreno-EGL( 2857): Remote Branch: 
02-18 04:17:43.290-0500 I/Adreno-EGL( 2857): Local Patches: 
02-18 04:17:43.290-0500 I/Adreno-EGL( 2857): Reconstruct Branch: 
02-18 04:17:43.290-0500 E/PKGMGR_SERVER( 2852): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
02-18 04:17:43.570-0500 W/MM_CAMCORDER( 2860): mm_camcorder_internal.c: _mmcamcorder_constructor(204) >  start
02-18 04:17:43.570-0500 W/MM_CAMCORDER( 2860): mm_camcorder_internal.c: _mmcamcorder_constructor(214) >  done
02-18 04:17:43.570-0500 I/efl-extension( 2860): efl_extension.c: eext_mod_init(40) > Init
02-18 04:17:43.650-0500 W/WATCH_CORE( 1240): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
02-18 04:17:43.650-0500 I/WATCH_CORE( 1240): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
02-18 04:17:43.650-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:17:43.650-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:17:43.650-0500 I/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
02-18 04:17:43.650-0500 W/W_HOME  ( 1163): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
02-18 04:17:43.650-0500 W/W_HOME  ( 1163): gesture.c: _manual_render_schedule(211) > schedule, manual render
02-18 04:17:43.670-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : -1216381368[0;m
02-18 04:17:43.670-0500 W/WATCH_CORE( 1240): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOn
02-18 04:17:43.670-0500 I/WATCH_CORE( 1240): appcore-watch.c: __signal_lcd_status_handler(1149) > Call the time_tick_cb
02-18 04:17:43.670-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:17:43.670-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:17:43.670-0500 I/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
02-18 04:17:43.670-0500 W/W_HOME  ( 1163): dbus.c: _dbus_message_recv_cb(186) > LCD on
02-18 04:17:43.670-0500 W/W_HOME  ( 1163): gesture.c: _manual_render_disable_timer_set(161) > timer set
02-18 04:17:43.670-0500 W/W_HOME  ( 1163): gesture.c: _manual_render_disable_timer_del(151) > timer del
02-18 04:17:43.670-0500 W/W_HOME  ( 1163): gesture.c: _apps_status_get(123) > apps status:0
02-18 04:17:43.670-0500 W/W_HOME  ( 1163): gesture.c: _lcd_on_cb(295) > move_to_clock:0 clock_visible:1 info->offtime:2035
02-18 04:17:43.670-0500 W/W_HOME  ( 1163): gesture.c: _manual_render_schedule(211) > schedule, manual render
02-18 04:17:43.670-0500 W/W_HOME  ( 1163): event_manager.c: _lcd_on_cb(691) > lcd state: 1
02-18 04:17:43.670-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
02-18 04:17:43.670-0500 W/STARTER ( 1109): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [gesture] after screen off time [2035]ms
02-18 04:17:43.670-0500 W/STARTER ( 1109): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
02-18 04:17:43.680-0500 I/APP_CORE( 1163): appcore-efl.c: __do_app(429) > [APP 1163] Event: RESUME State: PAUSED
02-18 04:17:43.680-0500 I/CAPI_APPFW_APPLICATION( 1163): app_main.c: app_appcore_resume(223) > app_appcore_resume
02-18 04:17:43.680-0500 W/W_HOME  ( 1163): main.c: _appcore_resume_cb(683) > appcore resume
02-18 04:17:43.680-0500 W/W_HOME  ( 1163): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
02-18 04:17:43.680-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
02-18 04:17:43.680-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
02-18 04:17:43.680-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
02-18 04:17:43.680-0500 W/APPS    ( 1163): apps_main.c: _time_changed_cb(295) >  date : 18->18
02-18 04:17:43.680-0500 W/W_HOME  ( 1163): rotary.c: rotary_attach(138) > rotary_attach:0xb781bf10
02-18 04:17:43.680-0500 I/efl-extension( 1163): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb781bf10, elm_layout, _activated_obj : 0xb776dd08, activated : 1
02-18 04:17:43.680-0500 I/efl-extension( 1163): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
02-18 04:17:43.680-0500 W/ALARM_MANAGER(  896): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
02-18 04:17:43.680-0500 W/ALARM_MANAGER(  896): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
02-18 04:17:43.680-0500 E/ALARM_MANAGER(  896): alarm-manager.c: __alarm_remove_from_list(456) > [alarm-server]:Remove alarm id(1272701434)
02-18 04:17:43.680-0500 E/ALARM_MANAGER(  896): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
02-18 04:17:43.680-0500 E/ALARM_MANAGER(  896): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 18-2-2017, 09:25:06 (UTC).
02-18 04:17:43.680-0500 E/ALARM_MANAGER(  896): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
02-18 04:17:43.680-0500 E/ALARM_MANAGER(  896): alarm-manager.c: alarm_manager_alarm_delete(2209) > alarm_id[1272701434] is removed.
02-18 04:17:43.680-0500 W/GESTURE (  249): gesture.c: BackGestureSetProperty(4510) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
02-18 04:17:43.680-0500 W/GESTURE (  249): gesture.c: BackGestureSetProperty(4505) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
02-18 04:17:43.680-0500 W/GESTURE (  249): gesture.c: BackGestureSetProperty(4505) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
02-18 04:17:43.680-0500 W/GESTURE (  249): gesture.c: BackGestureSetProperty(4505) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
02-18 04:17:43.690-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
02-18 04:17:43.690-0500 W/W_HOME  ( 1163): gesture.c: _widget_updated_cb(190) > widget updated
02-18 04:17:43.690-0500 W/W_HOME  ( 1163): gesture.c: _manual_render_disable_timer_del(151) > timer del
02-18 04:17:43.690-0500 W/W_HOME  ( 1163): gesture.c: _manual_render(176) > 
02-18 04:17:43.700-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
02-18 04:17:43.700-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 0
02-18 04:17:43.710-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 04:17:43.710-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupServiceStart(395) > [0;32mINFO: 500[0;m
02-18 04:17:43.710-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 500
02-18 04:17:43.710-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 04:17:43.720-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Enable start
02-18 04:17:43.720-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Enable end. (ret: 0x0)
02-18 04:17:43.720-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-18 04:17:43.720-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
02-18 04:17:43.720-0500 I/HIGEAR  ( 1580): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
02-18 04:17:43.720-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : -1226675444[0;m
02-18 04:17:43.720-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
02-18 04:17:43.720-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
02-18 04:17:43.730-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 0
02-18 04:17:43.730-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 04:17:43.750-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupServiceStart(395) > [0;32mINFO: 500[0;m
02-18 04:17:43.750-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_set_param(1262) > [SVOICE] set param [keyword length] : 500
02-18 04:17:43.750-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
02-18 04:17:43.760-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Enable start
02-18 04:17:43.760-0500 W/MUSIC_CONTROL_SERVICE( 1307): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1307]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
02-18 04:17:43.770-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Enable end. (ret: 0x0)
02-18 04:17:43.770-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-18 04:17:43.770-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 1[0;m
02-18 04:17:43.770-0500 I/HIGEAR  ( 1580): WakeupService.cpp: WakeupServiceStart(400) > [svoice:Application:WakeupServiceStart:IN]
02-18 04:17:43.790-0500 E/rpm-installer( 2853): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
02-18 04:17:43.810-0500 W/W_HOME  ( 1163): gesture.c: _manual_render(176) > 
02-18 04:17:43.810-0500 W/STARTER ( 1109): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [gesture]
02-18 04:17:43.810-0500 W/STARTER ( 1109): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
02-18 04:17:43.830-0500 W/W_HOME  ( 1163): gesture.c: _manual_render_enable(133) > 0
02-18 04:17:43.950-0500 I/SHealth_Common( 1619): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
02-18 04:17:43.950-0500 I/SHealth_Service( 1619): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
02-18 04:17:44.000-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1619): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
02-18 04:17:44.000-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1619): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
02-18 04:17:44.010-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1619): preference.c: preference_get_double(1214) > preference_get_double(1619) : pedometer_inactive_period error
02-18 04:17:44.010-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1619): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
02-18 04:17:44.010-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1619): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-18 04:17:44.010-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1619): preference.c: preference_get_double(1214) > preference_get_double(1619) : inactive_10min_precaution_millisec error
02-18 04:17:44.010-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1619): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
02-18 04:17:44.010-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1619): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
02-18 04:17:44.010-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1619): preference.c: preference_get_double(1214) > preference_get_double(1619) : inactive_before_10min_precaution_millisec error
02-18 04:17:44.610-0500 I/AUL     ( 2860): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 04:17:44.660-0500 I/AUL     ( 2860): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 04:17:44.660-0500 E/AUL     ( 2860): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-18 04:17:44.660-0500 E/AUL     ( 2860): aul_path.c: __get_path(169) > root_path is NULL!
02-18 04:17:44.680-0500 I/AUL     ( 2860): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 04:17:44.680-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:17:44.680-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:17:44.680-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:17:44.680-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 04:17:44.680-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 04:17:44.680-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:17:44.680-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 04:17:44.680-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:17:44.680-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:17:44.680-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:17:44.680-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:17:44.680-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 04:17:44.680-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 04:17:44.680-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:17:44.680-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 04:17:44.680-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 04:17:44.680-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 04:17:44.680-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:17:44.680-0500 E/CAPI_APPFW_APP_CONTROL( 1307): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
02-18 04:17:44.680-0500 W/MUSIC_CONTROL_SERVICE( 1307): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1307]   [com.samsung.w-home]register msg port [true][0m
02-18 04:17:44.680-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
02-18 04:17:44.690-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1163
02-18 04:17:44.690-0500 W/MUSIC_CONTROL_SERVICE( 1307): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1307]   [MUSIC_PLAYER_EVENT][0m
02-18 04:17:44.690-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1307): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
02-18 04:17:44.690-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1307): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
02-18 04:17:44.690-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1307): preference.c: preference_get_int(1132) > preference_get_int(1307) : key(music-control-service_native/playing_diration) error
02-18 04:17:44.690-0500 W/MUSIC_CONTROL_SERVICE( 1307): music-control-info.c: music_control_info_get_player_position(582) > [31m[TID:1307]   preference_get_int() .. [0xfef00030][0m
02-18 04:17:44.690-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:17:44.690-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:17:44.690-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:17:44.690-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 04:17:44.690-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 04:17:44.690-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:17:44.690-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-18 04:17:44.690-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:17:44.690-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:17:44.690-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:17:44.690-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:17:44.690-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 04:17:44.690-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 04:17:44.690-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:17:44.690-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-18 04:17:44.690-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 04:17:44.690-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 04:17:44.690-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:17:44.700-0500 W/W_HOME  ( 1163): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
02-18 04:17:44.700-0500 E/W_HOME  ( 1163): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
02-18 04:17:44.700-0500 W/MUSIC_CONTROL_SERVICE( 1307): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1307]   [MUSIC_PLAYER_EVENT][0m
02-18 04:17:44.700-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1307): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
02-18 04:17:44.700-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1307): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
02-18 04:17:44.700-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1307): preference.c: preference_get_int(1132) > preference_get_int(1307) : key(music-control-service_native/playing_diration) error
02-18 04:17:44.700-0500 W/MUSIC_CONTROL_SERVICE( 1307): music-control-info.c: music_control_info_get_player_position(582) > [31m[TID:1307]   preference_get_int() .. [0xfef00030][0m
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:17:44.700-0500 W/W_HOME  ( 1163): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
02-18 04:17:44.700-0500 E/W_HOME  ( 1163): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
02-18 04:17:44.700-0500 I/TIZEN_N_SOUND_MANAGER( 1307): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
02-18 04:17:44.700-0500 W/TIZEN_N_SOUND_MANAGER( 1307): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 04:17:44.700-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:17:44.720-0500 I/AUL     ( 2860): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 04:17:44.720-0500 E/AUL     ( 2860): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-18 04:17:44.720-0500 E/AUL     ( 2860): aul_path.c: __get_path(169) > root_path is NULL!
02-18 04:17:44.720-0500 E/EFL     ( 2860): elementary<2860> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 04:17:44.720-0500 E/EFL     ( 2860): elementary<2860> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 04:17:44.740-0500 E/EFL     ( 2860): elementary<2860> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 04:17:44.740-0500 I/UXT     ( 2860): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
02-18 04:17:44.740-0500 E/EFL     ( 2860): elementary<2860> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 04:17:44.770-0500 E/EFL     ( 2860): elementary<2860> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 04:17:44.770-0500 E/EFL     ( 2860): elementary<2860> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 04:17:44.770-0500 E/EFL     ( 2860): elementary<2860> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 04:17:44.770-0500 E/EFL     ( 2860): elementary<2860> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 04:17:44.770-0500 E/EFL     ( 2860): elementary<2860> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 04:17:44.790-0500 E/EFL     ( 2860): elementary<2860> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 04:17:44.800-0500 E/EFL     ( 2860): elementary<2860> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 04:17:44.800-0500 E/EFL     ( 2860): elementary<2860> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 04:17:44.810-0500 E/EFL     ( 2860): elementary<2860> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 04:17:44.820-0500 E/EFL     ( 2860): elementary<2860> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 04:17:44.820-0500 E/EFL     ( 2860): elementary<2860> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 04:17:44.820-0500 E/EFL     ( 2860): elementary<2860> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 04:17:44.820-0500 E/EFL     ( 2860): elementary<2860> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 04:17:44.820-0500 E/EFL     ( 2860): elementary<2860> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 04:17:44.820-0500 E/EFL     ( 2860): elementary<2860> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 04:17:44.850-0500 I/Adreno-EGL( 2860): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
02-18 04:17:44.850-0500 I/Adreno-EGL( 2860): OpenGL ES Shader Compiler Version: E031.24.00.16
02-18 04:17:44.850-0500 I/Adreno-EGL( 2860): Build Date: 09/02/15 Wed
02-18 04:17:44.850-0500 I/Adreno-EGL( 2860): Local Branch: 
02-18 04:17:44.850-0500 I/Adreno-EGL( 2860): Remote Branch: 
02-18 04:17:44.850-0500 I/Adreno-EGL( 2860): Local Patches: 
02-18 04:17:44.850-0500 I/Adreno-EGL( 2860): Reconstruct Branch: 
02-18 04:17:44.900-0500 W/Adreno-ES20( 2860): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:17:44.900-0500 W/Adreno-ES20( 2860): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:17:44.900-0500 W/Adreno-ES20( 2860): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:17:44.900-0500 W/Adreno-ES20( 2860): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:17:44.900-0500 W/Adreno-ES20( 2860): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:17:44.900-0500 W/Adreno-ES20( 2860): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:17:44.900-0500 W/Adreno-ES20( 2860): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:17:44.900-0500 W/Adreno-ES20( 2860): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:17:44.900-0500 W/Adreno-ES20( 2860): <get_simple_queries:1550>: GL_INVALID_ENUM
02-18 04:17:45.290-0500 E/PKGMGR_SERVER( 2852): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
02-18 04:17:46.970-0500 E/PKGMGR_SERVER( 2852): pkgmgr-server.c: sighandler(409) > child NORMAL exit [2853]
02-18 04:17:46.980-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
02-18 04:17:47.000-0500 W/W_HOME  ( 1163): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.example.metronomo is updated, need to check validation
02-18 04:17:47.000-0500 W/W_HOME  ( 1163): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:com.samsung.watchface
02-18 04:17:47.020-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, COMPLETED]
02-18 04:17:47.020-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6946) > package install complete
02-18 04:17:47.020-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_package_install_event(4818) > 
02-18 04:17:47.020-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1758) > Found in install_req_list?[0], index[-1]
02-18 04:17:47.080-0500 W/APPS    ( 1163): pkgmgr.c: _update_app(739) >  old order:[25]
02-18 04:17:47.090-0500 E/STARTER ( 1109): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
02-18 04:17:47.120-0500 E/PKGMGR_INFO(  898): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
02-18 04:17:47.140-0500 E/EFL     ( 1163): elementary<1163> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0xb78abaf0 into part 'elm.swallow.event.0'
02-18 04:17:47.150-0500 E/APPS    ( 1163): AppsViewNecklace.cpp: onShow(597) >  AppsItemList[27]
02-18 04:17:47.190-0500 E/Vi::Animations( 1163): result Vi::Animations::_AnimationManager::addAnimation(Vi::Animations::Visual&, const string*, Vi::Animations::Animation&)(288) > [E_OBJ_ALREADY_EXIST] Animation with keyName already exists. key name = hide
02-18 04:17:47.190-0500 I/Vi::Animations( 1163): result Vi::Animations::_VisualImpl::addAnimation(const string*, Vi::Animations::Animation&)(6999) > [E_OBJ_ALREADY_EXIST] Propagating.
02-18 04:17:47.190-0500 E/EFL     ( 1163): elementary<1163> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0xb78abaf0 into part 'elm.swallow.event.0'
02-18 04:17:47.200-0500 E/APPS    ( 1163): AppsViewNecklace.cpp: onShow(597) >  AppsItemList[28]
02-18 04:17:47.290-0500 E/PKGMGR_SERVER( 2852): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
02-18 04:17:47.290-0500 E/PKGMGR_SERVER( 2852): pkgmgr-server.c: main(2185) > package manager server terminated.
02-18 04:17:47.700-0500 W/APPS    ( 1163): pkgmgr.c: _update_app_cb(718) >  Update apps order
02-18 04:17:47.700-0500 W/APPS    ( 1163): AppsViewNecklace.cpp: onTouchEventCancel(4360) >  touch cancel
02-18 04:17:48.600-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 0
02-18 04:17:48.620-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
02-18 04:17:48.640-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
02-18 04:17:48.640-0500 E/AUL_AMD (  934): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
02-18 04:17:48.640-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(1708) > caller pid : 2925
02-18 04:17:48.670-0500 W/AUL_AMD (  934): amd_launch.c: __nofork_processing(1151) > __nofork_processing, cmd: 0, pid: 2013
02-18 04:17:48.670-0500 I/APP_CORE( 2013): appcore-efl.c: __do_app(429) > [APP 2013] Event: RESET State: PAUSED
02-18 04:17:48.670-0500 I/CAPI_APPFW_APPLICATION( 2013): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
02-18 04:17:48.680-0500 W/AUL_AMD (  934): amd_launch.c: __reply_handler(922) > listen fd(20) , send fd(15), pid(2013), cmd(0)
02-18 04:17:49.060-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2013
02-18 04:17:49.120-0500 W/CRASH_MANAGER( 2926): worker.c: worker_job(1199) > 04020136d6574148740946
