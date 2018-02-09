using System;
using System.Windows.Forms;
using ServicesFactory.Interfaces;

namespace ServicesFactory.Services
{
    internal class MessageBoxService : IMessageBoxService
    {
        private static readonly Lazy<MessageBoxService> Instance = new Lazy<MessageBoxService>(() => new MessageBoxService(), true);
        public static MessageBoxService GetInstance()
        {
            return Instance.Value;
        }

        private MessageBoxService()
        {
        }

        public void CatchException(Action action)
        {
            try
            {
                action.Invoke();
                MessageBox.Show("No_exceptions.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public T CatchException<T>(Func<T> function)
        {
            try
            {
                var result = function.Invoke();
                MessageBox.Show($"No_exceptions.");
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
            return (T)(object)null;
        }
    }
}
