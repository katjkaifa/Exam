using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Organisation : Client
    {
        public long AccountNo { get; set; }

        public override void PrintInformation()
        {
            Console.WriteLine($"Organisation name: {this.Name}; Start date account: {this.StartDate}; Account No: {this.AccountNo}; Account sum: {this.Value}");
        }
    }
}
