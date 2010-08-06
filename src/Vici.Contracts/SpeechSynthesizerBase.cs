// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SpeechSynthesizerBase.cs" company="Sleepless Monkey Development, Inc.">
//   Copyright © 2010
// </copyright>
// <summary>
//   The speech synthesizer base class for abstracting calls to speech engine.
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

namespace Vici.Contracts
{
    using System;
    using System.Collections.ObjectModel;
    using System.Globalization;
    using System.IO;
    using System.Speech.AudioFormat;
    using System.Speech.Synthesis;

    /// <summary>
    /// The speech synthesizer base class for abstracting calls to speech engine.
    /// </summary>
    /// <remarks>
    /// Although MSDN documentation isn't very populated, you can see more information at http://msdn.microsoft.com/en-us/library/system.speech.synthesis.speechsynthesizer.aspx.
    /// </remarks>
    public abstract class SpeechSynthesizerBase : IDisposable
    {
        /// <summary>
        /// Occurs when a bookmark is reached in the synthesized speech prompt.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Justification = "This is an abstraction class.  No actual logic should be executed here.")]
        public virtual event EventHandler<BookmarkReachedEventArgs> BookmarkReached
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Occurs when a phoneme is reached.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Justification = "This is an abstraction class.  No actual logic should be executed here.")]
        public virtual event EventHandler<PhonemeReachedEventArgs> PhonemeReached
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Occurs when speech is completed.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Justification = "This is an abstraction class.  No actual logic should be executed here.")]
        public virtual event EventHandler<SpeakCompletedEventArgs> SpeakCompleted
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Occurs when speech progress is updated.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Justification = "This is an abstraction class.  No actual logic should be executed here.")]
        public virtual event EventHandler<SpeakProgressEventArgs> SpeakProgress
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Occurs when new synthesized speech is started.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Justification = "This is an abstraction class.  No actual logic should be executed here.")]
        public virtual event EventHandler<SpeakStartedEventArgs> SpeakStarted
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Occurs when internal state of the synthesis engine is changed.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Justification = "This is an abstraction class.  No actual logic should be executed here.")]
        public virtual event EventHandler<StateChangedEventArgs> StateChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Occurs when a viseme is reached.
        /// </summary>
        /// <remarks>
        /// To read more about visemes, see http://en.wikipedia.org/wiki/Viseme.  Essentially it's the visual representation of the face when making a sound.
        /// </remarks>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Justification = "This is an abstraction class.  No actual logic should be executed here.")]
        public virtual event EventHandler<VisemeReachedEventArgs> VisemeReached
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Occurs when the voice is changed.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Justification = "This is an abstraction class.  No actual logic should be executed here.")]
        public virtual event EventHandler<VoiceChangeEventArgs> VoiceChange
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets or sets the rate at when speech is synthesized.
        /// </summary>
        /// <value>The current rate.</value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Justification = "This is an abstraction class.  No actual logic should be executed here.")]
        public virtual int Rate
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets the current state of the synthesizer.
        /// </summary>
        /// <value>The current state.</value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Justification = "This is an abstraction class.  No actual logic should be executed here.")]
        public virtual SynthesizerState State
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets the current voice used when speaking.
        /// </summary>
        /// <value>The current voice.</value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Justification = "This is an abstraction class.  No actual logic should be executed here.")]
        public virtual VoiceInfo Voice
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Gets or sets the volume at which the engine synthesizes the speech.
        /// </summary>
        /// <value>The volume.</value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Justification = "This is an abstraction class.  No actual logic should be executed here.")]
        public virtual int Volume
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Adds the lexicon.
        /// </summary>
        /// <param name="uri">The URI of the lexicon.</param>
        /// <param name="mediaType">Type of the media.</param>
        public virtual void AddLexicon(Uri uri, string mediaType)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly", Justification = "This is an abstraction class.  No actual logic should be executed here.")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Justification = "This is an abstraction class.  No actual logic should be executed here.")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1816:CallGCSuppressFinalizeCorrectly", Justification = "This is an abstraction class.  No actual logic should be executed here.")]
        public virtual void Dispose()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the currently spoken prompt.
        /// </summary>
        /// <returns>The prompt that is currently being spoken.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "This is how it is defined in the System.Speech BCL.")]
        public virtual Prompt GetCurrentlySpokenPrompt()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the installed voices.
        /// </summary>
        /// <returns>The collection of installed voices.</returns>
        public virtual ReadOnlyCollection<InstalledVoice> GetInstalledVoices()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the installed voices for the specific culture.
        /// </summary>
        /// <param name="culture">The specific culture to get voices for.</param>
        /// <returns>The collection of installed voices for the culture.</returns>
        public virtual ReadOnlyCollection<InstalledVoice> GetInstalledVoices(CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Pauses the speech that is currently being spoken.
        /// </summary>
        public virtual void Pause()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes the lexicon.
        /// </summary>
        /// <param name="uri">The URI of the lexicon.</param>
        public virtual void RemoveLexicon(Uri uri)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Resumes playing the speech that had previously been paused.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Resume", Justification = "This is how it's defined in the System.Speech BCL.")]
        public virtual void Resume()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the current voice to the one based on the <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the voice to change to.</param>
        public virtual void SelectVoice(string name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the current voice to one based on the <paramref name="gender"/>.
        /// </summary>
        /// <param name="gender">The gender of the voice to change to.</param>
        public virtual void SelectVoiceByHints(VoiceGender gender)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the current voice to one based on the <paramref name="gender"/> and <paramref name="age"/>.
        /// </summary>
        /// <param name="gender">The gender of the voice to change to.</param>
        /// <param name="age">The age of the voice.</param>
        public virtual void SelectVoiceByHints(VoiceGender gender, VoiceAge age)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the current voice to one based on the <paramref name="gender"/>, <paramref name="age"/> and <paramref name="voiceAlternate"/>.
        /// </summary>
        /// <param name="gender">The gender of the voice to change to.</param>
        /// <param name="age">The age of the voice.</param>
        /// <param name="voiceAlternate">The voice alternative.</param>
        public virtual void SelectVoiceByHints(VoiceGender gender, VoiceAge age, int voiceAlternate)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the current voice to one based on the <paramref name="gender"/>, <paramref name="age"/>, <paramref name="voiceAlternate"/> and <paramref name="culture"/>.
        /// </summary>
        /// <param name="gender">The gender of the voice to change to.</param>
        /// <param name="age">The age of the voice.</param>
        /// <param name="voiceAlternate">The voice alternate.</param>
        /// <param name="culture">The specific culture to select a voice for.</param>
        public virtual void SelectVoiceByHints(VoiceGender gender, VoiceAge age, int voiceAlternate, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets where synthesized speech is rendered to.  This sets the output to audio stream.
        /// </summary>
        /// <param name="audioDestination">The audio destination.</param>
        /// <param name="formatInfo">The format info for rendering the stream.</param>
        public virtual void SetOutputToAudioStream(Stream audioDestination, SpeechAudioFormatInfo formatInfo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets where synthesized speech is rendered to.  This sets the output to default audio device as configured by the user.
        /// </summary>
        public virtual void SetOutputToDefaultAudioDevice()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets where synthesized speech is rendered to.  This sets the output to a null resource.  This will send all synthesized speech to no audio output.
        /// </summary>
        public virtual void SetOutputToNull()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets where synthesized speech is rendered to.  This sets the output to wave file.
        /// </summary>
        /// <param name="path">The path where to save the wave to.</param>
        public virtual void SetOutputToWaveFile(string path)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets where synthesized speech is rendered to.  This sets the output to wave file.
        /// </summary>
        /// <param name="path">The path where to save the wave to.</param>
        /// <param name="formatInfo">The format info for rendering the file.</param>
        public virtual void SetOutputToWaveFile(string path, SpeechAudioFormatInfo formatInfo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets where synthesized speech is rendered to.  This sets it to a wave stream.
        /// </summary>
        /// <param name="audioDestination">The audio destination.</param>
        public virtual void SetOutputToWaveStream(Stream audioDestination)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Speaks the text as specified via a prompt.
        /// </summary>
        /// <param name="prompt">The populated prompt.</param>
        public virtual void Speak(Prompt prompt)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Speaks the text as specified via a prompt builder.
        /// </summary>
        /// <param name="promptBuilder">The populated prompt builder.</param>
        public virtual void Speak(PromptBuilder promptBuilder)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Speaks the specified string of text.
        /// </summary>
        /// <param name="textToSpeak">The text to speak.</param>
        public virtual void Speak(string textToSpeak)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Speaks the text as specified via a prompt asynchronously.
        /// </summary>
        /// <param name="prompt">The populated prompt.</param>
        public virtual void SpeakAsync(Prompt prompt)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Speaks the text as specified via a prompt builder asynchronously.
        /// </summary>
        /// <param name="promptBuilder">The populated prompt builder.</param>
        /// <returns>The handle of the prompt spoken. It is used when you want to call <see cref="SpeakAsyncCancel(Prompt)"/>.</returns>
        public virtual Prompt SpeakAsync(PromptBuilder promptBuilder)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Speaks the specified string of text asynchronously.
        /// </summary>
        /// <param name="textToSpeak">The text to speak.</param>
        /// <returns>The handle of the prompt spoken. It is used when you want to call <see cref="SpeakAsyncCancel(Prompt)"/>.</returns>
        public virtual Prompt SpeakAsync(string textToSpeak)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cancels the asynchronous speech of the given prompt.
        /// </summary>
        /// <param name="prompt">The prompt to cancel.</param>
        public virtual void SpeakAsyncCancel(Prompt prompt)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cancels all asynchronous speech.
        /// </summary>
        public virtual void SpeakAsyncCancelAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Speaks the text as defined as Speech Synthesis Markup Language.
        /// </summary>
        /// <param name="textToSpeak">The text to speak.</param>
        public virtual void SpeakSsml(string textToSpeak)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Speaks the text asynchronously as defined as Speech Synthesis Markup Language.
        /// </summary>
        /// <param name="textToSpeak">The text to speak.</param>
        /// <returns>The handle of the prompt spoken. It is used when you want to call <see cref="SpeakAsyncCancel(Prompt)"/>.</returns>
        public virtual Prompt SpeakSsmlAsync(string textToSpeak)
        {
            throw new NotImplementedException();
        }
    }
}