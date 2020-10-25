using System;
namespace Lab
{  
    public class Program {
        public static void Main(String[] args) {
            // Создаем массив продуктов
            Product[] products1 = { new Product("Хлеб", 250, 1, 30), new Product("Масло", 50, 0.2, 20),
                    new Product("Сыр", 100, 0.5, 50), new Product("Колбаса", 100, 0.75, 40) };

            // Создаем бутерброд из продуктов
            Food butter = new Food("Бутерброд", products1);
            butter.Display();
            Console.WriteLine();
            butter.AboutProducts(); // Выводим информацию о продуктах, которые содерждатся в butter

            Console.WriteLine("Заполните поля о продукте: ");
            // Статический метод. Позволяет нам выполнять какие-либо действия
            // без создания экземпляра класса. В данном случае статический метод
            // создает экземпляр класса путем ввода данных с клавиатуры
            Product prod = Product.ReadFromInput();

            // Инициализируем экземпляры классов с помощью конструкторов
            Product p1 = new Product("Картошка", 10500, 3, 300);
            Product p2 = new Product("Капуста", 500, 0.4, 40);
            Console.WriteLine();
            p1.Display(); // Отображаем p1
            Console.WriteLine();
            p1.Add(p2); // Прибавляем к p1 p2
            p1.Display(); // Отображаем p1
            Console.WriteLine();
            p2.Display(); // Отображаем p2
            Console.WriteLine();

            // Рассчитываем какой продукт эффективнее
            double p1Eff = p1.GetEfficiencyProduct();
            double prodEff = prod.GetEfficiencyProduct();
            String winnerName = p1Eff > prodEff ? p1.get_name() : prod.get_name();
            String loserName = prodEff < p1Eff ? prod.get_name() : p1.get_name();
            Console.Write("Эффективность продукта {0} больше, чем эффективность продукта {1}\n", winnerName, loserName);
            Console.WriteLine();

            Product[] products = { new Product("Огурцы", 2000, 1, 80), p1 };

            // Статический метод позволяет приготовить блюдо из массива продуктов
            Food food = Food.CookFood(products);
            food.Display(); // Отображаем информацию о food
            Console.WriteLine();
            Console.WriteLine("Заполните поля о блюде: ");
            Food food2 = Food.ReadFromInput(); // Заполняем информацию о блюде
            Console.WriteLine();
            food2.ApplyDiscount(30); // Применяем скидку 30%
            Console.WriteLine("Введенный продукт после применения скидки 30%: ");
            food2.Display();
            Console.WriteLine();

            Console.Write("Сейчас будем готовить блюдо. Введите количество продуктов, из скольких оно будет состоять: ");
            int n = int.Parse(Console.ReadLine()); // Количество продуктов

            // Массив объектов класса Product
            Product[] productsArray = new Product[n];
            for (int i = 0; i < n; i++) {
                Console.Write("Введите {0} продукт из {1}\n", i + 1, n);
                Product pr = Product.ReadFromInput();
                productsArray[i] = pr;
                Console.WriteLine();
            }

            // Готовим блюдо из введенных продуктов
            Food cookedFood = Food.CookFood(productsArray);
            Console.WriteLine("Приготовленное блюдо: ");
            cookedFood.Display();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}