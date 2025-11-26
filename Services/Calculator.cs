namespace Diogris.InterfacesWorkshop.Services;

/// <summary>
/// Мини-калькулятор.
/// </summary>
internal class Calculator : IAddition
{
    /// <inheritdoc />
    public int Sum(int a, int b)
    {
        return a + b;       
    }
}
