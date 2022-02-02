using System.Linq;
using System.Windows;

namespace Kasirku
{
    public partial class input : Window
    {
        kasirEntities _db = new kasirEntities();
        public int jumlahB, sosokB, idBarang;

        public input()
        {
            InitializeComponent();
            setBarang();
        }

        public void setBarang()
        {
            var jenisBarang = (from k in _db.Barangs
                              select k.nama_barang).ToList();

            cbBarang.ItemsSource = jenisBarang;
        }


        public void reset()
        {
            jumlah.Text = ""; harga.Text = ""; total.Text = ""; bayar.Text = ""; sosok.Text = "";
            cbBarang.SelectedIndex = 0;
        }

        private void BtnKeluar_Click(object sender, RoutedEventArgs e)
        {
            reset();
            this.Hide();
            Dashboard w = new Dashboard();
            w.Show();
        }

        private void BtnBatal_Click(object sender, RoutedEventArgs e)
        {
            reset();
        }

        private void BtnSimpan_Click(object sender, RoutedEventArgs e)
        {
            string jenis = cbBarang.SelectedItem.ToString().Trim();
            int a = 4;
            if (jenis == "Indomie")
            {
                idBarang = 4;
            }
            else if (jenis == "Penghapus")
            {
                idBarang = 1;
            }
            else if (jenis == "Penggaris")
            {
                idBarang = 2;
            }
            else if (jenis == "Buku Tulis")
            {
                idBarang = 3;
            }
            else
            {
                idBarang = (a++);
            }

            Transaksi newTransaksi = new Transaksi()
            {
                Id_barang = idBarang,
                nama_barang = cbBarang.Text,
                harga_barang = int.Parse(harga.Text),
                jumlah_barang = int.Parse(jumlah.Text)
            };

            _db.Transaksis.Add(newTransaksi);
            _db.SaveChanges();
            tampil.dataGrid.ItemsSource = _db.Transaksis.ToList();
            this.Hide();

        }
        
        private void CbJeniskamar_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string jenis = cbBarang.SelectedItem.ToString().Trim();

            if (jenis == "Indomie")
            {
                harga.Text += (5000);
            }
            else if (jenis == "Penghapus")
            {
                harga.Text += 5000;
            }
            else if (jenis == "Penggaris")
            {
                harga.Text += 7000;
            }
            else if (jenis == "Buku Tulis")
            {
                harga.Text += 2500;
            }
            else
            {
                harga.Text += 0;
            }
        }

        private void Bayar_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            sosokB = int.Parse(bayar.Text) - int.Parse(total.Text);
            sosok.Text = sosokB.ToString();
        }

        private void Jumlah_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            jumlahB = int.Parse(harga.Text) * int.Parse(jumlah.Text);
            total.Text = jumlahB.ToString();
        }
    }
}