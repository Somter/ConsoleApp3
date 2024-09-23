class Hello
{
    static void Main()
    {
        // Задание 1:
        //Console.Write("Введите число: ");
        //int number;
        //number = int.Parse(Console.ReadLine());

        //int invertedNumber = 0;
        //int originalNumber = number;

        //while (number > 0)
        //{
        //    int lastNumber = number % 10;
        //    invertedNumber = invertedNumber * 10 + lastNumber; 
        //    number /= 10;                           
        //}

        //if (originalNumber == invertedNumber) {
        //    Console.Write("Ваше число является палиндромом");
        //}
        //else
        //{
        //    Console.Write("Ваше число не является палиндромом");
        //}

        //Задание 2:
        //Math.Pow - функция для возведения в степень

        //Console.Write("Введите число: ");
        //int number = int.Parse(Console.ReadLine());

        //Console.Write("Введите количество разрядов для сдвига: ");
        //int shift = int.Parse(Console.ReadLine());

        //Console.Write("Введите направление сдвига (0 - влево, 1 - вправо): ");
        //int direction = int.Parse(Console.ReadLine());

        //int originalNumber = number;
        //int DigitsNumb = 0;
        //while (originalNumber > 0)
        //{
        //    originalNumber /= 10;
        //    DigitsNumb++;
        //}

        //shift = shift % DigitsNumb;


        //int left;
        //int right;
        //int power;

        //if (direction == 0)
        //{
        //    power = (int)Math.Pow(10, DigitsNumb - shift);
        //    left = number / power;
        //    right = number % power;

        //    number = right * (int)Math.Pow(10, shift) + left;
        //}
        //else if (direction == 1)
        //{
        //    power = (int)Math.Pow(10, shift);
        //    right = number % power;
        //    left = number / power;

        //    number = right * (int)Math.Pow(10, DigitsNumb - shift) + left;
        //}
        //else
        //{
        //    Console.WriteLine("Вы ввели неверное число");
        //    return;
        //}

        //Console.WriteLine("Результат: " + number);

        //Задание 3

        //int length = 0;
        //int startMax = 0;
        //int currentLength = 1;
        //int currentStartIndex = 1;

        //Console.WriteLine("Введите 15 целых чисел:");

        //int startNum = int.Parse(Console.ReadLine());

        //for (int i = 2; i <= 15; i++)
        //{
        //    int currentNumber = int.Parse(Console.ReadLine()); 

        //    if (currentNumber >= startNum)
        //    {
        //        currentLength++;
        //    }
        //    else
        //    {
        //        if (currentLength > length)
        //        {
        //            length = currentLength;
        //            startMax = currentStartIndex;
        //        }

        //        currentLength = 1;
        //        currentStartIndex = i;
        //    }

        //    startNum = currentNumber;
        //}

        //if (currentLength > length)
        //{
        //    length = currentLength;
        //    startMax = currentStartIndex;
        //}

        //Console.WriteLine("Максимальная длина цепочки: " + length); 
        //Console.WriteLine("Порядковый номер начала цепочки: " + startMax);

    }
}