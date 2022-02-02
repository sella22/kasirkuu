using System.Windows;

namespace Kasirku
{
    public partial class Dashboard : Window
    {
        kasirEntities _db = new kasirEntities();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void buttonBarang_Click(object sender, RoutedEventArgs e)
        {
            tampilBarang tr = new tampilBarang();
            tr.Show();
            this.Close();
        }

        private void buttonTransaksi_Click(object sender, RoutedEventArgs e)
        {
            tampil tr = new tampil();
            tr.Show();
            this.Close();
        }
        private void Button_back_Click(object sender, RoutedEventArgs e)
        {
            Login page = new Login();
            page.Show();
            Close();
        }
    }
}
