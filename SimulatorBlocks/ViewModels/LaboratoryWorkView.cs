using SimulatorBlocks.Commands;
using SimulatorBlocks.Views.PageFrame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SimulatorBlocks.ViewModels
{
    class LaboratoryWorkView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public LaboratoryWorkView()
        {
            setcounter = 1;
        }
        private int setcounter;
        private int chooseCategory;
        public void setNullTitle()
        {
            switch (chooseCategory)
            {
                case 1:
                    {
                        infoTextTitle = "Установка порога срабатывания схемы\n автоматического контроля блока Ф8.03.05.00\n по порогу прохождения";

                        break;
                    }
                case 2:
                    {
                        infoTextTitle = "Установка порога срабатывания схемы\n автоматического контроля блока Ф8.03.05.00\n по порогу подавления";
                        break;
                    }
                case 3:
                    {
                        infoTextTitle = "Проверка работы схемы АРУ\nв блоке Ф8.03.05М";
                        this.infoText = "Включить процедуру 1С1 согласно ЕФ1.005.029 ИЭ2";
                        break;
                    }
                case 4:
                    {
                        infoTextTitle = "Проверка динамического диапозона блока Ф8.03.05М";
                        this.infoText = "Включить процедуру 1С1 согласно ЕФ1.005.029 ИЭ2";
                        break;
                    }
            }
        }
        private void CreatePoint()
        {
            if (chooseCategory == 1)
            {
                List<Point> newpoint = new List<Point>();
                newpoint.Add(new Point(20, 75)); newpoint.Add(new Point(35, 30)); newpoint.Add(new Point(60, 75)); newpoint.Add(new Point(80, 75));
                newpoint.Add(new Point(80, 30)); newpoint.Add(new Point(100, 30)); newpoint.Add(new Point(100, 75)); newpoint.Add(new Point(120, 75));
                newpoint.Add(new Point(135, 30)); newpoint.Add(new Point(160, 75)); newpoint.Add(new Point(180, 75));
                oscill.MyPoint = newpoint;
                oscill.TurnChangeOscill();
            }
        }
        /// <summary>
        /// Установка порога срабатывания схемы автоматического контроля блока Ф8.03.05.00 по сигналу прохождения
        /// </summary>
        private void runStepfirst()
        {
            switch (setcounter)
            {
                case 1:
                    {
                        this.infoText = "Подключим осциллограф, нажатием на верхней панели Осциллограф\n" +
                          "Нажать кнопку On|Off\n Выполнив все действия приступаем к следующему шагу";
                        if (oscill != null)
                        {
                            if (this.chooseRightBlocks == 2 && this.oscill.TurnOnOscill == true) { this.setCounter++; runStepfirst(); }
                        }
                        break;
                    }
                case 2:
                    {
                        this.infoText = "Осциллограф подключен следющими шагами будут:\n" +
                          "1) Выбрать блок Ф8.03.05М \n2) установить тумблер АРУ ВКЛ/ВЫКЛ в положение ВЫКЛ\nТумблер ПОДАВЛ/ПРОХОЖД в положение ПРОХОЖД"
                          + "\n3) Переключатель B2 в положение У17.\nВыполнив все действия приступаем к следующему шагу";
                        if (blockF8 != null)
                        {
                            if (blockF8.BlockF8Context.BlockF8.TumblerB2.Counter == 8)
                            {
                                if (oscill.TurnOnOscill == true)
                                {
                                    oscill.TurnChangeOscill();
                                    CreatePoint();
                                }
                                else CreatePoint();
                            }
                            if (this.chooseRightBlocks == 2 && blockF8.BlockF8Context.BlockF8.Switcher1.Flag == true && blockF8.BlockF8Context.BlockF8.Switcher2.Flag == true
                                && blockF8.BlockF8Context.BlockF8.TumblerB2.Counter == 8)
                            {

                                this.setCounter++;
                                runStepfirst();
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        this.infoText = "Мы наблюдаем 3 не задержанных и 3 задержанных импульса,\nзначит нажимаем на блоке Ф8.03.05М кнопку ПОРОГ У17\nДолжны наблюдать уменьшение амплитуды импульсов в полтора-два раза."
                            + "\n Выполнив все действия приступаем к следующему шагу";
                        if (blockF8.BlockF8Context.BlockF8.ButtonU17.Flag == true) { this.setCounter++; runStepfirst(); }
                        break;
                    }
                case 4:
                    {
                        this.infoText = "вращая ось резистора R32 на субблоке У17, добейтесь начала свечения светодиодов КАНАЛ С1 ОТКАЗ и «03.05», "
                            + "отпустите кнопку; если светодиоды мерцают, то вращением оси R32 по часовой стрелке добейтесь устойчивого отсутствия свечения;";

                        break;
                    }

            }
        }
        /// <summary>
        /// Установка порога срабатывания схемы автоматического контроля блока Ф8.03.05.00  по сигналу подавлении
        /// </summary>
        private void runStepSecond()
        {
            switch (this.setcounter)
            {
                case 1:
                    {
                        this.infoText = "Подключим осциллограф, нажатием на верхней панели Осциллограф\n" +
                          "Выставить длительность развертки 20мкс/дел\n Выполнив все действия приступаем к следующему шагу";

                        if (this.chooseRightBlocks == 2) { this.setCounter++; runStepSecond(); }
                        break;
                    }
                case 2:
                    {
                        this.infoText = "Осциллограф подключен следющими шагами будут:\n" +
                          "1) Выбрать блок Ф8.03.05М \n2) установить тумблер АРУ ВКЛ/ВЫКЛ в положение ВКЛ\n тумблер ПОДАВЛ/ПРОХОЖД в положение ПОДАВ "
                          + "\n Выполнив все действия приступаем к следующему шагу";
                        if (this.chooseRightBlocks == 2 && blockF8.BlockF8Context.BlockF8.Switcher1.Flag == true && blockF8.BlockF8Context.BlockF8.Switcher2.Flag == true)
                        {
                            this.setCounter++; runStepSecond();
                        }
                        break;
                    }
                case 3:
                    {
                        this.infoText = "Переходим к блоку 19.26.01,\nПосле нажатия на соответствующую кнопку в верхней панели\nТумблер СИНХР поставить в положение СИНХР3\nМы должны заметить после импульсов следуют остаточные сигналы."
                            + "\n Выполнив все действия приступаем к следующему шагу";
                        if (block1926.datacontext.Block19260100.f2Shina3.Counter == 6)
                        {
                            //Запуск осциллографа
                            this.setCounter++; runStepSecond();
                        }
                        break;
                    }
                case 4:
                    {
                        this.infoText = "На блоке Ф8.03.05М нажмем кнопку ПОРОГ У17\nДолжны наблюдать возрастание остаточных сигналов";
                        if (blockF8.BlockF8Context.BlockF8.ButtonU17.Flag == false)
                        {
                            //Нужно увеличение остаточных сигналов
                            this.setCounter++;
                            runStepSecond();
                        }
                        break;
                    }
                case 5:
                    {
                        this.infoText = "вращая ось резистора R4 на субблоке У17, добейтесь начала мерцания светодиодов КАНАЛ С1 ОТКАЗ и «03.05», "
                            + "отпустите кнопку ПОРОГ У17";

                        break;
                    }
            }
        }
        /// <summary>
        /// Проверка работоспособности схем АРУ
        /// </summary>
        private void runStepThird()
        {
            /*switch (setcounter)
            {
                case 1:
                    {
                        this.infoText = "Перевести переключатель в положение 'РЕГЛ КОНТР'";
                        block1903.block19035.commandchangeAlert1();
                        if (this.block1903.block19035.Block190350.Switch3.Flag == true)
                        {
                            this.setCounter++;
                            this.runStepThird();
                        }
                        break;
                    }
                case 2:
                    {
                        this.infoText = "Перейдите к блоку Ф8.03.05 и переключить тумблер B4 в положение С1";
                        if (this.blockF8.BlockF8Context.BlockF8.TumblerB4.Counter == 2)
                        {
                            this.blockF8.BlockF8Context.BlockF8.Nalerts6.commandchangeAlertControl();//Нужно закомментить все аллерты
                            this.setCounter++;
                            this.runStepThird();
                        }
                        break;
                    }
                case 3:
                    {
                        this.infoText = "Перейдите к блоку 19.60.00.00 и установить значение амперметра '03.05'";
                        if (this.block1960.datacontext.Block19600000.f3shina.Counter == 5)
                        {
                            this.setCounter++;
                            this.runStepThird();
                        }
                        break;
                    }
                case 4:
                    {
                        this.infoText = "Блок Ф8.03.05М переключатель АРУ в положение ВКЛ\n Тумблер В1 в положение У8(I)~У9";
                        if (blockF8.BlockF8Context.BlockF8.Switcher2.Flag = true &&
                            blockF8.BlockF8Context.BlockF8.Shina.Counter == 5)
                        {
                            this.setcounter++;
                            this.runStepThird();
                        }
                        break;
                    }
                case 5:
                    {
                        this.infoText = "Пройдем во внутреннюю часть блока Ф8.03.05М и \nна субблоке У9 будем регулировать сопротивление R9\n"
                            + "в значения от 45~55 (мА)";
                        if (Convert.ToInt32(blockF8.BlockF8Context.UB8.UndF8.reVR9) <= 55
                            && Convert.ToInt32(blockF8.BlockF8Context.UB8.UndF8.reVR9) >= 45)
                        {
                            this.setcounter++;
                            this.runStepThird();
                        }
                        break;
                    }
                case 6:
                    {
                        this.infoText = "Переключим тумблер В1 на блоке Ф8.03.05М на субблок У10/II/У9"
                            + "\nПройдем во внутреннюю часть блока Ф8.03.05М и \nна субблоке У9 будем регулировать сопротивление R19\n"
                            + "в значения от 45~55 (мА)";
                        if (blockF8.Blockf8.BlockF8.Tumbler1.Counter == 6 &&
                            Convert.ToInt32(blockF8.Blockf8.UB8.UndF8.reVR19) <= 55
                            && Convert.ToInt32(blockF8.Blockf8.UB8.UndF8.reVR19) >= 45)
                        {
                            this.setcounter++;
                            this.runStepThird();
                        }
                        break;
                    }
                case 7:
                    {
                        this.infoText = "Переключим тумблер В1 на блоке Ф8.03.05М на субблок У8/II/У9"
                            + "\nПройдем во внутреннюю часть блока Ф8.03.05М и \nна субблоке У9 будем регулировать сопротивление R10\n"
                            + "в значения от 45~55 (мА)";
                        if (blockF8.Blockf8.BlockF8.Tumbler1.Counter == 7 &&
                            Convert.ToInt32(blockF8.Blockf8.UB8.UndF8.reVR19) <= 55
                            && Convert.ToInt32(blockF8.Blockf8.UB8.UndF8.reVR19) >= 45)
                        {
                            this.setcounter++;
                            this.runStepThird();
                        }
                        break;
                    }
                case 8:
                    {
                        this.infoText = "Переключим тумблер В1 на блоке Ф8.03.05М на субблок У10/I/У9"
                            + "\nПройдем во внутреннюю часть блока Ф8.03.05М и \nна субблоке У9 будем регулировать сопротивление R20\n"
                            + "в значения от 45~55 (мА)";
                        if (blockF8.Blockf8.BlockF8.Tumbler1.Counter == 8 &&
                            Convert.ToInt32(blockF8.Blockf8.UB8.UndF8.reVR19) <= 55
                            && Convert.ToInt32(blockF8.Blockf8.UB8.UndF8.reVR19) >= 45)
                        {
                            this.setcounter++;
                            this.runStepThird();
                        }
                        break;
                    }
                case 9:
                    {
                        this.infoText = "Переключим тумблер В1 на блоке Ф8.03.05М на субблок У8/I/У9";
                        this.infoText += "\nПройдем во внутреннюю часть блока Ф8.03.05М и \nрегулируем усил 1 \n"
                            + "в значения от 40~60 (мА)";
                        if (blockF8.Blockf8.BlockF8.Tumbler1.Counter == 5 &&
                            Convert.ToInt32(blockF8.Blockf8.UB8.UndF8.reVR9) <= 60
                            && Convert.ToInt32(blockF8.Blockf8.UB8.UndF8.reVR9) >= 40)
                        {
                            this.setcounter++;
                            this.runStepThird();
                        }
                        break;
                    }
                case 10:
                    {
                        this.infoText = "Переключим тумблер В1 на блоке Ф8.03.05М на субблок У10/II/У9"
                            + "\nПройдем во внутреннюю часть блока Ф8.03.05М и \nрегулируем усил 2\n"
                            + "в значения от 40~60 (мА)";
                        if (blockF8.Blockf8.BlockF8.Tumbler1.Counter == 6 &&
                            Convert.ToInt32(blockF8.Blockf8.UB8.UndF8.reVR19) <= 60
                            && Convert.ToInt32(blockF8.Blockf8.UB8.UndF8.reVR19) >= 40)
                        {
                            this.setcounter++;
                            this.runStepThird();
                        }
                        break;
                    }
                case 11:
                    {
                        this.infoText = "Переключим тумблер В1 на блоке Ф8.03.05М на субблок У8/II/У9"
                            + "\nПройдем во внутреннюю часть блока Ф8.03.05М и \nрегулируем усил 3\n"
                            + "в значения от 40~60 (мА)";
                        if (blockF8.Blockf8.BlockF8.Tumbler1.Counter == 7 &&
                            Convert.ToInt32(blockF8.Blockf8.UB8.UndF8.reVR19) <= 60
                            && Convert.ToInt32(blockF8.Blockf8.UB8.UndF8.reVR19) >= 40)
                        {
                            this.setcounter++;
                            this.runStepThird();
                        }
                        break;
                    }
                case 12:
                    {
                        this.infoText = "Переключим переключатель В1 на блоке Ф8.03.05М на субблок У10/I/У9"
                            + "\nПройдем во внутреннюю часть блока Ф8.03.05М и \nрегулируем усил 4\n"
                            + "в значения от 40~60 (мА)";
                        if (blockF8.BlockF8Context.BlockF8.Shina.Counter == 8 &&
                            Convert.ToInt32(blockF8.Blockf8.UB8.UndF8.reVR19) <= 60
                            && Convert.ToInt32(blockF8.Blockf8.UB8.UndF8.reVR19) >= 40)
                        {
                            this.setcounter++;
                            this.runStepThird();
                        }
                        break;
                    }
            }*/
        }
        /// <summary>
        /// Проверка динамического диапозона блока Ф8.03.05М
        /// </summary>
        private void runStepFourth()
        {
            switch (setcounter)
            {
                case 1:
                    {
                        this.infoText = "Пройдем к блоку 19.03.50 и установим переключатель\n"
                            + "ШУМ/УСТР17 в положение УСТР17\nПереключатель ВИД РАБОТЫ в положение СИГН/шум\n";
                        if (block1903.block19035.Block190350.Switch2.Flag == false
                            && block1903.block19035.Block190350.f1Tumbler0.Counter == 2)
                        {
                            setcounter++; this.runStepFourth();
                        }
                        break;
                    }
                case 2:
                    {
                        this.infoText = "Сейчас переключатель ВЫХОД в положение МП\n"
                            + "Переключатели СИГН[АП]/ШУМ,ДБ , левый в положение 4, правый в положение 30";
                        if (block1903.block19035.Block190350.f1shina.Counter == 4 &&
                            block1903.block19035.Block190350.f1Tumbler10.Counter == 5 &&
                            block1903.block19035.Block190350.f1Tumbler20.Counter == 4)
                        {
                            setcounter++; this.runStepFourth();
                        }
                        break;
                    }
                case 3:
                    {
                        this.infoText = "Перейдем к блоку 19.26.01 и \nпереключим левый тумблер КОНТР СИГНАЛОВ в СИНХР1";
                        if (block1926.datacontext.Block19260100.f2Shina3.Counter == 4)
                        {
                            this.setcounter++; this.runStepFourth();
                        }
                        break;
                    }
                case 4:
                    {
                        this.infoText = "Включим осциллограф и перейдем к блоку Ф8.03.05М и переключим тумблер B2 в положение У20";
                        if (blockF8.BlockF8Context.BlockF8.TumblerB2.Counter == 2 && chooseRightBlocks == 2)
                        {
                            this.setcounter++; this.runStepFourth();
                        }
                        break;
                    }
                case 5:
                    {
                        //Запуск осциллографа
                        this.infoText = "Включим блок 19.03.50 и переключатели СИГН[АП]/ШУМ,ДБ \nлевый переключатель в положение 0"
                            + "\nправый переключатель в положение 20";
                        if (block1903.block19035.Block190350.f1Tumbler10.Counter == 1 &&
                            block1903.block19035.Block190350.f1Tumbler20.Counter == 3)
                        {
                            this.setcounter++; this.runStepFourth();
                        }
                        break;
                    }
                case 6:
                    {
                        this.infoText = "Во внутренней части блока Ф8.03.05М\n регулировать резистор R2 субблока У20"
                            + "";
                        //Проверка нужного положения осциллографа
                        break;
                    }
            }
        }
        /// <summary>
        /// Проверка ограничения входного импульса возбуждения в блоке Ф8.03.05М
        /// </summary>
        private void runStepFirth()
        {

        }

        private int chooseLeftBlocks = 1;
        private BlockF8 blockF8 = null;
        private Block19035 block1903 = null;
        private Block1926 block1926 = null;
        private int chooseRightBlocks = 1;
        private Block1960 block1960 = null;
        private Oscilloscope oscill = null;

        private string infotextTitle;
        public string infoTextTitle
        {
            get { return infotextTitle; }
            set { infotextTitle = value; OnPropertyChanged("infoTextTitle"); }
        }

        private string infotext;
        public string infoText
        {
            get { return infotext; }
            set { infotext = value; OnPropertyChanged(); }
        }
        public ICommand runBlockF8
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    if (blockF8 == null)
                    {
                        blockF8 = new BlockF8();
                        chooseLeftBlocks = 1;
                    }
                    else
                    {
                        chooseLeftBlocks = 1;
                    }
                    OnPropertyChanged("leftBlock");
                }));
            }
        }
        public ICommand runBlock1903
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    if (block1903 == null)
                    {
                        block1903 = new Block19035();
                        chooseLeftBlocks = 2;
                    }
                    else
                    {
                        chooseLeftBlocks = 2;
                    }
                    OnPropertyChanged("leftBlock");
                }));
            }
        }
        public ICommand runBlock1926
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    if (block1926 == null)
                    {
                        block1926 = new Block1926();
                        chooseLeftBlocks = 3;
                        GC.Collect();
                    }
                    else
                    {
                        chooseLeftBlocks = 3;
                        GC.Collect();
                    }
                    OnPropertyChanged("leftBlock");
                }));
            }
        }
        public ICommand runOscill
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {
                    if (chooseRightBlocks == 1)
                    {
                        if (oscill == null)
                        {
                            oscill = new Oscilloscope();
                            chooseRightBlocks = 2;
                            GC.Collect();
                        }
                        else
                        {
                            chooseRightBlocks = 2;
                            GC.Collect();
                        }
                    }
                    else
                    {
                        if (block1960 == null)
                        {
                            block1960 = new Block1960();
                            chooseRightBlocks = 1;
                            GC.Collect();
                        }
                        else
                        {
                            chooseRightBlocks = 1;
                            GC.Collect();
                        }
                    }
                    OnPropertyChanged("otherBlocks");
                }));
            }
        }

        /// <summary>
        /// Команда для кнопки следующего шага
        /// </summary> 
        public ICommand NextStep
        {
            get
            {
                return new delegateCommand(new Action(() =>
                {

                    switch (chooseCategory)
                    {
                        case 1:
                            {
                                runStepfirst();
                                break;
                            }
                        case 2:
                            {
                                runStepSecond();
                                break;
                            }
                        case 3:
                            {
                                runStepThird();
                                break;
                            }
                        case 4:
                            {
                                runStepFourth();
                                break;
                            }
                    }
                }));
            }
        }
        public int setCounter
        {
            get { return setcounter; }
            set { setcounter = value; }
        }
        public int ChooseCategory
        {
            set { chooseCategory = value; }
        }
        public Page leftBlock
        {
            get
            {
                switch (chooseLeftBlocks)
                {
                    case 1: return blockF8;
                    case 2: return block1903;
                    case 3: return block1926;
                    default: return null;
                }
            }
        }
        public Page otherBlocks
        {
            get
            {
                switch (chooseRightBlocks)
                {
                    case 1: return block1960;
                    case 2: return oscill;
                    default: return null;
                }
            }
        }
    }
}
