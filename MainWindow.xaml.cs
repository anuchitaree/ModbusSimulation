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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Threading;

namespace ModbusSimulation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       DispatcherTimer timerPoll = new DispatcherTimer();
        int g1 = 0;
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timerPoll.Interval = TimeSpan.FromSeconds(1);
            timerPoll.Tick += TimePoll_Tick;
            timerPoll.Start();  
        }

        private void TimePoll_Tick(object sender, EventArgs e)
        {
            g1++;
            gauage1.Value = g1;
            gauage2.Value = g1;
        }
    }
}
