using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TABLE_DRIVEN_TUBES_KPL
{
    internal class MAIN
    {
        private static void Main(string[] args)
        {
            CariHistoryPayment search = new CariHistoryPayment();
            search.toArray();
            Console.WriteLine("Masukan Nama: ");
            String input = Console.ReadLine();
            search.cariByNama(input);
            int index = search.returnIndex(input);
            
            if(index != -1 )
            {
                Console.WriteLine($"Nama {input} ada pada index {index}");
            } else
            {
                Console.WriteLine("Index Tidak Ditemukan");
            }
        }
    }
}
