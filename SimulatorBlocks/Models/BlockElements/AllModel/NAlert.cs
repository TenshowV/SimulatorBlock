using SimulatorBlocks.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SimulatorBlocks.Models.BlockElements.AllModel
{
    class NAlert
    {
        public void commandchangeAlertControl()
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
        private int alertCount;

        public NAlert(int aC)
        {
            Flag = true;
            AlertCount = aC;
        }
        public BitmapSource alerts
        {
            /// <summary>
            /// Алерты для блока 19035000
            /// </summary>  
            get
            {
                if (AlertCount == 0)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.Nalert_on);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.Nalert_off);
                    }
                    return null;
                }

                if (AlertCount == 1)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F1alert0_on);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F1alert0_off);
                    }
                }

                if (AlertCount == 2)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F1alert1_on);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F1alert1_off);
                    }
                }

                if (AlertCount == 3)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F1alert2_on);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F1alert2_off);
                    }
                }
                /// <summary>
                /// Алерты для блока Ф80305
                /// </summary> 

                if (AlertCount == 4)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F0alert0_on);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F0alert0_off);
                    }
                }

                if (AlertCount == 5)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F0alert1_on);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F0alert1_off);
                    }
                }

                if (AlertCount == 6)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F0alert2_on);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F0alert2_off);
                    }
                }

                if (AlertCount == 7)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F0alert3_on);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F0alert3_off);
                    }
                }

                if (AlertCount == 8)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F0alert4_on);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F0alert4_off);
                    }
                }

                if (AlertCount == 9)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F0alert5_on);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F0alert5_off);
                    }
                }

                if (AlertCount == 10)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F0alert6_on);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F0alert6_off);
                    }
                }

                /// <summary>
                /// Алерты для блока 19260100
                /// </summary> 

                if (AlertCount == 11)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F2alert0_on);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F2alert0_off);
                    }
                }

                if (AlertCount == 12)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F2alert1_on);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F2alert1_off);
                    }
                }

                if (AlertCount == 13)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F2alert2_on);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F2alert2_off);
                    }
                }

                if (AlertCount == 14)
                {
                    if (Flag == false)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F2alert3_on);
                    }
                    else if (Flag == true)
                    {
                        return commandBitmap.loadBitmap(Properties.Resources.F2alert3_off);
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

        public int AlertCount
        {
            get
            {
                return alertCount;
            }

            set
            {
                alertCount = value;
            }
        }
    }
}
