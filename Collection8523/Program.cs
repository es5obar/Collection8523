using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection8523
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirListesi = new List<string>();
            sehirListesi.Add("İstanbul");
            sehirListesi.Add("Ankara");
            foreach (var sehir in sehirListesi)
            {
                Console.WriteLine(sehir);
            }

            List<Sehir> sehirler = new List<Sehir>()
            {
                new Sehir()
                {
                    Plaka = "06",
                    Adi = "Ankara"

                },
                new Sehir()
                {
                    Plaka = "07",
                    Adi = "Antalya"
                }
            };

            sehirler.Add(new Sehir() { Plaka = "67", Adi = "Zonguldak" });

            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir.Plaka + " - " + sehir.Adi);
            }

            #region Collection Method
            int count = sehirler.Count;  // 3

            for (int i = 0; i < sehirler.Count; i++)
            {
                Console.WriteLine(sehirler[i].Plaka + " - " + sehirler[i].Adi);
            }

            // List<Sehir>
            Sehir[] yeniSehirler = new Sehir[2]
            {
                new Sehir()
                {
                    Plaka ="19",
                    Adi = "Çorum"
                },
                new Sehir()
                {
                    Plaka = "21",
                    Adi = "Diyarbakır"
                }
            };
            sehirler.AddRange(yeniSehirler);

            IEnumerable<string> names1 = new List<string>()
            {
                "Max", "Charlize", "Robert", "Jasmine"
            };
            ICollection<int> numbers1 = new List<int>()
            {
                1,2,3,4
            };

            List<string> names2 = new List<string>()
            {
                "Max" , "Charlize" , "Robert" , "Jasmine"
            };

            names2.Sort();

            Console.WriteLine(names1.Contains("Max")); // true
            Console.WriteLine(names1.Contains("max")); // false
            Console.WriteLine(names1.Contains("Michael")); // false

            bool varMi = sehirler.Contains(new Sehir() { Plaka = "06", Adi = "Ankara" }); //false

            Sehir sehir1 = sehirler[0]; // ankara
            varMi = sehirler.Contains(sehir1); // true
            int index = sehirler.IndexOf(sehir1); // 0
            int lastIndex = sehirler.LastIndexOf(sehir1); //0
            sehirler.Insert(0, new Sehir() { Plaka = "", Adi = "Seçiniz" });
            sehirler.Remove(sehir1); // ankara çıktı
            sehirler.Clear();
            #endregion

            #region Dictionary
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["book"]); // kitap

            foreach (var item in dictionary) // [book, kitap]
            {
                Console.WriteLine(item.Key + ": " + item.Value); // book: kitap
            }
            foreach (var item in dictionary.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (var item in dictionary.Values)
            {
                Console.WriteLine(item);
            }

            if (dictionary.ContainsKey("glass")) // false
            {
                Console.WriteLine("glass var");
            }
            else
            {
                Console.WriteLine("glass yok");
            }
            if (dictionary.ContainsValue("bilgisayar")) // true
            {
                Console.WriteLine("bilgisayar var");
            }
            else
            {
                Console.WriteLine("bilgisayar yok");
            }

            Dictionary<string, Sehir> sehirDictionary = new Dictionary<string, Sehir>()
            {
                { "a" , new Sehir() {Plaka = "06", Adi = "Ankara"}},
                { "i" , new Sehir() { Plaka = "34", Adi ="İstanbul"} },
                { "d", new Sehir() { Plaka = "01" , Adi ="Adana"} },
            };
            Console.WriteLine(sehirDictionary["a"].Adi);
            Console.WriteLine(sehirDictionary["d"].Plaka + ": " + sehirDictionary["d"].Adi);
            #endregion
            Console.ReadLine();
        }
    }

    class Sehir
    {
        public string Plaka { get; set; }

        public string Adi { get; set; }
    }
}
