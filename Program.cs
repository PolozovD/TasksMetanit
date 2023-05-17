// Task1. Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа. А программа сранивает два введенных числа и выводит на консоль результат сравнения (два числа равны, первое число больше второго или первое число меньше второго).

// Console.WriteLine("Enter the first number: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the second number: ");
// int  secondNum = Convert.ToInt32(Console.ReadLine());
 
// if(firstNum > secondNum)
// Console.WriteLine("The first number is greater than the second number");
// else if (firstNum < secondNum)
// Console.WriteLine("The first number is less than the second number");
// else
// Console.WriteLine("Both numbers are equal");

// Task2. Напишите консольную программу, в которую пользователь вводит с клавиатуры число. 
// Если число одновременно больше 5 и меньше 10, то программа выводит "Число больше 5 и меньше 10". Иначе программа выводит сообщение "Неизвестное число".

// Console.WriteLine("Enter the number: ");
// int num = Convert.ToInt32(Console.ReadLine());
 
// if (num > 5 && num < 10)
// Console.WriteLine("The number greater than 5 and less than 10");
// else
// Console.WriteLine("Unkown number");

// Task3. Напишите консольную программу, в которую пользователь вводит с клавиатуры число. 
// Если число либо равно 5, либо равно 10, то программа выводит "Число либо равно 5, либо равно 10". Иначе программа выводит сообщение "Неизвестное число".

// Console.WriteLine("Enter the number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num == 5 || num == 10)
// Console.WriteLine("The number is either 5 or 10");
// else
// Console.WriteLine("Unkown number");

// Task4. В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться. 
// Напишите консольную программу, в которую пользователь вводит сумму вклада. 
// Если сумма вклада меньше 100, то начисляется 5%. Если сумма вклада от 100 до 200, то начисляется 7%. 
// Если сумма вклада больше 200, то начисляется 10%. В конце программа должна выводить сумму вклада с начисленными процентами.

// Для получения вводимого с клавиатуры числа используйте выражение Convert.ToDouble(Console.ReadLine())

// Console.WriteLine("Enter the deposit amount: ");
// double num = Convert.ToDouble(Console.ReadLine());

// double result = 0;
// if(num > 0 && num < 100) 
// {
//     result = num * 1.05;
//     Console.WriteLine($"{num} -> the amount of the deposit with accrued interest {result}");
// }
// if(num > 99 && num < 200)
// {
//     result = num * 1.07;
//     Console.WriteLine($"{num} -> the amount of the deposit with accrued interest {result}");
// }
// if(num > 199)
// {
//     result = num * 1.1;
//     Console.WriteLine($"{num} -> the amount of the deposit with accrued interest {result}");
// }

// Task5. Изменим предыдущую задачу. Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы. 
// И, допустим, сейчас банк решил доначислить по всем вкладам 15 единиц вне зависимости от их суммы. 
// Измените программу таким образом, чтобы к финальной сумме дочислялись бонусы.

// Console.WriteLine("Enter the deposit amount: ");
// double num = Convert.ToDouble(Console.ReadLine());

// double result = 0;
// if(num > 0 && num < 100) 
// {
//     result = num * 1.05 + 15;
//     Console.WriteLine($"{num} -> the amount of the deposit with accrued interest {result}");
// }
// if(num > 99 && num < 200)
// {
//     result = num * 1.07 + 15;
//     Console.WriteLine($"{num} -> the amount of the deposit with accrued interest {result}");
// }
// if(num > 199)
// {
//     result = num * 1.1 + 15;
//     Console.WriteLine($"{num} -> the amount of the deposit with accrued interest {result}");
// }

// Task6. Напишите консольную программу, которая выводит пользователю сообщение "Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение". 
// Рядом с названием каждой операции указан ее номер, например, операция вычитания имеет номер 2. 
// Пусть пользователь вводит в программу номер операции, и в зависимости от номера операции программа выводит ему название операции.

// Для определения операции по введенному номеру используйте конструкцию switch...case.

// Если введенное пользователем число не соответствует никакой операции (например, число 120), то выведите пользователю сообщение о том, что операция неопределена.

// Console.WriteLine("Enter the number of operaation: 1.Addition; 2.Subtraction; 3.Multiplication");
// int numOfOperation = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the first number: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the second number: ");
// int secondNum = Convert.ToInt32(Console.ReadLine());

// switch (numOfOperation)
// {
//     case 1:
//     Console.WriteLine($"The first num is {firstNum}, the second num is {secondNum}, This operation is addition -> {firstNum + secondNum}");
//     break;
//     case 2:
//     Console.WriteLine($"The first num is {firstNum}, the second num is {secondNum}, This operation is substraction -> {firstNum - secondNum}");
//     break;
//     case 3:
//     Console.WriteLine($"The first num is {firstNum}, the second num is {secondNum}, This operation is multiplication -> {firstNum * secondNum}");
//     break;
//     default:
//     Console.WriteLine("Operation not defined");
//     break;
// }

