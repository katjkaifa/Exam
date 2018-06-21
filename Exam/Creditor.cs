using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Creditor : Client
    {
        public double CreditInterest { get; set; }
        public decimal CreditRemainder { get; set; }

        public override void PrintInformation()
        {
            Console.WriteLine($"Creditor name: {this.Name}; Start date credit: {this.StartDate}; Credit value: {this.Value}; Credit interest: {this.CreditInterest}; Credit remainder: {this.CreditRemainder}");
        }
    }
}
