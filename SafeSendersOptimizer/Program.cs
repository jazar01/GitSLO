using System;

namespace SenderListOptimizer
{

    /// <summary>
    /// program class is used for unit testing from the console
    /// </summary>
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

        /// <summary>
        /// Simplified consloe writer
        /// </summary>
        /// <param name="str"></param>
        private static void write(string str)
        {
            Console.WriteLine(str);
        }
    }
}
