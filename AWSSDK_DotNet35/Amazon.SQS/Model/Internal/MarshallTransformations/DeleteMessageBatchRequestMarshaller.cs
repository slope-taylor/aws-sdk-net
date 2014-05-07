/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SQS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.SQS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteMessageBatch Request Marshaller
    /// </summary>       
    internal class DeleteMessageBatchRequestMarshaller : IMarshaller<IRequest, DeleteMessageBatchRequest>
    {
        public IRequest Marshall(DeleteMessageBatchRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SQS");
            request.Parameters.Add("Action", "DeleteMessageBatch");
            request.Parameters.Add("Version", "2012-11-05");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetEntries())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.Entries)
                    {
                        if(publicRequestlistValue.IsSetId())
                        {
                            request.Parameters.Add("DeleteMessageBatchRequestEntry" + "." + publicRequestlistValueIndex + "." + "Id", StringUtils.FromString(publicRequestlistValue.Id));
                        }
                        if(publicRequestlistValue.IsSetReceiptHandle())
                        {
                            request.Parameters.Add("DeleteMessageBatchRequestEntry" + "." + publicRequestlistValueIndex + "." + "ReceiptHandle", StringUtils.FromString(publicRequestlistValue.ReceiptHandle));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetQueueUrl())
                {
                    request.Parameters.Add("QueueUrl", StringUtils.FromString(publicRequest.QueueUrl));
                }
            }
            return request;
        }
    }
}