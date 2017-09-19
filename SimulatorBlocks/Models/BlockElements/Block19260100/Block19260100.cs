using SimulatorBlocks.Commands;
using SimulatorBlocks.Models.BlockElements.AllModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SimulatorBlocks.Models.Block19260100
{
    class Block19260100
    {
        public F2shina0 f2Shina0;
        public F2shina1 f2Shina1;
        public F2shina2 f2Shina2;
        public F2shina3 f2Shina3;
        public F2shina4 f2Shina4;
        public NSwitch switch1;
        public NAlert alert1;
        public NAlert alert2;
        public NAlert alert3;
        public NAlert alert4;

        public Block19260100()
        {
            f2Shina0 = new F2shina0();
            f2Shina1 = new F2shina1();
            f2Shina2 = new F2shina2();
            f2Shina3 = new F2shina3();
            f2Shina4 = new F2shina4();
            switch1 = new NSwitch(5);
            alert1 = new NAlert(11);
            alert2 = new NAlert(12);
            alert3 = new NAlert(13);
            alert4 = new NAlert(14);
        }

        public BitmapSource Image
        {
            get
            {
                return commandBitmap.loadBitmap(Properties.Resources._19_26_01_00);
            }
        }
    }
}
