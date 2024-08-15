using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeknolojiMagazasi
{

    public abstract class BaseMakine
    {
        public DateTime UretimTarihi { get; }
        public string SeriNumarasi { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }

        // Constructor
        public BaseMakine()
        {
            UretimTarihi = DateTime.Now;
        }

        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Üretim Tarihi: {UretimTarihi}");
            Console.WriteLine($"Seri Numarası: {SeriNumarasi}");
            Console.WriteLine($"Ad: {Ad}");
            Console.WriteLine($"Açıklama: {Aciklama}");
            Console.WriteLine($"İşletim Sistemi: {IsletimSistemi}");
        }
        public abstract void UrunAdiGetir();
    }
    public class Telefon : BaseMakine
    {
        // Telefonun Türkiye lisanslı olup olmadığını belirten özellik
        public bool TrLisansliMi { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"TR Lisanslı mı: {(TrLisansliMi ? "Evet" : "Hayır")}");
        }
        // Telefonun adını ekrana yazdırmak için kullanılan metod
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonunuzun adı ---> {Ad}");
        }
    }
    public class Bilgisayar : BaseMakine
    {
        private int _usbGirisSayisi;
        public int UsbGirisSayisi
        {
            get { return _usbGirisSayisi; }
            set
            {
                // USB giriş sayısının 2 veya 4 olup olmadığını kontrol eder
                if (value == 2 || value == 4)
                    _usbGirisSayisi = value;
                else
                {
                    // Geçersiz bir değer girildiğinde uyarı mesajı verir ve varsayılan değeri -1 olarak ayarlar
                    Console.WriteLine("Usb Giriş Sayısı sadece 2 veya 4 olabilir.");
                    _usbGirisSayisi = -1;
                }
            }
        }

        public bool BluetoothVarMi { get; set; }
        // Bilgisayar bilgilerini ekrana yazdırmak için kullanılan metod
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"USB Giriş Sayısı: {UsbGirisSayisi}");
            Console.WriteLine($"Bluetooth Var mı: {(BluetoothVarMi ? "Evet" : "Hayır")}");
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
        }
    }




}
