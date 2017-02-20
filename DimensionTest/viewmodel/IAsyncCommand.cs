using System;
using System.Windows.Input;


namespace DimensionTest.viewmodel
{
    /// <summary>
    /// Класс аргументов события завершения асинхронной команды.
    /// </summary>
    public class AsyncCommandCompletedEventArgs : EventArgs
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="AsyncCommandCompletedEventArgs"/>.
        /// </summary>
        /// <param name="result">если присвоено значение <c>true</c>, то команда завершилась успешно.</param>
        public AsyncCommandCompletedEventArgs(bool result)
        {
            Result = result;
        }
        /// <summary>
        /// Получает результат.
        /// </summary>
        /// <value>Результат.</value>
        public bool Result { get; private set; }
    }

    /// <summary>
    /// Интерфейс асинхронной команды.
    /// </summary>
    public interface IAsyncCommand : ICommand
    {
        /// <summary>
        /// Возникает, когда выполнение команды завершено.
        /// </summary>
        event EventHandler<AsyncCommandCompletedEventArgs> Completed;
    }
}