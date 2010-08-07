// --------------------------------------------------------------------------------------------------------------------
// <copyright file="The_SpeechSynthesizerWrapper_class.cs" company="Sleepless Monkey Development, Inc.">
//   Copyright © 2010
// </copyright>
// <summary>
//   Specifications of the SpeechSynthesizerWrapper class.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Globalization;
using System.IO;
using System.Linq;
using System.Speech.AudioFormat;
using System.Text;

#pragma warning disable 169
// ReSharper disable InconsistentNaming
// ReSharper disable InvokeAsExtensionMethod
namespace Vici.Core.Tests.SpeechSynthesizerWrapperContext
{
    using System;
    using System.Speech.Synthesis;
    using Machine.Specifications;

    /// <summary>
    /// Provides specifications over the <see cref="SpeechSynthesizerWrapper"/>.
    /// </summary>
    /// <remarks>
    /// Since the base abstraction class throws exceptions, verifying that no exception is thrown is the closest we can come to testing that methods are at least overridden.
    /// </remarks>
    [Subject(typeof(SpeechSynthesizerWrapper))]
    [Tags("Integration")]
    public class The_SpeechSynthesizerWrapper_class
    {
        private static SpeechSynthesizerWrapper speechSynthesizerWrapper;
        private static SpeechSynthesizer speechSynthesizer;

        private Establish context = () =>
                                        {
                                            speechSynthesizer = new SpeechSynthesizer();
                                            speechSynthesizerWrapper = new SpeechSynthesizerWrapper(speechSynthesizer);
                                        };

        private It Can_set_the_volume = () => Catch.Exception(() => speechSynthesizerWrapper.Volume = 100).ShouldBeNull();

        private It Can_get_the_volume = () => Catch.Exception(() => { var volume = speechSynthesizerWrapper.Volume; }).ShouldBeNull();

        private It Can_get_the_rate = () => Catch.Exception(() => { var rate = speechSynthesizerWrapper.Rate; }).ShouldBeNull();

        private It Can_set_the_rate = () => Catch.Exception(() => speechSynthesizerWrapper.Rate = 10).ShouldBeNull();

        private It Can_get_the_state = () => Catch.Exception(() => { var state = speechSynthesizerWrapper.State; }).ShouldBeNull();

        private It Can_get_the_voice = () => Catch.Exception(() => { var voice = speechSynthesizerWrapper.Voice; }).ShouldBeNull();

        private It Can_add_BookmarkReached_event = () => Catch.Exception(() => { speechSynthesizerWrapper.BookmarkReached += (s, e) => { }; }).ShouldBeNull();

        private It Can_add_PhonemeReached_event = () => Catch.Exception(() => { speechSynthesizerWrapper.PhonemeReached += (s, e) => { }; }).ShouldBeNull();

        private It Can_add_SpeakCompleted_event = () => Catch.Exception(() => { speechSynthesizerWrapper.SpeakCompleted += (s, e) => { }; }).ShouldBeNull();

        private It Can_add_SpeakProgress_event = () => Catch.Exception(() => { speechSynthesizerWrapper.SpeakProgress += (s, e) => { }; }).ShouldBeNull();

        private It Can_add_SpeakStarted_event = () => Catch.Exception(() => { speechSynthesizerWrapper.SpeakStarted += (s, e) => { }; }).ShouldBeNull();

        private It Can_add_VisemeReached_event = () => Catch.Exception(() => { speechSynthesizerWrapper.VisemeReached += (s, e) => { }; }).ShouldBeNull();

        private It Can_call_GetCurrentlySpoken_Prompt = () => Catch.Exception(() =>
                                                                                  {
                                                                                      var currentlySpokenPrompt = speechSynthesizerWrapper.GetCurrentlySpokenPrompt();
                                                                                  }).ShouldBeNull();

        private It Can_call_GetInstalledVoices = () => Catch.Exception(() =>
                                                                           {
                                                                               var installedVoices = speechSynthesizerWrapper.GetInstalledVoices();
                                                                           }).ShouldBeNull();

