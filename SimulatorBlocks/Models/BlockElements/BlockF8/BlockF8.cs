using SimulatorBlocks.Models.BlockElements.AllModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SimulatorBlocks.Models.BlockElements.BlockF8
{
    class BlockF8
    {
        public NButton ButtonU17;
        /// <summary>
        /// Шина В1
        /// </summary>
        public shina Shina;
        public tumblerB2 TumblerB2;
        public tumblerB4 TumblerB4;
        /// <summary>
        /// ТУмблер ПРОХОЖД ПОДАВЛ
        /// </summary>  
        public NSwitch Switcher1;
        /// <summary>
        /// ТУмблер АРУ
        /// </summary>  
        public NSwitch Switcher2;
        public NAlert Nalerts;
        public NAlert Nalerts1;
        public NAlert Nalerts2;
        public NAlert Nalerts3;
        public NAlert Nalerts4;
        public NAlert Nalerts5;
        public NAlert Nalerts6;
        public BlockF8()
        {
            Shina = new shina();
            TumblerB2 = new tumblerB2();
            TumblerB4 = new tumblerB4();

            ButtonU17 = new NButton(0);
            Switcher2 = new NSwitch(4);
            Switcher1 = new NSwitch(4);
            Nalerts = new NAlert(10);
            Nalerts1 = new NAlert(4);
            Nalerts2 = new NAlert(5);
            Nalerts3 = new NAlert(6);
            Nalerts4 = new NAlert(7);
            Nalerts5 = new NAlert(8);
            Nalerts6 = new NAlert(9);
        }
        public BitmapSource ImageMainBlock
        {
            get
            {
                return Commands.commandBitmap.loadBitmap(Properties.Resources.Ф8_03_05);
            }
        }
    }
}
