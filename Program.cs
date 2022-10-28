using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace Lab3_2
{
    class Book
    {
        public class Title
        {
            public string titleStr;

            public Title(string titleStr)
            {
                this.titleStr = titleStr;
                Show();

                void Show()
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Назва: {titleStr}");
                }
            }

        }

        public class Author
        {
            public string authorStr;

            public Author(string authorStr)
            {
                this.authorStr = authorStr;
                Show();

                void Show()
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Автор: {authorStr}");
                }
            }
        }

        public class Content
        {
            public string contentStr;

            public Content(string contentStr)
            {
                this.contentStr = contentStr;
                Show();

                void Show()
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Зміст: {contentStr}");
                }
            }
        }
    }
        
        class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Book book = new Book();

            Console.WriteLine("Уведіть назву книги:");
            string titleSTR = Console.ReadLine();

            Console.WriteLine("Уведіть ім'я автора:");
            string authorSTR = Console.ReadLine();

            Console.WriteLine("Уведіть зміст:");
            string contentSTR = Console.ReadLine();

            Book.Title bookTitle = new Book.Title(titleSTR);
            Book.Author bookAuthor = new Book.Author(authorSTR);
            Book.Content bookContent = new Book.Content(contentSTR);
        }
    }
}
