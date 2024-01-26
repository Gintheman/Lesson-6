// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

char [] symbols = new char[7];
string str = " ";
string symb = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

void CreateCharArray()
{
    Random rnd = new Random();
    for (int i = 0; i < symbols.GetLength(0); i++)
    {
    
        symbols[i] = symb[rnd.Next(0, symb.Length)];
        Console.Write(symbols[i] + " ");      
        
    }
    System.Console.WriteLine();
         
}



void GetCap()
{
    for(int i = 0; i < symbols.GetLength(0); i++)
    {
        
        if (char.IsUpper(symbols[i]))
        {
            symbols[i] = char.ToLower(symbols[i]);
            str += symbols[i] + " "; 
        }
        else
        {

            str += symbols[i] + " ";

        }

        
    }
    System.Console.Write(str);
}
    
    



CreateCharArray();
GetCap();