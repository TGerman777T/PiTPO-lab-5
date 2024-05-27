using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace lab_5
{
    internal static class DBProcesser
    {
        public static void KitToBD(Kitchen employee)
        {
            using (KitchenContext db = new KitchenContext())
            {
                db.Kitchens.Add(employee);
                db.SaveChanges();
                Console.WriteLine("Объект добавлен");
            }
        }
        public static void WaiToBD(Waiter employee)
        {
            using (WaiterContext db = new WaiterContext())
            {
                db.Waiters.Add(employee);
                db.SaveChanges();
                Console.WriteLine("Объект добавлен");
            }
        }
        public static void ManToBD(Manager employee)
        {
            using (ManagerContext db = new ManagerContext())
            {
                db.Managers.Add(employee);
                db.SaveChanges();
                Console.WriteLine("Объект добавлен");
            }
        }
        public static void MJrToBD(ManagerJr employee)
        {
            using (ManagerJrContext db = new ManagerJrContext())
            {
                db.ManagerJrs.Add(employee);
                db.SaveChanges();
                Console.WriteLine("Объект добавлен");
            }
        }
        public static void GetKitchen()
        {
            using (var context = new KitchenContext())
            {
                var employees = context.Kitchens.ToList();
                foreach (var employee in employees)
                {
                    employee.GetInfo();
                }
            }
        }
        public static void GetWaiter()
        {
            using (var context = new WaiterContext())
            {
                var employees = context.Waiters.ToList();
                foreach (var employee in employees)
                {
                    employee.GetInfo();
                }
            }
        }
        public static void GetManager()
        {
            using (var context = new ManagerContext())
            {
                var employees = context.Managers.ToList();
                foreach (var employee in employees)
                {
                    employee.GetInfo();
                }
            }
        }
        public static void GetManagerJr()
        {
            using (var context = new ManagerJrContext())
            {
                var employees = context.ManagerJrs.ToList();
                foreach (var employee in employees)
                {
                    employee.GetInfo();
                }
            }
        }
    }
}
