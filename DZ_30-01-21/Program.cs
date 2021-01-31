using System;

namespace DZ_30_01_21
{
	partial class Program
	{
		static void Main(string[] args)
		{
			System.Console.WriteLine("Задание 2");
			{
				// Задание 2
				// 1. Требуется:
				// • Создайте класс DocumentWorker.
				// • В теле класса создайте три метода OpenDocument(), EditDocument(),
				// SaveDocument().
				// • В тело каждого из методов добавьте вывод на экран соответствующих
				// строк: "Документ открыт", "Редактирование документа доступно в
				// версии Про", "Сохранение документа доступно в версии Про".
				// • Создайте производный класс ProDocumentWorker.
				// • Переопределите соответствующие методы, при переопределении
				// методов выводите следующие строки: "Документ отредактирован",
				// "Документ сохранен в старом формате, сохранение в остальных
				// форматах доступно в версии Эксперт".
				// • Создайте производный класс ExpertDocumentWorker от базового
				// класса ProDocumentWorker.
				// • Переопределите соответствующий метод. При вызове данного метода
				// необходимо выводить на экран "Документ сохранен в новом
				// формате".
				// • В теле метода Main() реализуйте возможность приема от пользователя
				// номера ключа доступа pro и exp.
				// • Если пользователь не вводит ключ, он может пользоваться только
				// бесплатной версией (создается экземпляр базового класса), если
				// пользователь ввел номера ключа доступа pro и exp, то должен
				// • создаться экземпляр соответствующей версии класса, приведенный к
				// базовому - DocumentWorker.
				var docWorker = new DocumentWorker();
				Console.Write("Введите ключ продукта: ");
				var key = Console.ReadLine();
				docWorker = GetWorkerByKey(key);
				Console.WriteLine();
				bool isOn = true;
				while (isOn)
				{
					Console.WriteLine("1. Открыть документ\n2. Изменить документ\n3. Сохранить документ\n4. Ввести новый ключ\nВведите любую другую команду для выхода");
					switch (Console.ReadLine())
					{
						case "1":
							{
								docWorker.OpenDocument();
								break;
							}
						case "2":
							{
								docWorker.EditDocument();
								break;
							}
						case "3":
							{
								docWorker.SaveDocument();
								break;
							}
						case "4":
							{
								Console.Write("Введите ключ продукта: ");
								key = Console.ReadLine();
								docWorker = GetWorkerByKey(key);
								break;
							}
						default:
							{
								Console.WriteLine("Не верный выбор");
								isOn = false;
								break;
							}
					}
				}
			}
			Console.WriteLine();
			Console.WriteLine("Задание 3");
			{
				// Задание 3
				// Требуется:
				// • Создайте 2 интерфейса IPlayable и IRecodable. В каждом из
				// интерфейсов создайте по 3 метода:
				// IPlayable:
				// o void Play() / void Pause() / void Stop()
				// IRecodable:
				// o void Record() / void Pause() / void Stop()
				// • Создайте производный класс Player от базовых интерфейсов IPlayable
				// и IRecodable.
				// • Написать программу, которая выводит на экран текст действия.
				var player = new Player();
				player.Play();
				player.Record();
				player.Pause();
				player.Stop();
			}
		}
		public static DocumentWorker GetWorkerByKey(string key)
		{
			switch (key)
			{
				case "shPro":
					Console.WriteLine("Был введён ключ от версии Pro");
					return new ProDocumentWorker();
				case "shExp":
					Console.WriteLine("Был введён ключ от версии Expert");
					return new ProDocumentWorker();
				default:
					Console.WriteLine("Был введён не действительный ключ. Вам доступна обычная версия");
					return new DocumentWorker();

			}
		}
	}
}
