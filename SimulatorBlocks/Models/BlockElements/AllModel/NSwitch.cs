using SimulatorBlocks.Commands;
using System.Windows.Media.Imaging;

namespace SimulatorBlocks.Models.BlockElements.AllModel
{
    class NSwitch
    {
        public void commandchangeSwitcher()
        {          
            if (Flag == true)
            {
                Flag = false;
            }
            else if (Flag == false)
            {
                Flag = true;              
            }          
        }
        private bool flag;
        private int switchCount;

        public NSwitch(int kS)
        {
            Flag = false;
            SwitchCount = kS;
        }

        public BitmapSource switchers
        {
            /// <summary>
            /// Свичеры для блока Ф80305
            /// </summary> 
            get
            {
                if (SwitchCount == 0)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.Nswitch_on);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.Nswitch_off);
                    }
                }

                /// <summary>
                /// Свитчеры для блока 19035000
                /// </summary> 

                if (SwitchCount == 1)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F1switcher0_on);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F1switcher0_off);
                    }
                }

                if (SwitchCount == 2)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F1switcher1_on);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F1switcher1_off);
                    }
                }

                if (SwitchCount == 3)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F1switcher2_on);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F1switcher2_off);
                    }
                }

                if (SwitchCount == 4)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.Switch_off);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.Switch_on);
                    }
                }

                /// <summary>
                /// Свитчеры для блока 19260100
                /// </summary>

                if (SwitchCount == 5)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F2switcher_on);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F2switcher_off);
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

        public int SwitchCount
        {
            get
            {
                return switchCount;
            }

            set
            {
                switchCount = value;
            }
        }
    }
}
