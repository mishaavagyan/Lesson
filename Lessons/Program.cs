using Lessons.Models;
using Tools.Services;
using System;
using System.Linq;

namespace Lessons
{
    class program
    {
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
            //Console.WriteLine("Enter first number: ");
            //decimal number1 = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number: ");
            //decimal number2 = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Enter operator: ");
            //string operato = Console.ReadLine();

            //switch (operato)
            //{
            //    case "+":
            //        Console.WriteLine($"{number1}+{number2} = {number1 - number2}");
            //        break;
            //    case "-":
            //        Console.WriteLine($"{number1}-{number2} = {number1 + number2}");
            //        break;
            //    case "*":
            //        Console.WriteLine($"{number1}*{number2} = {number1 * number2}");
            //        break;
            //    case "/":
            //        Console.WriteLine($"{number1}/{number2} = {number1 / number2}");
            //        break;
            //    case "%":
            //        Console.WriteLine($"{number1}%{number2} = {number1 / number2 * 100}");
            //        break;

            //    default:
            //        Console.WriteLine("wrong operator");
            //        break;
            //}
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
            #region or Qarakusi
            //Console.WriteLine("Enter Widht");
            //int widht  = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Height");
            //int height = int.Parse(Console.ReadLine());


            //for(int i = 0;  i < height; i++)
            //{
            //    for (int j = 0; j < widht; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    for (int k = 0; k < widht; k++)
            //    {
            //        if (height == k)
            //        {
            //            Console.Write("");
            //        }
            //    }
            //}




            #endregion
            #region Validaciaya

            //Console.WriteLine("Enter Name:");
            //string inputName = Console.ReadLine();
            //Console.WriteLine("Enter gmail: ");
            //string inputGmail = Console.ReadLine();
            //bool isNameSuccess;
            //bool isGmailSuccess;
            //string result = Validate(inputName, inputGmail, out isNameSuccess, out isGmailSuccess);

            //if (isNameSuccess && isGmailSuccess)
            //    Console.WriteLine("Congratulations, you have successfully registered");
            //else
            //    Console.WriteLine("Cheak Errors and Fix them ");

            //Console.WriteLine(result);

            //Console.WriteLine("Enter Name:");
            //string inputName = Console.ReadLine();
            //Console.WriteLine("Enter gmail: ");
            //string inputGmail = Console.ReadLine();

            //Valid(inputName,inputGmail);
            #endregion

            var user1 = new User
            {
                Name = "Gago",
                Email = "gago123@gmail.com",
                Password = "gago5505",
                Age = "18",
                PhoneNumber = "1234567890",
                BirthDate = DateTime.Now,


            };
            var user2 = new User
            {
                Name = "Peto",
                Email = "Peto123@gmail.com",
                Password = "Peto5505",
                Age = "12",
                PhoneNumber = "1234567890",
                BirthDate = DateTime.Now,


            };
            var user3 = new User
            {
                Name = "Moso",
                Email = "moso123@gmail.com",
                Password = "moso5505",
                Age = "13",
                PhoneNumber = "1234567890",
                BirthDate = DateTime.Now,


            };

            Console.WriteLine("Please Login: \n");
            Console.WriteLine("Enter Email");
            string userEmail = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string userPassword = Console.ReadLine();
            var result = UsersLogin(userEmail, userPassword, user1, user2, user3);
            if (result.Success)
            {
                Console.WriteLine($"{result.Massege}\n");
                Console.WriteLine("Name: " + result.User.Name);
                Console.WriteLine("Email: " + result.User.Email);
                Console.WriteLine("Age: " + result.User.Age);
                Console.WriteLine("Phone Number: " + result.User.PhoneNumber);
                Console.WriteLine("Birthdate: " + result.User.BirthDate);
            }


            #region 1
            //RegisterModel registerModel = new RegisterModel();
            //Console.WriteLine("Enter FullName");
            //registerModel.FullName = Console.ReadLine();
            //Console.WriteLine("Enter email");
            //registerModel.Email = Console.ReadLine();
            //Console.WriteLine("Enter age");
            //registerModel.Age = Console.ReadLine();
            //Console.WriteLine("Phone number");
            //registerModel.PhoneNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter password");
            //registerModel.Password = Console.ReadLine();
            //var registerResponse = Register(registerModel);

