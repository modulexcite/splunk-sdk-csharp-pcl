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

namespace Splunk.ModularInputs
{
    using System.Xml.Serialization;

    /// <summary>
    /// Enumeration of the valid values for the Scheme Streaming Mode.
    /// </summary>
    public enum StreamingMode
    {
        /// <summary>
        /// An XML object that is part of a stream of data to Splunk.
        /// </summary>
        [XmlEnum(Name = "xml")]
        Xml,

        /// <summary>
        /// A plain-text modular input.
        /// </summary>
        [XmlEnum(Name = "simple")]
        Simple
    }
}
