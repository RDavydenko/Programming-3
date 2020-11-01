using System;

namespace Lab
{
    // Продукт (пищевой)
    public class Product
    {
        private String _name; // Название
        private double _weight; // Вес
        private double _volume; // Объем
        private double _price; // Цена

        // Статическая функция, возвращающая стандартный продукт
        public static Product Default()
        {
            return new Product("Продукт", 1000, 1000, 1000);
        }

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

        public double Weight
        {
            get
            {
                return this._weight;
            }
            private set
            {
                _weight = value;
            }
        }

        public double Volume
        {
            get
            {
                return this._volume;
            }
            private set
            {
                _volume = value;
            }
        }

        public double Price
        {
            get
            {
                return this._price;
            }
            set
            {
                _price = value;
            }
        }

        // Конструктор класса по умолчанию (без параметров)
        public Product()
        {
            Product _default = Product.Default();
            _name = _default.Name;
            _weight = _default.Weight;
            _volume = _default.Volume;
            _price = _default.Price;
        }

        // Конструктор класса с параметрами
        public Product(String name, double weight, double volume, double price)
        {
            _name = name;
            _weight = weight;
            _volume = volume;
            _price = price;
        }

        // Вывести информацию на экран
        public void Display()
        {
            Console.Write("Информация о продукте\n");
            Console.Write("Название: {0}\n", this._name);
            Console.Write("Вес:  {0}\n", this._weight);
            Console.Write("Объем: {0}\n", this._volume);
            Console.Write("Цена: {0}\n", this._price);
        }

        // Ввести с клавиатуры информацию о продукте
        public static Product ReadFromInput()
        {
            String name;
            do
            {
                Console.Write("Введите название: ");
                name = Console.ReadLine();
            } while (name == null || name.Length == 0);

            double weight = 0;
            do
            {
                Console.Write("Введите вес: ");
                double.TryParse(Console.ReadLine(), out weight);
            } while (weight == 0);

            double volume = 0;
            do
            {
                Console.Write("Введите объем: ");
                double.TryParse(Console.ReadLine(), out volume);
            } while (volume == 0);

            double price = 0;
            do
            {
                Console.Write("Введите цену: ");
                double.TryParse(Console.ReadLine(), out price);
            } while (price == 0);

            return new Product(name, weight, volume, price);
        }

        // Прибавить к этому продукту другой продукт
        public void Add(Product other)
        {
            if (other._name != this._name)
            {
                this._name += (" + " + other._name);
            }
            this._weight += other._weight;
            this._volume += other._volume;
            this._price += other._price;
        }

        // Рассчитать цену за грамм продукта
        public double GetPriceByGramm()
        {
            return this._price / this._weight;
        }

        // Расчет эффективности продукта
        public double GetEfficiencyProduct()
        {
            double averageCalorie = 200;
            double priceByGramm = GetPriceByGramm();
            double efficiency = 1 / priceByGramm; // Эффективность (грамм за деньги)
            return efficiency;
        }

        // Расчет плотности продукта
        public double GetProductDensity()
        {
            double density = this._weight / this._volume; // Плотность
            return density;
        }

        // Перегрузка оператора +
        public static Product operator +(Product p1, Product p2)
        {
            return new Product($"{p1.Name} {p2.Name}", p1.Weight + p2.Weight,
                p1.Volume + p2.Volume, p1.Price + p2.Price);
        }

        // Перегрузка оператора ++
        public static Product operator ++(Product x)
        {
            return new Product(x.Name, x.Weight * 2, x.Volume * 2, x.Price * 2);
        }
    }
}