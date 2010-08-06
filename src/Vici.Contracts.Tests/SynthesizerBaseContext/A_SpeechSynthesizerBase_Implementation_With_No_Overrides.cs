// --------------------------------------------------------------------------------------------------------------------
// <copyright file="A_SpeechSynthesizerBase_Implementation_With_No_Overrides.cs" company="Sleepless Monkey Development, Inc.">
//   Copyright © 2010
// </copyright>
// <summary>
//   Defines specifications covering the base implementation of the SpeechSynthesizerBase with a thin implementation
//   layer.
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
namespace Vici.Contracts.Tests.SynthesizerBaseContext
{
    using System;
    using System.Collections;
    using System.Speech.Synthesis;
    using Machine.Specifications;

    public class A_SpeechSynthesizerBase_Implementation_With_No_Overrides
    {
        private static SpeechSynthesizerBase speechSynthesizer;

        private Establish context = () =>
                                        {
                                            speechSynthesizer = new NullSpeechSynthesizer();
                                        };

        private It Should_throw_a_NotImplementedException_when_adding_a_BookmarkReached_event = () =>
                                                                                                    {
                                                                                                        var exception = Catch.Exception(() => speechSynthesizer.BookmarkReached += (sender, e) => { });
                                                                                                        exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                    };

        private It Should_throw_a_NotImplementedException_when_removing_a_BookmarkReached_event = () =>
                                                                                                    {
                                                                                                        var exception = Catch.Exception(() => speechSynthesizer.BookmarkReached -= (sender, e) => { });
                                                                                                        exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                    };

        private It Should_throw_a_NotImplementedException_when_adding_a_PhonemeReached_event = () =>
                                                                                                    {
                                                                                                        var exception = Catch.Exception(() => speechSynthesizer.PhonemeReached += (sender, e) => { });
                                                                                                        exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                    };

        private It Should_throw_a_NotImplementedException_when_removing_a_PhonemeReached_event = () =>
                                                                                                     {
                                                                                                         var exception = Catch.Exception(() => speechSynthesizer.PhonemeReached -= (sender, e) => { });
                                                                                                         exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                     };

        private It Should_throw_a_NotImplementedException_when_adding_a_SpeakCompleted_event = () =>
                                                                                                   {
                                                                                                       var exception = Catch.Exception(() => speechSynthesizer.SpeakCompleted += (sender, e) => { });
                                                                                                       exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                   };

        private It Should_throw_a_NotImplementedException_when_removing_a_SpeakCompleted_event = () =>
                                                                                                     {
                                                                                                         var exception = Catch.Exception(() => speechSynthesizer.SpeakCompleted -= (sender, e) => { });
                                                                                                         exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                     };

        private It Should_throw_a_NotImplementedException_when_adding_a_SpeakProgress_event = () =>
                                                                                                  {
                                                                                                      var exception = Catch.Exception(() => speechSynthesizer.SpeakProgress += (sender, e) => { });
                                                                                                      exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                  };

        private It Should_throw_a_NotImplementedException_when_removing_a_SpeakProgress_event = () =>
                                                                                                    {
                                                                                                        var exception = Catch.Exception(() => speechSynthesizer.SpeakProgress -= (sender, e) => { });
                                                                                                        exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                    };

        private It Should_throw_a_NotImplementedException_when_adding_a_SpeakStarted_event = () =>
                                                                                                 {
                                                                                                     var exception = Catch.Exception(() => speechSynthesizer.SpeakStarted += (s, e) => { });
                                                                                                     exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                 };

        private It Should_throw_a_NotImplementedException_when_removing_a_SpeakStarted_event = () =>
                                                                                                   {
                                                                                                       var exception = Catch.Exception(() => speechSynthesizer.SpeakStarted -= (s, e) => { });
                                                                                                       exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                   };

        private It Should_throw_a_NotImplementedException_when_adding_a_StateChanged_event = () =>
                                                                                                 {
                                                                                                     var exception = Catch.Exception(() => speechSynthesizer.StateChanged += (s, e) => { });
                                                                                                     exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                 };

        private It Should_throw_a_NotImplementedException_when_removing_a_StateChanged_event = () =>
                                                                                                   {
                                                                                                       var exception = Catch.Exception(() => speechSynthesizer.StateChanged -= (s, e) => { });
                                                                                                       exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                   };

        private It Should_throw_a_NotImplementedException_when_adding_a_VisimeReached_event = () =>
                                                                                                  {
                                                                                                      var exception = Catch.Exception(() => speechSynthesizer.VisemeReached += (s, e) => { });
                                                                                                      exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                  };

        private It Should_throw_a_NotImplementedException_when_removing_a_VisimeReached_event = () =>
                                                                                                    {
                                                                                                        var exception = Catch.Exception(() => speechSynthesizer.VisemeReached -= (s, e) => { });
                                                                                                        exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                    };

