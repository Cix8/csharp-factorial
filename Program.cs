Console.WriteLine("Inserisci un numero intero");
int myNumb = Convert.ToInt32(Console.ReadLine());
int result = myNumb;

void Factorial(int number)
{
    if (number > 1)
    {
        result = result * (number - 1);
        number = number - 1;
        Factorial(number);
    }
}


Factorial(myNumb);

Console.WriteLine($"Il fattoriale di {myNumb} è uguale a : {result}");