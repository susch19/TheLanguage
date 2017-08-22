﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compiler.Visitors;
using System.Reflection.Emit;

namespace Compiler.Parsing.Definition
{
    [Syntax(20)]
    public class ReturnSyntax : Syntax
    {
        public Syntax Expression { get; private set; }

        public ReturnSyntax() : base(nameof(ReturnSyntax))
        {
        }

        public override bool TryParse(SyntaxStream stream, Scanner scanner)
        {
            if (stream.Count < 2)
                return false;

            if (stream[0].Name == "Return")
            {
                Expression = scanner.Scan(stream.Skip(1));
                return true;
            }

            return false;
        }

        public override void Visit(Scope scope)
        {
            Expression.Visit(scope);
            scope.Generator.Emit(OpCodes.Ret);
        }
    }
}
