mkdir -p bin
#UNAME=$(uname -a | grep Darwin | grep x86_64)
#if [ ! -z "$UNAME" ]
#then
#    echo Using gcc-4.0 on Darwin x86_64!
#    export MONO_CC=gcc-4.0
#else
#    export MONO_CC=gcc
#fi
#$MONO_CC -dynamiclib -o bin/libmonojavabridge.so -I /Developer/SDKs/MacOSX10.5.sdk/System/Library/Frameworks/JavaVM.framework/Versions/1.5.0/Headers/ -I../../hostbuild/mono/ -I../../hostbuild/mono/eglib/src/ -liconv MonoJavaInterop/MonoJavaInterop.c ../../hostbuild/install/lib/libmono.0.dylib

xbuild

if [ ! -z "$ANDROID_NDK" ]
then
    cd $ANDROID_NDK
    make -j8 APP=androidmono
else
    echo Please export the ANDROID_NDK environment variable to point to the root of your NDK directory.
fi
