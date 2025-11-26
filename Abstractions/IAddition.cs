namespace Diogris.InterfacesWorkshop.Abstractions;

/// <summary>
/// Описывает методы сложения.
/// </summary>
internal interface IAddition
{
	/// <summary>
	/// Производит сложение двух чисел.
	/// </summary>
	/// <param name="a">Первое число для сложения.</param>
	/// <param name="b">Второе число для сложения.</param>
	/// <returns>Сумма двух чисел.</returns>
	int Sum(int a, int b);
}
