using System;
using System.Collections;
using tokenizer;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList targets = new ArrayList();
            if(args.Length == 0){
                Console.WriteLine("Error | was not provided a file.");
            } else{
                targets.Add(args[0]);
                textTokenizer tokens = new textTokenizer(targets);
            }
        }
    }
}