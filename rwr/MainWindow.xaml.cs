using System;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static rwr.MainWindow;
using static System.Net.Mime.MediaTypeNames;

namespace rwr
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Shapes.Ellipse ellipse1 = new System.Windows.Shapes.Ellipse();
        TextBlock textBlock1 = new TextBlock();

        System.Windows.Shapes.Ellipse ellipse2 = new System.Windows.Shapes.Ellipse();
        TextBlock textBlock2 = new TextBlock();

        System.Windows.Shapes.Ellipse ellipse3 = new System.Windows.Shapes.Ellipse();
        TextBlock textBlock3 = new TextBlock();

        System.Windows.Shapes.Ellipse ellipse4 = new System.Windows.Shapes.Ellipse();
        TextBlock textBlock4 = new TextBlock();

        System.Windows.Shapes.Ellipse ellipse5 = new System.Windows.Shapes.Ellipse();
        TextBlock textBlock5 = new TextBlock();

        int x1 = 10;
        int y1 = 130;
        int x2 = 10;
        int y2 = 130;
        int x3 = 10;
        int y3 = 130;
        int x4 = 10;
        int y4 = 130;
        int x5 = 10;
        int y5 = 130;

        int delay1 = 750;
        int delay2 = 1500;

        int r1 = 60;

        bool rwrtask = false;
        bool rwr01 = false;
        bool rwr02 = false;
        bool rwr03 = false;
        bool rwr04 = false;
        bool rwr05 = false;
        int mode = 1;

        Task task;
        Task task1;
        Task task2;
        Task task3;
        Task task4;
        Task task5;

        String rwrmp3_1 = "rwr.mp3";
        String rwrmp3_2 = "rwr.mp3";

        MediaPlayer player1;
        MediaPlayer player2;
        MediaPlayer player3;
        MediaPlayer player4;
        MediaPlayer player5;
        public MainWindow()
        {
            InitializeComponent();

            ellipse1.Stroke = Brushes.GreenYellow;
            ellipse1.StrokeThickness = 2;
            ellipse1.Height = 40;
            ellipse1.Width = 40;
            textBlock1.Text = "  ?";
            textBlock1.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(173, 255, 47));
            textBlock1.FontSize = 24;

            ellipse2.Stroke = Brushes.GreenYellow;
            ellipse2.StrokeThickness = 2;
            ellipse2.Height = 40;
            ellipse2.Width = 40;
            textBlock2.Text = "  ?";
            textBlock2.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(173, 255, 47));
            textBlock2.FontSize = 24;

            ellipse3.Stroke = Brushes.GreenYellow;
            ellipse3.StrokeThickness = 2;
            ellipse3.Height = 40;
            ellipse3.Width = 40;
            textBlock3.Text = "  ?";
            textBlock3.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(173, 255, 47));
            textBlock3.FontSize = 24;

            ellipse4.Stroke = Brushes.GreenYellow;
            ellipse4.StrokeThickness = 2;
            ellipse4.Height = 40;
            ellipse4.Width = 40;
            textBlock4.Text = "  ?";
            textBlock4.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(173, 255, 47));
            textBlock4.FontSize = 24;

            ellipse5.Stroke = Brushes.GreenYellow;
            ellipse5.StrokeThickness = 2;
            ellipse5.Height = 40;
            ellipse5.Width = 40;
            textBlock5.Text = "  ?";
            textBlock5.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromRgb(173, 255, 47));
            textBlock5.FontSize = 24;

            player1 = new MediaPlayer();
            player2 = new MediaPlayer();
            player3 = new MediaPlayer();
            player4 = new MediaPlayer();
            player5 = new MediaPlayer();

            task = new Task(rwr_draw);           
            task1 = new Task(rwr1);
            task2 = new Task(rwr2);
            task3 = new Task(rwr3);
            task4 = new Task(rwr4);
            task5 = new Task(rwr5);

            task.Start();
            task1.Start();
            task2.Start();
            task3.Start();
            task4.Start();
            task5.Start();
        }

        private void rwr_ref_Click(object sender, RoutedEventArgs e)
        {
            
            if (rwrtask)
            {
                rwrtask = false;
            }
            else
            {
                rwrtask= true;
            }
            


        }
        public void rwr_draw()
        {
            while (true)
            {
                if (!rwrtask)
                {
                    this.rwr_e1.Dispatcher.Invoke(new Action(() => { this.rwr_e1.Visibility = Visibility.Hidden; }));
                    this.rwr_e2.Dispatcher.Invoke(new Action(() => { this.rwr_e2.Visibility = Visibility.Hidden; }));
                    this.rwr_e3.Dispatcher.Invoke(new Action(() => { this.rwr_e3.Visibility = Visibility.Hidden; }));
                    this.rwr_e4.Dispatcher.Invoke(new Action(() => { this.rwr_e4.Visibility = Visibility.Hidden; }));
                    this.rwr_e5.Dispatcher.Invoke(new Action(() => { this.rwr_e5.Visibility = Visibility.Hidden; }));
                    player1.Dispatcher.Invoke(new Action(() => { player1.Volume = 0; }));
                    player2.Dispatcher.Invoke(new Action(() => { player2.Volume = 0; }));
                    player3.Dispatcher.Invoke(new Action(() => { player3.Volume = 0; }));
                    player4.Dispatcher.Invoke(new Action(() => { player4.Volume = 0; }));
                    player5.Dispatcher.Invoke(new Action(() => { player5.Volume = 0; }));
                }
                else if (mode == 1)
                {
                    this.rwr_e1.Dispatcher.Invoke(new Action(() => { this.rwr_e1.Visibility =Visibility.Visible; }));
                    this.rwr_e2.Dispatcher.Invoke(new Action(() => { this.rwr_e2.Visibility = Visibility.Hidden; }));
                    this.rwr_e3.Dispatcher.Invoke(new Action(() => { this.rwr_e3.Visibility = Visibility.Hidden; }));
                    this.rwr_e4.Dispatcher.Invoke(new Action(() => { this.rwr_e4.Visibility = Visibility.Hidden; }));
                    this.rwr_e5.Dispatcher.Invoke(new Action(() => { this.rwr_e5.Visibility = Visibility.Hidden; }));
                    player1.Dispatcher.Invoke(new Action(() => { player1.Volume = 0.5; }));
                    player2.Dispatcher.Invoke(new Action(() => { player2.Volume = 0; }));
                    player3.Dispatcher.Invoke(new Action(() => { player3.Volume = 0; }));
                    player4.Dispatcher.Invoke(new Action(() => { player4.Volume = 0; }));
                    player5.Dispatcher.Invoke(new Action(() => { player5.Volume = 0; }));
                }
                else if (mode == 2)
                {
                    this.rwr_e1.Dispatcher.Invoke(new Action(() => { this.rwr_e1.Visibility = Visibility.Visible; }));
                    this.rwr_e2.Dispatcher.Invoke(new Action(() => { this.rwr_e2.Visibility = Visibility.Visible; }));
                    this.rwr_e3.Dispatcher.Invoke(new Action(() => { this.rwr_e3.Visibility = Visibility.Hidden; }));
                    this.rwr_e4.Dispatcher.Invoke(new Action(() => { this.rwr_e4.Visibility = Visibility.Hidden; }));
                    this.rwr_e5.Dispatcher.Invoke(new Action(() => { this.rwr_e5.Visibility = Visibility.Hidden; }));
                    player1.Dispatcher.Invoke(new Action(() => { player1.Volume = 0.5; }));
                    player2.Dispatcher.Invoke(new Action(() => { player2.Volume = 0.5; }));
                    player3.Dispatcher.Invoke(new Action(() => { player3.Volume = 0; }));
                    player4.Dispatcher.Invoke(new Action(() => { player4.Volume = 0; }));
                    player5.Dispatcher.Invoke(new Action(() => { player5.Volume = 0; }));
                }
                else if (mode == 3)
                {
                    this.rwr_e1.Dispatcher.Invoke(new Action(() => { this.rwr_e1.Visibility = Visibility.Visible; }));
                    this.rwr_e2.Dispatcher.Invoke(new Action(() => { this.rwr_e2.Visibility = Visibility.Visible; }));
                    this.rwr_e3.Dispatcher.Invoke(new Action(() => { this.rwr_e3.Visibility = Visibility.Visible; }));
                    this.rwr_e4.Dispatcher.Invoke(new Action(() => { this.rwr_e4.Visibility = Visibility.Hidden; }));
                    this.rwr_e5.Dispatcher.Invoke(new Action(() => { this.rwr_e5.Visibility = Visibility.Hidden; }));
                    player1.Dispatcher.Invoke(new Action(() => { player1.Volume = 0.5; }));
                    player2.Dispatcher.Invoke(new Action(() => { player2.Volume = 0.5; }));
                    player3.Dispatcher.Invoke(new Action(() => { player3.Volume = 0.5; }));
                    player4.Dispatcher.Invoke(new Action(() => { player4.Volume = 0; }));
                    player5.Dispatcher.Invoke(new Action(() => { player5.Volume = 0; }));
                }
                else if (mode == 4)
                {
                    this.rwr_e1.Dispatcher.Invoke(new Action(() => { this.rwr_e1.Visibility = Visibility.Visible; }));
                    this.rwr_e2.Dispatcher.Invoke(new Action(() => { this.rwr_e2.Visibility = Visibility.Visible; }));
                    this.rwr_e3.Dispatcher.Invoke(new Action(() => { this.rwr_e3.Visibility = Visibility.Visible; }));
                    this.rwr_e4.Dispatcher.Invoke(new Action(() => { this.rwr_e4.Visibility = Visibility.Visible; }));
                    this.rwr_e5.Dispatcher.Invoke(new Action(() => { this.rwr_e5.Visibility = Visibility.Hidden; }));
                    player1.Dispatcher.Invoke(new Action(() => { player1.Volume = 0.5; }));
                    player2.Dispatcher.Invoke(new Action(() => { player2.Volume = 0.5; }));
                    player3.Dispatcher.Invoke(new Action(() => { player3.Volume = 0.5; }));
                    player4.Dispatcher.Invoke(new Action(() => { player4.Volume = 0.5; }));
                    player5.Dispatcher.Invoke(new Action(() => { player5.Volume = 0; }));
                }
                else if (mode == 5)
                {
                    this.rwr_e1.Dispatcher.Invoke(new Action(() => { this.rwr_e1.Visibility = Visibility.Visible; }));
                    this.rwr_e2.Dispatcher.Invoke(new Action(() => { this.rwr_e2.Visibility = Visibility.Visible; }));
                    this.rwr_e3.Dispatcher.Invoke(new Action(() => { this.rwr_e3.Visibility = Visibility.Visible; }));
                    this.rwr_e4.Dispatcher.Invoke(new Action(() => { this.rwr_e4.Visibility = Visibility.Visible; }));
                    this.rwr_e5.Dispatcher.Invoke(new Action(() => { this.rwr_e5.Visibility = Visibility.Visible; }));
                    player1.Dispatcher.Invoke(new Action(() => { player1.Volume = 0.5; }));
                    player2.Dispatcher.Invoke(new Action(() => { player2.Volume = 0.5; }));
                    player3.Dispatcher.Invoke(new Action(() => { player3.Volume = 0.5; }));
                    player4.Dispatcher.Invoke(new Action(() => { player4.Volume = 0.5; }));
                    player5.Dispatcher.Invoke(new Action(() => { player5.Volume = 0.5; }));
                }
            }
        }

        private void rwr1()
        {
            while (true)
            {
                x1 = Random.Shared.Next(10, 251);
                y1 = Random.Shared.Next(10, 251);
                if (Math.Sqrt(Math.Pow(x1 - 130, 2) + Math.Pow(y1 - 130, 2)) <= 120 && Math.Sqrt(Math.Pow(x1 - 130, 2) + Math.Pow(y1 - 130, 2)) >= r1)
                {
                    DrawCanvas01(ellipse1);
                    player1.Dispatcher.Invoke(new Action(() => { player1.Open(new Uri(rwrmp3_1, UriKind.Relative)); player1.Play(); }));
                    this.rwr_e1.Dispatcher.Invoke(new Action(() => { this.rwr_e1.RenderTransform = SetXY(x1, y1); }));

                    Thread.Sleep(Random.Shared.Next(Math.Min(delay1, delay2), Math.Max(delay1, delay2) + 1));
                    ClearCanvas01();
                }
            }
            

        }
        private void rwr2()
        {
            while (true)
            {
                x2 = Random.Shared.Next(10, 251);
                y2 = Random.Shared.Next(10, 251);
                if (Math.Sqrt(Math.Pow(x2 - 130, 2) + Math.Pow(y2 - 130, 2)) <= 120 && Math.Sqrt(Math.Pow(x2 - 130, 2) + Math.Pow(y2 - 130, 2)) >= r1)
                {


                    DrawCanvas02(ellipse2);
                    player2.Dispatcher.Invoke(new Action(() => { player2.Open(new Uri(rwrmp3_2, UriKind.Relative)); player2.Play(); }));
                    this.rwr_e2.Dispatcher.Invoke(new Action(() => { this.rwr_e2.RenderTransform = SetXY(x2, y2); }));

                    Thread.Sleep(Random.Shared.Next(Math.Min(delay1, delay2), Math.Max(delay1, delay2) + 1));
                    ClearCanvas02();
                }
            }
            
        }
        private void rwr3()
        {
            while (true)
            {
                x3 = Random.Shared.Next(10, 251);
                y3 = Random.Shared.Next(10, 251);
                if (Math.Sqrt(Math.Pow(x3 - 130, 2) + Math.Pow(y3 - 130, 2)) <= 120 && Math.Sqrt(Math.Pow(x3 - 130, 2) + Math.Pow(y3 - 130, 2)) >= r1)
                {


                    DrawCanvas03(ellipse3);
                    player3.Dispatcher.Invoke(new Action(() => { player3.Open(new Uri(rwrmp3_2, UriKind.Relative)); player3.Play(); }));
                    this.rwr_e3.Dispatcher.Invoke(new Action(() => { this.rwr_e3.RenderTransform = SetXY(x3, y3); }));

                    Thread.Sleep(Random.Shared.Next(Math.Min(delay1, delay2), Math.Max(delay1, delay2) + 1));
                    ClearCanvas03();
                }
            }
            
        }
        private void rwr4()
        {
            while (true)
            {
                x4 = Random.Shared.Next(10, 251);
                y4 = Random.Shared.Next(10, 251);
                if (Math.Sqrt(Math.Pow(x4 - 130, 2) + Math.Pow(y4 - 130, 2)) <= 120 && Math.Sqrt(Math.Pow(x4 - 130, 2) + Math.Pow(y4 - 130, 2)) >= r1)
                {


                    DrawCanvas04(ellipse4);
                    player4.Dispatcher.Invoke(new Action(() => { player4.Open(new Uri(rwrmp3_2, UriKind.Relative)); player4.Play(); }));
                    this.rwr_e4.Dispatcher.Invoke(new Action(() => { this.rwr_e4.RenderTransform = SetXY(x4, y4); }));

                    Thread.Sleep(Random.Shared.Next(Math.Min(delay1, delay2), Math.Max(delay1, delay2) + 1));
                    ClearCanvas04();
                }
            }
            
        }
        private void rwr5()
        {
            while (true)
            {
                x5 = Random.Shared.Next(10, 251);
                y5 = Random.Shared.Next(10, 251);
                if (Math.Sqrt(Math.Pow(x5 - 130, 2) + Math.Pow(y5 - 130, 2)) <= 120 && Math.Sqrt(Math.Pow(x5 - 130, 2) + Math.Pow(y5 - 130, 2)) >= r1)
                {


                    DrawCanvas05(ellipse5);
                    player5.Dispatcher.Invoke(new Action(() => { player5.Open(new Uri(rwrmp3_2, UriKind.Relative)); player5.Play(); }));
                    this.rwr_e5.Dispatcher.Invoke(new Action(() => { this.rwr_e5.RenderTransform = SetXY(x5, y5); }));

                    Thread.Sleep(Random.Shared.Next(Math.Min(delay1, delay2), Math.Max(delay1, delay2) + 1));
                    ClearCanvas05();
                }
            }
            
        }
        private void ClearCanvas01()
        {
            this.rwr_e1.Dispatcher.Invoke(new Action(() =>
            {
                this.rwr_e1.Children.Clear();
            }));
        }
        private void DrawCanvas01(UIElement obj)
        {
            this.rwr_e1.Dispatcher.Invoke(new Action(() =>
            {
                this.rwr_e1.Children.Add(obj);
                this.rwr_e1.Children.Add(textBlock1);
            }));
        }
        private void ClearCanvas02()
        {
            this.rwr_e2.Dispatcher.Invoke(new Action(() =>
            {
                this.rwr_e2.Children.Clear();               
            }));
        }
        private void DrawCanvas02(UIElement obj)
        {
            this.rwr_e2.Dispatcher.Invoke(new Action(() =>
            {
                this.rwr_e2.Children.Add(obj);
                this.rwr_e2.Children.Add(textBlock2);
            }));
        }
        private void ClearCanvas03()
        {
            this.rwr_e3.Dispatcher.Invoke(new Action(() =>
            {
                this.rwr_e3.Children.Clear();
            }));
        }
        private void DrawCanvas03(UIElement obj)
        {
            this.rwr_e3.Dispatcher.Invoke(new Action(() =>
            {
                this.rwr_e3.Children.Add(obj);
                this.rwr_e3.Children.Add(textBlock3);
            }));
        }
        private void ClearCanvas04()
        {
            this.rwr_e4.Dispatcher.Invoke(new Action(() =>
            {
                this.rwr_e4.Children.Clear();
            }));
        }
        private void DrawCanvas04(UIElement obj)
        {
            this.rwr_e4.Dispatcher.Invoke(new Action(() =>
            {
                this.rwr_e4.Children.Add(obj);
                this.rwr_e4.Children.Add(textBlock4);
            }));
        }
        private void ClearCanvas05()
        {
            this.rwr_e5.Dispatcher.Invoke(new Action(() =>
            {
                this.rwr_e5.Children.Clear();
            }));
        }
        private void DrawCanvas05(UIElement obj)
        {
            this.rwr_e5.Dispatcher.Invoke(new Action(() =>
            {
                this.rwr_e5.Children.Add(obj);
                this.rwr_e5.Children.Add(textBlock5);
            }));
        }

        public TransformGroup SetXY(double CenterX, double CenterY)
        {
            TransformGroup tfGroup = new TransformGroup();
            TranslateTransform tt = new TranslateTransform();
            tt.X = CenterX;
            tt.Y = CenterY;
            tfGroup.Children.Add(tt);
            return tfGroup;
        }

        private void rwr_num1_Click(object sender, RoutedEventArgs e)
        {
            mode = 1;
        }

        private void rwr_num2_Click(object sender, RoutedEventArgs e)
        {
            mode = 2;
        }

        private void rwr_num3_Click(object sender, RoutedEventArgs e)
        {
            mode = 3;
        }
        private void rwr_num4_Click(object sender, RoutedEventArgs e)
        {
            mode = 4;
        }
        private void rwr_num5_Click(object sender, RoutedEventArgs e)
        {
            mode = 5;
        }

        private void rwr_set_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(freq_s.Text, out delay1);
            int.TryParse(freq_l.Text, out delay2);
            int.TryParse(r_1.Text, out r1);
        }

        private void rwr_sounds_Click(object sender, RoutedEventArgs e)
        {
            if (rwrmp3_1 == "rwr.mp3")
            {
                rwrmp3_1 = "lock.mp3";
            }
            else if (rwrmp3_1 == "lock.mp3")
            {
                rwrmp3_1 = "msl.mp3";
            }
            else if (rwrmp3_1 == "msl.mp3")
            {
                rwrmp3_1 = "rwr.mp3";
            }
        }
    }
    
}