import java.time.LocalDate;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class Program {
    public static void main(String[] args) {
        // ������������ ������ � �������� ��������
        // ������� ������ ���������
        Product products1[] = { new Product("����", 250, 1, 30), new Product("�����", 50, 0.2, 20),
                new Product("���", 100, 0.5, 50), new Product("�������", 100, 0.75, 40),
                new Product("����", 1000, 1, 250) };
        ArrayList<Product> list = new ArrayList<>(Arrays.asList(products1)); // �������������� � ������ ���������
        // ������� �������, ������� ���������� �������
        Product deleted = list.stream().filter(x -> (x.get_name().toLowerCase() == "����".toLowerCase())).findFirst().orElse(null);
        if (deleted != null) { // �������, ���� ������
            list.remove(deleted);
            products1 = list.toArray(new Product[list.size()]);
        }

        // ������� �������������� �������� �� ������ ����� ��������������� ����� 
        Product bread = new Product("����", 250, 1 , 30); // ��������
        var storageLife = bread.new StorageLife(LocalDate.now(), 10); // C��� �������� � 10 ����
        bread.set_StorageLife(storageLife); // ������������� ���� �������� � 10 ����
        int allDays = bread.get_StorageLife().getStorageLifeInDays(); // ������� ����� �������� ������� (�����������)
        int daysRemainded = bread.get_StorageLife().howManyDaysRemaind(); // ������� ���� �������� �� ���������
        System.out.printf("����� �������� %d ���� �� %d ����\n\n", daysRemainded, allDays);

        // ������� ��������� �� ���������
        Food butter = new Food("���������", products1);
        butter.Display();
        System.out.println();
        butter.AboutProducts(); // ������� ���������� � ���������, ������� ����������� � butter

        System.out.println("��������� ���� � ��������: ");
        // ����������� �����. ��������� ��� ��������� �����-���� ��������
        // ��� �������� ���������� ������. � ������ ������ ����������� �����
        // ������� ��������� ������ ����� ����� ������ � ����������
        Product prod = Product.ReadFromInput();

        // �������������� ���������� ������� � ������� �������������
        Product p1 = new Product("��������", 10500, 3, 300);
        Product p2 = new Product("�������", 500, 0.4, 40);
        System.out.println();
        p1.Display(); // ���������� p1
        System.out.println();
        p1.Add(p2); // ���������� � p1 p2
        p1.Display(); // ���������� p1
        System.out.println();
        p2.Display(); // ���������� p2
        System.out.println();

        // ������������ ����� ������� �����������
        double p1Eff = p1.GetEfficiencyProduct();
        double prodEff = prod.GetEfficiencyProduct();
        String winnerName = p1Eff > prodEff ? p1.get_name() : prod.get_name();
        String loserName = prodEff < p1Eff ? prod.get_name() : p1.get_name();
        System.out.printf("������������� �������� %s ������, ��� ������������� �������� %s\n", winnerName, loserName);
        System.out.println();

        Product products[] = { new Product("������", 2000, 1, 80), p1 };

        // ����������� ����� ��������� ����������� ����� �� ������� ���������
        Food food = Food.CookFood(products);
        food.Display(); // ���������� ���������� � food
        System.out.println();
        System.out.println("��������� ���� � �����: ");
        Food food2 = Food.ReadFromInput(); // ��������� ���������� � �����
        System.out.println();
        food2.ApplyDiscount(30); // ��������� ������ 30%
        System.out.println("��������� ������� ����� ���������� ������ 30%: ");
        food2.Display();
        System.out.println();

        System.out.print("������ ����� �������� �����. ������� ���������� ���������, �� �������� ��� ����� ��������: ");
        Scanner in = new Scanner(System.in, "Cp866");
        int n = in.nextInt(); // ���������� ���������

        // ������ �������� ������ Product
        Product[] productsArray = new Product[n];
        for (int i = 0; i < n; i++) {
            System.out.printf("������� %d ������� �� %d\n", i + 1, n);
            Product pr = Product.ReadFromInput();
            productsArray[i] = pr;
            System.out.println();
        }

        // ������� ����� �� ��������� ���������
        Food cookedFood = Food.CookFood(productsArray);
        System.out.println("�������������� �����: ");
        cookedFood.Display();
        System.out.println();

        in.close();
    }
}