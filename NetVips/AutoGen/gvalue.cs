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
    public unsafe delegate void GValueTransform(global::System.IntPtr src_value, global::System.IntPtr dest_value);

    public unsafe partial class GValue : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal ulong g_type;

            [FieldOffset(8)]
            internal fixed byte data[16];
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NetVips.AutoGen.GValue> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NetVips.AutoGen.GValue>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::NetVips.AutoGen.GValue __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::NetVips.AutoGen.GValue(native.ToPointer(), skipVTables);
        }

        internal static global::NetVips.AutoGen.GValue __CreateInstance(global::NetVips.AutoGen.GValue.__Internal native, bool skipVTables = false)
        {
            return new global::NetVips.AutoGen.GValue(native, skipVTables);
        }

        private static void* __CopyValue(global::NetVips.AutoGen.GValue.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::NetVips.AutoGen.GValue.__Internal));
            *(global::NetVips.AutoGen.GValue.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private GValue(global::NetVips.AutoGen.GValue.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected GValue(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        ~GValue()
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
            global::NetVips.AutoGen.GValue __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public ulong GType
        {
            get
            {
                return ((global::NetVips.AutoGen.GValue.__Internal*) __Instance)->g_type;
            }

            set
            {
                ((global::NetVips.AutoGen.GValue.__Internal*)__Instance)->g_type = value;
            }
        }
    }

    public unsafe partial class gvalue
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libgobject-2.0-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="g_value_init")]
            internal static extern global::System.IntPtr GValueInit(global::System.IntPtr value, ulong g_type);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libgobject-2.0-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="g_value_unset")]
            internal static extern void GValueUnset(global::System.IntPtr value);
        }

        public static global::NetVips.AutoGen.GValue GValueInit(global::NetVips.AutoGen.GValue value, ulong g_type)
        {
            var __arg0 = ReferenceEquals(value, null) ? global::System.IntPtr.Zero : value.__Instance;
            var __ret = __Internal.GValueInit(__arg0, g_type);
            global::NetVips.AutoGen.GValue __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::NetVips.AutoGen.GValue.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::NetVips.AutoGen.GValue) global::NetVips.AutoGen.GValue.NativeToManagedMap[__ret];
            else __result0 = global::NetVips.AutoGen.GValue.__CreateInstance(__ret);
            return __result0;
        }

        public static void GValueUnset(global::NetVips.AutoGen.GValue value)
        {
            var __arg0 = ReferenceEquals(value, null) ? global::System.IntPtr.Zero : value.__Instance;
            __Internal.GValueUnset(__arg0);
        }
    }
}