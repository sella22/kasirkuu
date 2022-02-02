using System.Windows;

namespace Kasirku
{
    public partial class Register : Window
    {
        kasirEntities _db = new kasirEntities();
        public Register()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void onClickRegisterBtn(object sender, RoutedEventArgs e)
        {
            admin newadmin = new admin()
            {
                email = TxtEmail.Text,
                password = TxtPassword.Text
            };
            _db.admins.Add(newadmin);
            if (_db.SaveChanges() > 0)
            {
                MessageBox.Show("Berhasil Aktivasi Akun", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Maaf Silahkan Mencoba Kembali", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            Login page = new Login();
            page.Show();
            Close();
        }
    }
}
    
