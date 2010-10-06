namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ViewDebug : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static ViewDebug()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewDebug), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.view.ViewDebug(@__env);
			}
		}
		protected ViewDebug(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface CapturedViewProperty : java.lang.annotation.Annotation
		{
			bool retrieveReturn();
		}

		public partial class CapturedViewProperty_
		{
			public static global::java.lang.Class _class
			{
				get { return __CapturedViewProperty.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __CapturedViewProperty : java.lang.Object, CapturedViewProperty
		{
			internal static global::java.lang.Class staticClass;
			static __CapturedViewProperty()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewDebug.__CapturedViewProperty), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ViewDebug.__CapturedViewProperty(@__env);
				}
			}
			internal __CapturedViewProperty(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _retrieveReturn8417;
			 bool android.view.ViewDebug.CapturedViewProperty.retrieveReturn() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.ViewDebug.__CapturedViewProperty._retrieveReturn8417);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewDebug.__CapturedViewProperty.staticClass, global::android.view.ViewDebug.__CapturedViewProperty._retrieveReturn8417);
			}
			internal static global::net.sf.jni4net.jni.MethodId _equals8418;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.ViewDebug.__CapturedViewProperty._equals8418, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewDebug.__CapturedViewProperty.staticClass, global::android.view.ViewDebug.__CapturedViewProperty._equals8418, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _toString8419;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__CapturedViewProperty._toString8419));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__CapturedViewProperty.staticClass, global::android.view.ViewDebug.__CapturedViewProperty._toString8419));
			}
			internal static global::net.sf.jni4net.jni.MethodId _hashCode8420;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.view.ViewDebug.__CapturedViewProperty._hashCode8420);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewDebug.__CapturedViewProperty.staticClass, global::android.view.ViewDebug.__CapturedViewProperty._hashCode8420);
			}
			internal static global::net.sf.jni4net.jni.MethodId _annotationType8421;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__CapturedViewProperty._annotationType8421));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__CapturedViewProperty.staticClass, global::android.view.ViewDebug.__CapturedViewProperty._annotationType8421));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ViewDebug.__CapturedViewProperty.staticClass = @__class;
				global::android.view.ViewDebug.__CapturedViewProperty._retrieveReturn8417 = @__env.GetMethodID(global::android.view.ViewDebug.__CapturedViewProperty.staticClass, "android.view.ViewDebug.CapturedViewProperty.retrieveReturn", "()Z");
				global::android.view.ViewDebug.__CapturedViewProperty._equals8418 = @__env.GetMethodID(global::android.view.ViewDebug.__CapturedViewProperty.staticClass, "java.lang.annotation.Annotation.equals", "(Ljava/lang/Object;)Z");
				global::android.view.ViewDebug.__CapturedViewProperty._toString8419 = @__env.GetMethodID(global::android.view.ViewDebug.__CapturedViewProperty.staticClass, "java.lang.annotation.Annotation.toString", "()Ljava/lang/String;");
				global::android.view.ViewDebug.__CapturedViewProperty._hashCode8420 = @__env.GetMethodID(global::android.view.ViewDebug.__CapturedViewProperty.staticClass, "java.lang.annotation.Annotation.hashCode", "()I");
				global::android.view.ViewDebug.__CapturedViewProperty._annotationType8421 = @__env.GetMethodID(global::android.view.ViewDebug.__CapturedViewProperty.staticClass, "java.lang.annotation.Annotation.annotationType", "()Ljava/lang/Class;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface ExportedProperty : java.lang.annotation.Annotation
		{
			global::java.lang.String prefix();
			bool resolveId();
			global::android.view.ViewDebug.IntToString[] mapping();
			global::android.view.ViewDebug.IntToString[] indexMapping();
			global::android.view.ViewDebug.FlagToString[] flagMapping();
			bool deepExport();
		}

		public partial class ExportedProperty_
		{
			public static global::java.lang.Class _class
			{
				get { return __ExportedProperty.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __ExportedProperty : java.lang.Object, ExportedProperty
		{
			internal static global::java.lang.Class staticClass;
			static __ExportedProperty()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewDebug.__ExportedProperty), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ViewDebug.__ExportedProperty(@__env);
				}
			}
			internal __ExportedProperty(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _prefix8422;
			 global::java.lang.String android.view.ViewDebug.ExportedProperty.prefix() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty._prefix8422));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty.staticClass, global::android.view.ViewDebug.__ExportedProperty._prefix8422));
			}
			internal static global::net.sf.jni4net.jni.MethodId _resolveId8423;
			 bool android.view.ViewDebug.ExportedProperty.resolveId() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.ViewDebug.__ExportedProperty._resolveId8423);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewDebug.__ExportedProperty.staticClass, global::android.view.ViewDebug.__ExportedProperty._resolveId8423);
			}
			internal static global::net.sf.jni4net.jni.MethodId _mapping8424;
			 global::android.view.ViewDebug.IntToString[] android.view.ViewDebug.ExportedProperty.mapping() 
			{
				if (!IsClrObject)
					return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty._mapping8424));
				else
					return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty.staticClass, global::android.view.ViewDebug.__ExportedProperty._mapping8424));
			}
			internal static global::net.sf.jni4net.jni.MethodId _indexMapping8425;
			 global::android.view.ViewDebug.IntToString[] android.view.ViewDebug.ExportedProperty.indexMapping() 
			{
				if (!IsClrObject)
					return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty._indexMapping8425));
				else
					return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty.staticClass, global::android.view.ViewDebug.__ExportedProperty._indexMapping8425));
			}
			internal static global::net.sf.jni4net.jni.MethodId _flagMapping8426;
			 global::android.view.ViewDebug.FlagToString[] android.view.ViewDebug.ExportedProperty.flagMapping() 
			{
				if (!IsClrObject)
					return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty._flagMapping8426));
				else
					return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty.staticClass, global::android.view.ViewDebug.__ExportedProperty._flagMapping8426));
			}
			internal static global::net.sf.jni4net.jni.MethodId _deepExport8427;
			 bool android.view.ViewDebug.ExportedProperty.deepExport() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.ViewDebug.__ExportedProperty._deepExport8427);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewDebug.__ExportedProperty.staticClass, global::android.view.ViewDebug.__ExportedProperty._deepExport8427);
			}
			internal static global::net.sf.jni4net.jni.MethodId _equals8428;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.ViewDebug.__ExportedProperty._equals8428, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewDebug.__ExportedProperty.staticClass, global::android.view.ViewDebug.__ExportedProperty._equals8428, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _toString8429;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty._toString8429));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty.staticClass, global::android.view.ViewDebug.__ExportedProperty._toString8429));
			}
			internal static global::net.sf.jni4net.jni.MethodId _hashCode8430;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.view.ViewDebug.__ExportedProperty._hashCode8430);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewDebug.__ExportedProperty.staticClass, global::android.view.ViewDebug.__ExportedProperty._hashCode8430);
			}
			internal static global::net.sf.jni4net.jni.MethodId _annotationType8431;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty._annotationType8431));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__ExportedProperty.staticClass, global::android.view.ViewDebug.__ExportedProperty._annotationType8431));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ViewDebug.__ExportedProperty.staticClass = @__class;
				global::android.view.ViewDebug.__ExportedProperty._prefix8422 = @__env.GetMethodID(global::android.view.ViewDebug.__ExportedProperty.staticClass, "android.view.ViewDebug.ExportedProperty.prefix", "()Ljava/lang/String;");
				global::android.view.ViewDebug.__ExportedProperty._resolveId8423 = @__env.GetMethodID(global::android.view.ViewDebug.__ExportedProperty.staticClass, "android.view.ViewDebug.ExportedProperty.resolveId", "()Z");
				global::android.view.ViewDebug.__ExportedProperty._mapping8424 = @__env.GetMethodID(global::android.view.ViewDebug.__ExportedProperty.staticClass, "android.view.ViewDebug.ExportedProperty.mapping", "()[Landroid/view/ViewDebug/IntToString;");
				global::android.view.ViewDebug.__ExportedProperty._indexMapping8425 = @__env.GetMethodID(global::android.view.ViewDebug.__ExportedProperty.staticClass, "android.view.ViewDebug.ExportedProperty.indexMapping", "()[Landroid/view/ViewDebug/IntToString;");
				global::android.view.ViewDebug.__ExportedProperty._flagMapping8426 = @__env.GetMethodID(global::android.view.ViewDebug.__ExportedProperty.staticClass, "android.view.ViewDebug.ExportedProperty.flagMapping", "()[Landroid/view/ViewDebug/FlagToString;");
				global::android.view.ViewDebug.__ExportedProperty._deepExport8427 = @__env.GetMethodID(global::android.view.ViewDebug.__ExportedProperty.staticClass, "android.view.ViewDebug.ExportedProperty.deepExport", "()Z");
				global::android.view.ViewDebug.__ExportedProperty._equals8428 = @__env.GetMethodID(global::android.view.ViewDebug.__ExportedProperty.staticClass, "java.lang.annotation.Annotation.equals", "(Ljava/lang/Object;)Z");
				global::android.view.ViewDebug.__ExportedProperty._toString8429 = @__env.GetMethodID(global::android.view.ViewDebug.__ExportedProperty.staticClass, "java.lang.annotation.Annotation.toString", "()Ljava/lang/String;");
				global::android.view.ViewDebug.__ExportedProperty._hashCode8430 = @__env.GetMethodID(global::android.view.ViewDebug.__ExportedProperty.staticClass, "java.lang.annotation.Annotation.hashCode", "()I");
				global::android.view.ViewDebug.__ExportedProperty._annotationType8431 = @__env.GetMethodID(global::android.view.ViewDebug.__ExportedProperty.staticClass, "java.lang.annotation.Annotation.annotationType", "()Ljava/lang/Class;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface FlagToString : java.lang.annotation.Annotation
		{
			global::java.lang.String name();
			int equals();
			int mask();
			bool outputIf();
		}

		public partial class FlagToString_
		{
			public static global::java.lang.Class _class
			{
				get { return __FlagToString.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __FlagToString : java.lang.Object, FlagToString
		{
			internal static global::java.lang.Class staticClass;
			static __FlagToString()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewDebug.__FlagToString), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ViewDebug.__FlagToString(@__env);
				}
			}
			internal __FlagToString(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _name8432;
			 global::java.lang.String android.view.ViewDebug.FlagToString.name() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__FlagToString._name8432));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__FlagToString.staticClass, global::android.view.ViewDebug.__FlagToString._name8432));
			}
			internal static global::net.sf.jni4net.jni.MethodId _equals8433;
			 int android.view.ViewDebug.FlagToString.equals() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.view.ViewDebug.__FlagToString._equals8433);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewDebug.__FlagToString.staticClass, global::android.view.ViewDebug.__FlagToString._equals8433);
			}
			internal static global::net.sf.jni4net.jni.MethodId _mask8434;
			 int android.view.ViewDebug.FlagToString.mask() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.view.ViewDebug.__FlagToString._mask8434);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewDebug.__FlagToString.staticClass, global::android.view.ViewDebug.__FlagToString._mask8434);
			}
			internal static global::net.sf.jni4net.jni.MethodId _outputIf8435;
			 bool android.view.ViewDebug.FlagToString.outputIf() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.ViewDebug.__FlagToString._outputIf8435);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewDebug.__FlagToString.staticClass, global::android.view.ViewDebug.__FlagToString._outputIf8435);
			}
			internal static global::net.sf.jni4net.jni.MethodId _equals8436;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.ViewDebug.__FlagToString._equals8436, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewDebug.__FlagToString.staticClass, global::android.view.ViewDebug.__FlagToString._equals8436, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _toString8437;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__FlagToString._toString8437));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__FlagToString.staticClass, global::android.view.ViewDebug.__FlagToString._toString8437));
			}
			internal static global::net.sf.jni4net.jni.MethodId _hashCode8438;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.view.ViewDebug.__FlagToString._hashCode8438);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewDebug.__FlagToString.staticClass, global::android.view.ViewDebug.__FlagToString._hashCode8438);
			}
			internal static global::net.sf.jni4net.jni.MethodId _annotationType8439;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__FlagToString._annotationType8439));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__FlagToString.staticClass, global::android.view.ViewDebug.__FlagToString._annotationType8439));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ViewDebug.__FlagToString.staticClass = @__class;
				global::android.view.ViewDebug.__FlagToString._name8432 = @__env.GetMethodID(global::android.view.ViewDebug.__FlagToString.staticClass, "android.view.ViewDebug.FlagToString.name", "()Ljava/lang/String;");
				global::android.view.ViewDebug.__FlagToString._equals8433 = @__env.GetMethodID(global::android.view.ViewDebug.__FlagToString.staticClass, "android.view.ViewDebug.FlagToString.equals", "()I");
				global::android.view.ViewDebug.__FlagToString._mask8434 = @__env.GetMethodID(global::android.view.ViewDebug.__FlagToString.staticClass, "android.view.ViewDebug.FlagToString.mask", "()I");
				global::android.view.ViewDebug.__FlagToString._outputIf8435 = @__env.GetMethodID(global::android.view.ViewDebug.__FlagToString.staticClass, "android.view.ViewDebug.FlagToString.outputIf", "()Z");
				global::android.view.ViewDebug.__FlagToString._equals8436 = @__env.GetMethodID(global::android.view.ViewDebug.__FlagToString.staticClass, "java.lang.annotation.Annotation.equals", "(Ljava/lang/Object;)Z");
				global::android.view.ViewDebug.__FlagToString._toString8437 = @__env.GetMethodID(global::android.view.ViewDebug.__FlagToString.staticClass, "java.lang.annotation.Annotation.toString", "()Ljava/lang/String;");
				global::android.view.ViewDebug.__FlagToString._hashCode8438 = @__env.GetMethodID(global::android.view.ViewDebug.__FlagToString.staticClass, "java.lang.annotation.Annotation.hashCode", "()I");
				global::android.view.ViewDebug.__FlagToString._annotationType8439 = @__env.GetMethodID(global::android.view.ViewDebug.__FlagToString.staticClass, "java.lang.annotation.Annotation.annotationType", "()Ljava/lang/Class;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class HierarchyTraceType : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static HierarchyTraceType()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewDebug.HierarchyTraceType), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ViewDebug.HierarchyTraceType(@__env);
				}
			}
			internal HierarchyTraceType(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values8440;
			public static global::android.view.ViewDebug.HierarchyTraceType[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.view.ViewDebug.HierarchyTraceType.staticClass, global::android.view.ViewDebug.HierarchyTraceType._values8440));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf8441;
			public static global::android.view.ViewDebug.HierarchyTraceType valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewDebug.HierarchyTraceType>(@__env, @__env.CallStaticObjectMethodPtr(android.view.ViewDebug.HierarchyTraceType.staticClass, global::android.view.ViewDebug.HierarchyTraceType._valueOf8441, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _BUILD_CACHE8442;
			public static global::android.view.ViewDebug.HierarchyTraceType BUILD_CACHE
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _DRAW8443;
			public static global::android.view.ViewDebug.HierarchyTraceType DRAW
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _INVALIDATE8444;
			public static global::android.view.ViewDebug.HierarchyTraceType INVALIDATE
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _INVALIDATE_CHILD8445;
			public static global::android.view.ViewDebug.HierarchyTraceType INVALIDATE_CHILD
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _INVALIDATE_CHILD_IN_PARENT8446;
			public static global::android.view.ViewDebug.HierarchyTraceType INVALIDATE_CHILD_IN_PARENT
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _ON_LAYOUT8447;
			public static global::android.view.ViewDebug.HierarchyTraceType ON_LAYOUT
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _ON_MEASURE8448;
			public static global::android.view.ViewDebug.HierarchyTraceType ON_MEASURE
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _REQUEST_LAYOUT8449;
			public static global::android.view.ViewDebug.HierarchyTraceType REQUEST_LAYOUT
			{
				get
				{
					return default(global::android.view.ViewDebug.HierarchyTraceType);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ViewDebug.HierarchyTraceType.staticClass = @__class;
				global::android.view.ViewDebug.HierarchyTraceType._values8440 = @__env.GetStaticMethodID(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "values", "()[Landroid/view/ViewDebug/HierarchyTraceType;");
				global::android.view.ViewDebug.HierarchyTraceType._valueOf8441 = @__env.GetStaticMethodID(global::android.view.ViewDebug.HierarchyTraceType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/view/ViewDebug$HierarchyTraceType;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface IntToString : java.lang.annotation.Annotation
		{
			int from();
			global::java.lang.String to();
		}

		public partial class IntToString_
		{
			public static global::java.lang.Class _class
			{
				get { return __IntToString.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __IntToString : java.lang.Object, IntToString
		{
			internal static global::java.lang.Class staticClass;
			static __IntToString()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewDebug.__IntToString), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ViewDebug.__IntToString(@__env);
				}
			}
			internal __IntToString(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _from8450;
			 int android.view.ViewDebug.IntToString.from() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.view.ViewDebug.__IntToString._from8450);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewDebug.__IntToString.staticClass, global::android.view.ViewDebug.__IntToString._from8450);
			}
			internal static global::net.sf.jni4net.jni.MethodId _to8451;
			 global::java.lang.String android.view.ViewDebug.IntToString.to() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__IntToString._to8451));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__IntToString.staticClass, global::android.view.ViewDebug.__IntToString._to8451));
			}
			internal static global::net.sf.jni4net.jni.MethodId _equals8452;
			 bool java.lang.annotation.Annotation.equals(java.lang.Object arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.view.ViewDebug.__IntToString._equals8452, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.view.ViewDebug.__IntToString.staticClass, global::android.view.ViewDebug.__IntToString._equals8452, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _toString8453;
			 global::java.lang.String java.lang.annotation.Annotation.toString() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__IntToString._toString8453));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__IntToString.staticClass, global::android.view.ViewDebug.__IntToString._toString8453));
			}
			internal static global::net.sf.jni4net.jni.MethodId _hashCode8454;
			 int java.lang.annotation.Annotation.hashCode() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.view.ViewDebug.__IntToString._hashCode8454);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.view.ViewDebug.__IntToString.staticClass, global::android.view.ViewDebug.__IntToString._hashCode8454);
			}
			internal static global::net.sf.jni4net.jni.MethodId _annotationType8455;
			 global::java.lang.Class java.lang.annotation.Annotation.annotationType() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.ViewDebug.__IntToString._annotationType8455));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Class>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.ViewDebug.__IntToString.staticClass, global::android.view.ViewDebug.__IntToString._annotationType8455));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ViewDebug.__IntToString.staticClass = @__class;
				global::android.view.ViewDebug.__IntToString._from8450 = @__env.GetMethodID(global::android.view.ViewDebug.__IntToString.staticClass, "android.view.ViewDebug.IntToString.from", "()I");
				global::android.view.ViewDebug.__IntToString._to8451 = @__env.GetMethodID(global::android.view.ViewDebug.__IntToString.staticClass, "android.view.ViewDebug.IntToString.to", "()Ljava/lang/String;");
				global::android.view.ViewDebug.__IntToString._equals8452 = @__env.GetMethodID(global::android.view.ViewDebug.__IntToString.staticClass, "java.lang.annotation.Annotation.equals", "(Ljava/lang/Object;)Z");
				global::android.view.ViewDebug.__IntToString._toString8453 = @__env.GetMethodID(global::android.view.ViewDebug.__IntToString.staticClass, "java.lang.annotation.Annotation.toString", "()Ljava/lang/String;");
				global::android.view.ViewDebug.__IntToString._hashCode8454 = @__env.GetMethodID(global::android.view.ViewDebug.__IntToString.staticClass, "java.lang.annotation.Annotation.hashCode", "()I");
				global::android.view.ViewDebug.__IntToString._annotationType8455 = @__env.GetMethodID(global::android.view.ViewDebug.__IntToString.staticClass, "java.lang.annotation.Annotation.annotationType", "()Ljava/lang/Class;");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class RecyclerTraceType : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static RecyclerTraceType()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.ViewDebug.RecyclerTraceType), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.view.ViewDebug.RecyclerTraceType(@__env);
				}
			}
			internal RecyclerTraceType(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values8456;
			public static global::android.view.ViewDebug.RecyclerTraceType[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.view.ViewDebug.RecyclerTraceType.staticClass, global::android.view.ViewDebug.RecyclerTraceType._values8456));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf8457;
			public static global::android.view.ViewDebug.RecyclerTraceType valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.ViewDebug.RecyclerTraceType>(@__env, @__env.CallStaticObjectMethodPtr(android.view.ViewDebug.RecyclerTraceType.staticClass, global::android.view.ViewDebug.RecyclerTraceType._valueOf8457, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _BIND_VIEW8458;
			public static global::android.view.ViewDebug.RecyclerTraceType BIND_VIEW
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _MOVE_FROM_ACTIVE_TO_SCRAP_HEAP8459;
			public static global::android.view.ViewDebug.RecyclerTraceType MOVE_FROM_ACTIVE_TO_SCRAP_HEAP
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _MOVE_TO_ACTIVE_HEAP8460;
			public static global::android.view.ViewDebug.RecyclerTraceType MOVE_TO_ACTIVE_HEAP
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _MOVE_TO_SCRAP_HEAP8461;
			public static global::android.view.ViewDebug.RecyclerTraceType MOVE_TO_SCRAP_HEAP
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _NEW_VIEW8462;
			public static global::android.view.ViewDebug.RecyclerTraceType NEW_VIEW
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _RECYCLE_FROM_ACTIVE_HEAP8463;
			public static global::android.view.ViewDebug.RecyclerTraceType RECYCLE_FROM_ACTIVE_HEAP
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _RECYCLE_FROM_SCRAP_HEAP8464;
			public static global::android.view.ViewDebug.RecyclerTraceType RECYCLE_FROM_SCRAP_HEAP
			{
				get
				{
					return default(global::android.view.ViewDebug.RecyclerTraceType);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.ViewDebug.RecyclerTraceType.staticClass = @__class;
				global::android.view.ViewDebug.RecyclerTraceType._values8456 = @__env.GetStaticMethodID(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "values", "()[Landroid/view/ViewDebug/RecyclerTraceType;");
				global::android.view.ViewDebug.RecyclerTraceType._valueOf8457 = @__env.GetStaticMethodID(global::android.view.ViewDebug.RecyclerTraceType.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/view/ViewDebug$RecyclerTraceType;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _trace8465;
		public static void trace(android.view.View arg0, android.view.ViewDebug.RecyclerTraceType arg1, int[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._trace8465, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _trace8466;
		public static void trace(android.view.View arg0, android.view.ViewDebug.HierarchyTraceType arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._trace8466, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startRecyclerTracing8467;
		public static void startRecyclerTracing(java.lang.String arg0, android.view.View arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._startRecyclerTracing8467, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopRecyclerTracing8468;
		public static void stopRecyclerTracing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._stopRecyclerTracing8468);
		}
		internal static global::net.sf.jni4net.jni.MethodId _startHierarchyTracing8469;
		public static void startHierarchyTracing(java.lang.String arg0, android.view.View arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._startHierarchyTracing8469, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopHierarchyTracing8470;
		public static void stopHierarchyTracing() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._stopHierarchyTracing8470);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dumpCapturedView8471;
		public static void dumpCapturedView(java.lang.String arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._dumpCapturedView8471, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _ViewDebug8472;
		public ViewDebug()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.view.ViewDebug.staticClass, global::android.view.ViewDebug._ViewDebug8472, this);
		}
		public static bool TRACE_HIERARCHY
		{
			get
			{
				return false;
			}
		}
		public static bool TRACE_RECYCLER
		{
			get
			{
				return false;
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.ViewDebug.staticClass = @__class;
			global::android.view.ViewDebug._trace8465 = @__env.GetStaticMethodID(global::android.view.ViewDebug.staticClass, "trace", "(Landroid/view/View;Landroid/view/ViewDebug$RecyclerTraceType;[I)V");
			global::android.view.ViewDebug._trace8466 = @__env.GetStaticMethodID(global::android.view.ViewDebug.staticClass, "trace", "(Landroid/view/View;Landroid/view/ViewDebug$HierarchyTraceType;)V");
			global::android.view.ViewDebug._startRecyclerTracing8467 = @__env.GetStaticMethodID(global::android.view.ViewDebug.staticClass, "startRecyclerTracing", "(Ljava/lang/String;Landroid/view/View;)V");
			global::android.view.ViewDebug._stopRecyclerTracing8468 = @__env.GetStaticMethodID(global::android.view.ViewDebug.staticClass, "stopRecyclerTracing", "()V");
			global::android.view.ViewDebug._startHierarchyTracing8469 = @__env.GetStaticMethodID(global::android.view.ViewDebug.staticClass, "startHierarchyTracing", "(Ljava/lang/String;Landroid/view/View;)V");
			global::android.view.ViewDebug._stopHierarchyTracing8470 = @__env.GetStaticMethodID(global::android.view.ViewDebug.staticClass, "stopHierarchyTracing", "()V");
			global::android.view.ViewDebug._dumpCapturedView8471 = @__env.GetStaticMethodID(global::android.view.ViewDebug.staticClass, "dumpCapturedView", "(Ljava/lang/String;Ljava/lang/Object;)V");
			global::android.view.ViewDebug._ViewDebug8472 = @__env.GetMethodID(global::android.view.ViewDebug.staticClass, "<init>", "()V");
		}
	}
}