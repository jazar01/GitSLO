using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenderListOptimizer
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath;
            string publicdomainpath;

            write("Number of arguments = " + args.Length);
            if (args.Length < 1)
                write("Less than 2 arguments");

            write("\nArguments:");
            foreach (string parm in args)
              write(parm);
              

            filepath = args[0];
            publicdomainpath = args[1];

            write("\nNow showing all lines in " + filepath);
            SendersList sl = new SendersList(filepath, publicdomainpath);

            write("\nNow showing senders and domains");
            sl.ShowParsedList();
            write("\nEnd");

        }

        private static void write(string str)
        {
            Console.WriteLine(str);
        }
    }
}
