using System.Collections;
using System.IO;

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
            for (int i = 0; i < files.size(); i++)
            {
                this.getLines(files.get(i))
            }
            // TODO tokenize
        }

        private getLines(string fileName)
        {
            StreamReader fp = new StreamReader(fileName);
            string line = "";
            while (line != null)
            {
                fp.ReadLine();
                textLines.add(line);
            }
            fp.close()
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