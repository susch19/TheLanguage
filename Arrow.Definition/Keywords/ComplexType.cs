﻿using Arrow.Core;
using Arrow.Core.Basekeywords;

namespace Arrow.Definition.Keywords
{
    public class ComplexType : TypeKeyword
    {
        public override bool TryParse(TokenStream stream, Scanner scanner)
        {
            if(stream[0] is TokenSyntax tokenSyntax)
            {
                if(tokenSyntax.Name == "Identifier")
                {
                    Value = tokenSyntax.Token.Value;
                    Position = stream.GlobalPosition;
                    Length = 1;
                    return true;
                }
            }

            return false;
        }
    }
}