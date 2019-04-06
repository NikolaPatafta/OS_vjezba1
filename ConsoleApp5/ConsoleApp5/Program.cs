using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
            
        {
            // Uzimamo direktorij iz odredjenog diska
            DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();

            // pisemo na odredeni direktorij
            using (StreamWriter sw = new StreamWriter("CDriveDirs.txt"))
            {
                foreach (DirectoryInfo dir in cDirs)
                {
                    sw.WriteLine(dir.Name);

                }
            }

            // Citamo svaku liniju odredjene datoteke
            string line = "";
            using (StreamReader sr = new StreamReader("CDriveDirs.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}



