﻿namespace Microsoft.Build.Logging.StructuredLogger
{
    public class SourceFile : NamedNode, IHasSourceFile
    {
        public string SourceFilePath { get; set; }
    }
}
