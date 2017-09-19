using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace SimulatorBlocks.Commands
{
    class commandBitmap
    {
        [System.Runtime.InteropServices.DllImport("gdi32")]
        static extern int DeleteObject(IntPtr o);

        /// <summary>
        /// Конвертация из Bitmap в BitmapSource
        /// </summary>
        /// <param BitmapSource="System.Drawing.Bitmap"></param>
        /// <returns></returns>
        public static BitmapSource loadBitmap(Bitmap source)
        {
            IntPtr ip = source.GetHbitmap();

            BitmapSource bs = null;
            try
            {

                bs = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(ip,
                   IntPtr.Zero, Int32Rect.Empty,
                   System.Windows.Media.Imaging.BitmapSizeOptions.FromEmptyOptions());
            }
            finally
            {
                DeleteObject(ip);
            }

            return bs;
        }
    }
}
