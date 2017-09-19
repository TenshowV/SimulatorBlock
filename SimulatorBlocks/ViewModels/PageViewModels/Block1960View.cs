using SimulatorBlocks.Commands;
using SimulatorBlocks.Models.BlockElements.Block1960;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace SimulatorBlocks.ViewModels.PageViewModels
{
    class Block1960View : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                ControlStatic.SwitchName = name;
                ControlStatic.CheckWork();
                //MessageBox.Show(name);
                handler(this, new PropertyChangedEventArgs(name));
            }

        }

        private Block1960Model block;

        public Block1960View()
        {
            block = new Block1960Model();
        }

        public ImageSource drawBlock
        {
            get
            {
                return block.Image;
            }
        }

        public bool commandchangeF3shina()
        {
            bool f = false;
            if (block.f3shina.Counter >= 11) block.f3shina.Flag = false;
            else if (block.f3shina.Counter <= 1) block.f3shina.Flag = true;

            if (block.f3shina.Flag == true)
            {
                block.f3shina.Counter++;
                f = true;
            }
            else
            {
                block.f3shina.Counter--;
                f = true;
            }
            OnPropertyChanged("drawF3Shina");
            return f;
        }

        public ImageSource drawF3Shina
        {
            get { return block.f3shina.f3Shina; }
        }

        public ICommand changeF3Shina
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeF3shina();
                    GC.Collect();
                }));
            }
        }

        public bool commandchangeBut1()
        {
            bool f = false;
            if (block.btn1.Flag == false)
            {
                block.btn1.Flag = true;
                f = true;
            }
            else if (block.btn1.Flag == true)
            {
                block.btn1.Flag = false;
                f = true;
            }
            OnPropertyChanged("drawButton1");
            return f;
        }
        public ImageSource drawButton1
        {
            get
            { return block.btn1.models; }
        }
        public ICommand changeBut1
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeBut1();
                }));
            }
        }

        public bool commandchangeBut2()
        {
            bool f = false;
            if (block.btn2.Flag == false)
            {
                block.btn2.Flag = true;
                f = true;
            }
            else if (block.btn2.Flag == true)
            {
                block.btn2.Flag = false;
                f = true;
            }
            OnPropertyChanged("drawButton2");
            return f;
        }
        public ImageSource drawButton2
        {
            get
            { return block.btn2.models; }
        }
        public ICommand changeBut2
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeBut2();
                }));
            }
        }



        internal Block1960Model Block19600000
        {
            get
            {
                return block;
            }
        }
    }
}
