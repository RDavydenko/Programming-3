import java.util.Scanner;

public class Meat extends Product {

    public Meat() {
        super("����");
    }

    // ����������� � �����������
    public Meat(double weight, double volume, double price) {
        super("����", weight, volume, price);
    }

    // ��������� ���������� � ���������� � ������� ����� ��������� ��������
    public static Meat ReadFromInput() {
        Scanner in = new Scanner(System.in, "Cp866");
        double weight = 0;
        do {
            System.out.print("������� ���: ");
            if (in.hasNextDouble()) {
                weight = in.nextDouble();
            }
        } while (weight == 0);

        double volume = 0;
        do {
            System.out.print("������� �����: ");
            if (in.hasNextDouble()) {
                volume = in.nextDouble();
            }
        } while (volume == 0);

        double price = 0;
        do {
            System.out.print("������� ����: ");
            if (in.hasNextDouble()) {
                price = in.nextDouble();
            }
        } while (price == 0);

        return new Meat(weight, volume, price);
    }

    // ��������
    public void Fry() {
        // ����� ������ � _name, ������ ��� ��� protected � ������� ������
        // ���� �� ���� private, �� � ������-���������� �� ���� �� ����� _name
        System.out.println("����� " + _name + "... ���! *�����*");
    }

    // ��������
    public void Cook() {
        System.out.println("�����  " + _name + "... ����-����! *������*");
    }

    // �������� ������������� ��������
    @Override // ���������������� ����� �������� ������
    public double GetEfficiencyProduct() {
        var baseEfficiency = super.GetEfficiencyProduct();
        return baseEfficiency * 1.5;
    }
}
