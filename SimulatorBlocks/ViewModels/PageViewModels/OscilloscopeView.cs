using SimulatorBlocks.Models.BlockElements.Oscilloscope;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SimulatorBlocks.ViewModels.PageViewModels
{
    class OscilloscopeView
    : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged members
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion   
        Oscilloscope oscillModel;
        public OscilloscopeView()
        {
            oscillModel = new Oscilloscope();
        }
        public BitmapSource drawOscill
        {
            get { return oscillModel.imageOscil; }
        }
    }
}
