﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="When_Adding_A_New_Zone_With_No_Name_To_A_ViciEngine.cs" company="Sleepless Monkey Development, Inc.">
//   Copyright © 2010
// </copyright>
// <summary>
//   Defines the When_Creating_A_New_Engine type.
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
namespace Vici.Core.Tests.Engine
{
    using System;
    using Contracts;
    using Machine.Specifications;

    [Subject(typeof(ViciEngine))]
    public class When_Adding_A_New_Zone_With_No_Name_To_A_ViciEngine : New_ViciEngine_Context
    {
        private static Exception Exception;

        private Because Of = () =>
            {
                var speechSynthesizerMock = new Moq.Mock<SpeechSynthesizerBase>();
                var zone = new Zone(speechSynthesizerMock.Object);
                Exception = Catch.Exception(() => viciEngine.AddZone(zone));
            };

        private It Should_throw_an_error = () => Exception.ShouldBeOfType(typeof(ArgumentException));

        private It Should_have_an_error_message_about_the_name = () => Exception.Message.ShouldContain("Name");
    }
}