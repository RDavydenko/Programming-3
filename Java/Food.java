import java.util.Scanner;

// ����� (�������������� �� ���������)
class Food {
    private String _name; // ��������
    private double _price; // ����
    private int _difficult; // ���������

    /* ���������� */ Product[] _products; // ��������, �� ������� ������� �����

    public String get_name() {
        return this._name;
    }

    public double get_price() {
        return this._price;
    }

    public int get_difficult() {
        return this._difficult;
    }

    public Product[] get_products() {
        return this._products;
    }

    // ����������� ������
    public Food(String name, double price, int difficult) {
        _name = name;
        _price = price;
        _difficult = difficult;
    }

    // ����������� ������
    public Food(String name, Product[] products) {
        this._name = name;
        this._price = 0;
        this._difficult = 0;
        this._products = products;

        for (int i = 0; i < products.length; i++) {
            _price += products[i].get_price();
        }
        this._price *= 1.2; // ������� 20%
        if (products.length <= 2) {
            this._difficult = 1;
        } else if (products.length <= 4) {
            this._difficult = 2;
        } else if (products.length <= 6) {
            this._difficult = 3;
        } else if (products.length <= 10) {
            this._difficult = 4;
        } else {
            this._difficult = 5;
        }
    }

    // ������� ���������� �� �����
    public void Display() {
        System.out.printf("���������� � �����\n");
        System.out.printf("��������: %s\n", this._name);
        System.out.printf("����:  %g\n", this._price);
        System.out.printf("���������: %d\n", this._difficult);
    }

    // ������� ���������� � ���������, ������� ���������� �����
    public void AboutProducts() {
        if (_products.length == 0) {
            System.out.println("���������� � ��������� ���");
        } else {
            for (int i = 0; i < _products.length; i++) {
                System.out.printf("��������: %s\n", _products[i].get_name());
                System.out.printf("���: %g\n", _products[i].get_weight());
                System.out.printf("�����: %g\n", _products[i].get_volume());
                System.out.printf("����: %g\n", _products[i].get_price());
                System.out.println();
            }
        }
    }

    // ��������� � ����� ����� ������ �����
    public void Add(Food other) {
        if (other._name != this._name) {
            this._name += (" + " + other._name);
        }
        this._price += other._price;
        this._difficult = (int) Math.ceil((this._difficult + other._difficult) / 2);
    }

    // ������ � ���������� ���������� � �����
    public static Food ReadFromInput() {
        String name;
        Scanner in = new Scanner(System.in, "Cp866");
        do {
            System.out.print("������� ��������: ");
            name = in.nextLine();
        } while (name == null || name.length() == 0);

        double price = 0;
        do {
            System.out.print("������� ����: ");
            if (in.hasNextDouble()) {
                price = in.nextDouble();
            }
        } while (price == 0);

        int difficult = 0;
        do {
            System.out.print("������� ���������: ");
            if (in.hasNextInt()) {
                difficult = in.nextInt();
            }
        } while (difficult == 0);

        return new Food(name, price, difficult);
    }

    // ��������� ������
    public void ApplyDiscount(int percent) {
        if (percent < 0) {
            percent = 0;
        }
        if (percent > 100) {
            percent = 100;
        }
        this._price *= (100 - percent) / 100.0;
    }

    // ����������� ��� �� ���������
    public static Food CookFood(Product products[]) {
        String compositeName = "";
        double price = 0;
        for (int i = 0; i < products.length; i++) {
            compositeName += products[i].get_name();
            if (i != products.length - 1) {
                compositeName += " + ";
            }
            price += products[i].get_price();
        }
        price *= 1.2; // ������� 20%
        int difficult = 0;
        if (products.length <= 2) {
            difficult = 1;
        } else if (products.length <= 4) {
            difficult = 2;
        } else if (products.length <= 6) {
            difficult = 3;
        } else if (products.length <= 10) {
            difficult = 4;
        } else {
            difficult = 5;
        }

        Food result = new Food(compositeName, price, difficult);
        result._products = products;
        return result;
    }
}