            //if (registerResponse.Success)
            //{
            //    Console.WriteLine("You have registered successfully. Please login\n");
            //    LoginModel loginModel = new LoginModel();
            //    Console.WriteLine("Enter Email");
            //    loginModel.Email = Console.ReadLine();
            //    Console.WriteLine("Enter Password");
            //    loginModel.Password = Console.ReadLine();
            //    var loginResponse = Login(loginModel, registerModel);
            //    Console.WriteLine($"{ loginResponse.Massege}\n");
            //    Console.WriteLine("User Profile Info: \n");
            //    Console.WriteLine("Name: " + registerModel.FullName);
            //    Console.WriteLine("Email: " + registerModel.Email);
            //    Console.WriteLine("Age: " + registerModel.Age);
            //    Console.WriteLine("Phone Number: " + registerModel.PhoneNumber);
            //}
            //else
            //{
            //    Console.WriteLine(registerResponse.Message);
            //}
            #endregion
        }
        #region Methods
        public static string ValidPassword(string password, out bool isPasswordValid)
        {
            isPasswordValid = true;
            string massege = null;
            if (password.Length <= 6)
            {
                massege += "parolt 6 en shat gre\n";
                isPasswordValid = false;
            }
            return massege;
        }
        public static string ValidAge(string age, out bool isAgeValid)
        {
            isAgeValid = true;
            string messege = null;
            string stringAge = age.ToString();
            if (!stringAge.All(char.IsDigit))
            {
                messege += "tarikid mej ka tiv\n";
                isAgeValid = false;
            }
            return messege;
        }
        public static string PhoneNumber(int phoneNumber, out bool isPhoneNumberValid)
        {
            isPhoneNumberValid = true;
            string messege = null;
            string stringPhoneNumber = phoneNumber.ToString();
            if (!stringPhoneNumber.All(char.IsDigit))
            {
                messege += "heraxosid hamari mej ka tiv\n";
                isPhoneNumberValid = false;
            }
            return messege;
        }
        public static string FullName(string fullName, out bool isFullNameValid)
        {
            string massege = null;
            isFullNameValid = true;
            if (fullName.Length <= 0)
            {
                isFullNameValid = false;
                massege += "anuny 0 en mec gre\n";
            }
            return massege;

        }
        public static string Validate(string name, string gmail, out bool isNameSuccess, out bool isGmailSuccess)
        {
            string masseges = null;

            isNameSuccess = false;
            if (name[0] >= 'a' && name[0] <= 'z')
            {
                masseges += "Write the first letter as a Capital letter\n";
            }
            else if (name.Length > 12)
            {
                masseges += "Names Max Size is 12: Write no more than 12\n";
            }
            else
            {
                Console.WriteLine($"{name} Your Name Fits\n");
                isNameSuccess = true;
            }
            bool isFoundGmailSymbol = false;
            for (int i = 0; i < gmail.Length; i++)
            {
                if (gmail[i] == '@')
                {
                    isFoundGmailSymbol = true;
                    break;
                }
            }
            bool isFoundNumbersInGmail = true;
            for (int i = 0; i < gmail.Length; i++)
            {
                if (gmail[i] >= '0' && gmail[i] <= '9')
                {
                    isFoundNumbersInGmail = false;
                    break;
                }
            }
            isGmailSuccess = false;
            if (!isFoundGmailSymbol && !isFoundNumbersInGmail)
            {
                masseges += "Missing @ symbol in your Gmail\nThere are numbers in your Gmail\n";

            }
            else if (!isFoundNumbersInGmail)
            {
                masseges += "There are numbers in your Gmail\n";
            }
            else if (!isFoundGmailSymbol)
            {
                masseges += "Missing @ symbol in your Gmail\n";
            }
            else
            {
                Console.WriteLine($"{gmail} Your gmail Fits\n");
                isGmailSuccess = true;
            }
            return masseges;

        }
        public static string NameCapitalLetter(string name, out bool isNameCapitalLetterValid)
        {
            string error = null;
            isNameCapitalLetterValid = false;
            if (!char.IsUpper(name[0]))
            {
                error += "Write the first letter as a Capital letter\n";
            }
            else
            {
                isNameCapitalLetterValid = true;
            }

            return error;
        }
        public static string NameMaxSize(string name, out bool isNameSizeValid)
        {
            string error = null;
            isNameSizeValid = true;
            if (name.Length > 12)
            {
                error += "Names Max Size is 12: Write no more than 12\n";
                isNameSizeValid = false;

            }
            return error;
        }
        public static string MissingEmailSymbol(string email, out bool isEmailSymbolValid)
        {
            isEmailSymbolValid = true;
            string massege = null;
            if (!email.Contains("@"))
            {
                massege += "gmail chuni shunik\n";
                isEmailSymbolValid = false;
            }
            return massege;
        }
        public static string NumbersInGmail(string gmail, out bool isNumbersInGmail)
        {
            isNumbersInGmail = true;
            string error = null;
            for (int i = 0; i < gmail.Length; i++)
            {
                if (gmail[i] >= '0' && gmail[i] <= '9')
                {
                    error += "There are numbers in your Gmail\n";
                    isNumbersInGmail = false;
                    break;
                }
            }
            return error;
        }
        public static string Valid(string name, string gmail)
        {
            string error = null;
            error += NameCapitalLetter(name, out bool isNameCapitalLetterValid);
            error += NameMaxSize(name, out bool isNameSizeValid);
            error += MissingEmailSymbol(gmail, out bool isGmailSymbolValid);
            error += NumbersInGmail(gmail, out bool isNumbersInGmail);

            if (isNameCapitalLetterValid && isNameSizeValid && isGmailSymbolValid && isNumbersInGmail)
            {
                Console.WriteLine("Congratulations, Misha you did it :) ");
            }
            else
            {
                Console.WriteLine(error);
            }
            return error;
        }
        #endregion


