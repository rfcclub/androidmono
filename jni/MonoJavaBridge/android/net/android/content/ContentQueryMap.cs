namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ContentQueryMap : java.util.Observable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ContentQueryMap() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.ContentQueryMap), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.ContentQueryMap(@__env); 
			} 
		} 
		protected ContentQueryMap(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close1030; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentQueryMap)) 
				@__env.CallVoidMethod(this, _close1030); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentQueryMap.staticClass, _close1030); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requery1031; 
		public virtual void requery() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentQueryMap)) 
				@__env.CallVoidMethod(this, _requery1031); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentQueryMap.staticClass, _requery1031); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setKeepUpdated1032; 
		public virtual void setKeepUpdated(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentQueryMap)) 
				@__env.CallVoidMethod(this, _setKeepUpdated1032, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.ContentQueryMap.staticClass, _setKeepUpdated1032, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getValues1033; 
		public virtual android.content.ContentValues getValues(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentQueryMap)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentValues>(@__env, @__env.CallObjectMethodPtr(this, _getValues1033, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.ContentValues>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentQueryMap.staticClass, _getValues1033, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRows1034; 
		public virtual java.util.Map getRows() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.ContentQueryMap)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, _getRows1034)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.ContentQueryMap.staticClass, _getRows1034)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ContentQueryMap1035; 
		public ContentQueryMap(android.database.Cursor arg0, java.lang.String arg1, bool arg2, android.os.Handler arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.ContentQueryMap.staticClass, _ContentQueryMap1035, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.ContentQueryMap.staticClass = @__class; 
			global::android.content.ContentQueryMap._close1030 = @__env.GetMethodID(global::android.content.ContentQueryMap.staticClass, "close", "()V"); 
			global::android.content.ContentQueryMap._requery1031 = @__env.GetMethodID(global::android.content.ContentQueryMap.staticClass, "requery", "()V"); 
			global::android.content.ContentQueryMap._setKeepUpdated1032 = @__env.GetMethodID(global::android.content.ContentQueryMap.staticClass, "setKeepUpdated", "(Z)V"); 
			global::android.content.ContentQueryMap._getValues1033 = @__env.GetMethodID(global::android.content.ContentQueryMap.staticClass, "getValues", "(Ljava/lang/String;)Landroid/content/ContentValues;"); 
			global::android.content.ContentQueryMap._getRows1034 = @__env.GetMethodID(global::android.content.ContentQueryMap.staticClass, "getRows", "()Ljava/util/Map;"); 
			global::android.content.ContentQueryMap._ContentQueryMap1035 = @__env.GetMethodID(global::android.content.ContentQueryMap.staticClass, "<init>", "(Landroid/database/Cursor;Ljava/lang/String;ZLandroid/os/Handler;)V"); 
		} 
	} 
} 