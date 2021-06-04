using System;
using System.Collections.Generic;
using System.Text;

namespace oop1
{
    public class FactoryAttribute : Attribute
    {
        private string toolName;
        public string TollName { get => toolName; set => toolName = value; }

        public FactoryAttribute() { }
        public FactoryAttribute(string toolName) { this.toolName = toolName; }
    }
}