        private It Should_throw_a_NotImplementedException_when_adding_a_VoiceChange_event = () =>
                                                                                                {
                                                                                                    var exception = Catch.Exception(() => speechSynthesizer.VoiceChange += (s, e) => { });
                                                                                                    exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                };

        private It Should_throw_a_NotImplementedException_when_removing_a_VoiceChange_event = () =>
                                                                                                  {
                                                                                                      var exception = Catch.Exception(() => speechSynthesizer.VoiceChange -= (s, e) => { });
                                                                                                      exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                  };

        private It Should_throw_a_NotImplementedException_when_setting_the_Rate = () =>
                                                                                      {
                                                                                          var exception = Catch.Exception(() => speechSynthesizer.Rate = 0);
                                                                                          exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                      };

        private It Should_throw_a_NotImplementedException_when_getting_the_Rate = () =>
                                                                                      {
                                                                                          var exception = Catch.Exception(() => { var rate = speechSynthesizer.Rate; });
                                                                                          exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                      };

        private It Should_throw_a_NotImplementedException_when_getting_the_State = () =>
                                                                                       {
                                                                                           var exception = Catch.Exception(() => { var state = speechSynthesizer.State; });
                                                                                           exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                       };

        private It Should_throw_a_NotImplementedException_when_getting_the_Voice = () =>
                                                                                       {
                                                                                           var exception = Catch.Exception(() => { var voice = speechSynthesizer.Voice; });
                                                                                           exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                       };

        private It Should_throw_a_NotImplementedException_when_setting_the_Volume = () =>
                                                                                        {
                                                                                            var exception = Catch.Exception(() => { speechSynthesizer.Volume = 100; });
                                                                                            exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                        };

        private It Should_throw_a_NotImplementedException_when_getting_the_Volume = () =>
                                                                                        {
                                                                                            var exception = Catch.Exception(() => { var volume = speechSynthesizer.Volume; });
                                                                                            exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                        };

        private It Should_throw_a_NotImplementedException_when_calling_Dispose = () =>
                                                                                     {
                                                                                         var exception = Catch.Exception(() => speechSynthesizer.Dispose());
                                                                                         exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                     };

        private It Should_throw_a_NotImplementedException_when_calling_GetCurrentlySpokenPrompt = () =>
                                                                                                      {
                                                                                                          var exception = Catch.Exception(() => speechSynthesizer.GetCurrentlySpokenPrompt());
                                                                                                          exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                      };

        private It Should_throw_a_NotImplementedException_when_calling_GetInstalledVoices = () =>
                                                                                                {
                                                                                                    var exception = Catch.Exception(() => speechSynthesizer.GetInstalledVoices());
                                                                                                    exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                };

        private It Should_throw_a_NotImplementedException_when_calling_Pause = () =>
                                                                                   {
                                                                                       var exception = Catch.Exception(() => speechSynthesizer.Pause());
                                                                                       exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                   };

        private It Should_throw_a_NotImplementedException_when_calling_Resume = () =>
                                                                                    {
                                                                                        var exception = Catch.Exception(() => speechSynthesizer.Resume());
                                                                                        exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                    };

        private It Should_throw_a_NotImplementedException_when_calling_SetOutputToDefaultAudioDevice = () =>
                                                                                                           {
                                                                                                               var exception = Catch.Exception(() => speechSynthesizer.SetOutputToDefaultAudioDevice());
                                                                                                               exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                           };

        private It Should_throw_a_NotImplementedException_when_calling_AddLexicon = () =>
                                                                                        {
                                                                                            var exception = Catch.Exception(() => speechSynthesizer.AddLexicon(null, null));
                                                                                            exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                        };

        private It Should_throw_a_NotImplementedException_when_calling_GetInstalledVoices_with_culture = () =>
                                                                                                {
                                                                                                    var exception = Catch.Exception(() => speechSynthesizer.GetInstalledVoices(null));
                                                                                                    exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                };

        private It Should_throw_a_NotImplementedException_when_calling_RemoveLexicon = () =>
                                                                                           {
                                                                                               var exception = Catch.Exception(() => speechSynthesizer.RemoveLexicon(null));
                                                                                               exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                           };

        private It Should_throw_a_NotImplementedException_when_calling_SelectVoice = () =>
                                                                                         {
                                                                                             var exception = Catch.Exception(() => speechSynthesizer.SelectVoice(null));
                                                                                             exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                         };

        private It Should_throw_a_NotImplementedException_when_calling_SelectVoiceByHints_with_VoiceGender = () =>
                                                                                                {
                                                                                                    var exception = Catch.Exception(() => speechSynthesizer.SelectVoiceByHints(VoiceGender.NotSet));
                                                                                                    exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                };

        private It Should_throw_a_NotImplementedException_when_calling_SelectVoiceByHints_with_VoiceGender_and_age = () =>
                                                                                                                         {
                                                                                                                             var exception = Catch.Exception(() => speechSynthesizer.SelectVoiceByHints(VoiceGender.NotSet, VoiceAge.NotSet));
                                                                                                                             exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                                         };

