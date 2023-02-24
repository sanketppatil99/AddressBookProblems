namespace AddressBook
{
    class Program
    {
        public static List<Contacts> Person = new List<Contacts>();
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to address Book System");
            AddressBookMain.CreateContacts();


            bool end = true;
            while (true)
            {
                Console.WriteLine("Select Option\n1.add Contact \n2.Display \n3.Edit Contact \n4.end");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddressBookMain.CreateContacts();
                        break;
                    case 2:
                        AddressBookMain.Dispaly();
                        break;
                    case 3:

                        AddressBookMain.EditContact();
                        break;
                    case 4:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Incorrect Option");
                        break;
                }
            }
        }
    }
}
