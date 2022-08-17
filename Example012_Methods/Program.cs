// Вид 1

/*void Method1()  //нет никаких аргументов
{
    Console.WriteLine("Автор ...");         //тело метода, который может что-то показывать на экран
}
Method1();   //Вызываем метод */


// Вид 2

/*void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения"); */

/*void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;      // инкремент
    }
}
Method21(msg: "Текст", count: 4);
Method21(count: 4, msg: "Новый текст"); */

//Вид 3

/*int Method3()
{
    return DateTime.Now.Year;   //метод выполняет какую-то работу
}
int year = Method3();          //Сюда будет положен результат работы метода
Console.WriteLine(year); */

//Вид 4
/*string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res); */


//Цикл for
/*string Method4(int count, string text)
{
    string result = String.Empty;
    for( int i = 0; i < count; i++)    
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res); */

//Цикл в цикле
/*    for( int i = 2; i <= 10; i++) 
 {
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");   //интерполяция строк
    }
    Console.WriteLine();
 } */



//===== Работа с текстом
//Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с".


string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
              + " ежели бы вач послали вместо нашего милого Винценгероде,"
              + "вы бы взяли приступом согласие прусского короля."
              + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;  //заводим новую строку

    int Length = text.Length;
    for (int i = 0; i < Length; i++)
    {
        if (text[i] == oldValue)
            result = result + $"{newValue}";
        else
            result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);




//int[] array = {1, 5, 4, 3, 2, 6, 7, 1, 1};

/*void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)     //поиск минимального
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];            // обмен двух переменных местами
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(array);
SelectionSort(array);
PrintArray(array); */



/* void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)     //поиск максимального
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];            // обмен двух переменных местами
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}


PrintArray(array);
SelectionSort(array);
PrintArray(array); */