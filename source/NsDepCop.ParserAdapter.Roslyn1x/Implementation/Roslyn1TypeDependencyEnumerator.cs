﻿using Codartis.NsDepCop.Core.Util;

namespace Codartis.NsDepCop.ParserAdapter.Implementation
{
    /// <summary>
    /// Enumerates type dependencies in source code using Roslyn 1.x
    /// </summary>
    public class Roslyn1TypeDependencyEnumerator : RoslynTypeDependencyEnumeratorBase
    {
        public Roslyn1TypeDependencyEnumerator(MessageHandler infoMessageHandler, MessageHandler diagnosticMessageHandler) 
            : base(new Roslyn1SyntaxNodeAnalyzer(),  infoMessageHandler, diagnosticMessageHandler)
        {
        }
    }
}
