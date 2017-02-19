S/W Version Information
Model: SM-R730V
Tizen-Version: 2.3.1.5
Build-Number: R730VVRU2BPC7
Build-Date: 2016.04.01 13:23:02

Crash Information
Process Name: metronomo
PID: 7057
Date: 2017-02-18 04:43:56-0500
Executable File Path: /opt/usr/apps/org.example.metronomo/bin/metronomo
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xbc4

Register Information
r0   = 0x00000f49, r1   = 0xb7b4e9f0
r2   = 0xb5800798, r3   = 0xb57f01d5
r4   = 0xbea5f54c, r5   = 0xb5b25980
r6   = 0xb7c40070, r7   = 0x00000285
r8   = 0x00000041, r9   = 0xb6be5824
r10  = 0xb7be4800, fp   = 0x00000000
ip   = 0xb58007ec, sp   = 0xbea5ed00
lr   = 0xb57f01e9, pc   = 0x00000bc4
cpsr = 0x60000010

Memory Information
MemTotal:   389300 KB
MemFree:     21912 KB
Buffers:     11216 KB
Cached:      95072 KB
VmPeak:      68684 KB
VmSize:      67740 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14040 KB
VmRSS:       14040 KB
VmData:      12224 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       23056 KB
VmPTE:          48 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 7057 TID = 7057
7057 7148 

