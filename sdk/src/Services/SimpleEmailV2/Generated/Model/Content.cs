/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that represents the content of the email, and optionally a character set
    /// specification.
    /// </summary>
    public partial class Content
    {
        private string _charset;
        private string _data;

        /// <summary>
        /// Gets and sets the property Charset. 
        /// <para>
        /// The character set for the content. Because of the constraints of the SMTP protocol,
        /// the Amazon SES API v2 uses 7-bit ASCII by default. If the text includes characters
        /// outside of the ASCII range, you have to specify a character set. For example, you
        /// could specify <code>UTF-8</code>, <code>ISO-8859-1</code>, or <code>Shift_JIS</code>.
        /// </para>
        /// </summary>
        public string Charset
        {
            get { return this._charset; }
            set { this._charset = value; }
        }

        // Check to see if Charset property is set
        internal bool IsSetCharset()
        {
            return this._charset != null;
        }

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The content of the message itself.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

    }
}