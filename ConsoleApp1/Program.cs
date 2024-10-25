using System;
namespace ConsoleApp1
{
    class program
    {
        static int kataryaltTiv()
        {
            int number = 0;
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                {
                    number += i;
                }


            }
            if (input == number)
            {
                Console.WriteLine($"ya kataryal  {input}");
            }
            else
            {
                Console.WriteLine($"ya kataryal chem {input}");
            }

            return input;

        }




        static void Main()
        {
            #region 2 hamakarg while 
            //Console.Write("Введите десятичное число: ");
            //int decimalNumber = int.Parse(Console.ReadLine());

            //string binaryNumber = "";

            //while (decimalNumber > 0)
            //{
            //    int remainder = decimalNumber % 2;
            //    binaryNumber = remainder + binaryNumber;
            //    decimalNumber /= 2; // Делим число на 2
            //}

            //Console.WriteLine("Двоичное представление: " + binaryNumber);
            #endregion
            #region Discriminant
            //Console.WriteLine("Enter A: ");
            //double A = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter B: ");
            //double B = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter C: ");
            //double C = double.Parse(Console.ReadLine());
            //Console.WriteLine($"{A}x2 + {B}x + {C} = 0 ");
            //double Discriminant = B * B - 4 * A * C;
            //Console.WriteLine("Discriminant (D) = b2 - 4ac: ");
            //Console.WriteLine($"Discriminant = { Discriminant}");
            //if (Discriminant < 0)
            //{
            //    Console.WriteLine("Discriminant < 0: Chuni Lucum");
            //}
            //else if (Discriminant == 0)
            //{
            //    Console.WriteLine("Discriminant = 0: Uni Mek Lucum");
            //}
            //else
            //{
            //    Console.WriteLine("Discriminant > 0: Uni Erku Lucum");
            //}
            #endregion
            #region Tas 1-7 tiv asi shabatva vor orna 
            //Console.WriteLine("Enter Number: ");
            //int number1 = int.Parse(Console.ReadLine());
            //switch (number1)
            //{
            //    case 1:
            //        Console.WriteLine("Today is Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Today is Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Today is Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Today is Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Today is Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Today is Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Today is Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Does not correspond to days of week");
            //        break;
            //}
            #endregion
            #region tas 2 tiv inky 1 en ed tivy hertov bazmapatke
            //Console.WriteLine("Enter First Number: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Number: ");
            //int number2 = int.Parse(Console.ReadLine());
            //int maxNumber = number1;
            //int minNumber = number2;
            //if (minNumber > maxNumber)
            //{
            //    minNumber = number1;
            //    maxNumber = number2;
            //}
            //for (int i = 1; i <= maxNumber; i++)
            //{
            //    for (int j = 1; j <= maxNumber; j++)
            //    {
            //        Console.WriteLine($"{i}*{j} = {i * j}");
            //    }
            //}
            #endregion
            #region Calculator
            Console.WriteLine("Enter first number: ");
            decimal number1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            decimal number2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter operator: ");
            string operato = Console.ReadLine();

            switch (operato)
            {
                case "-":
                    Console.WriteLine($"{number1}+{number2} = {number1 - number2}");
                    break;
                case "+":
                    Console.WriteLine($"{number1}-{number2} = {number1 + number2}");
                    break;
                case "*":
                    Console.WriteLine($"{number1}*{number2} = {number1 * number2}");
                    break;
                case "/":
                    Console.WriteLine($"{number1}/{number2} = {number1 / number2}");
                    break;
                case "%":
                    Console.WriteLine($"{number1}%{number2} = {number1 / number2 * 100}");
                    break;

                default:
                    Console.WriteLine("wrong operator");
                    break;
            }
            #endregion
            #region tv
            //Tv tv1 = new Tv
            //{
            //    Name = "Samsung",
            //    Model = "A33"
            //};
            //tv1.ChangeChannel();
            //tv1.ChangeChannel();

            //var tv2 = new Tv();
            //tv2.Name = "Hisense";
            //tv2.Model = "12Pro";
            //tv2.ChangeChannel();
            #endregion
            #region tiv tam se amenamec bajanarar 
            //Console.WriteLine("Enter number:");
            //int number = int.Parse(Console.ReadLine());
            //int amenamecbajanarar = 0;
            //for (int i = 1; i <= number / 2; i++)
            //{
            //    if (number % i == 0)
            //    {
            //        amenamecbajanarar = i;
            //    }
            //}
            //Console.WriteLine(amenamecbajanarar);
            #endregion
            #region Kataryal tiv
            //int input = int.Parse(Console.ReadLine());
            //int number = 0;
            //for (int i = 1; i < input; i++)
            //{
            //    if (input % i == 0)
            //    {
            //        number += i;
            //    }
            //}
            //if (input == number)
            //{
            //    Console.WriteLine($"ya kataryal  {input}");
            //}
            //else
            //{
            //    Console.WriteLine($"ya kataryal chem {input}");
            //}
            #endregion
            #region 2 hamakarg 
            //int input = int.Parse(Console.ReadLine());

            //for (int i = 0; i < input; i = input / 2)
            //{
            //    Console.Write(input % 2);
            //    input = input / 2;
            //}
            #endregion
            #region 1 en tvac tivy verg bajnvi 3 i 
            //Console.WriteLine("Enter Your Number ");
            //int inputNumber = int.Parse(Console.ReadLine());

            //for (int i = 1; i < inputNumber; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region arrayi miji amena mec tivy ev amenapoqr tivy 

            //int[] array = { 10, 20, 30 };
            //int maxNumber = array[0];
            //int minNumber = array[0];
            //foreach (int numbers in array)
            //{
            //    if (numbers > maxNumber)
            //    {
            //        maxNumber = numbers;
            //    }
            //    if (numbers < minNumber)
            //    {
            //        minNumber = numbers;
            //    }
            //}
            //Console.WriteLine(maxNumber);
            //Console.WriteLine(minNumber);
            #endregion
            #region max even min odd 
            //int maxEven = 0;
            //int minOdd = 0;
            //int[] numbers = new int[10];
            //var random = new Random();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = random.Next(1, 5);
            //}
            //foreach (var item in numbers)
            //{
            //    if (item % 2 == 0)
            //    {
            //        maxEven = item;
            //    }
            //    if (item % 2 != 0 && item > 0)
            //    {
            //        minOdd = item;
            //        if (item < minOdd)
            //        {
            //            minOdd = item;
            //        }
            //    }
            //}
            //Console.WriteLine(maxEven);
            //Console.WriteLine(minOdd);
            #endregion
            #region Discriminant 
            //Console.WriteLine("Enter A");
            //double a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter B");
            //double b = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter C");
            //double c = double.Parse(Console.ReadLine());
            //double Discriminant = b * b - 4 * a * c;
            //if (Discriminant > 0)
            //{
            //    Console.WriteLine("ka erku lucum ");

            //}
            //else if (Discriminant < 0)
            //{
            //    Console.WriteLine("chuni lucum ");
            //}
            //else
            //{
            //    Console.WriteLine("Uni mek lucum ");
            //}
            #endregion
            #region maxnumber in array 
            //int[] arr = { 12, 32, 1, 34, 45, 6, 7, 8 };
            //int maxNumber = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > maxNumber)
            //    {
            //        maxNumber = arr[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);
            #endregion
            #region odds in array 
            //int[] array = { 11, 23, 4, 5, 7, 67, 8, 78, 2, 445, 56, 6, };
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] % 2 == 0)
            //    {
            //        continue;

            //    }
            //    Console.WriteLine(array[i]);
            //}
            #endregion
            #region max even in array 
            //int[] array = {  -100 , -12, -2, -34, -65, -6, -79, -89, -2, -56, -80,  };
            //int maxEven = array[0];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] % 2 == 0 && array[i] > maxEven)
            //    {
            //        maxEven = array[i];
            //    }
            //}
            //Console.WriteLine(maxEven);
            #endregion
            #region Dari voroshum 
            //Console.WriteLine("Enter Year");
            //int input = int.Parse(Console.ReadLine());
            //if (input % 100 == 0)
            //{
            //    Console.WriteLine($"duq gtnvumeq { input / 100} darum");
            //}
            //else
            //{
            //    Console.WriteLine($"duq gtnvumeq { input / 100 + 1} darum");

            //}
            #endregion
            #region in arr max num and min num
            //int[] arr = new int[20];
            //var random = new Random();          
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = random.Next(1, 50);
            //}
            //int max = arr[0]; int min = arr[0];
            //int minIndex = 0; int maxIndex = 0;
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //        maxIndex = i;
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //        minIndex = i;
            //    }             
            //}
            //arr[minIndex] = max;
            //arr[maxIndex] = min;
            //Console.WriteLine("Min Number = "+ min);
            //Console.WriteLine("Max Number = "+ max);
            #endregion
            #region Arrayi mej pijigen mec mecen pijig        
            //int[] array = new int[25];
            //int minIndex = 0; int maxIndex = 0;
            //int min = 0; int max = 0;
            //Random random = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(1, 125);
            //}

            //for (int i = 0; i < array.Length; i++)
            //{             
            //    for (int j =i + 1; j < array.Length; j++)
            //    {
            //        if (array[i] > array[j])
            //        {
            //            max = array[i];
            //            min = array[j];
            //            array[i] = min;
            //            array[j] = max;
            //        }

            //    }
            //}

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Xndirner 

            //xndir 1 
            //int[] array = { 12, 23, 43, 5, 6, 4 };
            //for (int i = array.Length - 1 ; i >= 0 ; i--)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //xndir 2
            //int[] array = { 12,11,13,23,45};
            //int oddCount = 0;
            //int index = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if(array[i] % 2 != 0)
            //    {
            //        oddCount++;
            //        index = i;
            //        if (oddCount == 2)
            //        {
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine("Index = " + index);
            //Console.WriteLine("Odd Number = " + array[index]);

            //xndir 3 
            //int[] array1 = { 12, 34, 45, 53, 23};
            //int[] array2 = { 1, 2, 34, 4, 5};
            //int[] margedArray = new int[array1.Length + array2.Length];

            //for (int i = 0; i < array1.Length; i++)
            //{
            //    margedArray[i] = array1[i] ;
            //    margedArray[array1.Length + i] = array2[i] ;
            //}

            //foreach (var item in margedArray)
            //{
            //    Console.WriteLine(item);
            //}

            //xndir 4 
            //Console.WriteLine("Enter First Number");
            //int input = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Number");
            //int input1 = int.Parse(Console.ReadLine());
            //int maxNumber = 0;

            //maxNumber = input > input1 ? maxNumber = input : maxNumber = input1;
            //Console.WriteLine("The biggest numbger is "+ maxNumber);

            ////xndir 5 

            //int[] array = {5,4,3,2,1};
            //bool isSort = true;
            //for (int i = 0; i < array.Length -1 ; i++)
            //{
            //        if (array[i] > array[i + 1])

            //            isSort = false;
            //}
            //Console.WriteLine(isSort);
            #endregion
            #region 12 i mijic vorna mec 1 te 2 

            //int number = 1234;
            //int result = 0; int max = 0;
            //while (number > 0)
            //{
            //    result = number % 10;
            //    if (result > max)
            //    {
            //        max = result;
            //    }
            //    number /= 10;
            //}
            //Console.WriteLine(max);

            #endregion
            #region 123 tiv tam tpe kent tvery orinak 1 3 
            //int number = 1234567;
            //int result = 0;
            //while (number > 0)
            //{
            //    result = number % 10;
            //    if (result % 2 != 0)
            //    {
            //        Console.WriteLine(result);
            //    }
            //    number /= 10;

            //}


            #endregion
            #region 12 1+2 edig minusov
            //int number = -12;
            //int result = 0;
            //while (number < 0)
            //{
            //    result += number % 10;

            //    number /= 10;
            //}
            //Console.WriteLine(result);
            #endregion
            #region asi 5 asi * ** *** **** *****
            //int inputNumber = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= inputNumber; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            //barev dzez

        }

    }

}
