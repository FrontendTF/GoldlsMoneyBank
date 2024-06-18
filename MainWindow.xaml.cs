using System.Security.RightsManagement;
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
using System.IO;
using Microsoft.Win32;
using System.Data;


namespace GoldlsMoneyBank
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Öffnet die kunden.csv Datei und gibt es in einem Datagrid zurück
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          
            Kunde Kundeninfos = new Kunde();
            string[] KundenArray;

            DataTable dt = new DataTable();
            dt.Columns.Add("KundenID", typeof(string));
            dt.Columns.Add("KundenName", typeof(string));
            dt.Columns.Add("Kundenkonto", typeof(string));

            // Datei Pfad von Kunden + Kunden ID auslesen 
            using (StreamReader sr = new StreamReader(@"C:\Users\051419\Desktop\Kompetenzcheck\GoldlsMoneyBank\Kunden.csv"))
            {
                while (!sr.EndOfStream)
                {
                    // Bei Komma Spliten um die Strings(ID und Name) zu trennen
                    KundenArray = sr.ReadLine().Split(",");
                    Kundeninfos.KundenID = KundenArray[0];
                    Kundeninfos.KundenName = KundenArray[1];

                    dt.Rows.Add(KundenArray);

                }
                DataView dv = new DataView(dt);
                dtGridView.ItemsSource = dv;

            }
            using (StreamReader sr = new StreamReader(@"C:\Users\051419\Desktop\Kompetenzcheck\GoldlsMoneyBank\Konten.csv"))
            {
                
            }
        }
    }
}