using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var editor = new TextEditor();
            editor.WriteLine("Любіть Україну, як сонце любіть.");
            editor.Save();
            Console.WriteLine("Перше речення — " + editor.GetText());

            editor.WriteLine("Як вітер, і трави, і води…");
            editor.Save();
            Console.WriteLine("Друге речення — " + editor.GetText());

            editor.WriteLine("В годину щасливу і в радості мить,");
            Console.WriteLine("Третє речення — " + editor.GetText());

            editor.Undo();
            Console.WriteLine("Після одного скасування — " + editor.GetText());

            editor.Undo();
            Console.WriteLine("Після другого скасування — " + editor.GetText());
            Console.ReadKey();
        }
    }
}
