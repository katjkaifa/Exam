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
            Console.WriteLine("Creditor name: {0}; Start date credit: {1}; Credit value: {2}; Credit interest: {3}; Credit remainder: {4}", this.Name, this.StartDate, this.Value, this.CreditInterest, this.CreditRemainder);
        }
    }
}
