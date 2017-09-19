using SimulatorBlocks.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SimulatorBlocks.Models.BlockElements.Block1960
{
    class F3Shina
    {
        private bool flag;
        private int counter;
        public BitmapSource f3Shina
        {
            get
            {
                switch (Counter)
                {
                    case 0: return commandBitmap.loadBitmap(Properties.Resources.F3shina0_0);
                    case 1: return commandBitmap.loadBitmap(Properties.Resources.F3shina0_1);
                    case 2: return commandBitmap.loadBitmap(Properties.Resources.F3shina0_2);
                    case 3: return commandBitmap.loadBitmap(Properties.Resources.F3shina0_3);
                    case 4: return commandBitmap.loadBitmap(Properties.Resources.F3shina0_4);
                    case 5: return commandBitmap.loadBitmap(Properties.Resources.F3shina0_5);
                    case 6: return commandBitmap.loadBitmap(Properties.Resources.F3shina0_6);
                    case 7: return commandBitmap.loadBitmap(Properties.Resources.F3shina0_7);
                    case 8: return commandBitmap.loadBitmap(Properties.Resources.F3shina0_8);
                    case 9: return commandBitmap.loadBitmap(Properties.Resources.F3shina0_9);
                    case 10: return commandBitmap.loadBitmap(Properties.Resources.F3shina0_10);
                    case 11: return commandBitmap.loadBitmap(Properties.Resources.F3shina0_11);
                    default: { return null; }
                }
            }
        }
        public F3Shina()
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
