string[] initialArr = new string[5];
Console.WriteLine("Пожалуйста, введите 5 строк.");
FillArray(initialArr);

string[] finalArr = new string[FindArrSize(initialArr)];

string[] FillArray(string[] array) //метод заполняет массив данными, введенными пользователем
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

int FindArrSize(string[] array) //метод позволяет узнать сколько в массиве всего значений с длиной <= 3
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) size += 1;
    }
    return size;
}

void FillNewArr(string[] initialArr, string[] finalArr) //метод переносит элементы с длиной <= 3 в новый массив
{
    int count = 0;
    for (int i = 0; i < initialArr.Length; i++)
    {
        if (initialArr[i].Length <= 3)
        {
            finalArr[count] = initialArr[i];
            count += 1;
        }
    }
    Console.WriteLine(string.Join(", ", finalArr));
}

FillNewArr(initialArr, finalArr);