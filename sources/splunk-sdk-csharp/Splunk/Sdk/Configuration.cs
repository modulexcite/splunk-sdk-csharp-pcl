﻿/*
 * Copyright 2014 Splunk, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"): you may
 * not use this file except in compliance with the License. You may obtain
 * a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations
 * under the License.
 */

// TODO:
// [ ] Contracts
// [ ] Documentation
// [ ] Properties & Methods

namespace Splunk.Sdk
{
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;

    /// <summary>
    /// Provides a class for manipulating Splunk configuration files.
    /// </summary>
    /// <remarks>
    /// <para><b>References:</b></para>
    /// <list type="number">
    /// <item><description>
    ///     <a href="http://goo.gl/cTdaIH">REST API Reference: Accessing and 
    ///     updating Splunk configurations</a>
    /// </description></item>
    /// <item><description>
    ///     <a href="http://goo.gl/0ELhzV">REST API Reference: Configurations</a>.
    /// </description></item>
    /// </list>
    /// </remarks>
    public class Configuration : EntityCollection<Configuration, ConfigurationStanza>
    {
        #region Constructors

        internal Configuration(Context context, Namespace @namespace, string fileName)
            : base(context, @namespace, new ResourceName(ResourceName.Properties, fileName))
        { }

        public Configuration()
        { }

        #endregion

        #region Methods

        /// <summary>
        /// Removes a configuration stanza.
        /// </summary>
        /// <param name="stanzaName">
        /// Name of a configuration stanza in the current <see cref=
        /// "Configuration"/>.
        /// </param>
        /// <remarks>
        /// This method uses the <a href="http://goo.gl/dpbuhQ">DELETE 
        /// configs/conf-{file}/{name}</a> endpoint to remove the configuration 
        /// stanza identified by <see cref="stanzaName"/>.
        /// </remarks>
        public void RemoveStanza(string stanzaName)
        {
            this.RemoveStanzaAsync(stanzaName).Wait();
        }

        /// <summary>
        /// Asynchronously removes a configuration stanza.
        /// </summary>
        /// <param name="stanzaName">
        /// Name of a configuration stanza in the current <see cref=
        /// "Configuration"/>.
        /// </param>
        /// <remarks>
        /// This method uses the <a href="http://goo.gl/dpbuhQ">DELETE
        /// configs/conf-{file}/{name}</a> endpoint to remove the configuration
        /// stanza identified by <see cref="stanzaName"/>.
        /// </remarks>
        public async Task RemoveStanzaAsync(string stanzaName)
        {
            var entity = new ConfigurationStanza(this.Context, this.Namespace, this.Title, stanzaName);
            await entity.RemoveAsync();
        }

        #endregion
    }
}