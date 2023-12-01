using System;
using Microsoft.EntityFrameworkCore;

namespace Laundromat
{
    internal class Program
    {

        // Asnyc method will allow the data to work in the background while you focus on the main code.... 

        public static async Task SeedTheDataBase()
        {

            // Created Equipment set values for the Database

            //Store 1 Equipment

            Equipment Equipment1 = new Equipment
            {
                EquipmentType = "Washing Machine",
                SerialNumber = "EA7589",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment2 = new Equipment
            {
                EquipmentType = "Washing Machine",
                SerialNumber = "EA8954",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment3 = new Equipment
            {
                EquipmentType = "Washing Machine",
                SerialNumber = "EA9975",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment4 = new Equipment
            {
                EquipmentType = "Washing Machine",
                SerialNumber = "EA8875",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment5 = new Equipment
            {
                EquipmentType = "Dryer Machine",
                SerialNumber = "ES0874",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment6 = new Equipment
            {
                EquipmentType = "Dryer Machine",
                SerialNumber = "ES5543",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment7 = new Equipment
            {
                EquipmentType = "Dryer Machine",
                SerialNumber = "ES1985",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment8 = new Equipment
            {
                EquipmentType = "Dryer Machine",
                SerialNumber = "ES8649",
                CustomerPrice = 1.50M,

            };


            //Store 2 Equipment

            Equipment Equipment9 = new Equipment
            {
                EquipmentType = "Washing Machine",
                SerialNumber = "EA9876",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment10 = new Equipment
            {
                EquipmentType = "Washing Machine",
                SerialNumber = "EA3864",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment11 = new Equipment
            {
                EquipmentType = "Washing Machine",
                SerialNumber = "EA3896",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment12 = new Equipment
            {
                EquipmentType = "Washing Machine",
                SerialNumber = "EA8865",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment13 = new Equipment
            {
                EquipmentType = "Dryer Machine",
                SerialNumber = "ES2298",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment14 = new Equipment
            {
                EquipmentType = "Dryer Machine",
                SerialNumber = "ES8456",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment15 = new Equipment
            {
                EquipmentType = "Dryer Machine",
                SerialNumber = "ES3348",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment16 = new Equipment
            {
                EquipmentType = "Dryer Machine",
                SerialNumber = "ES4573",
                CustomerPrice = 1.50M,

            };


            //Store 3 Equipment

            Equipment Equipment17 = new Equipment
            {
                EquipmentType = "Washing Machine",
                SerialNumber = "EA3578",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment18 = new Equipment
            {
                EquipmentType = "Washing Machine",
                SerialNumber = "EA9872",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment19 = new Equipment
            {
                EquipmentType = "Washing Machine",
                SerialNumber = "EA2343",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment20 = new Equipment
            {
                EquipmentType = "Washing Machine",
                SerialNumber = "EA1134",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment21 = new Equipment
            {
                EquipmentType = "Dryer Machine",
                SerialNumber = "ES5673",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment22 = new Equipment
            {
                EquipmentType = "Dryer Machine",
                SerialNumber = "ES2343",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment23 = new Equipment
            {
                EquipmentType = "Dryer Machine",
                SerialNumber = "ES6543",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment24 = new Equipment
            {
                EquipmentType = "Dryer Machine",
                SerialNumber = "ES3566",
                CustomerPrice = 1.50M,

            };


            //Store 4 Equipment

            Equipment Equipment25 = new Equipment
            {
                EquipmentType = "Washing Machine",
                SerialNumber = "EA1987",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment26 = new Equipment
            {
                EquipmentType = "Washing Machine",
                SerialNumber = "EA8713",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment27 = new Equipment
            {
                EquipmentType = "Washing Machine",
                SerialNumber = "EA1999",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment28 = new Equipment
            {
                EquipmentType = "Washing Machine",
                SerialNumber = "EA1990",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment29 = new Equipment
            {
                EquipmentType = "Dryer Machine",
                SerialNumber = "ES1960",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment30 = new Equipment
            {
                EquipmentType = "Dryer Machine",
                SerialNumber = "ES1890",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment31 = new Equipment
            {
                EquipmentType = "Dryer Machine",
                SerialNumber = "ES7890",
                CustomerPrice = 1.50M,

            };


            Equipment Equipment32 = new Equipment
            {
                EquipmentType = "Dryer Machine",
                SerialNumber = "ES9876",
                CustomerPrice = 1.50M,

            };


            // Created Customer set values for the Database

            Customer Customer1 = new Customer
            {
                CustomerFirstName = "Neil",
                CustomerLastName = "Wehneman",
                CustomerSex = "Male",
                CustomerAge = 42,
                CustomerId = 11003,

            };

            Customer Customer2 = new Customer
            {
                CustomerFirstName = "Asher",
                CustomerLastName = "Finkle",
                CustomerSex = "Male",
                CustomerAge = 39,
                CustomerId = 11008,

            };

            Customer Customer3 = new Customer
            {
                CustomerFirstName = "Arshia",
                CustomerLastName = "Shabbir",
                CustomerSex = "Female",
                CustomerAge = 29,
                CustomerId = 11010,

            };

            Customer Customer4 = new Customer
            {
                CustomerFirstName = "Mansur",
                CustomerLastName = "Tapia",
                CustomerSex = "Male",
                CustomerAge = 26,
                CustomerId = 11011,

            };

            Customer Customer5 = new Customer
            {
                CustomerFirstName = "Bernard",
                CustomerLastName = "Estephan",
                CustomerSex = "Male",
                CustomerAge = 27,
                CustomerId = 11016,

            };

            Customer Customer6 = new Customer
            {
                CustomerFirstName = "Faira",
                CustomerLastName = "Hussain",
                CustomerSex = "Female",
                CustomerAge = 21,
                CustomerId = 11019,

            };

            Customer Customer7 = new Customer
            {
                CustomerFirstName = "Kevin",
                CustomerLastName = "Lee",
                CustomerSex = "Male",
                CustomerAge = 45,
                CustomerId = 11022,

            };

            Customer Customer8 = new Customer
            {
                CustomerFirstName = "Nancy",
                CustomerLastName = "Doe",
                CustomerSex = "Female",
                CustomerAge = 60,
                CustomerId = 11032,

            };

            Customer Customer9 = new Customer
            {
                CustomerFirstName = "Drew",
                CustomerLastName = "Dooley",
                CustomerSex = "Female",
                CustomerAge = 18,
                CustomerId = 11033,

            };

            Customer Customer10 = new Customer
            {
                CustomerFirstName = "Bailey",
                CustomerLastName = "Leo",
                CustomerSex = "Female",
                CustomerAge = 55,
                CustomerId = 11045,

            };


            // Created Store class set values for the Database


            Store store1 = new Store
            {
                StoreName = "Aqua Magic Laundry",
                StoreAddress = "1231 Gold Ave",
                StoreId = 7820001,
                CostToRun = 5400M,
                BusinessRevenue = 30900M,
                EquipmentInStore = new List<Equipment> { Equipment1, Equipment2, Equipment3, Equipment4, Equipment5, Equipment6, Equipment7, Equipment8 },
                CustomersinStore = new List<Customer> { Customer1, Customer6 },
                //EquipmentInUuseInStore = new List<EquipmentUsage> { Equipment1, Equipment1, Equipment2, Equipment2, Equipment6, Equipment8 }
            };

            Store store2 = new Store
            {
                StoreName = "Bright Fresh Laundry",
                StoreAddress = "4042 Yellow View",
                StoreId = 7820002,
                CostToRun = 8890M,
                BusinessRevenue = 112600M,
                EquipmentInStore = new List<Equipment> { Equipment9, Equipment10, Equipment11, Equipment12, Equipment12, Equipment14, Equipment15, Equipment16 },
                CustomersinStore = new List<Customer> { Customer2, Customer3 },
                //EquipmentInUuseInStore = new List<EquipmentUsage> { Equipment10, Equipment12, Equipment13, Equipment14, Equipment16 }
            };

            Store store3 = new Store
            {
                StoreName = "A+ Cleaners",
                StoreAddress = "7822 William St.",
                StoreId = 7820003,
                CostToRun = 7400M,
                BusinessRevenue = 102900M,
                EquipmentInStore = new List<Equipment> { Equipment17, Equipment18, Equipment19, Equipment20, Equipment21, Equipment22, Equipment23, Equipment24 },
                CustomersinStore = new List<Customer> { Customer4, Customer5, Customer7, Customer8 },
                //EquipmentInUuseInStore = new List<EquipmentUsage> { Equipment17, Equipment17, Equipment20, Equipment20, Equipment21, Equipment24 }
            };

            Store store4 = new Store
            {
                StoreName = "American Cleaners",
                StoreAddress = "2364 Turn Now Way",
                StoreId = 7820004,
                CostToRun = 8000M,
                BusinessRevenue = 109200M,
                EquipmentInStore = new List<Equipment> { Equipment25, Equipment26, Equipment27, Equipment28, Equipment29, Equipment30, Equipment31, Equipment32 },
                CustomersinStore = new List<Customer> { Customer9, Customer10 },
                //EquipmentInUuseInStore = new List<EquipmentUsage> { Equipment27, Equipment27, Equipment28 }

            };

            // Created EquipmentUsage set values for the database

            EquipmentUsage EquipmentUsage1 = new EquipmentUsage
            {
                EquipmentUsageId = 7589,
                Equipment = Equipment1, // Washer located in store1 
                TimeWashCycle = new TimeSpan(1, 60, 0), //1 hour and 45 minutes

                Customer = Customer1, // Neil
                CustomerId = 11003,
                TypeofEquipmentinUse = "Washing Machine"

            };

            EquipmentUsage EquipmentUsage2 = new EquipmentUsage
            {
                EquipmentUsageId = 5919,
                Equipment = Equipment2, // Washer located in store1 
                TimeWashCycle = new TimeSpan(0, 45, 0), //45 minutes
                Customer = Customer1, // Neil
                CustomerId = 11003,
                TypeofEquipmentinUse = "Washing Machine"
            };

            EquipmentUsage EquipmentUsage3 = new EquipmentUsage
            {
                EquipmentUsageId = 4729,
                Equipment = Equipment6, // Dryer located in store1
                TimeWashCycle = new TimeSpan(0, 45, 0), //45 minutes
                Customer = Customer1, // Neil
                CustomerId = 11003,
                TypeofEquipmentinUse = "Dryer Machine"
            };

            EquipmentUsage EquipmentUsage4 = new EquipmentUsage
            {
                EquipmentUsageId = 2018,
                Equipment = Equipment8, // Dryer located in store1
                TimeWashCycle = new TimeSpan(1, 45, 0), //1 hour and 45 minutes
                Customer = Customer1, // Neil
                CustomerId = 11003,
                TypeofEquipmentinUse = "Dryer Machine"
            };

            EquipmentUsage EquipmentUsage5 = new EquipmentUsage
            {
                EquipmentUsageId = 3792,
                Equipment = Equipment13, // Washer located in store2
                TimeWashCycle = new TimeSpan(0, 45, 0), //45 minutes
                Customer = Customer2, // Asher
                CustomerId = 11008,
                TypeofEquipmentinUse = "Washing Machine"
            };

            EquipmentUsage EquipmentUsage6 = new EquipmentUsage
            {
                EquipmentUsageId = 9299,
                Equipment = Equipment14, // Dryer located in store2
                TimeWashCycle = new TimeSpan(0, 45, 0), //45 minutes
                Customer = Customer2, // Asher
                CustomerId = 11008,
                TypeofEquipmentinUse = "Dryer Machine"
            };

            EquipmentUsage EquipmentUsage7 = new EquipmentUsage
            {
                EquipmentUsageId = 2882,
                Equipment = Equipment10, // Washer located in store2
                TimeWashCycle = new TimeSpan(1, 45, 0), //1 hour and 45 minutes
                Customer = Customer3, // Arshia
                CustomerId = 11010,
                TypeofEquipmentinUse = "Washing Machine"
            };

            EquipmentUsage EquipmentUsage8 = new EquipmentUsage
            {
                EquipmentUsageId = 3980,
                Equipment = Equipment12, // Washer located in store2
                TimeWashCycle = new TimeSpan(0, 60, 0), //60 minutes (Air drying)
                Customer = Customer3, // Arshia
                CustomerId = 11010,
                TypeofEquipmentinUse = "Washing Machine"
            };

            EquipmentUsage EquipmentUsage9 = new EquipmentUsage
            {
                EquipmentUsageId = 6702,
                Equipment = Equipment16, // Dryer located in store2
                TimeWashCycle = new TimeSpan(1, 60, 0), //1 hour and 60 minutes
                Customer = Customer3, // Arshia
                CustomerId = 11010,
                TypeofEquipmentinUse = "Dryer Machine"
            };

            EquipmentUsage EquipmentUsage10 = new EquipmentUsage
            {
                EquipmentUsageId = 4569,
                Equipment = Equipment20, // Washer located in store3
                TimeWashCycle = new TimeSpan(1, 60, 0), //1 hours and 60 minutes
                Customer = Customer4, // Mansur
                CustomerId = 11011,
                TypeofEquipmentinUse = "Washing Machine"
            };

            EquipmentUsage EquipmentUsage11 = new EquipmentUsage
            {
                EquipmentUsageId = 4567,
                Equipment = Equipment24, // Dryer located in store3
                TimeWashCycle = new TimeSpan(2, 10, 0), //2 hours and 10 minutes
                Customer = Customer4, // Mansur
                CustomerId = 11011,
                TypeofEquipmentinUse = "Dryer Machine"
            };

            EquipmentUsage EquipmentUsage12 = new EquipmentUsage
            {
                EquipmentUsageId = 9837,
                Equipment = Equipment20, // 20 Washer located in store3 he goes after Mansur
                TimeWashCycle = new TimeSpan(1, 45, 0), //1 hour and 45 minutes (Air drying)
                Customer = Customer5, // Bernard
                CustomerId = 11016,
                TypeofEquipmentinUse = "Washing Machine"
            };

            EquipmentUsage EquipmentUsage13 = new EquipmentUsage
            {
                EquipmentUsageId = 1878,
                Equipment = Equipment2, // Located in store1
                TimeWashCycle = new TimeSpan(0, 60, 0), //60 minutes
                Customer = Customer6, // Faira
                CustomerId = 11019,
                TypeofEquipmentinUse = "Washing Machine"
            };

            EquipmentUsage EquipmentUsage14 = new EquipmentUsage
            {
                EquipmentUsageId = 9876,
                Equipment = Equipment1, //Washing machine located in store1
                TimeWashCycle = new TimeSpan(0, 60, 0), //60 minutes
                Customer = Customer6, // Faira
                CustomerId = 11003,
                TypeofEquipmentinUse = "Washing Machine"
            };

            EquipmentUsage EquipmentUsage15 = new EquipmentUsage
            {
                EquipmentUsageId = 1341,
                Equipment = Equipment17,// Washer located in store3
                                        // is in use first and Nacy is waiting to use second
                TimeWashCycle = new TimeSpan(1, 30, 0), //1 hour and 30 minutes
                Customer = Customer7, // Kevin
                CustomerId = 11022,
                TypeofEquipmentinUse = "Washing Machine"
            };

            EquipmentUsage EquipmentUsage16 = new EquipmentUsage
            {
                EquipmentUsageId = 2385,
                Equipment = Equipment21,// Dryer located in store3
                TimeWashCycle = new TimeSpan(1, 30, 0), //1 hour and 30 minutes
                Customer = Customer7, // Kevin
                CustomerId = 11022,
                TypeofEquipmentinUse = "Dryer Machine"
            };

            EquipmentUsage EquipmentUsage17 = new EquipmentUsage
            {
                EquipmentUsageId = 1234,
                Equipment = Equipment17,// Washer located in store3
                TimeWashCycle = new TimeSpan(0, 60, 0), //60 minutes (Air drying)
                Customer = Customer8, // Nancy
                CustomerId = 11032,
                TypeofEquipmentinUse = "Washing Machine"
            };

            EquipmentUsage EquipmentUsage18 = new EquipmentUsage
            {
                EquipmentUsageId = 2342,
                Equipment = Equipment27,// Washer located in store4
                                        // (She is supposed to come in after Bailey to use the machine)
                TimeWashCycle = new TimeSpan(1, 30, 0), //1 hour and 30 minutes (Air drying)
                Customer = Customer9, // Drew
                CustomerId = 11032,
                TypeofEquipmentinUse = "Washing Machine"
            };

            EquipmentUsage EquipmentUsage19 = new EquipmentUsage
            {
                EquipmentUsageId = 2345,
                Equipment = Equipment27, // Washer located in store4
                TimeWashCycle = new TimeSpan(1, 60, 0), //1 hour and 60 minutes
                Customer = Customer10, // Bailey
                CustomerId = 11033,
                TypeofEquipmentinUse = "Washing Machine"
            };

            EquipmentUsage EquipmentUsage20 = new EquipmentUsage
            {
                EquipmentUsageId = 2334,
                Equipment = Equipment28, // Washer located in store4
                TimeWashCycle = new TimeSpan(1, 60, 0), //1 hour and 60 minutes
                Customer = Customer10, // Bailey
                CustomerId = 11033,
                TypeofEquipmentinUse = "Washing Machine"
            };


            // Add Store set values to the database
            List<Store> ListofStores = new List<Store>
            {
             store1,store2,store3,store4
            };


            // Add Equipment set values to the database
            List<Equipment> EquipmentList = new List<Equipment>
            {
                Equipment1, Equipment2, Equipment3, Equipment4, Equipment5,
                Equipment6, Equipment7, Equipment8, Equipment9, Equipment10,
                Equipment11, Equipment12, Equipment13, Equipment14, Equipment15,
                Equipment16, Equipment17, Equipment18, Equipment19, Equipment20,
                Equipment21, Equipment22, Equipment23, Equipment24, Equipment25,
                Equipment26, Equipment27, Equipment28, Equipment29, Equipment30,
                Equipment31,Equipment32
            };

            // Add Customer set values to the database
            List<Customer> CustomersList = new List<Customer>
            {
                Customer1, Customer2, Customer3, Customer4, Customer5,
                Customer6, Customer7, Customer8, Customer9, Customer10,
            };

            // Add EquipmentUsage set values to the database
            List<EquipmentUsage> EquipmentUsagesList = new List<EquipmentUsage>
            {
                EquipmentUsage1, EquipmentUsage2, EquipmentUsage3, EquipmentUsage4, EquipmentUsage5,
                EquipmentUsage6, EquipmentUsage7, EquipmentUsage8, EquipmentUsage9, EquipmentUsage10,
                EquipmentUsage11, EquipmentUsage12, EquipmentUsage13, EquipmentUsage14, EquipmentUsage15,
                EquipmentUsage16, EquipmentUsage17, EquipmentUsage18, EquipmentUsage19, EquipmentUsage20,

            };

            using LaundromatContext context = new LaundromatContext();
            

            context.AddRange(ListofStores);
            context.AddRange(EquipmentList);
            context.AddRange(CustomersList);
            context.AddRange(EquipmentUsagesList);
            await context.SaveChangesAsync();

        }

        public static async Task Main()

        {

            //SeedTheDataBase();

            // MAKE SURE TO: uncomment out seedthedatabase before you store it onto your machine


            // STEPS TO FOLLOW:
            // Using DATA from the database for user to select options from
            // User Press ENTER on KeyBoard to Start
            // User gets the message "Welcome to our Megaplex Laundromat stores.." within a border
            // Press 1 to select service (enters the the while loop or type "exit" to quit
            //....
            //....
            //....
            //....
            // User gets the message... "Press 1 to select a Last name from the options below"
            // User is given options of customers Last Name from the Database 
            // User enter the Last Name of their choosing and press enter
            // The Terminal will then provide with information from the database such as:
            // the customer First and Last name, store Location, number of equipment in usage and
            // the type of equipment in usage and this is based on what is being requested in code


            Console.WriteLine("Press Enter to START");

            string userInput = Console.ReadLine();

            using LaundromatContext context = new LaundromatContext();
            context.Database.ExecuteSql($"UPDATE Customers SET CustomerFirstName='James' WHERE CustomerFirstName='Neil'");
            //context.Database.ExecuteSql($"UPDATE EquipmentUsages SET EquipmentUsageId='2111' WHERE EquipmentUsageId='2345'");

            List<Store> stores = await context.Stores.ToListAsync();

            List<Customer> customers = await context.Customers.ToListAsync();

            List<Equipment> equipment = await context.Equipment.ToListAsync();

            List<EquipmentUsage> equipmentUsages = await context.EquipmentUsages.ToListAsync();


            Console.WriteLine("+-----------------------+");
            Console.WriteLine("|                       |");
            Console.WriteLine("|  Megaplex Laundromat  |");
            Console.WriteLine("|        Stores         |");
            Console.WriteLine("|                       |");
            Console.WriteLine("+-----------------------+");

            Console.WriteLine("Press 1 to select a service");
            Console.WriteLine("Type ‘exit’ to quit");
            userInput = Console.ReadLine() ?? "Default";

            // Here using the While Loop since the variable (UserInput) will be less than 5:
            //to provide the user with multiple options from database to select to from:

            while (userInput.ToLower() != "exit")
            {
                if (userInput == "1")
                {
                    Console.WriteLine("Press 1 and select a Last name from the options below");
                    userInput = Console.ReadLine();

                    if (userInput == "1")
                    {
                        ExecuteServiceSelection1(customers);
                    }
                }

                else if (userInput == "2")
                {
                    Console.WriteLine("You have chosse invalid option. Press 1 to start again or type Exit to quit");
                    string? y = Console.ReadLine();
                }


                static async void ExecuteServiceSelection1(List<Customer> customers)
                {

                    foreach (Customer individualcustomer in customers)
                    {
                        Console.WriteLine(individualcustomer.CustomerLastName);
                    }

                    string instructionoptions = Console.ReadLine();

                    using LaundromatContext context = new LaundromatContext();



                    Customer customerX = context.Customers
                        .Where(customerx =>
                            customerx.CustomerLastName.ToLower() == instructionoptions.ToLower())
                        .Single();


                    List<EquipmentUsage> ListofEquipmentUsage = await context.EquipmentUsages
                        .Where(equipmentUsagesparamater => equipmentUsagesparamater.Customer == customerX)
                        .ToListAsync();

                    //List<Store> ListofStoreNameType = context.Stores
                    //       .Where(storesparameter => storesparameter.CustomersinStore == customerX)
                    //       .ToList();

                    //List<Store> StoreX = new List<Store>();

                    //List<string> ListofStoreName = context.Stores
                    //        .Select(stores => stores.StoreName)
                    //        .ToList();

                    //List<string> ListofStoreName = context.Stores
                    //     .Select(stores => stores.StoreName.CompareTo(customerX).ToString().ToList(),
                    ////.ToList();


                    List<string> ListofEquipmentUsagesType = ListofEquipmentUsage
                       .Select(equipmentUsage => equipmentUsage.TypeofEquipmentinUse)
                       .ToList();



                    Console.WriteLine($" {customerX.CustomerFirstName} {customerX.CustomerLastName} " +
                                       $" has " + ListofEquipmentUsage.Count + " equipments in use, " +
                                       //$" at the {StoreX.StoreName} store" +
                                       //$" at the {string.Join(',', ListofStoreName)} store " +
                                       $" {string.Join(',', ListofEquipmentUsagesType)} ");


                    Console.WriteLine("Press 1 to START");
                    Console.WriteLine("Type ‘exit’ to quit");
                    string? a = Console.ReadLine();


                }
            }
        }       
    }
}