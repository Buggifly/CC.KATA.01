using System.Diagnostics.CodeAnalysis;

using CC.KATA.C01.Code.Exceptions;

namespace CC.KATA.C01.Code.Models
{
    internal sealed class Frame
    {
        internal int Height
        {
            get { throw new UTException(); }
        }

        internal int Width
        {
            get { throw new UTException(); }
        }

        internal int X
        {
            get { throw new UTException(); }
        }

        internal int Y
        {
            get { throw new UTException(); }
        }

        [SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "KATA")]
        internal void RenderOverflowIcon(int x, int y)
        {
            throw new UTException();
        }
    }
}
