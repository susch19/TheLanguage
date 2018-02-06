﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using Arrow.Core.Basekeywords;
using Arrow.Core;
using Arrow.Core.Scanning;

namespace Arrow.Definition.Keywords
{
    public class Identifier : IdentifierKeyword
    {

        public override bool TryParse(TokenStream stream, Scanner scanner)
        {

            if (stream.Count != 1)
                return false;

            if (stream[0] is Token token)
            {
                if (token.Name == "Identifier")
                {
                    Position = stream.GlobalPosition;
                    Length = 1;
                    Name = token.Value;
                    return true;
                }
            }

            return false;
        }
    }
}
