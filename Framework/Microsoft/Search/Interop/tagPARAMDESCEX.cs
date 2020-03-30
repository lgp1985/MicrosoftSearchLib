namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=8)]
    public struct tagPARAMDESCEX
    {
        public uint cBytes;
        [MarshalAs(UnmanagedType.Struct)]
        public object varDefaultValue;
    }
}

