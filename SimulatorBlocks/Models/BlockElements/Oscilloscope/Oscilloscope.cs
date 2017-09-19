using SimulatorBlocks.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SimulatorBlocks.Models.BlockElements.Oscilloscope
{
    class Oscilloscope
    {
        public BitmapSource imageOscil
        {
            get { return commandBitmap.loadBitmap(Properties.Resources.osc1); }
        }
        public Oscilloscope()
        {

        }
    }
}
