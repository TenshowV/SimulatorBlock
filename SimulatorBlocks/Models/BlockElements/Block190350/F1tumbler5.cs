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
    class F1tumbler5
    {
        private bool flag;
        private int counter;

        public BitmapSource f1Tumbler5
        {
            get
            {
                switch (Counter)
                {
                    case 0: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler5_0);
                    case 1: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler5_1);
                    case 2: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler5_2);
                    case 3: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler5_3);
                    case 4: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler5_4);
                    case 5: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler5_5);
                    case 6: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler5_6);
                    case 7: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler5_7);
                    case 8: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler5_8);
                    case 9: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler5_9);
                    case 10: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler5_10);
                    case 11: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler5_11);
                    default: { return null; }
                }
            }
        }

        public F1tumbler5()
        {
            flag = true;
            counter = 0;
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
