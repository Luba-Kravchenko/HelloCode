//
/* string[,] table = new string[2, 5];
//String.Empty - инициализация для строк
// table[0,0] table[0, 1] table[0, 2] table[0, 3] table[0, 4]
// table[1,0] table[1, 1] table[1, 2] table[1, 3] table[1, 4]


table[1, 2] = "слово";


for (int rows = 0; rows < 2; rows++)     //строки
{
    for (int columns = 0; columns < 5; columns++)     //столбцы
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
} */



/* void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)       //метод который заполняет нашу матрицу случайными числами
{
   for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10);      //[1; 10) - интервал от 1 до 10
        } 
    }  
}                              

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);  */










/*int[,] pic = new int[,]
{
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};


void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"{image[i, j]} ");
            if(image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)       //Метод, который закрашивает картинку
{
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);   // Вызываем функцию саму себя - рекурсия
        FillImage(row, col - 1);
        FillImage(row + 1, col);
        FillImage(row, col + 1);
    }
}


PrintImage(pic);
FillImage(13, 13);    //В качестве случайной точки указываем (13, 13)
PrintImage(pic); */



// Рекурсия - это функция вызывающая сама себя.

/*double Factorial (int n)
{
    //1! = 1
    //0! = 1
    if(n == 1) return 1;                  //Если мы дошли до единицы, то мы должны вернуть единицу
    else return n * Factorial(n-1);       //Иначе мы текущее значение умножаем на факториал предыдущего числа
} 
for (int i = 1; i < 40; i++)
{
    //Console.WriteLine(Factorial(i));              // 3! = 1*2*3 = 6
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
*/

// Используя рекурсию одним из самых важных является условие выхода, чтобы рекурсия прекратилась!

//Собрать строку с числами от a до b, a <= b.  (a >= b)
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)      // запускаем цикл, который меняет значения от a до <= b  (i >= b; i--)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);  // (return NumbersRec(a + 1, b) + $"{a} ")
    else return String.Empty;    //окончание рекурсии, возвращаем пустую строку, если условие не выполнилось
}
Console.WriteLine(NumbersFor(1, 10)); //1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); //1 2 3 4 5 6 7 8 9 10


// Найти Cумму чисел от 1 до n.
int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

int SumRec(int n)
{
    if (n == 0) return 0;    // условие выхода n == 0, возвращаем 0
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumFor(10));  //55
Console.WriteLine(SumRec(10));  //55

//Факториал числа n.
int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

int FactorialRec(int n)
{
    if (n == 1) return 1;    // условие выхода n == 1, возвращаем 1.
    else return n * FactorialRec(n - 1);
}
Console.WriteLine(FactorialFo(10));   //3628800
Console.WriteLine(FactorialRec(10));  //3628800


//Вычислить a в сиепени n.
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{
    if (n == 0) return 1;
    else return PowerRec(a, n - 1) * a;
    // return n == 0 ? 1 : PowerRec(a, n - 1) * a; этой одной строкой можно заменить две строки выше 
}

int PowerRecMath(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}
Console.WriteLine(PowerFor(2, 10));     //1024
Console.WriteLine(PowerRec(2, 10));     //1024
Console.WriteLine(PowerRecMath(2, 10));  //1024

// Внекотором  машинном алфавите имеются четыре буквы "а", "и", "с", "в".
// Покажите все слова, состоящие из Т букв, которые можно построить из букв этого алфавита.
char[] s = { 'a', 'и', 'с', 'в' };
int count = s.Length;
int n = 1;
for (int i = 0; i <= count; i++)        //переберём все буквы и получим однобуквенные слова
{
    for (int j = 0; j <= count; j++)   //получим двухбуквенные слова
    {
        Console.WriteLine($"{n++,-5}{s[i]}{s[j]}");
    }
}

int n = 1;
void FindWords(string alphabet, char[] word, int length = 0)    //Рекурсивный метод
{
    if (length == word.Length)  // условие выхода из рекурсии
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("аисв", new char[5]);

// Как посмотреть содержимое папки?
string path = "C:/Users/Люба/Desktop/Учеба/Examples/Example002_";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}

//рекурсия опишем метод который будет ходить по папкам и смотреть, что внутри
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
string path = "C:/Users/Люба/Desktop/Учеба/Examples";
CatalogInfo(path);


// Поиграем в пирамидки.
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);

}
Towers();


// Обход разных структур.
// ((4 - 2) * (1 + 3)) / 10
string emp = string.Empty;
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
 //               0    1    2     3    4    5    6    7    8    9    10   11
 void InOrderTreversal(int pos = 1)  // метод, позволяющий делать обход с позиции = 1
 {
    if (pos < tree.Length)   // условие оеончание рекурсии
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if(left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTreversal(left);
        Console.WriteLine(left[pos]);
        if (right < tree.Length && !string.IsNullOrEmpty(tree[right])) InOrderTreversal(right);
    }
 }
InOrderTreversal();



//Числа Фибоначчи, где каждое следующее число задаётся через предыдущее.
// Код для вывода чисел Фибоначчи

//f(1) = 1
//f(2) = 1
//f(n) = f(n-1) + f(n-2)

/*int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
} */



/*double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}*/