        private It Can_call_GetInstalledVoices_with_culture = () => Catch.Exception(() =>
                                                                                        {
                                                                                            var installedVoices = speechSynthesizerWrapper.GetInstalledVoices(CultureInfo.CurrentCulture);
                                                                                        }).ShouldBeNull();

        private It Can_call_Pause = () => Catch.Exception(() => speechSynthesizerWrapper.Pause());

        private It Can_add_StateChanged_event = () => Catch.Exception(() => { speechSynthesizerWrapper.StateChanged += (s, e) => { }; }).ShouldBeNull();

        private It Can_add_VoiceChange_event = () => Catch.Exception(() => { speechSynthesizerWrapper.VoiceChange += (s, e) => { }; }).ShouldBeNull();

        private It Can_call_Resume = () => Catch.Exception(() => speechSynthesizerWrapper.Resume()).ShouldBeNull();

        private It Can_call_SetOutputToDefaultAudioDevice = () => Catch.Exception(() => speechSynthesizerWrapper.SetOutputToDefaultAudioDevice()).ShouldBeNull();

        private It Can_call_SetOutputToNull = () => Catch.Exception(() => speechSynthesizerWrapper.SetOutputToNull()).ShouldBeNull();

        private It Can_remove_BookmarkReached_event = () => Catch.Exception(() => { speechSynthesizerWrapper.BookmarkReached -= (s, e) => { }; }).ShouldBeNull();

        private It Can_remove_PhonemeReached_event = () => Catch.Exception(() => { speechSynthesizerWrapper.PhonemeReached -= (s, e) => { }; }).ShouldBeNull();

        private It Can_remove_SpeakCompleted_event = () => Catch.Exception(() => { speechSynthesizerWrapper.SpeakCompleted -= (s, e) => { }; }).ShouldBeNull();

        private It Can_remove_SpeakProgress_event = () => Catch.Exception(() => { speechSynthesizerWrapper.SpeakProgress -= (s, e) => { }; }).ShouldBeNull();

        private It Can_remove_SpeakStarted_event = () => Catch.Exception(() => { speechSynthesizerWrapper.SpeakStarted -= (s, e) => { }; }).ShouldBeNull();

        private It Can_remove_StateChanged_event = () => Catch.Exception(() => { speechSynthesizerWrapper.StateChanged -= (s, e) => { }; }).ShouldBeNull();

        private It Can_remove_VisemeReached_event = () => Catch.Exception(() => { speechSynthesizerWrapper.VisemeReached -= (s, e) => { }; }).ShouldBeNull();

        private It Can_remove_VoiceChange_event = () =>
                                                      {
                                                          var exception = Catch.Exception(() =>
                                                                                              {
                                                                                                  speechSynthesizerWrapper.VoiceChange -= (s, e) => { };
                                                                                              });
                                                          exception.ShouldBeNull();
                                                      };

        private It Can_call_SpeakAsyncCancelAll = () => Catch.Exception(() => { speechSynthesizerWrapper.SpeakAsyncCancelAll(); }).ShouldBeNull();

        private It Can_call_Speak_with_string = () => Catch.Exception(() =>
                                                                          {
                                                                              speechSynthesizerWrapper.SetOutputToNull();
                                                                              speechSynthesizerWrapper.Speak("test");
                                                                          }).ShouldBeNull();

        private It Can_call_Speak_with_Prompt = () => Catch.Exception(() =>
                                                                          {
                                                                              speechSynthesizerWrapper.SetOutputToNull();
                                                                              speechSynthesizerWrapper.Speak(new Prompt("test"));
                                                                          }).ShouldBeNull();

        private It Can_call_Speak_with_PromptBuilder = () => Catch.Exception(() =>
                                                                                 {
                                                                                     speechSynthesizerWrapper.SetOutputToNull();
                                                                                     var promptBuilder = new PromptBuilder();
                                                                                     promptBuilder.AppendText("test");
                                                                                     speechSynthesizerWrapper.Speak(promptBuilder);
                                                                                 }).ShouldBeNull();

