using System;
using System.Collections.Generic;
using System.Drawing;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace vtys.UC
{
    /// <summary>
    /// satis_login_uc.xaml etkileşim mantığı
    /// </summary>
    public partial class satis_login_uc : UserControl
    {
        public satis_login_uc()
        {
            InitializeComponent();
        }

        private void satisuc_login_username_tb_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            satisuc_login_username_tb.Text = "";
            satisuc_login_username_tb.Foreground = new SolidColorBrush(Colors.Black);
            satisuc_login_username_tb.TextAlignment = TextAlignment.Left;
        }

        private void satisuc_login_username_tb_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            satisuc_login_username_tb.Text = "Kullanıcı Adı...";
            satisuc_login_username_tb.Foreground = new SolidColorBrush(Colors.LightGray);
            
            satisuc_login_username_tb.TextAlignment = TextAlignment.Center;

        }

        private void satisuc_login_pass_tb_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            satisuc_login_pass_tb.Text = "";
            satisuc_login_pass_tb.Foreground = new SolidColorBrush(Colors.Black);
            satisuc_login_pass_tb.TextAlignment = TextAlignment.Left;
        }

        private void satisuc_login_pass_tb_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            satisuc_login_pass_tb.Text = "Kullanıcı Adı...";
            satisuc_login_pass_tb.Foreground = new SolidColorBrush(Colors.LightGray);
            satisuc_login_pass_tb.TextAlignment = TextAlignment.Center;
        }
    }
}
