using SimulatorBlocks.Commands;
using SimulatorBlocks.Models.Block19260100;
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
    class Block192601View
    : INotifyPropertyChanged
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
        private Block19260100 block;

        public Block192601View()
        {
            block = new Block19260100();
        }

        public ImageSource drawBlock
        {
            get
            {
                return block.Image;
            }
        }

        public bool commandchangeF2shina0()
        {
            bool f = false;
            if (block.f2Shina0.Counter >= 8) block.f2Shina0.Flag = false;
            else if (block.f2Shina0.Counter <= 1) block.f2Shina0.Flag = true;

            if (block.f2Shina0.Flag == true)
            {
                block.f2Shina0.Counter++;
                f = true;
            }
            else
            {
                block.f2Shina0.Counter--;
                f = true;
            }
            OnPropertyChanged("drawF2Shina0");
            return f;
        }

        public ImageSource drawF2Shina0
        {
            get { return block.f2Shina0.f2Shina0; }
        }

        public ICommand changeF2Shina0
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeF2shina0();
                    GC.Collect();
                }));
            }
        }

        public bool commandchangeF2shina1()
        {
            bool f = false;
            if (block.f2Shina1.Counter >= 12) block.f2Shina1.Flag = false;
            else if (block.f2Shina1.Counter <= 1) block.f2Shina1.Flag = true;

            if (block.f2Shina1.Flag == true)
            {
                block.f2Shina1.Counter++;
                f = true;
            }
            else
            {
                block.f2Shina1.Counter--;
                f = true;
            }
            OnPropertyChanged("drawF2Shina1");
            return f;
        }

        public ImageSource drawF2Shina1
        {
            get { return block.f2Shina1.f2Shina1; }
        }

        public ICommand changeF2Shina1
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeF2shina1();
                    GC.Collect();
                }));
            }
        }

        public bool commandchangeF2shina2()
        {
            bool f = false;
            if (block.f2Shina2.Counter >= 8) block.f2Shina2.Flag = false;
            else if (block.f2Shina2.Counter <= 1) block.f2Shina2.Flag = true;

            if (block.f2Shina2.Flag == true)
            {
                block.f2Shina2.Counter++;
                f = true;
            }
            else
            {
                block.f2Shina2.Counter--;
                f = true;
            }
            OnPropertyChanged("drawF2Shina2");
            return f;
        }

        public ImageSource drawF2Shina2
        {
            get { return block.f2Shina2.f2Shina2; }
        }

        public ICommand changeF2Shina2
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeF2shina2();
                    GC.Collect();
                }));
            }
        }

        public bool commandchangeF2shina3()
        {
            bool f = false;
            if (block.f2Shina3.Counter >= 11) block.f2Shina3.Flag = false;
            else if (block.f2Shina3.Counter <= 1) block.f2Shina3.Flag = true;

            if (block.f2Shina3.Flag == true)
            {
                block.f2Shina3.Counter++;
                f = true;
            }
            else
            {
                block.f2Shina3.Counter--;
                f = true;
            }
            OnPropertyChanged("drawF2Shina3");
            return f;
        }

        public ImageSource drawF2Shina3
        {
            get { return block.f2Shina3.f2Shina3; }
        }

        public ICommand changeF2Shina3
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeF2shina3();
                    GC.Collect();
                }));
            }
        }

        public bool commandchangeF2shina4()
        {
            bool f = false;
            if (block.f2Shina4.Counter >= 12) block.f2Shina4.Flag = false;
            else if (block.f2Shina4.Counter <= 1) block.f2Shina4.Flag = true;

            if (block.f2Shina4.Flag == true)
            {
                block.f2Shina4.Counter++;
                f = true;
            }
            else
            {
                block.f2Shina4.Counter--;
                f = true;
            }
            OnPropertyChanged("drawF2Shina4");
            return f;
        }

        public ImageSource drawF2Shina4
        {
            get { return block.f2Shina4.f2Shina4; }
        }

        public ICommand changeF2Shina4
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeF2shina4();
                    GC.Collect();
                }));
            }
        }

        public bool commandchangeSwitch1()
        {
            bool f = false;
            if (block.switch1.Flag == true)
            {
                block.switch1.Flag = false;
                f = true;
            }
            else if (block.switch1.Flag == false)
            {
                block.switch1.Flag = true;
                f = true;
            }
            OnPropertyChanged("drawSwitch1");
            return f;
        }

        public ImageSource drawSwitch1
        {
            get { return block.switch1.switchers; }
        }

        public ICommand changeSwitch1
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeSwitch1();
                }));
            }
        }

        public bool commandchangeAlert1()
        {
            bool f = false;
            if (block.alert1.Flag == true)
            {
                block.alert1.Flag = false;
                f = true;
            }
            else if (block.alert1.Flag == false)
            {
                block.alert1.Flag = true;
                f = true;
            }
            OnPropertyChanged("drawAlert1");
            return f;
        }

        public ImageSource drawAlert1
        {
            get { return block.alert1.alerts; }
        }

        public ICommand changeAlert1
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeAlert1();
                }));
            }
        }

        public bool commandchangeAlert2()
        {
            bool f = false;
            if (block.alert2.Flag == true)
            {
                block.alert2.Flag = false;
                f = true;
            }
            else if (block.alert2.Flag == false)
            {
                block.alert2.Flag = true;
                f = true;
            }
            OnPropertyChanged("drawAlert2");
            return f;
        }

        public ImageSource drawAlert2
        {
            get { return block.alert2.alerts; }
        }

        public ICommand changeAlert2
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeAlert2();
                }));
            }
        }

        public bool commandchangeAlert3()
        {
            bool f = false;
            if (block.alert3.Flag == true)
            {
                block.alert3.Flag = false;
                f = true;
            }
            else if (block.alert3.Flag == false)
            {
                block.alert3.Flag = true;
                f = true;
            }
            OnPropertyChanged("drawAlert3");
            return f;
        }

        public ImageSource drawAlert3
        {
            get { return block.alert3.alerts; }
        }

        public ICommand changeAlert3
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeAlert3();
                }));
            }
        }

        public bool commandchangeAlert4()
        {
            bool f = false;
            if (block.alert4.Flag == true)
            {
                block.alert4.Flag = false;
                f = true;
            }
            else if (block.alert4.Flag == false)
            {
                block.alert4.Flag = true;
                f = true;
            }
            OnPropertyChanged("drawAlert4");
            return f;
        }

        public ImageSource drawAlert4
        {
            get { return block.alert4.alerts; }
        }

        public ICommand changeAlert4
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeAlert4();
                }));
            }
        }
        internal Block19260100 Block19260100
        {
            get
            {
                return block;
            }
        }
    }
}
