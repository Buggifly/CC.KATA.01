using System;

namespace CC.KATA.C01.Code.Exceptions
{
    internal sealed class UTException : Exception
    {
        internal UTException()
            : base("NOT allowed in a UT context.")
        {
        }
    }
}
