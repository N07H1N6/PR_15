using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_15
{
    class Program
    {
        static void InfoAboutObjStuct(uint countPayment, Payment[] payments)
        {
            int i;
            for (i = 0; i < countPayment; i++)
            {
                payments[i] = new Payment(0);
                Console.Write("\nРасчетный счет плательщика: ");
                payments[i].payeraccount = Console.ReadLine().ToCharArray();
                Console.Write("Расчетный счет получателя:");
                payments[i].recipienttaccount = Console.ReadLine().ToCharArray();
                Console.Write("Перечисляемая сумма в рублях:");
                payments[i].amount = UInt32.Parse(Console.ReadLine());

            }
        }
        public struct Payment
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
            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Практическая работа №15. \nЗдравствуйте!");
                Console.Write("\nУкажите количество плательщиков:");
                uint countPayment = UInt32.Parse(Console.ReadLine());
                Payment[] payments = new Payment[countPayment];
                if (payments.Length == 0) throw new ArgumentException("Платежный лист не может быть пустым");
                else
                {
                    InfoAboutObjStuct(countPayment, payments);
                    Payment firstPayment = ((Payment)payments[0]);
                    uint maxAmount = firstPayment.amount;
                    char[] maxAmountPayer = firstPayment.payeraccount;

                    // Находим плательщика с максимальной суммой платежей и записываем его счет
                    foreach (Payment p in payments)
                    {
                        if (p.amount > maxAmount)
                        {
                            maxAmount = p.amount;
                            maxAmountPayer = p.payeraccount;
                        }
                    }
                    Console.Write("\nПлательщик с максимальной суммой:", maxAmountPayer);
                    Console.WriteLine(maxAmountPayer);
                    uint total = 0;
                    // Суммируем все платежи
                    foreach (Payment p in payments)
                    {
                        total += p.amount;
                    }
                    Console.Write("\nсумма платежей:", String.Format("{0:f2}", total));
                    Console.WriteLine(String.Format("{0:f2}", total));

                }
                
            }
            catch(ArgumentException fe)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка:"+fe.Message);  
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ошибка:" + e.Message);
            }
            Console.ReadKey();
        }
    }
}