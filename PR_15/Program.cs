using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_15
{
    class Program
    {
        struct Payment
        {
            public char[] payeraccount;
            public char[] recipienttaccount;
            public uint amount;

            public Payment(uint amount)
            {
                this.payeraccount = new char[20];
                this.recipienttaccount = new char[20];
                this.amount = 0;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Практическая работа №15. \nЗдравствуйте!");
            Console.Write("укажите количество плательщиков");
            uint countPayment = UInt32.Parse(Console.ReadLine());

            Payment[] payments = new Payment[countPayment];
            int i;
            for(i=0;i<countPayment;i++)
            {
                payments[i] = new Payment(0);
                Console.Write("\nРасчетный счет плательщика: ");
                payments[i].payeraccount = Console.ReadLine().ToCharArray();
                Console.Write("Расчетный счет получателя:");
                payments[i].recipienttaccount = Console.ReadLine().ToCharArray();
                Console.Write("Перечисляемая сумма в рублях:");
                payments[i].amount = UInt32.Parse(Console.ReadLine());
            }

            char[] new_amount = new char[20];
            Console.Write("\n ")
        }
    }
}
