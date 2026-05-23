using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp3
{
    public class LoginVM : INotifyPropertyChanged
    {
        public event Action LoginSucceeded;
        private LoginModel _LoginM = new LoginModel();
        
    

    
         public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string UserName
        {
            get { return _LoginM.UserName; }
            set
            {
                _LoginM.UserName = value;
                RaisePropertyChanged("UserName");
            }
        }

        public string Password
        {
            get { return _LoginM.Password; }
            set
            {
                _LoginM.Password = value;
                RaisePropertyChanged("Password");
            }
        }
        /// <summary>
        /// 登录方法
        /// </summary>
        void LoginFunc()
        {
            if (UserName == "wpf" && Password == "666")
            {
                new Index().Show();
                LoginSucceeded?.Invoke();


            }
            else
            {
                // ✅ 绑定会自动清空界面
                UserName = string.Empty;
                Password = string.Empty;
                System.Windows.MessageBox.Show("用户名或密码错误！");
            }
        }
        private bool CanLoginExecute()
        {
            // 这里可以写判断逻辑，比如用户名密码不为空才返回 true
            return true;
        }
        public ICommand LoginAction
        {
            get { return new RelayCommand(LoginFunc,CanLoginExecute); }
        }
    }
}