namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, ComConversionLoss, Guid("AB310581-AC80-11D1-8DF3-00C04FB6EF69"), InterfaceType((short) 1)]
    public interface ISearchManager
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void GetIndexerVersionStr([MarshalAs(UnmanagedType.LPWStr)] out string ppszVersionString);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void GetIndexerVersion(out uint pdwMajor, out uint pdwMinor);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        IntPtr GetParameter([In, MarshalAs(UnmanagedType.LPWStr)] string pszName);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void SetParameter([In, MarshalAs(UnmanagedType.LPWStr)] string pszName, [In] ref tag_inner_PROPVARIANT pValue);
        [DispId(0x60010004)]
        string ProxyName { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }
        [DispId(0x60010005)]
        string BypassList { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void SetProxy([In] _PROXY_ACCESS sUseProxy, [In] int fLocalByPassProxy, [In] uint dwPortNumber, [In, MarshalAs(UnmanagedType.LPWStr)] string pszProxyName, [In, MarshalAs(UnmanagedType.LPWStr)] string pszByPassList);
        [return: MarshalAs(UnmanagedType.Interface)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        CSearchCatalogManager GetCatalog([In, MarshalAs(UnmanagedType.LPWStr)] string pszCatalog);
        [DispId(0x60010008)]
        string UserAgent { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; [param: In, MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] set; }
        [DispId(0x6001000a)]
        _PROXY_ACCESS UseProxy { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }
        [DispId(0x6001000b)]
        int LocalBypass { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }
        [DispId(0x6001000c)]
        uint PortNumber { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

