namespace java.nio
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class InvalidMarkException : java.lang.IllegalStateException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected InvalidMarkException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _InvalidMarkException22279;
		public InvalidMarkException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.InvalidMarkException.staticClass, global::java.nio.InvalidMarkException._InvalidMarkException22279);
			Init(@__env, handle);
		}
		static InvalidMarkException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.InvalidMarkException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/InvalidMarkException"));
			global::java.nio.InvalidMarkException._InvalidMarkException22279 = @__env.GetMethodIDNoThrow(global::java.nio.InvalidMarkException.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}