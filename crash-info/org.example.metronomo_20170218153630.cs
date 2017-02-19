S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.5
Build-Number: R730VVRU2BPC7
Build-Date: 2016.04.01 13:23:02

Crash Information
Process Name: metronomo
PID: 8818
Date: 2017-02-18 15:36:30-0500
Executable File Path: /opt/usr/apps/org.example.metronomo/bin/metronomo
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xc

Register Information
r0   = 0x00000001, r1   = 0x0000037c
r2   = 0x00000000, r3   = 0xb6f0f788
r4   = 0xb6f1db18, r5   = 0x00000140
r6   = 0x00000000, r7   = 0xb6f94159
r8   = 0x00000000, r9   = 0x00000000
r10  = 0xb6fa4c18, fp   = 0x00000000
ip   = 0xb6efe70d, sp   = 0xbee46508
lr   = 0xb6efe745, pc   = 0xb6ef706a
cpsr = 0x20000030

Memory Information
MemTotal:   389300 KB
MemFree:     13672 KB
Buffers:      4936 KB
Cached:      89952 KB
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
b3f6c000 b4036000 r-xp /usr/lib/libCOREGL.so.4.0
b404e000 b4051000 r-xp /lib/libattr.so.1.1.0
b4059000 b4060000 r-xp /lib/libcrypt-2.13.so
b4090000 b4093000 r-xp /lib/libcap.so.2.21
b409b000 b409d000 r-xp /usr/lib/libiri.so
b40a6000 b40c3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b40cc000 b40d5000 r-xp /usr/lib/libresourced.so.0.2.86
b40dd000 b40de000 r-xp /usr/lib/librd-network.so.0.2.86
b40e6000 b40f3000 r-xp /usr/lib/libail.so.0.1.0
b40fc000 b4103000 r-xp /usr/lib/libminizip.so.1.0.0
b410c000 b4139000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4141000 b4143000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b414b000 b4152000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b415b000 b4177000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b4180000 b4188000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
b4191000 b4197000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b419f000 b41a4000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
b41ac000 b41cd000 r-xp /usr/lib/libexif.so.12.3.3
b41e0000 b41f9000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
b4202000 b4205000 r-xp /usr/lib/libsmack.so.1.0.0
b420d000 b4212000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b421a000 b421f000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b57af000 b57ba000 r-xp /usr/lib/libgpg-error.so.0.15.0
b57c3000 b596b000 r-xp /usr/lib/libcrypto.so.1.0.0
b5984000 b59d1000 r-xp /usr/lib/libssl.so.1.0.0
b59dd000 b5a0b000 r-xp /usr/lib/libidn.so.11.5.44
b5a13000 b5a1c000 r-xp /usr/lib/libcares.so.2.1.0
b5a25000 b5a27000 r-xp /usr/lib/libXau.so.6.0.0
b5a30000 b5a32000 r-xp /usr/lib/libdri2.so.0.0.0
b5a3a000 b5a42000 r-xp /usr/lib/libdrm.so.2.4.0
b5a4a000 b5ade000 r-xp /usr/lib/libstdc++.so.6.0.16
b5af1000 b5af2000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b5afb000 b5afe000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
b5b07000 b5beb000 r-xp /usr/lib/libicuuc.so.51.1
b5c00000 b5d3d000 r-xp /usr/lib/libicui18n.so.51.1
b5d4d000 b5d4f000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5d57000 b5d59000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5d63000 b5ddf000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5deb000 b5e03000 r-xp /usr/lib/liblzma.so.5.0.3
b5e0b000 b5e11000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b5e1a000 b5e5e000 r-xp /usr/lib/libcurl.so.4.3.0
b5e68000 b5e8b000 r-xp /usr/lib/libjpeg.so.8.0.2
b5ea3000 b5eb6000 r-xp /usr/lib/libxcb.so.1.1.0
b5ebf000 b5ec5000 r-xp /usr/lib/libxcb-render.so.0.0.0
b5ecd000 b5ece000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b5ed7000 b5eef000 r-xp /usr/lib/libpng12.so.0.50.0
b5ef8000 b5efb000 r-xp /usr/lib/libEGL.so.1.4
b5f03000 b5f11000 r-xp /usr/lib/libGLESv2.so.2.0
b5f1a000 b5f1b000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5f23000 b5f3a000 r-xp /usr/lib/liblua-5.1.so
b5f43000 b5f4a000 r-xp /usr/lib/libembryo.so.1.7.99
b5f53000 b5f5a000 r-xp /usr/lib/libtbm.so.1.0.0
b5f62000 b5f83000 r-xp /usr/lib/libui-extension.so.0.1.0
b5f8c000 b5f9e000 r-xp /usr/lib/libtts.so
b5fa6000 b5fbc000 r-xp /lib/libexpat.so.1.5.2
b5fc6000 b5fc9000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b5fd2000 b5fd6000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b5fdf000 b5fe4000 r-xp /usr/lib/libecore_fb.so.1.7.99
b5fed000 b5ff7000 r-xp /usr/lib/libXext.so.6.4.0
b6000000 b6004000 r-xp /usr/lib/libXtst.so.6.1.0
b600c000 b6012000 r-xp /usr/lib/libXrender.so.1.3.0
b601b000 b6021000 r-xp /usr/lib/libXrandr.so.2.2.0
b6029000 b602a000 r-xp /usr/lib/libXinerama.so.1.0.0
b6033000 b6036000 r-xp /usr/lib/libXfixes.so.3.1.0
b603e000 b6040000 r-xp /usr/lib/libXgesture.so.7.0.0
b6048000 b604a000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6052000 b6054000 r-xp /usr/lib/libXdamage.so.1.1.0
b605d000 b6064000 r-xp /usr/lib/libXcursor.so.1.0.2
b606c000 b607c000 r-xp /lib/libresolv-2.13.so
b6080000 b6096000 r-xp /lib/libz.so.1.2.5
b609e000 b60a0000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b60a8000 b60ad000 r-xp /usr/lib/libffi.so.5.0.10
b60b6000 b60b7000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b60bf000 b6134000 r-xp /usr/lib/libsqlite3.so.0.8.6
b613e000 b6154000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b615c000 b615f000 r-xp /usr/lib/libproc-stat.so.0.2.86
b6167000 b61a3000 r-xp /usr/lib/libsystemd.so.0.4.0
b61ad000 b61b2000 r-xp /usr/lib/libxdgmime.so.1.1.0
b61ba000 b61d1000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b61d9000 b61db000 r-xp /usr/lib/libiniparser.so.0
b61e4000 b61ea000 r-xp /usr/lib/libecore_imf.so.1.7.99
b61f2000 b61f5000 r-xp /usr/lib/libbundle.so.0.1.22
b61fe000 b6204000 r-xp /usr/lib/libappsvc.so.0.1.0
b620c000 b6262000 r-xp /usr/lib/libpixman-1.so.0.28.2
b626f000 b62c5000 r-xp /usr/lib/libfreetype.so.6.11.3
b62d1000 b630e000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6317000 b632a000 r-xp /usr/lib/libfribidi.so.0.3.1
b6333000 b634d000 r-xp /usr/lib/libecore_con.so.1.7.99
b6356000 b6380000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6389000 b6392000 r-xp /usr/lib/libedbus.so.1.7.99
b639a000 b63ab000 r-xp /usr/lib/libecore_input.so.1.7.99
b63b3000 b63b8000 r-xp /usr/lib/libecore_file.so.1.7.99
b63c0000 b63d9000 r-xp /usr/lib/libeet.so.1.7.99
b63eb000 b63f4000 r-xp /usr/lib/libXi.so.6.1.0
b63fc000 b64dd000 r-xp /usr/lib/libX11.so.6.3.0
b64e8000 b65a0000 r-xp /usr/lib/libcairo.so.2.11200.14
b65ab000 b6608000 r-xp /usr/lib/libedje.so.1.7.99
b6612000 b667b000 r-xp /lib/libm-2.13.so
b6685000 b668b000 r-xp /lib/librt-2.13.so
b6694000 b66a6000 r-xp /usr/lib/libefl-assist.so.0.1.0
b66ae000 b677a000 r-xp /usr/lib/libxml2.so.2.7.8
b6787000 b67af000 r-xp /usr/lib/libfontconfig.so.1.8.0
b67b0000 b67d2000 r-xp /usr/lib/libecore_evas.so.1.7.99
b67dc000 b682c000 r-xp /usr/lib/libecore_x.so.1.7.99
b682e000 b68fe000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b68ff000 b6933000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b693c000 b6a0f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6a1a000 b6a1f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6a27000 b6a2b000 r-xp /usr/lib/libvconf.so.0.2.45
b6a33000 b6a47000 r-xp /lib/libpthread-2.13.so
b6a52000 b6a93000 r-xp /usr/lib/libeina.so.1.7.99
b6a9c000 b6abe000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6ac6000 b6ad2000 r-xp /usr/lib/libaul.so.0.1.0
b6adc000 b6ae1000 r-xp /usr/lib/libappcore-common.so.1.1
b6ae9000 b6aee000 r-xp /usr/lib/libappcore-efl.so.1.1
b6af6000 b6af8000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b6b01000 b6b05000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b6b0e000 b6b10000 r-xp /lib/libdl-2.13.so
b6b19000 b6b24000 r-xp /lib/libunwind.so.8.0.1
b6b51000 b6b59000 r-xp /lib/libgcc_s-4.6.so.1
b6b5a000 b6c75000 r-xp /lib/libc-2.13.so
b6c83000 b6d51000 r-xp /usr/lib/libevas.so.1.7.99
b6d76000 b6eb1000 r-xp /usr/lib/libelementary.so.1.7.99
b6ec7000 b6ee8000 r-xp /usr/lib/libefl-extension.so.0.1.0
b6ef0000 b6f07000 r-xp /usr/lib/libecore.so.1.7.99
b6f1e000 b6f20000 r-xp /usr/lib/libdlog.so.0.0.0
b6f28000 b6f30000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b6f31000 b6f36000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b6f3e000 b6f42000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b6f60000 b6f64000 r-xp /usr/lib/libsys-assert.so
b6f6d000 b6f8a000 r-xp /lib/ld-2.13.so
b6f93000 b6f95000 r-xp /opt/usr/apps/org.example.metronomo/bin/metronomo
b7cdb000 b7d1d000 rw-p [heap]
bee26000 bee47000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8818)
Call Stack Count: 5
 0: (0xb6ef706a) [/usr/lib/libecore.so.1] + 0x706a
 1: ecore_timer_add + 0x38 (0xb6efe745) [/usr/lib/libecore.so.1] + 0xe745
 2: main + 0x84 (0xb6f943b9) [/opt/usr/apps/org.example.metronomo/bin/metronomo] + 0x13b9
 3: __libc_start_main + 0x114 (0xb6b7182c) [/lib/libc.so.6] + 0x1782c
 4: (0xb6f93fcc) [/opt/usr/apps/org.example.metronomo/bin/metronomo] + 0xfcc
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
ds a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-18 15:36:04.119-0500 I/MESSAGE_PORT(  876): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 15:36:04.119-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 15:36:04.119-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 15:36:04.119-0500 W/MUSIC_CONTROL_SERVICE( 1614): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1614]   [MUSIC_PLAYER_EVENT][0m
02-18 15:36:04.119-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1614): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
02-18 15:36:04.119-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1614): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
02-18 15:36:04.119-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1614): preference.c: preference_get_int(1132) > preference_get_int(1614) : key(music-control-service_native/playing_diration) error
02-18 15:36:04.119-0500 W/MUSIC_CONTROL_SERVICE( 1614): music-control-info.c: music_control_info_get_player_position(582) > [31m[TID:1614]   preference_get_int() .. [0xfef00030][0m
02-18 15:36:04.119-0500 W/W_HOME  ( 1156): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
02-18 15:36:04.119-0500 E/W_HOME  ( 1156): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
02-18 15:36:04.119-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 15:36:04.119-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 15:36:04.119-0500 I/MESSAGE_PORT(  876): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 15:36:04.119-0500 I/MESSAGE_PORT(  876): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 15:36:04.119-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 15:36:04.119-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 15:36:04.119-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 15:36:04.129-0500 I/TIZEN_N_SOUND_MANAGER( 1614): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
02-18 15:36:04.129-0500 W/TIZEN_N_SOUND_MANAGER( 1614): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 15:36:04.129-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 15:36:04.139-0500 W/W_HOME  ( 1156): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
02-18 15:36:04.139-0500 E/W_HOME  ( 1156): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
02-18 15:36:04.229-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:04.229-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:04.419-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:04.419-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:04.609-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:04.609-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:04.809-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:04.809-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:05.009-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:05.009-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:05.129-0500 E/W_INDICATOR( 1100): windicator_moment_view.c: windicator_moment_view_hide(634) > [windicator_moment_view_hide:634] Hide Moment View : dynamic_layout(0xb92fe958),Type(1)
02-18 15:36:05.129-0500 E/W_INDICATOR( 1100): windicator_connection.c: windi_connection_pause(1671) > [windi_connection_pause:1671] Failed to deregister noti event : TAPI_PROP_MODEL_POWER
02-18 15:36:05.139-0500 W/PROCESSMGR(  599): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
02-18 15:36:05.139-0500 W/WATCH_CORE( 1244): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
02-18 15:36:05.139-0500 I/WATCH_CORE( 1244): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
02-18 15:36:05.139-0500 E/W_INDICATOR( 1100): windicator_util.c: windi_x_input_event_unregister(231) > [windi_x_input_event_unregister:231] not registered
02-18 15:36:05.139-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:05.139-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:05.139-0500 W/W_HOME  ( 1156): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
02-18 15:36:05.139-0500 W/W_HOME  ( 1156): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 15:36:05.139-0500 W/W_HOME  ( 1156): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 15:36:05.139-0500 W/W_HOME  ( 1156): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 15:36:05.139-0500 W/W_HOME  ( 1156): main.c: _ecore_x_message_cb(1233) > main_info.is_win_on_top: 1
02-18 15:36:05.139-0500 W/GESTURE (  257): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
02-18 15:36:05.159-0500 W/APP_CORE( 1100): appcore-efl.c: __hide_cb(809) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:1c00011
02-18 15:36:05.159-0500 I/APP_CORE( 1100): appcore-efl.c: __do_app(429) > [APP 1100] Event: PAUSE State: RUNNING
02-18 15:36:05.159-0500 I/CAPI_APPFW_APPLICATION( 1100): app_main.c: app_appcore_pause(202) > app_appcore_pause
02-18 15:36:05.199-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:05.199-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:05.399-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:05.399-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:05.599-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:05.599-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:05.799-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:05.799-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:05.999-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:05.999-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:06.199-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:06.199-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:06.399-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:06.399-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:06.599-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:06.599-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:06.799-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:06.799-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:06.999-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:06.999-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:07.199-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:07.199-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:07.399-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:07.399-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:07.589-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:07.589-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:07.789-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:07.789-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:07.989-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:07.989-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:08.199-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:08.199-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:08.399-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:08.399-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:08.599-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:08.599-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:08.799-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:08.799-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:08.999-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:08.999-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:09.199-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:09.199-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:09.399-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:09.399-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:09.469-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : -1226593524[0;m
02-18 15:36:09.469-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
02-18 15:36:09.469-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
02-18 15:36:09.479-0500 W/WATCH_CORE( 1244): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
02-18 15:36:09.489-0500 W/STARTER ( 1093): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
02-18 15:36:09.489-0500 W/STARTER ( 1093): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
02-18 15:36:09.489-0500 E/STARTER ( 1093): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
02-18 15:36:09.489-0500 W/STARTER ( 1093): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
02-18 15:36:09.489-0500 W/STARTER ( 1093): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
02-18 15:36:09.489-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Disable start
02-18 15:36:09.499-0500 I/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Disable end. (ret: 0x0)
02-18 15:36:09.499-0500 W/TIZEN_N_SOUND_MANAGER( 1580): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
02-18 15:36:09.499-0500 W/WAKEUP-SERVICE( 1580): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
02-18 15:36:09.499-0500 I/HIGEAR  ( 1580): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
02-18 15:36:09.599-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:09.599-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:09.759-0500 W/W_HOME  ( 1156): dbus.c: _dbus_message_recv_cb(204) > LCD off
02-18 15:36:09.759-0500 W/W_HOME  ( 1156): gesture.c: _manual_render_disable_timer_del(151) > timer del
02-18 15:36:09.759-0500 W/W_HOME  ( 1156): gesture.c: _manual_render_enable(133) > 1
02-18 15:36:09.759-0500 W/W_HOME  ( 1156): event_manager.c: _lcd_off_cb(699) > lcd state: 0
02-18 15:36:09.759-0500 W/W_HOME  ( 1156): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 15:36:09.769-0500 I/SHealth_Common( 1633): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
02-18 15:36:09.769-0500 I/SHealth_Service( 1633): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
02-18 15:36:09.769-0500 W/MUSIC_CONTROL_SERVICE( 1614): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1614]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
02-18 15:36:09.789-0500 W/STARTER ( 1093): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
02-18 15:36:09.789-0500 W/STARTER ( 1093): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
02-18 15:36:09.789-0500 W/STARTER ( 1093): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
02-18 15:36:09.789-0500 W/STARTER ( 1093): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[1]
02-18 15:36:09.789-0500 I/APP_CORE( 1156): appcore-efl.c: __do_app(429) > [APP 1156] Event: PAUSE State: RUNNING
02-18 15:36:09.789-0500 I/CAPI_APPFW_APPLICATION( 1156): app_main.c: app_appcore_pause(202) > app_appcore_pause
02-18 15:36:09.789-0500 W/W_HOME  ( 1156): main.c: _appcore_pause_cb(692) > appcore pause
02-18 15:36:09.789-0500 W/W_HOME  ( 1156): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
02-18 15:36:09.789-0500 W/W_HOME  ( 1156): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 15:36:09.789-0500 W/W_HOME  ( 1156): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 15:36:09.799-0500 W/W_HOME  ( 1156): main.c: home_pause(762) > clock/widget paused
02-18 15:36:09.799-0500 W/W_HOME  ( 1156): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 15:36:09.799-0500 I/CAPI_WATCH_APPLICATION( 1244): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 15:36:09.799-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 15:36:09.799-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 15:36:09.799-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 15:36:09.799-0500 I/MESSAGE_PORT(  876): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 15:36:09.799-0500 I/MESSAGE_PORT(  876): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 15:36:09.799-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 15:36:09.799-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 15:36:09.799-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 15:36:09.799-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 15:36:09.799-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 15:36:09.799-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 15:36:09.799-0500 I/MESSAGE_PORT(  876): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 15:36:09.799-0500 I/MESSAGE_PORT(  876): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 15:36:09.799-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 15:36:09.799-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 15:36:09.799-0500 I/MESSAGE_PORT(  876): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 15:36:09.799-0500 I/MESSAGE_PORT(  876): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 15:36:09.799-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 15:36:09.799-0500 I/MESSAGE_PORT(  876): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 15:36:09.799-0500 W/GESTURE (  257): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
02-18 15:36:09.809-0500 E/CAPI_APPFW_APP_CONTROL( 1614): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
02-18 15:36:09.809-0500 W/MUSIC_CONTROL_SERVICE( 1614): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1614]   [com.samsung.w-home]register msg port [false][0m
02-18 15:36:09.909-0500 W/WATCH_CORE( 1244): appcore-watch.c: __widget_pause(1001) > widget_pause
02-18 15:36:09.909-0500 E/watchface-loader( 1244): watchface-loader.cpp: OnAppPause(713) > 
02-18 15:36:09.909-0500 E/watchface-viewer( 1244): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 15:36:09.909-0500 E/watchface-viewer( 1244): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 15:36:09.909-0500 E/watchface-viewer( 1244): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 15:36:09.909-0500 E/watchface-viewer( 1244): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
02-18 15:36:10.169-0500 I/APP_CORE( 1100): appcore-efl.c: __do_app(429) > [APP 1100] Event: MEM_FLUSH State: PAUSED
02-18 15:36:10.309-0500 I/APP_CORE( 1156): appcore-efl.c: __do_app(429) > [APP 1156] Event: MEM_FLUSH State: PAUSED
02-18 15:36:14.840-0500 I/APP_CORE( 1156): appcore-efl.c: __do_app(429) > [APP 1156] Event: MEM_FLUSH State: PAUSED
02-18 15:36:20.829-0500 E/PKGMGR  ( 8728): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
02-18 15:36:20.959-0500 E/PKGMGR_SERVER( 8735): pkgmgr-server.c: main(2131) > package manager server start
02-18 15:36:21.049-0500 E/PKGMGR_SERVER( 8735): pkgmgr-server.c: req_cb(650) > req_id=[org.example.metronomo_-72968215], req_type=[1], pkg_type=[rpm], pkgid=[org.example.metronomo], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.metronomo_-72968215' '-r' 'org.example.metronomo'], cookie=[jXGStFsaNx4ZUIubRzlRCDHcw7E=], backend_flag=[0]
02-18 15:36:21.049-0500 E/PKGMGR  ( 8735): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.metronomo]
02-18 15:36:21.049-0500 E/PKGMGR_SERVER( 8735): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.metronomo 
02-18 15:36:21.049-0500 E/PKGMGR  ( 8728): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[87280002]
02-18 15:36:21.049-0500 E/PKGMGR_SERVER( 8737): pkgmgr-server.c: queue_job(1815) > INSTALL start, pkg path=[org.example.metronomo]
02-18 15:36:21.269-0500 E/WMS     (  901): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, STARTED]
02-18 15:36:21.269-0500 W/AUL_AMD (  935): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
02-18 15:36:21.289-0500 E/WMS     (  901): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
02-18 15:36:21.289-0500 W/W_HOME  ( 1156): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.metronomo is being updateded:0
02-18 15:36:21.439-0500 W/CERT_SVC( 8737): DUID.cpp: CheckCertifiedDevice(675) > No device id on distributor certificate
02-18 15:36:21.479-0500 E/PKGMGR_CERT( 8737): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
02-18 15:36:21.489-0500 E/WMS     (  901): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
02-18 15:36:21.489-0500 E/PKGMGR_CERT( 8737): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 101
02-18 15:36:21.489-0500 E/PKGMGR_CERT( 8737): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 101
02-18 15:36:21.489-0500 E/PKGMGR_CERT( 8737): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 1
02-18 15:36:21.489-0500 E/PKGMGR_CERT( 8737): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 1
02-18 15:36:21.489-0500 E/PKGMGR_CERT( 8737): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 1
02-18 15:36:21.489-0500 E/PKGMGR_CERT( 8737): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 26 1
02-18 15:36:21.509-0500 E/PKGMGR_CERT( 8737): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
02-18 15:36:21.699-0500 I/AUL_AMD (  935): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 7781
02-18 15:36:21.779-0500 I/AUL_AMD (  935): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 8292
02-18 15:36:21.889-0500 I/AUL_AMD (  935): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 7662
02-18 15:36:21.909-0500 E/EFL     ( 8738): elementary<8738> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 15:36:21.909-0500 E/EFL     ( 8738): elementary<8738> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 15:36:21.929-0500 E/EFL     ( 8738): elementary<8738> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 15:36:21.929-0500 E/EFL     ( 8738): elementary<8738> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 15:36:21.969-0500 E/EFL     ( 8738): elementary<8738> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 15:36:21.969-0500 E/EFL     ( 8738): elementary<8738> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 15:36:21.969-0500 E/EFL     ( 8738): elementary<8738> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 15:36:21.969-0500 E/EFL     ( 8738): elementary<8738> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 15:36:21.969-0500 E/EFL     ( 8738): elementary<8738> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 15:36:21.999-0500 E/EFL     ( 8738): elementary<8738> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 15:36:22.009-0500 E/EFL     ( 8738): elementary<8738> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 15:36:22.009-0500 E/EFL     ( 8738): elementary<8738> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 15:36:22.039-0500 E/EFL     ( 8738): elementary<8738> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 15:36:22.039-0500 E/EFL     ( 8738): elementary<8738> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 15:36:22.039-0500 E/EFL     ( 8738): elementary<8738> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 15:36:22.039-0500 E/EFL     ( 8738): elementary<8738> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 15:36:22.039-0500 E/EFL     ( 8738): elementary<8738> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 15:36:22.039-0500 E/EFL     ( 8738): elementary<8738> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 15:36:22.039-0500 E/EFL     ( 8738): elementary<8738> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 15:36:22.039-0500 I/AUL_PAD ( 8738): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
02-18 15:36:22.309-0500 I/efl-extension( 8740): efl_extension.c: eext_mod_init(40) > Init
02-18 15:36:22.329-0500 E/EFL     ( 8740): elementary<8740> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 15:36:22.329-0500 E/EFL     ( 8740): elementary<8740> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 15:36:22.359-0500 E/EFL     ( 8740): elementary<8740> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 15:36:22.359-0500 I/UXT     ( 8740): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
02-18 15:36:22.359-0500 E/EFL     ( 8740): elementary<8740> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 15:36:22.399-0500 E/EFL     ( 8740): elementary<8740> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 15:36:22.399-0500 E/EFL     ( 8740): elementary<8740> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 15:36:22.399-0500 E/EFL     ( 8740): elementary<8740> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 15:36:22.399-0500 E/EFL     ( 8740): elementary<8740> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 15:36:22.399-0500 E/EFL     ( 8740): elementary<8740> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 15:36:22.409-0500 I/AUL_AMD (  935): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 8739
02-18 15:36:22.419-0500 E/EFL     ( 8740): elementary<8740> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 15:36:22.419-0500 E/EFL     ( 8740): elementary<8740> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 15:36:22.419-0500 E/EFL     ( 8740): elementary<8740> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 15:36:22.509-0500 I/AUL_AMD (  935): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 8738
02-18 15:36:22.519-0500 E/EFL     ( 8740): elementary<8740> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 15:36:22.519-0500 E/EFL     ( 8740): elementary<8740> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 15:36:22.519-0500 E/EFL     ( 8740): elementary<8740> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 15:36:22.519-0500 E/EFL     ( 8740): elementary<8740> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 15:36:22.519-0500 E/EFL     ( 8740): elementary<8740> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 15:36:22.519-0500 E/EFL     ( 8740): elementary<8740> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 15:36:22.519-0500 E/EFL     ( 8740): elementary<8740> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 15:36:22.519-0500 I/AUL_PAD ( 8740): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
02-18 15:36:22.539-0500 I/Adreno-EGL( 8740): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
02-18 15:36:22.539-0500 I/Adreno-EGL( 8740): OpenGL ES Shader Compiler Version: E031.24.00.16
02-18 15:36:22.539-0500 I/Adreno-EGL( 8740): Build Date: 09/02/15 Wed
02-18 15:36:22.539-0500 I/Adreno-EGL( 8740): Local Branch: 
02-18 15:36:22.539-0500 I/Adreno-EGL( 8740): Remote Branch: 
02-18 15:36:22.539-0500 I/Adreno-EGL( 8740): Local Patches: 
02-18 15:36:22.539-0500 I/Adreno-EGL( 8740): Reconstruct Branch: 
02-18 15:36:23.359-0500 W/MM_CAMCORDER( 8741): mm_camcorder_internal.c: _mmcamcorder_constructor(204) >  start
02-18 15:36:23.359-0500 W/MM_CAMCORDER( 8741): mm_camcorder_internal.c: _mmcamcorder_constructor(214) >  done
02-18 15:36:23.359-0500 I/efl-extension( 8741): efl_extension.c: eext_mod_init(40) > Init
02-18 15:36:23.639-0500 E/rpm-installer( 8737): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
02-18 15:36:23.699-0500 E/PKGMGR_SERVER( 8735): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
02-18 15:36:24.089-0500 I/AUL     ( 8741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 15:36:24.109-0500 I/AUL     ( 8741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 15:36:24.109-0500 E/AUL     ( 8741): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-18 15:36:24.109-0500 E/AUL     ( 8741): aul_path.c: __get_path(169) > root_path is NULL!
02-18 15:36:24.139-0500 I/AUL     ( 8741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 15:36:24.149-0500 I/AUL     ( 8741): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 15:36:24.149-0500 E/AUL     ( 8741): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-18 15:36:24.149-0500 E/AUL     ( 8741): aul_path.c: __get_path(169) > root_path is NULL!
02-18 15:36:24.149-0500 E/EFL     ( 8741): elementary<8741> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 15:36:24.149-0500 E/EFL     ( 8741): elementary<8741> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 15:36:24.179-0500 E/EFL     ( 8741): elementary<8741> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 15:36:24.179-0500 I/UXT     ( 8741): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
02-18 15:36:24.179-0500 E/EFL     ( 8741): elementary<8741> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 15:36:24.209-0500 E/EFL     ( 8741): elementary<8741> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 15:36:24.209-0500 E/EFL     ( 8741): elementary<8741> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 15:36:24.209-0500 E/EFL     ( 8741): elementary<8741> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 15:36:24.209-0500 E/EFL     ( 8741): elementary<8741> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 15:36:24.209-0500 E/EFL     ( 8741): elementary<8741> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 15:36:24.229-0500 E/EFL     ( 8741): elementary<8741> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 15:36:24.229-0500 E/EFL     ( 8741): elementary<8741> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 15:36:24.229-0500 E/EFL     ( 8741): elementary<8741> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 15:36:24.259-0500 E/EFL     ( 8741): elementary<8741> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 15:36:24.269-0500 E/EFL     ( 8741): elementary<8741> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 15:36:24.269-0500 E/EFL     ( 8741): elementary<8741> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 15:36:24.269-0500 E/EFL     ( 8741): elementary<8741> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 15:36:24.269-0500 E/EFL     ( 8741): elementary<8741> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 15:36:24.269-0500 E/EFL     ( 8741): elementary<8741> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 15:36:24.269-0500 E/EFL     ( 8741): elementary<8741> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 15:36:24.289-0500 I/Adreno-EGL( 8741): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
02-18 15:36:24.289-0500 I/Adreno-EGL( 8741): OpenGL ES Shader Compiler Version: E031.24.00.16
02-18 15:36:24.289-0500 I/Adreno-EGL( 8741): Build Date: 09/02/15 Wed
02-18 15:36:24.289-0500 I/Adreno-EGL( 8741): Local Branch: 
02-18 15:36:24.289-0500 I/Adreno-EGL( 8741): Remote Branch: 
02-18 15:36:24.289-0500 I/Adreno-EGL( 8741): Local Patches: 
02-18 15:36:24.289-0500 I/Adreno-EGL( 8741): Reconstruct Branch: 
02-18 15:36:24.349-0500 W/Adreno-ES20( 8741): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 15:36:24.349-0500 W/Adreno-ES20( 8741): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 15:36:24.349-0500 W/Adreno-ES20( 8741): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 15:36:24.349-0500 W/Adreno-ES20( 8741): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 15:36:24.349-0500 W/Adreno-ES20( 8741): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 15:36:24.349-0500 W/Adreno-ES20( 8741): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 15:36:24.349-0500 W/Adreno-ES20( 8741): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 15:36:24.349-0500 W/Adreno-ES20( 8741): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 15:36:24.349-0500 W/Adreno-ES20( 8741): <get_simple_queries:1550>: GL_INVALID_ENUM
02-18 15:36:25.699-0500 E/PKGMGR_SERVER( 8735): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
02-18 15:36:26.849-0500 W/W_HOME  ( 1156): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.example.metronomo is updated, need to check validation
02-18 15:36:26.849-0500 W/W_HOME  ( 1156): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:com.samsung.watchface
02-18 15:36:26.859-0500 E/WMS     (  901): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
02-18 15:36:26.859-0500 E/WMS     (  901): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, COMPLETED]
02-18 15:36:26.859-0500 E/WMS     (  901): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6946) > package install complete
02-18 15:36:26.859-0500 E/WMS     (  901): wms_event_handler.c: _wms_event_handler_package_install_event(4818) > 
02-18 15:36:26.859-0500 E/WMS     (  901): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1758) > Found in install_req_list?[0], index[-1]
02-18 15:36:26.929-0500 E/PKGMGR_SERVER( 8735): pkgmgr-server.c: sighandler(409) > child NORMAL exit [8737]
02-18 15:36:26.989-0500 W/APPS    ( 1156): pkgmgr.c: _update_app(739) >  old order:[25]
02-18 15:36:26.999-0500 E/PKGMGR_INFO(  900): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
02-18 15:36:26.999-0500 E/STARTER ( 1093): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
02-18 15:36:27.049-0500 E/EFL     ( 1156): elementary<1156> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0xb7fc2518 into part 'elm.swallow.event.0'
02-18 15:36:27.049-0500 E/APPS    ( 1156): AppsViewNecklace.cpp: onShow(597) >  AppsItemList[26]
02-18 15:36:27.049-0500 W/APPS    ( 1156): AppsItem.cpp: onItemBadgeShow(599) >  badge show:[0:1]
02-18 15:36:27.099-0500 E/Vi::Animations( 1156): result Vi::Animations::_AnimationManager::addAnimation(Vi::Animations::Visual&, const string*, Vi::Animations::Animation&)(288) > [E_OBJ_ALREADY_EXIST] Animation with keyName already exists. key name = hide
02-18 15:36:27.099-0500 I/Vi::Animations( 1156): result Vi::Animations::_VisualImpl::addAnimation(const string*, Vi::Animations::Animation&)(6999) > [E_OBJ_ALREADY_EXIST] Propagating.
02-18 15:36:27.099-0500 E/Vi::Animations( 1156): result Vi::Animations::_AnimationManager::addAnimation(Vi::Animations::Visual&, const string*, Vi::Animations::Animation&)(288) > [E_OBJ_ALREADY_EXIST] Animation with keyName already exists. key name = hide
02-18 15:36:27.099-0500 I/Vi::Animations( 1156): result Vi::Animations::_VisualImpl::addAnimation(const string*, Vi::Animations::Animation&)(6999) > [E_OBJ_ALREADY_EXIST] Propagating.
02-18 15:36:27.099-0500 E/EFL     ( 1156): elementary<1156> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0xb7fc2518 into part 'elm.swallow.event.0'
02-18 15:36:27.099-0500 E/APPS    ( 1156): AppsViewNecklace.cpp: onShow(597) >  AppsItemList[27]
02-18 15:36:27.099-0500 W/APPS    ( 1156): AppsItem.cpp: onItemBadgeShow(599) >  badge show:[0:1]
02-18 15:36:27.619-0500 W/APPS    ( 1156): pkgmgr.c: _update_app_cb(718) >  Update apps order
02-18 15:36:27.619-0500 W/APPS    ( 1156): AppsViewNecklace.cpp: onTouchEventCancel(4360) >  touch cancel
02-18 15:36:27.699-0500 E/PKGMGR_SERVER( 8735): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
02-18 15:36:27.699-0500 E/PKGMGR_SERVER( 8735): pkgmgr-server.c: main(2185) > package manager server terminated.
02-18 15:36:27.839-0500 W/APPS    ( 1156): AppsItem.cpp: onItemBadgeShow(599) >  badge show:[0:1]
02-18 15:36:30.099-0500 W/AUL_AMD (  935): amd_request.c: __request_handler(646) > __request_handler: 0
02-18 15:36:30.119-0500 I/AUL_AMD (  935): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
02-18 15:36:30.129-0500 I/AUL_AMD (  935): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
02-18 15:36:30.129-0500 E/AUL_AMD (  935): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
02-18 15:36:30.129-0500 W/AUL_AMD (  935): amd_launch.c: _start_app(1708) > caller pid : 8816
02-18 15:36:30.149-0500 E/RESOURCED(  936): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.metronomo, table num : 1
02-18 15:36:30.149-0500 E/RESOURCED(  936): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
02-18 15:36:30.149-0500 W/AUL_AMD (  935): amd_launch.c: _start_app(2086) > pad pid(-5)
02-18 15:36:30.149-0500 W/AUL_PAD ( 1713): launchpad.c: __launchpad_main_loop(607) > Candidate is not prepared, enter legacy logic
02-18 15:36:30.149-0500 W/AUL_PAD ( 1713): launchpad.c: __send_result_to_caller(272) > Check app launching
02-18 15:36:30.149-0500 W/AUL_AMD (  935): amd_launch.c: _start_app(2097) > Launch with legacy way : no launchpad
02-18 15:36:30.149-0500 W/AUL_AMD (  935): amd_launch.c: start_process(580) > child process: 8818
02-18 15:36:30.199-0500 W/AUL_AMD (  935): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 8818
02-18 15:36:30.209-0500 E/RESOURCED(  936): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.metronomo
02-18 15:36:30.239-0500 W/AUL_AMD (  935): amd_request.c: __request_handler(646) > __request_handler: 14
02-18 15:36:30.249-0500 W/AUL_AMD (  935): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 8818
02-18 15:36:30.249-0500 W/AUL_AMD (  935): amd_request.c: __request_handler(646) > __request_handler: 12
02-18 15:36:30.299-0500 I/efl-extension( 8818): efl_extension.c: eext_mod_init(40) > Init
02-18 15:36:30.359-0500 E/EFL     ( 8817): elementary<8817> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 15:36:30.359-0500 E/EFL     ( 8817): elementary<8817> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 15:36:30.379-0500 E/EFL     ( 8817): elementary<8817> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 15:36:30.379-0500 E/EFL     ( 8817): elementary<8817> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 15:36:30.409-0500 W/AUL_AMD (  935): amd_request.c: __request_handler(646) > __request_handler: 23
02-18 15:36:30.409-0500 W/AUL_AMD (  935): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
02-18 15:36:30.409-0500 W/AUL_AMD (  935): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 8818
02-18 15:36:30.409-0500 W/AUL_AMD (  935): amd_request.c: __send_app_termination_signal(511) > send dead signal done
02-18 15:36:30.419-0500 E/EFL     ( 8817): elementary<8817> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 15:36:30.419-0500 E/EFL     ( 8817): elementary<8817> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 15:36:30.419-0500 E/EFL     ( 8817): elementary<8817> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 15:36:30.419-0500 E/EFL     ( 8817): elementary<8817> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 15:36:30.419-0500 E/EFL     ( 8817): elementary<8817> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 15:36:30.419-0500 I/AUL_AMD (  935): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 8818
02-18 15:36:30.459-0500 E/EFL     ( 8817): elementary<8817> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 15:36:30.459-0500 E/EFL     ( 8817): elementary<8817> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 15:36:30.459-0500 E/EFL     ( 8817): elementary<8817> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 15:36:30.499-0500 E/EFL     ( 8817): elementary<8817> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 15:36:30.499-0500 E/EFL     ( 8817): elementary<8817> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 15:36:30.499-0500 E/EFL     ( 8817): elementary<8817> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 15:36:30.499-0500 E/EFL     ( 8817): elementary<8817> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 15:36:30.499-0500 E/EFL     ( 8817): elementary<8817> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 15:36:30.499-0500 E/EFL     ( 8817): elementary<8817> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 15:36:30.499-0500 E/EFL     ( 8817): elementary<8817> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 15:36:30.499-0500 I/AUL_PAD ( 8817): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
02-18 15:36:30.549-0500 W/CRASH_MANAGER( 8825): worker.c: worker_job(1199) > 11088186d6574148745019
