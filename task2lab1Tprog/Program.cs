﻿using System;
public class Logic
{
	//логика программы в которой происходит поиск ответа на поставленную задачу с текущими данными
	public static string splitstring(String vvod) {
			//создаём следующие переменные:
			var num = new List<double>();//массив для хранения чисел в ведённой последовательности
			double save = 0; //вспомогательная переменная для хранения числа, при его переводе из текста
			int j = 0;//счётчик разрядности, предназначенный для корректного перевода числа
        try { //обработка ошибки, при неверно введённом формате данных
			for (int i = vvod.Length; i > 0; i--) //цикл для прохода строки с конца
			{
				if (vvod[i - 1] == ',') { num.Add(save); j = 0; save = 0; }//при символе "," записываем зранящееся в переменной save число в массив
				else
				{
					save += Math.Pow(10, j) * int.Parse(vvod[i - 1].ToString());//переводимтекущий символ в число домнажая его на разрядность и сохраняем в переменной save
					j++;
				}
			}
			if (num.Count < 1) { return "формат введённых данных некоректен, попробуйте ещё раз"; } //обработка малого числа введённых данных
		}catch (FormatException) { return "формат введённых данных некоректен, попробуйте ещё раз"; }
		return giveans(num);
	}
	private static string giveans(List<double> num)
	{
		//проходим по полученному выше массиву проверяя порядок
		for (int i = 1; i < num.Count; i++)
		{
			if (num[i - 1] <= num[i])
			{

				return "Последовательность, не возрастающая";
			}
		}
		return "Последовательность, возрастающая";
	}
}
class Program
{
	//основная часть программы в которой происходит ввод данных и вывод ответа
	static void Main()
	{
		Console.WriteLine("Введите числа последовательности через запятую:");
		string vvod = Console.ReadLine();
		Console.WriteLine(Logic.splitstring(vvod));
	}
}