        private It Should_throw_a_NotImplementedException_when_calling_SelectVoiceByHints_with_VoiceGender_age_and_alternative = () =>
                                                                                                                                     {
                                                                                                                                         var exception = Catch.Exception(() => speechSynthesizer.SelectVoiceByHints(VoiceGender.NotSet, VoiceAge.NotSet, 0));
                                                                                                                                         exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                                                     };

        private It Should_throw_a_NotImplementedException_when_calling_SelectVoiceByHints_with_VoiceGender_age_alternative_and_culture = () =>
                                                                                                                                             {
                                                                                                                                                 var exception = Catch.Exception(() => speechSynthesizer.SelectVoiceByHints(VoiceGender.NotSet, VoiceAge.NotSet, 0, null));
                                                                                                                                                 exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                                                             };

        private It Should_throw_a_NotImplementedException_when_calling_SetOutputToAudioStream = () =>
                                                                                                    {
                                                                                                        var exception = Catch.Exception(() => speechSynthesizer.SetOutputToAudioStream(null, null));
                                                                                                        exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                    };

        private It Should_throw_a_NotImplementedException_when_calling_SetOutputToNull = () =>
                                                                                             {
                                                                                                 var exception = Catch.Exception(() => speechSynthesizer.SetOutputToNull());
                                                                                                 exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                             };

        private It Should_throw_a_NotImplementedException_when_calling_SetOutputToWaveFile_with_Path = () =>
                                                                                                           {
                                                                                                               var exception = Catch.Exception(() => speechSynthesizer.SetOutputToWaveFile(null));
                                                                                                               exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                           };

        private It Should_throw_a_NotImplementedException_when_calling_SetOutputToWaveFile_with_Path_and_format = () =>
                                                                                                                      {
                                                                                                                          var exception = Catch.Exception(() => speechSynthesizer.SetOutputToWaveFile(null, null));
                                                                                                                          exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                                      };

        private It Should_throw_a_NotImplementedException_when_calling_SetOutputToWaveStream = () =>
                                                                                                   {
                                                                                                       var exception = Catch.Exception(() => speechSynthesizer.SetOutputToWaveStream(null));
                                                                                                       exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                   };

        private It Should_throw_a_NotImplementedException_when_calling_Speak_with_Prompt = () =>
                                                                                               {
                                                                                                   var exception = Catch.Exception(() => speechSynthesizer.Speak((Prompt)null));
                                                                                                   exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                               };

        private It Should_throw_a_NotImplementedException_when_calling_Speak_with_PromptBuilder = () =>
                                                                                                      {
                                                                                                          var exception = Catch.Exception(() => speechSynthesizer.Speak((PromptBuilder)null));
                                                                                                          exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                      };

        private It Should_throw_a_NotImplementedException_when_calling_Speak_with_string = () =>
                                                                                               {
                                                                                                   var exception = Catch.Exception(() => speechSynthesizer.Speak(string.Empty));
                                                                                                   exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                               };

        private It Should_throw_a_NotImplementedException_when_calling_SpeakAsync_with_Prompt = () =>
                                                                                                    {
                                                                                                        var exception = Catch.Exception(() => speechSynthesizer.SpeakAsync((Prompt)null));
                                                                                                        exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                    };

        private It Should_throw_a_NotImplementedException_when_calling_SpeakAsync_with_PromptBuilder = () =>
                                                                                                           {
                                                                                                               var exception = Catch.Exception(() => speechSynthesizer.SpeakAsync((PromptBuilder)null));
                                                                                                               exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                           };

        private It Should_throw_a_NotImplementedException_when_calling_SpeakAsync_with_string = () =>
                                                                                                    {
                                                                                                        var exception = Catch.Exception(() => speechSynthesizer.SpeakAsync(string.Empty));
                                                                                                        exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                    };

        private It Should_throw_a_NotImplementedException_when_calling_SpeakAsyncCancel = () =>
                                                                                              {
                                                                                                  var exception = Catch.Exception(() => speechSynthesizer.SpeakAsyncCancel(null));
                                                                                                  exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                              };

        private It Should_throw_a_NotImplementedException_when_calling_SpeakAsyncCancelAll = () =>
                                                                                                 {
                                                                                                     var exception = Catch.Exception(() => speechSynthesizer.SpeakAsyncCancelAll());
                                                                                                     exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                                 };

        private It Should_throw_a_NotImplementedException_when_calling_SpeakSsml = () =>
                                                                                       {
                                                                                           var exception = Catch.Exception(() => speechSynthesizer.SpeakSsml(string.Empty));
                                                                                           exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                       };

        private It Should_throw_a_NotImplementedException_when_calling_SpeakSsmlAsync = () =>
                                                                                            {
                                                                                                var exception = Catch.Exception(() => speechSynthesizer.SpeakSsmlAsync(string.Empty));
                                                                                                exception.ShouldBeOfType(typeof(NotImplementedException));
                                                                                            };
    }
}