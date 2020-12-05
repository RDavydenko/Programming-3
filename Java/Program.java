import java.time.LocalDate;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class Program {
    public static void main(String[] args) {
        // Вызов конструкторов
        Product p100 = new Product();
        Product p101 = new Product("Хлеб");
        Product p102 = new Product("Хлеб", 100, 100, 20);
        Food f100 = new Food();
        Food f101 = new Food("Бутерброд");
        Food f102 = new Food("Бутерброд", 100, 2);
        // Инициализация массива конструктором по умолчанию (без параметров)
        Product pArr100[] = new Product[10];
        for (int i = 0; i < 10; i++)
        {
            pArr100[i] = new Product();
        }

        // Демонстрация работы с массивом объектов
        // Создаем массив продуктов
        Product products1[] = { new Product("Хлеб", 250, 1, 30), new Product("Масло", 50, 0.2, 20),
                new Product("Сыр", 100, 0.5, 50), new Product("Колбаса", 100, 0.75, 40),
                new Product("Вино", 1000, 1, 250) };
        ArrayList<Product> list = new ArrayList<>(Arrays.asList(products1)); // преобразование к списку продуктов
        // Находим продукт, который собираемся удалить
        Product deleted = list.stream().filter(x -> (x.get_name().toLowerCase() == "Вино".toLowerCase())).findFirst().orElse(null);
        if (deleted != null) { // удаляем, если найден
            list.remove(deleted);
            products1 = list.toArray(new Product[list.size()]);
        }

        // Возврат целочисленного значения из метода через вспомогательный класс 
        Product bread = new Product("Хлеб", 250, 1 , 30); // Хлебушек
        var storageLife = bread.new StorageLife(LocalDate.now(), 10); // Cрок хранения в 10 дней
        bread.set_StorageLife(storageLife); // Устанавливаем срок хранения в 10 дней
        int allDays = bread.get_StorageLife().getStorageLifeInDays(); // Сколько всего хранится продукт (максимально)
        int daysRemainded = bread.get_StorageLife().howManyDaysRemaind(); // Сколько дней осталось до просрочки
        System.out.printf("Хлебу осталось %d дней из %d дней\n\n", daysRemainded, allDays);

        // Создаем бутерброд из продуктов
        Food butter = new Food("Бутерброд", products1);
        butter.Display();
        System.out.println();
        butter.AboutProducts(); // Выводим информацию о продуктах, которые содерждатся в butter

        System.out.println("Заполните поля о продукте: ");
        Product prod = Product.Default;

        try {
            // Статический метод. Позволяет нам выполнять какие-либо действия
            // без создания экземпляра класса. В данном случае статический метод
            // создает экземпляр класса путем ввода данных с клавиатуры
            prod = Product.ReadFromInput();
        } catch (Exception e) {
            System.out.println("Возникла ошибка: " + e.getMessage());   
        }        

        // Инициализируем экземпляры классов с помощью конструкторов
        Product p1 = new Product("Картошка", 10500, 3, 300);
        Product p2 = new Product("Капуста", 500, 0.4, 40);
        System.out.println();
        p1.Display(); // Отображаем p1
        System.out.println();
        p1.Add(p2); // Прибавляем к p1 p2
        p1.Display(); // Отображаем p1
        System.out.println();
        p2.Display(); // Отображаем p2
        System.out.println();

        // Рассчитываем какой продукт эффективнее
        double p1Eff = p1.GetEfficiencyProduct();
        double prodEff = prod.GetEfficiencyProduct();
        String winnerName = p1Eff > prodEff ? p1.get_name() : prod.get_name();
        String loserName = prodEff < p1Eff ? prod.get_name() : p1.get_name();
        System.out.printf("Эффективность продукта %s больше, чем эффективность продукта %s\n", winnerName, loserName);
        System.out.println();

        Product products[] = { new Product("Огурцы", 2000, 1, 80), p1 };

        // Статический метод позволяет приготовить блюдо из массива продуктов
        Food food = Food.CookFood(products);
        food.Display(); // Отображаем информацию о food
        System.out.println();
        System.out.println("Заполните поля о блюде: ");
        Food food2 = Food.ReadFromInput(); // Заполняем информацию о блюде
        System.out.println();
        food2.ApplyDiscount(30); // Применяем скидку 30%
        System.out.println("Введенный продукт после применения скидки 30%: ");
        food2.Display();
        System.out.println();

        System.out.print("Сейчас будем готовить блюдо. Введите количество продуктов, из скольких оно будет состоять: ");
        Scanner in = new Scanner(System.in, "Cp866");
        int n = in.nextInt(); // Количество продуктов

        // Массив объектов класса Product
        Product[] productsArray = new Product[n];
        for (int i = 0; i < n; i++) {
            System.out.printf("Введите %d продукт из %d\n", i + 1, n);
            try {
                Product pr = Product.ReadFromInput();
                productsArray[i] = pr;
                System.out.println();                
            } catch (Exception e) {
                productsArray[i] = Product.Default;
            }
        }

        // Готовим блюдо из введенных продуктов
        Food cookedFood = Food.CookFood(productsArray);
        System.out.println("Приготовленное блюдо: ");
        cookedFood.Display();
        System.out.println();

        in.close();
    }
}