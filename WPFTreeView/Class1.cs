using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTreeView
{
    public class Class1 : INotifyPropertyChanged
    {
        private string test;

        public event PropertyChangedEventHandler? PropertyChanged = (sender, e) => { };

        public string Test
        {
            get { return test; }
            set
            {
                if(test == value) return;

                test = value;

                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Test)));
            }
        }

        public Class1()
        {
            Task.Run(async () =>
            {
                int i = 0;

                while(true)
                {
                    await Task.Delay(1000);
                    Test = (i++).ToString();
                }
            });
        }

        public override string ToString()
        {
            return "Hello World";
        }
    }
}
