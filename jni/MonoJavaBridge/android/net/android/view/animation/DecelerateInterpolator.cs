namespace android.view.animation 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DecelerateInterpolator : java.lang.Object, Interpolator
	{ 
		internal static global::java.lang.Class staticClass; 
		static DecelerateInterpolator() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.animation.DecelerateInterpolator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.animation.DecelerateInterpolator(@__env); 
			} 
		} 
		protected DecelerateInterpolator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInterpolation8298; 
		public virtual float getInterpolation(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.DecelerateInterpolator)) 
				return @__env.CallFloatMethod(this, _getInterpolation8298, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.animation.DecelerateInterpolator.staticClass, _getInterpolation8298, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DecelerateInterpolator8299; 
		public DecelerateInterpolator()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.DecelerateInterpolator.staticClass, _DecelerateInterpolator8299, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DecelerateInterpolator8300; 
		public DecelerateInterpolator(float arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.DecelerateInterpolator.staticClass, _DecelerateInterpolator8300, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DecelerateInterpolator8301; 
		public DecelerateInterpolator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.DecelerateInterpolator.staticClass, _DecelerateInterpolator8301, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.animation.DecelerateInterpolator.staticClass = @__class; 
			global::android.view.animation.DecelerateInterpolator._getInterpolation8298 = @__env.GetMethodID(global::android.view.animation.DecelerateInterpolator.staticClass, "getInterpolation", "(F)F"); 
			global::android.view.animation.DecelerateInterpolator._DecelerateInterpolator8299 = @__env.GetMethodID(global::android.view.animation.DecelerateInterpolator.staticClass, "<init>", "()V"); 
			global::android.view.animation.DecelerateInterpolator._DecelerateInterpolator8300 = @__env.GetMethodID(global::android.view.animation.DecelerateInterpolator.staticClass, "<init>", "(F)V"); 
			global::android.view.animation.DecelerateInterpolator._DecelerateInterpolator8301 = @__env.GetMethodID(global::android.view.animation.DecelerateInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 