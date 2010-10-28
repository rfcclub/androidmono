namespace android.content
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.content.ContentResolver_))]
	public abstract partial class ContentResolver : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ContentResolver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getType2713;
		public virtual global::java.lang.String getType(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentResolver._getType2713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._getType2713, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _delete2714;
		public virtual int delete(android.net.Uri arg0, java.lang.String arg1, java.lang.String[] arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContentResolver._delete2714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._delete2714, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _insert2715;
		public virtual global::android.net.Uri insert(android.net.Uri arg0, android.content.ContentValues arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentResolver._insert2715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._insert2715, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _query2716;
		public virtual global::android.database.Cursor query(android.net.Uri arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentResolver._query2716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._query2716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _update2717;
		public virtual int update(android.net.Uri arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContentResolver._update2717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._update2717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _openInputStream2718;
		public virtual global::java.io.InputStream openInputStream(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentResolver._openInputStream2718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._openInputStream2718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _openOutputStream2719;
		public virtual global::java.io.OutputStream openOutputStream(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentResolver._openOutputStream2719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._openOutputStream2719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _openOutputStream2720;
		public virtual global::java.io.OutputStream openOutputStream(android.net.Uri arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentResolver._openOutputStream2720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.OutputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._openOutputStream2720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.io.OutputStream;
		}
		internal static global::MonoJavaBridge.MethodId _openFileDescriptor2721;
		public virtual global::android.os.ParcelFileDescriptor openFileDescriptor(android.net.Uri arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentResolver._openFileDescriptor2721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.ParcelFileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._openFileDescriptor2721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.ParcelFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _openAssetFileDescriptor2722;
		public virtual global::android.content.res.AssetFileDescriptor openAssetFileDescriptor(android.net.Uri arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentResolver._openAssetFileDescriptor2722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.AssetFileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._openAssetFileDescriptor2722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.res.AssetFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _applyBatch2723;
		public virtual global::android.content.ContentProviderResult[] applyBatch(java.lang.String arg0, java.util.ArrayList arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.ContentProviderResult>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentResolver._applyBatch2723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderResult[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.ContentProviderResult>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._applyBatch2723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.ContentProviderResult[];
		}
		internal static global::MonoJavaBridge.MethodId _bulkInsert2724;
		public virtual int bulkInsert(android.net.Uri arg0, android.content.ContentValues[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ContentResolver._bulkInsert2724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._bulkInsert2724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _acquireContentProviderClient2725;
		public virtual global::android.content.ContentProviderClient acquireContentProviderClient(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentResolver._acquireContentProviderClient2725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderClient;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._acquireContentProviderClient2725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderClient;
		}
		internal static global::MonoJavaBridge.MethodId _acquireContentProviderClient2726;
		public virtual global::android.content.ContentProviderClient acquireContentProviderClient(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ContentResolver._acquireContentProviderClient2726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderClient;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._acquireContentProviderClient2726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ContentProviderClient;
		}
		internal static global::MonoJavaBridge.MethodId _registerContentObserver2727;
		public virtual void registerContentObserver(android.net.Uri arg0, bool arg1, android.database.ContentObserver arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentResolver._registerContentObserver2727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._registerContentObserver2727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterContentObserver2728;
		public virtual void unregisterContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentResolver._unregisterContentObserver2728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._unregisterContentObserver2728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _notifyChange2729;
		public virtual void notifyChange(android.net.Uri arg0, android.database.ContentObserver arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentResolver._notifyChange2729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._notifyChange2729, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _notifyChange2730;
		public virtual void notifyChange(android.net.Uri arg0, android.database.ContentObserver arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentResolver._notifyChange2730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._notifyChange2730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startSync2731;
		public virtual void startSync(android.net.Uri arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentResolver._startSync2731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._startSync2731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _requestSync2732;
		public static void requestSync(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._requestSync2732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _validateSyncExtrasBundle2733;
		public static void validateSyncExtrasBundle(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._validateSyncExtrasBundle2733, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cancelSync2734;
		public virtual void cancelSync(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ContentResolver._cancelSync2734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ContentResolver.staticClass, global::android.content.ContentResolver._cancelSync2734, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cancelSync2735;
		public static void cancelSync(android.accounts.Account arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._cancelSync2735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getSyncAdapterTypes2736;
		public static global::android.content.SyncAdapterType[] getSyncAdapterTypes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.content.SyncAdapterType>(@__env.CallStaticObjectMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._getSyncAdapterTypes2736)) as android.content.SyncAdapterType[];
		}
		internal static global::MonoJavaBridge.MethodId _getSyncAutomatically2737;
		public static bool getSyncAutomatically(android.accounts.Account arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._getSyncAutomatically2737, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSyncAutomatically2738;
		public static void setSyncAutomatically(android.accounts.Account arg0, java.lang.String arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._setSyncAutomatically2738, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addPeriodicSync2739;
		public static void addPeriodicSync(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2, long arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._addPeriodicSync2739, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _removePeriodicSync2740;
		public static void removePeriodicSync(android.accounts.Account arg0, java.lang.String arg1, android.os.Bundle arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._removePeriodicSync2740, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getPeriodicSyncs2741;
		public static global::java.util.List getPeriodicSyncs(android.accounts.Account arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallStaticObjectMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._getPeriodicSyncs2741, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getIsSyncable2742;
		public static int getIsSyncable(android.accounts.Account arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._getIsSyncable2742, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setIsSyncable2743;
		public static void setIsSyncable(android.accounts.Account arg0, java.lang.String arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._setIsSyncable2743, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getMasterSyncAutomatically2744;
		public static bool getMasterSyncAutomatically()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._getMasterSyncAutomatically2744);
		}
		internal static global::MonoJavaBridge.MethodId _setMasterSyncAutomatically2745;
		public static void setMasterSyncAutomatically(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._setMasterSyncAutomatically2745, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSyncActive2746;
		public static bool isSyncActive(android.accounts.Account arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._isSyncActive2746, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentSync2747;
		public static global::android.content.SyncInfo getCurrentSync()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._getCurrentSync2747)) as android.content.SyncInfo;
		}
		internal static global::MonoJavaBridge.MethodId _isSyncPending2748;
		public static bool isSyncPending(android.accounts.Account arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._isSyncPending2748, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addStatusChangeListener2749;
		public static global::java.lang.Object addStatusChangeListener(int arg0, android.content.SyncStatusObserver arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._addStatusChangeListener2749, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		public static java.lang.Object addStatusChangeListener(int arg0, global::android.content.SyncStatusObserverDelegate arg1)
		{
			return addStatusChangeListener(arg0, (global::android.content.SyncStatusObserverDelegateWrapper)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _removeStatusChangeListener2750;
		public static void removeStatusChangeListener(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._removeStatusChangeListener2750, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ContentResolver2751;
		public ContentResolver(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentResolver.staticClass, global::android.content.ContentResolver._ContentResolver2751, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static global::java.lang.String SYNC_EXTRAS_ACCOUNT
		{
			get
			{
				return "account";
			}
		}
		public static global::java.lang.String SYNC_EXTRAS_EXPEDITED
		{
			get
			{
				return "expedited";
			}
		}
		public static global::java.lang.String SYNC_EXTRAS_FORCE
		{
			get
			{
				return "force";
			}
		}
		public static global::java.lang.String SYNC_EXTRAS_IGNORE_SETTINGS
		{
			get
			{
				return "ignore_settings";
			}
		}
		public static global::java.lang.String SYNC_EXTRAS_IGNORE_BACKOFF
		{
			get
			{
				return "ignore_backoff";
			}
		}
		public static global::java.lang.String SYNC_EXTRAS_DO_NOT_RETRY
		{
			get
			{
				return "do_not_retry";
			}
		}
		public static global::java.lang.String SYNC_EXTRAS_MANUAL
		{
			get
			{
				return "force";
			}
		}
		public static global::java.lang.String SYNC_EXTRAS_UPLOAD
		{
			get
			{
				return "upload";
			}
		}
		public static global::java.lang.String SYNC_EXTRAS_OVERRIDE_TOO_MANY_DELETIONS
		{
			get
			{
				return "deletions_override";
			}
		}
		public static global::java.lang.String SYNC_EXTRAS_DISCARD_LOCAL_DELETIONS
		{
			get
			{
				return "discard_deletions";
			}
		}
		public static global::java.lang.String SYNC_EXTRAS_INITIALIZE
		{
			get
			{
				return "initialize";
			}
		}
		public static global::java.lang.String SCHEME_CONTENT
		{
			get
			{
				return "content";
			}
		}
		public static global::java.lang.String SCHEME_ANDROID_RESOURCE
		{
			get
			{
				return "android.resource";
			}
		}
		public static global::java.lang.String SCHEME_FILE
		{
			get
			{
				return "file";
			}
		}
		public static global::java.lang.String CURSOR_ITEM_BASE_TYPE
		{
			get
			{
				return "vnd.android.cursor.item";
			}
		}
		public static global::java.lang.String CURSOR_DIR_BASE_TYPE
		{
			get
			{
				return "vnd.android.cursor.dir";
			}
		}
		public static int SYNC_OBSERVER_TYPE_SETTINGS
		{
			get
			{
				return 1;
			}
		}
		public static int SYNC_OBSERVER_TYPE_PENDING
		{
			get
			{
				return 2;
			}
		}
		public static int SYNC_OBSERVER_TYPE_ACTIVE
		{
			get
			{
				return 4;
			}
		}
		static ContentResolver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentResolver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentResolver"));
			global::android.content.ContentResolver._getType2713 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "getType", "(Landroid/net/Uri;)Ljava/lang/String;");
			global::android.content.ContentResolver._delete2714 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "delete", "(Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.content.ContentResolver._insert2715 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "insert", "(Landroid/net/Uri;Landroid/content/ContentValues;)Landroid/net/Uri;");
			global::android.content.ContentResolver._query2716 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "query", "(Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.content.ContentResolver._update2717 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "update", "(Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.content.ContentResolver._openInputStream2718 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "openInputStream", "(Landroid/net/Uri;)Ljava/io/InputStream;");
			global::android.content.ContentResolver._openOutputStream2719 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "openOutputStream", "(Landroid/net/Uri;)Ljava/io/OutputStream;");
			global::android.content.ContentResolver._openOutputStream2720 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "openOutputStream", "(Landroid/net/Uri;Ljava/lang/String;)Ljava/io/OutputStream;");
			global::android.content.ContentResolver._openFileDescriptor2721 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "openFileDescriptor", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/os/ParcelFileDescriptor;");
			global::android.content.ContentResolver._openAssetFileDescriptor2722 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "openAssetFileDescriptor", "(Landroid/net/Uri;Ljava/lang/String;)Landroid/content/res/AssetFileDescriptor;");
			global::android.content.ContentResolver._applyBatch2723 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "applyBatch", "(Ljava/lang/String;Ljava/util/ArrayList;)[Landroid/content/ContentProviderResult;");
			global::android.content.ContentResolver._bulkInsert2724 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "bulkInsert", "(Landroid/net/Uri;[Landroid/content/ContentValues;)I");
			global::android.content.ContentResolver._acquireContentProviderClient2725 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "acquireContentProviderClient", "(Landroid/net/Uri;)Landroid/content/ContentProviderClient;");
			global::android.content.ContentResolver._acquireContentProviderClient2726 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "acquireContentProviderClient", "(Ljava/lang/String;)Landroid/content/ContentProviderClient;");
			global::android.content.ContentResolver._registerContentObserver2727 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "registerContentObserver", "(Landroid/net/Uri;ZLandroid/database/ContentObserver;)V");
			global::android.content.ContentResolver._unregisterContentObserver2728 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.content.ContentResolver._notifyChange2729 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "notifyChange", "(Landroid/net/Uri;Landroid/database/ContentObserver;)V");
			global::android.content.ContentResolver._notifyChange2730 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "notifyChange", "(Landroid/net/Uri;Landroid/database/ContentObserver;Z)V");
			global::android.content.ContentResolver._startSync2731 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "startSync", "(Landroid/net/Uri;Landroid/os/Bundle;)V");
			global::android.content.ContentResolver._requestSync2732 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "requestSync", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.ContentResolver._validateSyncExtrasBundle2733 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "validateSyncExtrasBundle", "(Landroid/os/Bundle;)V");
			global::android.content.ContentResolver._cancelSync2734 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "cancelSync", "(Landroid/net/Uri;)V");
			global::android.content.ContentResolver._cancelSync2735 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "cancelSync", "(Landroid/accounts/Account;Ljava/lang/String;)V");
			global::android.content.ContentResolver._getSyncAdapterTypes2736 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "getSyncAdapterTypes", "()[Landroid/content/SyncAdapterType;");
			global::android.content.ContentResolver._getSyncAutomatically2737 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "getSyncAutomatically", "(Landroid/accounts/Account;Ljava/lang/String;)Z");
			global::android.content.ContentResolver._setSyncAutomatically2738 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "setSyncAutomatically", "(Landroid/accounts/Account;Ljava/lang/String;Z)V");
			global::android.content.ContentResolver._addPeriodicSync2739 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "addPeriodicSync", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;J)V");
			global::android.content.ContentResolver._removePeriodicSync2740 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "removePeriodicSync", "(Landroid/accounts/Account;Ljava/lang/String;Landroid/os/Bundle;)V");
			global::android.content.ContentResolver._getPeriodicSyncs2741 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "getPeriodicSyncs", "(Landroid/accounts/Account;Ljava/lang/String;)Ljava/util/List;");
			global::android.content.ContentResolver._getIsSyncable2742 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "getIsSyncable", "(Landroid/accounts/Account;Ljava/lang/String;)I");
			global::android.content.ContentResolver._setIsSyncable2743 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "setIsSyncable", "(Landroid/accounts/Account;Ljava/lang/String;I)V");
			global::android.content.ContentResolver._getMasterSyncAutomatically2744 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "getMasterSyncAutomatically", "()Z");
			global::android.content.ContentResolver._setMasterSyncAutomatically2745 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "setMasterSyncAutomatically", "(Z)V");
			global::android.content.ContentResolver._isSyncActive2746 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "isSyncActive", "(Landroid/accounts/Account;Ljava/lang/String;)Z");
			global::android.content.ContentResolver._getCurrentSync2747 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "getCurrentSync", "()Landroid/content/SyncInfo;");
			global::android.content.ContentResolver._isSyncPending2748 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "isSyncPending", "(Landroid/accounts/Account;Ljava/lang/String;)Z");
			global::android.content.ContentResolver._addStatusChangeListener2749 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "addStatusChangeListener", "(ILandroid/content/SyncStatusObserver;)Ljava/lang/Object;");
			global::android.content.ContentResolver._removeStatusChangeListener2750 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "removeStatusChangeListener", "(Ljava/lang/Object;)V");
			global::android.content.ContentResolver._ContentResolver2751 = @__env.GetMethodIDNoThrow(global::android.content.ContentResolver.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.ContentResolver))]
	internal sealed partial class ContentResolver_ : android.content.ContentResolver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ContentResolver_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static ContentResolver_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentResolver_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentResolver"));
		}
		internal static void InitJNI()
		{
		}
	}
}