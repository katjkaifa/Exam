using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Client[] clients = new Client[]
            {
                new Depositor
                {
                    Name = "Depositor1",
                    StartDate = DateTime.Now,
                    Value = 10000m,
                    DepositInterest = 2.5
                },
                new Depositor
                {
                    Name = "Depositor2",
                    StartDate= new DateTime(2016, 6, 6),
                    Value = 20000m,
                    DepositInterest = 3
                },
                new Depositor
                {
                    Name = "Depositor3",
                    StartDate= new DateTime(2018, 2, 20),
                    Value = 30000m,
                    DepositInterest = 2.8
                },

                new Creditor
                {
                    Name = "Creditor1",
                    StartDate= new DateTime(2017, 5, 5),
                    Value = 25000m,
                    CreditInterest = 6,
                    CreditRemainder = 3000
                },
                new Creditor
                {
                    Name = "Creditor2",
                    StartDate = new DateTime(2018, 5, 5),
                    Value = 2000m,
                    CreditInterest = 6,
                    CreditRemainder = 1000
                },
                new Creditor
                {
                    Name = "Creditor3",
                    StartDate = new DateTime(2016, 6, 6),
                    Value = 5000m,
                    CreditInterest = 6,
                    CreditRemainder = 4000
                },

                new Organisation
                {
                    Name = "Organisation1",
                    StartDate = new DateTime(2015, 7,7),
                    AccountNo = 205945630258,
                    Value = 50000m
                },
                new Organisation
                {
                    Name = "Organisation2",
                    StartDate = new DateTime(2016, 6 ,6),
                    AccountNo = 147869204896,
                    Value = 30000m
                },
                new Organisation
                {
                    Name = "Organisation3",
                    StartDate = new DateTime(2017, 6 ,6),
                    AccountNo = 597526482789,
                    Value = 25000m
                },
            };

            clients.ToList().ForEach(c => c.PrintInformation());

            Console.ReadLine();
            Console.WriteLine("\nSearched Clients\n");

            Client[] searchedClients = clients.Where(c => c.SearchClient(new DateTime(2016, 6, 6))).ToArray();
            searchedClients.ToList().ForEach(c => c.PrintInformation());

            Console.ReadLine();
        }
    }
}
