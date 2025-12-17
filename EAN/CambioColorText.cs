using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAN
{
    class CambioColorText
    {
        public static void ChangeColor(RichTextBox rtx, int Start, byte Length = 1)
        {
            rtx.SelectionAlignment = HorizontalAlignment.Left;
            rtx.SelectionStart = Start;
            rtx.SelectionLength = Length;
            rtx.SelectionColor = Color.Crimson;
        }
    }
}