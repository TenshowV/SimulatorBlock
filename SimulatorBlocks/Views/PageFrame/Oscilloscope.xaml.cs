using SimulatorBlocks.ViewModels.PageViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimulatorBlocks.Views.PageFrame
{
    /// <summary>
    /// Логика взаимодействия для Oscilloscope.xaml
    /// </summary>
    public partial class Oscilloscope : Page
    {
        /// <summary>
        /// Начальная точка (0.75) конечная (210.75)
        /// </summary>
        /// <param name="точки графика"></param>
        public List<Point> MyPoint
        {
            get { return point; }
            set { point = value; }
        }
        internal OscilloscopeView OscillContext
        {
            get
            {
                return this.oscillContext;
            }
        }
        public Oscilloscope()
        {
            InitializeComponent();
        }
        private double y0 = 75, x0 = 0, speed = 0.4;
        private List<Point> point;
        private int steps;
        private bool flag;

        public bool TurnOnOscill = false;
        public void TurnChangeOscill()
        {
            if (TurnOnOscill == false)
            {
                point = new List<Point>();
                point.Add(new Point(210, 75));

                TurnOnOscill = true;
                this.InitializeAnimation();
            }
            else
            {
                oscill.Children.Clear();
                TurnOnOscill = false;
            }
        }
        private void OnOrOff(object sender, RoutedEventArgs e)
        {
            this.TurnChangeOscill();
        }

        private void InitializeAnimation()
        {
            if (TurnOnOscill == false)
            {
                oscill.Children.Clear();
                point.Clear();
            }
            else
            {
                steps = 0; flag = true;
                Line lineShort = new Line();
                lineShort.X1 = x0; lineShort.Y1 = y0; lineShort.Y2 = y0; lineShort.X2 = x0;
                lineShort.StrokeThickness = 3; lineShort.Stroke = Brushes.White;
                DoubleAnimation animationLineShort = new DoubleAnimation();
                animationLineShort.From = x0; animationLineShort.To = point.ElementAt(steps).X;
                animationLineShort.Duration = TimeSpan.FromSeconds(speed);
                steps++;
                oscill.Children.Add(lineShort);
                animationLineShort.Completed += NextRunAnimation;
                lineShort.BeginAnimation(Line.X2Property, animationLineShort);
            }
        }
        private void NextRunAnimation(object sender, EventArgs e)
        {
            if (steps <= point.Count - 1)
            {
                Line lineShort = new Line();
                lineShort.X1 = point.ElementAt(steps - 1).X; lineShort.Y1 = point.ElementAt(steps - 1).Y;
                lineShort.Y2 = point.ElementAt(steps - 1).Y; lineShort.X2 = point.ElementAt(steps - 1).X;
                lineShort.StrokeThickness = 3; lineShort.Stroke = Brushes.White;
                DoubleAnimation animationLineShort = new DoubleAnimation();
                animationLineShort.Duration = TimeSpan.FromSeconds(speed);
                oscill.Children.Add(lineShort);
                animationLineShort.Completed += NextRunAnimation;
                if (flag == true)
                {
                    flag = false;
                    animationLineShort.From = point.ElementAt(steps - 1).Y; animationLineShort.To = point.ElementAt(steps).Y;
                    lineShort.BeginAnimation(Line.Y2Property, animationLineShort);
                }
                else
                {
                    flag = true;
                    animationLineShort.From = point.ElementAt(steps - 1).X; animationLineShort.To = point.ElementAt(steps).X;
                    lineShort.BeginAnimation(Line.X2Property, animationLineShort);
                }
                steps++;
            }
            else
            {
                oscill.Children.Clear();
                InitializeAnimation();
            }
        }
    }
}
