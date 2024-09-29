int result = 1;
for (int i = 1; i < 5; i++)
    result = result * 3;
Console.WriteLine(result);
//**********************************
Operators instance = new();
Console.WriteLine(instance.Expo(3, 4));

//**********************************Extension Method
string user = "Ayse Nur ORUCCU";
bool userResult = user.CheckSpaces();
Console.WriteLine(userResult);

if (userResult)
    Console.WriteLine(user.RemoveWhiteScapes());
Console.WriteLine(user.MakeUpperCase());
Console.WriteLine(user.MakeLowerCase());

int[] arr = { 9, 10, 4, 7, 29, 0 };
arr.SortArry();
arr.WriteScreen();

int number = 5;
Console.WriteLine(number.IsDoubleNumber());

Console.WriteLine(user.GetFirstCharacter());
//***********************************************
int FactorialNumber = 6; //4*3*2
Console.WriteLine(FactorialNumber.Factorial());
//***********************************************
public class Operators
{
    public int Expo(int number, int exponents)
    {
        if (exponents < 2)
            return number;
        return Expo(number, exponents - 1) * number;
    }
}


//***********************************************
public static class Extension
{
    public static int Factorial(this int n)
    {
        if (n == 0) 
            return 1;
        else
        {
            n--;
            return (n+1) * n.Factorial();
        }
    }
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }
    public static string RemoveWhiteScapes(this string param)
    {
        string[] dizi = param.Split(" ");
        return string.Join("", dizi);
    }
    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }
    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }
    public static int[] SortArry(this int[] param)
    {
        Array.Sort(param);
        return param;
    }
    public static void WriteScreen(this int[] param)
    {
        foreach (int item in param)
            Console.Write(item);

    }
    public static bool IsDoubleNumber(this int param)
    {
        return param % 2 == 0;
    }
    public static string GetFirstCharacter(this string param)
    {
        return param.Substring(0, 1);
    }
}