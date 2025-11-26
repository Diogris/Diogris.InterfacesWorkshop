namespace Diogris.InterfacesWorkshop.Services;

/// <summary>
/// Логгер в консоль.
/// </summary>
internal class Logger : ILogger
{
    /// <inheritdoc />
    public void Error(Exception exception)
    {
        var defaultForegroundColor = Console.ForegroundColor;

        SetForegroundColor(ConsoleColor.Red);
        Console.WriteLine($"[ERROR]: {exception.Message}");

        SetForegroundColor(defaultForegroundColor);
    }

    /// <inheritdoc />
    public void Info(string message)
    {
        var defaultForegroundColor = Console.ForegroundColor;

        SetForegroundColor(ConsoleColor.Blue);
        Console.WriteLine($"[INFO] {message}");

        SetForegroundColor(defaultForegroundColor);
    }

    /// <summary>
    /// Изменяет цвет шрифта консоли на заданный.
    /// </summary>
    /// <param name="color">Заданный цвет шрифта.</param>
    private void SetForegroundColor(ConsoleColor color)
    {
        Console.ForegroundColor = color;
    }
}
