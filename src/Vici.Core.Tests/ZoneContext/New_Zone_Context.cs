// --------------------------------------------------------------------------------------------------------------------
// <copyright file="New_Zone_Context.cs" company="Sleepless Monkey Development, Inc.">
//   Copyright � 2010
// </copyright>
// <summary>
//   Defines the New_Zone_Context type.
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

#pragma warning disable 169
// ReSharper disable InconsistentNaming
// ReSharper disable InvokeAsExtensionMethod
namespace Vici.Core.Tests.ZoneContext
{
    using Contracts;
    using Machine.Specifications;

    public class New_Zone_Context
    {
        protected static IZone zone;
        protected static Moq.Mock<SpeechSynthesizerBase> speechSynthesizerMock;

        private Establish context = () =>
        {
            speechSynthesizerMock = new Moq.Mock<SpeechSynthesizerBase>();
            zone = new Zone(speechSynthesizerMock.Object) { Name = "new zone" };
        };

    }
}