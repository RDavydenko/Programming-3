using System;

namespace Lab
{
    // Мясо (наследуется от продукта)
    public class Meat : Product
    {
        public Meat() :base("Мясо") { }

        // Конструктор класса с параметрами
        public Meat(double weight, double volume, double price)
            : base("Мясо", weight, volume, price) { } 

        // Ввести с клавиатуры информацию о мясе
        public static Meat ReadFromInput()
        {
            double weight = 0;
            do
            {
                Console.Write("Введите вес: ");
                double.TryParse(Console.ReadLine(), out weight);
            } while (weight == 0);

            if (weight < 0) 
            {
                throw new Exception("Вес не может быть отрицательным!");
            }

            double volume = 0;
            do
            {
                Console.Write("Введите объем: ");
                double.TryParse(Console.ReadLine(), out volume);
            } while (volume == 0);

             if (volume < 0) 
            {
                throw new Exception("Объем не может быть отрицательным!");
            }

            double price = 0;
            do
            {
                Console.Write("Введите цену: ");
                double.TryParse(Console.ReadLine(), out price);
            } while (price == 0);

            if (price < 0) 
            {
                throw new Exception("Цена не может быть отрицательной!");
            }

            return new Meat(weight, volume, price);
        }

        // Расчет эффективности продукта
        public override double GetEfficiencyProduct()
        {
            var baseEfficency = base.GetEfficiencyProduct();
            return baseEfficency * 1.5; // Коэффициент эффективности мяса
        }
    }
}