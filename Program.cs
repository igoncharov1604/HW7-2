namespace ConsoleApp18
{
    using System;
    using System.Collections.Generic;

    // Клас Дерево
    public class Дерево
    {
        public string Порода { get; set; }
        public double Ціна { get; set; }
        public double Висота { get; set; }

        public Дерево(string порода, double ціна, double висота)
        {
            Порода = порода;
            Ціна = ціна;
            Висота = висота;
        }

        public override string ToString()
        {
            return $"Порода: {Порода}, Ціна: {Ціна} грн, Висота: {Висота} м";
        }
    }

    // Компаратор для порівняння дерев за ціною
    public class ПорівнянняЗаЦіною : IComparer<Дерево>
    {
        public int Compare(Дерево x, Дерево y)
        {
            if (x == null || y == null)
                throw new ArgumentException("Об'єкти для порівняння не повинні бути null");

            return x.Ціна.CompareTo(y.Ціна);
        }
    }

    // Компаратор для порівняння дерев за висотою
    public class ПорівнянняЗаВисотою : IComparer<Дерево>
    {
        public int Compare(Дерево x, Дерево y)
        {
            if (x == null || y == null)
                throw new ArgumentException("Об'єкти для порівняння не повинні бути null");

            return x.Висота.CompareTo(y.Висота);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Створення масиву об'єктів класу Дерево
            Дерево[] дерева = {
            new Дерево("Дуб", 500, 20),
            new Дерево("Береза", 300, 15),
            new Дерево("Сосна", 400, 25),
            new Дерево("Ялина", 350, 18)
        };

            // Сортування за ціною
            Array.Sort(дерева, new ПорівнянняЗаЦіною());
            Console.WriteLine("Відсортовані дерева за ціною:");
            foreach (var дерево in дерева)
            {
                Console.WriteLine(дерево);
            }

            // Сортування за висотою
            Array.Sort(дерева, new ПорівнянняЗаВисотою());
            Console.WriteLine("\nВідсортовані дерева за висотою:");
            foreach (var дерево in дерева)
            {
                Console.WriteLine(дерево);
            }
        }
    }

}
