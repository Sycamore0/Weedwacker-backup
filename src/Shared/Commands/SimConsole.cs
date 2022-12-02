using System;
using System.Collections.Generic;
using System.CommandLine.IO;
using System.CommandLine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.Shared.Enums;

namespace Weedwacker.Shared.Commands
{
    public class SimConsole : IConsoleWithUserRank
    {
        /// <summary>
        /// Initializes a new instance of <see cref="SimConsole"/>.
        /// </summary>
        public SimConsole(UserRank rank)
        {
            this.rank = rank;
            Out = new StandardStreamWriter();
            Error = this.Out;
        }

        /// <inheritdoc />
        public IStandardStreamWriter Error { get; protected set; }

        /// <inheritdoc />
        public IStandardStreamWriter Out { get; protected set; }

        /// <inheritdoc />
        public bool IsOutputRedirected { get; protected set; }

        /// <inheritdoc />
        public bool IsErrorRedirected { get; protected set; }

        /// <inheritdoc />
        public bool IsInputRedirected { get; protected set; }

        public UserRank rank { get; protected set; }

        internal class StandardStreamWriter : TextWriter, IStandardStreamWriter
        {
            private readonly StringBuilder _stringBuilder = new();

            public override void Write(char value)
            {
                _stringBuilder.Append(value);
            }

            public override void Write(string? value)
            {
                _stringBuilder.Append(value);
            }

            public override Encoding Encoding { get; } = Encoding.Unicode;

            public override string ToString() => _stringBuilder.ToString();
        }
    }
    
}
