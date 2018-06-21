using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    abstract class Client
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Value { get; set; }

        public abstract void PrintInformation();

        public bool SearchClient(DateTime date)
        {
            return date == StartDate ? true : false;
        }
    }
}
