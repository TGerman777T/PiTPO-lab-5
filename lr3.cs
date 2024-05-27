using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ManagerJr : Manager
{
    public override int GetPrice()
    {
        DateTime now = DateTime.Now;
        int years = date.Subtract(now).Days / 365;
        if (now.Month == 6 || now.Month == 12)
        {
            int zp = st + add1 * years;
            return zp;
        }
        else
        {
            int zp = st;
            return zp;
        }
    }
    public override void GetInfo() => base.GetInfo();
    public ManagerJr() { }
    public ManagerJr(string Name, DateTime Date, int St, int Bonus) : base(Name, Date, St, Bonus) { }
}
public class Manager : Employee
{
    public override int GetPrice()
    {
        DateTime now = DateTime.Now;
        int years = now.Subtract(date).Days / 365;
        int zp = st + add1 * years;
        return zp;
    }
    public override void GetInfo()
    {
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Дата трудоустройства: {date}");
        Console.WriteLine($"Ставка: {st}");
        Console.WriteLine($"Сумма премии: {add1}");
        Console.WriteLine($"Заработная плата: {GetPrice()}");
    }
    public Manager() { }
    public Manager(string Name, DateTime Date, int St, int Bonus)
    {
        name = Name;
        date = Date;
        st = St;
        add1 = Bonus;
    }
}
public class Waiter : Employee
{
    public override int GetPrice()
    {
        int zp = st * add1 + add2;
        return zp;
    }
    public override void GetInfo()
    {
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Дата трудоустройства: {date}");
        Console.WriteLine($"Ставка: {st}");
        Console.WriteLine($"Количество отработанных часов: {add1}");
        Console.WriteLine($"Количество чаевых: {add2}");
        Console.WriteLine($"Заработная плата: {GetPrice()}");
    }
    public Waiter() { }
    public Waiter(string Name, DateTime Date, int St, int Hours, int Tips)
    {
        name = Name;
        date = Date;
        st = St;
        add1 = Hours;
        add2 = Tips;
    }
}
public class Kitchen : Employee
{
    public override int GetPrice()
    {
        int zp = st * add1;
        return zp;
    }
    public override void GetInfo()
    {
        Console.WriteLine($"Имя: {name}");
        Console.WriteLine($"Дата трудоустройства: {date}");
        Console.WriteLine($"Ставка: {st}");
        Console.WriteLine($"Количество отработанных часов: {add1}");
        Console.WriteLine($"Заработная плата: {GetPrice()}");
    }
    public Kitchen() { }
    public Kitchen(string Name, DateTime Date, int St, int Hours)
    {
        name = Name;
        date = Date;
        st = St;
        add1 = Hours;
    }
}
public abstract class Employee
{
    [Key]
    public int Id { get; set; }
    public string name { get; set; }
    public DateTime date { get; set; }
    public int st { get; set; }
    public int add1 { get; set; }
    public int add2 { get; set; }

    public abstract void GetInfo();
    public abstract int GetPrice();
}