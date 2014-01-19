﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using Microsoft.AspNet.Razor.Text;
using Microsoft.AspNet.Razor.Tokenizer;
using Microsoft.AspNet.Razor.Tokenizer.Symbols;

namespace Microsoft.AspNet.Razor.Test.Tokenizer
{
    public abstract class CSharpTokenizerTestBase : TokenizerTestBase<CSharpSymbol, CSharpSymbolType>
    {
        private static CSharpSymbol _ignoreRemaining = new CSharpSymbol(0, 0, 0, String.Empty, CSharpSymbolType.Unknown);

        protected override CSharpSymbol IgnoreRemaining
        {
            get { return _ignoreRemaining; }
        }

        protected override Tokenizer<CSharpSymbol, CSharpSymbolType> CreateTokenizer(ITextDocument source)
        {
            return new CSharpTokenizer(source);
        }

        protected void TestSingleToken(string text, CSharpSymbolType expectedSymbolType)
        {
            TestTokenizer(text, new CSharpSymbol(0, 0, 0, text, expectedSymbolType));
        }
    }
}