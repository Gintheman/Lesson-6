// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.


char[,] symbols = new char[2,3];
string str = " ";
string symb = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

void CreateCharArray()
{
    Random rnd = new Random();
    for (int i = 0; i < symbols.GetLength(0); i++)
    {
        for( int j = 0; j < symbols.GetLength(1); j++)
        {
            symbols[i, j] = symb[rnd.Next(0, symb.Length)];  
            
        }
    }
         
}

void PrintCharArray()
{
    
    for (int i = 0; i < symbols.GetLength(0); i++)
    {
        for( int j = 0; j < symbols.GetLength(1); j++)
        {
            System.Console.Write(symbols[i, j] + " ");
             
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void GetString()
{
    for(int i = 0; i < symbols.GetLength(0); i++)
    {
        for(int j = 0; j < symbols.GetLength(1); j++)
        {
            str += symbols[i, j];
        }
    }
    System.Console.Write(str);
    

}

CreateCharArray();
PrintCharArray();
GetString();
