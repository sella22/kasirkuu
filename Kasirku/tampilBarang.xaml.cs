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

namespace Kasirku
{
    /// <summary>
    /// Interaction logic for tampilBarang.xaml
    /// </summary>
    public partial class tampilBarang : Window
    {
        kasirEntities _db = new kasirEntities();
        public static DataGrid dataGrid;

        public tampilBarang()
        {
            InitializeComponent(); Load();
        }
        private void Load()
        {
            dgrd2.ItemsSource = _db.Barangs.ToList();
            dataGrid = dgrd2;
        }
        private void btnTambah_Klik(object sender, RoutedEventArgs e)
        {
            BarangInput iPage = new BarangInput();
            iPage.ShowDialog();
        }
        private void btnHapus_Klik(object sender, RoutedEventArgs e)
        {
            
            _db.SaveChanges();
            dgrd2.ItemsSource = _db.Barangs.ToList();
        }

        private void Button_back_Click(object sender, RoutedEventArgs e)
        {
            Dashboard page = new Dashboard();
            page.Show();
            Close();
        }
    }
}