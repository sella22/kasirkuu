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
    /// Interaction logic for BarangInput.xaml
    /// </summary>
    public partial class BarangInput : Window
    {
        kasirEntities _db = new kasirEntities();
        public BarangInput()
        {
            InitializeComponent();
        }
        public void reset()
        {
            namaBarang.Text = ""; hargaBarang.Text = ""; jumlahBarang.Text = ""; 
        }

        private void BtnBatal_Click(object sender, RoutedEventArgs e)
        {
            reset();
        }
       
        private void DbTxt(object sender, RoutedEventArgs e)
        {
            Barang newBarang = new Barang()
            {
                nama_barang = namaBarang.Text,
                harga_barang = int.Parse(hargaBarang.Text),
                jumlah_barang = int.Parse(jumlahBarang.Text)
            };
            _db.Barangs.Add(newBarang);
            _db.SaveChanges();
            tampilBarang.dataGrid.ItemsSource = _db.Barangs.ToList();
            this.Hide();
        }
    }
}
