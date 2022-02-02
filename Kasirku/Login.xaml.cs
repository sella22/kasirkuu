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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        kasirEntities _db = new kasirEntities();
        public Login()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_db.admins.Where(r => r.email == txtEmail.Text
                 && r.password == txtPassword.Password).Count() > 0)
                {
                    //redirect ke Dashboard
                    // MainWindow page = new MainWindow();
                    // page.Show();
                    //dataPelanggan page = new dataPelanggan();
                    //page.Show();
                    Dashboard page = new Dashboard();
                    page.Show();
                    Close();
                }
                else
                {
                    //pesan jika salah
                    MessageBox.Show("Invalid User");
                }
            }
            catch (Exception ert)
            {
            }
        }

        private void register_btn_Click(object sender, RoutedEventArgs e)
        {
            Register registerView = new Register();
            registerView.Show();
            this.Close();
        }
    }
}