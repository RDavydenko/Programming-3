#include <iostream>
#include <string>
#include <locale.h>
using namespace std;


// Продукт (пищевой)
class Product {
private:
	string _name;  // Название
	double _weight; // Вес
	double _volume; // Объем
	double _price; // Цена

public:
	// Статическая функция, возвращающая стандартный продукт
	static Product Default() 
	{
		return Product("Продукт", 1000, 1000, 1000);
	}

public:
	string get_name() { return this->_name; }
	double get_weight() { return this->_weight; }
	double get_volume() { return this->_volume; }
	double get_price() { return this->_price; }

public:

	// Конструктор класса по умолчанию (без параметров)
	Product()
	{
		Product _default = Product::Default();
		_name = _default.get_name();
		_weight = _default.get_weight();
		_volume = _default.get_volume();
		_price = _default.get_price();
	}

	// Конструктор класса с параметрами
	Product(string name, double weight, double volume, double price)
	{
		_name = name;
		_weight = weight;
		_volume = volume;
		_price = price;
	}

	// Вывести информацию на экран
	void Display()
	{
		cout << "Информация о продукте" << endl;
		cout << "Название: " << this->_name << endl;
		cout << "Вес:  " << this->_weight << endl;
		cout << "Объем: " << this->_volume << endl;
		cout << "Цена: " << this->_price << endl;
	}

	// Ввести с клавиатуры информацию о продукте
	static Product ReadFromInput()
	{
		string name;
		do
		{
			cout << "Введите название: ";
			cin >> name;
		} while (name.empty());

		double weight = 0;
		do
		{
			cout << "Введите вес: ";
			cin >> weight;
		} while (weight == 0);

		double volume = 0;
		do
		{
			cout << "Введите объем: ";
			cin >> volume;
		} while (volume == 0);

		double price = 0;
		do
		{
			cout << "Введите цену: ";
			cin >> price;
		} while (price == 0);

		return Product(name, weight,  volume, price);
	}

	// Прибавить к этому продукту другой продукт
	void Add(Product other)
	{
		if (other._name != this->_name)
		{
			this->_name += (" + " + other._name);
		}
		this->_weight += other._weight;
		this->_volume += other._volume;
		this->_price += other._price;
	}
	
	// Рассчитать цену за грамм продукта
	double GetPriceByGramm()
	{
		return this->_price / this->_weight;
	}

	// Расчет эффективности продукта
	double GetEfficiencyProduct()
	{
		double averageCalorie = 200;
		double priceByGramm = GetPriceByGramm();
		double efficiency = 1 / priceByGramm; // Эффективность (грамм за деньги)
		return efficiency;
	}

	// Расчет плотности продукта
	double GetProductDensity()
	{
		double density = this->_weight / this->_volume; // Плотность
		return density;
	}
};

// Блюдо (приготовленное из продуктов)
class Food
{
private:
	string _name; // Название
	double _price; // Цена
	int _difficult; // Сложность

public:
	string get_name() { return this->_name; }
	double get_price() { return this->_price; }
	int get_difficult() { return this->_difficult; }

public:
	// Конструктор класса
	Food(string name, double price, int difficult)
	{
		_name = name;
		_price = price;
		_difficult = difficult;
	}

	// Вывести информацию на экран
	void Display()
	{
		cout << "Информация о блюде" << endl;
		cout << "Название: " << this->_name << endl;
		cout << "Цена:  " << this->_price << endl;
		cout << "Сложность: " << this->_difficult << endl;
	}

	// Прибавить к этому блюду другое блюдо
	void Add(Food other)
	{
		if (other._name != this->_name)
		{
			this->_name += (" + " + other._name);
		}
		this->_price += other._price;
		this->_difficult = (int)ceil((this->_difficult + other._difficult) / 2);
	}

	// Ввести с клавиатуры информацию о блюде
	static Food ReadFromInput()
	{
		string name;
		do
		{
			cout << "Введите название: ";
			cin >> name;
		} while (name.empty());

		double price = 0;
		do
		{
			cout << "Введите цену: ";
			cin >> price;
		} while (price == 0);

		int difficult = 0;
		do
		{
			cout << "Введите сложность: ";
			cin >> difficult;
		} while (difficult == 0);

		return Food(name, price, difficult);
	}

