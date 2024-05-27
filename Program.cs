using lab_5;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitchen Vladimir = new Kitchen("Vladimir", new DateTime(2015, 7, 20), 1000, 20);
            Kitchen Maxim = new Kitchen("Maxim", new DateTime(2010, 1, 2), 1500, 10);
            Waiter Alena = new Waiter("Alena", new DateTime(2023, 3, 15), 100, 20, 500);
            Waiter Boris = new Waiter("Boris", new DateTime(2020, 10, 22), 200, 10, 1000);
            Manager Zoya = new Manager("Zoya", new DateTime(2004, 1, 9), 1000, 10000);
            ManagerJr Kirill = new ManagerJr("Kirill", new DateTime(2013, 6, 19), 500, 500);

            DBProcesser.KitToBD(Vladimir);
            DBProcesser.KitToBD(Maxim);
            DBProcesser.WaiToBD(Alena);
            DBProcesser.WaiToBD(Boris);
            DBProcesser.ManToBD(Zoya);
            DBProcesser.MJrToBD(Kirill);

            DBProcesser.GetKitchen();
            DBProcesser.GetWaiter();
            DBProcesser.GetManager();
            DBProcesser.GetManagerJr();

            Console.Read();
        }
    }
}
