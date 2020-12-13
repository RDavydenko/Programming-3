import java.util.Scanner;

public class Meat extends Product {

    public Meat() {
        super("Мясо");
    }

    // Конструктор с параметрами
    public Meat(double weight, double volume, double price) {
        super("Мясо", weight, volume, price);
    }

    // Считываем информацию с клавиатуры и создаем новый экзмепляр Продукта
    public static Meat ReadFromInput() {
        Scanner in = new Scanner(System.in, "Cp866");
        double weight = 0;
        do {
            System.out.print("Введите вес: ");
            if (in.hasNextDouble()) {
                weight = in.nextDouble();
            }
        } while (weight == 0);

        double volume = 0;
        do {
            System.out.print("Введите объем: ");
            if (in.hasNextDouble()) {
                volume = in.nextDouble();
            }
        } while (volume == 0);

        double price = 0;
        do {
            System.out.print("Введите цену: ");
            if (in.hasNextDouble()) {
                price = in.nextDouble();
            }
        } while (price == 0);

        return new Meat(weight, volume, price);
    }

    // Пожарить
    public void Fry() {
        // Имеем доступ к _name, потому что оно protected в базовом классе
        // Если бы было private, то в классе-наследнике не была бы видна _name
        System.out.println("Жарим " + _name + "... Пшш! *Шипит*");
    }

    // Отварить
    public void Cook() {
        System.out.println("Варим  " + _name + "... Буль-буль! *Бурлит*");
    }

    // Получить эффективность продукта
    @Override // Переопределенный метод базового класса
    public double GetEfficiencyProduct() {
        var baseEfficiency = super.GetEfficiencyProduct();
        return baseEfficiency * 1.5;
    }
}
