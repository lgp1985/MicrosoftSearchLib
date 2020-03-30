namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, InterfaceType((short) 1), Guid("AB310581-AC80-11D1-8DF3-00C04FB6EF53")]
    public interface ISearchScopeRule
    {
        [DispId(0x60010000)]
        string PatternOrURL { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }
        [DispId(0x60010001)]
        int IsIncluded { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }
        [DispId(0x60010002)]
        int IsDefault { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }
        [DispId(0x60010003)]
        uint FollowFlags { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

