﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrow.Core.Parsing
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class SyntaxAttribute : Attribute
    {
        public int Order { get; private set; }

        public SyntaxAttribute(int order)
        {
            Order = order;
        }
        public SyntaxAttribute(SyntaxDefinitionType syntaxDefinition)
        {
            Order = (int)syntaxDefinition;
        }
    }
}
