using SimulatorBlocks.Commands;
using SimulatorBlocks.Models;
using SimulatorBlocks.Models.Block190350;
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
    class Block190350View
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

        private Block190350 block190350;

        public Block190350View()
        {
            block190350 = new Block190350();
        }

        public ImageSource drawBlock
        {
            get
            {
                return block190350.Image;
            }
        }

        public bool commandchangeF1shina()
        {
            bool f = false;
            if (block190350.f1shina.Counter >= 6) block190350.f1shina.Flag = false;
            else if (block190350.f1shina.Counter <= 1) block190350.f1shina.Flag = true;

            if (block190350.f1shina.Flag == true)
            {
                block190350.f1shina.Counter++;
                f = true;
            }
            else
            {
                block190350.f1shina.Counter--;
                f = true;
            }
            OnPropertyChanged("drawShina");
            return f;
        }

        public ImageSource drawShina
        {
            get { return block190350.f1shina.f1Shina; }
        }

        public ICommand changeShina
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeF1shina();
                    GC.Collect();
                }));
            }
        }

        public bool commandchangeF1Tumbler0()
        {
            bool f = false;
            if (block190350.f1Tumbler0.Counter >= 5) block190350.f1Tumbler0.Flag = false;
            else if (block190350.f1Tumbler0.Counter <= 1) block190350.f1Tumbler0.Flag = true;

            if (block190350.f1Tumbler0.Flag == true)
            {
                block190350.f1Tumbler0.Counter++;
                f = true;
            }
            else
            {
                block190350.f1Tumbler0.Counter--;
                f = true;
            }
            OnPropertyChanged("drawF1Tumbler0");
            return f;
        }

        public ImageSource drawF1Tumbler0
        {
            get { return block190350.f1Tumbler0.f1Tumbler0; }
        }

        public ICommand changeF1Tumbler0
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeF1Tumbler0();
                    GC.Collect();
                }));
            }
        }
        public bool commandchangeF1Tumbler10()
        {
            bool f = false;
            if (block190350.f1Tumbler10.Counter >= 11) block190350.f1Tumbler10.Flag = false;
            else if (block190350.f1Tumbler10.Counter <= 1) block190350.f1Tumbler10.Flag = true;

            if (block190350.f1Tumbler10.Flag == true)
            {
                block190350.f1Tumbler10.Counter++;
                f = true;
            }
            else
            {
                block190350.f1Tumbler10.Counter--;
                f = true;
            }
            OnPropertyChanged("drawF1Tumbler10");
            return f;
        }

        public ImageSource drawF1Tumbler10
        {
            get { return block190350.f1Tumbler10.f1Tumbler1; }
        }

        public ICommand changeF1Tumbler10
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeF1Tumbler10();
                    GC.Collect();
                }));
            }
        }


        public bool commandchangeF1Tumbler11()
        {
            bool f = false;
            if (block190350.f1Tumbler11.Counter >= 11) block190350.f1Tumbler11.Flag = false;
            else if (block190350.f1Tumbler11.Counter <= 1) block190350.f1Tumbler11.Flag = true;

            if (block190350.f1Tumbler11.Flag == true)
            {
                block190350.f1Tumbler11.Counter++;
                f = true;
            }
            else
            {
                block190350.f1Tumbler11.Counter--;
                f = true;
            }
            OnPropertyChanged("drawF1Tumbler11");
            return f;
        }

        public ImageSource drawF1Tumbler11
        {
            get { return block190350.f1Tumbler11.f1Tumbler6; }
        }

        public ICommand changeF1Tumbler11
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeF1Tumbler11();
                    GC.Collect();
                }));
            }
        }

        public bool commandchangeF1Tumbler20()
        {
            bool f = false;
            if (block190350.f1Tumbler20.Counter >= 4) block190350.f1Tumbler20.Flag = false;
            else if (block190350.f1Tumbler20.Counter <= 1) block190350.f1Tumbler20.Flag = true;

            if (block190350.f1Tumbler20.Flag == true)
            {
                block190350.f1Tumbler20.Counter++;
                f = true;
            }
            else
            {
                block190350.f1Tumbler20.Counter--;
                f = true;
            }
            OnPropertyChanged("drawF1Tumbler20");
            return f;
        }

        public ImageSource drawF1Tumbler20
        {
            get { return block190350.f1Tumbler20.f1Tumbler2; }
        }

        public ICommand changeF1Tumbler20
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeF1Tumbler20();
                    GC.Collect();
                }));
            }
        }
        public bool commandchangeF1Tumbler21()
        {
            bool f = false;
            if (block190350.f1Tumbler21.Counter >= 4) block190350.f1Tumbler21.Flag = false;
            else if (block190350.f1Tumbler21.Counter <= 1) block190350.f1Tumbler21.Flag = true;

            if (block190350.f1Tumbler21.Flag == true)
            {
                block190350.f1Tumbler21.Counter++;
                f = true;
            }
            else
            {
                block190350.f1Tumbler21.Counter--;
                f = true;
            }
            OnPropertyChanged("drawF1Tumbler21");
            return f;
        }

        public ImageSource drawF1Tumbler21
        {
            get { return block190350.f1Tumbler21.f1Tumbler7; }
        }

        public ICommand changeF1Tumbler21
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeF1Tumbler21();
                    GC.Collect();
                }));
            }
        }
        public bool commandchangeF1Tumbler3()
        {
            bool f = false;
            if (block190350.f1Tumbler3.Counter >= 8) block190350.f1Tumbler3.Flag = false;
            else if (block190350.f1Tumbler3.Counter <= 1) block190350.f1Tumbler3.Flag = true;

            if (block190350.f1Tumbler3.Flag == true)
            {
                block190350.f1Tumbler3.Counter++;
                f = true;
            }
            else
            {
                block190350.f1Tumbler3.Counter--;
                f = true;
            }
            OnPropertyChanged("drawF1Tumbler3");
            return f;
        }

        public ImageSource drawF1Tumbler3
        {
            get { return block190350.f1Tumbler3.f1Tumbler3; }
        }

        public ICommand changeF1Tumbler3
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeF1Tumbler3();
                    GC.Collect();
                }));
            }
        }
        public bool commandchangeF1Tumbler4()
        {
            bool f = false;
            if (block190350.f1Tumbler4.Counter >= 3) block190350.f1Tumbler4.Flag = false;
            else if (block190350.f1Tumbler4.Counter <= 1) block190350.f1Tumbler4.Flag = true;

            if (block190350.f1Tumbler4.Flag == true)
            {
                block190350.f1Tumbler4.Counter++;
                f = true;
            }
            else
            {
                block190350.f1Tumbler4.Counter--;
                f = true;
            }
            OnPropertyChanged("drawF1Tumbler4");
            return f;
        }

        public ImageSource drawF1Tumbler4
        {
            get { return block190350.f1Tumbler4.f1Tumbler4; }
        }

        public ICommand changeF1Tumbler4
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeF1Tumbler4();
                    GC.Collect();
                }));
            }
        }
        public bool commandchangeF1Tumbler5()
        {
            bool f = false;
            if (block190350.f1Tumbler5.Counter >= 11) block190350.f1Tumbler5.Flag = false;
            else if (block190350.f1Tumbler5.Counter <= 1) block190350.f1Tumbler5.Flag = true;

            if (block190350.f1Tumbler5.Flag == true)
            {
                block190350.f1Tumbler5.Counter++;
                f = true;
            }
            else
            {
                block190350.f1Tumbler5.Counter--;
                f = true;
            }
            OnPropertyChanged("drawF1Tumbler5");
            return f;
        }

        public ImageSource drawF1Tumbler5
        {
            get { return block190350.f1Tumbler5.f1Tumbler5; }
        }

        public ICommand changeF1Tumbler5
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeF1Tumbler5();
                    GC.Collect();
                }));
            }
        }
        public bool commandchangeSwitch1()
        {
            bool f = false;
            if (block190350.Switch1.Flag == true)
            {
                block190350.Switch1.Flag = false;
                f = true;
            }
            else if (block190350.Switch1.Flag == false)
            {
                block190350.Switch1.Flag = true;
                f = true;
            }
            OnPropertyChanged("drawSwitch1");
            return f;
        }

        public ImageSource drawSwitch1
        {
            get { return block190350.Switch1.switchers; }
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

        public bool commandchangeSwitch2()
        {
            bool f = false;
            if (block190350.Switch2.Flag == true)
            {
                block190350.Switch2.Flag = false;
                f = true;
            }
            else if (block190350.Switch2.Flag == false)
            {
                block190350.Switch2.Flag = true;
                f = true;
            }
            OnPropertyChanged("drawSwitch2");
            return f;
        }

        public ImageSource drawSwitch2
        {
            get { return block190350.Switch2.switchers; }
        }

        public ICommand changeSwitch2
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeSwitch2();
                }));
            }
        }

        public bool commandchangeSwitch3()
        {
            bool f = false;
            if (block190350.Switch3.Flag == true)
            {
                block190350.Switch3.Flag = false;
                f = true;
            }
            else if (block190350.Switch3.Flag == false)
            {
                block190350.Switch3.Flag = true;
                f = true;
            }
            OnPropertyChanged("drawSwitch3");
            return f;
        }

        public ImageSource drawSwitch3
        {
            get { return block190350.Switch3.switchers; }
        }

        public ICommand changeSwitch3
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    this.commandchangeSwitch3();
                }));
            }
        }


        public bool commandchangeAlert1()
        {
            bool f = false;
            if (block190350.Alert1.Flag == true)
            {
                block190350.Alert1.Flag = false;
                f = true;
            }
            else if (block190350.Alert1.Flag == false)
            {
                block190350.Alert1.Flag = true;
                f = true;
            }
            OnPropertyChanged("drawAlert1");
            return f;

        }

        public ImageSource drawAlert1
        {
            get { return block190350.Alert1.alerts; }
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
            if (block190350.Alert2.Flag == true)
            {
                block190350.Alert2.Flag = false;
                f = true;
            }
            else if (block190350.Alert2.Flag == false)
            {
                block190350.Alert2.Flag = true;
                f = true;
            }
            OnPropertyChanged("drawAlert2");
            return f;

        }

        public ImageSource drawAlert2
        {
            get { return block190350.Alert2.alerts; }
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
            if (block190350.Alert3.Flag == true)
            {
                block190350.Alert3.Flag = false;
                f = true;
            }
            else if (block190350.Alert3.Flag == false)
            {
                block190350.Alert3.Flag = true;
                f = true;
            }
            OnPropertyChanged("drawAlert3");
            return f;

        }

        public ImageSource drawAlert3
        {
            get { return block190350.Alert3.alerts; }
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
            if (block190350.Alert4.Flag == true)
            {
                block190350.Alert4.Flag = false;
                f = true;
            }
            else if (block190350.Alert4.Flag == false)
            {
                block190350.Alert4.Flag = true;
                f = true;
            }
            OnPropertyChanged("drawAlert4");
            return f;

        }

        public ImageSource drawAlert4
        {
            get { return block190350.Alert4.alerts; }
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

        internal Block190350 Block190350
        {
            get
            {
                return block190350;
            }
        }
    }
}
