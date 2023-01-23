System.Console.WriteLine("Введите число!");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (number <= 1){
    System.Console.WriteLine("Нет четных чисел для заданного условия");
}
while(count<= number){
    if(count % 2 == 0 && count > 0){
        System.Console.Write($" {count} ");
    }
    count++;
}