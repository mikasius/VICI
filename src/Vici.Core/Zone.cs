﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Zone.cs" company="Sleepless Monkey Development, Inc.">
//   Copyright © 2010
// </copyright>
// <summary>
//   Defines the Zone type.
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

namespace Vici.Core
{
    using System;
    using System.IO;
    using Contracts;

    /// <summary>
    /// A Zone represents an individual physical zone that Vici can interact with.
    /// </summary>
    public class Zone : IZone
    {
        /// <summary>
        /// The backing field for the output stream.
        /// </summary>
        private Stream outputStream;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zone"/> class.
        /// </summary>
        /// <param name="speechSynthesizerBase">The speech synthesizer base.</param>
        public Zone(SpeechSynthesizerBase speechSynthesizerBase)
        {
            this.SpeechSynthesizer = speechSynthesizerBase;
        }

        /// <summary>
        /// Gets or sets the user configured name.
        /// </summary>
        /// <value>The user provided name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets the speech synthesizer specific to this zone.
        /// </summary>
        /// <value>The speech synthesizer.</value>
        public SpeechSynthesizerBase SpeechSynthesizer { get; private set; }

        /// <summary>
        /// Gets or sets the stream where the audio it output to.
        /// </summary>
        /// <value>The output audio stream.</value>
        public Stream OutputStream
        {
            get
            {
                return this.outputStream;
            }

            set
            {
                this.outputStream = value;
                this.SpeechSynthesizer.SetOutputToWaveStream(this.outputStream);
            }
        }
    }
}