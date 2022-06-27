using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonTable
{
    public class TableGenerator
    {
        public string GenerateTable(dynamic json)
        {
            var result = String.Empty;

            PrintEmptyLine();
            Console.Write("| ");
            foreach (var item in json[0])
            {
                Console.Write("{0} | ", item.Name);                
            }

            PrintEmptyLine();

            foreach (var item in json)
            {
                Console.Write("| ");
                foreach (var item2 in item)
                {
                    Console.Write(item2.Value + " | ");
                }

                PrintEmptyLine();
            }

            return result;
        }

        private void PrintEmptyLine()
        {
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
