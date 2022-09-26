/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine ("ВВедите первое число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("ВВедите второе число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

if (userNumber > userNumber1)
{
    Console.WriteLine("max" + userNumber);
}
else if ( userNumber1 > userNumber )
{
    Console.WriteLine("max" + userNumber1 );
}
else 
{
    Console.WriteLine( userNumber );
}
