using System;

namespace egitimNotlari
{
    class Program
    {
        static void Main(string[] args)
        {

            //byte tam sayı tanımlamak için 1byte yer kaplar
            //short tam sayı tanımlamak için 2byte yer kaplar
            //int tam sayı tanımlamak için 4 byte yer kaplar
            //long tam sayı tanımlamak için 8 byte yer kaplar
            //float ondalıklı sayı tanımlamak için 2 byte yer kaplar
            //double ondalıklı sayı tanımlamak için 4 byte yer kaplar
            //boolean 2 alternatifin oldupu veri tipidir. 2 byte yer kaplar
            //char sadece tek karakter değerleri atamak için kullanılır.
            //string metin değeri tutabilmek için kullanılır.













            // "komutlar arası /*-*/ yaparak tamamını açıklama satırına çevirebiliriz.

            /*
            //ekrana yazdırma
            Console.WriteLine("Hello World!");
            Console.WriteLine("Atakan");//writeline komutunda alt alta yazar.
            Console.Write("aytun");//write komutunda yan yana yazar.
            Console.Write(" ");
            Console.Write("pelin");
            
            Console.ReadLine(); //programı ekranda tutmak için kullanılabilir.
            */








            //byte vb. değer verme

            /*
            byte birinci = 5; //0-255
            byte ikinci = 25;
            byte maxDeger = byte.MaxValue;
            byte minDeger = byte.MinValue;


            Console.WriteLine(birinci);
            Console.WriteLine(ikinci);
            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
            Console.ReadLine();
            */









            // short veri tipi kullanımı
            //short değişkeni -32768 ile 32767 arasında değer depolayabilmektedir.

            /*
            short birinciDegisken = -50;
            short ikinciDegisken = 25550;
            short ucuncuDegisken = 32000;

            short maxDeger = short.MaxValue;
            short minDeger = short.MinValue;

            console.writeline(birinciDegisken);
           
            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
            Console.ReadLine();
            */











            //int veri tipi ve kullanımı
            // İnt tipi -2milyon ile 2milyon arasında değer depolayabilir.
            // 8 bit = 1 byte
            // 1024 byte = 1KB(kilobyte)
            // 1024 kb = 1MB(megabyte)
            // 1024 mb = 1GB(gigabyte)
            // 1024 gb = 1TB(terabyte)
            // 1024 tb = 1PB(petabyte)

            /*
            int birinciDegisken = 150000;
            int ikinciDegisken = -500000;

            Console.WriteLine(birinciDegisken);
            Console.WriteLine(ikinciDegisken);

            int maxDeger = int.MaxValue;
            int minDeger = int.MinValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);

            Console.ReadLine();
            */












            //Long veri tipi nedir ?
            // long veri tipi tam sayıları tanımlamak için kullanılır.
            // diğer veri tiplerinden farkı '-' ve '+' değer olarak 19 basamak değer alabilir.

            /*
            long maxDeger = long.MaxValue;
            long minDeger = long.MinValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);

            Console.ReadLine();
            */












            //float veri tipi nedir
            // girilen ondalıklı sayı değeri double olarak algılanır. Bunu float komutunda yazmak için değer sonuna "f" konulmalıdır.

            /*
            float maxDeger = float.MaxValue;
            float minDeger = float.MinValue;

            float ondalikliSayi1 = 35.56f;

            Console.WriteLine(ondalikliSayi1);
            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);

            Console.ReadLine();
            */










            //double veri tipi
            // 15 basamaklı ondalıklı sayıları tutabilir.

            /*
            double maxDeger = double.MaxValue;
            double minDeger = double.MinValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);

            Console.ReadLine();
            */












            //char veri tipi nedir
            //tek tırnak içerisinde tek değer olucak şekilde kullanılır

            /*
            char karakter = 'A';
            char karakter2 = 'P';

            Console.WriteLine(karakter);
            Console.WriteLine(karakter2);

            Console.ReadLine();
            */










            //string veri tipi nedir
            // çift tırnak içerisinde kullanılır.

            /*
            string isim = "aytun";
            string soyisim = "karagoz";

            Console.WriteLine(isim);
            Console.WriteLine(soyisim);

            Console.ReadLine();
            */











            //bool veri tipi nedir
            // iki ihtimalin olduğu veri tipidir , yalnızca iki değer tutar.

            /*
            bool kontrol = true; //doğru
            bool kontrol2 = false; // yanlış

            bool Sonuc = 10 > 5;

            Console.WriteLine(Sonuc);
            Console.ReadLine();
            */











            //object veri tipi
            // tüm veri tiplerini ayırt etmeden içerisinde tutabilir

            /*
            object a = "5";
            object b = "aytun";
            object c = "3.12";
            */










            //operatörler

            /*
            + : toplama
            - : çıkartma
            * : çarpma
            / : bölme
            % : mod bölme
            -- : bir azaltma
            ++ : bir arttırma
            = : atama
            > : büyük
            >= : büyük eşit
            < : küçük
            <= : küçük eşit
            == : eşit
            != : farklı(eşit değil)
            && : ve(and)
            || : veya(or) 
            ! : değil
            */











            //toplama , çıkarma

            /*
            int sayi1 = 5;
            int sayi2 = 12;
            int sayi3 = 32;
            int sayi4 = 18;
            int sonuc = (sayi1 + sayi2 + sayi3) - sayi4;

            Console.WriteLine(sonuc);
            Console.ReadLine();
            */










            //çarpma , bölme

            /*
            int sayi1 = 7;
            int sayi2 = 11;
            int sayi3 = 10;

            int sonuc = (sayi1 * sayi2)/sayi3;

            Console.WriteLine(sonuc);
            Console.ReadLine();
            */







            //mod alma operatörü : % (sayının bölümünden kalanı bulma operatörü)

            /*
            int sayi1 = 10;
            int sayi2 = 3;

            Console.WriteLine(sayi1 % sayi2);
            Console.ReadLine();  //çıkan sonuç bölümden kalan olur.
            */







            //arttırma ve azaltma operatörü

            /*
            int sayi1 = 20;
            int sayi2 = 15;
            sayi1++;
            sayi2--;

            Console.WriteLine(sayi1);
            Console.WriteLine(sayi2);

            Console.ReadLine();
            */






            //atama operatörü : =

            /*
            int yas = 21;
            */





            //eşittir operatörü : ==

            /*
            int sayi1 = 4;
            int sayi2 = 4;

            bool kontrolEt = sayi1 == sayi2; //bool komutu doğru yanlış değerini kontrol ediyor.

            Console.WriteLine(kontrolEt);
            Console.ReadLine();
            */








            //eşit değildir operatörü : !=

            /*
            int sayi1 = 3;
            int sayi2 = 4;

            bool kontrolEt = sayi1 != sayi2; //sayılar eşit olmadığı için sonuç true olmalıdır.

            Console.WriteLine(kontrolEt);
            Console.ReadLine();
            */







            //büyüktür operatörü : >
            // büyük ve eşittir operatörü : >=

            /*
            int yas = 18;

            bool kontrolEt = yas > 18;

            Console.WriteLine(kontrolEt);
            Console.ReadLine();
            */







            // && (ve) operatörü 

            /*
            int sayi1 = 5;
            int sayi2 = 5;
            int sayi3 = 10;

            bool kontrolEt = sayi1 == sayi2 && sayi1 < sayi3;
            //&& (ve) operatörünü kullanarak 2 koşul oluşturduk bool komutu buna göre çalışacaktır.
            Console.WriteLine(kontrolEt);
            Console.ReadLine();
            */








            // veya || operatörü
            // verilen iki koşuldan birisinin sağlanması yeterlidir.

            /*
            int sayi1 = 3;
            int sayi2 = 3;
            int sayi3 = 6;

            bool kontrolEt = sayi1 == sayi2 || sayi2 > sayi3;
            // koşullardan birisi sağlanıyorsa sonuç true kabul ediliyor.
            Console.WriteLine(kontrolEt);
            Console.ReadLine();
           */









            // ! (değil) operatörü
            // var olan bir şeyi zıttına çevirir

            /*
            bool a = true;

            Console.WriteLine(!a);
            Console.ReadLine();
            // sonuç true çıkması gerekirken !(değil) operatörünü kullandığımız için sonuç false çıkacaktır.
            */







            // kısaltma olarak kullanabilicek operatörlerdir.
            // +=
            // -=
            // /=
            // *=


            /*
            int a = 5;

            a += 4;

            Console.WriteLine("a'nın değeri:" + a);
            Console.ReadLine();
            */









            //breakpoint ve tooltip önemi(önemli)
            // breakpoint kodların tek tek üzerinden geçme
            //tooltip komutu yazarken yanında açılan küçük bilgi kutusu
            /*
            int a = 3;
            int b = 5;
            int c = 10;

            int sonuc = a + b + c;

            Console.WriteLine(sonuc);
            Console.ReadLine();
            */









            //kullanıcıdan değer alma

            /*
            Console.WriteLine("Adınızı Giriniz:");

            string isim = Console.ReadLine();

            Console.WriteLine("Soyisminizi Giriniz:");

            string soyisim = Console.ReadLine();


            Console.WriteLine("Kullanıcının İsmi: " + isim);
            Console.WriteLine("Kullanıcının Soyismi: " + soyisim);

            Console.ReadLine();
            */










            //TÜR DÖNÜŞÜMLERİ (veri tiplerinde değişim)


            //1.örnek
            /*
            int a = 5;

            byte b = (byte)a;

            Console.WriteLine(b.GetType());
            // b değişkeninin türünü görmemizi sağlayan komut gettype.
            Console.WriteLine(b);
            Console.ReadLine();
            */


            //2.örnek
            /*
            string sayi1 = "1";
            string sayi2 = "2";

            int a = int.Parse(sayi1); //string değerini int değerine dönüştürdük.
            int b = int.Parse(sayi2);

            Console.WriteLine(a + b);
            Console.ReadLine();
            */


            //3.örnek
            /*
            string sayi1 = "1";
            string sayi2 = "3";

            int a = Convert.ToInt32(sayi1);
            int b = Convert.ToInt32(sayi2);

            Console.WriteLine(a + b);
            Console.ReadLine();
            */


            //4.örnek
            /*
            int sayi1 = 5;
            int sayi2 = 10;

            string a = sayi1.ToString();
            string b = sayi2.ToString();
            //string değerleri toplamaya çalışırsak yan yana yazacaktır.

            Console.WriteLine(a+b);

            Console.ReadLine();
            */


            //5.örnek
            /*
            double sayi = 5.22;

            int a = Convert.ToInt32(sayi);
            // doubledan int değerine geçiş yapınca ondalık kısmı atacaktır.
            Console.WriteLine(a);
            Console.WriteLine(sayi.GetType());
            Console.ReadLine();
            */





            //KULLANICIDAN ALINAN DEĞERLER STRİNG VERİ TİPİNDE OLUR

            /*
            string kullanici_yas = Console.ReadLine("Lütfen yaşınızı giriniz: ");

            int kullanici_yasInt = int.Parse(kullanici_yas);
            int kullanici_yasInt2 = Convert.ToInt32(kullanici_yas);

            Console.WriteLine(kullanici_yasInt);
            Console.WriteLine(kullanici_yasInt2);
            Console.ReadLine();
            */




            //kullanıcıdan 2 tane sayı alan ve ikisinin toplamını ekrana yazdıran program
            /*
            Console.WriteLine("1.Sayıyı Giriniz: ");
            string sayi1 = Console.ReadLine();

            int a = int.Parse(sayi1);

            Console.WriteLine("2.Sayıyı Giriniz: ");
            string sayi2 = Console.ReadLine();

            int b = int.Parse(sayi2);

            Console.WriteLine("İki Sayının Toplamı: "+ (a+b));
            Console.ReadLine();
            */








            // Koşul yapıları (IF-ELSE)
            // öğrenci notu 50'den büyükse başarılı başarısız yazdıran program.

            /*
            int not = 75;

            if (not > 50)
            {
                Console.WriteLine("Öğrenci bu dersten başarılı bir şekilde geçmiştir.");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Öğrenci dersten başarısız olmuştur.");
                Console.ReadLine();
            }
            */






            //IF - ELSE IF - ELSE

            //ÖRNEK
            //Kullanıcıdan 3 tane not alan ve bu notların ortalamasının bulunması
            //80-100 arasında A+
            //60-80 arasında A
            //40-60 arasında B+
            //40'dan düşükse F yazdıran kodlama


            /*
            Console.WriteLine("1.Notu Giriniz:");
            int not1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Notu Giriniz:");
            int not2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3.Notu Giriniz:");
            int not3 = Convert.ToInt32(Console.ReadLine());

            int sonuc = (not1 + not2 + not3) / 3;
            Console.WriteLine("Not Ortalamanız: " + sonuc);

            if(sonuc>80 && sonuc<100)
            {
                Console.WriteLine("Not Değeriniz : A+");
            }

            else if(sonuc>60 && sonuc<80)
            {
                Console.WriteLine("Not Değeriniz : A");
            }

            else if(sonuc>40 && sonuc<60)
            {
                Console.WriteLine("Not Değeriniz : B+");
            }

            else
            {
                Console.WriteLine("Not Değeriniz : F");
            }
            */






            //Örnek 2
            //Mini ATM örneği
            // kullanıcıya nasıl bir işlem yapmak istediği
            //1-Bakiye görüntüleme
            //2-para çekme
            //3-para yatırma
            //q çıkış yap

            /*
            int bakiye = 1000;

            Console.WriteLine("Atm'ye Hoşgeldiniz");
            Console.WriteLine(" ");
            Console.WriteLine("1-Bakiye Görüntüleme");
            Console.WriteLine("2-Para Çekme");
            Console.WriteLine("3-Para Yatırma");
            Console.WriteLine("Q-Çıkış Yap");
            Console.WriteLine(" ");

            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Şu anki Bakiyeniz : " + bakiye);
                Console.ReadLine();
            }

            else if (secim == "2")
            {
                Console.WriteLine("Çekmek İstediğiniz Tutarı Giriniz:");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                if(cekilecek_tutar<=bakiye)
                {
                    Console.WriteLine("Kalan Tutar : " + (bakiye - cekilecek_tutar));
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Bakiyenizden Fazla Para Çekemezsiniz.");
                    Console.ReadLine();
                }
            }

            else if(secim=="3")
            {
                Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz:");
                int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Yeni Bakiyeniz : " + (bakiye + yatirilacak_tutar));
                Console.ReadLine();
            }

            else if(secim=="q")
                {
                Console.WriteLine("ATM'den Çıkış Yapılıyor.");
                Console.WriteLine("Çıkış Yapıldı. İyi Günler...");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz.");
                Console.ReadLine();
            }

            */








            //ÖRNEK 3
            //BEDEN KİTLE ENDEKSİ HESAPLAMA

            //Beden Kitle Endeksi Hesaplama = Kilo/boy*boy
            //Beden Kitle Endeksi 18'eşit veya düşükse zayıf
            //18 ile 25 arasında normal
            //25'ten büyükse obez yazdıran program


            /*
            Console.WriteLine("Kilonuzu Giriniz.");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boyunuzu Giriniz.");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bke = kilo / (boy * boy);
            Console.WriteLine("BKE değeriniz : " + bke);

            if(bke<18)
            {
                Console.WriteLine("Zayıf");
                Console.ReadLine();
            }

            else if(bke>18 && bke <25)
            {
                Console.WriteLine("Normal");
                Console.ReadLine();
            }

            else if(bke>25)
            {
                Console.WriteLine("Obez");
                Console.ReadLine();
            }

            */








            //Switch Case Kullanarak Mini ATM
            //1-Bakiye Görüntüleme
            //2-Para Çek
            //3-Para Yatır
            //4-Çıkış yap
            //1-2-3-4 değerleri dışında ise hata vericek


            /*
            int bakiye = 700;

            Console.WriteLine("ATM'ye Hoşgeldiniz.");

            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz.");
            Console.WriteLine("1-Bakiye Görüntüleme");
            Console.WriteLine("2-Para Çek");
            Console.WriteLine("3-Para Yatır");
            Console.WriteLine("4-Çıkış Yap");

            string secim = Console.ReadLine();

            switch(secim)
            {
                case "1":

                    Console.WriteLine("Bakiyeniz : " + bakiye);
                    Console.ReadLine();
                    break;

                case "2":

                    Console.WriteLine("Çekmek İstediğiniz Tutarı Giriniz.");
                    int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                    if(cekilecek_tutar>bakiye)
                    {
                        Console.WriteLine("Bakiyenizden Fazla Para Çekemezsiniz");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Kalan Bakiyeniz : "+(bakiye - cekilecek_tutar));
                        Console.ReadLine();
                    }
                    break;

                case "3":

                    Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz");
                    int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Yeni Bakiyeniz : " + (bakiye + yatirilacak_tutar));
                    Console.ReadLine();
                    
                    break;

                case "4":

                    Console.WriteLine("Hesabınızdan Çıkış Yapılıyor. İyi Günler...");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz.");
                    Console.ReadLine();
                    break;

            }
            */










            //DÖNGÜLER(LOOPS)
            //For-While
            /*
            for(int degisken_adi = baslangicDegeri;koşul;arttırmaAzaltma)

             {

            çalışacak kodlar

             }
            */






            //Örnek(for)
            // 1'den 10'a kadar olan sayıları alt alta ekrana yazdıran program.
            //Koşul sağlandığı sürece koşul çalışır. koşul(i<=10)


            /*
            for(int i = 1;i<=10;i++)//i değeri 10'dan küçük olduğu için arttırarak yazar.
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */





            //Örnek2(for)
            //1'den 10'a kadar olan sayılardan çift olanları ekrana yazdırma.

            /*
            for(int a=0;a<=10;a=a+2)//a+=2 kullanılabilir(arttırma için)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
            */






            //İç içe For Döngüsü Kullanımı


            /*
            for(int i=1;i<=10;i++)
            {
                for(int j = 1 ; j<=i ; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
            */







            //while(şart)
            /*
             {
            kodlar
            }
            */





            //1'den 10'a kadar sayıları ekrana yazdırma

            //100'den 0'a kadar olan sayıların çift olanlarını büyükten küçüğe yazdırma





            //ÖRNEK 1
            /*
            int a = 1;

            while (a <=10)
            {
                Console.WriteLine(a);
                a++;
            }

            Console.ReadLine();
            */


            //ÖRNEK 2

            /*
            int a = 100;

            while(a>=0)
            {
                Console.WriteLine(a);
                a -= 2;//a=a-2
            }

            Console.ReadLine();
            */






            //do while döngüsü
            /*
             do
            {

            }while(şart);
            */



            //1'den 10'a kadar yazdırma(do while ile)
            //1'den 100'e kadar olan sayıların toplamı(do while ile)

            //Örnek 1
            /*
            int a = 1;

            do
            {
                Console.WriteLine(a);
                a++;

            } while (a<=10);

            Console.ReadLine();
            */


            //ÖRNEK 2

            /*
            int a = 1;
            int toplam = 0;

            do
            {
                toplam += a;

                a++;
                

            } while (a<=100);

            Console.WriteLine("1'den 100'e kadar olan sayıların toplamı:" + toplam);

            Console.ReadLine();
            */






            //Break anahtar kelimesi
            //Continue anahtar kelimesi

            //break örnek
            /*
            for(int a=1; a<=10; a++)
            {
                if (a==7)
                {
                    break;//ekrana yazdırmayı 7'de durdurur.
                }
                Console.WriteLine("a'nın değeri:" + a);
            }

            Console.ReadLine();
            */



            //continue örnek
            /*
            for (int a = 1; a <= 10; a++)
            {
                if (a == 7)
                {
                    continue;//döngüyü 1 sefer kırar(ekranda 7 yazmaz.)
                }
                Console.WriteLine("a'nın değeri:" + a);
            }

            Console.ReadLine();
            */




            //ÖRNEK***
            //For döngüsü ile çarptım tablosu

            /*
            for(int i=1;i<=10; i++)
            {
                for(int j=1;j<=10;j++)
                {
                    Console.WriteLine(i + "x" + j + "=" + (i * j));

                }
            }

            Console.ReadLine();
            */




            //Kullanıcı giriş sayfası uygulaması
            //kullanıcı adı ve şifresi doğru girerse tebrikler giriş yaptınız
            //yanlış girerse hata verip 3 hak tanısın.

            /*
            int hak_sayisi = 3;

            while(true)
            {
                Console.WriteLine("Kullanıcı Adınızı Giriniz:");
                string kullanici_adi = Console.ReadLine();

                Console.WriteLine("Kullanıcı Şifrenizi Giriniz:");
                string sifre = Console.ReadLine();


                if(kullanici_adi=="atakan"&&sifre=="123")
                    {
                    Console.WriteLine("Tebrikler Başarılı Şekilde Giriş Yaptınız");
                    break;

                }

                else
                {
                    Console.WriteLine("Kullanıcı adınız veya Şifreniz Yanlış.");
                    if (hak_sayisi > 0)
                    {
                        hak_sayisi -= 1;
                    }
                    if(hak_sayisi==0)
                    {
                        Console.WriteLine("Giriş Hakkınız Kalmamıştır.");
                        break;
                    }
                }
            }

            Console.ReadLine();
            */






            //Örnek
            //kullanıcıdan bir sayı alacağız 0'dan başlayıp aldığımzı sayıya kadar toplayacağız
            // girdiği sayıyı toplayıp ortalama alıcaz

            /*
            Console.WriteLine("Lütfen bir sayı giriniz:");

            int sayi = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;

            for(int i=1;i<=sayi;i++)
            {
                toplam += 1;//toplam = toplam+i;
            }

            double ortalama = toplam / sayi;

            if(ortalama>50)
            {
                Console.WriteLine("Ortalamanız 50'den büyüktür.");
            }
            else
            {
                Console.WriteLine("Ortalamanız 50'den küçüktür.");
                Console.ReadLine();
            }
            */






            //Diziler |ARRAY|
            // Dizilerde girilenler sırasıyla 0'dan başlar(0.index - 1.index - ....)



            //Örnek - Dizilerde değer atama ve yazdırma


            /*
            int[] sayilar = new int[5];//kaç değer verirsek o kadar index oluşturabiliriz.

            sayilar[0] = 10;
            sayilar[1] = 20;
            sayilar[2] = 30;
            sayilar[3] = 40;
            sayilar[4] = 50;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);
            }

            Console.ReadLine();
            */







            //Örnek
            // String - double - char


            /*
            string[] isimler = { "Atakan", "Pelin", "Zuhal", "Koray","Deniz" };
            //isimler 0-1-2 şeklinde sıradan gider.

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }
            Console.ReadLine();
            */

            /*
            double[] ondalikli_sayilar = new double[4];

            ondalikli_sayilar[0] = 1.44;
            ondalikli_sayilar[1] = 7.66;
            ondalikli_sayilar[2] = 8.34;
            ondalikli_sayilar[3] = 10.5;

            for(int i=0;i<ondalikli_sayilar.Length;i++)
            {
                Console.WriteLine(ondalikli_sayilar[i]);
            }

            Console.ReadLine();
            */









            //ÖRNEK - Dizinin elemanlarını kullanıcıdan alma

            /*
            int[] sayilar = new int[4];

            for(int i =0; i<sayilar.Length;i++)
            {
                Console.Write("Sayılar Dizisinin" + (i + 0) + ". index değerini giriniz.");

                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("*******");

            for (int i = 0; i < sayilar.Length; i++)
            {

                Console.WriteLine(sayilar[i]);
            }
            Console.ReadLine();
            */








            //ForEach Döngüsü(Diziler için kullanılan döngüdür)

            /*
            string[] isimler = { "aytun", "pelin", "deniz", "anıl","koray" };

            foreach (string a in isimler)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
            */

            /*
            int[] sayilar = new int[3];

            sayilar[0] = 4;
            sayilar[1] = 7;
            sayilar[2] = 3;

            foreach (int a in sayilar)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
            */







            //Çalışma
            /*
            baslangic:

            Console.WriteLine("1 Sayı Giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());

            if(a>0)
            {
                Console.WriteLine("Girdiğiniz Sayı Pozitiftir.");
            }

            else if(a<0)
            {
                Console.WriteLine("Girdiğiniz Sayı Negatiftir.");
            }

            else
            {
                Console.WriteLine("Girdiğiniz Sayı 0'dır.");
                goto baslangic;//etiket koyduğumuz satıra geri yönlendiriyoruz.
            }
            */










            //Kullanıcının girdiğini sayı ve dizinin içinde var mı ? Kontrol eden varsa kaçta olduğununu söyleyen yoksa da yoktur diye uyaran program


            /*
            int[] sayilar = { 10, 10, 20, 30, 20, 30, 40, 50, 40, 50, 70, 55, 65, 5, 20, 35, 65, 5, 20, 35, 65, 80 };
            int adet = 0;
            int sayi;
            Console.WriteLine("Bir Sayı Giriniz:");

            sayi=Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sayilar.Length; i++)
            {
                if(sayi==sayilar[i])
                {
                    adet++;
                }
            }


            if(adet==0)
            {
                Console.WriteLine("Girdiğiniz Değer Dizide Bulunamadı.");
            }

            else
            {
                Console.WriteLine("Girdiğiniz Sayı Dizide Bulundu...");
                Console.WriteLine("Adet : " + adet);
            }

            Console.ReadLine();
            */






            //Kullanıcıdan 10 tane int değer alan ve şunları yapan program Örneği
            //1- Kaç adet tek ve çift eleman olduğunu
            //2- Çift değerlerin ve tek değerlerin toplamı
            //3- Son olarak kontrol yapsın çift değerlerin toplamı tek değerlerden büyükse çift değerlerin toplamını yazdırsın.



            /*

            int[] sayilar = new int[10];

            int tekAdetToplam = 0;
            int ciftAdetToplam = 0;


            int tekSayilarToplami = 0;
            int ciftSayilarToplami = 0;

            int kullaniciDeger = 0;

            for(int i=0;i<sayilar.Length;i++)
            {
                Console.WriteLine((i + 0) + ".index değerini giriniz:");
                kullaniciDeger = int.Parse(Console.ReadLine());


                sayilar[i] = kullaniciDeger;//Kullanıcıdan alınan değerler ile içerisi doldururldu.

            }


            for(int j=0;j<sayilar.Length;j++)
            {
                if(sayilar[j]%2==0)
                {
                    ciftAdetToplam++;
                    ciftSayilarToplami += sayilar[j];
                }

                else
                {
                    tekAdetToplam++;
                    tekSayilarToplami += sayilar[j];

                }


            }


            if(ciftSayilarToplami>tekSayilarToplami)
            {
                Console.WriteLine("Çift Sayıların Toplamı Tek Sayıların Toplamından Büyüktür.");
            }

            else
            {
                Console.WriteLine("Tek Sayıların Toplamı Çift Sayıların Toplamından Büyüktür.");
            }

            Console.WriteLine("*****************************");

            Console.WriteLine("Çift Sayıların Toplamı : " + ciftSayilarToplami);
            Console.WriteLine("Çift Sayıların Adeti : "+ciftAdetToplam);


            Console.WriteLine("******************************");

            Console.WriteLine("Tek Sayıların Toplamı : " + tekSayilarToplami);
            Console.WriteLine("Tek Sayıların Adeti : " + tekAdetToplam);

            Console.ReadLine();


            */





            


























        }
    }
}
