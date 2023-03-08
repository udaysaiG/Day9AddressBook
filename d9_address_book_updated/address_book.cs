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
                Console.Write("Enter your option for \n 1) Add address \n 2) Update Address \n 3) Delete Address");
                Console.WriteLine("\n Total Details stored: " + addressDetailDict.Count + "\n");
                Console.WriteLine("\n Enter Your Option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1: addAddress(); break;
                    case 2: updateAddress(); break;
                    case 3: deleteAddress(); break;

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

            // throw new NotImplementedException();
        }

        public void updateAddress()
        {
            Console.WriteLine("Enter the firstname to update field");
            String name = Convert.ToString(Console.ReadLine());
            if (addressDetailDict.ContainsKey(name))
            {
                Console.WriteLine("ENter First Name");
                addressDetailDict[name].firstName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("ENter last Name");
                addressDetailDict[name].lastName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("ENter address ");
                addressDetailDict[name].address = Convert.ToString(Console.ReadLine());
                Console.WriteLine("ENter city");
                addressDetailDict[name].city = Convert.ToString(Console.ReadLine());
                Console.WriteLine("ENter state");
                addressDetailDict[name].state = Convert.ToString(Console.ReadLine());
                Console.WriteLine("ENter zip");
                addressDetailDict[name].zip = Convert.ToString(Console.ReadLine());
                Console.WriteLine("ENter phone number");
                addressDetailDict[name].phoneNumber = Convert.ToString(Console.ReadLine());
                Console.WriteLine("ENter email");
                addressDetailDict[name].email = Convert.ToString(Console.ReadLine());
            }
            else
            {

                Console.WriteLine("No key with name " + name + " found");

            }
        }

        public void deleteAddress()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Enter the firstname to delete");
            String name = Convert.ToString(Console.ReadLine());
            if (addressDetailDict.ContainsKey(name))
            {
                addressDetailDict.Remove(name);
                Console.WriteLine("-------------Deleted Successfully ----------------");
            }
            else
            {
                Console.WriteLine("Name not found");
            }
        }

        public void display()
        {
            // throw new NotImplementedException();
        }


    }
}
