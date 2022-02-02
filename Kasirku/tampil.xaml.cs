using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Kasirku
{
    public partial class tampil : Window
    {
        kasirEntities _db = new kasirEntities();
        public static DataGrid dataGrid;

        public tampil()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            dgrd1.ItemsSource = _db.Transaksis.ToList();
            dataGrid = dgrd1;
        }
        private void btnTambah_Klik(object sender, RoutedEventArgs e)
        {
            input iPage = new input();
            iPage.ShowDialog();
        }

        private void Button_back_Click(object sender, RoutedEventArgs e)
        {
            Dashboard page = new Dashboard();
            page.Show();
            Close();
        }

        private void btnUpload_Klik(object sender, RoutedEventArgs e)
        {
            UpdateData uPage = new UpdateData();
            uPage.ShowDialog();
        }
    }
}