//Если метод не возвращает какие-то значения, т.е. метод ничего не возвращает, то он наз. Void метод и тогда не надо использовать return 
void FillArray(int[] collection)   //наименование метода(название аргумента)
{
    int length  = collection.Length;  //длина массива
    int index = 0;                   // позиция индекса
    while (index < length)           //цикл(пока индекс меньше чем длина)
    {
        collection[index] = new Random().Next(1, 10); //действие:обращаемся к аргументу collection на позицию индекс и положить туда новое случайное число
        //index = index +1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;      //количество элементов
    int position = 0;           //текущая позиция
    while(position < count)    //цикл: пока позиция меньше, чем количество
    {
        Console.WriteLine(col[position]);  //выводим на экран текущую позицию
        position++;                       //увеличиваем значение текущей позиции
    }                 
}

int IndexOf(int[] collection, int find)   //нахождение позиции текущего элемента в массиве с использованием метода 
{
    int count = collection.Length;     //количество элементов
    int index = 0;                     //щёлкаем массивы
    int position = -1;                 //если введённого элемента нет в массиве, то позиция будет -1
    while (index < count)            //цикл проверяет, что...
    {
        if(collection[index] == find)   //если...
        {
            position = index;          //то нужно будет сохранить позицию
            break;                   //чтобы показывалась первая позиция при нескольких одинаковых значениях
        }  
        index++;
    }
    return position;
}

int[] array = new int[10];    //определили массив из 10-ти элементов

FillArray(array);            //метод заполнения массива
array[4] = 4;
array[6] = 4;

PrintArray(array);           //метод печати массива на экран
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);     //