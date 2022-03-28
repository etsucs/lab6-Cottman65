/**       
 *--------------------------------------------------------------------
 * 	   File name: {Methods}
 * 	Project name: {Homework 6/Lab 6}
 *--------------------------------------------------------------------
 * Author’s name and email:	 {Colee Cottrell/cottrellc@etsu.edu}}				
 *          Course-Section: {CSCI-1250-001}
 *           Creation Date:	 {3/23/2022}		
 * -------------------------------------------------------------------
 */

ShowCharacter("Quertyo", 5);
CalculateRetail(5, 100);
Console.WriteLine(IsPrime(3));
for (int i = 80; i <= 100; i++)
{
    Console.WriteLine($"{i} converted to Celsius is {Celsius(i)}");
}

static void ShowCharacter(string word, int position)
{
    if (position > word.Length)
    {
        System.Console.WriteLine("The position does not exist for that word!");
    }
    else if(position <= 0)
    {
        System.Console.WriteLine("That does not make sense!");
    }
    else
    {
        Console.WriteLine(word[position - 1]);
    }
}

static void CalculateRetail(double cost, double percent)
{
    percent = cost * (percent / 100);
    var final = cost + percent;
    System.Console.WriteLine($"The retail price is ${final} ");
}

static double Celsius(int fahrenheit)
{
    return ((5.0/9.0) * (fahrenheit - 32.0));
}

static bool IsPrime(int num)
{
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }
    return true;
}


