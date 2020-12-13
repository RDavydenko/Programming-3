using System;

namespace Lab
{
    // Динамический массив
    public class DynamicArray<T>
    {
        private T[] _array;
        private int _count = 0;
        private int _capacity = 0;

        // Конструктор без параметров
        public DynamicArray() {
            _array = new T[2];
            _capacity = 2;
        }

        // capacity - начальная ёмкость
        public DynamicArray(int capacity) {
            _array = new T[capacity];
            _capacity = capacity;
        }

        // Добавить новый элемент
        public void Add(T element) {
            // Если достигли предела, то увеличиваем массив в 2 раза
            if (_count + 1 >= _capacity) {
                _capacity *= 2;
                _array = RestructArray(_capacity);
            }
            _array[_count] = element;
            _count++;
        }

        // Получить элемент по индексу
        public T GetByIndex(int index) {
            return _array[index];
        }

        // Количество элементов массива
        public int GetCount() {
            return _count;
        }

        private T[] RestructArray(int count)
        {
            T[] newArray = new T[count];
            for (int i = 0; i < _count; i++)
            {
                newArray[i] = _array[i];
            }
            return newArray;
        }
    }
}