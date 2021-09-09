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

namespace ZZ_Tests
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
#if PANELS
            InitializeComponent();
#endif
#if DRAGDROP
            DragDropTest win = new DragDropTest();
            win.Show();
            this.Close();
#endif
        }

        private void ListItemList_Click(object sender, RoutedEventArgs e)
        {
            List<int> wochennummerListe = new List<int>();
            wochennummerListe.Add(26);
            wochennummerListe.Add(27);
            wochennummerListe.Add(28);
            wochennummerListe.Add(29);

            List<Daten> datenListe = new List<Daten>();
            datenListe.Add(new Daten(25 , "KW 25 NEIN"));
            datenListe.Add(new Daten(25 , "KW 25 auch NEIN"));
            datenListe.Add(new Daten(26 , "KW 26 JA 1"));
            datenListe.Add(new Daten(26 , "KW 26 JA 2"));
            datenListe.Add(new Daten(27 , "KW 27 JA"));
            datenListe.Add(new Daten(28 , "KW 28 JA 1"));
            datenListe.Add(new Daten(28 , "KW 28 JA 2"));
            datenListe.Add(new Daten(29 , "KW 29 JA"));
            datenListe.Add(new Daten(30 , "KW 30 NEIN"));
            datenListe.Add(new Daten(31 , "KW 31 NEIN"));

            Daten ja = new Daten(27, "JA");
            Daten nein = new Daten(25, "NEIN");

            ;
            List<Daten> erg = datenListe.FindAll((d) => wochennummerListe.Contains(d.Woche));

        }
    }

    public class Daten
    {
        public int Woche { get; set; }
        public string Text { get; set; }

        public Daten(int w, string t)
        {
            this.Woche = w;
            this.Text = t;
        }
    }
}
