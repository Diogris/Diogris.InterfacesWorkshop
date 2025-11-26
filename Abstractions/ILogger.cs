namespace Diogris.InterfacesWorkshop.Abstractions;

/// <summary>
/// Описывает методы логгирования.
/// </summary>
internal interface ILogger
{
    /// <summary>
    /// Информационное сообщение.
    /// </summary>
    /// <param name="message">Текст сообщения.</param>
    void Info(string message);

    /// <summary>
    /// Сообщение об ошибке.
    /// </summary>
    /// <param name="exception">Исключение.</param>
    void Error(Exception exception);
}
