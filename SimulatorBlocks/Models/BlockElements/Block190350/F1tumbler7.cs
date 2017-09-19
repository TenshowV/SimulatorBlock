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
    class F1tumbler7
    {
        private bool flag;
        private int counter;

        public BitmapSource f1Tumbler7
        {
            get
            {
                switch (Counter)
                {
                    case 0: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler7_0);
                    case 1: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler7_1);
                    case 2: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler7_2);
                    case 3: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler7_3);
                    case 4: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler7_4);
                    default: { return null; }
                }
            }
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

        public F1tumbler7()
        {
            Flag = true;
            Counter = 1;
        }
    }
}
