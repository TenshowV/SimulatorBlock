using SimulatorBlocks.Commands;
using SimulatorBlocks.Models.BlockElements.BlockF8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SimulatorBlocks.ViewModels.PageViewModels
{
    class BlockF8View : INotifyPropertyChanged
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
        public BlockF8View()
        {

        }
        internal BlockF8 BlockF8
        {
            get
            {
                return blockF8;
            }
        }
        private BlockF8 blockF8 = null;
        /// <summary>
        /// Отрисовка блока целиком
        /// </summary>
        public ImageSource drawBlock
        {
            get
            {
                if (blockF8 == null)
                {
                    blockF8 = new BlockF8();
                    return blockF8.ImageMainBlock;
                }
                else
                {
                    return blockF8.ImageMainBlock;
                }
            }
        }
        /// <summary>
        /// отрисовка переключателя Б2
        /// </summary>
        public BitmapSource drawTumbler
        {
            get
            { return blockF8.TumblerB2.tumblers; }
        }
        public ICommand changeTumbler
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    //ControlViewModel.helpF();
                    blockF8.TumblerB2.commandchangeTumbler();
                    OnPropertyChanged("drawTumbler");
                    GC.Collect();
                }));
            }
        }
        /// <summary>
        /// Отрисовка шины В1
        /// </summary>
        public BitmapSource drawShina
        {
            get
            { return blockF8.Shina.Shina; }
        }
        public ICommand changeShina
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    blockF8.Shina.commandchangeshina();
                    OnPropertyChanged("drawShina");
                    GC.Collect();
                }));
            }
        }
        /// <summary>
        /// ТУмблер ПРОХОЖД ПОДАВЛ
        /// </summary>
        public BitmapSource drawSwitcher1
        {
            get { return blockF8.Switcher1.switchers; }
        }
        public ICommand changeSwitcher1
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    blockF8.Switcher1.commandchangeSwitcher();
                    OnPropertyChanged("drawSwitcher1");
                }));
            }
        }
        /// <summary>
        /// ТУмблер АРУ
        /// </summary>
        public BitmapSource drawSwitcher2
        {
            get { return blockF8.Switcher2.switchers; }
        }
        public ICommand changeSwitcher2
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    blockF8.Switcher2.commandchangeSwitcher();
                    OnPropertyChanged("drawSwitcher2");
                }));
            }
        }
        ///<summary>
        ///Кнопка У17
        ///</summary>
        public ImageSource drawButtonU17
        {
            get
            {
                return blockF8.ButtonU17.models;
            }
        }
        public ICommand changeBut
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    blockF8.ButtonU17.commandchangeBut();
                    OnPropertyChanged("drawButtonU17");
                }));
            }
        }
        /// <summary>
        /// Тумблер В4
        /// </summary>
        public BitmapSource drawTumbler1
        {
            get { return blockF8.TumblerB4.tumblers; }
        }
        public ICommand changeTumbler1
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    blockF8.TumblerB4.commandchangeTumbler();
                    OnPropertyChanged("drawTumbler1");
                }));
            }
        }
    }
}
