System.Console.WriteLine("Введите первое число! >");
int firstnumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число! >");
int secondnumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число! >");
int thirdnumber = Convert.ToInt32(Console.ReadLine());
int max = firstnumber;
 if (secondnumber > max){
    max = secondnumber;
 }
  if (thirdnumber > max){
    max = thirdnumber;
 }
 System.Console.WriteLine("Самое большое число = "+ max);