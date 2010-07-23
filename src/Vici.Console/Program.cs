// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Sleepless Monkey Development, Inc.">
//   Copyright © 2010
// </copyright>
// <summary>
//   The command line runner for VICI.
// </summary>
// <license>
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of
// the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS
// OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </license>
// --------------------------------------------------------------------------------------------------------------------

namespace Vici.Console
{
    using System;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Reflection;
    using CommandLine;
    using CommandLine.Text;

    /// <summary>
    /// The command line runner for VICI.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// This is the heading information that is displayed for the executable when the help information is shown.
        /// </summary>
        private static readonly HeadingInfo Heading = new HeadingInfo(Assembly.GetEntryAssembly().GetName().Name, Assembly.GetEntryAssembly().GetName().Version.ToString(3));

        /// <summary>
        /// This is the copyright information that is displayed for the executable when the help information is shown.
        /// </summary>
        private static readonly CopyrightInfo Copyright = new CopyrightInfo(ProjectInformation.Company, Convert.ToInt32(ProjectInformation.CopyrightStartYear, CultureInfo.CurrentCulture));

        /// <summary>
        /// The entry point of the command line runner.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            var options = new Options();
            if (!CommandLineParser.Default.ParseArguments(args, options))
            {
                Environment.Exit(ExitCodes.InvalidArguments);
            }

            Pause();
        }

        /// <summary>
        /// Pauses console execution until the user acknowledges the message.
        /// </summary>
        [Conditional("DEBUG")]
        private static void Pause()
        {
            Console.Write(Resources.PressAnyKeyToContinue);
            Console.ReadKey();
        }

        /// <summary>
        /// The Options class is a strongly typed class used by the CommandLine library for parsing command line arguments.
        /// </summary>
        private class Options
        {
            /// <summary>
            /// Gets the help text.
            /// </summary>
            /// <returns>The build out help text.</returns>
            [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Justification = "This is reflected upon by Commandline, thus never called explicitly."),
                HelpOption("?", "help", HelpText = "Displays this help text.")]
            public string GetHelp()
            {
                var help = new HelpText(Program.Heading)
                {
                    AdditionalNewLineAfterOption = true,
                    ApplicationName = Heading.ProgramName,
                    Copyright = Program.Copyright,
                    DisplayOptionsWithHyphens = true,
                    MaximumDisplayWidth = System.Console.BufferWidth
                };
                help.AddPreOptionsLine("This is free software. You may redistribute copies of it under the terms of the MIT License <http://www.opensource.org/licenses/mit-license.php>.");

                help.AddPostOptionsLine(" ");

                help.AddOptions(this);
                return help;
            }
        }
    }
}
