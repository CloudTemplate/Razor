﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using Microsoft.AspNetCore.Razor.Language.CodeGeneration;
using Microsoft.AspNetCore.Razor.Language.Intermediate;

namespace Microsoft.AspNetCore.Razor.Language.Extensions
{
    public sealed class TemplateIntermediateNode : ExtensionIntermediateNode
    {
        public override IntermediateNodeCollection Children { get; } = new DefaultIntermediateNodeCollection();
        
        public override void Accept(IntermediateNodeVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException(nameof(visitor));
            }

            AcceptExtensionNode<TemplateIntermediateNode>(this, visitor);
        }

        public override void WriteNode(CodeTarget target, CSharpRenderingContext context)
        {
            if (target == null)
            {
                throw new ArgumentNullException(nameof(target));
            }

            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var extension = target.GetExtension<ITemplateTargetExtension>();
            if (extension == null)
            {
                context.ReportMissingExtension<ITemplateTargetExtension>();
                return;
            }

            extension.WriteTemplate(context, this);
        }
    }
}