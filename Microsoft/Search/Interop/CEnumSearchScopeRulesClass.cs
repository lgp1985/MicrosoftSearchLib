namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("3379F9F7-F805-4827-9CF6-03DB41F297DA"), ClassInterface((short) 0)]
    public class CEnumSearchScopeRulesClass : IEnumSearchScopeRules, CEnumSearchScopeRules
    {
        [return: MarshalAs(UnmanagedType.Interface)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern CEnumSearchScopeRules Clone();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void Next([In] uint celt, [MarshalAs(UnmanagedType.Interface)] out CSearchScopeRule pprgelt, [In, Out] ref uint pceltFetched);
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void Reset();
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        public virtual extern void Skip([In] uint celt);
    }
}

