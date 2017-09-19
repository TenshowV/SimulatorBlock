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
    class F2shina2
    {
        private bool flag;
        private int counter;

        public BitmapSource f2Shina2
        {
            get
            {
                switch (Counter)
                {
                    case 0: return commandBitmap.loadBitmap(Properties.Resources.F2shina2_0);
                    case 1: return commandBitmap.loadBitmap(Properties.Resources.F2shina2_1);
                    case 2: return commandBitmap.loadBitmap(Properties.Resources.F2shina2_2);
                    case 3: return commandBitmap.loadBitmap(Properties.Resources.F2shina2_3);
                    case 4: return commandBitmap.loadBitmap(Properties.Resources.F2shina2_4);
                    case 5: return commandBitmap.loadBitmap(Properties.Resources.F2shina2_5);
                    case 6: return commandBitmap.loadBitmap(Properties.Resources.F2shina2_6);
                    case 7: return commandBitmap.loadBitmap(Properties.Resources.F2shina2_7);
                    case 8: return commandBitmap.loadBitmap(Properties.Resources.F2shina2_8);
                    default: { return null; }
                }
            }
        }
        public F2shina2()
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
