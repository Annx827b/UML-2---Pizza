using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UML_2___Pizza;
using UML_2_PizzaStore;

namespace UML_2___Pizza
{
    class CustomerCatalog
    {
        #region My List
        public List<Customer> customerList = new List<Customer>();
        #endregion

        #region Customer List
        public void CustomerList()
        {
            Customer customer1 = new Customer(1, "Harry Potter", "Roskilde", 4000, "Troldevej", 20, 20973040, "Harrypotter@gmail.com");
            Customer customer2 = new Customer(2, "Niels Hansen", "Roskilde", 4000, "Svalevej", 12, 40384030, "Niels@hotmail.com");
            Customer customer3 = new Customer(3, "Mathilde Jørgensen", "Holbæk", 4300, "Vestervangen", 26, 90107854, "Math95@gmail.com");
            Customer customer4 = new Customer(4, "Charlotte Christensen", "Mørkøv", 4440, "Skolevej", 55, 10993431, "LotteC@hotmail.com");

            customerList.Add(customer1);
            customerList.Add(customer2);
            customerList.Add(customer3);
            customerList.Add(customer4);
        }
        #endregion

        #region Create Customer
        public void CreateCustomer()
        {
            int numberOfCustomer;
            string nameOfCustomer;
            string customerCity;
            int customerPostalCode;
            string customerStreetName;
            int customerHouseNumber;
            int phoneNumberOfCustomer;
            string emailOfCustomer;

            try
            {
                Console.WriteLine($"CREATE CUSTOMER");
                Console.WriteLine($"____________");
                Console.WriteLine($"Enter Name Of Customer:");
                nameOfCustomer = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine($"Enter City & Postal Code:");
                customerCity = Console.ReadLine();
                customerPostalCode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine($"Enter Street Name & House Number:");
                customerStreetName = Console.ReadLine();
                customerHouseNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine($"Enter Phonenumber:");
                phoneNumberOfCustomer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine($"Enter E-Mail:");
                emailOfCustomer = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine($"You Have Now Created A Customer! The Customer Has Been Assigned Number {customerList.Count + 1}");
                numberOfCustomer = customerList.Count + 1;
                Customer customer = new Customer(numberOfCustomer, nameOfCustomer, customerCity, customerPostalCode, customerStreetName, customerHouseNumber, phoneNumberOfCustomer, emailOfCustomer);
                customerList.Add(customer);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Use Only Numbers! Press Enter To Start Over");
                Console.ReadKey();
                Console.Clear();
                CreateCustomer();
            }

        }
        #endregion

        #region All Customers
        public void AllCustomers()
        {
            Console.WriteLine("Customer Catalog");
            Console.WriteLine("~~~~");

            foreach (Customer customer in customerList)
            {
                Console.WriteLine("______________________________________________________________________");
                Console.WriteLine($"Customer No.{customer.NumberOfCustomer} - Name: {customer.NameOfCustomer} - Phone Number: {customer.PhoneNumberOfCustomer} - Address: {customer.CustomerStreetName} {customer.CustomerHouseNumber}, {customer.CustomerCity} {customer.CustomerPostalCode}");
            }
        }
        #endregion

        #region Search For Customer
        public void SearchForCustomer(string search)
        {
            var matchingCustomers = customerList.Where(customer => customer.NameOfCustomer.Contains(search)).ToList();
            foreach (Customer customer in matchingCustomers)
            {
                Console.WriteLine($"Customer No.{customer.NumberOfCustomer} - Name: {customer.NameOfCustomer} - Phone Number: {customer.PhoneNumberOfCustomer} - Address: {customer.CustomerStreetName} {customer.CustomerHouseNumber}, {customer.CustomerCity} {customer.CustomerPostalCode}");
            }

            Console.WriteLine($"No Result - Please Try Again!");
            Console.ReadKey();
            Console.Clear();
            MenuCatalog menuCatalog = new MenuCatalog();
            menuCatalog.UserMenu();

        }
        #endregion

        #region Update Customer
        public void UpdateCustomer(int numberOfCustomer)
        {
            var customer = customerList.FirstOrDefault(customer => customer.NumberOfCustomer == numberOfCustomer);
            try
            {
                if (customer == null)
                {
                    Console.WriteLine($"Customer Not Found");
                }
                else
                {
                    Console.WriteLine($"You Have Chosen Customer No.{customer.NumberOfCustomer}");
                    Console.WriteLine();
                    Console.WriteLine("Enter New Full Name:");
                    customer.NameOfCustomer = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter Phone Number:");
                    customer.PhoneNumberOfCustomer = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"Enter Street Name And House Number:");
                    customer.CustomerStreetName = Console.ReadLine();
                    customer.CustomerHouseNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"Enter City And Postal Code:");
                    customer.CustomerCity = Console.ReadLine();
                    customer.CustomerPostalCode = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Succes! Your Customer Has Been Updated!");
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Use Only Numbers When Setting A Price! Press Enter To Start Over");
                Console.ReadKey();
                Console.Clear();
                UpdateCustomer(numberOfCustomer);
            }

        }
        #endregion

        #region Remove Customer
        public void RemoveCustomer(int numberOfCustomer)
        {
            try
            {
                customerList.RemoveAt(numberOfCustomer - 1);
                Console.WriteLine($"Customer No.{numberOfCustomer} Has Been Removed From The Customer Catalog");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Use Only Numbers When Choosing A Customer To Remove! Press Enter To Start Over");
                Console.ReadKey();
                Console.Clear();
                RemoveCustomer(numberOfCustomer);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine($"No Result - Please Try Again!");
                Console.ReadKey();
                Console.Clear();
                MenuCatalog menuCatalog = new MenuCatalog();
                menuCatalog.UserMenu();
            }
            #endregion
        }
    }
    }


    
    

    