#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <locale.h>
#include<math.h>
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
	printf("Информация о продукте\n");
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

int main()
{
	system("chcp 1251");
	setlocale(LC_ALL, "Russian");
	system("cls");

	// Тестируем структуру Product
	char name[MAXLEN] = "Курица";
	Product p1 = InitProduct(&name[0], 1, 10, 103);
	DisplayProduct(p1);
	printf("\n");
	Product p2 = ReadProduct();

	Product sum = AddProducts(p1, p2);


	// Тестируем структуру Food
	char name2[MAXLEN] = "Оливье";
	Food f1 = InitFood(&name2[0], 450, 2);
	DisplayFood(f1);
	printf("\n");
	Food f2 = ReadFood();

	Food sum2 = AddFood(f1, f2);
}

