using System;

namespace Lab
{
    // Блюдо (приготовленное из продуктов)
    public class Food : IDisplayable
    {
        private String _name; // Название
        private double _price; // Цена
        private int _difficult; // Сложность

        /* Ассоциация */
        Product[] _products; // Продукты, из которых состоит блюдо

        public String Name
        {
            get
            {
                return this._name;
            }
            private set
            {
                _name = value;
            }
        }

        public double Price
        {
            get
            {
                return this._price;
            }
            private set
            {
                _price = value;
            }
        }

        public int Difficult
        {
            get
            {
                return this._difficult;
            }
            private set
            {
                _difficult = value;
            }
        }

        public Product[] Products
        {
            get
            {
                return this._products;
            }
        }

        // Конструктор без параметров
        public Food()
        {
            _name = "Без имени";
            _price = 1;
            _difficult = 1;
        }

        // Конструктор с одним параметром
        public Food(string name)
        {
            _name = name;
            _price = 1;
            _difficult = 1;
        }


        // Конструктор класса
        public Food(String name, double price, int difficult)
        {
            _name = name;
            _price = price;
            _difficult = difficult;
        }

        // Конструктор класса
        public Food(String name, Product[] products)
        {
            this._name = name;
            this._price = 0;
            this._difficult = 0;
            this._products = products;

            for (int i = 0; i < products.Length; i++)
            {
                _price += products[i].Price;
            }
            this._price *= 1.2; // Наценка 20%
            if (products.Length <= 2)
            {
                this._difficult = 1;
            }
            else if (products.Length <= 4)
            {
                this._difficult = 2;
            }
            else if (products.Length <= 6)
            {
                this._difficult = 3;
            }
            else if (products.Length <= 10)
            {
                this._difficult = 4;
            }
            else
            {
                this._difficult = 5;
            }
        }

        // Вывести информацию на экран
        public void Display()
        {
            Console.Write("Информация о блюде\n");
            Console.Write("Название: {0}\n", this._name);
            Console.Write("Цена:  {0}\n", this._price);
            Console.Write("Сложность: {0}\n", this._difficult);
        }

        // Перегруза оператора ToString()
        public override string ToString() 
        {
            var res = string.Empty;
            res += string.Format("Информация о блюде\n");
            res += string.Format("Название: {0}\n", this._name);
            res += string.Format("Цена:  {0}\n", this._price);
            res += string.Format("Сложность: {0}\n", this._difficult);
            return res;
        }

        // Вывести информацию о продуктах, которые составляют блюдо
        public void AboutProducts()
        {
            if (_products.Length == 0)
            {
                Console.WriteLine("Информации о продуктах нет");
            }
            else
            {
                for (int i = 0; i < _products.Length; i++)
                {
                    Console.Write("Название: {0}\n", _products[i].Name);
                    Console.Write("Вес: {0}\n", _products[i].Weight);
                    Console.Write("Объем: {0}\n", _products[i].Volume);
                    Console.Write("Цена: {0}\n", _products[i].Price);
                    Console.WriteLine();
                }
            }
        }

        // Прибавить к этому блюду другое блюдо
        public void Add(Food other)
        {
            if (other._name != this._name)
            {
                this._name += (" + " + other._name);
            }
            this._price += other._price;
            this._difficult = (int)Math.Ceiling((this._difficult + other._difficult) / 2.0);
        }

        // Ввести с клавиатуры информацию о блюде
        public static Food ReadFromInput()
        {
            String name;
            do
            {
                Console.Write("Введите название: ");
                name = Console.ReadLine();
            } while (name == null || name.Length == 0);

            double price = 0;
            do
            {
                Console.Write("Введите цену: ");
                double.TryParse(Console.ReadLine(), out price);
            } while (price == 0);

            int difficult = 0;
            do
            {
                Console.Write("Введите сложность: ");
                int.TryParse(Console.ReadLine(), out difficult);
            } while (difficult == 0);

            return new Food(name, price, difficult);
        }

        // Применить скидку
        public void ApplyDiscount(int percent)
        {
            if (percent < 0)
            {
                percent = 0;
            }
            if (percent > 100)
            {
                percent = 100;
            }
            this._price *= (100 - percent) / 100.0;
        }

        // Приготовить еду из продуктов
        public static Food CookFood(Product[] products)
        {
            String compositeName = "";
            double price = 0;
            for (int i = 0; i < products.Length; i++)
            {
                compositeName += products[i].Name;
                if (i != products.Length - 1)
                {
                    compositeName += " + ";
                }
                price += products[i].Price;
            }
            price *= 1.2; // Наценка 20%
            int difficult = 0;
            if (products.Length <= 2)
            {
                difficult = 1;
            }
            else if (products.Length <= 4)
            {
                difficult = 2;
            }
            else if (products.Length <= 6)
            {
                difficult = 3;
            }
            else if (products.Length <= 10)
            {
                difficult = 4;
            }
            else
            {
                difficult = 5;
            }

            Food result = new Food(compositeName, price, difficult);
            result._products = products;
            return result;
        }

        // Перегрузка оператора +
        public static Food operator +(Food f1, Food f2)
        {
            return new Food(f1.Name + " " + f2.Name, f1.Price + f2.Price, f1.Difficult + f2.Difficult);
        }
    }
}