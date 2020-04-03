using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyprojecsApp
{
    class Program
    {
        static void Main(string[] args)
        { /*                                   //Задача 1
            Console.Write("side1 = ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("side2 = ");
            double side2 = double.Parse(Console.ReadLine());
            Rectangle rect1 = new Rectangle(side1, side2);
            System.Console.WriteLine($"Area = {rect1.Area}\nPerimeter = {rect1.Perimeter}");
            Console.ReadKey();

                                              //Задача 2
            Book book;
            Console.Write("Введите имя автора:  ");
            string Author =Console.ReadLine();
            Console.Write("Введите название книги:  ");
            string Title =Console.ReadLine();
            Console.Write("Введите содержание книги: ");
            string content = Console.ReadLine();
            book = new Book( Author, Title,content);
            book.Show();
            Console.ReadKey();

                                            //Задача 3
            Animal GetInfo = new Animal();
            Animal Kot = new Animal("Лила","nicely",2.5,"Сабринна");
            Animal Sobaka = new Animal("Барсик","good",15,"Иван");
            Animal Tigr = new Animal("Канадскый тигр",63.4);


            Console.WriteLine("Просмотрим информацию о некоторие животнии:\n");
            GetInfo.Show();
            Console.WriteLine("\t\t Кошка\n");
            Kot.Show();
            Console.WriteLine("\t\t Собака\n");
            Sobaka.Show();
            Console.WriteLine("\t\t Тигр\n");
            Tigr.Show();

            Console.ReadKey();*/
        }
        class Rectangle
        {
            public double side1 { get; set; }
            public double side2 { get; set; }
            public Rectangle(double side1, double side2)
            {
                this.side1 = side1;
                this.side2 = side2;
            }
            public double Area
            {
                get
                {
                    return AreaCalculator();
                }

            }
            public double Perimeter
            {
                get
                {
                    return PerimeterCalculator();
                }
            }
            private double AreaCalculator()
            {
                return this.side1 * this.side2;

            }
            private double PerimeterCalculator()
            {
                return 2 * (this.side1 + this.side2);
            }

        }
        class Book
        {
            public Content MyCont { get; set; }
            public Title MyTitle { get; set; }
            public Author MyAuthor { get; set; }
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                MyAuthor.Show();
                Console.ForegroundColor = ConsoleColor.Green;
                MyTitle.Show();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                MyCont.Show();
            }
            public Book()
            {
                MyAuthor = new Author();
                MyTitle = new Title();
                MyCont = new Content();
            }
            public Book(string autName, string bookTitle, string bookContent)
            {
                MyAuthor = new Author();
                MyTitle = new Title();
                MyCont = new Content();
                MyCont.BookContent = bookContent;
                MyAuthor.AutName = autName;
                MyTitle.BookName = bookTitle;
            }
        }
        class Title
        {
            public string BookName { get; set; }
            public void Show()
            {
                Console.WriteLine("Название: " + BookName);
            }
        }
        class Author
        {
            public string AutName { get; set; }
            public void Show()
            {
                Console.WriteLine("Автор: " + AutName);
            }

        }

        class Content
        {
            public string BookContent { get; set; }
            public void Show()
            {
                Console.WriteLine("Содержание: " + BookContent);
            }
        }

        class Animal
    {
        private string Name;
        private string Kind;
        private string Master;
        private double Weight;
        public Animal(string Name, string Kind, double Weight, string Master) 
        {
            this.Name = Name;
            this.Kind = Kind;
            this.Weight = Weight;
            this.Master = Master;
        }
        public Animal(string Name, double Weight)
        {
            this.Name = Name;
            this.Weight = Weight;
        }
        public Animal()
        {
            this.Name =" Name ";
            this.Kind = "Kind ";
            this.Master = "Master Weight";
        }
        public void Show()
        {System.Console.WriteLine("-------------------------------------------");
            Console.WriteLine( $"{Name}   {Kind}   {Master}   {Weight}\n");
        }
    }
    }
}
