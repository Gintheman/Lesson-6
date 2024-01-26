// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.


char [] symbols1 = new char[5];
char [] symbols2 = new char[symbols1.Length];
string symb = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

void CreateCharString()
{
    Random rnd = new Random();
    for (int i = 0; i < symbols1.Length; i++)
    {
    
        symbols1[i] = symb[rnd.Next(0, symb.Length)];
        Console.Write(symbols1[i] + " ");      
        
    }
    System.Console.WriteLine();
         
}

void CreateCharString2()
{
    for (int i = 0; i < symbols2.Length; i++)
    {
        symbols2[i] = symbols1[symbols1.Length - 1 - i];
        Console.Write(symbols2[i] + " ");
    }
    Console.WriteLine();
}

void IsPalindrom ()
{
    int i = 0;
    while(symbols1[i] == symbols2[i])
    {
        i++;
    }
    if(i == symbols1.Length)
    {
        Console.WriteLine($"The string is palindrome");
    }
    else
    {
        Console.WriteLine($"The string is NOT palindrome");
    }
    
}


CreateCharString();
CreateCharString2();
IsPalindrom();

