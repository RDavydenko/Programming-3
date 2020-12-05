import java.time.LocalDate;
import java.time.Period;
import java.util.Scanner;

// �������
public class Product {
    private String _name; // ��������
    private double _weight; // ���
    private double _volume; // �����
    private double _price; // ����
    private StorageLife _storageLife = null; // ���� ��������

    // ��������� ��������� ������ �������
    public static Product Default = new Product("����������", 1000, 1000, 1000);

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
    
    // �������� ���� ��������
    public StorageLife get_StorageLife() {
        return this._storageLife;
    }

    // ������������� ���� �������� �� �������
    public void set_StorageLife(StorageLife storageLife) {
        if (storageLife != null) { // ���� ���� �������� ��� �� ����������
            // ����� ������ ������
            this._storageLife = storageLife;
        }
    } 

    // ����������� ��� ����������
    public Product() {
        Product _default = Product.Default;
        _name = _default.get_name();
        _weight = _default.get_weight();
        _volume = _default.get_volume();
        _price = _default.get_price();
    }

     // ����������� � ����� ����������
     public Product(String name) {
        Product _default = Product.Default;
        _name = name;
        _weight = _default.get_weight();
        _volume = _default.get_volume();
        _price = _default.get_price();
    }

    // ����������� � �����������
    public Product(String name, double weight, double volume, double price) {
        _name = name;
        _weight = weight;
        _volume = volume;
        _price = price;
    }

    // ����������� ���������� � ��������
    public void Display() {
        System.out.printf("���������� � ��������:\n");
        System.out.printf("��������: %s\n", this._name);
        System.out.printf("���:  %g\n", this._weight);
        System.out.printf("�����: %g\n", this._volume);
        System.out.printf("����: %g\n", this._price);
    }

    // ��������� ���������� � ���������� � ������� ����� ��������� ��������
    public static Product ReadFromInput() throws Exception {
        String name;
        Scanner in = new Scanner(System.in, "Cp866");
        do {
            System.out.print("������� ��������: ");
            name = in.nextLine();
        } while (name == null || name.length() == 0);

        double weight = 0;
        do {
            System.out.print("������� ���: ");
            if (in.hasNextDouble()) {
                weight = in.nextDouble();
            }
        } while (weight == 0);
        
        if (weight < 0)
        {
            throw new Exception("��� �� ����� ���� �������������!");
        }

        double volume = 0;
        do {
            System.out.print("������� �����: ");
            if (in.hasNextDouble()) {
                volume = in.nextDouble();
            }
        } while (volume == 0);

        if (volume < 0) 
        {
            throw new Exception("����� �� ����� ���� �������������!");
        }

        double price = 0;
        do {
            System.out.print("������� ����: ");
            if (in.hasNextDouble()) {
                price = in.nextDouble();
            }
        } while (price == 0);

        if (price < 0) 
        {
            throw new Exception("���� �� ����� ���� �������������!");
        }

        return new Product(name, weight, volume, price);
    }

    // ��������� �������
    public void Add(Product other) {
        if (other._name != this._name) {
            this._name += (" + " + other._name);
        }
        this._weight += other._weight;
        this._volume += other._volume;
        this._price += other._price;
    }

    // �������� ���� �� �����
    public double GetPriceByGramm() {
        return this._price / this._weight;
    }

    // �������� ������������� ��������
    public double GetEfficiencyProduct() {
        double averageCalorie = 200;
        double priceByGramm = GetPriceByGramm();
        double efficiency = 1 / priceByGramm; // �������������
        return efficiency;
    }

    // �������� ��������� ��������
    public double GetProductDensity() {
        double density = this._weight / this._volume; // ���������
        return density;
    }

    // ���� ��������
    public class StorageLife {
        private LocalDate startDate; // ��������� ����
        private LocalDate endDate; // �������� ����
        
        // ����������� - ��������� ���� � ������� ���� ����� ���������
        public StorageLife(LocalDate startDate, int days) {
            this.startDate = startDate;
            this.endDate = startDate.plusDays(days);
        }

        // ����������� - �������� ����
        public StorageLife(LocalDate endDate) {
            this.startDate = LocalDate.now();
            this.endDate = endDate;
        }

        // ������� ���� �������� �� ��������� ����� ��������
        public int howManyDaysRemaind() {
            var period = Period.between(LocalDate.now(), endDate);
            return period.getDays();
        }

        // �������� ������ ���� ��������
        public int getStorageLifeInDays() {
            Period period = Period.between(startDate, endDate);
            return period.getDays();
        }   
    }
}
