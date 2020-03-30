namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.InteropServices.CustomMarshalers;

    [ComImport, ComConversionLoss, InterfaceType((short) 1), Guid("00020403-0000-0000-C000-000000000046")]
    public interface ITypeComp
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void RemoteBind([In, MarshalAs(UnmanagedType.LPWStr)] string szName, [In] uint lHashVal, [In] ushort wFlags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType="", MarshalTypeRef=typeof(TypeToTypeInfoMarshaler), MarshalCookie="")] out Type ppTInfo, out tagDESCKIND pDescKind, [Out] IntPtr ppFuncDesc, [Out] IntPtr ppVarDesc, [MarshalAs(UnmanagedType.Interface)] out ITypeComp ppTypeComp, [ComAliasName("Microsoft.Search.Interop.DWORD")] out uint pDummy);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void RemoteBindType([In, MarshalAs(UnmanagedType.LPWStr)] string szName, [In] uint lHashVal, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType="", MarshalTypeRef=typeof(TypeToTypeInfoMarshaler), MarshalCookie="")] out Type ppTInfo);
    }
}

