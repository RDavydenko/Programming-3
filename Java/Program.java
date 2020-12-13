import java.time.LocalDate;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class Program {
    public static void main(String[] args) {
        // ����� �������������
        Product p100 = new Product();
        Product p101 = new Product("����");
        Product p102 = new Product("����", 100, 100, 20);

        Item abstractItem = p100; // ����������� �����
        abstractItem.get_name(); // �������� ������ �����, ������������ � ����������� ������ - get_name()
        Displayable displayableItem = p101; // ���������
        displayableItem.Display(); // �������� �����, ������������ � ���������� - Display()

        String name = "�������";
        Product baseProd = new Product(name);
        var thing = baseProd.new Thing();
        thing.Str = name;
        baseProd.clonedThing = thing;
        var easyClon = baseProd.Clone(); // ������ ������������
        var deepClon = baseProd.DeepClone(); // �������� ������������
        baseProd.clonedThing.Str = "Edited"; // easyClon.clonedThing.Str ���� ���������
        System.out.printf("Parent: %s | EasyClon: %s\n", baseProd.clonedThing.Str, easyClon.clonedThing.Str); // easyClon.clonedThing.Str ����������
        System.out.printf("Parent: %s | DeepClon: %s\n", baseProd.clonedThing.Str ,deepClon.clonedThing.Str); // deepClon.clonedThing.Str �� ���������

        Food f100 = new Food();
        Food f101 = new Food("���������");
        Food f102 = new Food("���������", 100, 2);
        // ������������� ������� ������������� �� ��������� (��� ����������)
        Product pArr100[] = new Product[10];
        for (int i = 0; i < 10; i++)
        {
            pArr100[i] = new Product();
        }

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

        // ��������� ������
        int _n = 2, _m = 3;
        Product[][] productsTwoMerniy = new Product[][]
        {
            { new Product("����", 250, 1, 30), new Product("�����", 250, 1, 30), new Product("���", 250, 1, 30) },
            { new Product("����", 250, 1, 30), new Product("������", 250, 1, 30), new Product("����", 250, 1, 30) }
        };
        for (int i = 0; i < _n; i++)
        {
            for (int j = 0; j < _m; j++)
            {
                productsTwoMerniy[i][j].Display();
            }
            System.out.println();
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
        Product prod = Product.Default;

        try {
            // ����������� �����. ��������� ��� ��������� �����-���� ��������
            // ��� �������� ���������� ������. � ������ ������ ����������� �����
            // ������� ��������� ������ ����� ����� ������ � ����������
            prod = Product.ReadFromInput();
        } catch (Exception e) {
            System.out.println("�������� ������: " + e.getMessage());   
        }        

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
            try {
                Product pr = Product.ReadFromInput();
                productsArray[i] = pr;
                System.out.println();                
            } catch (Exception e) {
                productsArray[i] = Product.Default;
            }
        }

        // ������� ����� �� ��������� ���������
        Food cookedFood = Food.CookFood(productsArray);
        System.out.println("�������������� �����: ");
        cookedFood.Display();
        System.out.println();

        in.close();
    }
}