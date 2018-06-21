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
            Console.WriteLine("Organisation name: {0}; Start date account: {1}; Account No: {2}; Account sum: {3}", this.Name, this.StartDate, this.AccountNo, this.Value);
        }
    }
}
