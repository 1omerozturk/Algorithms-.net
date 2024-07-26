using Algorithms;
using System.Collections;
using System.Numerics;
using System.Text;
using System.Threading.Channels;

namespace List
{
    public class Program
    {
        public static void Main(string[] args)
        {




            // SortedSet Küme işlemleri

            //SortedSet<int> A, B;

            //Yazdirma(out A, out B);

            //Birlesim(A, B);

            //Kesisim(A, B);

            //Cıkarma(A, B);

            //KesisimDışı(A, B);

            //SubSetAltKume(A, B);


            /*
                        HashListExample();
                        

                        SortedListExample();

                        StackExample();

                        QueueExample();

                        LinkedList();

                        DictionaryExam();

                        DictionaryExample();

                        SortedDictionaryExample();
                        
                        SortedSetExample();
            
                        HashSetExm();
             */



            static void HashListExample()
            {
                // hash table example


                Console.WriteLine("Bir Başlık giriniz: ");
                string baslik = Console.ReadLine();

                baslik = baslik.ToLower();

                var karakterSeti = new Hashtable()
            {
                { 'ç','c'},
                { 'ı','i'},
                { 'ğ','g'},
                { 'ü','u'},
                { 'ö','o'},
                {'\'','-' },
                {'.','-' }
            };

                foreach (DictionaryEntry item in karakterSeti)
                {
                    baslik = baslik.Replace((char)item.Key, (char)item.Value);
                }
                Console.WriteLine(baslik);
                Console.ReadKey();

            }
        }

        private static void HashSetExm()
        {

            // HashSet <T>

            //* System.Collections.Generic sınıfı altında bulunur
            //* Type safe'dir
            //* eleman benzersizdir.
            //* sıralama yok.
            //* küme işlemlerine izin verir.

            var sesliHarf = new HashSet<char>()
            {
                'e',
                'ı',
                'i',
                'u',
                'ü',
                'o',
                'ö'
            };

            // Yazdırma: 
            KoleksiyonYazdir(sesliHarf);

            // Ekleme - Add
            sesliHarf.Add('a');
            KoleksiyonYazdir(sesliHarf);

            // listeden çıkarma
            sesliHarf.Remove('e');
            KoleksiyonYazdir(sesliHarf);


            var alfabe = new List<char>();
            for (int i = 97; i < 123; i++)
            {
                alfabe.Add((char)i);
            }
            KoleksiyonYazdir(alfabe);

            // Türkçe'de kullanılan sesli harfler
            //sesliHarf.ExceptWith(alfabe);
            //sesliHarf.UnionWith(alfabe);
            //sesliHarf.IntersectWith(alfabe);
            sesliHarf.SymmetricExceptWith(alfabe);

            KoleksiyonYazdir(sesliHarf);




            Console.ReadKey();

            static void KoleksiyonYazdir(IEnumerable koleksiyon)
            {
                Console.WriteLine();
                int t = 0;
                Console.WriteLine("\nSesli harfler:");
                foreach (char i in koleksiyon)
                {
                    Console.Write($"{i,3}");
                    t++;
                }
                Console.WriteLine("\nEleman sayisi: {0}", t);
            }
        }

        private static void SubSetAltKume(SortedSet<int> A, SortedSet<int> B)
        {

            // Alt küme - Subset
            Console.WriteLine(B.IsSubsetOf(A));
        }

        private static void KesisimDışı(SortedSet<int> A, SortedSet<int> B)
        {

            //Kesişim dışındaki elemanlar - Symetric Exception

            #region kesişim dışındaki elemanlar
            A.SymmetricExceptWith(B);
            Console.WriteLine();
            Console.WriteLine("\n\n Kesişim dışındaki elemanlar: ");
            foreach (var s in A)
            {
                Console.WriteLine(s);
            }

            #endregion
        }

        private static void Cıkarma(SortedSet<int> A, SortedSet<int> B)
        {
            // Cıkarma - Exception
            #region Çıkarma
            A.ExceptWith(B);
            Console.WriteLine();
            Console.WriteLine("\n\n Sadece A");
            foreach (var s in A)
            {
                Console.WriteLine(s);
            }

            #endregion
        }

        private static void Kesisim(SortedSet<int> A, SortedSet<int> B)
        {
            #region Kesisim

            // Kesişim - IntersectWith
            Console.WriteLine("İki kümenin kesişimi: ");
            A.IntersectWith(B);
            foreach (var i in A)
            {
                Console.WriteLine($"{i,5}");
            }

            #endregion
        }

        private static void Birlesim(SortedSet<int> A, SortedSet<int> B)
        {
            #region Birlesim

            // Birleşim - Union
            A.UnionWith(B);
            Console.WriteLine("Birleşim kümesi: ");
            foreach (var x in A) Console.WriteLine(x);

            #endregion
        }

