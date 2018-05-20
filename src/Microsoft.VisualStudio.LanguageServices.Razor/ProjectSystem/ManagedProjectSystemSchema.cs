// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.CodeAnalysis.Razor.ProjectSystem
{
    // Well-Known Schema and property names defined by the ManagedProjectSystem
    internal static class ManagedProjectSystemSchema
    {
        public static class CompilerCommandLineArgs
        {
            public static readonly string SchemaName = "CompilerCommandLineArgs";

            public static readonly string ItemName = "CompilerCommandLineArgs";
        }

        public static class ConfigurationGeneral
        {
            public static readonly string SchemaName = "ConfigurationGeneral";

            public static readonly string TargetPathPropertyName = "TargetPath";
        }

        public static class ResolvedCompilationReference
        {
            public static readonly string SchemaName = "ResolvedCompilationReference";

            public static readonly string ItemName = "ResolvedCompilationReference";
        }
    }
}
