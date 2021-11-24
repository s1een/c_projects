/**
* @file Choice.cpp
* @author Морозов Д.С., гр. 515Б
* @date 23 июня 2019
* @brief Практическое задание
*
* Сравнение алгоритмов сортировки.  Сортировка Выбором.
*/
#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <time.h>
// Прототипы функций
void rand_array(int[], int);
void person_array(int[], int);
void sort(int[], int);
// Main
int main(void) {
	int n, v, result = 0;
	int array[15];
	printf("***The program for sorting an array of choice algorithm.***\n");
	printf("Enter the number of elements in the array (Max 15) > ");
	scanf_s("%d", &n);
	// Проверка на корректность данных
	if (n > 15 || n <= 0)
	{
		printf("Error, try again.");
		_getch();
		return 1;
	}
	// Способ заполнения массив
	printf("Functions:\n> 0.Random Array.\n> 1.Keyboard input.\n> ");
	scanf_s("%d", &v);
	if (v == 0)
		rand_array(array, n);
	else if (v == 1)
		person_array(array, n);
	// Проверка на корректность
	else
	{
		printf("Error!(Select 0 or 1)\n");
		_getch();
		return 1;
	}
	sort(array, n);
	// Вывод отсортированного массива
	printf("Your Sorted array > ");
	for (int i = 0; i < n; i++) {
		printf("%d ", array[i]);
	}
	_getch();
	return 0;
}
/**
* Заполнение массива автоматически
*
* @param array[] - массив чисел
* @param n - количество эллемантов массива
* @return - Nothing
* @
*/
void rand_array(int array[], int n) {
	srand(time(NULL));
	printf("Your Random Array > ");
	for (int i = 0; i < n; i++) {
		array[i] = rand() % 201 - 100;
		printf("%d ", array[i]);
	}
	printf("\n");
}
/**
* Заполнение массива пользователем
*
* @param array[] - массив чисел
* @param n - количество эллемантов массива
* @return - Nothing
* @
*/
void person_array(int array[], int n)
{
	for (int i = 0; i < n; i++)
	{
		printf("Enter the %d-st element of the array > ", i + 1);
		scanf_s("%d", &array[i]);
	}
	printf("Your Person Array > ");
	for (int i = 0; i < n; i++) {
		printf("%d ", array[i]);
	}
	printf("\n");
}
/**
* Сортировка Вставками
*
* @param array[] - массив чисел
* @param n - количество эллемантов массива
* @param min_i - начальное значение минимального индекса
* @return - Nothing
* @
*/
void sort(int array[], int n) {
	for (int i = 0; i < n - 1; i++)
	{
		/* устанавливаем начальное значение минимального индекса */
		int min_i = i;
		/* находим индекс минимального элемента */
		for (int j = i + 1; j < n; j++)
		{
			if (array[j] < array[min_i])
			{
				min_i = j;
			}
		}
		/* меняем значения местами */
		int temp = array[i];
		array[i] = array[min_i];
		array[min_i] = temp;
	}
}