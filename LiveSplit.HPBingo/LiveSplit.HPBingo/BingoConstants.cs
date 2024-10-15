using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.HPBingo
{
    public static class BingoConstants
    {
        public const string COMPONENT_NAME = "HP Bingo";
        public const string COMPONENT_DESCRIPTION = "LiveSplit component for the HP Bingo";

        public const int DEFAULT_FONTSIZE = 12;
        public const int DEFAULT_WIDTH = 100;
        public const int DEFAULT_HEIGHT = 350;
        public const int MIN_WIDTH = 200;
        public const int MIN_HEIGHT = 20;

        public static readonly Color DEFAULT_TEXTCOLOR = Color.LightGray;
        public static readonly Color DEFAULT_COUNTERCOLOR = Color.LightGreen;
    }
}
