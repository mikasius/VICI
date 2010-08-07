// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SpeechSynthesizerWrapper.cs" company="Sleepless Monkey Development, Inc.">
//   Copyright © 2010
// </copyright>
// <summary>
//   Provides a wrapper class over the SpeechSynthesizerBase abstraction class to call the BCL SpeechSynthesizer.
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
    using System.Collections.ObjectModel;
    using System.Globalization;
    using System.IO;
    using System.Speech.AudioFormat;
    using System.Speech.Synthesis;
    using Contracts;

    /// <summary>
    /// The wrapper class over <see cref="SpeechSynthesizerBase"/> to call <see cref="SpeechSynthesizer"/>.
    /// </summary>
    public class SpeechSynthesizerWrapper : SpeechSynthesizerBase
    {
        /// <summary>
        /// Backing field of the actual <see cref="SpeechSynthesizer"/>.
        /// </summary>
        private readonly SpeechSynthesizer speechSynthesizer;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpeechSynthesizerWrapper"/> class.
        /// </summary>
        /// <param name="speechSynthesizer">The speech synthesizer.</param>
        public SpeechSynthesizerWrapper(SpeechSynthesizer speechSynthesizer)
        {
            this.speechSynthesizer = speechSynthesizer;
        }

        /// <summary>
        /// Occurs when a bookmark is reached in the synthesized speech prompt.
        /// </summary>
        public override event EventHandler<BookmarkReachedEventArgs> BookmarkReached
        {
            add
            {
                this.speechSynthesizer.BookmarkReached += value;
            }

            remove
            {
                this.speechSynthesizer.BookmarkReached -= value;
            }
        }

        /// <summary>
        /// Occurs when a phoneme is reached.
        /// </summary>
        public override event EventHandler<PhonemeReachedEventArgs> PhonemeReached
        {
            add
            {
                this.speechSynthesizer.PhonemeReached += value;
            }

            remove
            {
                this.speechSynthesizer.PhonemeReached -= value;
            }
        }

        /// <summary>
        /// Occurs when speech is completed.
        /// </summary>
        public override event EventHandler<SpeakCompletedEventArgs> SpeakCompleted
        {
            add
            {
                this.speechSynthesizer.SpeakCompleted += value;
            }

            remove
            {
                this.speechSynthesizer.SpeakCompleted -= value;
            }
        }

        /// <summary>
        /// Occurs when speech progress is updated.
        /// </summary>
        public override event EventHandler<SpeakProgressEventArgs> SpeakProgress
        {
            add
            {
                this.speechSynthesizer.SpeakProgress += value;
            }

            remove
            {
                this.speechSynthesizer.SpeakProgress -= value;
            }
        }

        /// <summary>
        /// Occurs when new synthesized speech is started.
        /// </summary>
        public override event EventHandler<SpeakStartedEventArgs> SpeakStarted
        {
            add
            {
                this.speechSynthesizer.SpeakStarted += value;
            }

            remove
            {
                this.speechSynthesizer.SpeakStarted -= value;
            }
        }

        /// <summary>
        /// Occurs when internal state of the synthesis engine is changed.
        /// </summary>
        public override event EventHandler<StateChangedEventArgs> StateChanged
        {
            add
            {
                this.speechSynthesizer.StateChanged += value;
            }

            remove
            {
                this.speechSynthesizer.StateChanged -= value;
            }
        }

        /// <summary>
        /// Occurs when a viseme is reached.
        /// </summary>
        /// <remarks>
        /// To read more about visemes, see http://en.wikipedia.org/wiki/Viseme.  Essentially it's the visual representation of the face when making a sound.
        /// </remarks>
        public override event EventHandler<VisemeReachedEventArgs> VisemeReached
        {
            add
            {
                this.speechSynthesizer.VisemeReached += value;
            }

            remove
            {
                this.speechSynthesizer.VisemeReached -= value;
            }
        }

        /// <summary>
        /// Occurs when the voice is changed.
        /// </summary>
        public override event EventHandler<VoiceChangeEventArgs> VoiceChange
        {
            add
            {
                this.speechSynthesizer.VoiceChange += value;
            }

            remove
            {
                this.speechSynthesizer.VoiceChange -= value;
            }
        }

        /// <summary>
        /// Gets or sets the rate at when speech is synthesized.
        /// </summary>
        /// <value>The current rate.</value>
        public override int Rate
        {
            get
            {
                return this.speechSynthesizer.Rate;
            }

            set
            {
                this.speechSynthesizer.Rate = value;
            }
        }

        /// <summary>
        /// Gets the current state of the synthesizer.
        /// </summary>
        /// <value>The current state.</value>
        public override SynthesizerState State
        {
            get
            {
                return this.speechSynthesizer.State;
            }
        }

        /// <summary>
        /// Gets the current voice used when speaking.
        /// </summary>
        /// <value>The current voice.</value>
        public override VoiceInfo Voice
        {
            get
            {
                return this.speechSynthesizer.Voice;
            }
        }

        /// <summary>
        /// Gets or sets the volume at which the engine synthesizes the speech.
        /// </summary>
        /// <value>The volume.</value>
        public override int Volume
        {
            get
            {
                return this.speechSynthesizer.Volume;
            }

            set
            {
                this.speechSynthesizer.Volume = value;
            }
        }

        /// <summary>
        /// Adds the lexicon.
        /// </summary>
        /// <param name="uri">The URI of the lexicon.</param>
        /// <param name="mediaType">Type of the media.</param>
        public override void AddLexicon(Uri uri, string mediaType)
        {
            this.speechSynthesizer.AddLexicon(uri, mediaType);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Justification = "This is a wrapper over SpeechSynthesizer so no additional logic is needed.")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1816:CallGCSuppressFinalizeCorrectly", Justification = "This is a wrapper over SpeechSynthesizer so no additional logic is needed.")]
        public override void Dispose()
        {
            this.speechSynthesizer.Dispose();
        }

        /// <summary>
        /// Gets the currently spoken prompt.
        /// </summary>
        /// <returns>
        /// The prompt that is currently being spoken.
        /// </returns>
        public override Prompt GetCurrentlySpokenPrompt()
        {
            return this.speechSynthesizer.GetCurrentlySpokenPrompt();
        }

        /// <summary>
        /// Gets the installed voices.
        /// </summary>
        /// <returns>The collection of installed voices.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1304:SpecifyCultureInfo", MessageId = "System.Speech.Synthesis.SpeechSynthesizer.GetInstalledVoices", Justification = "This is a wrapper over SpeechSynthesizer so no additional logic is needed.")]
        public override ReadOnlyCollection<InstalledVoice> GetInstalledVoices()
        {
            return this.speechSynthesizer.GetInstalledVoices();
        }

        /// <summary>
        /// Gets the installed voices for the specific culture.
        /// </summary>
        /// <param name="culture">The specific culture to get voices for.</param>
        /// <returns>
        /// The collection of installed voices for the culture.
        /// </returns>
        public override ReadOnlyCollection<InstalledVoice> GetInstalledVoices(CultureInfo culture)
        {
            return this.speechSynthesizer.GetInstalledVoices(culture);
        }

        /// <summary>
        /// Pauses the speech that is currently being spoken.
        /// </summary>
        public override void Pause()
        {
            this.speechSynthesizer.Pause();
        }

        /// <summary>
        /// Removes the lexicon.
        /// </summary>
        /// <param name="uri">The URI of the lexicon.</param>
        public override void RemoveLexicon(Uri uri)
        {
            this.speechSynthesizer.RemoveLexicon(uri);
        }

        /// <summary>
        /// Resumes playing the speech that had previously been paused.
        /// </summary>
        public override void Resume()
        {
            this.speechSynthesizer.Resume();
        }

        /// <summary>
        /// Sets the current voice to the one based on the <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the voice to change to.</param>
        public override void SelectVoice(string name)
        {
            this.speechSynthesizer.SelectVoice(name);
        }

        /// <summary>
        /// Sets the current voice to one based on the <paramref name="gender"/>.
        /// </summary>
        /// <param name="gender">The gender of the voice to change to.</param>
        public override void SelectVoiceByHints(VoiceGender gender)
        {
            this.speechSynthesizer.SelectVoiceByHints(gender);
        }

        /// <summary>
        /// Sets the current voice to one based on the <paramref name="gender"/> and <paramref name="age"/>.
        /// </summary>
        /// <param name="gender">The gender of the voice to change to.</param>
        /// <param name="age">The age of the voice.</param>
        public override void SelectVoiceByHints(VoiceGender gender, VoiceAge age)
        {
            this.speechSynthesizer.SelectVoiceByHints(gender, age);
        }

        /// <summary>
        /// Sets the current voice to one based on the <paramref name="gender"/>, <paramref name="age"/> and <paramref name="voiceAlternate"/>.
        /// </summary>
        /// <param name="gender">The gender of the voice to change to.</param>
        /// <param name="age">The age of the voice.</param>
        /// <param name="voiceAlternate">The voice alternative.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1304:SpecifyCultureInfo", MessageId = "System.Speech.Synthesis.SpeechSynthesizer.SelectVoiceByHints(System.Speech.Synthesis.VoiceGender,System.Speech.Synthesis.VoiceAge,System.Int32)", Justification = "This is a wrapper over SpeechSynthesizer so no additional logic is needed.")]
        public override void SelectVoiceByHints(VoiceGender gender, VoiceAge age, int voiceAlternate)
        {
            this.speechSynthesizer.SelectVoiceByHints(gender, age, voiceAlternate);
        }

        /// <summary>
        /// Sets the current voice to one based on the <paramref name="gender"/>, <paramref name="age"/>, <paramref name="voiceAlternate"/> and <paramref name="culture"/>.
        /// </summary>
        /// <param name="gender">The gender of the voice to change to.</param>
        /// <param name="age">The age of the voice.</param>
        /// <param name="voiceAlternate">The voice alternate.</param>
        /// <param name="culture">The specific culture to select a voice for.</param>
        public override void SelectVoiceByHints(VoiceGender gender, VoiceAge age, int voiceAlternate, CultureInfo culture)
        {
            this.speechSynthesizer.SelectVoiceByHints(gender, age, voiceAlternate, culture);
        }

        /// <summary>
        /// Sets where synthesized speech is rendered to.  This sets the output to audio stream.
        /// </summary>
        /// <param name="audioDestination">The audio destination.</param>
        /// <param name="formatInfo">The format info for rendering the stream.</param>
        public override void SetOutputToAudioStream(Stream audioDestination, SpeechAudioFormatInfo formatInfo)
        {
            this.speechSynthesizer.SetOutputToAudioStream(audioDestination, formatInfo);
        }

        /// <summary>
        /// Sets where synthesized speech is rendered to.  This sets the output to default audio device as configured by the user.
        /// </summary>
        public override void SetOutputToDefaultAudioDevice()
        {
            this.speechSynthesizer.SetOutputToDefaultAudioDevice();
        }

        /// <summary>
        /// Sets where synthesized speech is rendered to.  This sets the output to a null resource.  This will send all synthesized speech to no audio output.
        /// </summary>
        public override void SetOutputToNull()
        {
            this.speechSynthesizer.SetOutputToNull();
        }

        /// <summary>
        /// Sets where synthesized speech is rendered to.  This sets the output to wave file.
        /// </summary>
        /// <param name="path">The path where to save the wave to.</param>
        public override void SetOutputToWaveFile(string path)
        {
            this.speechSynthesizer.SetOutputToWaveFile(path);
        }

        /// <summary>
        /// Sets where synthesized speech is rendered to.  This sets the output to wave file.
        /// </summary>
        /// <param name="path">The path where to save the wave to.</param>
        /// <param name="formatInfo">The format info for rendering the file.</param>
        public override void SetOutputToWaveFile(string path, SpeechAudioFormatInfo formatInfo)
        {
            this.speechSynthesizer.SetOutputToWaveFile(path, formatInfo);
        }

        /// <summary>
        /// Sets where synthesized speech is rendered to.  This sets it to a wave stream.
        /// </summary>
        /// <param name="audioDestination">The audio destination.</param>
        public override void SetOutputToWaveStream(Stream audioDestination)
        {
            this.speechSynthesizer.SetOutputToWaveStream(audioDestination);
        }

        /// <summary>
        /// Speaks the text as specified via a prompt.
        /// </summary>
        /// <param name="prompt">The populated prompt.</param>
        public override void Speak(Prompt prompt)
        {
            this.speechSynthesizer.Speak(prompt);
        }

        /// <summary>
        /// Speaks the text as specified via a prompt builder.
        /// </summary>
        /// <param name="promptBuilder">The populated prompt builder.</param>
        public override void Speak(PromptBuilder promptBuilder)
        {
            this.speechSynthesizer.Speak(promptBuilder);
        }

        /// <summary>
        /// Speaks the specified string of text.
        /// </summary>
        /// <param name="textToSpeak">The text to speak.</param>
        public override void Speak(string textToSpeak)
        {
            this.speechSynthesizer.Speak(textToSpeak);
        }

        /// <summary>
        /// Speaks the text as specified via a prompt asynchronously.
        /// </summary>
        /// <param name="prompt">The populated prompt.</param>
        public override void SpeakAsync(Prompt prompt)
        {
            this.speechSynthesizer.SpeakAsync(prompt);
        }

        /// <summary>
        /// Speaks the text as specified via a prompt builder asynchronously.
        /// </summary>
        /// <param name="promptBuilder">The populated prompt builder.</param>
        /// <returns>
        /// The handle of the prompt spoken. It is used when you want to call <see cref="SpeakAsyncCancel(Prompt)"/>.
        /// </returns>
        public override Prompt SpeakAsync(PromptBuilder promptBuilder)
        {
            return this.speechSynthesizer.SpeakAsync(promptBuilder);
        }

        /// <summary>
        /// Speaks the specified string of text asynchronously.
        /// </summary>
        /// <param name="textToSpeak">The text to speak.</param>
        /// <returns>
        /// The handle of the prompt spoken. It is used when you want to call <see cref="SpeakAsyncCancel(Prompt)"/>.
        /// </returns>
        public override Prompt SpeakAsync(string textToSpeak)
        {
            return this.speechSynthesizer.SpeakAsync(textToSpeak);
        }

        /// <summary>
        /// Cancels the asynchronous speech of the given prompt.
        /// </summary>
        /// <param name="prompt">The prompt to cancel.</param>
        public override void SpeakAsyncCancel(Prompt prompt)
        {
            this.speechSynthesizer.SpeakAsyncCancel(prompt);
        }

        /// <summary>
        /// Cancels all asynchronous speech.
        /// </summary>
        public override void SpeakAsyncCancelAll()
        {
            this.speechSynthesizer.SpeakAsyncCancelAll();
        }

        /// <summary>
        /// Speaks the text as defined as Speech Synthesis Markup Language.
        /// </summary>
        /// <param name="textToSpeak">The text to speak.</param>
        public override void SpeakSsml(string textToSpeak)
        {
            this.speechSynthesizer.SpeakSsml(textToSpeak);
        }

        /// <summary>
        /// Speaks the text asynchronously as defined as Speech Synthesis Markup Language.
        /// </summary>
        /// <param name="textToSpeak">The text to speak.</param>
        /// <returns>
        /// The handle of the prompt spoken. It is used when you want to call <see cref="SpeakAsyncCancel(Prompt)"/>.
        /// </returns>
        public override Prompt SpeakSsmlAsync(string textToSpeak)
        {
            return this.speechSynthesizer.SpeakSsmlAsync(textToSpeak);
        }
    }
}