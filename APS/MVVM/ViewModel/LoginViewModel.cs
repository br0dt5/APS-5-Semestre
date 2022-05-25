using Chat.Nucleo;
using Chat.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Chat.MVVM.ViewModel
{
    class LoginViewModel
    {
        public static string Username { get; set; }

        public RelayCommand LoginCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(o =>
            {
                var main = new MainWindow();
                main.Show();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = main;
            }, o => !string.IsNullOrEmpty(Username));
        }
    }
}
