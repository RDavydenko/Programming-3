import java.lang.reflect.Array;

// Шаблон класса - динамический массив
@SuppressWarnings("unchecked")
class DynamicArray<T> {
    private T[] _array;
    private int _count = 0;
    private int _capacity = 0;
    private Class<T> _class;

    // Конструктор без параметров
    DynamicArray(Class<T> class1) {
        _class = class1;
        _array = (T[]) Array.newInstance(class1, 2);
        _capacity = 2;
    }

    // capacity - начальная ёмкость
    DynamicArray(Class<T> clazz, int capacity) {
        _class = clazz;
        _array = (T[]) Array.newInstance(clazz, capacity);
        _capacity = capacity;
    }

    // Добавить новый элемент
    public void add(T element) {
        // Если достигли предела, то увеличиваем массив в 2 раза
        if (_count + 1 >= _capacity) {
            _capacity *= 2;
            _array = restructArray(_capacity);
        }
        _array[_count] = element;
        _count++;
    }

    // Получить элемент по индексу
    public T getByIndex(int index) {
        return _array[index];
    }

    // Количество элементов массива
    public int getCount() {
        return _count;
    }

    private T[] restructArray(int count)
	{
        T t;
		T[] newArray = (T[]) Array.newInstance(_class, count);
		for (int i = 0; i < _count; i++)
		{
			newArray[i] = _array[i];
		}
		return newArray;
	}
};
