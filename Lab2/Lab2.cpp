﻿#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <locale.h>
#include<math.h>
#include <conio.h>
#define MAXLEN 1000
#define PLUS "+"

// Продукт
struct Product
{
	char* ProductName;
	double Weight;
	double Volume;
	double Price;
};

// Готовая еда (набор продуктов)
struct Food
{
	char* Name;
	double Price;
	int Difficult;
};

// Инициализация продукта
Product InitProduct(char* productName, double weight, double volume, double price)
{
	Product res = { productName,  weight, volume, price };
	return res;
}

// Инициализация еды
Food InitFood(char* name, double price, int difficult)
{
	Food res = { name, price, difficult };
	return res;
}

// Инициализация продукта путем ввода с клавиатуры
Product ReadProduct()
{
	Product product;
	char* s = (char*)calloc(MAXLEN, sizeof(char));
	do
	{
		printf("Введите название продукта: ");
		gets_s(s, MAXLEN - 1);
	} while (s == NULL || s == nullptr || strlen(s) == 0);
	product.ProductName = s;

	int result;
	double w;
	do
	{
		printf("Введите вес продукта: ");
		result = scanf_s("%lf", &w);
		while (getchar() != '\n');
	} while (result == 0);
	product.Weight = w;

	double v;
	do
	{
		printf("Введите объем продукта: ");
		result = scanf_s("%lf", &v);
		while (getchar() != '\n');
	} while (result == 0);
	product.Volume = v;

	double p;
	do
	{
		printf("Введите цену продукта: ");
		result = scanf_s("%lf", &p);
		while (getchar() != '\n');
	} while (result == 0);
	product.Price = p;

	return product;
}

// Инициализация еды путем ввода с клавиатуры
Food ReadFood()
{
	Food food;
	char* s = (char*)calloc(MAXLEN, sizeof(char));
	do
	{
		printf("Введите название еды: ");
		gets_s(s, MAXLEN - 1);
	} while (s == NULL || s == nullptr || strlen(s) == 0);
	food.Name = s;

	int result;
	double p;
	do
	{
		printf("Введите цену еды: ");
		result = scanf_s("%lf", &p);
		while (getchar() != '\n');
	} while (result == 0);
	food.Price = p;

	int d;
	do
	{
		printf("Введите сложность приготовления еды (от 0 до 5): ");
		result = scanf_s("%i", &d);
		while (getchar() != '\n');
	} while (result == 0 || d < 0 || d > 5);
	food.Difficult = d;

	return food;
}

// Вывод на экран информации о продукте
void DisplayProduct(Product p)
{
	printf("Информация о продукте\n");
	printf("Название: %s\n", p.ProductName);
	printf("Вес: %g\n", p.Weight);
	printf("Объем: %g\n", p.Volume);
	printf("Цена: %g\n", p.Price);
}

// Вывод на экран информации о еде
void DisplayFood(Food f)
{
	printf("Информация о блюде\n");
	printf("Название: %s\n", f.Name);
	printf("Цена: %g\n", f.Price);
	printf("Сложность: %i\n", f.Difficult);
}

// Сложение продуктов 
Product AddProducts(Product p1, Product p2)
{
	Product result;
	char* strcopy1 = (char*)calloc(MAXLEN, sizeof(char));
	char* strcopy2 = (char*)calloc(MAXLEN, sizeof(char));
	strcpy(strcopy1, p1.ProductName);
	strcpy(strcopy2, p2.ProductName);
	if (strcmp(strcopy1, strcopy2) == 0)
	{
		result.ProductName = strcopy1;
	}
	else
	{
		result.ProductName = strcat(strcopy1, strcopy2);
	}
	result.Weight = p1.Weight + p2.Weight;
	result.Volume = p1.Volume + p2.Volume;
	result.Price = p1.Price + p2.Price;

	return result;
}

// Сложение еды 
Food AddFood(Food f1, Food f2)
{
	Food result;
	char* strcopy1 = (char*)calloc(MAXLEN, sizeof(char));
	char* strcopy2 = (char*)calloc(MAXLEN, sizeof(char));
	strcpy(strcopy1, f1.Name);
	strcpy(strcopy2, f2.Name);
	if (strcmp(strcopy1, strcopy2) == 0)
	{
		result.Name = strcopy1;
	}
	else
	{
		result.Name = strcat(strcopy1, strcopy2);
	}
	result.Price = f1.Price + f2.Price;
	result.Difficult = (int)ceil((f1.Difficult + (double)f2.Difficult) / 2);

	return result;
}

