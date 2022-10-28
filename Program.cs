using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
//using System.ValueTuple;

namespace Lab3_4
{
    class Invoice
    {
        public int account;
        public string customer;
        public string provider;

        internal string article;
        internal int quantity;

        public Invoice(int account, string customer, string provider, string article, int quantity)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            this.quantity = quantity;

            int withVAT = Calculate(article, quantity).Item1;
            int withoutVAT = Calculate(article, quantity).Item2;

            if (withoutVAT == 0)
            {
                Console.WriteLine($"Невірний артикул");
            }
            else
            {
                Console.WriteLine($"ID: {account}");
                Console.WriteLine($"Ім'я замовника: {customer}");
                Console.WriteLine($"Ім'я постачальника: {provider}");
                Console.WriteLine($"Артикул товару: {article}");
                Console.WriteLine($"Кількість (од.): {quantity}");
                Console.WriteLine($"Вартість замовлення з ПДВ: {withVAT}");
                Console.WriteLine($"Вартість замовлення без ПДВ: {withoutVAT}");
            }
        }

        Tuple<int, int> Calculate(string article, int quantity)
        {
            int VAT = 20;
            int price;

            switch (article)
            {
                case "0001":
                    price = 1500;
                    break;

                case "0002":
                    price = 5400;
                    break;

                case "0003":
                    price = 8200;
                    break;

                default:
                    price = 0;
                    break;
            }

            int withVAT = (quantity * (price + ((price / 100) * VAT)));
            int withoutVAT = quantity * price;

            return Tuple.Create(withVAT, withoutVAT);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            int acc = 0;

            Console.WriteLine("Введіть ім'я замовника");
            string customerName = Console.ReadLine();

            Console.WriteLine("Введіть ім'я постачальника");
            string providerName = Console.ReadLine();

            Console.WriteLine("Введіть артикул товару(останні чотири цифри артикулу)");
            string articleName = Console.ReadLine();

            Console.WriteLine("Введіть кількість товару");
            int quantityName = Convert.ToInt32(Console.ReadLine());

            Invoice invo = new Invoice(acc, customerName, providerName, articleName, quantityName);
        }
    }
}