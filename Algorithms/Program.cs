using System.Collections;
using System.Text;
using System.Threading.Channels;

namespace List
{
    public class Sehir : IComparable<Sehir>
    {
        public override string ToString()
        {
            return $"{PlakaNo,-5}  {SehirAdi,-15}";
        }

        public int CompareTo(Sehir? other)
        {
            if (this.PlakaNo < other?.PlakaNo)
            {
                return -1;
            }
            else if (this.PlakaNo == other?.PlakaNo)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public Sehir(int plakaNo, string sehirAdi)
        {
            PlakaNo = plakaNo;
            SehirAdi = sehirAdi;
        }
        public int PlakaNo { get; set; }

        public string SehirAdi { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            /*// hash table example

                {
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
*/



            // sorted list example

            /*
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
            */

            /*
                        var kitapicerigi = new SortedList();
                        kitapicerigi.Add(1, "Önsöz");
                        kitapicerigi.Add(25, "Değişkenler");
                        kitapicerigi.Add(35, "Veri tipleri");
                        kitapicerigi.Add(20, "İlişkisel Operatörler");
                        kitapicerigi.Add(10, "Döngüler");
                        kitapicerigi.Add(50, "Operatörler");

                        Console.WriteLine("İçincdekiler");
                        Console.WriteLine(new string('-',25));

                        Console.WriteLine($"{"Konular",-30} {"Sayfalar",5}");

                        foreach (DictionaryEntry item in kitapicerigi)
                        {
                            Console.WriteLine($"{item.Value, -30} {item.Key,5}");
                        }*/

            /*
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


            */
            /*  Console.WriteLine("Lütfen bir sayı giriniz: ");
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
                 Console.WriteLine($"\t{item,7} x {Math.Pow(10,n-i),7}\t = {item*Math.Pow(10,n-i),7}");
                 i++;
             }
             Console.ReadKey();
  */

            // Queue Example

            /*     var q1 = new Queue();
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
                foreach(var i in q1)
                {
                    System.Console.WriteLine(i);
                }
                q1.Peek(); */


            // Linked List <type> Example 

            // linked listlere indis ile erişim yapılamaz sadece düğümler ve find metotu
            // ile ulaşılabilir. önceki, sonraki, ilk, son ve find ile ulaşılabilir.

            var sehirler =new LinkedList<string>();
        sehirler.AddFirst("Ankara");
        sehirler.AddFirst("İstanbul");
        sehirler.AddFirst("İzmir");
        sehirler.AddFirst("Adana");
        sehirler.AddLast("Van");
        sehirler.AddAfter(sehirler.Find("İstanbul"),"Trabzon");6
        sehirler.AddAfter(sehirler.Last.Previous,"Ordu");
            sehirler.AddBefore(sehirler.Find("Ankara"), "Elazığ");

        foreach(string sehir in sehirler)
        {
            System.Console.WriteLine(sehir);
        }







        }
    }
}