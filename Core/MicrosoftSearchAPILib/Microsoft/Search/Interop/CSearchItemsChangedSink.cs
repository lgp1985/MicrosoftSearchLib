namespace Microsoft.Search.Interop
{
    using System.Runtime.InteropServices;

    [ComImport, CoClass(typeof(CSearchItemsChangedSinkClass)), Guid("AB310581-AC80-11D1-8DF3-00C04FB6EF58")]
    public interface CSearchItemsChangedSink : ISearchItemsChangedSink
    {
    }
}

