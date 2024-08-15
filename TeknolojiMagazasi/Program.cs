using System;
using TeknolojiMagazasi;



//Kullanıcıya ürün seçimi yaptırılır.
bool Sectirme = true;

while (Sectirme)
{
    Console.WriteLine("Lütfen bir seçim yapınız:");
    Console.WriteLine("1 - Telefon üret");
    Console.WriteLine("2 - Bilgisayar üret");
    Console.Write("Seçiminiz: ");
    //Tekrar while oluşturularak şartlar belirlenir ve kullanıcının seçimine uygun döngü başlar.
    int secim;
    while (!int.TryParse(Console.ReadLine(), out secim) || (secim != 1 && secim != 2))
    {
        Console.Write("Geçersiz seçim. Lütfen 1 veya 2 giriniz: ");
    }

    if (secim == 1)
    {
        Telefon yeniTelefon = new Telefon();
        BilgileriAl(yeniTelefon);
        Console.Write("TR Lisanslı mı? (E/H): ");
        string trLisans = Console.ReadLine().ToLower();
        yeniTelefon.TrLisansliMi = trLisans == "e";

        yeniTelefon.BilgileriYazdir();
        yeniTelefon.UrunAdiGetir();
    }
    else if (secim == 2)
    {
        Bilgisayar yeniBilgisayar = new Bilgisayar();
        BilgileriAl(yeniBilgisayar);
        Console.Write("USB Giriş Sayısı (2/4): ");
        int usbGirisSayisi;
        while (!int.TryParse(Console.ReadLine(), out usbGirisSayisi))
        {
            Console.Write("Geçersiz giriş. Lütfen sayı giriniz: ");
        }
        yeniBilgisayar.UsbGirisSayisi = usbGirisSayisi;

        Console.Write("Bluetooth Var mı? (E/H): ");
        string bluetoothVarMi = Console.ReadLine().ToLower();
        yeniBilgisayar.BluetoothVarMi = bluetoothVarMi == "e";

        yeniBilgisayar.BilgileriYazdir();
        yeniBilgisayar.UrunAdiGetir();
    }

    Console.Write("Başka bir ürün üretmek ister misiniz? (E/H): ");
    string devam = Console.ReadLine().ToLower();
    Sectirme = devam == "e";
}

Console.WriteLine("İyi günler!");


static void BilgileriAl(BaseMakine makine)
{
    // Kullanıcıdan seri numarası bilgisini alır ve makine nesnesinin SeriNumarasi özelliğine atar
    Console.Write("Seri Numarası: ");
    makine.SeriNumarasi = Console.ReadLine();

    // Kullanıcıdan ad bilgisini alır ve makine nesnesinin Ad özelliğine atar
    Console.Write("Ad: ");
    makine.Ad = Console.ReadLine();

    // Kullanıcıdan açıklama bilgisini alır ve makine nesnesinin Aciklama özelliğine atar
    Console.Write("Açıklama: ");
    makine.Aciklama = Console.ReadLine();

    // Kullanıcıdan işletim sistemi bilgisini alır ve makine nesnesinin IsletimSistemi özelliğine atar
    Console.Write("İşletim Sistemi: ");
    makine.IsletimSistemi = Console.ReadLine();
}