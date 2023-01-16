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
    /// Logica di interazione per PlayerGam.xaml
    /// </summary>
    public partial class PlayerGam : Page
    {
        public PlayerGam()
        {
            InitializeComponent();
        }
        public partial class PlayerPage : Page
        {
            private int nGiocatori;
            public PlayerPage(int nGiocatori)
            {
                
                // assegnamento al parametro privato nGiocatori, il valore passato dalla pagina precedente
                this.nGiocatori = nGiocatori;
                // ciclo per creare tanti TextBox e ComboBox quanti sono i giocatori
                for (int i = 0; i < nGiocatori; i++)
                {
                    // creazione TextBox
                    TextBox tb = new TextBox();
                    // impostazione larghezza
                    tb.Width = 150;
                    // impostazione altezza
                    tb.Height = 20;
                    // impostazione margine
                    tb.Margin = new Thickness(5);
                    // impostazione nome
                    tb.Name = "tbPlayer" + i;
                    // impostazione allineamento verticale
                    tb.VerticalAlignment = VerticalAlignment.Top;
                    // impostazione allineamento orizzontale
                    tb.HorizontalAlignment = HorizontalAlignment.Left;
                    // impostazione PlaceholderText tb.PlaceholderText = "Inserisci il nome del giocatore";
                    // aggiunta del TextBox al StackPanel
                    StackPanelPlayers.Children.Add(tb);
                    StackPanel.Pane

                    // creazione ComboBox
                    ComboBox cb = new ComboBox();
                    // impostazione larghezza
                    cb.Width = 150;
                    // impostazione altezza
                    cb.Height = 20;
                    // impostazione margine
                    cb.Margin = new Thickness(5);
                    // impostazione nome
                    cb.Name;
                    cb.VerticalAlignment = VerticalAlignment.Top;
                    cb.HorizontalAlignment = HorizontalAlignment.Left;
                    for (int j = 1; j <= 200; j++)
                        cb.Items.Add(j);
                    StackPanelPlayers.Children.Add(cb);



                }
            }
        }
    }
}
