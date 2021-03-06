﻿using System.Diagnostics;

namespace FunctionInterpreter
{
    /// <summary>
    /// Describes the type and location of a compilation error.
    /// </summary>
    [DebuggerDisplay("{Text}")]
    public readonly struct CompileError
    {
        public CompileError(ErrorType error, int? position = null)
        {
            Type = error;
            Position = position;
            Text = ErrorResources.GetString(error);
        }

        public CompileError(ErrorType error, string text)
        {
            Type = error;
            Text = text;
            Position = null;
        }

        public CompileError(ErrorType error, string text, int? position)
        {
            Type = error;
            Text = text;
            Position = position;
        }

        public ErrorType Type { get; }
        public string Text { get; }
        public int? Position { get; }
    }
}
