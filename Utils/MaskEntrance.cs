using System;
using System.Collections.Generic;
using System.Text;

namespace SystemNomina.Utils
{
    public class MaskEntrance
    {

        static public string ReadMask()
        {
          var bf = new StringBuilder();
           while (true) {
                var key = Console.ReadKey(true); 
                
                if(key.Key == ConsoleKey.Enter)
                {
                    if (bf.Length == 10) break;
                    continue;
                }

                if(key.Key == ConsoleKey.Backspace && bf.Length > 0)
                {
                    bf.Remove(bf.Length - 1, 1);
                    Console.Write("\b \b");
                    continue;
                }

                if (char.IsLetter(key.KeyChar)) continue;

                if (bf.Length == 8)
                {
                    bf.Append('-');
                    Console.Write("-");
                }
                if (bf.Length < 10)
                {
                    char c = char.ToUpper(key.KeyChar);
                    bf.Append(c);
                    Console.Write(c);
                }

            }
           return bf.ToString();
        }
    }
}