        private It Can_call_SpeakAsync_with_Prompt = () => Catch.Exception(() =>
                                                                               {
                                                                                   speechSynthesizerWrapper.SetOutputToNull();
                                                                                   speechSynthesizerWrapper.SpeakAsync(new Prompt("test"));
                                                                               }).ShouldBeNull();

        private It Can_call_SpeakAsync_with_PromptBuilder = () => Catch.Exception(() =>
                                                                                      {
                                                                                          speechSynthesizerWrapper.SetOutputToNull();
                                                                                          var promptBuilder = new PromptBuilder();
                                                                                          promptBuilder.AppendText("test");
                                                                                          speechSynthesizerWrapper.SpeakAsync(promptBuilder);
                                                                                      }).ShouldBeNull();

        private It Can_call_SpeakAsync_with_text = () => Catch.Exception(() =>
                                                                             {
                                                                                 speechSynthesizerWrapper.SetOutputToNull();
                                                                                 speechSynthesizerWrapper.SpeakAsync("test");
                                                                             }).ShouldBeNull();

        private It Can_call_SpeakSsml = () => Catch.Exception(() =>
                                                                  {
                                                                      speechSynthesizerWrapper.SetOutputToNull();
                                                                      speechSynthesizerWrapper.SpeakSsml(BuildSSML());
                                                                  }).ShouldBeNull();

        private It Can_call_SpeakSsmlAsync = () => Catch.Exception(() =>
                                                                       {
                                                                           speechSynthesizerWrapper.SetOutputToNull();
                                                                           speechSynthesizerWrapper.SpeakSsmlAsync(BuildSSML());
                                                                       }).ShouldBeNull();

        private It Can_call_SpeakAsyncCancel = () => Catch.Exception(() =>
                                                                         {
                                                                             speechSynthesizerWrapper.SetOutputToNull();
                                                                             var speakAsync = speechSynthesizerWrapper.SpeakAsync("test");
                                                                             speechSynthesizerWrapper.SpeakAsyncCancel(speakAsync);
                                                                         }).ShouldBeNull();

        private It Can_call_SelectVoice_with_invalid_voice = () => Catch.Exception(() =>
                                                                    {
                                                                        speechSynthesizerWrapper.SelectVoice("-ALWAYS_INVALID-");
                                                                    }).ShouldBeOfType(typeof(ArgumentException));

        private It Can_call_SelectVoice_with_valid_voice = () => Catch.Exception(() =>
                                                                                     {
                                                                                         var installedVoice = speechSynthesizerWrapper.GetInstalledVoices().First(x => x.Enabled);
                                                                                         speechSynthesizerWrapper.SelectVoice(installedVoice.VoiceInfo.Name);
                                                                                     }).ShouldBeNull();

        private It Can_call_SelectVoiceByHints_with_VoiceGender = () => Catch.Exception(() =>
                                                                                            {
                                                                                                speechSynthesizerWrapper.SelectVoiceByHints(VoiceGender.NotSet);
                                                                                            }).ShouldBeNull();

        private It Can_call_SetOutputToWaveFile_with_Path = () => Catch.Exception(() =>
                                                                                      {
                                                                                          speechSynthesizerWrapper.SpeakAsyncCancelAll();
                                                                                          var tempFileName = Path.GetTempFileName();
                                                                                          speechSynthesizerWrapper.SetOutputToWaveFile(tempFileName);
                                                                                      }).ShouldBeNull();

        private It Can_call_SetOutputToWaveFile_with_Path_and_Format = () => Catch.Exception(() =>
                                                                                                 {
                                                                                                     speechSynthesizerWrapper.SpeakAsyncCancelAll();
                                                                                                     var tempFileName = Path.GetTempFileName();
                                                                                                     speechSynthesizerWrapper.SetOutputToWaveFile(tempFileName, new SpeechAudioFormatInfo(8, AudioBitsPerSample.Sixteen, AudioChannel.Stereo));
                                                                                                 }).ShouldBeNull();

