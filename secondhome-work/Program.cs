System.Console.WriteLine("Введите первое число");
int firstnumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int secondnumber = Convert.ToInt32(Console.ReadLine());
if(firstnumber>secondnumber){
    System.Console.WriteLine("Наименьшее число " +secondnumber + " Наибольшее число " + firstnumber);
} else{
        System.Console.WriteLine("Наименьшее число " +firstnumber + " Наибольшее число " +secondnumber);
}