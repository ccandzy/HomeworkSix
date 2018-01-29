using HomeworkSix.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSix.Services
{
    public class MenuService : IMenuService
    {
        public void Add()
        {
            Console.WriteLine("Add Successful");
        }

        public void Delete()
        {
            Console.WriteLine("Delete Successful");
        }

        public void Select()
        {
            Console.WriteLine("Select Successful");
        }

        public void Update()
        {
            Console.WriteLine("Update Successful");
        }
    }
}