	// Применить скидку
	void ApplyDiscount(int percent)
	{
		if (percent < 0)
		{
			percent = 0;
		}
		if (percent > 100)
		{
			percent = 100;
		}
		this->_price *= (100 - percent) / 100.0;
	}

	// Приготовить еду из продуктов
	static Food CookFood(Product products[], int size)
	{
		string compositeName = "";
		double price = 0;
		for (int i = 0; i < size; i++)
		{
			compositeName += products[i].get_name();
			if (i != size - 1)
			{
				compositeName += " + ";
			}
			price += products[i].get_price();
		}
		price *= 1.2; // Наценка 20%
		int difficult = 0;
		if (size <= 2)
		{
			difficult = 1;
		}
		else if (size <= 4)
		{
			difficult = 2;
		}
		else if (size <= 6)
		{
			difficult = 3;
		}
		else if (size <= 10)
		{
			difficult = 4;
		}
		else
		{
			difficult = 5;
		}

		return Food(compositeName, price, difficult);
	}
};

int main()
{
	system("chcp 1251");
	setlocale(LC_ALL, "Russian");
	system("cls");

	//cout << "Заполните поля о продукте: " << endl;
	//// Статический метод. Позволяет нам выполнять какие-либо действия
	//// без создания экземпляра класса. В данном случае статический метод
	//// создает экземпляр класса путем ввода данных с клавиатуры
	//Product prod = Product::ReadFromInput();

	//// Инициализируем экземпляры классов с помощью конструкторов
	//Product p1 = Product("Картошка", 10500, 3, 300);
	//Product p2 = Product("Капуста", 500, 0.4, 40);
	//cout << endl;
	//p1.Display(); // Отображаем p1
	//cout << endl;
	//p1.Add(p2); // Прибавляем к p1 p2
	//p1.Display(); // Отображаем p1
	//cout << endl;
	//p2.Display(); // Отображаем p2
	//cout << endl;
	//// Рассчитываем какой продукт эффективнее
	//double p1Eff = p1.GetEfficiencyProduct();
	//double p2Eff = p2.GetEfficiencyProduct();
	//string winnerName = p1Eff > p2Eff ? p1.get_name() : p2.get_name();
	//string loserName = p2Eff > p1Eff ? p2.get_name() : p1.get_name();
	//cout << "Эффективность продукта" << winnerName << " больше, чем эффективность продукта" << loserName << endl;
	//cout << endl;

	//Product products[] =
	//{
	//	Product("Огурцы", 2000, 1, 80),
	//	p1
	//};
	//// Статический метод позволяет приготовить блюдо из массива продуктов
	//Food food = Food::CookFood(products, 2);
	//food.Display(); // Отображаем информацию о food
	//cout << endl;
	//cout << "Заполните поля о блюде: " << endl;
	//Food food2 = Food::ReadFromInput(); // Заполняем информацию о блюде
	//cout << endl;
	//food2.ApplyDiscount(30); // Применяем скидку 30%
	//cout << "Введенный продукт после применения скидки 30%: " << endl;
	//food2.Display();
	//cout << endl;

	cout << "Сейчас будем готовить блюдо. Введите количество продуктов, из скольких оно будет состоять: ";
	int n; // Количество продуктов
	cin >> n;
	// ДИНАМИЧЕСКИ инициализируем массив объектов класса Product
	Product* products = new Product[n]();
	for (int i = 0; i < n; i++)
	{
		cout << "Введите " << i + 1 << " продукт из " << n << endl;
		Product prod = Product::ReadFromInput();
		products[i] = prod;
		cout << endl;
	}
	// Готовим блюдо из введенных продуктов
	Food cookedFood = Food::CookFood(products, n);
	cout << "Приготовленное блюдо: " << endl;
	cookedFood.Display();
	cout << endl;
}
