using SimulatorBlocks.Commands;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SimulatorBlocks.Models.Block19260100
{
    class F2shina1
    {
        private bool flag;
        private int counter;

        public BitmapSource f2Shina1
        {
            get
            {
                switch (Counter)
                {
                    case 0: return commandBitmap.loadBitmap(Properties.Resources.F2shina1_0);
                    case 1: return commandBitmap.loadBitmap(Properties.Resources.F2shina1_1);
                    case 2: return commandBitmap.loadBitmap(Properties.Resources.F2shina1_2);
                    case 3: return commandBitmap.loadBitmap(Properties.Resources.F2shina1_3);
                    case 4: return commandBitmap.loadBitmap(Properties.Resources.F2shina1_4);
                    case 5: return commandBitmap.loadBitmap(Properties.Resources.F2shina1_5);
                    case 6: return commandBitmap.loadBitmap(Properties.Resources.F2shina1_6);
                    case 7: return commandBitmap.loadBitmap(Properties.Resources.F2shina1_7);
                    case 8: return commandBitmap.loadBitmap(Properties.Resources.F2shina1_8);
                    case 9: return commandBitmap.loadBitmap(Properties.Resources.F2shina1_9);
                    case 10: return commandBitmap.loadBitmap(Properties.Resources.F2shina1_10);
                    case 11: return commandBitmap.loadBitmap(Properties.Resources.F2shina1_11);
                    case 12: return commandBitmap.loadBitmap(Properties.Resources.F2shina1_12);
                    default: { return null; }
                }
            }
        }
        public F2shina1()
        {
            Flag = true;
            Counter = 1;
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
