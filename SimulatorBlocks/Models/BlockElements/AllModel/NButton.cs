using SimulatorBlocks.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SimulatorBlocks.Models.BlockElements.AllModel
{
    class NButton
    {
        public void commandchangeBut()
        {           
            if (Flag == false)
            {
               Flag = true;
            }
            else if (Flag == true)
            {
                Flag = false;              
            }
        }
        private bool flag;
        private int countButton;

        public NButton(int kCB)
        {
            Flag = false;
            CountButton = kCB;
        }

        public BitmapSource models
        {


            get
            {
                /// <summary>
                /// Алерты для блока Ф80305
                /// </summary> 

                if (CountButton == 0)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.Button_17_off);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.Button_17_on);
                    }
                }


                /// <summary>
                /// Алерты для блока 1960
                /// </summary> 

                if (CountButton == 1)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F3btn1_off);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F3btn1_on);
                    }
                }

                if (CountButton == 2)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F3btn2_off);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F3btn2_on);
                    }
                }

                return null;
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

        public int CountButton
        {
            get
            {
                return countButton;
            }

            set
            {
                countButton = value;
            }
        }

    }
}