        private static void Yazdirma(out SortedSet<int> A, out SortedSet<int> B)
        {
            #region yazdirma

            //var A = new SortedSet<int>() { 1, 2, 3, 4, 5 };
            A = new SortedSet<int>(RastgeleSayiUret(8));
            B = new SortedSet<int>(RastgeleSayiUret(3));

            static List<int> RastgeleSayiUret(int n)
            {
                var list = new List<int>();
                var r = new Random();
                for (int i = 0; i < n; i++)
                {
                    list.Add(r.Next(0, 10));

                }
                return list;
            }

            Console.WriteLine("A kümesi: \n");
            foreach (var x in A) Console.WriteLine(x);
            Console.WriteLine("B kümesi: \n");
            foreach (var x in B) Console.WriteLine(x);

            #endregion
        }

        private static void SortedSetExample()
        {

            // SortedSet Example

            //* System.Collections.Generic sınıfı altında yer alır
            //* generic yapıdadır 
            //* elemanlar benzersizdi.
            //* Sıralama ekleme sırasında yapılır.
            //* Add işlemi boolean değer döndürür.
            //* Remove silme
            //* Remove Where (Predicate) => koşul ifadesi ile çalışır ve lambda şeklinde yazılır.
            //* Dinamik ve kesişim, birleşim, ayrım, altküme işlemlerini içerir.

            var list = new SortedSet<string>();
            if (list.Add("Ömer"))
            {
                Console.WriteLine("Ömer eklendi");
            }

            Console.WriteLine("{0}", list.Add("Öztürk") == true ? "Öztürk eklendi" : "Ekleme başarısız.");

            // SortedSet Example 2
            var r = new Random();
            var sayilar = new List<int>();
            Console.WriteLine();

            for (int i = 0; i < 100; i++)
            {
                sayilar.Add(r.Next(100));
                Console.WriteLine($"{sayilar[i],-3}");
            }
            Console.WriteLine();

            // listedeki benzersiz elemanları seçmek

            var benzersizSayilar = new SortedSet<int>(sayilar);

            Console.WriteLine("\nBenzersiz sayilar listesi:\n");
            foreach (var item in benzersizSayilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Benzersiz {benzersizSayilar.Count} sayi var");
            Console.ReadKey();
        }

        private static void SortedDictionaryExample()
        {

            // Sorted Dictionary
            //* system.collection.generic sınıfı altında 
            //* Dictionary sınıfı altındaki tüm metotlar geçerlidir.
            //* Veri ekleme adımında sıralama işlemi yaptığı için bir miktar veri kaybı yaşanmaktadır.
            //* Sıralama işlemi TKey ifadesine göre yapılır.

            var kitap = new SortedDictionary<string, List<int>>()
            {
                {"HTML",new List<int>{23,57,89} },
                {"CSS",new List<int>{32,44,73} },
                {"Bootstrap",new List<int>{51,66,90} }

            };
            kitap.Add("FTP", new List<int> { 4, 6, 9 });
            kitap.Add("ASP .NET Core", new List<int> { 15, 26, 35 });
            kitap.Add("Identity Framework", new List<int> { 50, 63, 87 });
            kitap.Add("ASP .NET MVC", new List<int> { 96, 123, 143 });


            foreach (var konu in kitap)
            {
                Console.WriteLine($"{konu.Key,-5} Subject: ");
                konu.Value.ForEach(x => Console.WriteLine(x));
            }
        }

        private static void DictionaryExample()
        {
            var personelListesi = new Dictionary<int, Personel>();
            personelListesi.Add(1, new Personel(123, "Ömer", "Öztürk", 40000));
            personelListesi.Add(2, new Personel(124, "Buse", "Öztürk", 70000));
            personelListesi.Add(3, new Personel(125, "Nur", "Öztürk", 40000));

            foreach (var item in personelListesi)
            {
                Console.WriteLine(item);
            }
        }

        private static void DictionaryExam()
        {
            var telefonKodlari = new Dictionary<int, string>()
            {
                {424,"Elazığ" },
                { 332,"Konya"},
                {123,"Art" }
            };

            // sözlük yapısında key bulunduğu için ve aynı değer alamayacağı
            // için derleme zamanında hata vermezken çalışma zamanında hata verir.
            // Aynı zamanda farklı key ile aynı değer kayıdı yapılabilir.

            // Ekleme

            telefonKodlari.Add(322, "Adana");
            //telefonKodlari.Add(322, "İstanbul");
            telefonKodlari.Add(212, "İstanbul");
            telefonKodlari.Add(216, "İstanbul");

            // Dolaşma

            foreach (var item in telefonKodlari)
            {
                Console.WriteLine(item);
            }

            // Erişme
            telefonKodlari[123] = "Denizli";

            // ContainsKey
            Console.WriteLine("Key ile ulaşma");
            telefonKodlari.ContainsKey(332);

            // ContainsValue
            Console.WriteLine("Value ile ulaşma");
            if (!telefonKodlari.ContainsValue("Malatya"))
            {
                Console.WriteLine("Malatya'nın kod bilgisi tanımlı değil");
                telefonKodlari.Add(312, "Malatya");
                Console.WriteLine("Malatya kod bilgisi eklendi.");
                Console.WriteLine(telefonKodlari[312]);

            }

            // Tüm elemanları dolaşma

            foreach (var item in telefonKodlari)
            {
                Console.WriteLine(item);
            }

            // Eleman silme

            telefonKodlari.Remove(123);
            foreach (var item in telefonKodlari)
            {
                Console.WriteLine(item);
            }

            // Sözlük yapısını temizlme:

            telefonKodlari.Clear();
            Console.WriteLine("Dictionary cleared.");

            foreach (var item in telefonKodlari)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static void SortedListExample()
        {


            // sorted list example


            var list = new SortedList()
                        {
                            {1,"Bir" },
                            {2,"İki" },
                            {3,"Üç" },
                            {4,"Dört" },
                            {5,"Beş" },
                            {6,"Altı" },
                            {7,"Yedi" },
                            {8,"Sekiz" },
                            {9,"Dokuz" },
                            {10,"On" }

                        };

            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.WriteLine("Listedeki eleman sayısı: {0}", list.Count);
            Console.WriteLine("Listenin kapasitesi: {0}", list.Capacity);
            list.TrimToSize();
            Console.WriteLine("Listenin kapasitesi: {0}", list.Capacity);

            Console.WriteLine(list[4]);
            Console.WriteLine(list.GetByIndex(6));
            Console.WriteLine(list.GetKey(9));
            Console.WriteLine("Liste sonundaki eleman: {0}", list.GetByIndex(list.Count - 1));
            Console.WriteLine("\n \tAnahtarlar");
            foreach (var item in list.Values)
            {
                Console.WriteLine(item);
            }


            if (list.ContainsKey(1))
                list[1] = "One";

            Console.WriteLine(list[1]);



            var kitapicerigi = new SortedList();
            kitapicerigi.Add(1, "Önsöz");
            kitapicerigi.Add(25, "Değişkenler");
            kitapicerigi.Add(35, "Veri tipleri");
            kitapicerigi.Add(20, "İlişkisel Operatörler");
            kitapicerigi.Add(10, "Döngüler");
            kitapicerigi.Add(50, "Operatörler");

            Console.WriteLine("İçincdekiler");
            Console.WriteLine(new string('-', 25));

            Console.WriteLine($"{"Konular",-30} {"Sayfalar",5}");

            foreach (DictionaryEntry item in kitapicerigi)
            {
                Console.WriteLine($"{item.Value,-30} {item.Key,5}");
            }


            var plakalar = new List<int>() { };
            var sehirler = new List<Sehir>()
                        {
                            new Sehir(6,"Ankara"),
                            new Sehir(23,"Elazığ"),
                            new Sehir(55,"Samsun"),
                            new Sehir(44,"Malatya"),
                            new Sehir(58,"Sivas"),
                            new Sehir(53,"Rize"),
                            new Sehir(54,"Sakarya"),};
            sehirler.Sort();
            sehirler.ForEach(x => { Console.WriteLine(x); });
            Console.ReadKey();
        }

        private static void StackExample()
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            var sayiYigini = new Stack<int>();

            while (sayi > 0)
            {
                int k = sayi % 10;
                sayiYigini.Push(k);
                sayi = sayi / 10;
            }

            int i = 0;
            int n = sayiYigini.Count - 1;

            foreach (var item in sayiYigini)
            {
                Console.WriteLine($"\t{item,7} x {Math.Pow(10, n - i),7}\t = {item * Math.Pow(10, n - i),7}");
                i++;
            }
            Console.ReadKey();
        }

        private static void QueueExample()
        {

            // Queue Example

            var q1 = new Queue();
            q1.Enqueue(1);
            q1.Enqueue(2);
            q1.Enqueue(3);
            q1.Enqueue(4);
            q1.Enqueue(5);
            System.Console.WriteLine(q1);
            foreach (var item in q1)
            {
                System.Console.WriteLine(item);
            }
            q1.Dequeue();
            q1.Dequeue();
            q1.Dequeue();
            foreach (var i in q1)
            {
                System.Console.WriteLine(i);
            }
            q1.Peek();
            Console.ReadKey();
        }

        private static void LinkedList()
        {
            // Linked List <type> Example 

            // linked listlere indis ile erişim yapılamaz sadece düğümler ve find metotu
            // ile ulaşılabilir. önceki, sonraki, ilk, son ve find ile ulaşılabilir.

            var sehirler = new LinkedList<string>();
            sehirler.AddFirst("Ankara");
            sehirler.AddFirst("İstanbul");
            sehirler.AddFirst("İzmir");
            sehirler.AddFirst("Adana");
            sehirler.AddLast("Van");
            sehirler.AddAfter(sehirler.Find("İstanbul"), "Trabzon");
            sehirler.AddAfter(sehirler.Last.Previous, "Ordu");
            sehirler.AddBefore(sehirler.Find("Ankara"), "Elazığ");


            // Tüm verileri dolaşma
            foreach (string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }



            // İlk veriden başlayarak while ile tüm verileri dolaşma 
            var eleman = sehirler.First;
            while (eleman != null)
            {
                Console.WriteLine(eleman.Value);
                eleman = eleman.Next;
            }


            // Son elemandan başlayarak tüm verileri dolaşma

            var son = sehirler.Last;
            while (son != null)
            {
                Console.WriteLine(son.Value);
                son = son.Previous;
            }
        }
    }
}