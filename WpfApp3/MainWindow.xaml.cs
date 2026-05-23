using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>

    // 👉 1. 必须继承 INotifyPropertyChanged
    public partial class MainWindow : Window
    {
        LoginVM loginVM;

        public MainWindow()
        {
            InitializeComponent();

            loginVM = new LoginVM();
            loginVM.LoginSucceeded += () =>
            {
               
               
                // 隐藏自己
                this.Hide();
            };
            this.DataContext = loginVM;
        }

     
    }
}

