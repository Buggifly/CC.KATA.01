using CC.KATA.C01.Code.Enumerations;
using CC.KATA.C01.Code.Exceptions;

namespace CC.KATA.C01.Code.Models
{
    internal sealed class Document
    {
        internal bool IsLoaded
        {
            get { throw new UTException(); }
        }

        internal OverflowIconPosition OverflowIconPosition
        {
            get { throw new UTException(); }
        }

        internal bool WarnIfOverflow
        {
            get { throw new UTException(); }
        }
    }
}
