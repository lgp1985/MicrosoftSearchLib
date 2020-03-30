namespace Microsoft.Search.Interop
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=4)]
    public struct tagELEMDESC
    {
        public tagTYPEDESC tdesc;
        public tagPARAMDESC paramdesc;
    }
}

