using SimulatorBlocks.Commands;
using SimulatorBlocks.Models.BlockElements.AllModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SimulatorBlocks.Models.BlockElements.Block1960
{
    class Block1960Model
    {
        public F3Shina f3shina;
        public NButton btn1;
        public NButton btn2;

        public Block1960Model()
        {
            f3shina = new F3Shina();
            btn1 = new NButton(1);
            btn2 = new NButton(2);
        }

        public BitmapSource Image
        {
            get
            {
                return commandBitmap.loadBitmap(Properties.Resources._19_60_00_00);
            }
        }
    }
}
