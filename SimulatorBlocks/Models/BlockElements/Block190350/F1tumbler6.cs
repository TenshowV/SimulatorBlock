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
    class F1tumbler6
    {


        private bool flag;
        private int counter;

        public BitmapSource f1Tumbler6
        {
            get
            {
                switch (Counter)
                {
                    case 0: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler6_0);
                    case 1: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler6_1);
                    case 2: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler6_2);
                    case 3: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler6_3);
                    case 4: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler6_4);
                    case 5: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler6_5);
                    case 6: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler6_6);
                    case 7: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler6_7);
                    case 8: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler6_8);
                    case 9: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler6_9);
                    case 10: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler6_10);
                    case 11: return commandBitmap.loadBitmap(Properties.Resources.F1tumbler6_11);
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

      
        public F1tumbler6()
        {
            Flag = true;
            Counter = 1;
        }
    }
}
