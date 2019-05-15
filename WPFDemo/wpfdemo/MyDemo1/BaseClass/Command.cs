using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyDemo1.BaseClass
{
    public class Command : ICommand
    {
        public Action<object> ExecuteMethod;
        public Func<object, bool> CanExecuteMethod;
        public Command(Action<object> action, Func<object, bool> func)
        {
            ExecuteMethod = action;
            CanExecuteMethod = func;
        }
        /// <summary>
        /// 在能否执行的状态发生改变的时候，通知调用者状态发生改变
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// 能否执行
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            if (CanExecuteMethod == null)
            {
                return true;
            }
            return CanExecuteMethod(parameter);
        }

        /// <summary>
        /// 执行的命令
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            if (CanExecute(null))
            {
                ExecuteMethod?.Invoke(parameter);
            }
        }
    }
}
