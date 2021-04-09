using System;
using System.Collections.Generic;
using System.Text;

namespace WinformsApp.Classes
{
    public class ComboBoxItemClass
    {
        public ComboBoxItemClass(double value, string text)
        {
            this.Value = value;
            this.Text = text;
        }
        public double Value { get; set; }
        public string Text { get; set; }
    }
}
