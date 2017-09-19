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
    class F1Shina
    {
        private bool flag;
        private int counter;


        public BitmapSource f1Shina
        {
            get
            {
                switch (Counter)
                {
                    case 0: return commandBitmap.loadBitmap(Properties.Resources.F1shina0_0);
                    case 1: return commandBitmap.loadBitmap(Properties.Resources.F1shina0_1);
                    case 2: return commandBitmap.loadBitmap(Properties.Resources.F1shina0_2);
                    case 3: return commandBitmap.loadBitmap(Properties.Resources.F1shina0_3);
                    case 4: return commandBitmap.loadBitmap(Properties.Resources.F1shina0_4);
                    case 5: return commandBitmap.loadBitmap(Properties.Resources.F1shina0_5);
                    case 6: return commandBitmap.loadBitmap(Properties.Resources.F1shina0_6);
                    default: { return null; }
                }
            }
        }

        public F1Shina()
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
