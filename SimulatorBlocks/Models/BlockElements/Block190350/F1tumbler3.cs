using SimulatorBlocks.Commands;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SimulatorBlocks.Models.Block190350
{
    class F1tumbler3
    {
        private bool flag;
        private int counter;

        public BitmapSource f1Tumbler3
        {
            get
            {
                switch (Counter)
                {
                    case 0: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler3_0);
                    case 1: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler3_1);
                    case 2: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler3_2);
                    case 3: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler3_3);
                    case 4: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler3_4);
                    case 5: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler3_5);
                    case 6: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler3_6);
                    case 7: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler3_7);
                    case 8: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler3_8);
                    default: { return null; }
                }
            }
        }

        public F1tumbler3()
        {
            Flag = true;
            Counter = 0;
        }

        public bool Flag
        {
            get
            {
                return flag;
            }

            set
            {
                flag = value;
            }
        }

        public int Counter
        {
            get
            {
                return counter;
            }

            set
            {
                counter = value;
            }
        }
    }
}
