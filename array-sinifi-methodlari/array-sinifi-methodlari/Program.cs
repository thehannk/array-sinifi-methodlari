using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_sinifi_methodlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sort
            int[] sayiDizisi = { 23, 12, 76, 45, 98, 1, 8, 98 };
            foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);
            
            
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            

            //Clear 
            Array.Clear(sayiDizisi,2,2);    //2. indexten başlayarak 2 tane elemanı clear et
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            

            //Reverse
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //IndexOf
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));    //23 değeri kaçıncı indexte?

            //Resize
            Array.Resize<int>(ref sayiDizisi, 9);   //8 elemanlı olan diziyi 9 elemanlı olarak arttır.
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);


            Console.ReadLine();

        }
    }
}
