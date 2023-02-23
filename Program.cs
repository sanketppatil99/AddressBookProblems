namespace AddressBook
{
    class Program
    {
        public static List<Contacts> Person = new List<Contacts>();
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to address Book System");
            AddressBookMain addressBookMain = new AddressBookMain();
            addressBookMain.CreatContact();
        }
    }
}
