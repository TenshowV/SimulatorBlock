using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SimulatorBlocks.Commands
{
    class ControlStatic
    {
        private static string switchName = String.Empty;
        private static int numberMode = 0;
        private static int errorList = 0;
        public static void CheckWork()
        {
            /* try
             {
                 if (NumberMode == 1) { return; }
                 if (NumberMode == 2)
                 {
                     ControlViewModel DC = (ControlViewModel)Application.Current.Windows[0].DataContext;
                     if (DC.ChooseCategory == 1) DC.runStepfirst();
                     if (DC.ChooseCategory == 2) DC.runStepSecond();
                     if (DC.ChooseCategory == 3) DC.runStepThird();
                     if (DC.ChooseCategory == 4) DC.runStepFourth();
                     //MessageBox.Show(DC.otherBlocks.ToString());
                     // MessageBox.Show("2");
                     return;
                 }
                 MessageBox.Show("Выбран некоректный режим!");
             }
             catch (Exception e) { }*/
        }

        public static void checkError()
        {
            MessageBox.Show("Ошибка! (Количество ошибок:" + (ErrorList + 1).ToString() + ")");
            ErrorList++;
            if (ErrorList > 3)
            {
                MessageBox.Show("Превышен лимит ошибок!");
                ErrorList = 0;
                var win = new MainWindow();
                win.Show();
                Application.Current.Windows[0].Close();

            }

        }
        public static string SwitchName
        {
            get
            {
                return switchName;
            }

            set
            {
                switchName = value;
            }
        }

        public static int NumberMode
        {
            get
            {
                return numberMode;
            }

            set
            {
                numberMode = value;
            }
        }

        public static int ErrorList
        {
            get
            {
                return errorList;
            }

            set
            {
                errorList = value;
            }
        }
    }
}
