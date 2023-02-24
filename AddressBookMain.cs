using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        public static Contacts contacts = new Contacts();
        public static List<Contacts> Person = new List<Contacts>();
        public static void CreateContacts()
        {
            
            Console.WriteLine("Enter First Name : ");
            contacts.fName = Console.ReadLine();

            Console.WriteLine("Enter Last Name : ");
            contacts.lName = Console.ReadLine();

            Console.WriteLine("Enter address : ");
            contacts.address = Console.ReadLine();

            Console.WriteLine("Enter City : ");
            contacts.city = Console.ReadLine();

            Console.WriteLine("Enter State : ");
            contacts.state = Console.ReadLine();

            Console.WriteLine("Enter ZipCode : ");
            contacts.zipcode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Phone Number : ");
            contacts.phoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter Email : ");
            contacts.email = Console.ReadLine();
            Program.Person.Add(contacts);

        }

        public static void Dispaly()
        {
            foreach (var contact in Program.Person)
            {
                Console.WriteLine("First Name : " + contact.fName + "\nLast Name : " + contact.lName + "\naddress : " + contact.address + "\nCity : " + contact.city + "\nState : " + contact.state + "\nZipCode : " + contact.zipcode + "\nPhone Number : " + contact.phoneNumber + "\nEmail : " + contact.email);
            }
        }
        public static void EditContact()
        {
            Console.WriteLine("Edit a contact list enter first name");

            string name = Console.ReadLine();

            if (contacts.fName == name)
            {
                Console.WriteLine("Edit a Contact\n 1.lastName\n 2.Address\n 3.City\n 4.State\n 5.Zip\n 6.phone no\n 7.email");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        string lastName = Console.ReadLine();
                        contacts.lName = lastName;
                        break;
                    case 2:
                        string address = Console.ReadLine();
                        contacts.address = address;
                        break;
                    case 3:
                        string city = Console.ReadLine();
                        contacts.city = city;
                        break;
                    case 4:
                        string state = Console.ReadLine();
                        contacts.state = state;
                        break;
                    case 5:
                        string zipcode = Console.ReadLine();
                        contacts.zipcode = Convert.ToInt32(zipcode);
                        break;
                    case 6:
                        string phoneNo = Console.ReadLine();
                        contacts.phoneNumber = Convert.ToInt64(Console.ReadLine());
                        break;
                    case 7:
                        string email = Console.ReadLine();
                        contacts.email = email;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Name is not Exist");
            }
        }
        public static void Delete()
        {
            Contacts delete = new Contacts();
            Console.WriteLine("Delete a contact list enter first name : ");
            string name = Console.ReadLine();

            foreach (var contact in Program.Person)
            {
                if (contacts.fName == name)
                {
                    delete = contact;
                }
                else
                {
                    Console.WriteLine("Name does not exists");
                }
                Person.Remove(delete);
            }
        }
    }
}
