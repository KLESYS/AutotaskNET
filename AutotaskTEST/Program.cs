using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using AutotaskNET;
using AutotaskNET.Entities;

namespace AutotaskTEST
{
    class Program
    {
        private const string @USERNAME = "";
        private const string @PASSWORD = "";

        static void Main(string[] args)
        {
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tVersion: {Assembly.GetExecutingAssembly().GetName().Version.ToString()}");
            Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tConnecting to AutoTask.");

            ATWSInterface atAPI = new ATWSInterface();

            try
            {
                atAPI.Connect(@USERNAME, @PASSWORD);

                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tConnected.");
                Console.WriteLine();

                ////UDF Information
                //Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Entity Information...");
                //List<FieldInformation> udfInformation = atAPI.GetUDFInfo(typeof(Account));
                //Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tEntities: {udfInformation.Count}");
                //foreach (FieldInformation udfInfo in udfInformation)
                //{
                //    Console.WriteLine($"\t\t - {udfInfo.Name} = Type: {udfInfo.Type}");
                //}
                //Console.WriteLine();

                ////Account
                //Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting All Accounts...");
                //List<Account> accounts = atAPI.Query(typeof(Account), new QueryFilter() {
                //    new ConditionGroup(ConditionGroupOperation.OR) {
                //        new Condition("id", ConditionOperation.Equals, 174),
                //        new Condition("id", ConditionOperation.Equals, 175)
                //    }
                //}).OfType<Account>().ToList();
                //Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tAll Accounts: {accounts.Count}");
                //Console.WriteLine();



                ////Account Locations
                //Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Account Locations...");
                //List<AccountLocation> account_locations = atAPI.Query(typeof(AccountLocation)).OfType<AccountLocation>().ToList();
                //Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tAccount Locations: {account_locations.Count}");
                //Console.WriteLine();



                ////Entity Information
                //Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Entity Information...");
                //List<EntityInformation> eInformation = atAPI.GetEntityInfo();
                //Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tEntities: {eInformation.Count}");
                //foreach (EntityInformation eInfo in eInformation)
                //{
                //    Console.WriteLine($"\t\t - {eInfo.name} = HasUDF: {eInfo.hasUserDefinedFields}, CanQuery: {eInfo.canQuery}, CanCreate: {eInfo.canCreate}, CanUpdate: {eInfo.canUpdate}, CanDelete: {eInfo.canDelete}");
                //}
                //Console.WriteLine();


                ////Account Types
                //Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Account Types...");
                //List<PicklistValue> account_types = atAPI.GetPicklistValues(typeof(Account), "AccountType");
                //Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tAccount Types: {account_types.Count}");
                //foreach (PicklistValue account_type in account_types)
                //{
                //    Console.WriteLine($"\t\t - {account_type.Label}");
                //}
                //Console.WriteLine();

                ////Customer Accounts
                //Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Customer Accounts...");
                //List<Account> customer_accounts = atAPI.Query(typeof(Account), new QueryFilter() {
                //    new Condition("AccountType", ConditionOperation.Equals, account_types.Find(type => type.Label == "Customer").Value)
                //}).OfType<Account>().ToList();
                //Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tCustomer Accounts: {customer_accounts.Count}");
                //foreach (Account acc in customer_accounts)
                //{
                //    Console.WriteLine($"\t\t - {acc.AccountName}");
                //    Console.WriteLine($"\t\t\t - {acc.AccountNumber}");
                //    Console.WriteLine($"\t\t\t - {acc.id}");

                //}
                //Console.WriteLine();
                //Console.WriteLine();


                ////Tickets Updated Today
                //Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Tickets Updated Today...");
                //List<Ticket> tickets_updated_today = atAPI.Query(typeof(Ticket), new QueryFilter {
                //    new Condition("LastActivityDate", ConditionOperation.GreaterThan, DateTime.Today)
                //}).OfType<Ticket>().ToList();
                //Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tTickets Updated Today: {tickets_updated_today.Count}");
                //Console.WriteLine();


                ////Contracts 
                //Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Contracts...");
                //List<Contract> contracts = atAPI.Query(typeof(Contract), new QueryFilter {
                //    new Condition("AccountID", ConditionOperation.Equals, "29685380")
                //}).OfType<Contract>().ToList();
                //Console.WriteLine($"{ DateTime.Now.ToLongTimeString()}\tContracts: {contracts.Count}");
                //foreach (Contract contract in contracts)
                //{
                //    //foreach (FieldInfo info in typeof(Contract).GetFields())
                //    //{
                //    //    Console.WriteLine($"\t\t - {info.Name}");
                //    //    Console.WriteLine($"\t\t\t - {info.GetValue(contract)}");
                //    //    Console.WriteLine();
                //    //}
                //    Console.WriteLine(contract.ContractName);
                //    Console.WriteLine(contract.id);
                //    Console.WriteLine(contract);
                    
                //    Console.WriteLine();
                //    Console.WriteLine();
                //    //Console.WriteLine($"\t\t - {contract.ContractName}");
                //    //Console.WriteLine($"\t\t - {contract.ContractCategory}");
                //    //Console.WriteLine($"\t\t - {contract.ContractType}");
                //}

                //Services
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Contract Services...");
                List<ContractService> contractservices = atAPI.Query(typeof(ContractService), new QueryFilter {
                    new Condition("ContractID", ConditionOperation.Equals, 29685337) }).OfType<ContractService>().ToList();
                Console.WriteLine($"{ DateTime.Now.ToLongTimeString()}\tContract Services: {contractservices.Count}");
                foreach (ContractService service in contractservices)
                {
                    Console.WriteLine(service.id);
                    Console.WriteLine(service.ContractID);
                    Console.WriteLine(service.ServiceID);
                    Console.WriteLine(service.InternalDescription);
                    Console.WriteLine();
                    Console.WriteLine();
                }

                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Services...");
                List<Service> services = atAPI.Query(typeof(Service)).OfType<Service>().ToList();
                Console.WriteLine($"{ DateTime.Now.ToLongTimeString()}\tServices: {services.Count}");
                foreach (Service service in services)
                {
                    Console.WriteLine(service.id);
                    Console.WriteLine(service.UnitCost);
                    Console.WriteLine(service.UnitPrice);
                    Console.WriteLine(service.Name);
                    Console.WriteLine();
                    Console.WriteLine();
                }

                //Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tGetting Services...");
                //List<ServiceBundle> servicebundle = atAPI.Query(typeof(ServiceBundle), new QueryFilter {
                //    new Condition("id", ConditionOperation.Equals, 34) }).OfType<ServiceBundle>().ToList();
                //Console.WriteLine($"{ DateTime.Now.ToLongTimeString()}\tServices: {servicebundle.Count}");
                //foreach (ServiceBundle service in servicebundle)
                //{
                //    Console.WriteLine(service.id);
                //    Console.WriteLine(service.UnitPrice);
                //    Console.WriteLine(service.InvoiceDescription);
                //    Console.WriteLine();
                //    Console.WriteLine();
                //}



                Console.WriteLine();


                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\tDone.");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}\t\tError: {e.Message}\r\n");
            }
            finally
            {
                Console.WriteLine("Press Enter");
                Console.ReadLine();
            }

        } //end Main

    } //end Program
}
