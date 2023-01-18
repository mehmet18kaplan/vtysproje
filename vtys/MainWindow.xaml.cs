using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using vtys.UC;

namespace vtys
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_kapat_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_boyut_click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }
        private void btn_simgedrm_click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btn_satis_mainmenu_Click(object sender, RoutedEventArgs e)
        {
            vtys.Class.Class1.uc_ekle(panelDesktop, new satis_login_uc());
        }

        private void btn_urunler_mainmenu_Click(object sender, RoutedEventArgs e)
        {
            vtys.Class.Class1.uc_ekle(panelDesktop, new urunler_uc());
        }

        private void btn_raporlar_mainmenu_Click(object sender, RoutedEventArgs e)
        {
            vtys.Class.Class1.uc_ekle(panelDesktop, new raporlar_uc());
        }
        private void btn_musteriler_mainmenu_Click(object sender, RoutedEventArgs e)
        {
            vtys.Class.Class1.uc_ekle(panelDesktop, new musteriler_uc());
        }
    }

    public class urun
    {
        public string barkod { get; set; }
        public string urun_adi { get; set; }
        public string fiyat { get; set; }
        public string stok_miktari { get; set; }
        public string alis_fiyati { get; set; }
        public string urun_kodu { get; set; }
    }

}
