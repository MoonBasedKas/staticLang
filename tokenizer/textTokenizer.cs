using System.Collections;
using System.IO;
using action;

namespace tokenizer
{
    class textTokenizer
    {
        ArrayList textLines;
        ArrayList tokens;

        globalEntry start;

        // Combines all of the provided files into one big program.
        public textTokenizer(ArrayList files)
        {
            for (int i = 0; i < files.Count; i++)
            {
                this.getLines((string)files[i]);
            }
            // TODO tokenize
        }

        private int getLines(string fileName)
        {
            StreamReader fp = new StreamReader(fileName);
            string line = "";
            while (line != null)
            {
                fp.ReadLine();
                textLines.Add(line);
            }
            return 0;
        }

        private globalEntry tokenizer()
        {
            return null;
        }

        public globalEntry getGlobalEntry()
        {
            return start;
        }
    }
}