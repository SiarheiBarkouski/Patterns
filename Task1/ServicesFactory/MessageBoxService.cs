using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicesFactory
{
    public class MessageBoxService
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
