using dataTypes;

namespace action{
    class variable{
        string name;
        string type;
        dynamic value;

        public dynamic getValue(){
            return this.value; // Return the variables value.
        }
    }
}