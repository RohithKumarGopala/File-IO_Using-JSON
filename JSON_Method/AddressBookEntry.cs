using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace JSON_Method
{
    class AddressBookEntry
    {
        class Contact
        {
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string City { get; set; }
            public string State { get; set; }

        }

        private List<Contact> contacts = new List<Contact>();

        public void AddContact()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your contact phone number: ");
            string phone = Console.ReadLine();


            Console.WriteLine("Enter Your Email: ");
            string Email = Console.ReadLine();


            Console.WriteLine("Enter your City: ");
            string city = Console.ReadLine();


            Console.WriteLine("Enter Your State: ");
            string State = Console.ReadLine();



            Contact contact = new Contact
            {
                Name = name,
                Phone = phone,
                Email = Email,
                City = city,
                State = State
            };

            contacts.Add(contact);

            Console.WriteLine("Contact added successfully!");
        }
        public void UpdateContact()
        {
            Console.WriteLine("Enter the name of the contact you want to update:");
            string name = Console.ReadLine();

            Contact contact = contacts.Find(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (contact == null)
            {
                Console.WriteLine("Contact not found!");
                return;
            }

            Console.WriteLine("Enter your name: ");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter your contact phone number: ");
            string phone = Console.ReadLine();


            Console.WriteLine("Enter Your Email: ");
            string Email = Console.ReadLine();


            Console.WriteLine("Enter your City: ");
            string city = Console.ReadLine();


            Console.WriteLine("Enter Your State: ");
            string State = Console.ReadLine();

            Console.WriteLine("Contact updated successfully!");
        }

        public void ViewContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("Address book is empty!");
                return;
            }

            Console.WriteLine("Contact List:");
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Name: {contact.Name}");
                Console.WriteLine($"Phone: {contact.Phone}");
                Console.WriteLine($"Email: {contact.Email}");
                Console.WriteLine($"City: {contact.City}");
                Console.WriteLine($"State: {contact.State}");
                Console.WriteLine("------------------");
            }
        }

        public void DeleteContact()
        {
            Console.WriteLine("Enter the name of the contact you want to delete:");
            string name = Console.ReadLine();

            Contact contact = contacts.Find(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (contact == null)
            {
                Console.WriteLine("Contact not found!");
                return;
            }

            contacts.Remove(contact);

            Console.WriteLine("Contact deleted successfully!");
        }
        public void SaveContact()
        {
            using (StreamWriter Writer = new StreamWriter(@"C:\Users\gopal\OneDrive\Desktop\JSON\File.txt", true))
            {
                string jsonContent = JsonConvert.SerializeObject(contacts);
                Writer.Write(jsonContent);

                Console.WriteLine("Contact Saved Successfully");
            }
        }
        public void ReadContacts()
        {
            if (File.Exists(@"C:\Users\gopal\OneDrive\Desktop\JSON\File.txt"))
            {
                using (StreamReader reader = new StreamReader(@"C:\Users\gopal\OneDrive\Desktop\JSON\File.txt"))
                {
                    string json = reader.ReadToEnd();
                    contacts = JsonConvert.DeserializeObject<List<Contact>>(json);
                }
                ViewContacts();
            }
            else
            {
                Console.WriteLine("File not exist");
            }
        }
    }
}


