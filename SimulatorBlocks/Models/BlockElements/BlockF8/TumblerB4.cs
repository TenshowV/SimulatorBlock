using SimulatorBlocks.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SimulatorBlocks.Models.BlockElements.BlockF8
{
    class tumblerB4
    {
        public void commandchangeTumbler()
        {            
            if (Counter >= 2) Flag = false;
            if (Counter <= 0)Flag = true;
            if (Flag == true)
            {
                Counter++;               
            }
            else
            {
                Counter--;
            }            
        }
        int counter;
        bool flag;
        public BitmapSource tumblers
        {
            get
            {
                switch (Counter)
                {
                    case 0: { return commandBitmap.loadBitmap(Properties.Resources.Tumbler2_0); }
                    case 1: { return commandBitmap.loadBitmap(Properties.Resources.Tumbler2_1); }
                    case 2: { return commandBitmap.loadBitmap(Properties.Resources.Tumbler2_2); }
                    default: { return null; }
                }
            }
        }


        public tumblerB4()
        {
            Counter = 1;
            Flag = true;
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
    }
}
