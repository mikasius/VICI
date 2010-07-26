// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ViciEngine.cs" company="Sleepless Monkey Development, Inc.">
//   Copyright © 2010
// </copyright>
// <summary>
//   The ViciEngine represents the controlling object that coordinates the entire system.
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
    using System.Collections.Generic;
    using System.Linq;

    using Vici.Contracts;

    /// <summary>
    /// The ViciEngine represents the controlling object that coordinates the entire system.
    /// </summary>
    public class ViciEngine : IViciEngine
    {
        /// <summary>
        /// Field holding the zones associated with this instance.
        /// </summary>
        private IList<IZone> zones;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViciEngine"/> class.
        /// </summary>
        public ViciEngine()
        {
            this.zones = new List<IZone>();
        }

        /// <summary>
        /// Gets the physical zones that Vici is aware of.
        /// </summary>
        /// <value>The zones.</value>
        public IEnumerable<IZone> Zones
        {
            get
            {
                return this.zones;
            }
        }

        /// <summary>
        /// Adds the zone.
        /// </summary>
        /// <param name="zone">The zone to add to the current instance.</param>
        public void AddZone(IZone zone)
        {
            this.zones.Add(zone);
        }
    }
}