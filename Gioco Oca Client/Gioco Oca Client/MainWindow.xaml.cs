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

namespace Gioco_Oca_Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Frame x; private readonly object mainFrame;

        //Name = "mainFrame" />
        public MainWindow()
        {
            InitializeComponent();


        }
       
        private void Bottone_di_inizio_gioco__Click(object sender, RoutedEventArgs e)
        {


            mainFrame(new Uri("Pagina1.xaml", UriKind.Relative));
    

        }
    }
}