Maps Information
b2f74000 b2f75000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
b2f7d000 b2f80000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b2f88000 b300f000 rw-s anon_inode:dmabuf
b308f000 b388e000 rw-p [stack:7148]
b388e000 b38a5000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b38b2000 b38b4000 r-xp /usr/lib/libgenlock.so
b38c4000 b38c6000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b38d2000 b38d7000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b38df000 b38ea000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b3c52000 b3d1c000 r-xp /usr/lib/libCOREGL.so.4.0
b3d2d000 b3d36000 r-xp /usr/lib/libresourced.so.0.2.86
b3d3e000 b3d3f000 r-xp /usr/lib/librd-network.so.0.2.86
b3d47000 b3d54000 r-xp /usr/lib/libail.so.0.1.0
b3d5d000 b3d64000 r-xp /usr/lib/libminizip.so.1.0.0
b3d6c000 b3d6e000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b3d76000 b3d7d000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b3d86000 b3da2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b3dab000 b3db3000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
b3dbb000 b3dc1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b3dc9000 b3dce000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
b3dd6000 b3df7000 r-xp /usr/lib/libexif.so.12.3.3
b3e0a000 b3e23000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
b3e2b000 b3e30000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3e38000 b3e3d000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b53cd000 b53cf000 r-xp /usr/lib/libdri2.so.0.0.0
b53d7000 b53df000 r-xp /usr/lib/libdrm.so.2.4.0
b53e7000 b53e8000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b53f1000 b53f4000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
b53fc000 b54e0000 r-xp /usr/lib/libicuuc.so.51.1
b54f5000 b5632000 r-xp /usr/lib/libicui18n.so.51.1
b5642000 b5648000 r-xp /usr/lib/libxcb-render.so.0.0.0
b5650000 b5651000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b565a000 b565d000 r-xp /usr/lib/libEGL.so.1.4
b5665000 b5673000 r-xp /usr/lib/libGLESv2.so.2.0
b567c000 b5683000 r-xp /usr/lib/libtbm.so.1.0.0
b568b000 b56ac000 r-xp /usr/lib/libui-extension.so.0.1.0
b56b5000 b56c7000 r-xp /usr/lib/libtts.so
b56cf000 b5787000 r-xp /usr/lib/libcairo.so.2.11200.14
b5792000 b57a4000 r-xp /usr/lib/libefl-assist.so.0.1.0
b57ac000 b57b1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b57b9000 b57da000 r-xp /usr/lib/libefl-extension.so.0.1.0
b57e2000 b57e7000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b57ef000 b57f1000 r-xp /opt/usr/apps/org.example.metronomo/bin/metronomo
b59a0000 b59aa000 r-xp /lib/libnss_files-2.13.so
b59b3000 b5a82000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5a98000 b5abc000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5ac5000 b5acb000 r-xp /usr/lib/libappsvc.so.0.1.0
b5ad3000 b5ad5000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5ade000 b5ae2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5aee000 b5af9000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b5b01000 b5b03000 r-xp /usr/lib/libiniparser.so.0
b5b0c000 b5b11000 r-xp /usr/lib/libappcore-common.so.1.1
b5b1a000 b5b22000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b5b23000 b5b27000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5b34000 b5b36000 r-xp /usr/lib/libXau.so.6.0.0
b5b3f000 b5b46000 r-xp /lib/libcrypt-2.13.so
b5b76000 b5b78000 r-xp /usr/lib/libiri.so
b5b80000 b5d28000 r-xp /usr/lib/libcrypto.so.1.0.0
b5d41000 b5d8e000 r-xp /usr/lib/libssl.so.1.0.0
b5d9b000 b5dc9000 r-xp /usr/lib/libidn.so.11.5.44
b5dd1000 b5dda000 r-xp /usr/lib/libcares.so.2.1.0
b5de3000 b5df6000 r-xp /usr/lib/libxcb.so.1.1.0
b5dff000 b5e01000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5e0a000 b5e0c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5e15000 b5ee1000 r-xp /usr/lib/libxml2.so.2.7.8
b5eee000 b5ef0000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5ef8000 b5efd000 r-xp /usr/lib/libffi.so.5.0.10
b5f05000 b5f06000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5f0f000 b5f1a000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5f22000 b5f25000 r-xp /lib/libattr.so.1.1.0
b5f2d000 b5fc1000 r-xp /usr/lib/libstdc++.so.6.0.16
b5fd4000 b5ff1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5ffa000 b6012000 r-xp /usr/lib/libpng12.so.0.50.0
b601b000 b6031000 r-xp /lib/libexpat.so.1.5.2
b603b000 b607f000 r-xp /usr/lib/libcurl.so.4.3.0
b6088000 b6092000 r-xp /usr/lib/libXext.so.6.4.0
b609b000 b609f000 r-xp /usr/lib/libXtst.so.6.1.0
b60a7000 b60ad000 r-xp /usr/lib/libXrender.so.1.3.0
b60b6000 b60bc000 r-xp /usr/lib/libXrandr.so.2.2.0
b60c4000 b60c5000 r-xp /usr/lib/libXinerama.so.1.0.0
b60ce000 b60d7000 r-xp /usr/lib/libXi.so.6.1.0
b60df000 b60e2000 r-xp /usr/lib/libXfixes.so.3.1.0
b60ea000 b60ec000 r-xp /usr/lib/libXgesture.so.7.0.0
b60f4000 b60f6000 r-xp /usr/lib/libXcomposite.so.1.0.0
b60ff000 b6101000 r-xp /usr/lib/libXdamage.so.1.1.0
b6109000 b6110000 r-xp /usr/lib/libXcursor.so.1.0.2
b6118000 b611b000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6123000 b6127000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6130000 b6135000 r-xp /usr/lib/libecore_fb.so.1.7.99
b613f000 b6220000 r-xp /usr/lib/libX11.so.6.3.0
b622b000 b624e000 r-xp /usr/lib/libjpeg.so.8.0.2
b6266000 b627c000 r-xp /lib/libz.so.1.2.5
b6284000 b62f9000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6303000 b6319000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6322000 b6356000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b635f000 b6432000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b643d000 b644d000 r-xp /lib/libresolv-2.13.so
b6451000 b64cd000 r-xp /usr/lib/libgcrypt.so.20.0.3
b64d9000 b64f1000 r-xp /usr/lib/liblzma.so.5.0.3
b64fa000 b64fd000 r-xp /lib/libcap.so.2.21
b6505000 b6532000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b653a000 b653b000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b6543000 b6549000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6551000 b6568000 r-xp /usr/lib/liblua-5.1.so
b6572000 b6579000 r-xp /usr/lib/libembryo.so.1.7.99
b6581000 b6587000 r-xp /lib/librt-2.13.so
b6590000 b65e6000 r-xp /usr/lib/libpixman-1.so.0.28.2
b65f3000 b6649000 r-xp /usr/lib/libfreetype.so.6.11.3
b6655000 b667d000 r-xp /usr/lib/libfontconfig.so.1.8.0
b667f000 b66bc000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b66c5000 b66d8000 r-xp /usr/lib/libfribidi.so.0.3.1
b66e0000 b66fa000 r-xp /usr/lib/libecore_con.so.1.7.99
b6703000 b670c000 r-xp /usr/lib/libedbus.so.1.7.99
b6714000 b6764000 r-xp /usr/lib/libecore_x.so.1.7.99
b6767000 b676b000 r-xp /usr/lib/libvconf.so.0.2.45
b6773000 b6784000 r-xp /usr/lib/libecore_input.so.1.7.99
b678c000 b6791000 r-xp /usr/lib/libecore_file.so.1.7.99
b6799000 b67bb000 r-xp /usr/lib/libecore_evas.so.1.7.99
b67c4000 b6805000 r-xp /usr/lib/libeina.so.1.7.99
b680e000 b6827000 r-xp /usr/lib/libeet.so.1.7.99
b6838000 b68a1000 r-xp /lib/libm-2.13.so
b68aa000 b68b0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b68b9000 b68bc000 r-xp /usr/lib/libproc-stat.so.0.2.86
b68c4000 b68e6000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b68ee000 b68f3000 r-xp /usr/lib/libxdgmime.so.1.1.0
b68fb000 b6925000 r-xp /usr/lib/libdbus-1.so.3.8.12
b692e000 b6945000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b694d000 b6958000 r-xp /lib/libunwind.so.8.0.1
b6985000 b69c1000 r-xp /usr/lib/libsystemd.so.0.4.0
b69ca000 b6ae5000 r-xp /lib/libc-2.13.so
b6af3000 b6afb000 r-xp /lib/libgcc_s-4.6.so.1
b6afc000 b6aff000 r-xp /usr/lib/libsmack.so.1.0.0
b6b07000 b6b0d000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6b15000 b6be5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6be6000 b6c43000 r-xp /usr/lib/libedje.so.1.7.99
b6c4d000 b6c64000 r-xp /usr/lib/libecore.so.1.7.99
b6c7b000 b6d49000 r-xp /usr/lib/libevas.so.1.7.99
b6d6e000 b6ea9000 r-xp /usr/lib/libelementary.so.1.7.99
b6ebf000 b6ed3000 r-xp /lib/libpthread-2.13.so
b6ede000 b6ee0000 r-xp /usr/lib/libdlog.so.0.0.0
b6ee8000 b6eeb000 r-xp /usr/lib/libbundle.so.0.1.22
b6ef3000 b6ef5000 r-xp /lib/libdl-2.13.so
b6efe000 b6f0a000 r-xp /usr/lib/libaul.so.0.1.0
b6f1c000 b6f21000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f2a000 b6f2e000 r-xp /usr/lib/libsys-assert.so
b6f37000 b6f54000 r-xp /lib/ld-2.13.so
b6f5d000 b6f62000 r-xp /usr/bin/launchpad-loader
b7af4000 b7c9d000 rw-p [heap]
bea3f000 bea60000 rw-p [stack]
bea3f000 bea60000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7057)
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
8 04:43:47.250-0500 E/EFL     ( 7537): elementary<7537> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 04:43:47.250-0500 E/EFL     ( 7537): elementary<7537> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 04:43:47.250-0500 E/EFL     ( 7537): elementary<7537> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 04:43:47.260-0500 E/EFL     ( 7537): elementary<7537> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 04:43:47.260-0500 E/EFL     ( 7537): elementary<7537> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 04:43:47.260-0500 E/EFL     ( 7537): elementary<7537> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 04:43:47.260-0500 E/EFL     ( 7537): elementary<7537> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 04:43:47.260-0500 I/AUL_PAD ( 7537): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
02-18 04:43:47.840-0500 E/PKGMGR  ( 7621): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
02-18 04:43:47.980-0500 E/PKGMGR_SERVER( 7623): pkgmgr-server.c: main(2131) > package manager server start
02-18 04:43:48.060-0500 E/PKGMGR_SERVER( 7623): pkgmgr-server.c: req_cb(650) > req_id=[org.example.metronomo_-571251525], req_type=[1], pkg_type=[rpm], pkgid=[org.example.metronomo], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.metronomo_-571251525' '-r' 'org.example.metronomo'], cookie=[ZfAHNv/1ENwKcunEHM/FLGpsijk=], backend_flag=[0]
02-18 04:43:48.060-0500 E/PKGMGR  ( 7623): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.metronomo]
02-18 04:43:48.060-0500 E/PKGMGR_SERVER( 7623): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.metronomo 
02-18 04:43:48.060-0500 E/PKGMGR  ( 7621): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[76210002]
02-18 04:43:48.060-0500 E/PKGMGR_SERVER( 7624): pkgmgr-server.c: queue_job(1815) > INSTALL start, pkg path=[org.example.metronomo]
02-18 04:43:48.240-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, STARTED]
02-18 04:43:48.240-0500 W/AUL_AMD (  934): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
02-18 04:43:48.260-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
02-18 04:43:48.270-0500 W/W_HOME  ( 1163): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.metronomo is being updateded:0
02-18 04:43:48.330-0500 W/MUSIC_TRANSFER( 7527): mt-consumer.c: __mt_consumer_on_peer_agent(454) > [33m[TID:7527]   uwLocalAgentId : [54266], pPeerAgent : [(nil)], wStatusCode : [1][0m
02-18 04:43:48.340-0500 W/MUSIC_TRANSFER( 7527): mt-consumer.c: __mt_consumer_on_peer_agent(467) > [31m[TID:7527]   wStatusCode error : [1]!!![0m
02-18 04:43:48.390-0500 W/AUL_AMD (  934): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
02-18 04:43:48.460-0500 W/CERT_SVC( 7624): DUID.cpp: CheckCertifiedDevice(675) > No device id on distributor certificate
02-18 04:43:48.520-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
02-18 04:43:48.520-0500 E/PKGMGR_CERT( 7624): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
02-18 04:43:48.530-0500 E/PKGMGR_CERT( 7624): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 102
02-18 04:43:48.530-0500 E/PKGMGR_CERT( 7624): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 102
02-18 04:43:48.530-0500 E/PKGMGR_CERT( 7624): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 23 1
02-18 04:43:48.530-0500 E/PKGMGR_CERT( 7624): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 24 1
02-18 04:43:48.540-0500 E/PKGMGR_CERT( 7624): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 25 1
02-18 04:43:48.540-0500 E/PKGMGR_CERT( 7624): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 26 1
02-18 04:43:48.560-0500 E/PKGMGR_CERT( 7624): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
02-18 04:43:48.720-0500 I/efl-extension( 7349): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb867e530, elm_scroller, _activated_obj : 0xb867e530, activated : 0
02-18 04:43:48.740-0500 I/efl-extension( 7349): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0xb867e530, obj: 0xb867e530
02-18 04:43:48.750-0500 I/efl-extension( 7349): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
02-18 04:43:48.750-0500 I/efl-extension( 7349): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
02-18 04:43:48.750-0500 I/efl-extension( 7349): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
02-18 04:43:48.750-0500 I/efl-extension( 7349): efl_extension_rotary.c: _object_deleted_cb(601) > done
02-18 04:43:48.750-0500 I/efl-extension( 7349): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
02-18 04:43:48.750-0500 I/efl-extension( 7349): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0xb86b5e70 is freed
02-18 04:43:48.750-0500 I/efl-extension( 7349): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
02-18 04:43:48.750-0500 I/efl-extension( 7349): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xb867e530, elm_scroller, func : 0xb57542f9
02-18 04:43:48.750-0500 I/efl-extension( 7349): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
02-18 04:43:48.750-0500 I/efl-extension( 7349): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
02-18 04:43:48.750-0500 I/efl-extension( 7349): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xb86ac170, elm_image, func : 0xb57542f9
02-18 04:43:48.750-0500 I/efl-extension( 7349): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
02-18 04:43:48.750-0500 I/efl-extension( 7349): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0xb867e530 : elm_scroller] rotary callabck is deleted
02-18 04:43:48.790-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 22
02-18 04:43:48.790-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(890) > app status : 4
02-18 04:43:48.800-0500 E/APP_CORE( 7349): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
02-18 04:43:48.800-0500 I/APP_CORE( 7349): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
02-18 04:43:48.800-0500 I/APP_CORE( 7349): appcore-efl.c: __after_loop(1090) > [APP 7349] PAUSE before termination
02-18 04:43:48.810-0500 W/AUL_AMD (  934): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
02-18 04:43:48.810-0500 W/AUL_AMD (  934): amd_launch.c: __e17_status_handler(2254) > back key ungrab error
02-18 04:43:48.860-0500 W/PROCESSMGR(  668): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(639) > [PROCESSMGR] =====================> send UpdateClock
02-18 04:43:48.860-0500 W/WATCH_CORE( 1240): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
02-18 04:43:48.860-0500 I/WATCH_CORE( 1240): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
02-18 04:43:48.860-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:48.860-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:48.860-0500 I/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(752) > set force update!!
02-18 04:43:48.920-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 7537
02-18 04:43:48.920-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 7256
02-18 04:43:48.930-0500 W/W_HOME  ( 1163): event_manager.c: _ecore_x_message_cb(403) > state: 1 -> 0
02-18 04:43:48.930-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 04:43:48.930-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 04:43:48.940-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 04:43:48.940-0500 W/W_HOME  ( 1163): main.c: _ecore_x_message_cb(1233) > main_info.is_win_on_top: 1
02-18 04:43:48.940-0500 W/W_HOME  ( 1163): event_manager.c: _window_visibility_cb(448) > Window [0x2400003] is now visible(0)
02-18 04:43:48.940-0500 W/W_HOME  ( 1163): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
02-18 04:43:48.940-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 04:43:48.940-0500 W/W_HOME  ( 1163): main.c: _window_visibility_cb(1200) > Window [0x2400003] is now visible(0)
02-18 04:43:48.940-0500 I/APP_CORE( 1163): appcore-efl.c: __do_app(429) > [APP 1163] Event: RESUME State: PAUSED
02-18 04:43:48.940-0500 I/CAPI_APPFW_APPLICATION( 1163): app_main.c: app_appcore_resume(223) > app_appcore_resume
02-18 04:43:48.940-0500 W/W_HOME  ( 1163): main.c: _appcore_resume_cb(683) > appcore resume
02-18 04:43:48.940-0500 W/W_HOME  ( 1163): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
02-18 04:43:48.940-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 04:43:48.940-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 04:43:48.940-0500 W/W_HOME  ( 1163): main.c: home_resume(731) > journal_appcore_app_fully_loaded called
02-18 04:43:48.940-0500 W/W_HOME  ( 1163): main.c: home_resume(735) > clock/widget resumed
02-18 04:43:48.940-0500 W/W_HOME  ( 1163): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
02-18 04:43:48.950-0500 I/wnotib  ( 1163): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
02-18 04:43:48.950-0500 E/wnotib  ( 1163): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
02-18 04:43:48.950-0500 W/wnotib  ( 1163): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1699) > No postponed update.
02-18 04:43:48.960-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 7257
02-18 04:43:48.960-0500 W/GESTURE (  249): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
02-18 04:43:48.980-0500 W/WATCH_CORE( 1240): appcore-watch.c: __widget_resume(1012) > widget_resume
02-18 04:43:48.980-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppResume(721) > 
02-18 04:43:48.980-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:48.980-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:49.050-0500 I/UXT     ( 7349): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
02-18 04:43:49.150-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:49.150-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:49.320-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:49.320-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:49.370-0500 I/efl-extension( 7349): efl_extension.c: eext_mod_shutdown(46) > Shutdown
02-18 04:43:49.490-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:49.490-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:49.590-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 7626
02-18 04:43:49.670-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:49.670-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:49.680-0500 I/AUL_AMD (  934): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 7349
02-18 04:43:49.860-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:49.860-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:49.950-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:43:49.950-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:43:49.950-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:43:49.950-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 04:43:49.950-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 04:43:49.950-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:43:49.950-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 04:43:49.950-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:43:49.950-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:43:49.950-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:43:49.950-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:43:49.950-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 04:43:49.950-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 04:43:49.950-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:43:49.950-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
02-18 04:43:49.950-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 04:43:49.950-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 04:43:49.950-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:43:49.950-0500 E/CAPI_APPFW_APP_CONTROL( 1307): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
02-18 04:43:49.950-0500 W/MUSIC_CONTROL_SERVICE( 1307): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1307]   [com.samsung.w-home]register msg port [true][0m
02-18 04:43:49.950-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 14
02-18 04:43:49.960-0500 W/AUL_AMD (  934): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1163
02-18 04:43:49.960-0500 W/MUSIC_CONTROL_SERVICE( 1307): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1307]   [MUSIC_PLAYER_EVENT][0m
02-18 04:43:49.960-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1307): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
02-18 04:43:49.960-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1307): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
02-18 04:43:49.960-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1307): preference.c: preference_get_int(1132) > preference_get_int(1307) : key(music-control-service_native/playing_diration) error
02-18 04:43:49.960-0500 W/MUSIC_CONTROL_SERVICE( 1307): music-control-info.c: music_control_info_get_player_position(582) > [31m[TID:1307]   preference_get_int() .. [0xfef00030][0m
02-18 04:43:49.960-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:43:49.960-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:43:49.960-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:43:49.960-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 04:43:49.960-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 04:43:49.960-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:43:49.960-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-18 04:43:49.960-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:43:49.960-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:43:49.960-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:43:49.960-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:43:49.960-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 04:43:49.960-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 04:43:49.960-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:43:49.960-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-18 04:43:49.960-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 04:43:49.960-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 04:43:49.960-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:43:49.960-0500 W/W_HOME  ( 1163): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
02-18 04:43:49.960-0500 E/W_HOME  ( 1163): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
02-18 04:43:49.960-0500 W/MUSIC_CONTROL_SERVICE( 1307): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1307]   [MUSIC_PLAYER_EVENT][0m
02-18 04:43:49.970-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1307): preference.c: _preference_check_retry_err(507) > key(music-control-service_native/playing_diration), check retry err: -21/(2/No such file or directory).
02-18 04:43:49.970-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1307): preference.c: _preference_get_key(1101) > _preference_get_key(music-control-service_native/playing_diration) step(-17825744) failed(2 / No such file or directory)
02-18 04:43:49.970-0500 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1307): preference.c: preference_get_int(1132) > preference_get_int(1307) : key(music-control-service_native/playing_diration) error
02-18 04:43:49.970-0500 W/MUSIC_CONTROL_SERVICE( 1307): music-control-info.c: music_control_info_get_player_position(582) > [31m[TID:1307]   preference_get_int() .. [0xfef00030][0m
02-18 04:43:49.970-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:43:49.970-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:43:49.970-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:43:49.970-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 04:43:49.970-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 04:43:49.970-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:43:49.970-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-18 04:43:49.970-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:43:49.970-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:43:49.970-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:43:49.970-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:43:49.970-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 04:43:49.970-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 04:43:49.970-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:43:49.970-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-18 04:43:49.970-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 04:43:49.970-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 04:43:49.970-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:43:49.970-0500 W/W_HOME  ( 1163): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
02-18 04:43:49.970-0500 E/W_HOME  ( 1163): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
02-18 04:43:49.980-0500 I/TIZEN_N_SOUND_MANAGER( 1307): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
02-18 04:43:49.980-0500 W/TIZEN_N_SOUND_MANAGER( 1307): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
02-18 04:43:49.980-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:43:49.980-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:43:49.980-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:43:49.980-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
02-18 04:43:49.980-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
02-18 04:43:49.980-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:43:49.980-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
02-18 04:43:49.980-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:43:49.980-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
02-18 04:43:49.980-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
02-18 04:43:49.980-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
02-18 04:43:49.980-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
02-18 04:43:49.980-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
02-18 04:43:49.980-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
02-18 04:43:49.980-0500 I/MESSAGE_PORT(  881): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
02-18 04:43:49.980-0500 I/MESSAGE_PORT(  881): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
02-18 04:43:49.980-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
02-18 04:43:49.980-0500 I/MESSAGE_PORT(  881): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
02-18 04:43:50.050-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:50.050-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:50.220-0500 I/efl-extension( 7625): efl_extension.c: eext_mod_init(40) > Init
02-18 04:43:50.240-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:50.240-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:50.290-0500 E/PKGMGR_SERVER( 7623): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
02-18 04:43:50.290-0500 E/EFL     ( 7625): elementary<7625> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 04:43:50.290-0500 E/EFL     ( 7625): elementary<7625> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 04:43:50.430-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:50.430-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:50.500-0500 W/MUSIC_TRANSFER( 7527): mt-consumer.c: __mt_consumer_on_peer_agent(454) > [33m[TID:7527]   uwLocalAgentId : [54266], pPeerAgent : [(nil)], wStatusCode : [1][0m
02-18 04:43:50.500-0500 W/MUSIC_TRANSFER( 7527): mt-consumer.c: __mt_consumer_on_peer_agent(467) > [31m[TID:7527]   wStatusCode error : [1]!!![0m
02-18 04:43:50.550-0500 E/EFL     ( 7625): elementary<7625> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 04:43:50.550-0500 I/UXT     ( 7625): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
02-18 04:43:50.550-0500 E/EFL     ( 7625): elementary<7625> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 04:43:50.600-0500 E/EFL     ( 7625): elementary<7625> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 04:43:50.600-0500 E/EFL     ( 7625): elementary<7625> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 04:43:50.620-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:50.620-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:50.680-0500 E/EFL     ( 7625): elementary<7625> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 04:43:50.680-0500 E/EFL     ( 7625): elementary<7625> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 04:43:50.680-0500 E/EFL     ( 7625): elementary<7625> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 04:43:50.710-0500 E/EFL     ( 7625): elementary<7625> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 04:43:50.710-0500 E/EFL     ( 7625): elementary<7625> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 04:43:50.710-0500 E/EFL     ( 7625): elementary<7625> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 04:43:50.770-0500 E/EFL     ( 7625): elementary<7625> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 04:43:50.780-0500 E/EFL     ( 7625): elementary<7625> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 04:43:50.780-0500 E/EFL     ( 7625): elementary<7625> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 04:43:50.780-0500 E/EFL     ( 7625): elementary<7625> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 04:43:50.780-0500 E/EFL     ( 7625): elementary<7625> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 04:43:50.780-0500 E/EFL     ( 7625): elementary<7625> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 04:43:50.780-0500 E/EFL     ( 7625): elementary<7625> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 04:43:50.780-0500 I/AUL_PAD ( 7625): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
02-18 04:43:50.790-0500 W/AUL_AMD (  934): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
02-18 04:43:50.820-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:50.820-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:50.930-0500 I/Adreno-EGL( 7625): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
02-18 04:43:50.930-0500 I/Adreno-EGL( 7625): OpenGL ES Shader Compiler Version: E031.24.00.16
02-18 04:43:50.930-0500 I/Adreno-EGL( 7625): Build Date: 09/02/15 Wed
02-18 04:43:50.930-0500 I/Adreno-EGL( 7625): Local Branch: 
02-18 04:43:50.930-0500 I/Adreno-EGL( 7625): Remote Branch: 
02-18 04:43:50.930-0500 I/Adreno-EGL( 7625): Local Patches: 
02-18 04:43:50.930-0500 I/Adreno-EGL( 7625): Reconstruct Branch: 
02-18 04:43:51.010-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:51.010-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:51.090-0500 E/rpm-installer( 7624): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
02-18 04:43:51.100-0500 I/APP_CORE( 1125): appcore-efl.c: __do_app(429) > [APP 1125] Event: MEM_FLUSH State: PAUSED
02-18 04:43:51.210-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:51.210-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:51.410-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:51.410-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:51.550-0500 W/MM_CAMCORDER( 7627): mm_camcorder_internal.c: _mmcamcorder_constructor(204) >  start
02-18 04:43:51.550-0500 W/MM_CAMCORDER( 7627): mm_camcorder_internal.c: _mmcamcorder_constructor(214) >  done
02-18 04:43:51.550-0500 I/efl-extension( 7627): efl_extension.c: eext_mod_init(40) > Init
02-18 04:43:51.610-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:51.610-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:51.800-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:51.800-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:52.000-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:52.000-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:52.200-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:52.200-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:52.290-0500 E/PKGMGR_SERVER( 7623): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
02-18 04:43:52.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:52.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:52.600-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:52.600-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:52.800-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:52.800-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:52.880-0500 I/AUL     ( 7627): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 04:43:52.910-0500 I/AUL     ( 7627): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 04:43:52.910-0500 E/AUL     ( 7627): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-18 04:43:52.910-0500 E/AUL     ( 7627): aul_path.c: __get_path(169) > root_path is NULL!
02-18 04:43:52.930-0500 I/AUL     ( 7627): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 04:43:52.950-0500 I/AUL     ( 7627): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
02-18 04:43:52.950-0500 E/AUL     ( 7627): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
02-18 04:43:52.950-0500 E/AUL     ( 7627): aul_path.c: __get_path(169) > root_path is NULL!
02-18 04:43:52.950-0500 E/EFL     ( 7627): elementary<7627> elm_main.c:558 elm_quicklaunch_init() eet_init done.
02-18 04:43:52.950-0500 E/EFL     ( 7627): elementary<7627> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
02-18 04:43:52.980-0500 E/EFL     ( 7627): elementary<7627> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
02-18 04:43:52.980-0500 I/UXT     ( 7627): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
02-18 04:43:52.980-0500 E/EFL     ( 7627): elementary<7627> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
02-18 04:43:53.000-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:53.000-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:53.040-0500 E/EFL     ( 7627): elementary<7627> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
02-18 04:43:53.040-0500 E/EFL     ( 7627): elementary<7627> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
02-18 04:43:53.040-0500 E/EFL     ( 7627): elementary<7627> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
02-18 04:43:53.040-0500 E/EFL     ( 7627): elementary<7627> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
02-18 04:43:53.040-0500 E/EFL     ( 7627): elementary<7627> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
02-18 04:43:53.070-0500 E/EFL     ( 7627): elementary<7627> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
02-18 04:43:53.070-0500 E/EFL     ( 7627): elementary<7627> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
02-18 04:43:53.070-0500 E/EFL     ( 7627): elementary<7627> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
02-18 04:43:53.110-0500 E/EFL     ( 7627): elementary<7627> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
02-18 04:43:53.140-0500 E/EFL     ( 7627): elementary<7627> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
02-18 04:43:53.140-0500 E/EFL     ( 7627): elementary<7627> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
02-18 04:43:53.140-0500 E/EFL     ( 7627): elementary<7627> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
02-18 04:43:53.140-0500 E/EFL     ( 7627): elementary<7627> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
02-18 04:43:53.140-0500 E/EFL     ( 7627): elementary<7627> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
02-18 04:43:53.140-0500 E/EFL     ( 7627): elementary<7627> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
02-18 04:43:53.200-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:53.200-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:53.200-0500 I/Adreno-EGL( 7627): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
02-18 04:43:53.200-0500 I/Adreno-EGL( 7627): OpenGL ES Shader Compiler Version: E031.24.00.16
02-18 04:43:53.200-0500 I/Adreno-EGL( 7627): Build Date: 09/02/15 Wed
02-18 04:43:53.200-0500 I/Adreno-EGL( 7627): Local Branch: 
02-18 04:43:53.200-0500 I/Adreno-EGL( 7627): Remote Branch: 
02-18 04:43:53.200-0500 I/Adreno-EGL( 7627): Local Patches: 
02-18 04:43:53.200-0500 I/Adreno-EGL( 7627): Reconstruct Branch: 
02-18 04:43:53.280-0500 W/Adreno-ES20( 7627): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:43:53.280-0500 W/Adreno-ES20( 7627): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:43:53.280-0500 W/Adreno-ES20( 7627): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:43:53.280-0500 W/Adreno-ES20( 7627): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:43:53.280-0500 W/Adreno-ES20( 7627): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:43:53.280-0500 W/Adreno-ES20( 7627): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:43:53.280-0500 W/Adreno-ES20( 7627): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:43:53.280-0500 W/Adreno-ES20( 7627): <core_glGetIntegeri_v:2183>: GL_INVALID_ENUM
02-18 04:43:53.280-0500 W/Adreno-ES20( 7627): <get_simple_queries:1550>: GL_INVALID_ENUM
02-18 04:43:53.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:53.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:53.600-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:53.600-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:53.800-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:53.800-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:54.000-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:54.000-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:54.200-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:54.200-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:54.290-0500 E/PKGMGR_SERVER( 7623): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
02-18 04:43:54.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:54.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:54.530-0500 W/MUSIC_TRANSFER( 7527): mt-consumer.c: __mt_consumer_on_peer_agent(454) > [33m[TID:7527]   uwLocalAgentId : [54266], pPeerAgent : [(nil)], wStatusCode : [1][0m
02-18 04:43:54.530-0500 W/MUSIC_TRANSFER( 7527): mt-consumer.c: __mt_consumer_on_peer_agent(467) > [31m[TID:7527]   wStatusCode error : [1]!!![0m
02-18 04:43:54.600-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:54.600-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:54.800-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:54.800-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:54.900-0500 E/PKGMGR_SERVER( 7623): pkgmgr-server.c: sighandler(409) > child NORMAL exit [7624]
02-18 04:43:54.910-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
02-18 04:43:54.920-0500 W/W_HOME  ( 1163): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.example.metronomo is updated, need to check validation
02-18 04:43:54.920-0500 W/W_HOME  ( 1163): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:com.samsung.watchface
02-18 04:43:54.950-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, COMPLETED]
02-18 04:43:54.950-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6946) > package install complete
02-18 04:43:54.950-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_package_install_event(4818) > 
02-18 04:43:54.950-0500 E/WMS     (  899): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1758) > Found in install_req_list?[0], index[-1]
02-18 04:43:54.980-0500 W/APPS    ( 1163): pkgmgr.c: _update_app(739) >  old order:[25]
02-18 04:43:55.000-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:55.000-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:55.020-0500 E/STARTER ( 1109): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
02-18 04:43:55.050-0500 E/PKGMGR_INFO(  898): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
02-18 04:43:55.100-0500 E/EFL     ( 1163): elementary<1163> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0xb78abaf0 into part 'elm.swallow.event.0'
02-18 04:43:55.100-0500 E/APPS    ( 1163): AppsViewNecklace.cpp: onShow(597) >  AppsItemList[27]
02-18 04:43:55.170-0500 E/Vi::Animations( 1163): result Vi::Animations::_AnimationManager::addAnimation(Vi::Animations::Visual&, const string*, Vi::Animations::Animation&)(288) > [E_OBJ_ALREADY_EXIST] Animation with keyName already exists. key name = hide
02-18 04:43:55.170-0500 I/Vi::Animations( 1163): result Vi::Animations::_VisualImpl::addAnimation(const string*, Vi::Animations::Animation&)(6999) > [E_OBJ_ALREADY_EXIST] Propagating.
02-18 04:43:55.180-0500 E/EFL     ( 1163): elementary<1163> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0xb78abaf0 into part 'elm.swallow.event.0'
02-18 04:43:55.200-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:55.200-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:55.220-0500 E/APPS    ( 1163): AppsViewNecklace.cpp: onShow(597) >  AppsItemList[28]
02-18 04:43:55.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:55.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:55.600-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:55.600-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:55.720-0500 W/APPS    ( 1163): pkgmgr.c: _update_app_cb(718) >  Update apps order
02-18 04:43:55.720-0500 W/APPS    ( 1163): AppsViewNecklace.cpp: onTouchEventCancel(4360) >  touch cancel
02-18 04:43:55.800-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:55.800-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:56.000-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:56.000-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:56.110-0500 I/RESOURCED(  935): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
02-18 04:43:56.110-0500 I/RESOURCED(  935): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
02-18 04:43:56.200-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:56.200-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:56.290-0500 E/PKGMGR_SERVER( 7623): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
02-18 04:43:56.290-0500 E/PKGMGR_SERVER( 7623): pkgmgr-server.c: main(2185) > package manager server terminated.
02-18 04:43:56.400-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:56.400-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:56.470-0500 W/AUL_AMD (  934): amd_request.c: __request_handler(646) > __request_handler: 0
02-18 04:43:56.480-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
02-18 04:43:56.490-0500 I/AUL_AMD (  934): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
02-18 04:43:56.490-0500 E/AUL_AMD (  934): amd_launch.c: _start_app(1698) > no caller appid info, ret: -1
02-18 04:43:56.490-0500 W/AUL_AMD (  934): amd_launch.c: _start_app(1708) > caller pid : 7689
02-18 04:43:56.500-0500 W/AUL_AMD (  934): amd_launch.c: __nofork_processing(1151) > __nofork_processing, cmd: 0, pid: 7057
02-18 04:43:56.510-0500 W/AUL_AMD (  934): amd_launch.c: __reply_handler(922) > listen fd(20) , send fd(15), pid(7057), cmd(0)
02-18 04:43:56.510-0500 I/APP_CORE( 7057): appcore-efl.c: __do_app(429) > [APP 7057] Event: RESET State: PAUSED
02-18 04:43:56.510-0500 I/CAPI_APPFW_APPLICATION( 7057): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
02-18 04:43:56.610-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:56.610-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:56.810-0500 I/CAPI_WATCH_APPLICATION( 1240): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
02-18 04:43:56.810-0500 E/watchface-loader( 1240): watchface-loader.cpp: OnAppTimeTick(740) > 
02-18 04:43:56.820-0500 W/CRASH_MANAGER( 7690): worker.c: worker_job(1199) > 11070576d6574148741103
