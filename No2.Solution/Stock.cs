using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No2.Solution
{
    public class Stock
    {
        public event EventHandler<StockInfoEventArgs> Notification = delegate { };

        public void OnNotification(int USD, int Euro)
        {
            Notification?.Invoke(this, new StockInfoEventArgs(USD, Euro));
        }

        public void Market()
        {
            Random rnd = new Random();
            int USD = rnd.Next(20, 40);
            int Euro = rnd.Next(30, 50);
            OnNotification(USD, Euro);
        }
    }
}
