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
    class F1tumbler0
    {
        private bool flag;
        private int counter;

        public BitmapSource f1Tumbler0
        {
            get
            {
                switch (Counter)
                {
                    case 0: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler0_0);
                    case 1: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler0_1);
                    case 2: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler0_2);
                    case 3: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler0_3);
                    case 4: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler0_4);
                    case 5: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler0_5);
                    default: { return null; }
                }
            }
        }

        public F1tumbler0()
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
