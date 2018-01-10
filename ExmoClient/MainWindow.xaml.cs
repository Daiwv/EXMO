using System;
using System.Collections.Generic;
using System.Linq;
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
using DevExpress.Xpf.Core;
using ExmoData.Model;
using ExmoData;
using System.Threading;
using System.Threading.Tasks;

namespace ExmoClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow
    {
        private ExmoDt exmoData;

        public MainWindow()
        {
            InitializeComponent();

            exmoData = new ExmoDt();
        }

        private void DXWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DisplayTick();            
        }

        async void DisplayTick()
        {
            while (true)
            {
                //DataContext = exmoData.GetTickers(new string[2] { "BTC_USD", "XRP_USD" });

                grData.ItemsSource = exmoData.GetTickers(new string[2] { "BTC_USD", "XRP_USD" });
                await Task.Delay(2000);
            }
        }

    }
}
