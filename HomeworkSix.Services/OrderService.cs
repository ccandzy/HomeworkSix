using HomeworkSix.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkSix.Model;

namespace HomeworkSix.Services
{
    public class OrderService : IOrderService
    {
        public void Cancel(Order order)
        {
            Console.WriteLine($"{order.OrderNo} Cancel Successful");
        }

        public void Create(Order order)
        {
            Console.WriteLine($"{order.OrderNo} Create Successful");
        }

        public void Pay(Order order)
        {
            Console.WriteLine($"{order.OrderNo} Pay Successful");
        }
    }
}
