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
using System.Windows.Shapes;

namespace Gioco_Oca_Client
{
    /// <summary>
    /// Logica di interazione per Pagina_1.xaml
    /// </summary>
    public partial class Pagina_1 : Window
    {
        public Pagina_1()
        {
            InitializeComponent();
        
    
        public int NumberOfPlayers
        {
            //get { return numberOfPlayers; }
            //set
            {
                numberOfPlayers = value;
                NotifyPropertyChanged("NumberOfPlayers");
                NumberOfPlayers = int.Parse(playersTextBox.Text);
            }
            
    }

    }
}
    }
}

