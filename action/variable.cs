using dataTypes;

namespace action{
    class variable{
        string name;
        string type;
        dynamic value; // This will be one of our data type objects.

        public dynamic getValue(){
            return this.value; // Return the variables value.
        }
    }
}