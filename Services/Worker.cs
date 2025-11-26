namespace Diogris.InterfacesWorkshop.Services;

/// <summary>
/// Основная логика приложения.
/// </summary>
/// <param name="logger">Логгер.</param>
/// <param name="addition">Калькулятор.</param>
internal class Worker(ILogger logger, IAddition addition)
{
	/// <summary>
	/// Запускает интерактивную сессию сложения.
	/// </summary>
	public void Run()
	{
		WriteGreeting();

		while (true)
		{
			var a = GetNumber(1);
			var b = GetNumber(2);

			var sum = addition.Sum(a, b);
			logger.Info($"Операция сложения успешна. Результат: {sum}");

			Console.WriteLine($"{a} + {b} = {sum}");
			Console.WriteLine();
		}
	}

	/// <summary>
	/// Получает число из консоли.
	/// </summary>
	/// <param name="index">Номер числа.</param>
	/// <returns>Число.</returns>
	private int GetNumber(int index)
	{
		while (true)
		{
			Console.Write($"Введите число {index}: ");
			var userResponse = Console.ReadLine();

			try
			{
				ArgumentException.ThrowIfNullOrEmpty(userResponse);

				var result = int.Parse(userResponse);

				logger.Info($"Числу {index} назначено значение {result}");

				return result;
			}
			catch (ArgumentException exception)
			{
				logger.Error(exception);
			}
			catch (FormatException exception)
			{
				logger.Error(exception);
			}
			finally
			{
				logger.Info("Попытка ввода завершена.");
			}
		}
	}

	/// <summary>
	/// Выводит приветственное сообщение.
	/// </summary>
	private static void WriteGreeting()
	{
		Console.WriteLine("Привет!");
		Console.WriteLine("Данный код помогает сложить два числа.");
		Console.WriteLine("Давай посмотрим, как он работает?");
		Console.WriteLine("(для выхода нажми ctrl+c)");
		Console.WriteLine();
	}
}
