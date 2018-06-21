using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Depositor : Client
    {
        public double DepositInterest { get; set; }

        public override void PrintInformation()
        {
            Console.WriteLine($"Depositor name: {this.Name}; Start date deposit: {this.StartDate}; Deposit value: {this.Value}; Deposit interest: {this.DepositInterest}");
        }
    }
}
