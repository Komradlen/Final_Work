/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

void PrintArray_2(string[] array){
	if(array.Length == 0){
		Console.WriteLine("В массиве нет таких строк");
	}
	else{
		Array.ForEach(array, (str) => Console.Write($"{str} "));
		Console.WriteLine();
	}
}

void PrintArray_1(string[] array){
	Console.WriteLine("Изначальный массив:");
	PrintArray_2(array);
	string[] shortArray = array_short(array);
	Console.WriteLine("Строки, в которых не более 3-х символов:");
	PrintArray_2(shortArray);
	Console.WriteLine();
}

string[] array_1 = {"Hello", "2", "world", ":-)"};
string[] array_2 = {"1234", "1567", "-2", "computer science"};
string[] array_3 = {"Russia", "Denmark", "Kazan"};
int max_lenght = 3;

string[] array_short(string[] array){
	int length = array.Length;			
	string[] result = new string[length];
	int count = 0;		
	for (int i = 0; i < length; i++){
		if(array[i].Length <= max_lenght){
			result[count] = array[i];
			count++;
		}
	}
    Array.Resize(ref result, count);
    return result;
}

PrintArray_1(array_1);
PrintArray_1(array_2);
PrintArray_1(array_3);