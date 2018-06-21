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
            Console.WriteLine("Depositor name: {0}; Start date deposit: {1}; Deposit value: {2}; Deposit interest: {3}", this.Name, this.StartDate, this.Value, this.DepositInterest);
        }
    }
}
