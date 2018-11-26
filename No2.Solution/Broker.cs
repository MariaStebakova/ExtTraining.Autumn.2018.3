using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Broker: Observer
    {
        public Broker(string name, Stock stock) : base(name, stock)
        {
        }

        public override void Update(object sender, StockInfoEventArgs eventArgs)
        {
            Console.WriteLine(
                eventArgs.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {eventArgs.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {eventArgs.USD}");
        }
    }
}
