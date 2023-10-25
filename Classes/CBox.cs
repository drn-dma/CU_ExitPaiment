using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_ExitPaiment.Classes
{
    internal class CBox
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public CBox(string text, object value) 
        { 
            Text = text;
            Value = value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
