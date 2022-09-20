void Zadacha1()
{
    Console.WriteLine("Введите трехзначное число");
    int number1 = Convert.ToInt32(Console.ReadLine());
    int tens = number1 / 10 % 10;
    Console.WriteLine(tens);
}
Zadacha1();


void Zadacha2()
{
    Console.WriteLine ("Введите любое число");
int number2= Convert.ToInt32 (Console.ReadLine());
int size = 1000;
int num = 10;
int a = 1;
if (number2< 100)
{
    Console.WriteLine ("У числа "+number2 +" третьей цифры нет");
}
else
{
    while(number2>0)
    {
        if (number2 < size)
        {
        int result = number2 % num / a;
        Console.WriteLine ( result);
        break;
        }
        else 
        {
            size = size*10;
            num = num *10;
            a = a*10;

        }
    }

}


}
Zadacha2();


void Zadacha3FirstdWay()
{
Console.WriteLine("Введите чило от 1 до 7");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number3 == 1)
{
    Console.WriteLine("Понедельник  будний день");
}
if (number3 == 2)
{
    Console.WriteLine("Вторник будний день");
}
if (number3 == 3)
{
    Console.WriteLine("Среда  будний день");
}
if (number3 == 4)
{
    Console.WriteLine("Четверг будний день");
}
if (number3 == 5)
{
    Console.WriteLine("Пятница будний день");
}
if (number3 == 6)
{
    Console.WriteLine("Суббота  Выходной день");
}
if (number3 == 7)
{
    Console.WriteLine("Воскресение Выходной день");
}
}
Zadacha3FirstdWay();


void Zadacha3SecondWay()
{
    Console.WriteLine("Введите чило от 1 до 7");
    int number4 = Convert.ToInt32(Console.ReadLine());
    string[] array = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресение" };

    int length = array.Length;
    int count = 1;
    while (count <= length)
    {
        if (number4 == count)
        {
            if (count == 6 || count == 7)
            {
                Console.WriteLine(array[count - 1] + " - Выходной день");
                break;
            }
            else
            {
                Console.WriteLine(array[count - 1] + " - Будний день");
                break;
            }
        }
        else
        {
            count++;
        }
    }
}
Zadacha3SecondWay();
