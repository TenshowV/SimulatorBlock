using SimulatorBlocks.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SimulatorBlocks.Models.BlockElements.BlockF8
{
    class shina
    {
        //Изображения для обработки
        int counter;
        bool flag;

        public BitmapSource Shina
        {
            get
            {
                switch (Counter)
                {
                    case 1: { return commandBitmap.loadBitmap(Properties.Resources.Shina_0); }
                    case 2: { return commandBitmap.loadBitmap(Properties.Resources.Shina_1); }
                    case 3: { return commandBitmap.loadBitmap(Properties.Resources.Shina_2); }
                    case 4: { return commandBitmap.loadBitmap(Properties.Resources.Shina_3); }
                    case 5: { return commandBitmap.loadBitmap(Properties.Resources.Shina_4); }
                    case 6: { return commandBitmap.loadBitmap(Properties.Resources.Shina_5); }
                    case 7: { return commandBitmap.loadBitmap(Properties.Resources.Shina_6); }
                    case 8: { return commandBitmap.loadBitmap(Properties.Resources.Shina_7); }
                    default: { return null; }
                }
            }
        }
        public void commandchangeshina()
        {           
            if (Counter >= 8) Flag = false;
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
        public shina()
        {
            counter = 1;
            flag = true;
        }
        /// <summary>
        /// Начальное положение нулевое
        /// </summary>

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
