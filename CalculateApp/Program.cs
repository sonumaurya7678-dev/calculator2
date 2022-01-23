using System;

namespace CalculateApp
{
    class Program
    {
        public int a {get;set;}
        public int b {get;set;}
        static void Main(string[] args)
        {

            Program p = new Program();
            p.option();
        }
        public void option()
        {
            Console.Clear();
            Console.WriteLine("~ ~ WELCOME TO MY APP ~ ~");
            Console.WriteLine("");
            Console.WriteLine("Press 1 : Addition");
            Console.WriteLine("Press 2 : Subtraction");
            Console.WriteLine("Press 3 : Multiplication");
            Console.WriteLine("Press 4 : Division");
            string anil;
            anil = Console.ReadLine();
            Console.WriteLine("");
            switch (anil)
            {
                case "1":
                    sum();
                    break;
                case "2":
                    sub();
                    break;
                case "3":
                    mul();
                    break;
                case "4":
                    div();
                    break;
            }
            CalAgain();
        }
        public void sum()
        {
            Console.WriteLine("Enter First Number : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a+b} ");
        }
        public void sub()
        {
            Console.WriteLine("Enter First Number : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} - {b} = {a - b} ");
        }
        public void mul()
        {
            Console.WriteLine("Enter First Number : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} * {b} = {a * b} ");
        }
        public void div()
        {
            Console.WriteLine("Enter First Number : ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} / {b} = {a / b} ");
        }
        public void CalAgain()
        {
            Console.WriteLine("");
            Console.WriteLine("Calculate Again.......Press 1");
            Console.WriteLine("Exit..................Press 2");
            string sonu;
            sonu = Console.ReadLine();
            switch (sonu)
            {
                case "1":
                    option();
                    break;
                case "2":
                    Exit();
                    break;
            }
        }
    public void Exit()
        {
            Console.WriteLine("");
            Console.WriteLine("Thank you so much for visit my App..");
        }
    }
}
