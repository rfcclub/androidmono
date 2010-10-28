namespace org.apache.http.impl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultHttpServerConnection : org.apache.http.impl.SocketHttpServerConnection
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DefaultHttpServerConnection(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString32647;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.DefaultHttpServerConnection._toString32647)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.impl.DefaultHttpServerConnection.staticClass, global::org.apache.http.impl.DefaultHttpServerConnection._toString32647)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _bind32648;
		public virtual void bind(java.net.Socket arg0, org.apache.http.@params.HttpParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.DefaultHttpServerConnection._bind32648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.impl.DefaultHttpServerConnection.staticClass, global::org.apache.http.impl.DefaultHttpServerConnection._bind32648, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _DefaultHttpServerConnection32649;
		public DefaultHttpServerConnection() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.DefaultHttpServerConnection.staticClass, global::org.apache.http.impl.DefaultHttpServerConnection._DefaultHttpServerConnection32649);
			Init(@__env, handle);
		}
		static DefaultHttpServerConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.DefaultHttpServerConnection.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/DefaultHttpServerConnection"));
			global::org.apache.http.impl.DefaultHttpServerConnection._toString32647 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultHttpServerConnection.staticClass, "toString", "()Ljava/lang/String;");
			global::org.apache.http.impl.DefaultHttpServerConnection._bind32648 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultHttpServerConnection.staticClass, "bind", "(Ljava/net/Socket;Lorg/apache/http/params/HttpParams;)V");
			global::org.apache.http.impl.DefaultHttpServerConnection._DefaultHttpServerConnection32649 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.DefaultHttpServerConnection.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}