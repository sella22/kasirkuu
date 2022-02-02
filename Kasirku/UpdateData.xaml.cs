using System;
using System.Data;
using System.Linq;
using System.Windows;

namespace Kasirku
{
    public partial class UpdateData : Window
    {
        kasirEntities _db = new kasirEntities();
        int id;
        public int jumlahB, sosokB, idBarang;

        public UpdateData()
        {
            InitializeComponent();
            setDataTable();
            dataTransaksi.Columns[0].Width = 50;
            dataTransaksi.Columns[1].Width = 80;
            dataTransaksi.Columns[2].Width = 100;
            setBarang();
        }

        public void setBarang()
        {
            var jenisKamar = (from k in _db.Barangs
                              select k.nama_barang).ToList();

            cbBarang.ItemsSource = jenisKamar;
        }

        public void setDataTable()
        {
            dataTransaksi.ItemsSource = _db.Transaksis.ToList();
        }

        public void reset()
        {
            jumlah.Text = ""; harga.Text = ""; total.Text = ""; bayar.Text = ""; sosok.Text = "";
            cbBarang.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            tampil w = new tampil();
            w.Show();
        }

        private void BtnTambah_Click(object sender, RoutedEventArgs e)
        {
            reset();
            this.Hide();
            tampil w = new tampil();
            w.Show();
        }

        private void DataTransaksi_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            try
            {
                if (dataTransaksi.SelectedItem != null)
                {
                    if (dataTransaksi.SelectedItem is Transaksi)
                    {
                        var row = (Transaksi)dataTransaksi.SelectedItem;

                        if (row != null)
                        {
                            this.id = row.Id_transaksi;
                            cbBarang.Text = row.nama_barang;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void Jumlah_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            jumlahB = int.Parse(harga.Text) * int.Parse(jumlah.Text);
            total.Text = jumlahB.ToString();
        }

        private void Bayar_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            sosokB = int.Parse(bayar.Text) - int.Parse(total.Text);
            sosok.Text = sosokB.ToString();
        }

        private void CbBarang_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string jenis = cbBarang.SelectedItem.ToString().Trim();

            if (jenis == "Indomie")
            {
                harga.Text = (5000) + "";
            }
            else if (jenis == "Penghapus")
            {
                harga.Text = 5000 + "";
            }
            else if (jenis == "Penggaris")
            {
                harga.Text = 7000 + "";
            }
            else if (jenis == "Buku Tulis")
            {
                harga.Text = 2500 + "";
            }
            else
            {
                harga.Text = 0 + "";
            }
        }

        private void BtnHapus_Click(object sender, RoutedEventArgs e)
        {
            var kamarRemoved = _db.Transaksis.Where(x => x.Id_transaksi == this.id).Single();
            _db.Transaksis.Remove(kamarRemoved);
            _db.SaveChanges();
            MessageBox.Show("Data Pembelian berhasil dihapus!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            reset();
            setDataTable();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Transaksi updateTransaksi = (from k in _db.Transaksis
                                         where k.Id_transaksi == this.id
                                         select k).Single();

            updateTransaksi.nama_barang = cbBarang.Text;
            updateTransaksi.harga_barang = int.Parse(harga.Text);
            updateTransaksi.jumlah_barang = int.Parse(jumlah.Text);
            _db.SaveChanges();
            MessageBox.Show("Data Pembelian berhasil diupdate!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            reset();
            this.Hide();
            tampil w = new tampil();
            w.Show();
        }
    }
}
