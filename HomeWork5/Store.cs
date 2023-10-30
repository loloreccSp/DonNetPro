

namespace HomeWork5
{
    public class Store : IDisposable
    {
        public string NameStore { get; set; }
        public string Address { get; set; }
        public string TypeStore { get; set; }
        
        public Store(string nameStore, string address, string typeStore) 
        {
            NameStore = nameStore;
            Address = address;
            TypeStore = typeStore;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Welcome to the '{NameStore}' store at the address {Address}. Type of store {TypeStore}");
        }

        //v1
        public void Dispose()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nThis store no longer exists!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //v2
        ~Store() 
        {
            Dispose();
        }
    }
}
