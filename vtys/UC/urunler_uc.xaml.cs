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

namespace vtys.UC
{
    /// <summary>
    /// urunler_uc.xaml etkileşim mantığı
    /// </summary>
    public partial class urunler_uc : UserControl
    {
        public urunler_uc()
        {
            InitializeComponent();
            
            ObservableCollection<urun> urunler = new ObservableCollection<urun>();

            urunler.Add(new urun { barkod = "1", urun_adi = "aaaaa", alis_fiyati = "15", fiyat = "20", stok_miktari = "55", urun_kodu = "254658" });
            urunler.Add(new urun { barkod = "2", urun_adi = "bbbbb", alis_fiyati = "13", fiyat = "20", stok_miktari = "55", urun_kodu = "254659" });
            urunler.Add(new urun { barkod = "3", urun_adi = "ccccc", alis_fiyati = "14", fiyat = "20", stok_miktari = "55", urun_kodu = "254657" });
            urunler.Add(new urun { barkod = "4", urun_adi = "ddddd", alis_fiyati = "12", fiyat = "20", stok_miktari = "55", urun_kodu = "254656" });
            urunler.Add(new urun { barkod = "5", urun_adi = "eeeee", alis_fiyati = "9", fiyat = "20", stok_miktari = "55", urun_kodu = "254655" });


            satis_urunler_tablo.ItemsSource = urunler;
        }

    }
}
