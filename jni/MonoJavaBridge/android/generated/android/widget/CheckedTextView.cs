namespace android.widget
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class CheckedTextView : android.widget.TextView, Checkable
	{
		internal new static global::java.lang.Class staticClass;
		static CheckedTextView()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.widget.CheckedTextView), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.widget.CheckedTextView(@__env);
			}
		}
		protected CheckedTextView(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toggle9989;
		public virtual void toggle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.CheckedTextView._toggle9989);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._toggle9989);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isChecked9990;
		public virtual bool isChecked() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.CheckedTextView._isChecked9990);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._isChecked9990);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setChecked9991;
		public virtual void setChecked(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.CheckedTextView._setChecked9991, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._setChecked9991, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dispatchPopulateAccessibilityEvent9992;
		public override bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.widget.CheckedTextView._dispatchPopulateAccessibilityEvent9992, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._dispatchPopulateAccessibilityEvent9992, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDraw9993;
		protected override void onDraw(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.CheckedTextView._onDraw9993, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._onDraw9993, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _drawableStateChanged9994;
		protected override void drawableStateChanged() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.CheckedTextView._drawableStateChanged9994);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._drawableStateChanged9994);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onCreateDrawableState9995;
		protected override int[] onCreateDrawableState(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.widget.CheckedTextView._onCreateDrawableState9995, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._onCreateDrawableState9995, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPadding9996;
		public override void setPadding(int arg0, int arg1, int arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.CheckedTextView._setPadding9996, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._setPadding9996, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCheckMarkDrawable9997;
		public virtual void setCheckMarkDrawable(android.graphics.drawable.Drawable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.CheckedTextView._setCheckMarkDrawable9997, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._setCheckMarkDrawable9997, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCheckMarkDrawable9998;
		public virtual void setCheckMarkDrawable(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.widget.CheckedTextView._setCheckMarkDrawable9998, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._setCheckMarkDrawable9998, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CheckedTextView9999;
		public CheckedTextView(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._CheckedTextView9999, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CheckedTextView10000;
		public CheckedTextView(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._CheckedTextView10000, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _CheckedTextView10001;
		public CheckedTextView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.widget.CheckedTextView.staticClass, global::android.widget.CheckedTextView._CheckedTextView10001, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.widget.CheckedTextView.staticClass = @__class;
			global::android.widget.CheckedTextView._toggle9989 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "toggle", "()V");
			global::android.widget.CheckedTextView._isChecked9990 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "isChecked", "()Z");
			global::android.widget.CheckedTextView._setChecked9991 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "setChecked", "(Z)V");
			global::android.widget.CheckedTextView._dispatchPopulateAccessibilityEvent9992 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
			global::android.widget.CheckedTextView._onDraw9993 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "onDraw", "(Landroid/graphics/Canvas;)V");
			global::android.widget.CheckedTextView._drawableStateChanged9994 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "drawableStateChanged", "()V");
			global::android.widget.CheckedTextView._onCreateDrawableState9995 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "onCreateDrawableState", "(I)[I");
			global::android.widget.CheckedTextView._setPadding9996 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "setPadding", "(IIII)V");
			global::android.widget.CheckedTextView._setCheckMarkDrawable9997 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "setCheckMarkDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			global::android.widget.CheckedTextView._setCheckMarkDrawable9998 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "setCheckMarkDrawable", "(I)V");
			global::android.widget.CheckedTextView._CheckedTextView9999 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.CheckedTextView._CheckedTextView10000 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::android.widget.CheckedTextView._CheckedTextView10001 = @__env.GetMethodID(global::android.widget.CheckedTextView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
		}
	}
}