using System.Collections;

namespace action
{
    class globalEntry : function
    {
        public ArrayList libraries;
        public ArrayList functions;
        public function main;

        public int execute()
        {
            main.execute(); // Executes the entry point.
            return 0;
        }

        /**
        Finds referenced variables.
        Order of checking:
        1. variables
        2. functions
        3. libraries
        */
        private dynamic findReference(string name)
        {
            function functionx = null;
            dynamic res = null;
            // Looks for variable references.
            for (int i = 0; i < this.variables.Count; i++)
            {
                if (string.Equals(name, this.variables[i])) {
                    return this.variables[i];
                }
            }

            // Looks for function references.
            for (int i = 0; i < this.functions.Count; i++)
            {
                if (string.Equals(name, this.variables[i])) {
                    functionx = (function) this.functions[i];
                    res = functionx.execute();
                }
            }
            // TODO: Libraries.

            return res;
        }
    }
}