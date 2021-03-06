namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpAuthHandler : android.os.Handler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static HttpAuthHandler()
		{
			InitJNI();
		}
		protected HttpAuthHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _cancel10320;
		public virtual void cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.HttpAuthHandler._cancel10320);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.HttpAuthHandler.staticClass, global::android.webkit.HttpAuthHandler._cancel10320);
		}
		internal static global::MonoJavaBridge.MethodId _handleMessage10321;
		public override void handleMessage(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.HttpAuthHandler._handleMessage10321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.HttpAuthHandler.staticClass, global::android.webkit.HttpAuthHandler._handleMessage10321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _proceed10322;
		public virtual void proceed(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.webkit.HttpAuthHandler._proceed10322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.webkit.HttpAuthHandler.staticClass, global::android.webkit.HttpAuthHandler._proceed10322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _useHttpAuthUsernamePassword10323;
		public virtual bool useHttpAuthUsernamePassword() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.webkit.HttpAuthHandler._useHttpAuthUsernamePassword10323);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.webkit.HttpAuthHandler.staticClass, global::android.webkit.HttpAuthHandler._useHttpAuthUsernamePassword10323);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.HttpAuthHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/HttpAuthHandler"));
			global::android.webkit.HttpAuthHandler._cancel10320 = @__env.GetMethodIDNoThrow(global::android.webkit.HttpAuthHandler.staticClass, "cancel", "()V");
			global::android.webkit.HttpAuthHandler._handleMessage10321 = @__env.GetMethodIDNoThrow(global::android.webkit.HttpAuthHandler.staticClass, "handleMessage", "(Landroid/os/Message;)V");
			global::android.webkit.HttpAuthHandler._proceed10322 = @__env.GetMethodIDNoThrow(global::android.webkit.HttpAuthHandler.staticClass, "proceed", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.webkit.HttpAuthHandler._useHttpAuthUsernamePassword10323 = @__env.GetMethodIDNoThrow(global::android.webkit.HttpAuthHandler.staticClass, "useHttpAuthUsernamePassword", "()Z");
		}
	}
}
