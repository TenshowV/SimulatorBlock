using SimulatorBlocks.Commands;
using System.Windows.Media.Imaging;

namespace SimulatorBlocks.Models.BlockElements.BlockF8
{
    class tumblerB2
    {
        int counter;
        bool flag;
        public BitmapSource tumblers
        {
            get
            {
                switch (Counter)
                {
                    case 1: { return commandBitmap.loadBitmap(Properties.Resources.Tumbler1_0); }
                    case 2: { return commandBitmap.loadBitmap(Properties.Resources.Tumbler1_1); }
                    case 3: { return commandBitmap.loadBitmap(Properties.Resources.Tumbler1_2); }
                    case 4: { return commandBitmap.loadBitmap(Properties.Resources.Tumbler1_3); }
                    case 5: { return commandBitmap.loadBitmap(Properties.Resources.Tumbler1_4); }
                    case 6: { return commandBitmap.loadBitmap(Properties.Resources.Tumbler1_5); }
                    case 7: { return commandBitmap.loadBitmap(Properties.Resources.Tumbler1_6); }
                    case 8: { return commandBitmap.loadBitmap(Properties.Resources.Tumbler1_7); }
                    case 9: { return commandBitmap.loadBitmap(Properties.Resources.Tumbler1_8); }
                    case 10: { return commandBitmap.loadBitmap(Properties.Resources.Tumbler1_9); }
                    case 11: { return commandBitmap.loadBitmap(Properties.Resources.Tumbler1_10); }
                    case 12: { return commandBitmap.loadBitmap(Properties.Resources.Tumbler1_11); }
                    default: { return null; }
                }
            }
        }
        /// <summary>
        /// Смена переключателя Б2
        /// </summary>
        public void commandchangeTumbler()
        {           
            if (Counter >= 12)Flag = false;
            else if (Counter <= 1) Flag = true;
            if (Flag == true)
            {
                Counter++;                
            }
            else
            {
               Counter--;                
            }           
        }
        public tumblerB2()
        {
            counter = 1;
            flag = true;
        }

        public int Counter
        {
            get { return counter; }
            set
            {
                counter = value;
            }
        }

        public bool Flag
        {
            get { return flag; }
            set
            {
                flag = value;
            }
        }
    }
}
