internal class Program
{
    private static void Main(string[] args)
    {
        // double, float, decimal
        double d = 10.0 / 3;
        Console.WriteLine(d);
        float f = 10f / 3;
        Console.WriteLine(f);
        decimal m = 10m / 3;
        Console.WriteLine(m);

        double incorrect = 0.1 + 0.2;
        Console.WriteLine(incorrect);
        decimal correct = 0.1m + 0.2m;
        Console.WriteLine(correct);

        // явное и неявное преобразование
        int i = 123456789;
        long l = i;
        Console.WriteLine(l);
        double dd = l;
        Console.WriteLine(dd);

        double ddd = 123456789.123456789;
        int ii = (int)ddd;
        Console.WriteLine("При преобразовании double в int теряется дробная часть: " + ii);

        long ll = 123;
        int iii = (int)ll;
        Console.WriteLine("При преобразовании long в int теряется часть числа: " + iii);

        // bool
        int DimaAge = 23;
        int correctAge = 18;
        bool isAdult = DimaAge <= correctAge;
        if (isAdult)
        {
            Console.WriteLine("Дима совершеннолетний");
        }
        else
        {
            Console.WriteLine("Дима несовершеннолетний");
        }

        // сравнение строк
        string s1 = "Hello";
        string s2 = "hello";
        bool areEqual = s1 == s2;
        bool areEqualIgnoreCase = s1.Equals(s2, StringComparison.OrdinalIgnoreCase);
        Console.WriteLine(areEqualIgnoreCase);

        // if else
        if (DimaAge >= 18 && DimaAge <= 100)
        {
            Console.WriteLine("Дима совершеннолетний");
        }
        else
        {
            Console.WriteLine("Дима несовершеннолетний");
        }

        // switch
        int age = 23;
        switch (age)
        {
            case <18:
                Console.WriteLine("Дима совершеннолетний");
                break;
            case 15:
                Console.WriteLine("Дима несовершеннолетний");
                break;
            default:
                Console.WriteLine("Дима неизвестный возраст");
                break;
        }

        if (age == 18)
        {
            Console.WriteLine("Дима совершеннолетний");
        }
        else if (age == 15)
        {
            Console.WriteLine("Дима несовершеннолетний");
        }
        else
        {
            Console.WriteLine("Дима неизвестный возраст");
        }
    }
}