        public static LoginResponseModel UsersLogin(string userEmail, string userPassword, User user1, User user2, User user3)
        {

            LoginResponseModel response = new LoginResponseModel();
            if (user1.Email == userEmail && user1.Password == userPassword)
            {
                response.User = user1;
                response.Massege = "Success Login";
                response.Success = true;
            }
            else if (user2.Email == userEmail && user2.Password == userPassword)
            {
                response.User = user2;
                response.Massege = "Success Login";
                response.Success = true;
            }
            else if (user3.Email == userEmail && user3.Password == userPassword)
            {
                response.User = user3;
                response.Massege = "Success Login";
                response.Success = true;
            }
            else
            {
                response.User = null;
                Console.WriteLine("Incorrect Email Or Password");
                response.Success = false;
            }
            return response;
        }
        public static RegisterResponseModel Register(RegisterModel registerModel)
        {
            bool successRegister = true;
            string massege = null;
            massege += FullName(registerModel.FullName, out bool isFullNameValid);
            massege += MissingEmailSymbol(registerModel.Email, out bool isEmailSymbolValid);
            massege += ValidAge(registerModel.Age, out bool isAgeValid);
            massege += PhoneNumber(registerModel.PhoneNumber, out bool isPhoneNumberValid);
            massege += ValidPassword(registerModel.Password, out bool isPasswordValid);
            if (!isFullNameValid || !isEmailSymbolValid || !isAgeValid || !isPhoneNumberValid || !isPasswordValid)
            {
                successRegister = false;
            }
            return new RegisterResponseModel
            {
                Success = successRegister,
                Message = massege
            };
        }
        public static LoginResponseModel Login(LoginModel loginModel, RegisterModel registerModel)
        {
            LoginResponseModel loginResponseModel = new LoginResponseModel();
            if (loginModel.Email == registerModel.Email && loginModel.Password == registerModel.Password)
            {
                loginResponseModel.Success = true;
                loginResponseModel.Massege = "Success Login";
            }
            else
            {
                loginResponseModel.Success = false;
                loginResponseModel.Massege = "Incorrect Login Or Password";
            }
            return loginResponseModel;
        }

    }

}
