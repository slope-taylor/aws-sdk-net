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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a local gateway.
    /// </summary>
    public partial class LocalGateway
    {
        private string _localGatewayId;
        private string _outpostArn;
        private string _ownerId;
        private string _state;

        /// <summary>
        /// Gets and sets the property LocalGatewayId. 
        /// <para>
        /// The ID of the local gateway.
        /// </para>
        /// </summary>
        public string LocalGatewayId
        {
            get { return this._localGatewayId; }
            set { this._localGatewayId = value; }
        }

        // Check to see if LocalGatewayId property is set
        internal bool IsSetLocalGatewayId()
        {
            return this._localGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost.
        /// </para>
        /// </summary>
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the AWS account ID that owns the local gateway.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the local gateway.
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}