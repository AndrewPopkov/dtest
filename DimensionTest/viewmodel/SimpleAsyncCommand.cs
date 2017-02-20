using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DimensionTest.viewmodel
{
    /// <summary>
    /// Реализация интерфейса асинхронной команды.
    /// </summary>
    public class SimpleAsyncCommand : SimpleCommand, IAsyncCommand
    {
        private readonly Action<SimpleAsyncCommand, object> asyncExecuteAction = null;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="SimpleCommand" />.
        /// </summary>
        /// <param name="executeAction">Действие команды.</param>
        /// <param name="canExecuteFunc">Функция проверки возможности исполнения команды.</param>
        public SimpleAsyncCommand(Action<object> executeAction, Func<object, bool> canExecuteFunc = null)
            : base(executeAction, canExecuteFunc) { }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="SimpleAsyncCommand"/>.
        /// </summary>
        /// <param name="executeAction">Действие команды.</param>
        /// <param name="canExecuteFunc">Функция проверки возможности исполнения команды.</param>
        public SimpleAsyncCommand(Action<SimpleAsyncCommand, object> executeAction, Func<object, bool> canExecuteFunc = null)
            : base(null, canExecuteFunc)
        {
            asyncExecuteAction = executeAction;
        }

        /// <summary>
        /// Выполняет действия команды.
        /// </summary>
        /// <param name="parameter">Параметр команды.</param>
        protected override void DoExecute(object parameter)
        {
            if (asyncExecuteAction != null)
            {
                if (CanExecute(parameter) && this.asyncExecuteAction != null)
                {
                    this.asyncExecuteAction(this, parameter);
                }
            }
            else
            {
                base.DoExecute(parameter);
            }
        }

        /// <summary>
        /// Завершает команду с указанным результатом.
        /// </summary>
        /// <param name="result">если присвоено значение <c>true</c>, то команда завершилась успешно.</param>
        public void Complete(bool result = true)
        {
            if (Completed != null)
                Completed(this, new AsyncCommandCompletedEventArgs(result));
        }

        /// <summary>
        /// Возникает, когда выполнение команды завершено.
        /// </summary>
        public event EventHandler<AsyncCommandCompletedEventArgs> Completed;
    }



    public class AsyncBlockingCommand : SimpleAsyncCommand
    {
        public object Parameter { get; set; }

        private bool isCompleted = false;
        public bool IsCompleted
        {
            get { return isCompleted; }
            set { isCompleted = value; }
        }

        private bool isBlocked = false;
        public bool IsBlocked
        {
            get { return isBlocked; }
            set { isBlocked = value; }
        }

        protected override void DoExecute(object parameter)
        {
            Parameter = parameter;

            base.DoExecute(parameter);
        }

        public new bool CanExecute(object parameter)
        {
            if (IsBlocked)
                return false;

            return base.CanExecute(parameter);
        }

        public AsyncBlockingCommand(Action<object> executeAction, Func<object, bool> canExecuteFunc = null)
            : base(executeAction, canExecuteFunc)
        { }

        public AsyncBlockingCommand(Action<SimpleAsyncCommand, object> executeAction, Func<object, bool> canExecuteFunc = null)
            : base(executeAction, canExecuteFunc)
        { }
    }
}
