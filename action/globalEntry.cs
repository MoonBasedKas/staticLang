namespace action
{
    class globalEntry : function
    {
        ArrayList libraries;
        ArrayList functions;
        function main;

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
            // Looks for variable references.
            for (int i = 0; i < this.variables.size(), i++)
            {
                if (string.Equals(name, this.variables.get(i))) return this.variables.get(i);
            }

            // Looks for function references.
            for (int i = 0; i < this.functions.size(), i++)
            {
                if (string.Equals(name, this.variables.get(i))) return this.functions.get(i).execute();
            }
            // TODO: Libraries.
        }
    }
}