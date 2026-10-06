namespace CSharpBasicsAssignment;
class Program
{
    static void Main(string[] args)
    {
        //RunTypesDemo();
        //Conversion();
        //RunValueVsReferenceDemo();


        // =============================================== Part C (Main method Part) ===============================================
        //Order o1 = new Order(1, "Yousef", 3, 100, true, 12, "Giza", 'H', 9291);
        //o1.CalculatePrice(3, 100, 12);
        //Order o2 = o1;
        // o2 variable have same value because it's refer to same address on heap after assignment by o2
        //Console.WriteLine($"O1 Pay Statue:{o1.IsPaid}");
        //Console.WriteLine($"O2 Pay Statue:{o2.IsPaid}");

        //object BoxedOrder = o1;
        //Console.WriteLine(object.ReferenceEquals(BoxedOrder, o2));
        //Order o3 = (Order) BoxedOrder;
        //o2.PrintSummary();
    }



    // =============================================== Part B ===============================================

    public static void RunTypesDemo()
    {
        int intVar = 42;
        long longVar = 9223372036854775807L;
        double doubleVar = 3.14159d;
        decimal decimalVar = 199.99m;
        bool boolVar = true;
        char charVar = 'Y';
        string stringVar = "Assignment 3";
        var inferredVar = 2026; // Inferred as int by the compiler

        Console.WriteLine($"Value: {intVar}, Type: {intVar.GetType()}");
        Console.WriteLine($"Value: {longVar}, Type: {longVar.GetType()}");
        Console.WriteLine($"Value: {doubleVar}, Type: {doubleVar.GetType()}");
        Console.WriteLine($"Value: {decimalVar}, Type: {decimalVar.GetType()}");
        Console.WriteLine($"Value: {boolVar}, Type: {boolVar.GetType()}");
        Console.WriteLine($"Value: {charVar}, Type: {charVar.GetType()}");
        Console.WriteLine($"Value: {stringVar}, Type: {stringVar.GetType()}");
        Console.WriteLine($"Value: {inferredVar}, Type: {inferredVar.GetType()}");
    }

    public static void Conversion()
    {
        long longvar = 999999999999;
        int intvar = 100;
        char charvar = '9';
        double doublevar = 123.5;

        // I don't need casting because the compiler cast this conversion Implicitly because the assigned data smaller than the variable that will put inside it.
        longvar = intvar;
        intvar = charvar;

        // Trancate (Ignore all numbers after .)
        Console.WriteLine($" {(int)doublevar}");

        // Rounding (Round the number based on rule ( number >= 0.5) ceiling, ( number < 0.5 Flooring) )
        Console.WriteLine($" {Convert.ToInt32(doublevar)}");

        // The difference is that when I divide int / int the result will be int, the compiler discard all number after point
        Console.WriteLine("Int: " + (5 / 2));
        Console.WriteLine("Float: " + (5.0 / 2.0));

        int Unboxingint = 100;
        Console.WriteLine($"Unboxing int: {Unboxingint}");

        object Boxingint = (int)Unboxingint;
        Console.WriteLine($"Boxing int: {Boxingint}");

        Console.WriteLine("Enter number");
        int goodStr = int.Parse(Console.ReadLine());


        Console.WriteLine("Enter number Again");
        string? strvar = (Console.ReadLine());
        int intvar4;

        if (int.TryParse(strvar, out intvar4))
        {
            Console.WriteLine("Success Input");
        }

        else
        {
            Console.WriteLine("Wrong Input");
        }

        // Convertion cannot be performmed because float have a larger range of decimal so this exhibition to bits lose (decimal focused on accuracy not range)
        float floatvar = 100.5f;
        decimal decimalvar = (decimal)floatvar;
    }
}


// =============================================== Part D ===============================================

class PartD
{
    private static string _appName = "C# Assignment App";

    // Can be Accessed inside the class ( private )
    
     void PrintAppInfo()
    {
        // Can't be accessed outside the function
        string EngineerName = "Yousef Ahmed";
        Console.WriteLine($"App: {_appName}");
    }

    void DisplayWelcomeMessage()
    {
        Console.WriteLine($"Welcome to: {_appName}");

        for (int i = 0; i < 3; i++)
        {
            // 'i' is the loop variable (block scope)
            // 'loopMessage' is a variable declared inside the loop body (block scope)
            string loopMessage = $"Iteration {i}";
            Console.WriteLine(loopMessage);
        }
    }

    void D_2()
    {
        int total = 100;
        Console.WriteLine($"Initial total: {total}");

        // 1. Using += (Addition assignment)
        total += 25; // total = total + 25;
        Console.WriteLine($"After += 25: {total}");

        // 2. Using -= (Subtraction assignment)
        total -= 10;
        Console.WriteLine($"After -= 10: {total}");

        // 3. Using *= (Multiplication assignment)
        total *= 2;
        Console.WriteLine($"After *= 2: {total}");

        // 4. Using /= (Division assignment)
        total /= 5;
        Console.WriteLine($"After /= 5: {total}");

        // 5. Using %= (Modulus assignment)
        total %= 7;
        Console.WriteLine($"After %= 7: {total}");
    }

    void D_3()
    {
        // (binary 1100 and 1010).
        int a = 12;
        int b = 10;

        // & is a anding operation between first and second number for all binary digits  1 & 1 = 1, else = 0
        Console.WriteLine(a & b);
        // & is a xoring operation between first and second number for all binary digits  1 ^ 0, 0 ^ 1 = 1, else = 0
        Console.WriteLine(a ^ b);

        // the difference between &, && is that & is a bits level opereator, && use for conditions to check two status is true
        // if condition + &&, if the first condition = false that is enough, will not check the second at all
    }
}

class F
{
    // number ^ 0 = number, Xoring between same numbers cancel both of them and = 0
     public int FindSingleNumber(int[] nums)
    {
        int Base = 0;
        foreach (int num in nums)
        {
            Base ^= num;
        }
        return Base;
    }
}



class test
{
    //float;kjasd;fkljasd;lkfjasdkl
    string test1 = "Test";
}