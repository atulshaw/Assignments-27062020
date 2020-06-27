using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter input");
            List<string> lst = new List<string>();
            while (true)
            {
                string userinput = Console.ReadLine();
                if (userinput.Contains("#"))
                {
                    lst.Add(userinput);
                }
                if (userinput.ToUpper() == "THE END")
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (i > 1)
                        {
                            if (lst[i].Split('#')[1].Trim() == lst[i - 1].Split('#')[1].Trim())
                            {
                                Console.WriteLine(Convert.ToString(lst[i - 1]).Replace("#"," "));
                                break;
                            }
                        }
                    }                    
                }                
            }
        }
    }
}
