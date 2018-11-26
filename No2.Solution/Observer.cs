using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public abstract class Observer
    {
        private Stock stock;

        public string Name { get; set; }

        protected Observer(string name, Stock stock)
        {
            this.Name = name;
            this.stock = stock;
        }

        public void Subscribe(Stock stock)
        {
            stock.Notification += Update;
        }

        public void Unsubscribe(Stock stock)
        {
            stock.Notification -= Update;
        }

        public abstract void Update(object sender, StockInfoEventArgs eventArgs);

    }
}
