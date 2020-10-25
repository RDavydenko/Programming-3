import java.util.Scanner;

// ������� (�������)
public class Product {
    private String _name; // ��������
    private double _weight; // ���
    private double _volume; // �����
    private double _price; // ����

    // ����������� �������, ������������ ����������� �������
    public static Product Default() {
        return new Product("�������", 1000, 1000, 1000);
    }

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

    // ����������� ������ �� ��������� (��� ����������)
    public Product() {
        Product _default = Product.Default();
        _name = _default.get_name();
        _weight = _default.get_weight();
        _volume = _default.get_volume();
        _price = _default.get_price();
    }

    // ����������� ������ � �����������
    public Product(String name, double weight, double volume, double price) {
        _name = name;
        _weight = weight;
        _volume = volume;
        _price = price;
    }

    // ������� ���������� �� �����
    public void Display() {
        System.out.printf("���������� � ��������\n");
        System.out.printf("��������: %s\n", this._name);
        System.out.printf("���:  %g\n", this._weight);
        System.out.printf("�����: %g\n", this._volume);
        System.out.printf("����: %g\n", this._price);
    }

    // ������ � ���������� ���������� � ��������
    public static Product ReadFromInput()
        {
            String name;
            Scanner in = new Scanner(System.in, "Cp866");
            do
            {
               System.out.print("������� ��������: ");
               name = in.nextLine();
            } while (name == null || name.length() == 0);
    
            double weight = 0;
            do
            {
                System.out.print("������� ���: ");
                if (in.hasNextDouble())
                {
                    weight = in.nextDouble();
                }
            } while (weight == 0);
    
            double volume = 0;
            do
            {
                System.out.print("������� �����: ");
                if (in.hasNextDouble())
                {
                    volume = in.nextDouble();
                }
            } while (volume == 0);
    
            double price = 0;
            do
            {
                System.out.print("������� ����: ");
                if (in.hasNextDouble())
                {
                    price = in.nextDouble();
                }
            } while (price == 0);
    
            return new Product(name, weight, volume, price);
        }

    // ��������� � ����� �������� ������ �������
    public void Add(Product other) {
        if (other._name != this._name) {
            this._name += (" + " + other._name);
        }
        this._weight += other._weight;
        this._volume += other._volume;
        this._price += other._price;
    }

    // ���������� ���� �� ����� ��������
    public double GetPriceByGramm() {
        return this._price / this._weight;
    }

    // ������ ������������� ��������
    public double GetEfficiencyProduct() {
        double averageCalorie = 200;
        double priceByGramm = GetPriceByGramm();
        double efficiency = 1 / priceByGramm; // ������������� (����� �� ������)
        return efficiency;
    }

    // ������ ��������� ��������
    public double GetProductDensity() {
        double density = this._weight / this._volume; // ���������
        return density;
    }
}
