namespace android.location
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class GpsStatus : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GpsStatus()
		{
			InitJNI();
		}
		internal GpsStatus(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.location.GpsStatus.Listener_))]
		public interface Listener  : global::MonoJavaBridge.IJavaObject 
		{
			void onGpsStatusChanged(int arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.location.GpsStatus.Listener))]
		public sealed partial class Listener_ : java.lang.Object, Listener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Listener_()
			{
				InitJNI();
			}
			internal Listener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onGpsStatusChanged4723;
			 void android.location.GpsStatus.Listener.onGpsStatusChanged(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.location.GpsStatus.Listener_._onGpsStatusChanged4723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.GpsStatus.Listener_.staticClass, global::android.location.GpsStatus.Listener_._onGpsStatusChanged4723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.location.GpsStatus.Listener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/GpsStatus$Listener"));
				global::android.location.GpsStatus.Listener_._onGpsStatusChanged4723 = @__env.GetMethodIDNoThrow(global::android.location.GpsStatus.Listener_.staticClass, "onGpsStatusChanged", "(I)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.location.GpsStatus.NmeaListener_))]
		public interface NmeaListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onNmeaReceived(long arg0, java.lang.String arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.location.GpsStatus.NmeaListener))]
		public sealed partial class NmeaListener_ : java.lang.Object, NmeaListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static NmeaListener_()
			{
				InitJNI();
			}
			internal NmeaListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onNmeaReceived4724;
			 void android.location.GpsStatus.NmeaListener.onNmeaReceived(long arg0, java.lang.String arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.location.GpsStatus.NmeaListener_._onNmeaReceived4724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.location.GpsStatus.NmeaListener_.staticClass, global::android.location.GpsStatus.NmeaListener_._onNmeaReceived4724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.location.GpsStatus.NmeaListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/GpsStatus$NmeaListener"));
				global::android.location.GpsStatus.NmeaListener_._onNmeaReceived4724 = @__env.GetMethodIDNoThrow(global::android.location.GpsStatus.NmeaListener_.staticClass, "onNmeaReceived", "(JLjava/lang/String;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTimeToFirstFix4725;
		public int getTimeToFirstFix() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.GpsStatus._getTimeToFirstFix4725);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.GpsStatus.staticClass, global::android.location.GpsStatus._getTimeToFirstFix4725);
		}
		internal static global::MonoJavaBridge.MethodId _getSatellites4726;
		public global::java.lang.Iterable getSatellites() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Iterable>(@__env.CallObjectMethod(this.JvmHandle, global::android.location.GpsStatus._getSatellites4726)) as java.lang.Iterable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.Iterable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.location.GpsStatus.staticClass, global::android.location.GpsStatus._getSatellites4726)) as java.lang.Iterable;
		}
		internal static global::MonoJavaBridge.MethodId _getMaxSatellites4727;
		public int getMaxSatellites() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.location.GpsStatus._getMaxSatellites4727);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.location.GpsStatus.staticClass, global::android.location.GpsStatus._getMaxSatellites4727);
		}
		public static int GPS_EVENT_STARTED
		{
			get
			{
				return 1;
			}
		}
		public static int GPS_EVENT_STOPPED
		{
			get
			{
				return 2;
			}
		}
		public static int GPS_EVENT_FIRST_FIX
		{
			get
			{
				return 3;
			}
		}
		public static int GPS_EVENT_SATELLITE_STATUS
		{
			get
			{
				return 4;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.location.GpsStatus.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/location/GpsStatus"));
			global::android.location.GpsStatus._getTimeToFirstFix4725 = @__env.GetMethodIDNoThrow(global::android.location.GpsStatus.staticClass, "getTimeToFirstFix", "()I");
			global::android.location.GpsStatus._getSatellites4726 = @__env.GetMethodIDNoThrow(global::android.location.GpsStatus.staticClass, "getSatellites", "()Ljava/lang/Iterable;");
			global::android.location.GpsStatus._getMaxSatellites4727 = @__env.GetMethodIDNoThrow(global::android.location.GpsStatus.staticClass, "getMaxSatellites", "()I");
		}
	}
}
