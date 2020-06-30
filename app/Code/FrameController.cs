using System;

using CC.KATA.C01.Code.Enumerations;
using CC.KATA.C01.Code.Exceptions;
using CC.KATA.C01.Code.Models;

namespace CC.KATA.C01.Code
{
    internal sealed class FrameController
    {
        private readonly Document document;

        private readonly Frame frame;

        internal FrameController(Document document, Frame frame)
        {
            this.document = document;
            this.frame = frame;

            throw new UTException();
        }

        internal void CheckIfOverflow()
        {
            if (!this.document.IsLoaded || !this.document.WarnIfOverflow)
            {
                return;
            }

            int xPos;
            int yPos;

            switch (this.document.OverflowIconPosition)
            {
                case OverflowIconPosition.BLeft:
                    xPos = this.frame.X + 5;
                    yPos = (this.frame.Y + this.frame.Height) - 32 - 5;
                    this.frame.RenderOverflowIcon(xPos, yPos);

                    break;

                case OverflowIconPosition.BRight:
                    xPos = (this.frame.X + this.frame.Width) - 32 - 5;
                    yPos = (this.frame.Y + this.frame.Height) - 32 - 5;
                    this.frame.RenderOverflowIcon(xPos, yPos);

                    break;

                default:
                    throw new NotSupportedException();
            }
        }
    }
}
