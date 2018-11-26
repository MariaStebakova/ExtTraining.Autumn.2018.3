using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Bank: Observer
    {
        public Bank(string name, Stock stock) : base(name, stock)
        {
        }

        public override void Update(object sender, StockInfoEventArgs eventArgs)
        {
            Console.WriteLine(
                eventArgs.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{eventArgs.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {eventArgs.Euro}");
        }
    }
}
