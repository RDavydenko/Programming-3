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

	// Конструктор с одним параметром
	Product(string name) 
	{
		Product _default = Product::Default();
		_name = name;
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

	// Конструктор копирования
	Product(const Product& prod)
	{
		cout << "\nКонструктор копирования\n";
	}

	// Перегрузка оператора присваивания
	Product& operator= (const Product& prod)
	{
		// Выполняем копирование значений
		_name = prod._name;
		_weight = prod._weight;
		_volume = prod._volume;
		_price = prod._price;
		
		return *this;
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

		double* weightPtr = (double*)malloc(sizeof(double));
		do
		{
			cout << "Введите вес: ";
			cin >> *weightPtr;
		} while (*weightPtr == 0);

		if (*weightPtr < 0)
		{
			throw -1;
		}

		double* volumePtr = (double*)malloc(sizeof(double));
		do
		{
			cout << "Введите объем: ";
			cin >> *volumePtr;
		} while (*volumePtr == 0);

		if (*weightPtr < 0)
		{
			throw -2;
		}

		double* pricePtr = (double*)malloc(sizeof(double));
		do
		{
			cout << "Введите цену: ";
			cin >> *pricePtr;
		} while (*pricePtr == 0);

		if (*weightPtr < 0)
		{
			throw -3;
		}

		return Product(name, *weightPtr, *volumePtr, *pricePtr);
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

	// Перегрузка оператора +
	Product operator + (Product p1) {
		this->Add(p1);
		return *this;
	}

	// Перегрузка оператора ++ (префиксная)
	Product operator++ ()
	{
		this->_volume *= 2;
		this->_weight *= 2;

		return *this;
	}

	// Перегрузка оператора ++ (постфиксная)
	Product operator++ (int) 
	{
		Product prev = *this;

		this->_volume *= 2;
		this->_weight *= 2;

		return prev;
	}
};

// Блюдо (приготовленное из продуктов)
class Food
{
private:
	string _name; // Название
	double _price; // Цена
	int _difficult; // Сложность
	/* Ассоциация */ Product* _products; // Продукты, из которых состоит блюдо

public:
	string get_name() { return this->_name; }
	double get_price() { return this->_price; }
	int get_difficult() { return this->_difficult; }
	Product* get_products() { return this->_products; }

public:
	// Конструктор класса без параметров
	Food()
	{
		_name = "Без имени";
		_price = 1;
		_difficult = 1;
	}

	// Конструктор класса с одним параметром
	Food(string name)
	{
		_name = name;
		_price = 1;
		_difficult = 1;
	}

	// Конструктор класса
	Food(string name, double price, int difficult)
	{
		_name = name;
		_price = price;
		_difficult = difficult;
	}

	// Конструктор класса 
	Food(string name, Product* products)
	{
		this->_name = name;
		this->_price = 0;
		this->_difficult = 0;
		this->_products = products;

		int size = sizeof(products);
		for (int i = 0; i < size; i++)
		{
			_price += products[0].get_price();
		}
		this->_price *= 1.2; // Наценка 20%
		if (size <= 2)
		{
			this->_difficult = 1;
		}
		else if (size <= 4)
		{
			this->_difficult = 2;
		}
		else if (size <= 6)
		{
			this->_difficult = 3;
		}
		else if (size <= 10)
		{
			this->_difficult = 4;
		}
		else
		{
			this->_difficult = 5;
		}
	}

	// Вывести информацию на экран
	void Display()
	{
		cout << "Информация о блюде" << endl;
		cout << "Название: " << this->_name << endl;
		cout << "Цена:  " << this->_price << endl;
		cout << "Сложность: " << this->_difficult << endl;
	}

	// Вывести информацию о продуктах, которые составляют блюдо
	void AboutProducts(int size)
	{
		if (_products == nullptr)
		{
			cout << "Информации о продуктах нет" << endl;
		}
		else
		{
			for (int i = 0; i < size; i++)
			{
				cout << "Название: " << _products[i].get_name() << endl;
				cout << "Вес: " << _products[i].get_weight() << endl;
				cout << "Объем: " << _products[i].get_volume() << endl;
				cout << "Цена: " << _products[i].get_price() << endl;
				cout << endl;
			}
		}
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
	static Food* ReadFromInput()
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

		static Food food = Food(name, price, difficult);
		return &food;
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

		Food result = Food(compositeName, price, difficult);
		result._products = products;
		return result;
	}

	// Дружественная функция
	friend void Rename(Food& food, string name);

	// Перегрузка оператора +
	Food operator + (Food f1) {
		this->Add(f1);
		return *this;
	}
};

// Дружественная функция
void Rename(Food& food, string name) {
	food._name = name;
}

int main()
{
	system("chcp 1251");
	setlocale(LC_ALL, "Russian");
	system("cls");

	// Использование конструкторов
	Product p100 = Product();
	Product p101 = Product("Хлеб");
	Product p102 = Product("Хлеб", 100, 1000, 20);
	Food f100 = Food();
	Food f101 = Food("Бутерброд");
	Food f102 = Food("Бутеброд", 100, 2);

	// Инициализация массива с помощью конструктора по умолчанию
	Product pArr100[10];
	for (int i = 0; i < 10; i++)
	{
		pArr100[i] = Product();
	}

	// Создаем массив продуктов
	Product products1[] = {
		Product("Хлеб", 250, 1, 30),
		Product("Масло", 50, 0.2, 20),
		Product("Сыр", 100, 0.5, 50),
		Product("Колбаса",100, 0.75, 40)
	};
	// Создаем бутерброд из продуктов
	Food butter = Food("Бутерброд", products1);
	butter.Display();
	cout << endl;
	butter.AboutProducts(4); // Выводим информацию о продуктах, которые содерждатся в butter

	// Двумерный массив
	Product productsTwoMerniy[2][3];
	productsTwoMerniy[0][0] = Product("Хлеб", 250, 1, 30);
	productsTwoMerniy[0][1] = Product("Масло", 250, 1, 30);
	productsTwoMerniy[0][2] = Product("Сыр", 250, 1, 30);

	productsTwoMerniy[1][0] = Product("Яйца", 250, 1, 30);
	productsTwoMerniy[1][1] = Product("Молоко", 250, 1, 30);
	productsTwoMerniy[1][2] = Product("Соль", 250, 1, 30);
	for (int i = 0; i < 2; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			productsTwoMerniy[i][j].Display();
		}
		cout << endl;
	}
	

	cout << "Заполните поля о продукте: " << endl;

	try
	{
		Product pTest = Product::ReadFromInput();
	}
	catch (int a)
	{
		cout << "Произошла ошибка номер ";
		printf("%d\n", a);
	}


	cout << "\nЗаполните поля о продукте: " << endl;
	// Статический метод. Позволяет нам выполнять какие-либо действия
	// без создания экземпляра класса. В данном случае статический метод
	// создает экземпляр класса путем ввода данных с клавиатуры
	Product prod = Product::ReadFromInput();

	// Инициализируем экземпляры классов с помощью конструкторов
	Product p1 = Product("Картошка", 10500, 3, 300);
	Product p2 = Product("Капуста", 500, 0.4, 40);
	cout << endl;
	p1.Display(); // Отображаем p1
	cout << endl;
	p1 = p1 + p2; // Прибавляем к p1 p2 (Используя перегрузку)
	p1.Display(); // Отображаем p1
	cout << endl;
	p2.Display(); // Отображаем p2
	cout << endl;

	cout << "Капуста после оператора ++" << endl;
	p2++; // Используем перегрузку
	p2.Display();

	// Рассчитываем какой продукт эффективнее
	double p1Eff = p1.GetEfficiencyProduct();
	double prodEff = prod.GetEfficiencyProduct();
	string winnerName = p1Eff > prodEff ? p1.get_name() : prod.get_name();
	string loserName = prodEff < p1Eff ? prod.get_name() : p1.get_name();
	cout << "Эффективность продукта " << winnerName << " больше, чем эффективность продукта " << loserName << endl;
	cout << endl;

	Product products[] =
	{
		Product("Огурцы", 2000, 1, 80),
		p1
	};
	// Статический метод позволяет приготовить блюдо из массива продуктов
	Food food = Food::CookFood(products, 2);

	// Используем дружественную функцию
	Rename(food, "Салат");

	food.Display(); // Отображаем информацию о food
	cout << endl;
	cout << "Заполните поля о блюде: " << endl;
	Food food2 = *(Food::ReadFromInput()); // Заполняем информацию о блюде
	cout << endl;
	food2.ApplyDiscount(30); // Применяем скидку 30%
	cout << "Введенный продукт после применения скидки 30%: " << endl;
	food2.Display();
	cout << endl;

	cout << "Сейчас будем готовить блюдо. Введите количество продуктов, из скольких оно будет состоять: ";
	int n; // Количество продуктов
	cin >> n;
	// ДИНАМИЧЕСКИ инициализируем массив объектов класса Product
	Product* productsArray = new Product[n]();
	for (int i = 0; i < n; i++)
	{
		cout << "Введите " << i + 1 << " продукт из " << n << endl;
		Product prod = Product::ReadFromInput();
		productsArray[i] = prod;
		cout << endl;
	}
	// Готовим блюдо из введенных продуктов
	Food cookedFood = Food::CookFood(productsArray, n);
	cout << "Приготовленное блюдо: " << endl;
	cookedFood.Display();
	cout << endl;
	// Очищаем память
	delete[] productsArray;
}
