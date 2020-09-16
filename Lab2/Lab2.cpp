#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <locale.h>
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
	Product Products[20];
	double Price;
	int Difficult;
};

// Инициализация
Product Init(char* productName, double weight, double volume, double price)
{
	Product res = { productName,  weight, volume, price };
	return res;
}

// Инициализация путем ввода с клавиатуры
Product Read()
{
	Product product;
	char s[MAXLEN];
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

// Вывод на экран
void Display(Product p)
{
	printf("Информация о продукте\n");
	printf("Название: %s\n", p.ProductName);
	printf("Вес: %g\n", p.Weight);
	printf("Объем: %g\n", p.Volume);
	printf("Цена: %g\n", p.Price);
}

// Сложение продуктов 
Product Add(Product p1, Product p2)
{	
	Product result;
	if (strcmp(p1.ProductName, p2.ProductName) == 0)
	{
		result.ProductName = p1.ProductName;
	}
	else
	{		
		result.ProductName = strcat(p1.ProductName, p2.ProductName);
	}
	result.Weight = p1.Weight + p2.Weight;
	result.Volume = p1.Volume + p2.Volume;
	result.Price = p1.Price + p2.Price;
	
	return result;
}

int main()
{
	system("chcp 1251");
	setlocale(LC_ALL, "Russian");
	system("cls");

	char name[MAXLEN] = "Курица";
	Product p1 = Init(&name[0], 1, 10, 103);
	Display(p1);
	Product p2 = Read();

	Product sum = Add(p1, p2);
}

