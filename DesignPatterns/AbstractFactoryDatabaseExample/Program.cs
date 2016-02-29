using AbstractFactoryDatabaseExample.Entity_Framework;
using AbstractFactoryDatabaseExample.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDatabaseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            Console.WriteLine("Choose data source: 1 = SQL Server, 2 = Oracle");
            do
            {
                answer = Convert.ToInt16(Console.ReadLine().ToString());
            } while (answer < 1 && answer > 2);


            //Create factory
            Console.WriteLine("Creating the factories...");

            if (answer == 1)
            {
                SQLRepositoryFactory sqlFactory = new SQLRepositoryFactory();
                
                answer = 0;
                Console.WriteLine("Choose entity: 1 = Customer, 2 = Supplier");
                do
                {
                    answer = Convert.ToInt16(Console.ReadLine().ToString());
                } while (answer < 1 && answer > 2);

                if (answer == 1)
                {
                    Console.WriteLine("Creating Customer repository...");
                    var sqlCustomerRepo = sqlFactory.CreateCustomerRepository();
                    
                    Console.Write("Enter Id of Customer to search: ");
                    var id = Convert.ToInt32(Console.ReadLine().ToString());

                    var customer = sqlCustomerRepo.Find(id);

                    if (customer == null)
                        Console.WriteLine("Could not find Customer with Id of: {0} in SQL Server", id);
                    else
                        Console.WriteLine("Id: {0}, Name: {1}, Business Unit: {2}, Group: {3}", customer.Id, customer.Name, customer.BusinessUnit, customer.Group);
                }
                else if (answer == 2)
                {
                    Console.WriteLine("Creating Supplier repository...");
                    var sqlSupplierRepo = sqlFactory.CreateSupplierRepository();

                    Console.Write("Enter Id of Supplier to search: ");
                    var id = Convert.ToInt32(Console.ReadLine().ToString());

                    var supplier = sqlSupplierRepo.Find(id);

                    if (supplier == null)
                        Console.WriteLine("Could not find Supplier with Id of: {0} in SQL Server", id);
                    else
                        Console.WriteLine("Id: {0}, Name: {1}, Business Unit: {2}, Group: {3}", supplier.Id, supplier.Name, supplier.BusinessUnit, supplier.Group);
                }
            }

            else if (answer == 2)
            {
                OracleRepositoryFactory oracleFactory = new OracleRepositoryFactory();
            }

            Console.ReadKey();
        }
    }
}
