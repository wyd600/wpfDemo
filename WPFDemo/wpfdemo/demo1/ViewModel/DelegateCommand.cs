using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace demo1.ViewModel
{
    public class DelegateCommand : ICommand
    {
        /// <summary>
        /// 当命令能不能执行的这个状态发生改变之后，有机会通知命令的调用者，让调用者知道状态已经发生了改变
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// 该方法用来帮助命令的呼叫者判断命令能不能执行
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            if (this.CanExecuteFunc == null)
            {
                return true;
            }
            return this.CanExecuteFunc(parameter);
        }

        /// <summary>
        /// 当命令执行的时候，想执行什么
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            if (this.ExecuteAction == null)
            {
                return;
            }
            this.ExecuteAction(parameter);
        }

        public Action<object> ExecuteAction { get; set; }
        public Func<object, bool> CanExecuteFunc { get; set; }
    }
}
