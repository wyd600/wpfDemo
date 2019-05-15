using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MyDemo1.Model;
using MyDemo1.BaseClass;
using Microsoft.Win32;

namespace MyDemo1.ViewModel
{
    public class MainFormVM
    {
        public MainFormVM()
        {
            para = new ParameterC();
        }
        public ParameterC para { get; set; }

        public void BtnClick(object c)
        {
            para.Result = para.Input1 + para.Input2;
        }

        public ICommand BtnClickAction
        {
            get
            {
                return new Command(BtnClick, null);
            }
        }

        public void SaveClick(object c)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
        }
        public ICommand SaveClickAction
        {
            get
            {
                return new Command(SaveClick, null);
            }
        }
    }
}
