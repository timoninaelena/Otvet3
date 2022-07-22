
int number = Convert.ToInt32(Console.ReadLine()) ;
Console.WriteLine(number);
int firstDigit = number / 10000;
int firstDigiOstatok = number % 10000;

int secondDigit = firstDigiOstatok /1000;
int secondDigitOstatok = firstDigiOstatok % 1000;

int thirdDigit = secondDigit/100;
int thirdDigitOstatok = secondDigit % 100;

int fourthDigit = thirdDigitOstatok / 10;
int fourthDigitOstatok = thirdDigitOstatok % 10;

int fifthDigit = fourthDigitOstatok / 1;
int fifthDigitOstatok = fourthDigitOstatok % 1;

{
if (firstDigiOstatok ==fifthDigitOstatok);
{
    if (secondDigitOstatok==fourthDigitOstatok);
    {
      Console.WriteLine($"Число: {number} - палиндром");
    }
}
if (firstDigiOstatok!=fifthDigitOstatok)
{
    Console.WriteLine($"Число: {number} - не палиндром");
}
else if (secondDigitOstatok!=fourthDigitOstatok)
{
    Console.WriteLine($"Число: {number} - не палиндром");
}
}