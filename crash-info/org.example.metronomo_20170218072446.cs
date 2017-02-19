S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.5
Build-Number: R730VVRU2BPC7
Build-Date: 2016.04.01 13:23:02

Crash Information
Process Name: metronomo
PID: 3570
Date: 2017-02-18 07:24:46-0500
Executable File Path: /opt/usr/apps/org.example.metronomo/bin/metronomo
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x295

Register Information
r0   = 0x00000295, r1   = 0xbed4de54
r2   = 0xbed49e1c, r3   = 0x00000295
r4   = 0xbed49e1c, r5   = 0xbed49e1c
r6   = 0xbed4de54, r7   = 0x00000002
r8   = 0x00000008, r9   = 0x00000000
r10  = 0x00000005, fp   = 0x00000006
ip   = 0x00000000, sp   = 0xbed49dd8
lr   = 0xb697b28c, pc   = 0xb697b0fc
cpsr = 0x20000010

Memory Information
MemTotal:   389300 KB
MemFree:      9616 KB
Buffers:     10384 KB
Cached:      91308 KB
VmPeak:      72732 KB
VmSize:      71112 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16652 KB
VmRSS:       16652 KB
VmData:      14948 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23056 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3570 TID = 3570
3570 3653 

Maps Information
b2cd4000 b2d5b000 rw-s anon_inode:dmabuf
b2d5b000 b2d5e000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b2d66000 b2ded000 rw-s anon_inode:dmabuf
b2ded000 b2e74000 rw-s anon_inode:dmabuf
b3021000 b3022000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
b30b9000 b38b8000 rw-p [stack:3653]
b38b8000 b38cf000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b38dc000 b38de000 r-xp /usr/lib/libgenlock.so
b38ee000 b38f0000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b38fc000 b3901000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b3909000 b3914000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b3c7c000 b3d46000 r-xp /usr/lib/libCOREGL.so.4.0
b3d57000 b3d60000 r-xp /usr/lib/libresourced.so.0.2.86
b3d68000 b3d69000 r-xp /usr/lib/librd-network.so.0.2.86
b3d71000 b3d7e000 r-xp /usr/lib/libail.so.0.1.0
b3d87000 b3d8e000 r-xp /usr/lib/libminizip.so.1.0.0
b3d96000 b3d98000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b3da0000 b3da7000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b3db0000 b3dcc000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b3dd5000 b3ddd000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
b3de5000 b3deb000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b3df3000 b3df8000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
b3e00000 b3e21000 r-xp /usr/lib/libexif.so.12.3.3
b3e34000 b3e4d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
b3e55000 b3e5a000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3e62000 b3e67000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b53f7000 b53f9000 r-xp /usr/lib/libdri2.so.0.0.0
b5401000 b5409000 r-xp /usr/lib/libdrm.so.2.4.0
b5411000 b5412000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b541b000 b541e000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
b5426000 b550a000 r-xp /usr/lib/libicuuc.so.51.1
b551f000 b565c000 r-xp /usr/lib/libicui18n.so.51.1
b566c000 b5672000 r-xp /usr/lib/libxcb-render.so.0.0.0
b567a000 b567b000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b5684000 b5687000 r-xp /usr/lib/libEGL.so.1.4
b568f000 b569d000 r-xp /usr/lib/libGLESv2.so.2.0
b56a6000 b56ad000 r-xp /usr/lib/libtbm.so.1.0.0
b56b5000 b56d6000 r-xp /usr/lib/libui-extension.so.0.1.0
b56df000 b56f1000 r-xp /usr/lib/libtts.so
b56f9000 b57b1000 r-xp /usr/lib/libcairo.so.2.11200.14
b57bc000 b57ce000 r-xp /usr/lib/libefl-assist.so.0.1.0
b57d6000 b57db000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b57e3000 b5804000 r-xp /usr/lib/libefl-extension.so.0.1.0
b580c000 b5811000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b5819000 b581b000 r-xp /opt/usr/apps/org.example.metronomo/bin/metronomo
b59ca000 b59d4000 r-xp /lib/libnss_files-2.13.so
b59dd000 b5aac000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5ac2000 b5ae6000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5aef000 b5af5000 r-xp /usr/lib/libappsvc.so.0.1.0
b5afd000 b5aff000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5b08000 b5b0c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5b18000 b5b23000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b5b2b000 b5b2d000 r-xp /usr/lib/libiniparser.so.0
b5b36000 b5b3b000 r-xp /usr/lib/libappcore-common.so.1.1
b5b44000 b5b4c000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b5b4d000 b5b51000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5b5e000 b5b60000 r-xp /usr/lib/libXau.so.6.0.0
b5b69000 b5b70000 r-xp /lib/libcrypt-2.13.so
b5ba0000 b5ba2000 r-xp /usr/lib/libiri.so
b5baa000 b5d52000 r-xp /usr/lib/libcrypto.so.1.0.0
b5d6b000 b5db8000 r-xp /usr/lib/libssl.so.1.0.0
b5dc5000 b5df3000 r-xp /usr/lib/libidn.so.11.5.44
b5dfb000 b5e04000 r-xp /usr/lib/libcares.so.2.1.0
b5e0d000 b5e20000 r-xp /usr/lib/libxcb.so.1.1.0
b5e29000 b5e2b000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5e34000 b5e36000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5e3f000 b5f0b000 r-xp /usr/lib/libxml2.so.2.7.8
b5f18000 b5f1a000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5f22000 b5f27000 r-xp /usr/lib/libffi.so.5.0.10
b5f2f000 b5f30000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5f39000 b5f44000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5f4c000 b5f4f000 r-xp /lib/libattr.so.1.1.0
b5f57000 b5feb000 r-xp /usr/lib/libstdc++.so.6.0.16
b5ffe000 b601b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b6024000 b603c000 r-xp /usr/lib/libpng12.so.0.50.0
b6045000 b605b000 r-xp /lib/libexpat.so.1.5.2
b6065000 b60a9000 r-xp /usr/lib/libcurl.so.4.3.0
b60b2000 b60bc000 r-xp /usr/lib/libXext.so.6.4.0
b60c5000 b60c9000 r-xp /usr/lib/libXtst.so.6.1.0
b60d1000 b60d7000 r-xp /usr/lib/libXrender.so.1.3.0
b60e0000 b60e6000 r-xp /usr/lib/libXrandr.so.2.2.0
b60ee000 b60ef000 r-xp /usr/lib/libXinerama.so.1.0.0
b60f8000 b6101000 r-xp /usr/lib/libXi.so.6.1.0
b6109000 b610c000 r-xp /usr/lib/libXfixes.so.3.1.0
b6114000 b6116000 r-xp /usr/lib/libXgesture.so.7.0.0
b611e000 b6120000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6129000 b612b000 r-xp /usr/lib/libXdamage.so.1.1.0
b6133000 b613a000 r-xp /usr/lib/libXcursor.so.1.0.2
b6142000 b6145000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b614d000 b6151000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b615a000 b615f000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6169000 b624a000 r-xp /usr/lib/libX11.so.6.3.0
b6255000 b6278000 r-xp /usr/lib/libjpeg.so.8.0.2
b6290000 b62a6000 r-xp /lib/libz.so.1.2.5
b62ae000 b6323000 r-xp /usr/lib/libsqlite3.so.0.8.6
b632d000 b6343000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b634c000 b6380000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6389000 b645c000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6467000 b6477000 r-xp /lib/libresolv-2.13.so
b647b000 b64f7000 r-xp /usr/lib/libgcrypt.so.20.0.3
b6503000 b651b000 r-xp /usr/lib/liblzma.so.5.0.3
b6524000 b6527000 r-xp /lib/libcap.so.2.21
b652f000 b655c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6564000 b6565000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b656d000 b6573000 r-xp /usr/lib/libecore_imf.so.1.7.99
b657b000 b6592000 r-xp /usr/lib/liblua-5.1.so
b659c000 b65a3000 r-xp /usr/lib/libembryo.so.1.7.99
b65ab000 b65b1000 r-xp /lib/librt-2.13.so
b65ba000 b6610000 r-xp /usr/lib/libpixman-1.so.0.28.2
b661d000 b6673000 r-xp /usr/lib/libfreetype.so.6.11.3
b667f000 b66a7000 r-xp /usr/lib/libfontconfig.so.1.8.0
b66a9000 b66e6000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b66ef000 b6702000 r-xp /usr/lib/libfribidi.so.0.3.1
b670a000 b6724000 r-xp /usr/lib/libecore_con.so.1.7.99
b672d000 b6736000 r-xp /usr/lib/libedbus.so.1.7.99
b673e000 b678e000 r-xp /usr/lib/libecore_x.so.1.7.99
b6791000 b6795000 r-xp /usr/lib/libvconf.so.0.2.45
b679d000 b67ae000 r-xp /usr/lib/libecore_input.so.1.7.99
b67b6000 b67bb000 r-xp /usr/lib/libecore_file.so.1.7.99
b67c3000 b67e5000 r-xp /usr/lib/libecore_evas.so.1.7.99
b67ee000 b682f000 r-xp /usr/lib/libeina.so.1.7.99
b6838000 b6851000 r-xp /usr/lib/libeet.so.1.7.99
b6862000 b68cb000 r-xp /lib/libm-2.13.so
b68d4000 b68da000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b68e3000 b68e6000 r-xp /usr/lib/libproc-stat.so.0.2.86
b68ee000 b6910000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6918000 b691d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6925000 b694f000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6958000 b696f000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6977000 b6982000 r-xp /lib/libunwind.so.8.0.1
b69af000 b69eb000 r-xp /usr/lib/libsystemd.so.0.4.0
b69f4000 b6b0f000 r-xp /lib/libc-2.13.so
b6b1d000 b6b25000 r-xp /lib/libgcc_s-4.6.so.1
b6b26000 b6b29000 r-xp /usr/lib/libsmack.so.1.0.0
b6b31000 b6b37000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6b3f000 b6c0f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c10000 b6c6d000 r-xp /usr/lib/libedje.so.1.7.99
b6c77000 b6c8e000 r-xp /usr/lib/libecore.so.1.7.99
b6ca5000 b6d73000 r-xp /usr/lib/libevas.so.1.7.99
b6d98000 b6ed3000 r-xp /usr/lib/libelementary.so.1.7.99
b6ee9000 b6efd000 r-xp /lib/libpthread-2.13.so
b6f08000 b6f0a000 r-xp /usr/lib/libdlog.so.0.0.0
b6f12000 b6f15000 r-xp /usr/lib/libbundle.so.0.1.22
b6f1d000 b6f1f000 r-xp /lib/libdl-2.13.so
b6f28000 b6f34000 r-xp /usr/lib/libaul.so.0.1.0
b6f46000 b6f4b000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f54000 b6f58000 r-xp /usr/lib/libsys-assert.so
b6f61000 b6f7e000 r-xp /lib/ld-2.13.so
b6f87000 b6f8c000 r-xp /usr/bin/launchpad-loader
b72fc000 b74c6000 rw-p [heap]
bed37000 bed58000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3570)
Call Stack Count: 1
 0: (0xb697b0fc) [/lib/libunwind.so.8] + 0x40fc
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
Property(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
02-18 07:24:40.154-0500 W/APP_CORE( 1137): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1c00011
02-18 07:24:40.184-0500 W/W_HOME  ( 1180): gesture.c: _widget_updated_cb(190) > widget updated
02-18 07:24:40.184-0500 W/W_HOME  ( 1180): gesture.c: _manual_render_disable_timer_del(151) > timer del
02-18 07:24:40.184-0500 W/W_HOME  ( 1180): gesture.c: _manual_render(176) > 
02-18 07:24:40.194-0500 W/W_HOME  ( 1180): gesture.c: _manual_render(176) > 
02-18 07:24:40.214-0500 I/APP_CORE( 1137): appcore-efl.c: __do_app(429) > [APP 1137] Event: MEM_FLUSH State: PAUSED
02-18 07:24:40.224-0500 I/AUL_AMD (  937): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3572
02-18 07:24:40.234-0500 W/W_HOME  ( 1180): gesture.c: _manual_render_enable(133) > 0
02-18 07:24:40.264-0500 I/APP_CORE( 1137): appcore-efl.c: __do_app(429) > [APP 1137] Event: RESUME State: PAUSED
02-18 07:24:40.264-0500 I/CAPI_APPFW_APPLICATION( 1137): app_main.c: app_appcore_resume(223) > app_appcore_resume
02-18 07:24:40.284-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:40.294-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:40.284-0500 E/SHealth_Common( 1631): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
02-18 07:24:40.294-0500 I/AUL_AMD (  937): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 4688
02-18 07:24:40.464-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:40.464-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:40.654-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:40.654-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:40.744-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 07:24:40.744-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 07:24:40.744-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 07:24:40.744-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 07:24:40.744-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 07:24:40.744-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 07:24:40.744-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 07:24:40.744-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 07:24:40.754-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 07:24:40.754-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 07:24:40.754-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 07:24:40.754-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 07:24:40.754-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 07:24:40.754-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 07:24:40.754-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 07:24:40.754-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 07:24:40.754-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 07:24:40.754-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 07:24:40.754-0500 E/CAPI_APPFW_APP_CONTROL( 1312): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
02-18 07:24:40.754-0500 W/MUSIC_CONTROL_SERVICE( 1312): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1312]   [com.samsung.w-home]register msg port [true][0m
02-18 07:24:40.754-0500 W/AUL_AMD (  937): amd_request.c: __request_handler(646) > __request_handler: 14
02-18 07:24:40.754-0500 W/AUL_AMD (  937): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1180
02-18 07:24:40.764-0500 W/MUSIC_CONTROL_SERVICE( 1312): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1312]   [MUSIC_PLAYER_EVENT][0m
02-18 07:24:40.764-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
02-18 07:24:40.764-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
02-18 07:24:40.764-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: preference_get_int(1132) > preference_get_int(1312) : key(music-control-service_native/playing_diration) error
02-18 07:24:40.764-0500 W/MUSIC_CONTROL_SERVICE( 1312): music-control-info.c: music_control_info_get_player_position(582) > [31m[TID:1312]   preference_get_int() .. [0xfef00030][0m
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 07:24:40.764-0500 W/MUSIC_CONTROL_SERVICE( 1312): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1312]   [MUSIC_PLAYER_EVENT][0m
02-18 07:24:40.764-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
02-18 07:24:40.764-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
02-18 07:24:40.764-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1312): preference.c: preference_get_int(1132) > preference_get_int(1312) : key(music-control-service_native/playing_diration) error
02-18 07:24:40.764-0500 W/MUSIC_CONTROL_SERVICE( 1312): music-control-info.c: music_control_info_get_player_position(582) > [31m[TID:1312]   preference_get_int() .. [0xfef00030][0m
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 07:24:40.764-0500 W/W_HOME  ( 1180): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
02-18 07:24:40.764-0500 E/W_HOME  ( 1180): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 07:24:40.764-0500 I/TIZEN_N_SOUND_MANAGER( 1312): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
02-18 07:24:40.764-0500 W/TIZEN_N_SOUND_MANAGER( 1312): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 07:24:40.764-0500 W/W_HOME  ( 1180): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
02-18 07:24:40.764-0500 E/W_HOME  ( 1180): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 07:24:40.764-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 07:24:40.804-0500 E/EFL     ( 4689): elementary<4689> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 07:24:40.814-0500 E/EFL     ( 4689): elementary<4689> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 07:24:40.834-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:40.834-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:40.864-0500 E/EFL     ( 4689): elementary<4689> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 07:24:40.864-0500 E/EFL     ( 4689): elementary<4689> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 07:24:40.874-0500 E/PKGMGR_SERVER( 4685): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
02-18 07:24:41.034-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:41.034-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:41.034-0500 E/EFL     ( 4689): elementary<4689> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 07:24:41.034-0500 E/EFL     ( 4689): elementary<4689> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 07:24:41.034-0500 E/EFL     ( 4689): elementary<4689> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 07:24:41.034-0500 E/EFL     ( 4689): elementary<4689> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 07:24:41.034-0500 E/EFL     ( 4689): elementary<4689> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 07:24:41.074-0500 E/EFL     ( 4689): elementary<4689> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 07:24:41.074-0500 E/EFL     ( 4689): elementary<4689> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 07:24:41.074-0500 E/EFL     ( 4689): elementary<4689> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 07:24:41.134-0500 E/EFL     ( 4689): elementary<4689> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 07:24:41.174-0500 E/EFL     ( 4689): elementary<4689> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 07:24:41.174-0500 E/EFL     ( 4689): elementary<4689> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 07:24:41.174-0500 E/EFL     ( 4689): elementary<4689> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 07:24:41.174-0500 E/EFL     ( 4689): elementary<4689> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 07:24:41.174-0500 E/EFL     ( 4689): elementary<4689> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 07:24:41.174-0500 E/EFL     ( 4689): elementary<4689> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 07:24:41.174-0500 I/AUL_PAD ( 4689): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
02-18 07:24:41.224-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:41.224-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:41.414-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:41.414-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:41.614-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:41.614-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:41.804-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:41.814-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:41.854-0500 E/rpm-installer( 4686): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
02-18 07:24:41.864-0500 I/efl-extension( 4690): efl_extension.c: eext_mod_init(40) > Init
02-18 07:24:42.004-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:42.004-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:42.084-0500 E/W_INDICATOR( 1137): windicator_moment_view.c: windicator_moment_view_hide(634) > [windicator_moment_view_hide:634] Hide Moment View : dynamic_layout(0xb7f1c428),Type(1)
02-18 07:24:42.084-0500 E/W_INDICATOR( 1137): windicator_connection.c: windi_connection_pause(1671) > [windi_connection_pause:1671] Failed to deregister noti event : TAPI_PROP_MODEL_POWER
02-18 07:24:42.094-0500 W/PROCESSMGR(  667): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
02-18 07:24:42.094-0500 W/W_HOME  ( 1180): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
02-18 07:24:42.094-0500 W/W_HOME  ( 1180): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 07:24:42.094-0500 W/W_HOME  ( 1180): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 07:24:42.094-0500 W/WATCH_CORE( 1242): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
02-18 07:24:42.094-0500 I/WATCH_CORE( 1242): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
02-18 07:24:42.094-0500 W/W_HOME  ( 1180): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 07:24:42.094-0500 W/W_HOME  ( 1180): main.c: _ecore_x_message_cb(1233) > main_info.is_win_on_top: 1
02-18 07:24:42.094-0500 W/GESTURE (  258): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
02-18 07:24:42.094-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:42.094-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:42.104-0500 E/W_INDICATOR( 1137): windicator_util.c: windi_x_input_event_unregister(231) > [windi_x_input_event_unregister:231] not registered
02-18 07:24:42.154-0500 W/APP_CORE( 1137): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:1c00011
02-18 07:24:42.154-0500 I/APP_CORE( 1137): appcore-efl.c: __do_app(429) > [APP 1137] Event: PAUSE State: RUNNING
02-18 07:24:42.154-0500 I/CAPI_APPFW_APPLICATION( 1137): app_main.c: app_appcore_pause(202) > app_appcore_pause
02-18 07:24:42.174-0500 E/EFL     ( 4690): elementary<4690> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 07:24:42.184-0500 E/EFL     ( 4690): elementary<4690> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 07:24:42.204-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:42.204-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:42.294-0500 E/EFL     ( 4690): elementary<4690> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 07:24:42.294-0500 I/UXT     ( 4690): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
02-18 07:24:42.294-0500 E/EFL     ( 4690): elementary<4690> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 07:24:42.404-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:42.404-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:42.434-0500 E/EFL     ( 4690): elementary<4690> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 07:24:42.434-0500 E/EFL     ( 4690): elementary<4690> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 07:24:42.464-0500 E/EFL     ( 4690): elementary<4690> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 07:24:42.464-0500 E/EFL     ( 4690): elementary<4690> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 07:24:42.464-0500 E/EFL     ( 4690): elementary<4690> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 07:24:42.494-0500 E/EFL     ( 4690): elementary<4690> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 07:24:42.494-0500 E/EFL     ( 4690): elementary<4690> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 07:24:42.494-0500 E/EFL     ( 4690): elementary<4690> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 07:24:42.604-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:42.604-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:42.724-0500 E/EFL     ( 4690): elementary<4690> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 07:24:42.724-0500 E/EFL     ( 4690): elementary<4690> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 07:24:42.724-0500 E/EFL     ( 4690): elementary<4690> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 07:24:42.724-0500 E/EFL     ( 4690): elementary<4690> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 07:24:42.724-0500 E/EFL     ( 4690): elementary<4690> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 07:24:42.724-0500 E/EFL     ( 4690): elementary<4690> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 07:24:42.724-0500 E/EFL     ( 4690): elementary<4690> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 07:24:42.724-0500 I/AUL_PAD ( 4690): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
02-18 07:24:42.764-0500 I/Adreno-EGL( 4690): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
02-18 07:24:42.764-0500 I/Adreno-EGL( 4690): OpenGL ES Shader Compiler Version: E031.24.00.16
02-18 07:24:42.764-0500 I/Adreno-EGL( 4690): Build Date: 09/02/15 Wed
02-18 07:24:42.764-0500 I/Adreno-EGL( 4690): Local Branch: 
02-18 07:24:42.764-0500 I/Adreno-EGL( 4690): Remote Branch: 
02-18 07:24:42.764-0500 I/Adreno-EGL( 4690): Local Patches: 
02-18 07:24:42.764-0500 I/Adreno-EGL( 4690): Reconstruct Branch: 
02-18 07:24:42.784-0500 W/MM_CAMCORDER( 4694): mm_camcorder_internal.c: _mmcamcorder_constructor(204) >  start
02-18 07:24:42.784-0500 W/MM_CAMCORDER( 4694): mm_camcorder_internal.c: _mmcamcorder_constructor(214) >  done
02-18 07:24:42.784-0500 I/efl-extension( 4694): efl_extension.c: eext_mod_init(40) > Init
02-18 07:24:42.804-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:42.804-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:42.874-0500 E/PKGMGR_SERVER( 4685): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
02-18 07:24:43.004-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:43.004-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:43.194-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:43.194-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:43.394-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:43.394-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:43.594-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:43.594-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:43.794-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:43.794-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:43.994-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:43.994-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:44.074-0500 I/AUL     ( 4694): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 07:24:44.084-0500 I/AUL     ( 4694): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 07:24:44.084-0500 E/AUL     ( 4694): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-18 07:24:44.084-0500 E/AUL     ( 4694): aul_path.c: __get_path(169) > root_path is NULL!
02-18 07:24:44.114-0500 I/AUL     ( 4694): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 07:24:44.114-0500 I/AUL     ( 4694): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 07:24:44.114-0500 E/AUL     ( 4694): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-18 07:24:44.114-0500 E/AUL     ( 4694): aul_path.c: __get_path(169) > root_path is NULL!
02-18 07:24:44.114-0500 E/EFL     ( 4694): elementary<4694> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 07:24:44.114-0500 E/EFL     ( 4694): elementary<4694> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 07:24:44.194-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:44.194-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:44.244-0500 E/EFL     ( 4694): elementary<4694> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 07:24:44.244-0500 I/UXT     ( 4694): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
02-18 07:24:44.244-0500 E/EFL     ( 4694): elementary<4694> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 07:24:44.284-0500 E/EFL     ( 4694): elementary<4694> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 07:24:44.284-0500 E/EFL     ( 4694): elementary<4694> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 07:24:44.284-0500 E/EFL     ( 4694): elementary<4694> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 07:24:44.284-0500 E/EFL     ( 4694): elementary<4694> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 07:24:44.284-0500 E/EFL     ( 4694): elementary<4694> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 07:24:44.324-0500 E/EFL     ( 4694): elementary<4694> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 07:24:44.324-0500 E/EFL     ( 4694): elementary<4694> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 07:24:44.324-0500 E/EFL     ( 4694): elementary<4694> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 07:24:44.354-0500 E/EFL     ( 4694): elementary<4694> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 07:24:44.374-0500 E/EFL     ( 4694): elementary<4694> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 07:24:44.374-0500 E/EFL     ( 4694): elementary<4694> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 07:24:44.374-0500 E/EFL     ( 4694): elementary<4694> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 07:24:44.374-0500 E/EFL     ( 4694): elementary<4694> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 07:24:44.374-0500 E/EFL     ( 4694): elementary<4694> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 07:24:44.374-0500 E/EFL     ( 4694): elementary<4694> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 07:24:44.394-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:44.394-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:44.414-0500 I/Adreno-EGL( 4694): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
02-18 07:24:44.414-0500 I/Adreno-EGL( 4694): OpenGL ES Shader Compiler Version: E031.24.00.16
02-18 07:24:44.414-0500 I/Adreno-EGL( 4694): Build Date: 09/02/15 Wed
02-18 07:24:44.414-0500 I/Adreno-EGL( 4694): Local Branch: 
02-18 07:24:44.414-0500 I/Adreno-EGL( 4694): Remote Branch: 
02-18 07:24:44.414-0500 I/Adreno-EGL( 4694): Local Patches: 
02-18 07:24:44.414-0500 I/Adreno-EGL( 4694): Reconstruct Branch: 
02-18 07:24:44.484-0500 W/Adreno-ES20( 4694): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 07:24:44.484-0500 W/Adreno-ES20( 4694): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 07:24:44.484-0500 W/Adreno-ES20( 4694): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 07:24:44.484-0500 W/Adreno-ES20( 4694): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 07:24:44.484-0500 W/Adreno-ES20( 4694): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 07:24:44.484-0500 W/Adreno-ES20( 4694): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 07:24:44.484-0500 W/Adreno-ES20( 4694): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 07:24:44.484-0500 W/Adreno-ES20( 4694): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 07:24:44.484-0500 W/Adreno-ES20( 4694): <get_simple_queries:1550>: GL_INVALID_ENUM
02-18 07:24:44.594-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:44.594-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:44.794-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:44.794-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:44.874-0500 E/PKGMGR_SERVER( 4685): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
02-18 07:24:44.994-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:44.994-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:45.194-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:45.194-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:45.394-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:45.394-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:45.524-0500 E/PKGMGR_SERVER( 4685): pkgmgr-server.c: sighandler(409) > child NORMAL exit [4686]
02-18 07:24:45.524-0500 E/WMS     (  911): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
02-18 07:24:45.544-0500 W/W_HOME  ( 1180): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.example.metronomo is updated, need to check validation
02-18 07:24:45.544-0500 W/W_HOME  ( 1180): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:com.samsung.watchface
02-18 07:24:45.564-0500 E/WMS     (  911): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, COMPLETED]
02-18 07:24:45.564-0500 E/WMS     (  911): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6946) > package install complete
02-18 07:24:45.564-0500 E/WMS     (  911): wms_event_handler.c: _wms_event_handler_package_install_event(4818) > 
02-18 07:24:45.564-0500 E/WMS     (  911): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1758) > Found in install_req_list?[0], index[-1]
02-18 07:24:45.594-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:45.594-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:45.624-0500 E/STARTER ( 1102): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
02-18 07:24:45.624-0500 W/APPS    ( 1180): pkgmgr.c: _update_app(739) >  old order:[25]
02-18 07:24:45.654-0500 E/PKGMGR_INFO(  908): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
02-18 07:24:45.684-0500 E/EFL     ( 1180): elementary<1180> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0xb7ad87d8 into part 'elm.swallow.event.0'
02-18 07:24:45.684-0500 E/APPS    ( 1180): AppsViewNecklace.cpp: onShow(597) >  AppsItemList[26]
02-18 07:24:45.754-0500 E/Vi::Animations( 1180): result Vi::Animations::_AnimationManager::addAnimation(Vi::Animations::Visual&, const string*, Vi::Animations::Animation&)(288) > [E_OBJ_ALREADY_EXIST] Animation with keyName already exists. key name = hide
02-18 07:24:45.754-0500 I/Vi::Animations( 1180): result Vi::Animations::_VisualImpl::addAnimation(const string*, Vi::Animations::Animation&)(6999) > [E_OBJ_ALREADY_EXIST] Propagating.
02-18 07:24:45.764-0500 E/EFL     ( 1180): elementary<1180> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0xb7ad87d8 into part 'elm.swallow.event.0'
02-18 07:24:45.764-0500 E/APPS    ( 1180): AppsViewNecklace.cpp: onShow(597) >  AppsItemList[27]
02-18 07:24:45.794-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:45.794-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:45.994-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:45.994-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:46.194-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:46.194-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:46.254-0500 W/WATCH_CORE( 1242): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
02-18 07:24:46.264-0500 W/STARTER ( 1102): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
02-18 07:24:46.264-0500 W/STARTER ( 1102): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
02-18 07:24:46.264-0500 E/STARTER ( 1102): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
02-18 07:24:46.264-0500 W/STARTER ( 1102): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
02-18 07:24:46.264-0500 W/STARTER ( 1102): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
02-18 07:24:46.264-0500 W/WAKEUP-SERVICE( 1594): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : -1226986740[0;m
02-18 07:24:46.264-0500 W/WAKEUP-SERVICE( 1594): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
02-18 07:24:46.264-0500 W/WAKEUP-SERVICE( 1594): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
02-18 07:24:46.274-0500 I/TIZEN_N_SOUND_MANAGER( 1594): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Disable start
02-18 07:24:46.284-0500 I/TIZEN_N_SOUND_MANAGER( 1594): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Disable end. (ret: 0x0)
02-18 07:24:46.284-0500 W/TIZEN_N_SOUND_MANAGER( 1594): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-18 07:24:46.284-0500 W/WAKEUP-SERVICE( 1594): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
02-18 07:24:46.284-0500 I/HIGEAR  ( 1594): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
02-18 07:24:46.394-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:46.394-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:46.514-0500 W/MUSIC_CONTROL_SERVICE( 1312): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1312]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
02-18 07:24:46.514-0500 W/APPS    ( 1180): pkgmgr.c: _update_app_cb(718) >  Update apps order
02-18 07:24:46.514-0500 W/APPS    ( 1180): AppsViewNecklace.cpp: onTouchEventCancel(4360) >  touch cancel
02-18 07:24:46.544-0500 W/STARTER ( 1102): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
02-18 07:24:46.544-0500 W/STARTER ( 1102): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
02-18 07:24:46.544-0500 W/STARTER ( 1102): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
02-18 07:24:46.544-0500 W/STARTER ( 1102): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[1]
02-18 07:24:46.544-0500 I/SHealth_Common( 1631): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
02-18 07:24:46.544-0500 I/SHealth_Service( 1631): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
02-18 07:24:46.594-0500 I/CAPI_WATCH_APPLICATION( 1242): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 07:24:46.594-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 07:24:46.604-0500 W/W_HOME  ( 1180): dbus.c: _dbus_message_recv_cb(204) > LCD off
02-18 07:24:46.604-0500 W/W_HOME  ( 1180): gesture.c: _manual_render_disable_timer_del(151) > timer del
02-18 07:24:46.604-0500 W/W_HOME  ( 1180): gesture.c: _manual_render_enable(133) > 1
02-18 07:24:46.604-0500 W/W_HOME  ( 1180): event_manager.c: _lcd_off_cb(699) > lcd state: 0
02-18 07:24:46.604-0500 W/W_HOME  ( 1180): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 07:24:46.604-0500 I/APP_CORE( 1180): appcore-efl.c: __do_app(429) > [APP 1180] Event: PAUSE State: RUNNING
02-18 07:24:46.604-0500 I/CAPI_APPFW_APPLICATION( 1180): app_main.c: app_appcore_pause(202) > app_appcore_pause
02-18 07:24:46.604-0500 W/W_HOME  ( 1180): main.c: _appcore_pause_cb(692) > appcore pause
02-18 07:24:46.604-0500 W/W_HOME  ( 1180): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
02-18 07:24:46.604-0500 W/W_HOME  ( 1180): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 07:24:46.604-0500 W/W_HOME  ( 1180): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 07:24:46.604-0500 W/W_HOME  ( 1180): main.c: home_pause(762) > clock/widget paused
02-18 07:24:46.604-0500 W/W_HOME  ( 1180): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 07:24:46.604-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 07:24:46.604-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 07:24:46.604-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 07:24:46.604-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 07:24:46.604-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 07:24:46.604-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 07:24:46.604-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 07:24:46.604-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 07:24:46.604-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 07:24:46.604-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 07:24:46.604-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 07:24:46.604-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 07:24:46.604-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 07:24:46.604-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 07:24:46.604-0500 I/MESSAGE_PORT(  885): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 07:24:46.604-0500 I/MESSAGE_PORT(  885): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 07:24:46.604-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 07:24:46.604-0500 I/MESSAGE_PORT(  885): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 07:24:46.604-0500 E/CAPI_APPFW_APP_CONTROL( 1312): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
02-18 07:24:46.604-0500 W/MUSIC_CONTROL_SERVICE( 1312): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1312]   [com.samsung.w-home]register msg port [false][0m
02-18 07:24:46.604-0500 W/GESTURE (  258): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
02-18 07:24:46.654-0500 W/AUL_AMD (  937): amd_request.c: __request_handler(646) > __request_handler: 0
02-18 07:24:46.664-0500 I/AUL_AMD (  937): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
02-18 07:24:46.674-0500 I/AUL_AMD (  937): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
02-18 07:24:46.674-0500 E/AUL_AMD (  937): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
02-18 07:24:46.674-0500 W/AUL_AMD (  937): amd_launch.c: _start_app(1708) > caller pid : 4757
02-18 07:24:46.674-0500 W/AUL_AMD (  937): amd_launch.c: __nofork_processing(1151) > __nofork_processing, cmd: 0, pid: 3570
02-18 07:24:46.684-0500 W/AUL_AMD (  937): amd_launch.c: __reply_handler(922) > listen fd(20) , send fd(13), pid(3570), cmd(0)
02-18 07:24:46.684-0500 I/APP_CORE( 3570): appcore-efl.c: __do_app(429) > [APP 3570] Event: RESET State: PAUSED
02-18 07:24:46.684-0500 I/CAPI_APPFW_APPLICATION( 3570): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
02-18 07:24:46.684-0500 W/WATCH_CORE( 1242): appcore-watch.c: __widget_pause(1001) > widget_pause
02-18 07:24:46.684-0500 E/watchface-loader( 1242): watchface-loader.cpp: OnAppPause(713) > 
02-18 07:24:46.684-0500 E/watchface-viewer( 1242): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 07:24:46.684-0500 E/watchface-viewer( 1242): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 07:24:46.684-0500 E/watchface-viewer( 1242): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 07:24:46.684-0500 E/watchface-viewer( 1242): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 07:24:46.874-0500 E/PKGMGR_SERVER( 4685): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
02-18 07:24:46.874-0500 E/PKGMGR_SERVER( 4685): pkgmgr-server.c: main(2185) > package manager server terminated.
02-18 07:24:47.104-0500 I/AUL_AMD (  937): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3570
02-18 07:24:47.104-0500 I/APP_CORE( 1180): appcore-efl.c: __do_app(429) > [APP 1180] Event: MEM_FLUSH State: PAUSED
02-18 07:24:47.144-0500 W/CRASH_MANAGER( 4758): worker.c: worker_job(1199) > 11035706d6574148742068
