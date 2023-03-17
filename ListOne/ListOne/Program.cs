using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ListOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            /*ADD*/

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");

            list.Insert(2, "Marco");

            foreach(string item in list)
            {
                Console.WriteLine(item);
            }

            /*CONTAGEM*/

            Console.WriteLine("List count: "+ list.Count);

            /*Filtro com primeiro nome com 'A'*/
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': "+ s1);

            /*Filtro com ULTIMO nome com 'A'*/
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': "+ s2);

            /*Filtro com primeiro POSIÇÃO com 'A'*/
            int pos1 = list.FindIndex(x => x[0]=='A');
            Console.WriteLine("First position 'A': "+pos1);

            /*Filtro com ultima Posição com 'A'*/
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("lAST position 'A': " + pos2);

            /*Filtro com lista de todos que tem  5 caracteres */
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------");

            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            /* Remove dados da lista */
            list.RemoveAt(3);
            Console.WriteLine("-----------------");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            /* Remove all da lista */

            list.RemoveAll(x => x[0]=='M');
            Console.WriteLine("-----------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }





        }
    }
}
