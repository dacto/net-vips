// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NetVips.AutoGen
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate void GBaseInitFunc(global::System.IntPtr g_class);

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate void GBaseFinalizeFunc(global::System.IntPtr g_class);

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate void GClassInitFunc(global::System.IntPtr g_class, global::System.IntPtr class_data);

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate void GClassFinalizeFunc(global::System.IntPtr g_class, global::System.IntPtr class_data);

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate void GInterfaceInitFunc(global::System.IntPtr g_iface, global::System.IntPtr iface_data);

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate void GInterfaceFinalizeFunc(global::System.IntPtr g_iface, global::System.IntPtr iface_data);

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate int GTypeClassCacheFunc(global::System.IntPtr cache_data, global::System.IntPtr g_class);

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate void GTypeInterfaceCheckFunc(global::System.IntPtr check_data, global::System.IntPtr g_iface);

    public unsafe partial class GTypeClass : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal ulong g_type;
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NetVips.AutoGen.GTypeClass> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NetVips.AutoGen.GTypeClass>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::NetVips.AutoGen.GTypeClass __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::NetVips.AutoGen.GTypeClass(native.ToPointer(), skipVTables);
        }

        internal static global::NetVips.AutoGen.GTypeClass __CreateInstance(global::NetVips.AutoGen.GTypeClass.__Internal native, bool skipVTables = false)
        {
            return new global::NetVips.AutoGen.GTypeClass(native, skipVTables);
        }

        private static void* __CopyValue(global::NetVips.AutoGen.GTypeClass.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::NetVips.AutoGen.GTypeClass.__Internal));
            *(global::NetVips.AutoGen.GTypeClass.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private GTypeClass(global::NetVips.AutoGen.GTypeClass.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected GTypeClass(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        ~GTypeClass()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NetVips.AutoGen.GTypeClass __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public ulong GType
        {
            get
            {
                return ((global::NetVips.AutoGen.GTypeClass.__Internal*) __Instance)->g_type;
            }

            set
            {
                ((global::NetVips.AutoGen.GTypeClass.__Internal*)__Instance)->g_type = value;
            }
        }
    }

    public unsafe partial class GTypeInstance
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr g_class;
        }
    }

    public unsafe partial class gtype
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libgobject-2.0-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="g_type_name")]
            internal static extern global::System.IntPtr GTypeName(ulong type);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libgobject-2.0-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="g_type_from_name")]
            internal static extern ulong GTypeFromName([MarshalAs(UnmanagedType.LPStr)] string name);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libgobject-2.0-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="g_type_fundamental")]
            internal static extern ulong GTypeFundamental(ulong type_id);
        }

        public static string GTypeName(ulong type)
        {
            var __ret = __Internal.GTypeName(type);
            return Marshal.PtrToStringAnsi(__ret);
        }

        public static ulong GTypeFromName(string name)
        {
            var __ret = __Internal.GTypeFromName(name);
            return __ret;
        }

        public static ulong GTypeFundamental(ulong type_id)
        {
            var __ret = __Internal.GTypeFundamental(type_id);
            return __ret;
        }
    }
}