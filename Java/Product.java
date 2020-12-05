import java.time.LocalDate;
import java.time.Period;
import java.util.Scanner;

// Продукт
public class Product {
    private String _name; // Название
    private double _weight; // Вес
    private double _volume; // Объем
    private double _price; // Цена
    private StorageLife _storageLife = null; // Срок хранения

    // Дефолтный экземпляр класса Продукт
    public static Product Default = new Product("Безымянный", 1000, 1000, 1000);

    public String get_name() {
        return this._name;
    }

    public double get_weight() {
        return this._weight;
    }

    public double get_volume() {
        return this._volume;
    }

    public double get_price() {
        return this._price;
    }
    
    // Получить срок хранения
    public StorageLife get_StorageLife() {
        return this._storageLife;
    }

    // Устанавливаем срок хранения на продукт
    public void set_StorageLife(StorageLife storageLife) {
        if (storageLife != null) { // Если срок хранения еще не установлен
            // Иначе нельзя менять
            this._storageLife = storageLife;
        }
    } 

    // Конструктор без параметров
    public Product() {
        Product _default = Product.Default;
        _name = _default.get_name();
        _weight = _default.get_weight();
        _volume = _default.get_volume();
        _price = _default.get_price();
    }

     // Конструктор с одним параметром
     public Product(String name) {
        Product _default = Product.Default;
        _name = name;
        _weight = _default.get_weight();
        _volume = _default.get_volume();
        _price = _default.get_price();
    }

    // Конструктор с параметрами
    public Product(String name, double weight, double volume, double price) {
        _name = name;
        _weight = weight;
        _volume = volume;
        _price = price;
    }

    // Отображение информации о продукте
    public void Display() {
        System.out.printf("Информация о продукте:\n");
        System.out.printf("Название: %s\n", this._name);
        System.out.printf("Вес:  %g\n", this._weight);
        System.out.printf("Объем: %g\n", this._volume);
        System.out.printf("Цена: %g\n", this._price);
    }

    // Считываем информацию с клавиатуры и создаем новый экзмепляр Продукта
    public static Product ReadFromInput() throws Exception {
        String name;
        Scanner in = new Scanner(System.in, "Cp866");
        do {
            System.out.print("Введите название: ");
            name = in.nextLine();
        } while (name == null || name.length() == 0);

        double weight = 0;
        do {
            System.out.print("Введите вес: ");
            if (in.hasNextDouble()) {
                weight = in.nextDouble();
            }
        } while (weight == 0);
        
        if (weight < 0)
        {
            throw new Exception("Вес не может быть отрицательным!");
        }

        double volume = 0;
        do {
            System.out.print("Введите объем: ");
            if (in.hasNextDouble()) {
                volume = in.nextDouble();
            }
        } while (volume == 0);

        if (volume < 0) 
        {
            throw new Exception("Объем не может быть отрицательным!");
        }

        double price = 0;
        do {
            System.out.print("Введите цену: ");
            if (in.hasNextDouble()) {
                price = in.nextDouble();
            }
        } while (price == 0);

        if (price < 0) 
        {
            throw new Exception("Цена не может быть отрицательной!");
        }

        return new Product(name, weight, volume, price);
    }

    // Прибавить продукт
    public void Add(Product other) {
        if (other._name != this._name) {
            this._name += (" + " + other._name);
        }
        this._weight += other._weight;
        this._volume += other._volume;
        this._price += other._price;
    }

    // Получить цену за грамм
    public double GetPriceByGramm() {
        return this._price / this._weight;
    }

    // Получить эффективность продукта
    public double GetEfficiencyProduct() {
        double averageCalorie = 200;
        double priceByGramm = GetPriceByGramm();
        double efficiency = 1 / priceByGramm; // Эффективность
        return efficiency;
    }

    // Получить плотность продукта
    public double GetProductDensity() {
        double density = this._weight / this._volume; // Плотность
        return density;
    }

    // Срок годности
    public class StorageLife {
        private LocalDate startDate; // Начальная дата
        private LocalDate endDate; // Конечная дата
        
        // Конструктор - начальная дата и сколько дней может храниться
        public StorageLife(LocalDate startDate, int days) {
            this.startDate = startDate;
            this.endDate = startDate.plusDays(days);
        }

        // Конструктор - конечная дата
        public StorageLife(LocalDate endDate) {
            this.startDate = LocalDate.now();
            this.endDate = endDate;
        }

        // Сколько дней осталось до истечения срока годности
        public int howManyDaysRemaind() {
            var period = Period.between(LocalDate.now(), endDate);
            return period.getDays();
        }

        // Получить полный срок хранения
        public int getStorageLifeInDays() {
            Period period = Period.between(startDate, endDate);
            return period.getDays();
        }   
    }
}
