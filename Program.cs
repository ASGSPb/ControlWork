// // Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше,
//  либо равна 3 символам. Первоначальный массив можно ввести с 
//  клавиатуры, либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.


// Создать массив строк.
// Вычислить необходимые значения.
// Создать новый массив с необходимыми значениями.
// Вывести на экран.

Console.Clear();

Console.WriteLine("Сформируем массив из элементов string.");
Console.WriteLine("Из скольки элементов будет массив?");
int arrayValue = int.Parse(Console.ReadLine());

string [] arrayFill = new string [arrayValue];

FillArray(arrayFill);

string [] newArray = SortArray(arrayFill);
Console.WriteLine();

Console.WriteLine("Заданный масив:");
PrintArray(arrayFill);
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Массив с элементами не длиннее (3)-х символов :");
PrintArray(newArray);
Console.WriteLine();
Console.WriteLine();








string [] FillArray (string [] arrayFill)
{
    for (int i = 0; i < arrayValue; i++)
	{
		Console.WriteLine($"Введите {i} элемент :");
		arrayFill[i] = Console.ReadLine();
	}
	return arrayFill;
}