        private It Can_call_SetOutputToWaveStream = () => Catch.Exception(() =>
                                                                              {
                                                                                  speechSynthesizerWrapper.SpeakAsyncCancelAll();
                                                                                  var memoryStream = new MemoryStream();
                                                                                  speechSynthesizerWrapper.SetOutputToWaveStream(memoryStream);
                                                                              }).ShouldBeNull();

        private It Can_call_SetOutputToAudioStream = () => Catch.Exception(() =>
                                                                                {
                                                                                    speechSynthesizerWrapper.SpeakAsyncCancelAll();
                                                                                    var memoryStream = new MemoryStream();
                                                                                    speechSynthesizerWrapper.SetOutputToAudioStream(memoryStream, new SpeechAudioFormatInfo(8, AudioBitsPerSample.Sixteen, AudioChannel.Stereo));
                                                                                }).ShouldBeNull();

        private It Can_call_SelectVoiceByHints_with_VoiceGender_age = () => Catch.Exception(() =>
                                                                                                {
                                                                                                    speechSynthesizerWrapper.SpeakAsyncCancelAll();
                                                                                                    speechSynthesizerWrapper.SelectVoiceByHints(VoiceGender.NotSet, VoiceAge.NotSet);
                                                                                                }).ShouldBeNull();

        private It Can_call_SelectVoiceByHints_with_VoiceGender_age_alternate = () => Catch.Exception(() =>
                                                                                                          {
                                                                                                              speechSynthesizerWrapper.SpeakAsyncCancelAll();
                                                                                                              speechSynthesizerWrapper.SelectVoiceByHints(VoiceGender.NotSet, VoiceAge.NotSet, 0);
                                                                                                          }).ShouldBeNull();

        private It Can_call_SelectVoiceByHints_with_VoiceGender_age_alternate_and_culture = () => Catch.Exception(() =>
                                                                                                                      {
                                                                                                                          speechSynthesizerWrapper.SpeakAsyncCancelAll();
                                                                                                                          speechSynthesizerWrapper.SelectVoiceByHints(VoiceGender.NotSet, VoiceAge.NotSet, 0, CultureInfo.CurrentCulture);
                                                                                                                      }).ShouldBeNull();

        private It Can_call_AddLexicon = () => Catch.Exception(() =>
                                                                   {
                                                                       speechSynthesizerWrapper.AddLexicon(new Uri("http://invalid.domain"), string.Empty);
                                                                   }).ShouldBeNull();

        private It Can_call_RemoveLexicon = () => Catch.Exception(() =>
                                                                      {
                                                                          speechSynthesizerWrapper.RemoveLexicon(new Uri("http://invalid.domain"));
                                                                      }).ShouldBeNull();


        // Ensure this is the last specification called.
        private It Can_call_Dispose = () => Catch.Exception(() =>
                                                                 {
                                                                     speechSynthesizerWrapper.Dispose();
                                                                 }).ShouldBeNull();


        /// <summary>
        /// Sample SSML mark up, found at http://msmvps.com/blogs/williamryan/archive/2007/05/27/speechsynthesizer-speakssml.aspx.
        /// </summary>
        /// <returns>SSML mark up string.</returns>
        private static String BuildSSML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<?xml version=''1.0''?> ");
            sb.Append("<speak version=''1.0'' ");
            sb.Append("xml:lang=''en-US''>");
            sb.Append("<voice gender=''female''>This is a test.</voice>");
            sb.Append(" <voice gender=''female'' variant=''2''>");
            sb.Append("This still isn't close");
            sb.Append(" </voice>");
            sb.Append("<voice name=''EvilDevilCuckoo''>Testing.</voice>");
            sb.Append("</speak>");
            return sb.ToString().Replace("''", '"'.ToString());
        }
    }
}