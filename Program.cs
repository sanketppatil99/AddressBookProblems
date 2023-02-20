namespace AddressBook
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address Book System");
            AddressBookMain addressBookMain = new AddressBookMain();
            addressBookMain.CreatContact();
        }
    }
}
