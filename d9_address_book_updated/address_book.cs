using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d9_address_book_updated
{
    public interface SystemProcess
    {

        void addAddress();
        void updateAddress();
        void deleteAddress();
        void display();


    }
    public class addressBookSystem
    {

        public String firstName;
        public String lastName;
        public String address;
        public String city;
        public String state;
        public String zip;
        public String phoneNumber;
        public String email;

        public addressBookSystem(String firstName, String lastName, String address, String city, String state, String zip, String phoneNumber, String email)
        {

            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;

        }


    }
    public class address_book : SystemProcess
    {

        private Dictionary<String, addressBookSystem> addressDetailDict;
        public address_book()
        {


            // addressDetailList = new LinkedList<addressBookSystem>();
            addressDetailDict = new Dictionary<String, addressBookSystem>();
            String exit = "n";
            while (exit == "n")
            {
                Console.Write("Enter your option for \n 1 Add address ");
                Console.WriteLine("Enter Your Option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1: addAddress(); break;

                }

                Console.WriteLine("Do you want to exit (y/n)");
                exit = Convert.ToString(Console.ReadLine());
            }

        }

        //Add Address Book
        public void addAddress()
        {
            String firstName, lastName, address, city, state, zip, phoneNumber, email;
            Console.WriteLine("Enter the first Name");
            firstName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Last Name");
            lastName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Address");
            address = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the city Name");
            city = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the state ");
            state = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the zip ");
            zip = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the phoneNumber");
            phoneNumber = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the email");
            email = Convert.ToString(Console.ReadLine());
            addressBookSystem adBook = new addressBookSystem(firstName, lastName, address, city, state, zip, phoneNumber, email);
            addressDetailDict.Add(firstName, adBook);
            Console.WriteLine("Total Details stored: " + addressDetailDict.Count);
            // throw new NotImplementedException();
        }

        public void updateAddress()
        {

        }

        public void deleteAddress()
        {
            //throw new NotImplementedException();
        }

        public void display()
        {
            // throw new NotImplementedException();
        }


    }
}