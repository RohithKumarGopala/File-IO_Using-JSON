namespace JSON_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBookEntry addressBook = new AddressBookEntry();

            while (true)
            {
                Console.WriteLine("Address Book Menu");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Update Contact");
                Console.WriteLine("3. View Contacts");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5.Save Contact");
                Console.WriteLine("6.Read Contact");
                Console.WriteLine("7. Exit");

                Console.Write("Enter your choice (1-5): ");
                int choice = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        addressBook.AddContact();
                        break;
                    case 2:
                        addressBook.UpdateContact();
                        break;
                    case 3:
                        addressBook.ViewContacts();
                        break;
                    case 4:
                        addressBook.DeleteContact();
                        break;
                    case 5:
                        addressBook.SaveContact();
                        break;
                    case 6:
                        addressBook.ReadContacts();
                        break;
                    case 7:
                        Console.WriteLine("Exited Successfully");
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}