using System;

//namespace Static_Sınıf_ve_Üyeler
//    {
    //// Bir sınıfın static olmayan üyelerine nesneler aracılığıyla erişirken static olan metotlara ve özelliklere ise nesne 
    //// oluşturmadan o sınıfın ismi aracılığıyla erişiriz.
//    class Ogrenci
//    {
//        public static int OgrenciSayisi = 0;
//        public string Isim;
//        public string Soyisim;
//        public Ogrenci()
//        {
//            OgrenciSayisi++;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Static sınıf üyesine erişim
//            Console.WriteLine("Öğrenci sayısı: {0}",Ogrenci.OgrenciSayisi);
//
//            //Static olmayan sinif üyesine erişim
//            Ogrenci ogrenci1 = new Ogrenci();
//            ogrenci1.Isim = "Deniz";
//            ogrenci1.Soyisim = "Arda";
//            
//            Ogrenci ogrenci2 = new Ogrenci();
//           ogrenci2.Isim = "Ayşe";
//            ogrenci2.Soyisim = "Yılmaz";
//
//            Console.WriteLine("Öğrenci Sayısı: {0}", Ogrenci.OgrenciSayisi);
//    }
//  }

////Yukarıda hem static hemde static olmayan sınıf üyesine sahip bir sınıf tanımı ve program içerisinden kullanımı görüyorsunuz.
////Static olmayan üyeler nesne bazında yaratılırken static sınıf üyeleri uygulama çalıştığı sürece kendilerine atanan veriyi tutarlar. 
////Yani yukarıdaki örnek için konuşursak, "Isim" ve "Soyisim" her nesne yaratıldığında başlangıç değeri olarak null alır,
////ataması yapıldığındaysa nesne bazında değerini tutar.
////Ama "Ogrenci Sayısı" field'ı program boyunca nesne yaratıldıkça öğrenci sayısının değerini 1 arttırarak bu veriyi korur.
////Yukarıdaki örnektede görebileceğini gibi bir özelliği static yapmak için geri dönüş tipi yada veri tipinden önce erişim
////belirleyiciden sonra "static" anahtar kelimesini koymanız yeterlidir.
////Normal metotlar gibi kurucu metotları da static olarak tanımlayabiliriz. Sınıfın static üyelerinin başlangıç değerlerini static kurucular
////aracılığıyla yapabiliriz. Parametre almazlar ve erişim belirleyicileri yoktur.

////Static Sınıflar
////Metotlar ve özellikler gibi sınıflar da static anahtar kelimesi ile oluşturulabilirler. Yukarıdaki örnekte de görebileceğiniz üzere normal
////sınıflar içerisinde static metotlar ve üyeler kullanabiliriz. Peki o halde neden sınıfları static yapma ihtiyacımız olsun? Buna
////okunabilirliği arttırmak için diyebiliriz.
////Bir sınıfın tüm üyeleri static ise sınıfı da static yapmak kullanımı kolaylaştıran bir yaklaşım olur.
//}

namespace Static_Sınıf_ve_Üyeler
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Çalışan Sayısı : {0}",Calisan.Calisansayisi );
            Calisan calisan = new Calisan("Ayşe", "Yılmaz", "IK");
            Console.WriteLine("Çalışan Sayısı : {0}",Calisan.Calisansayisi );
            Calisan calisan1 = new Calisan("Deniz", "Arda", "IK");
            Calisan calisan2 = new Calisan("Burak", "Oranlıer", "IK");
            Console.WriteLine("Çalışan Sayısı : {0}",Calisan.Calisansayisi );

            // nesneler aracılığıyla statik sınıfın üyeierine erişilemez, bu nedenle alt satırdaki işlem hata verir
            // iki alt satıırdaki gibi sınıfın kendisinden erişim sağla nabilir
            // Islemler islemler = new Islemler(); 
            Console.WriteLine("Toplama işlemi sonucu : {0}", Islemler.Topla(8,9));
            Console.WriteLine("Toplama işlemi sonucu : {0}", Islemler.Cikar(8,9));
        }
    }

    class Calisan
    {
        // statik olmayan elemanlar o sınıfla oluşturulan nesneye özgü iken, bir sınıfın statik olan üyeleri sınıf bazında atanır 
        private static int calisansayisi; 
        public static int Calisansayisi { get => calisansayisi; }
        private string Isim;
        private string Soyisim;
        private string Departman;


        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisansayisi ++;
        }

            //aşağıdaki statik konstruktor sadece 1 kez çalışır, o da bu sınıfa ilk erişildiğinde
            //
        static Calisan()
        {
            calisansayisi = 0;
        }
    }
    static class Islemler
    //statik sınıfların içerisinde statik olmayan herhangi bir metot ya da property tanımlayamayız
    // statik sınıflardan statik sınıflara kalıtım işlemi uygulanamaz
    {
        public static long Topla(int sayi1, int sayi2){
            return sayi1+sayi2;
        }

        public static long Cikar(int sayi1, int sayi2){
            return sayi1-sayi2;
        }


    }

}