// Рассчитать цену за грамм продукта
double GetPriceByGramm(Product p)
{
	return p.Price / p.Weight;
}

// Расчет эффективности продукта
double GetEfficiencyProduct(Product p)
{
	double averageCalorie = 200;
	double priceByGramm = GetPriceByGramm(p);
	double efficiency = 1 / priceByGramm; // Эффективность (грамм за деньги)
	return efficiency;
}

// Расчет плотности продукта
double GetProductDensity(Product p)
{
	double density = p.Weight / p.Volume; // Плотность
	return density;
}

// Приготовить блюдо из продуктов
Food CookFood(Product products[], int size)
{
	char empty[MAXLEN] = "Блюдо из: ";
	char whitespace[2] = " ";
	Food result = { &empty[0], 0, 0 };
	for (int i = 0; i < size; i++)
	{
		char* temp = (char*)calloc(MAXLEN, sizeof(char));
		strcpy(temp, result.Name);
		strcat(result.Name, products[i].ProductName);
		strcat(result.Name, whitespace);
		result.Price += products[i].Price;
	}
	if (size <= 2)
	{
		result.Difficult = 1;
	}
	else if (size <= 4)
	{
		result.Difficult = 2;
	}
	else if (size <= 6)
	{
		result.Difficult = 3;
	}
	else if (size <= 10)
	{
		result.Difficult = 4;
	}
	else
	{
		result.Difficult = 5;
	}
	result.Price *= 1.2; // Наценка 20%
	return result;
}

// Применить скидку
Food ApplyDiscount(Food f, int percent)
{
	if (percent < 0)
	{
		percent = 0;
	}
	if (percent > 100)
	{
		percent = 100;
	}
	f.Price *= (100 - percent) / 100.0;
	return f;
}

int main()
{
	system("chcp 1251");
	setlocale(LC_ALL, "Russian");
	system("cls");

	// Тестируем структуру Product
	char name[MAXLEN] = "Курица";
	Product p1 = InitProduct(&name[0], 1000, 100, 103);
	DisplayProduct(p1);
	printf("\n");
	Product p2 = ReadProduct();

	Product sum = AddProducts(p1, p2);

	double chickenEff = GetEfficiencyProduct(p1);
	double customEff = GetEfficiencyProduct(p2);
	char* winnerName = chickenEff > customEff ? p1.ProductName : p2.ProductName;
	char* loserName = chickenEff > customEff ? p2.ProductName : p1.ProductName;

	printf("\n");
	printf("Эффективность продукта %s больше, чем эффективность продукта %s\n", winnerName, loserName);
	printf("\n");

	// Тестируем структуру Food
	char name2[MAXLEN] = "Оливье";
	Food f1 = InitFood(&name2[0], 450, 2);
	DisplayFood(f1);
	printf("\n");
	Food f2 = ReadFood();
	printf("\n");

	Food sum2 = AddFood(f1, f2);

	Product prods[] = { p1, p2 };
	Food cookedFood = CookFood(prods, 2);
	DisplayFood(cookedFood);
	printf("\n");

	printf("\n");
	printf("Цена блюда до скидки: %g\n", cookedFood.Price);
	printf("\n");

	int discount = 75;
	Food discountedFood = ApplyDiscount(cookedFood, discount);
	printf("Цена блюда после применения скидки %d% : %g\n", discount, discountedFood.Price);
	printf("\n");

	// Пример работы с динамическими переменными типа структур
	Product* dynamicP1 = (Product*)malloc(sizeof(Product));
	char prodName[MAXLEN] ="Трюфели";
	dynamicP1->ProductName = prodName;
	dynamicP1->Weight = 1500;
	dynamicP1->Volume = 500;
	dynamicP1->Price = 10000;
	DisplayProduct(*dynamicP1);
	printf("\n");

	Food* dynamicF1 = (Food*)malloc(sizeof(Food));
	char foodName[MAXLEN] = "Утка по-пекински";
	dynamicF1->Name = foodName;
	dynamicF1->Price = 5000;
	dynamicF1->Difficult = 3;
	DisplayFood(*dynamicF1);
	printf("\n");


	_getch();
}

