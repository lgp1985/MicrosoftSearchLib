namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("E63DE750-3BD7-4BE5-9C84-6B4281988C44"), ClassInterface((short) 0), TypeLibType((short) 2)]
    public class CSearchScopeRuleClass : ISearchScopeRule, CSearchScopeRule
    {
        [DispId(0x60010000)]
        public virtual string PatternOrURL { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }

        [DispId(0x60010001)]
        public virtual int IsIncluded { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }

        [DispId(0x60010002)]
        public virtual int IsDefault { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }

        [DispId(0x60010003)]
        public virtual uint FollowFlags { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }

        [DispId(0x60010000)]
        public virtual string Microsoft.Search.Interop.ISearchScopeRule.PatternOrURL { [return: MarshalAs(UnmanagedType.LPWStr)] [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }

        [DispId(0x60010001)]
        public virtual int Microsoft.Search.Interop.ISearchScopeRule.IsIncluded { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }

        [DispId(0x60010002)]
        public virtual int Microsoft.Search.Interop.ISearchScopeRule.IsDefault { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }

        [DispId(0x60010003)]
        public virtual uint Microsoft.Search.Interop.ISearchScopeRule.FollowFlags { [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)] get; }
    }
}

