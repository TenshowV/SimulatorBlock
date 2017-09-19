using SimulatorBlocks.Commands;
using SimulatorBlocks.Models.BlockElements.AllModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SimulatorBlocks.Models.Block190350
{
    class Block190350
    {
        public F1Shina f1shina;
        public F1tumbler0 f1Tumbler0;
        public F1tumbler1 f1Tumbler10;
        public F1tumbler6 f1Tumbler11;
        public F1tumbler2 f1Tumbler20;
        public F1tumbler7 f1Tumbler21;
        public F1tumbler3 f1Tumbler3;
        public F1tumbler4 f1Tumbler4;
        public F1tumbler5 f1Tumbler5;
        public NSwitch Switch1;
        public NSwitch Switch2;
        public NSwitch Switch3;
        public NAlert Alert1;
        public NAlert Alert2;
        public NAlert Alert3;
        public NAlert Alert4;

        public Block190350()
        {
            f1shina = new F1Shina();
            f1Tumbler0 = new F1tumbler0();
            f1Tumbler10 = new F1tumbler1();
            f1Tumbler11 = new F1tumbler6();
            f1Tumbler20 = new F1tumbler2();
            f1Tumbler21 = new F1tumbler7();
            f1Tumbler3 = new F1tumbler3();
            f1Tumbler4 = new F1tumbler4();
            f1Tumbler5 = new F1tumbler5();
            Switch1 = new NSwitch(3);
            Switch2 = new NSwitch(2);
            Switch3 = new NSwitch(1);
            Alert1 = new NAlert(1);
            Alert2 = new NAlert(2);
            Alert3 = new NAlert(3);
            Alert4 = new NAlert(4);
        }

        public BitmapSource Image
        {
            get
            {
                return commandBitmap.loadBitmap(Properties.Resources._19_03_50_00);
            }
        }
    }
}
