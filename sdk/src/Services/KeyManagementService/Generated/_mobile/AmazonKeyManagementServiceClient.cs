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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.KeyManagementService.Model;
using Amazon.KeyManagementService.Model.Internal.MarshallTransformations;
using Amazon.KeyManagementService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.KeyManagementService
{
    /// <summary>
    /// Implementation for accessing KeyManagementService
    ///
    /// AWS Key Management Service 
    /// <para>
    /// AWS Key Management Service (AWS KMS) is an encryption and key management web service.
    /// This guide describes the AWS KMS operations that you can call programmatically. For
    /// general information about AWS KMS, see the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/">
    /// <i>AWS Key Management Service Developer Guide</i> </a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// AWS provides SDKs that consist of libraries and sample code for various programming
    /// languages and platforms (Java, Ruby, .Net, macOS, Android, etc.). The SDKs provide
    /// a convenient way to create programmatic access to AWS KMS and other AWS services.
    /// For example, the SDKs take care of tasks such as signing requests (see below), managing
    /// errors, and retrying requests automatically. For more information about the AWS SDKs,
    /// including how to download and install them, see <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// We recommend that you use the AWS SDKs to make programmatic API calls to AWS KMS.
    /// </para>
    ///  
    /// <para>
    /// Clients must support TLS (Transport Layer Security) 1.0. We recommend TLS 1.2. Clients
    /// must also support cipher suites with Perfect Forward Secrecy (PFS) such as Ephemeral
    /// Diffie-Hellman (DHE) or Elliptic Curve Ephemeral Diffie-Hellman (ECDHE). Most modern
    /// systems such as Java 7 and later support these modes.
    /// </para>
    ///  
    /// <para>
    ///  <b>Signing Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// Requests must be signed by using an access key ID and a secret access key. We strongly
    /// recommend that you <i>do not</i> use your AWS account (root) access key ID and secret
    /// key for everyday work with AWS KMS. Instead, use the access key ID and secret access
    /// key for an IAM user. You can also use the AWS Security Token Service to generate temporary
    /// security credentials that you can use to sign requests.
    /// </para>
    ///  
    /// <para>
    /// All AWS KMS operations require <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Logging API Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// AWS KMS supports AWS CloudTrail, a service that logs AWS API calls and related events
    /// for your AWS account and delivers them to an Amazon S3 bucket that you specify. By
    /// using the information collected by CloudTrail, you can determine what requests were
    /// made to AWS KMS, who made the request, when it was made, and so on. To learn more
    /// about CloudTrail, including how to turn it on and find your log files, see the <a
    /// href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/">AWS CloudTrail
    /// User Guide</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Additional Resources</b> 
    /// </para>
    ///  
    /// <para>
    /// For more information about credentials and request signing, see the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/general/latest/gr/aws-security-credentials.html">AWS
    /// Security Credentials</a> - This topic provides general information about the types
    /// of credentials used for accessing AWS.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp.html">Temporary
    /// Security Credentials</a> - This section of the <i>IAM User Guide</i> describes how
    /// to create and use temporary security credentials.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 Signing Process</a> - This set of topics walks you through the process of
    /// signing a request using an access key ID and a secret access key.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Commonly Used API Operations</b> 
    /// </para>
    ///  
    /// <para>
    /// Of the API operations discussed in this guide, the following will prove the most useful
    /// for most applications. You will likely perform operations other than these, such as
    /// creating keys and assigning policies, by using the console.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>Encrypt</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>Decrypt</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKey</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKeyWithoutPlaintext</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonKeyManagementServiceClient : AmazonServiceClient, IAmazonKeyManagementService
    {
        private static IServiceMetadata serviceMetadata = new AmazonKeyManagementServiceMetadata();
        
        #region Constructors

#if NETSTANDARD
    
        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonKeyManagementServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKeyManagementServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKeyManagementServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(AmazonKeyManagementServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKeyManagementServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonKeyManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKeyManagementServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Credentials and an
        /// AmazonKeyManagementServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(AWSCredentials credentials, AmazonKeyManagementServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKeyManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKeyManagementServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKeyManagementServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKeyManagementServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKeyManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKeyManagementServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKeyManagementServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKeyManagementServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CancelKeyDeletion

        internal virtual CancelKeyDeletionResponse CancelKeyDeletion(CancelKeyDeletionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelKeyDeletionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelKeyDeletionResponseUnmarshaller.Instance;

            return Invoke<CancelKeyDeletionResponse>(request, options);
        }


        /// <summary>
        /// Cancels the deletion of a customer master key (CMK). When this operation succeeds,
        /// the key state of the CMK is <code>Disabled</code>. To enable the CMK, use <a>EnableKey</a>.
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about scheduling and canceling deletion of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier for the customer master key (CMK) for which to cancel deletion. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CancelKeyDeletion">REST API Reference for CancelKeyDeletion Operation</seealso>
        public virtual Task<CancelKeyDeletionResponse> CancelKeyDeletionAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CancelKeyDeletionRequest();
            request.KeyId = keyId;
            return CancelKeyDeletionAsync(request, cancellationToken);
        }



        /// <summary>
        /// Cancels the deletion of a customer master key (CMK). When this operation succeeds,
        /// the key state of the CMK is <code>Disabled</code>. To enable the CMK, use <a>EnableKey</a>.
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about scheduling and canceling deletion of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelKeyDeletion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CancelKeyDeletion">REST API Reference for CancelKeyDeletion Operation</seealso>
        public virtual Task<CancelKeyDeletionResponse> CancelKeyDeletionAsync(CancelKeyDeletionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelKeyDeletionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelKeyDeletionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelKeyDeletionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConnectCustomKeyStore

        internal virtual ConnectCustomKeyStoreResponse ConnectCustomKeyStore(ConnectCustomKeyStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConnectCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConnectCustomKeyStoreResponseUnmarshaller.Instance;

            return Invoke<ConnectCustomKeyStoreResponse>(request, options);
        }



        /// <summary>
        /// Connects or reconnects a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a> to its associated AWS CloudHSM cluster.
        /// 
        ///  
        /// <para>
        /// The custom key store must be connected before you can create customer master keys
        /// (CMKs) in the key store or use the CMKs it contains. You can disconnect and reconnect
        /// a custom key store at any time.
        /// </para>
        ///  
        /// <para>
        /// To connect a custom key store, its associated AWS CloudHSM cluster must have at least
        /// one active HSM. To get the number of active HSMs in a cluster, use the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
        /// operation. To add HSMs to the cluster, use the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// The connection process can take an extended amount of time to complete; up to 20 minutes.
        /// This operation starts the connection process, but it does not wait for it to complete.
        /// When it succeeds, this operation quickly returns an HTTP 200 response and a JSON object
        /// with no properties. However, this response does not indicate that the custom key store
        /// is connected. To get the connection state of the custom key store, use the <a>DescribeCustomKeyStores</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// During the connection process, AWS KMS finds the AWS CloudHSM cluster that is associated
        /// with the custom key store, creates the connection infrastructure, connects to the
        /// cluster, logs into the AWS CloudHSM client as the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-concepts.html#concept-kmsuser">
        /// <code>kmsuser</code> crypto user</a> (CU), and rotates its password.
        /// </para>
        ///  
        /// <para>
        /// The <code>ConnectCustomKeyStore</code> operation might fail for various reasons. To
        /// find the reason, use the <a>DescribeCustomKeyStores</a> operation and see the <code>ConnectionErrorCode</code>
        /// in the response. For help interpreting the <code>ConnectionErrorCode</code>, see <a>CustomKeyStoresListEntry</a>.
        /// </para>
        ///  
        /// <para>
        /// To fix the failure, use the <a>DisconnectCustomKeyStore</a> operation to disconnect
        /// the custom key store, correct the error, use the <a>UpdateCustomKeyStore</a> operation
        /// if necessary, and then use <code>ConnectCustomKeyStore</code> again.
        /// </para>
        ///  
        /// <para>
        /// If you are having trouble connecting or disconnecting a custom key store, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html">Troubleshooting
        /// a Custom Key Store</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConnectCustomKeyStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConnectCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInvalidConfigurationException">
        /// The request was rejected because the associated AWS CloudHSM cluster did not meet
        /// the configuration requirements for a custom key store.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The cluster must be configured with private subnets in at least two different Availability
        /// Zones in the Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">security
        /// group for the cluster</a> (cloudhsm-cluster-<i>&lt;cluster-id&gt;</i>-sg) must include
        /// inbound rules and outbound rules that allow TCP traffic on ports 2223-2225. The <b>Source</b>
        /// in the inbound rules and the <b>Destination</b> in the outbound rules must match the
        /// security group ID. These rules are set by default when you create the cluster. Do
        /// not delete or change them. To get information about a particular security group, use
        /// the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSecurityGroups.html">DescribeSecurityGroups</a>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster must contain at least as many HSMs as the operation requires. To add HSMs,
        /// use the AWS CloudHSM <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For the <a>CreateCustomKeyStore</a>, <a>UpdateCustomKeyStore</a>, and <a>CreateKey</a>
        /// operations, the AWS CloudHSM cluster must have at least two active HSMs, each in a
        /// different Availability Zone. For the <a>ConnectCustomKeyStore</a> operation, the AWS
        /// CloudHSM must contain at least one active HSM.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about the requirements for an AWS CloudHSM cluster that is associated
        /// with a custom key store, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
        /// the Prerequisites</a> in the <i>AWS Key Management Service Developer Guide</i>. For
        /// information about creating a private subnet for an AWS CloudHSM cluster, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/create-subnets.html">Create
        /// a Private Subnet</a> in the <i>AWS CloudHSM User Guide</i>. For information about
        /// cluster security groups, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">Configure
        /// a Default Security Group</a> in the <i> <i>AWS CloudHSM User Guide</i> </i>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotActiveException">
        /// The request was rejected because the AWS CloudHSM cluster that is associated with
        /// the custom key store is not active. Initialize and activate the cluster and try the
        /// command again. For detailed instructions, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/getting-started.html">Getting
        /// Started</a> in the <i>AWS CloudHSM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because AWS KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ConnectCustomKeyStore">REST API Reference for ConnectCustomKeyStore Operation</seealso>
        public virtual Task<ConnectCustomKeyStoreResponse> ConnectCustomKeyStoreAsync(ConnectCustomKeyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConnectCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConnectCustomKeyStoreResponseUnmarshaller.Instance;

            return InvokeAsync<ConnectCustomKeyStoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAlias

        internal virtual CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasResponse>(request, options);
        }


        /// <summary>
        /// Creates a display name for a customer managed customer master key (CMK). You can use
        /// an alias to identify a CMK in cryptographic operations, such as <a>Encrypt</a> and
        /// <a>GenerateDataKey</a>. You can change the CMK associated with the alias at any time.
        /// 
        ///  
        /// <para>
        /// Aliases are easier to remember than key IDs. They can also help to simplify your applications.
        /// For example, if you use an alias in your code, you can change the CMK your code uses
        /// by associating a given alias with a different CMK. 
        /// </para>
        ///  
        /// <para>
        /// To run the same code in multiple AWS regions, use an alias in your code, such as <code>alias/ApplicationKey</code>.
        /// Then, in each AWS Region, create an <code>alias/ApplicationKey</code> alias that is
        /// associated with a CMK in that Region. When you run your code, it uses the <code>alias/ApplicationKey</code>
        /// CMK for that AWS Region without any Region-specific code.
        /// </para>
        ///  
        /// <para>
        /// This operation does not return a response. To get the alias that you created, use
        /// the <a>ListAliases</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To use aliases successfully, be aware of the following information.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Each alias points to only one CMK at a time, although a single CMK can have multiple
        /// aliases. The alias and its associated CMK must be in the same AWS account and Region.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can associate an alias with any customer managed CMK in the same AWS account and
        /// Region. However, you do not have permission to associate an alias with an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">AWS
        /// managed CMK</a> or an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-owned-cmk">AWS
        /// owned CMK</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To change the CMK associated with an alias, use the <a>UpdateAlias</a> operation.
        /// The current CMK and the new CMK must be the same type (both symmetric or both asymmetric)
        /// and they must have the same key usage (<code>ENCRYPT_DECRYPT</code> or <code>SIGN_VERIFY</code>).
        /// This restriction prevents cryptographic errors in code that uses aliases.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The alias name must begin with <code>alias/</code> followed by a name, such as <code>alias/ExampleAlias</code>.
        /// It can contain only alphanumeric characters, forward slashes (/), underscores (_),
        /// and dashes (-). The alias name cannot begin with <code>alias/aws/</code>. The <code>alias/aws/</code>
        /// prefix is reserved for <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">AWS
        /// managed CMKs</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The alias name must be unique within an AWS Region. However, you can use the same
        /// alias name in multiple Regions of the same AWS account. Each instance of the alias
        /// is associated with a CMK in its Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you create an alias, you cannot change its alias name. However, you can use
        /// the <a>DeleteAlias</a> operation to delete the alias and then create a new alias with
        /// the desired name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can use an alias name or alias ARN to identify a CMK in AWS KMS cryptographic
        /// operations and in the <a>DescribeKey</a> operation. However, you cannot use alias
        /// names or alias ARNs in API operations that manage CMKs, such as <a>DisableKey</a>
        /// or <a>GetKeyPolicy</a>. For information about the valid CMK identifiers for each AWS
        /// KMS API operation, see the descriptions of the <code>KeyId</code> parameter in the
        /// API operation documentation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Because an alias is not a property of a CMK, you can delete and change the aliases
        /// of a CMK without affecting the CMK. Also, aliases do not appear in the response from
        /// the <a>DescribeKey</a> operation. To get the aliases and alias ARNs of CMKs in each
        /// AWS account and Region, use the <a>ListAliases</a> operation.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="aliasName">Specifies the alias name. This value must begin with <code>alias/</code> followed by a name, such as <code>alias/ExampleAlias</code>. The alias name cannot begin with <code>alias/aws/</code>. The <code>alias/aws/</code> prefix is reserved for AWS managed CMKs.</param>
        /// <param name="targetKeyId">Identifies the CMK to which the alias refers. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. You cannot specify another alias. For help finding the key ID and ARN, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/viewing-keys.html#find-cmk-id-arn">Finding the Key ID and ARN</a> in the <i>AWS Key Management Service Developer Guide</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidAliasNameException">
        /// The request was rejected because the specified alias name is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual Task<CreateAliasResponse> CreateAliasAsync(string aliasName, string targetKeyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateAliasRequest();
            request.AliasName = aliasName;
            request.TargetKeyId = targetKeyId;
            return CreateAliasAsync(request, cancellationToken);
        }



        /// <summary>
        /// Creates a display name for a customer managed customer master key (CMK). You can use
        /// an alias to identify a CMK in cryptographic operations, such as <a>Encrypt</a> and
        /// <a>GenerateDataKey</a>. You can change the CMK associated with the alias at any time.
        /// 
        ///  
        /// <para>
        /// Aliases are easier to remember than key IDs. They can also help to simplify your applications.
        /// For example, if you use an alias in your code, you can change the CMK your code uses
        /// by associating a given alias with a different CMK. 
        /// </para>
        ///  
        /// <para>
        /// To run the same code in multiple AWS regions, use an alias in your code, such as <code>alias/ApplicationKey</code>.
        /// Then, in each AWS Region, create an <code>alias/ApplicationKey</code> alias that is
        /// associated with a CMK in that Region. When you run your code, it uses the <code>alias/ApplicationKey</code>
        /// CMK for that AWS Region without any Region-specific code.
        /// </para>
        ///  
        /// <para>
        /// This operation does not return a response. To get the alias that you created, use
        /// the <a>ListAliases</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To use aliases successfully, be aware of the following information.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Each alias points to only one CMK at a time, although a single CMK can have multiple
        /// aliases. The alias and its associated CMK must be in the same AWS account and Region.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can associate an alias with any customer managed CMK in the same AWS account and
        /// Region. However, you do not have permission to associate an alias with an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">AWS
        /// managed CMK</a> or an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-owned-cmk">AWS
        /// owned CMK</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To change the CMK associated with an alias, use the <a>UpdateAlias</a> operation.
        /// The current CMK and the new CMK must be the same type (both symmetric or both asymmetric)
        /// and they must have the same key usage (<code>ENCRYPT_DECRYPT</code> or <code>SIGN_VERIFY</code>).
        /// This restriction prevents cryptographic errors in code that uses aliases.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The alias name must begin with <code>alias/</code> followed by a name, such as <code>alias/ExampleAlias</code>.
        /// It can contain only alphanumeric characters, forward slashes (/), underscores (_),
        /// and dashes (-). The alias name cannot begin with <code>alias/aws/</code>. The <code>alias/aws/</code>
        /// prefix is reserved for <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">AWS
        /// managed CMKs</a>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The alias name must be unique within an AWS Region. However, you can use the same
        /// alias name in multiple Regions of the same AWS account. Each instance of the alias
        /// is associated with a CMK in its Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// After you create an alias, you cannot change its alias name. However, you can use
        /// the <a>DeleteAlias</a> operation to delete the alias and then create a new alias with
        /// the desired name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can use an alias name or alias ARN to identify a CMK in AWS KMS cryptographic
        /// operations and in the <a>DescribeKey</a> operation. However, you cannot use alias
        /// names or alias ARNs in API operations that manage CMKs, such as <a>DisableKey</a>
        /// or <a>GetKeyPolicy</a>. For information about the valid CMK identifiers for each AWS
        /// KMS API operation, see the descriptions of the <code>KeyId</code> parameter in the
        /// API operation documentation.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Because an alias is not a property of a CMK, you can delete and change the aliases
        /// of a CMK without affecting the CMK. Also, aliases do not appear in the response from
        /// the <a>DescribeKey</a> operation. To get the aliases and alias ARNs of CMKs in each
        /// AWS account and Region, use the <a>ListAliases</a> operation.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidAliasNameException">
        /// The request was rejected because the specified alias name is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomKeyStore

        internal virtual CreateCustomKeyStoreResponse CreateCustomKeyStore(CreateCustomKeyStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomKeyStoreResponseUnmarshaller.Instance;

            return Invoke<CreateCustomKeyStoreResponse>(request, options);
        }



        /// <summary>
        /// Creates a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a> that is associated with an <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/clusters.html">AWS
        /// CloudHSM cluster</a> that you own and manage.
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in AWS KMS, which combines the convenience and extensive
        /// integration of AWS KMS with the isolation and control of a single-tenant key store.
        /// </para>
        ///  
        /// <para>
        /// Before you create the custom key store, you must assemble the required elements, including
        /// an AWS CloudHSM cluster that fulfills the requirements for a custom key store. For
        /// details about the required elements, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
        /// the Prerequisites</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When the operation completes successfully, it returns the ID of the new custom key
        /// store. Before you can use your new custom key store, you need to use the <a>ConnectCustomKeyStore</a>
        /// operation to connect the new key store to its AWS CloudHSM cluster. Even if you are
        /// not going to use your custom key store immediately, you might want to connect it to
        /// verify that all settings are correct and then disconnect it until you are ready to
        /// use it.
        /// </para>
        ///  
        /// <para>
        /// For help with failures, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html">Troubleshooting
        /// a Custom Key Store</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomKeyStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInUseException">
        /// The request was rejected because the specified AWS CloudHSM cluster is already associated
        /// with a custom key store or it shares a backup history with a cluster that is associated
        /// with a custom key store. Each custom key store must be associated with a different
        /// AWS CloudHSM cluster.
        /// 
        ///  
        /// <para>
        /// Clusters that share a backup history have the same cluster certificate. To view the
        /// cluster certificate of a cluster, use the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
        /// operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInvalidConfigurationException">
        /// The request was rejected because the associated AWS CloudHSM cluster did not meet
        /// the configuration requirements for a custom key store.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The cluster must be configured with private subnets in at least two different Availability
        /// Zones in the Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">security
        /// group for the cluster</a> (cloudhsm-cluster-<i>&lt;cluster-id&gt;</i>-sg) must include
        /// inbound rules and outbound rules that allow TCP traffic on ports 2223-2225. The <b>Source</b>
        /// in the inbound rules and the <b>Destination</b> in the outbound rules must match the
        /// security group ID. These rules are set by default when you create the cluster. Do
        /// not delete or change them. To get information about a particular security group, use
        /// the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSecurityGroups.html">DescribeSecurityGroups</a>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster must contain at least as many HSMs as the operation requires. To add HSMs,
        /// use the AWS CloudHSM <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For the <a>CreateCustomKeyStore</a>, <a>UpdateCustomKeyStore</a>, and <a>CreateKey</a>
        /// operations, the AWS CloudHSM cluster must have at least two active HSMs, each in a
        /// different Availability Zone. For the <a>ConnectCustomKeyStore</a> operation, the AWS
        /// CloudHSM must contain at least one active HSM.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about the requirements for an AWS CloudHSM cluster that is associated
        /// with a custom key store, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
        /// the Prerequisites</a> in the <i>AWS Key Management Service Developer Guide</i>. For
        /// information about creating a private subnet for an AWS CloudHSM cluster, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/create-subnets.html">Create
        /// a Private Subnet</a> in the <i>AWS CloudHSM User Guide</i>. For information about
        /// cluster security groups, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">Configure
        /// a Default Security Group</a> in the <i> <i>AWS CloudHSM User Guide</i> </i>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotActiveException">
        /// The request was rejected because the AWS CloudHSM cluster that is associated with
        /// the custom key store is not active. Initialize and activate the cluster and try the
        /// command again. For detailed instructions, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/getting-started.html">Getting
        /// Started</a> in the <i>AWS CloudHSM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotFoundException">
        /// The request was rejected because AWS KMS cannot find the AWS CloudHSM cluster with
        /// the specified cluster ID. Retry the request with a different cluster ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNameInUseException">
        /// The request was rejected because the specified custom key store name is already assigned
        /// to another custom key store in the account. Try again with a custom key store name
        /// that is unique in the account.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.IncorrectTrustAnchorException">
        /// The request was rejected because the trust anchor certificate in the request is not
        /// the trust anchor certificate for the specified AWS CloudHSM cluster.
        /// 
        ///  
        /// <para>
        /// When you <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/initialize-cluster.html#sign-csr">initialize
        /// the cluster</a>, you create the trust anchor certificate and save it in the <code>customerCA.crt</code>
        /// file.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateCustomKeyStore">REST API Reference for CreateCustomKeyStore Operation</seealso>
        public virtual Task<CreateCustomKeyStoreResponse> CreateCustomKeyStoreAsync(CreateCustomKeyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomKeyStoreResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCustomKeyStoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGrant

        internal virtual CreateGrantResponse CreateGrant(CreateGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGrantResponseUnmarshaller.Instance;

            return Invoke<CreateGrantResponse>(request, options);
        }



        /// <summary>
        /// Adds a grant to a customer master key (CMK). The grant allows the grantee principal
        /// to use the CMK when the conditions specified in the grant are met. When setting permissions,
        /// grants are an alternative to key policies. 
        /// 
        ///  
        /// <para>
        /// To create a grant that allows a cryptographic operation only when the request includes
        /// a particular <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">encryption
        /// context</a>, use the <code>Constraints</code> parameter. For details, see <a>GrantConstraints</a>.
        /// </para>
        ///  
        /// <para>
        /// You can create grants on symmetric and asymmetric CMKs. However, if the grant allows
        /// an operation that the CMK does not support, <code>CreateGrant</code> fails with a
        /// <code>ValidationException</code>. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Grants for symmetric CMKs cannot allow operations that are not supported for symmetric
        /// CMKs, including <a>Sign</a>, <a>Verify</a>, and <a>GetPublicKey</a>. (There are limited
        /// exceptions to this rule for legacy operations, but you should not create a grant for
        /// an operation that AWS KMS does not support.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Grants for asymmetric CMKs cannot allow operations that are not supported for asymmetric
        /// CMKs, including operations that <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_GenerateDataKey">generate
        /// data keys</a> or <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_GenerateDataKeyPair">data
        /// key pairs</a>, or operations related to <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// key rotation</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or CMKs in <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key stores</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Grants for asymmetric CMKs with a <code>KeyUsage</code> of <code>ENCRYPT_DECRYPT</code>
        /// cannot allow the <a>Sign</a> or <a>Verify</a> operations. Grants for asymmetric CMKs
        /// with a <code>KeyUsage</code> of <code>SIGN_VERIFY</code> cannot allow the <a>Encrypt</a>
        /// or <a>Decrypt</a> operations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Grants for asymmetric CMKs cannot include an encryption context grant constraint.
        /// An encryption context is not supported on asymmetric CMKs.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about symmetric and asymmetric CMKs, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric CMKs</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// in the value of the <code>KeyId</code> parameter. For more information about grants,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Grants</a>
        /// in the <i> <i>AWS Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateGrant">REST API Reference for CreateGrant Operation</seealso>
        public virtual Task<CreateGrantResponse> CreateGrantAsync(CreateGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGrantResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateKey

        internal virtual CreateKeyResponse CreateKey(CreateKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyResponseUnmarshaller.Instance;

            return Invoke<CreateKeyResponse>(request, options);
        }



        /// <summary>
        /// Creates a unique customer managed <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master-keys">customer
        /// master key</a> (CMK) in your AWS account and Region. You cannot use this operation
        /// to create a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// You can use the <code>CreateKey</code> operation to create symmetric or asymmetric
        /// CMKs.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Symmetric CMKs</b> contain a 256-bit symmetric key that never leaves AWS KMS unencrypted.
        /// To use the CMK, you must call AWS KMS. You can use a symmetric CMK to encrypt and
        /// decrypt small amounts of data, but they are typically used to generate <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#data-keys">data
        /// keys</a> or data key pairs. For details, see <a>GenerateDataKey</a> and <a>GenerateDataKeyPair</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Asymmetric CMKs</b> can contain an RSA key pair or an Elliptic Curve (ECC) key
        /// pair. The private key in an asymmetric CMK never leaves AWS KMS unencrypted. However,
        /// you can use the <a>GetPublicKey</a> operation to download the public key so it can
        /// be used outside of AWS KMS. CMKs with RSA key pairs can be used to encrypt or decrypt
        /// data or sign and verify messages (but not both). CMKs with ECC key pairs can be used
        /// only to sign and verify messages.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about symmetric and asymmetric CMKs, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric CMKs</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To create different types of CMKs, use the following guidance:
        /// </para>
        ///  <dl> <dt>Asymmetric CMKs</dt> <dd> 
        /// <para>
        /// To create an asymmetric CMK, use the <code>CustomerMasterKeySpec</code> parameter
        /// to specify the type of key material in the CMK. Then, use the <code>KeyUsage</code>
        /// parameter to determine whether the CMK will be used to encrypt and decrypt or sign
        /// and verify. You can't change these properties after the CMK is created.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </dd> <dt>Symmetric CMKs</dt> <dd> 
        /// <para>
        /// When creating a symmetric CMK, you don't need to specify the <code>CustomerMasterKeySpec</code>
        /// or <code>KeyUsage</code> parameters. The default value for <code>CustomerMasterKeySpec</code>,
        /// <code>SYMMETRIC_DEFAULT</code>, and the default value for <code>KeyUsage</code>, <code>ENCRYPT_DECRYPT</code>,
        /// are the only valid values for symmetric CMKs. 
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </dd> <dt>Imported Key Material</dt> <dd> 
        /// <para>
        /// To import your own key material, begin by creating a symmetric CMK with no key material.
        /// To do this, use the <code>Origin</code> parameter of <code>CreateKey</code> with a
        /// value of <code>EXTERNAL</code>. Next, use <a>GetParametersForImport</a> operation
        /// to get a public key and import token, and use the public key to encrypt your key material.
        /// Then, use <a>ImportKeyMaterial</a> with your import token to import the key material.
        /// For step-by-step instructions, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i> <i>AWS Key Management Service Developer Guide</i> </i>.
        /// You cannot import the key material into an asymmetric CMK.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </dd> <dt>Custom Key Stores</dt> <dd> 
        /// <para>
        /// To create a symmetric CMK in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>, use the <code>CustomKeyStoreId</code> parameter to specify the custom
        /// key store. You must also use the <code>Origin</code> parameter with a value of <code>AWS_CLOUDHSM</code>.
        /// The AWS CloudHSM cluster that is associated with the custom key store must have at
        /// least two active HSMs in different Availability Zones in the AWS Region. 
        /// </para>
        ///  
        /// <para>
        /// You cannot create an asymmetric CMK in a custom key store. For information about custom
        /// key stores in AWS KMS see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Using
        /// Custom Key Stores</a> in the <i> <i>AWS Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInvalidConfigurationException">
        /// The request was rejected because the associated AWS CloudHSM cluster did not meet
        /// the configuration requirements for a custom key store.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The cluster must be configured with private subnets in at least two different Availability
        /// Zones in the Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">security
        /// group for the cluster</a> (cloudhsm-cluster-<i>&lt;cluster-id&gt;</i>-sg) must include
        /// inbound rules and outbound rules that allow TCP traffic on ports 2223-2225. The <b>Source</b>
        /// in the inbound rules and the <b>Destination</b> in the outbound rules must match the
        /// security group ID. These rules are set by default when you create the cluster. Do
        /// not delete or change them. To get information about a particular security group, use
        /// the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSecurityGroups.html">DescribeSecurityGroups</a>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster must contain at least as many HSMs as the operation requires. To add HSMs,
        /// use the AWS CloudHSM <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For the <a>CreateCustomKeyStore</a>, <a>UpdateCustomKeyStore</a>, and <a>CreateKey</a>
        /// operations, the AWS CloudHSM cluster must have at least two active HSMs, each in a
        /// different Availability Zone. For the <a>ConnectCustomKeyStore</a> operation, the AWS
        /// CloudHSM must contain at least one active HSM.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about the requirements for an AWS CloudHSM cluster that is associated
        /// with a custom key store, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
        /// the Prerequisites</a> in the <i>AWS Key Management Service Developer Guide</i>. For
        /// information about creating a private subnet for an AWS CloudHSM cluster, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/create-subnets.html">Create
        /// a Private Subnet</a> in the <i>AWS CloudHSM User Guide</i>. For information about
        /// cluster security groups, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">Configure
        /// a Default Security Group</a> in the <i> <i>AWS CloudHSM User Guide</i> </i>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because AWS KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.TagException">
        /// The request was rejected because one or more tags are not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateKey">REST API Reference for CreateKey Operation</seealso>
        public virtual Task<CreateKeyResponse> CreateKeyAsync(CreateKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Decrypt

        internal virtual DecryptResponse Decrypt(DecryptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecryptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecryptResponseUnmarshaller.Instance;

            return Invoke<DecryptResponse>(request, options);
        }



        /// <summary>
        /// Decrypts ciphertext that was encrypted by a AWS KMS customer master key (CMK) using
        /// any of the following operations:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyWithoutPlaintext</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPairWithoutPlaintext</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can use this operation to decrypt ciphertext that was encrypted under a symmetric
        /// or asymmetric CMK. When the CMK is asymmetric, you must specify the CMK and the encryption
        /// algorithm that was used to encrypt the ciphertext. For information about symmetric
        /// and asymmetric CMKs, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric CMKs</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The Decrypt operation also decrypts ciphertext that was encrypted outside of AWS KMS
        /// by the public key in an AWS KMS asymmetric CMK. However, it cannot decrypt ciphertext
        /// produced by other libraries, such as the <a href="https://docs.aws.amazon.com/encryption-sdk/latest/developer-guide/">AWS
        /// Encryption SDK</a> or <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingClientSideEncryption.html">Amazon
        /// S3 client-side encryption</a>. These libraries return a ciphertext format that is
        /// incompatible with AWS KMS.
        /// </para>
        ///  
        /// <para>
        /// If the ciphertext was encrypted under a symmetric CMK, you do not need to specify
        /// the CMK or the encryption algorithm. AWS KMS can get this information from metadata
        /// that it adds to the symmetric ciphertext blob. However, if you prefer, you can specify
        /// the <code>KeyId</code> to ensure that a particular CMK is used to decrypt the ciphertext.
        /// If you specify a different CMK than the one used to encrypt the ciphertext, the <code>Decrypt</code>
        /// operation fails.
        /// </para>
        ///  
        /// <para>
        /// Whenever possible, use key policies to give users permission to call the Decrypt operation
        /// on a particular CMK, instead of using IAM policies. Otherwise, you might create an
        /// IAM user policy that gives the user Decrypt permission on all CMKs. This user could
        /// decrypt ciphertext that was encrypted by CMKs in other accounts if the key policy
        /// for the cross-account CMK permits it. If you must use an IAM policy for <code>Decrypt</code>
        /// permissions, limit the user to particular CMKs or particular trusted accounts.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Decrypt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Decrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.IncorrectKeyException">
        /// The request was rejected because the specified CMK cannot decrypt the data. The <code>KeyId</code>
        /// in a <a>Decrypt</a> request and the <code>SourceKeyId</code> in a <a>ReEncrypt</a>
        /// request must identify the same CMK that was used to encrypt the ciphertext.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// From the <a>Decrypt</a> or <a>ReEncrypt</a> operation, the request was rejected because
        /// the specified ciphertext, or additional authenticated data incorporated into the ciphertext,
        /// such as the encryption context, is corrupted, missing, or otherwise invalid.
        /// 
        ///  
        /// <para>
        /// From the <a>ImportKeyMaterial</a> operation, the request was rejected because AWS
        /// KMS could not decrypt the encrypted (wrapped) key material. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the CMK is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the CMK <code>(CustomerMasterKeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a CMK, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular CMK, use the
        /// <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified CMK was not available. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Decrypt">REST API Reference for Decrypt Operation</seealso>
        public virtual Task<DecryptResponse> DecryptAsync(DecryptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecryptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecryptResponseUnmarshaller.Instance;

            return InvokeAsync<DecryptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAlias

        internal virtual DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAliasResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified alias. You cannot perform this operation on an alias in a different
        /// AWS account. 
        /// 
        ///  
        /// <para>
        /// Because an alias is not a property of a CMK, you can delete and change the aliases
        /// of a CMK without affecting the CMK. Also, aliases do not appear in the response from
        /// the <a>DescribeKey</a> operation. To get the aliases of all CMKs, use the <a>ListAliases</a>
        /// operation. 
        /// </para>
        ///  
        /// <para>
        /// Each CMK can have multiple aliases. To change the alias of a CMK, use <a>DeleteAlias</a>
        /// to delete the current alias and <a>CreateAlias</a> to create a new alias. To associate
        /// an existing alias with a different customer master key (CMK), call <a>UpdateAlias</a>.
        /// </para>
        /// </summary>
        /// <param name="aliasName">The alias to be deleted. The alias name must begin with <code>alias/</code> followed by the alias name, such as <code>alias/ExampleAlias</code>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual Task<DeleteAliasResponse> DeleteAliasAsync(string aliasName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteAliasRequest();
            request.AliasName = aliasName;
            return DeleteAliasAsync(request, cancellationToken);
        }



        /// <summary>
        /// Deletes the specified alias. You cannot perform this operation on an alias in a different
        /// AWS account. 
        /// 
        ///  
        /// <para>
        /// Because an alias is not a property of a CMK, you can delete and change the aliases
        /// of a CMK without affecting the CMK. Also, aliases do not appear in the response from
        /// the <a>DescribeKey</a> operation. To get the aliases of all CMKs, use the <a>ListAliases</a>
        /// operation. 
        /// </para>
        ///  
        /// <para>
        /// Each CMK can have multiple aliases. To change the alias of a CMK, use <a>DeleteAlias</a>
        /// to delete the current alias and <a>CreateAlias</a> to create a new alias. To associate
        /// an existing alias with a different customer master key (CMK), call <a>UpdateAlias</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomKeyStore

        internal virtual DeleteCustomKeyStoreResponse DeleteCustomKeyStore(DeleteCustomKeyStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomKeyStoreResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomKeyStoreResponse>(request, options);
        }



        /// <summary>
        /// Deletes a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>. This operation does not delete the AWS CloudHSM cluster that is associated
        /// with the custom key store, or affect any users or keys in the cluster.
        /// 
        ///  
        /// <para>
        /// The custom key store that you delete cannot contain any AWS KMS <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">customer
        /// master keys (CMKs)</a>. Before deleting the key store, verify that you will never
        /// need to use any of the CMKs in the key store for any cryptographic operations. Then,
        /// use <a>ScheduleKeyDeletion</a> to delete the AWS KMS customer master keys (CMKs) from
        /// the key store. When the scheduled waiting period expires, the <code>ScheduleKeyDeletion</code>
        /// operation deletes the CMKs. Then it makes a best effort to delete the key material
        /// from the associated cluster. However, you might need to manually <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups.
        /// </para>
        ///  
        /// <para>
        /// After all CMKs are deleted from AWS KMS, use <a>DisconnectCustomKeyStore</a> to disconnect
        /// the key store from AWS KMS. Then, you can delete the custom key store.
        /// </para>
        ///  
        /// <para>
        /// Instead of deleting the custom key store, consider using <a>DisconnectCustomKeyStore</a>
        /// to disconnect it from AWS KMS. While the key store is disconnected, you cannot create
        /// or use the CMKs in the key store. But, you do not need to delete CMKs and you can
        /// reconnect a disconnected custom key store at any time.
        /// </para>
        ///  
        /// <para>
        /// If the operation succeeds, it returns a JSON object with no properties.
        /// </para>
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in AWS KMS, which combines the convenience and extensive
        /// integration of AWS KMS with the isolation and control of a single-tenant key store.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomKeyStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreHasCMKsException">
        /// The request was rejected because the custom key store contains AWS KMS customer master
        /// keys (CMKs). After verifying that you do not need to use the CMKs, use the <a>ScheduleKeyDeletion</a>
        /// operation to delete the CMKs. After they are deleted, you can delete the custom key
        /// store.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because AWS KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteCustomKeyStore">REST API Reference for DeleteCustomKeyStore Operation</seealso>
        public virtual Task<DeleteCustomKeyStoreResponse> DeleteCustomKeyStoreAsync(DeleteCustomKeyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomKeyStoreResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCustomKeyStoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteImportedKeyMaterial

        internal virtual DeleteImportedKeyMaterialResponse DeleteImportedKeyMaterial(DeleteImportedKeyMaterialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImportedKeyMaterialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImportedKeyMaterialResponseUnmarshaller.Instance;

            return Invoke<DeleteImportedKeyMaterialResponse>(request, options);
        }



        /// <summary>
        /// Deletes key material that you previously imported. This operation makes the specified
        /// customer master key (CMK) unusable. For more information about importing key material
        /// into AWS KMS, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i>AWS Key Management Service Developer Guide</i>. You cannot
        /// perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// When the specified CMK is in the <code>PendingDeletion</code> state, this operation
        /// does not change the CMK's state. Otherwise, it changes the CMK's state to <code>PendingImport</code>.
        /// </para>
        ///  
        /// <para>
        /// After you delete key material, you can use <a>ImportKeyMaterial</a> to reimport the
        /// same key material into the CMK.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImportedKeyMaterial service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteImportedKeyMaterial service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteImportedKeyMaterial">REST API Reference for DeleteImportedKeyMaterial Operation</seealso>
        public virtual Task<DeleteImportedKeyMaterialResponse> DeleteImportedKeyMaterialAsync(DeleteImportedKeyMaterialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImportedKeyMaterialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImportedKeyMaterialResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteImportedKeyMaterialResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCustomKeyStores

        internal virtual DescribeCustomKeyStoresResponse DescribeCustomKeyStores(DescribeCustomKeyStoresRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomKeyStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomKeyStoresResponseUnmarshaller.Instance;

            return Invoke<DescribeCustomKeyStoresResponse>(request, options);
        }



        /// <summary>
        /// Gets information about <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key stores</a> in the account and region.
        /// 
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in AWS KMS, which combines the convenience and extensive
        /// integration of AWS KMS with the isolation and control of a single-tenant key store.
        /// </para>
        ///  
        /// <para>
        /// By default, this operation returns information about all custom key stores in the
        /// account and region. To get only information about a particular custom key store, use
        /// either the <code>CustomKeyStoreName</code> or <code>CustomKeyStoreId</code> parameter
        /// (but not both).
        /// </para>
        ///  
        /// <para>
        /// To determine whether the custom key store is connected to its AWS CloudHSM cluster,
        /// use the <code>ConnectionState</code> element in the response. If an attempt to connect
        /// the custom key store failed, the <code>ConnectionState</code> value is <code>FAILED</code>
        /// and the <code>ConnectionErrorCode</code> element in the response indicates the cause
        /// of the failure. For help interpreting the <code>ConnectionErrorCode</code>, see <a>CustomKeyStoresListEntry</a>.
        /// </para>
        ///  
        /// <para>
        /// Custom key stores have a <code>DISCONNECTED</code> connection state if the key store
        /// has never been connected or you use the <a>DisconnectCustomKeyStore</a> operation
        /// to disconnect it. If your custom key store state is <code>CONNECTED</code> but you
        /// are having trouble using it, make sure that its associated AWS CloudHSM cluster is
        /// active and contains the minimum number of HSMs required for the operation, if any.
        /// </para>
        ///  
        /// <para>
        ///  For help repairing your custom key store, see the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html">Troubleshooting
        /// Custom Key Stores</a> topic in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomKeyStores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomKeyStores service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because AWS KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeCustomKeyStores">REST API Reference for DescribeCustomKeyStores Operation</seealso>
        public virtual Task<DescribeCustomKeyStoresResponse> DescribeCustomKeyStoresAsync(DescribeCustomKeyStoresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomKeyStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomKeyStoresResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCustomKeyStoresResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeKey

        internal virtual DescribeKeyResponse DescribeKey(DescribeKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyResponseUnmarshaller.Instance;

            return Invoke<DescribeKeyResponse>(request, options);
        }


        /// <summary>
        /// Provides detailed information about a customer master key (CMK). You can run <code>DescribeKey</code>
        /// on a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
        /// managed CMK</a> or an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">AWS
        /// managed CMK</a>.
        /// 
        ///  
        /// <para>
        /// This detailed information includes the key ARN, creation date (and deletion date,
        /// if applicable), the key state, and the origin and expiration date (if any) of the
        /// key material. For CMKs in custom key stores, it includes information about the custom
        /// key store, such as the key store ID and the AWS CloudHSM cluster ID. It includes fields,
        /// like <code>KeySpec</code>, that help you distinguish symmetric from asymmetric CMKs.
        /// It also provides information that is particularly important to asymmetric CMKs, such
        /// as the key usage (encryption or signing) and the encryption algorithms or signing
        /// algorithms that the CMK supports.
        /// </para>
        ///  
        /// <para>
        ///  <code>DescribeKey</code> does not return the following information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Aliases associated with the CMK. To get this information, use <a>ListAliases</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether automatic key rotation is enabled on the CMK. To get this information, use
        /// <a>GetKeyRotationStatus</a>. Also, some key states prevent a CMK from being automatically
        /// rotated. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#rotate-keys-how-it-works">How
        /// Automatic Key Rotation Works</a> in <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags on the CMK. To get this information, use <a>ListResourceTags</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key policies and grants on the CMK. To get this information, use <a>GetKeyPolicy</a>
        /// and <a>ListGrants</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you call the <code>DescribeKey</code> operation on a <i>predefined AWS alias</i>,
        /// that is, an AWS alias with no key ID, AWS KMS creates an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">AWS
        /// managed CMK</a>. Then, it associates the alias with the new CMK, and returns the <code>KeyId</code>
        /// and <code>Arn</code> of the new CMK in the response.
        /// </para>
        ///  
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// or alias ARN in the value of the KeyId parameter.
        /// </para>
        /// </summary>
        /// <param name="keyId">Describes the specified customer master key (CMK).  If you specify a predefined AWS alias (an AWS alias with no key ID), KMS associates the alias with an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">AWS managed CMK</a> and returns its <code>KeyId</code> and <code>Arn</code> in the response. To specify a CMK, use its key ID, Amazon Resource Name (ARN), alias name, or alias ARN. When using an alias name, prefix it with <code>"alias/"</code>. To specify a CMK in a different AWS account, you must use the key ARN or alias ARN. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Alias name: <code>alias/ExampleAlias</code>  </li> <li> Alias ARN: <code>arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>. To get the alias name and alias ARN, use <a>ListAliases</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        public virtual Task<DescribeKeyResponse> DescribeKeyAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeKeyRequest();
            request.KeyId = keyId;
            return DescribeKeyAsync(request, cancellationToken);
        }



        /// <summary>
        /// Provides detailed information about a customer master key (CMK). You can run <code>DescribeKey</code>
        /// on a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
        /// managed CMK</a> or an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">AWS
        /// managed CMK</a>.
        /// 
        ///  
        /// <para>
        /// This detailed information includes the key ARN, creation date (and deletion date,
        /// if applicable), the key state, and the origin and expiration date (if any) of the
        /// key material. For CMKs in custom key stores, it includes information about the custom
        /// key store, such as the key store ID and the AWS CloudHSM cluster ID. It includes fields,
        /// like <code>KeySpec</code>, that help you distinguish symmetric from asymmetric CMKs.
        /// It also provides information that is particularly important to asymmetric CMKs, such
        /// as the key usage (encryption or signing) and the encryption algorithms or signing
        /// algorithms that the CMK supports.
        /// </para>
        ///  
        /// <para>
        ///  <code>DescribeKey</code> does not return the following information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Aliases associated with the CMK. To get this information, use <a>ListAliases</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether automatic key rotation is enabled on the CMK. To get this information, use
        /// <a>GetKeyRotationStatus</a>. Also, some key states prevent a CMK from being automatically
        /// rotated. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#rotate-keys-how-it-works">How
        /// Automatic Key Rotation Works</a> in <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags on the CMK. To get this information, use <a>ListResourceTags</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key policies and grants on the CMK. To get this information, use <a>GetKeyPolicy</a>
        /// and <a>ListGrants</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you call the <code>DescribeKey</code> operation on a <i>predefined AWS alias</i>,
        /// that is, an AWS alias with no key ID, AWS KMS creates an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">AWS
        /// managed CMK</a>. Then, it associates the alias with the new CMK, and returns the <code>KeyId</code>
        /// and <code>Arn</code> of the new CMK in the response.
        /// </para>
        ///  
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// or alias ARN in the value of the KeyId parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        public virtual Task<DescribeKeyResponse> DescribeKeyAsync(DescribeKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableKey

        internal virtual DisableKeyResponse DisableKey(DisableKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableKeyResponseUnmarshaller.Instance;

            return Invoke<DisableKeyResponse>(request, options);
        }


        /// <summary>
        /// Sets the state of a customer master key (CMK) to disabled, thereby preventing its
        /// use for cryptographic operations. You cannot perform this operation on a CMK in a
        /// different AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKey">REST API Reference for DisableKey Operation</seealso>
        public virtual Task<DisableKeyResponse> DisableKeyAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DisableKeyRequest();
            request.KeyId = keyId;
            return DisableKeyAsync(request, cancellationToken);
        }



        /// <summary>
        /// Sets the state of a customer master key (CMK) to disabled, thereby preventing its
        /// use for cryptographic operations. You cannot perform this operation on a CMK in a
        /// different AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKey">REST API Reference for DisableKey Operation</seealso>
        public virtual Task<DisableKeyResponse> DisableKeyAsync(DisableKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DisableKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableKeyRotation

        internal virtual DisableKeyRotationResponse DisableKeyRotation(DisableKeyRotationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableKeyRotationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableKeyRotationResponseUnmarshaller.Instance;

            return Invoke<DisableKeyRotationResponse>(request, options);
        }


        /// <summary>
        /// Disables <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified symmetric customer master key (CMK).
        /// 
        ///  
        /// <para>
        ///  You cannot enable automatic rotation of asymmetric CMKs, CMKs with imported key material,
        /// or CMKs in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>. You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">Identifies a symmetric customer master key (CMK). You cannot enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html#asymmetric-cmks">asymmetric CMKs</a>, CMKs with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported key material</a>, or CMKs in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom key store</a>. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKeyRotation">REST API Reference for DisableKeyRotation Operation</seealso>
        public virtual Task<DisableKeyRotationResponse> DisableKeyRotationAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DisableKeyRotationRequest();
            request.KeyId = keyId;
            return DisableKeyRotationAsync(request, cancellationToken);
        }



        /// <summary>
        /// Disables <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified symmetric customer master key (CMK).
        /// 
        ///  
        /// <para>
        ///  You cannot enable automatic rotation of asymmetric CMKs, CMKs with imported key material,
        /// or CMKs in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>. You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableKeyRotation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKeyRotation">REST API Reference for DisableKeyRotation Operation</seealso>
        public virtual Task<DisableKeyRotationResponse> DisableKeyRotationAsync(DisableKeyRotationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableKeyRotationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableKeyRotationResponseUnmarshaller.Instance;

            return InvokeAsync<DisableKeyRotationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisconnectCustomKeyStore

        internal virtual DisconnectCustomKeyStoreResponse DisconnectCustomKeyStore(DisconnectCustomKeyStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectCustomKeyStoreResponseUnmarshaller.Instance;

            return Invoke<DisconnectCustomKeyStoreResponse>(request, options);
        }



        /// <summary>
        /// Disconnects the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a> from its associated AWS CloudHSM cluster. While a custom key store is
        /// disconnected, you can manage the custom key store and its customer master keys (CMKs),
        /// but you cannot create or use CMKs in the custom key store. You can reconnect the custom
        /// key store at any time.
        /// 
        ///  <note> 
        /// <para>
        /// While a custom key store is disconnected, all attempts to create customer master keys
        /// (CMKs) in the custom key store or to use existing CMKs in cryptographic operations
        /// will fail. This action can prevent users from storing and accessing sensitive data.
        /// </para>
        ///  </note>  
        /// <para>
        /// To find the connection state of a custom key store, use the <a>DescribeCustomKeyStores</a>
        /// operation. To reconnect a custom key store, use the <a>ConnectCustomKeyStore</a> operation.
        /// </para>
        ///  
        /// <para>
        /// If the operation succeeds, it returns a JSON object with no properties.
        /// </para>
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in AWS KMS, which combines the convenience and extensive
        /// integration of AWS KMS with the isolation and control of a single-tenant key store.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectCustomKeyStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisconnectCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because AWS KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisconnectCustomKeyStore">REST API Reference for DisconnectCustomKeyStore Operation</seealso>
        public virtual Task<DisconnectCustomKeyStoreResponse> DisconnectCustomKeyStoreAsync(DisconnectCustomKeyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectCustomKeyStoreResponseUnmarshaller.Instance;

            return InvokeAsync<DisconnectCustomKeyStoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableKey

        internal virtual EnableKeyResponse EnableKey(EnableKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableKeyResponseUnmarshaller.Instance;

            return Invoke<EnableKeyResponse>(request, options);
        }


        /// <summary>
        /// Sets the key state of a customer master key (CMK) to enabled. This allows you to use
        /// the CMK for cryptographic operations. You cannot perform this operation on a CMK in
        /// a different AWS account.
        /// 
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKey">REST API Reference for EnableKey Operation</seealso>
        public virtual Task<EnableKeyResponse> EnableKeyAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new EnableKeyRequest();
            request.KeyId = keyId;
            return EnableKeyAsync(request, cancellationToken);
        }



        /// <summary>
        /// Sets the key state of a customer master key (CMK) to enabled. This allows you to use
        /// the CMK for cryptographic operations. You cannot perform this operation on a CMK in
        /// a different AWS account.
        /// 
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKey">REST API Reference for EnableKey Operation</seealso>
        public virtual Task<EnableKeyResponse> EnableKeyAsync(EnableKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableKeyResponseUnmarshaller.Instance;

            return InvokeAsync<EnableKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableKeyRotation

        internal virtual EnableKeyRotationResponse EnableKeyRotation(EnableKeyRotationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableKeyRotationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableKeyRotationResponseUnmarshaller.Instance;

            return Invoke<EnableKeyRotationResponse>(request, options);
        }


        /// <summary>
        /// Enables <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified symmetric customer master key (CMK).
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// You cannot enable automatic rotation of asymmetric CMKs, CMKs with imported key material,
        /// or CMKs in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">Identifies a symmetric customer master key (CMK). You cannot enable automatic rotation of asymmetric CMKs, CMKs with imported key material, or CMKs in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom key store</a>. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKeyRotation">REST API Reference for EnableKeyRotation Operation</seealso>
        public virtual Task<EnableKeyRotationResponse> EnableKeyRotationAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new EnableKeyRotationRequest();
            request.KeyId = keyId;
            return EnableKeyRotationAsync(request, cancellationToken);
        }



        /// <summary>
        /// Enables <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified symmetric customer master key (CMK).
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// You cannot enable automatic rotation of asymmetric CMKs, CMKs with imported key material,
        /// or CMKs in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableKeyRotation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKeyRotation">REST API Reference for EnableKeyRotation Operation</seealso>
        public virtual Task<EnableKeyRotationResponse> EnableKeyRotationAsync(EnableKeyRotationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableKeyRotationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableKeyRotationResponseUnmarshaller.Instance;

            return InvokeAsync<EnableKeyRotationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Encrypt

        internal virtual EncryptResponse Encrypt(EncryptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EncryptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EncryptResponseUnmarshaller.Instance;

            return Invoke<EncryptResponse>(request, options);
        }



        /// <summary>
        /// Encrypts plaintext into ciphertext by using a customer master key (CMK). The <code>Encrypt</code>
        /// operation has two primary use cases:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You can encrypt small amounts of arbitrary data, such as a personal identifier or
        /// database password, or other sensitive information. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can use the <code>Encrypt</code> operation to move encrypted data from one AWS
        /// region to another. In the first region, generate a data key and use the plaintext
        /// key to encrypt the data. Then, in the new region, call the <code>Encrypt</code> method
        /// on same plaintext data key. Now, you can safely move the encrypted data and encrypted
        /// data key to the new region, and decrypt in the new region when necessary.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You don't need to use the <code>Encrypt</code> operation to encrypt a data key. The
        /// <a>GenerateDataKey</a> and <a>GenerateDataKeyPair</a> operations return a plaintext
        /// data key and an encrypted copy of that data key.
        /// </para>
        ///  
        /// <para>
        /// When you encrypt data, you must specify a symmetric or asymmetric CMK to use in the
        /// encryption operation. The CMK must have a <code>KeyUsage</code> value of <code>ENCRYPT_DECRYPT.</code>
        /// To find the <code>KeyUsage</code> of a CMK, use the <a>DescribeKey</a> operation.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you use a symmetric CMK, you can use an encryption context to add additional security
        /// to your encryption operation. If you specify an <code>EncryptionContext</code> when
        /// encrypting data, you must specify the same encryption context (a case-sensitive exact
        /// match) when decrypting the data. Otherwise, the request to decrypt fails with an <code>InvalidCiphertextException</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// Context</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify an asymmetric CMK, you must also specify the encryption algorithm.
        /// The algorithm must be compatible with the CMK type.
        /// </para>
        ///  <important> 
        /// <para>
        /// When you use an asymmetric CMK to encrypt or reencrypt data, be sure to record the
        /// CMK and encryption algorithm that you choose. You will be required to provide the
        /// same CMK and encryption algorithm when you decrypt the data. If the CMK and algorithm
        /// do not match the values used to encrypt the data, the decrypt operation fails.
        /// </para>
        ///  
        /// <para>
        /// You are not required to supply the CMK ID and encryption algorithm when you decrypt
        /// with symmetric CMKs because AWS KMS stores this information in the ciphertext blob.
        /// AWS KMS cannot store metadata in ciphertext generated with asymmetric keys. The standard
        /// format for asymmetric key ciphertext does not include configurable fields.
        /// </para>
        ///  </important> 
        /// <para>
        /// The maximum size of the data that you can encrypt varies with the type of CMK and
        /// the encryption algorithm that you choose.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Symmetric CMKs
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SYMMETRIC_DEFAULT</code>: 4096 bytes
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>RSA_2048</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RSAES_OAEP_SHA_1</code>: 214 bytes
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RSAES_OAEP_SHA_256</code>: 190 bytes
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>RSA_3072</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RSAES_OAEP_SHA_1</code>: 342 bytes
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RSAES_OAEP_SHA_256</code>: 318 bytes
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <code>RSA_4096</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RSAES_OAEP_SHA_1</code>: 470 bytes
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RSAES_OAEP_SHA_256</code>: 446 bytes
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// or alias ARN in the value of the KeyId parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Encrypt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Encrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the CMK is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the CMK <code>(CustomerMasterKeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a CMK, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular CMK, use the
        /// <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified CMK was not available. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Encrypt">REST API Reference for Encrypt Operation</seealso>
        public virtual Task<EncryptResponse> EncryptAsync(EncryptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EncryptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EncryptResponseUnmarshaller.Instance;

            return InvokeAsync<EncryptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateDataKey

        internal virtual GenerateDataKeyResponse GenerateDataKey(GenerateDataKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateDataKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateDataKeyResponseUnmarshaller.Instance;

            return Invoke<GenerateDataKeyResponse>(request, options);
        }



        /// <summary>
        /// Generates a unique symmetric data key. This operation returns a plaintext copy of
        /// the data key and a copy that is encrypted under a customer master key (CMK) that you
        /// specify. You can use the plaintext key to encrypt your data outside of AWS KMS and
        /// store the encrypted data key with the encrypted data.
        /// 
        ///  
        /// <para>
        ///  <code>GenerateDataKey</code> returns a unique data key for each request. The bytes
        /// in the key are not related to the caller or CMK that is used to encrypt the data key.
        /// </para>
        ///  
        /// <para>
        /// To generate a data key, specify the symmetric CMK that will be used to encrypt the
        /// data key. You cannot use an asymmetric CMK to generate data keys.
        /// </para>
        ///  
        /// <para>
        /// You must also specify the length of the data key. Use either the <code>KeySpec</code>
        /// or <code>NumberOfBytes</code> parameters (but not both). For 128-bit and 256-bit data
        /// keys, use the <code>KeySpec</code> parameter. 
        /// </para>
        ///  
        /// <para>
        /// If the operation succeeds, the plaintext copy of the data key is in the <code>Plaintext</code>
        /// field of the response, and the encrypted copy of the data key in the <code>CiphertextBlob</code>
        /// field.
        /// </para>
        ///  
        /// <para>
        /// To get only an encrypted copy of the data key, use <a>GenerateDataKeyWithoutPlaintext</a>.
        /// To generate an asymmetric data key pair, use the <a>GenerateDataKeyPair</a> or <a>GenerateDataKeyPairWithoutPlaintext</a>
        /// operation. To get a cryptographically secure random byte string, use <a>GenerateRandom</a>.
        /// </para>
        ///  
        /// <para>
        /// You can use the optional encryption context to add additional security to the encryption
        /// operation. If you specify an <code>EncryptionContext</code>, you must specify the
        /// same encryption context (a case-sensitive exact match) when decrypting the encrypted
        /// data key. Otherwise, the request to decrypt fails with an InvalidCiphertextException.
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// Context</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// We recommend that you use the following pattern to encrypt data locally in your application:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use the <code>GenerateDataKey</code> operation to get a data encryption key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the plaintext data key (returned in the <code>Plaintext</code> field of the response)
        /// to encrypt data locally, then erase the plaintext data key from memory.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Store the encrypted data key (returned in the <code>CiphertextBlob</code> field of
        /// the response) alongside the locally encrypted data.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// To decrypt data locally:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use the <a>Decrypt</a> operation to decrypt the encrypted data key. The operation
        /// returns a plaintext copy of the data key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the plaintext data key to decrypt data locally, then erase the plaintext data
        /// key from memory.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateDataKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the CMK is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the CMK <code>(CustomerMasterKeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a CMK, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular CMK, use the
        /// <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified CMK was not available. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKey">REST API Reference for GenerateDataKey Operation</seealso>
        public virtual Task<GenerateDataKeyResponse> GenerateDataKeyAsync(GenerateDataKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateDataKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateDataKeyResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateDataKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateDataKeyPair

        internal virtual GenerateDataKeyPairResponse GenerateDataKeyPair(GenerateDataKeyPairRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateDataKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateDataKeyPairResponseUnmarshaller.Instance;

            return Invoke<GenerateDataKeyPairResponse>(request, options);
        }



        /// <summary>
        /// Generates a unique asymmetric data key pair. The <code>GenerateDataKeyPair</code>
        /// operation returns a plaintext public key, a plaintext private key, and a copy of the
        /// private key that is encrypted under the symmetric CMK you specify. You can use the
        /// data key pair to perform asymmetric cryptography outside of AWS KMS.
        /// 
        ///  
        /// <para>
        ///  <code>GenerateDataKeyPair</code> returns a unique data key pair for each request.
        /// The bytes in the keys are not related to the caller or the CMK that is used to encrypt
        /// the private key.
        /// </para>
        ///  
        /// <para>
        /// You can use the public key that <code>GenerateDataKeyPair</code> returns to encrypt
        /// data or verify a signature outside of AWS KMS. Then, store the encrypted private key
        /// with the data. When you are ready to decrypt data or sign a message, you can use the
        /// <a>Decrypt</a> operation to decrypt the encrypted private key.
        /// </para>
        ///  
        /// <para>
        /// To generate a data key pair, you must specify a symmetric customer master key (CMK)
        /// to encrypt the private key in a data key pair. You cannot use an asymmetric CMK. To
        /// get the type of your CMK, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// If you are using the data key pair to encrypt data, or for any operation where you
        /// don't immediately need a private key, consider using the <a>GenerateDataKeyPairWithoutPlaintext</a>
        /// operation. <code>GenerateDataKeyPairWithoutPlaintext</code> returns a plaintext public
        /// key and an encrypted private key, but omits the plaintext private key that you need
        /// only to decrypt ciphertext or sign a message. Later, when you need to decrypt the
        /// data or sign a message, use the <a>Decrypt</a> operation to decrypt the encrypted
        /// private key in the data key pair.
        /// </para>
        ///  
        /// <para>
        /// You can use the optional encryption context to add additional security to the encryption
        /// operation. If you specify an <code>EncryptionContext</code>, you must specify the
        /// same encryption context (a case-sensitive exact match) when decrypting the encrypted
        /// data key. Otherwise, the request to decrypt fails with an InvalidCiphertextException.
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// Context</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyPair service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateDataKeyPair service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the CMK is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the CMK <code>(CustomerMasterKeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a CMK, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular CMK, use the
        /// <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified CMK was not available. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKeyPair">REST API Reference for GenerateDataKeyPair Operation</seealso>
        public virtual Task<GenerateDataKeyPairResponse> GenerateDataKeyPairAsync(GenerateDataKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateDataKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateDataKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateDataKeyPairResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateDataKeyPairWithoutPlaintext

        internal virtual GenerateDataKeyPairWithoutPlaintextResponse GenerateDataKeyPairWithoutPlaintext(GenerateDataKeyPairWithoutPlaintextRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateDataKeyPairWithoutPlaintextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateDataKeyPairWithoutPlaintextResponseUnmarshaller.Instance;

            return Invoke<GenerateDataKeyPairWithoutPlaintextResponse>(request, options);
        }



        /// <summary>
        /// Generates a unique asymmetric data key pair. The <code>GenerateDataKeyPairWithoutPlaintext</code>
        /// operation returns a plaintext public key and a copy of the private key that is encrypted
        /// under the symmetric CMK you specify. Unlike <a>GenerateDataKeyPair</a>, this operation
        /// does not return a plaintext private key. 
        /// 
        ///  
        /// <para>
        /// To generate a data key pair, you must specify a symmetric customer master key (CMK)
        /// to encrypt the private key in the data key pair. You cannot use an asymmetric CMK.
        /// To get the type of your CMK, use the <code>KeySpec</code> field in the <a>DescribeKey</a>
        /// response.
        /// </para>
        ///  
        /// <para>
        /// You can use the public key that <code>GenerateDataKeyPairWithoutPlaintext</code> returns
        /// to encrypt data or verify a signature outside of AWS KMS. Then, store the encrypted
        /// private key with the data. When you are ready to decrypt data or sign a message, you
        /// can use the <a>Decrypt</a> operation to decrypt the encrypted private key.
        /// </para>
        ///  
        /// <para>
        ///  <code>GenerateDataKeyPairWithoutPlaintext</code> returns a unique data key pair for
        /// each request. The bytes in the key are not related to the caller or CMK that is used
        /// to encrypt the private key.
        /// </para>
        ///  
        /// <para>
        /// You can use the optional encryption context to add additional security to the encryption
        /// operation. If you specify an <code>EncryptionContext</code>, you must specify the
        /// same encryption context (a case-sensitive exact match) when decrypting the encrypted
        /// data key. Otherwise, the request to decrypt fails with an InvalidCiphertextException.
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// Context</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyPairWithoutPlaintext service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateDataKeyPairWithoutPlaintext service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the CMK is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the CMK <code>(CustomerMasterKeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a CMK, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular CMK, use the
        /// <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified CMK was not available. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKeyPairWithoutPlaintext">REST API Reference for GenerateDataKeyPairWithoutPlaintext Operation</seealso>
        public virtual Task<GenerateDataKeyPairWithoutPlaintextResponse> GenerateDataKeyPairWithoutPlaintextAsync(GenerateDataKeyPairWithoutPlaintextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateDataKeyPairWithoutPlaintextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateDataKeyPairWithoutPlaintextResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateDataKeyPairWithoutPlaintextResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateDataKeyWithoutPlaintext

        internal virtual GenerateDataKeyWithoutPlaintextResponse GenerateDataKeyWithoutPlaintext(GenerateDataKeyWithoutPlaintextRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateDataKeyWithoutPlaintextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateDataKeyWithoutPlaintextResponseUnmarshaller.Instance;

            return Invoke<GenerateDataKeyWithoutPlaintextResponse>(request, options);
        }



        /// <summary>
        /// Generates a unique symmetric data key. This operation returns a data key that is encrypted
        /// under a customer master key (CMK) that you specify. To request an asymmetric data
        /// key pair, use the <a>GenerateDataKeyPair</a> or <a>GenerateDataKeyPairWithoutPlaintext</a>
        /// operations.
        /// 
        ///  
        /// <para>
        ///  <code>GenerateDataKeyWithoutPlaintext</code> is identical to the <a>GenerateDataKey</a>
        /// operation except that returns only the encrypted copy of the data key. This operation
        /// is useful for systems that need to encrypt data at some point, but not immediately.
        /// When you need to encrypt the data, you call the <a>Decrypt</a> operation on the encrypted
        /// copy of the key. 
        /// </para>
        ///  
        /// <para>
        /// It's also useful in distributed systems with different levels of trust. For example,
        /// you might store encrypted data in containers. One component of your system creates
        /// new containers and stores an encrypted data key with each container. Then, a different
        /// component puts the data into the containers. That component first decrypts the data
        /// key, uses the plaintext data key to encrypt data, puts the encrypted data into the
        /// container, and then destroys the plaintext data key. In this system, the component
        /// that creates the containers never sees the plaintext data key.
        /// </para>
        ///  
        /// <para>
        ///  <code>GenerateDataKeyWithoutPlaintext</code> returns a unique data key for each request.
        /// The bytes in the keys are not related to the caller or CMK that is used to encrypt
        /// the private key.
        /// </para>
        ///  
        /// <para>
        /// To generate a data key, you must specify the symmetric customer master key (CMK) that
        /// is used to encrypt the data key. You cannot use an asymmetric CMK to generate a data
        /// key. To get the type of your CMK, use the <code>KeySpec</code> field in the <a>DescribeKey</a>
        /// response. You must also specify the length of the data key using either the <code>KeySpec</code>
        /// or <code>NumberOfBytes</code> field (but not both). For common key lengths (128-bit
        /// and 256-bit symmetric keys), use the <code>KeySpec</code> parameter. 
        /// </para>
        ///  
        /// <para>
        /// If the operation succeeds, you will find the plaintext copy of the data key in the
        /// <code>Plaintext</code> field of the response, and the encrypted copy of the data key
        /// in the <code>CiphertextBlob</code> field.
        /// </para>
        ///  
        /// <para>
        /// You can use the optional encryption context to add additional security to the encryption
        /// operation. If you specify an <code>EncryptionContext</code>, you must specify the
        /// same encryption context (a case-sensitive exact match) when decrypting the encrypted
        /// data key. Otherwise, the request to decrypt fails with an InvalidCiphertextException.
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// Context</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyWithoutPlaintext service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateDataKeyWithoutPlaintext service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the CMK is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the CMK <code>(CustomerMasterKeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a CMK, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular CMK, use the
        /// <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified CMK was not available. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKeyWithoutPlaintext">REST API Reference for GenerateDataKeyWithoutPlaintext Operation</seealso>
        public virtual Task<GenerateDataKeyWithoutPlaintextResponse> GenerateDataKeyWithoutPlaintextAsync(GenerateDataKeyWithoutPlaintextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateDataKeyWithoutPlaintextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateDataKeyWithoutPlaintextResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateDataKeyWithoutPlaintextResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateRandom

        internal virtual GenerateRandomResponse GenerateRandom(GenerateRandomRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateRandomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateRandomResponseUnmarshaller.Instance;

            return Invoke<GenerateRandomResponse>(request, options);
        }


        /// <summary>
        /// Returns a random byte string that is cryptographically secure.
        /// 
        ///  
        /// <para>
        /// By default, the random byte string is generated in AWS KMS. To generate the byte string
        /// in the AWS CloudHSM cluster that is associated with a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>, specify the custom key store ID.
        /// </para>
        ///  
        /// <para>
        /// For more information about entropy and random number generation, see the <a href="https://d0.awsstatic.com/whitepapers/KMS-Cryptographic-Details.pdf">AWS
        /// Key Management Service Cryptographic Details</a> whitepaper.
        /// </para>
        /// </summary>
        /// <param name="numberOfBytes">The length of the byte string.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateRandom service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because AWS KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateRandom">REST API Reference for GenerateRandom Operation</seealso>
        public virtual Task<GenerateRandomResponse> GenerateRandomAsync(int numberOfBytes, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GenerateRandomRequest();
            request.NumberOfBytes = numberOfBytes;
            return GenerateRandomAsync(request, cancellationToken);
        }



        /// <summary>
        /// Returns a random byte string that is cryptographically secure.
        /// 
        ///  
        /// <para>
        /// By default, the random byte string is generated in AWS KMS. To generate the byte string
        /// in the AWS CloudHSM cluster that is associated with a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>, specify the custom key store ID.
        /// </para>
        ///  
        /// <para>
        /// For more information about entropy and random number generation, see the <a href="https://d0.awsstatic.com/whitepapers/KMS-Cryptographic-Details.pdf">AWS
        /// Key Management Service Cryptographic Details</a> whitepaper.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateRandom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateRandom service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because AWS KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateRandom">REST API Reference for GenerateRandom Operation</seealso>
        public virtual Task<GenerateRandomResponse> GenerateRandomAsync(GenerateRandomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateRandomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateRandomResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateRandomResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetKeyPolicy

        internal virtual GetKeyPolicyResponse GetKeyPolicy(GetKeyPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyPolicyResponseUnmarshaller.Instance;

            return Invoke<GetKeyPolicyResponse>(request, options);
        }


        /// <summary>
        /// Gets a key policy attached to the specified customer master key (CMK). You cannot
        /// perform this operation on a CMK in a different AWS account.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="policyName">Specifies the name of the key policy. The only valid name is <code>default</code>. To get the names of key policies, use <a>ListKeyPolicies</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyPolicy">REST API Reference for GetKeyPolicy Operation</seealso>
        public virtual Task<GetKeyPolicyResponse> GetKeyPolicyAsync(string keyId, string policyName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetKeyPolicyRequest();
            request.KeyId = keyId;
            request.PolicyName = policyName;
            return GetKeyPolicyAsync(request, cancellationToken);
        }



        /// <summary>
        /// Gets a key policy attached to the specified customer master key (CMK). You cannot
        /// perform this operation on a CMK in a different AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyPolicy">REST API Reference for GetKeyPolicy Operation</seealso>
        public virtual Task<GetKeyPolicyResponse> GetKeyPolicyAsync(GetKeyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetKeyPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetKeyRotationStatus

        internal virtual GetKeyRotationStatusResponse GetKeyRotationStatus(GetKeyRotationStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyRotationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyRotationStatusResponseUnmarshaller.Instance;

            return Invoke<GetKeyRotationStatusResponse>(request, options);
        }


        /// <summary>
        /// Gets a Boolean value that indicates whether <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> is enabled for the specified customer master key
        /// (CMK).
        /// 
        ///  
        /// <para>
        /// You cannot enable automatic rotation of asymmetric CMKs, CMKs with imported key material,
        /// or CMKs in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>. The key rotation status for these CMKs is always <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Disabled: The key rotation status does not change when you disable a CMK. However,
        /// while the CMK is disabled, AWS KMS does not rotate the backing key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending deletion: While a CMK is pending deletion, its key rotation status is <code>false</code>
        /// and AWS KMS does not rotate the backing key. If you cancel the deletion, the original
        /// key rotation status is restored.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// in the value of the <code>KeyId</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. To specify a CMK in a different AWS account, you must use the key ARN. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyRotationStatus service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyRotationStatus">REST API Reference for GetKeyRotationStatus Operation</seealso>
        public virtual Task<GetKeyRotationStatusResponse> GetKeyRotationStatusAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetKeyRotationStatusRequest();
            request.KeyId = keyId;
            return GetKeyRotationStatusAsync(request, cancellationToken);
        }



        /// <summary>
        /// Gets a Boolean value that indicates whether <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> is enabled for the specified customer master key
        /// (CMK).
        /// 
        ///  
        /// <para>
        /// You cannot enable automatic rotation of asymmetric CMKs, CMKs with imported key material,
        /// or CMKs in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>. The key rotation status for these CMKs is always <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Disabled: The key rotation status does not change when you disable a CMK. However,
        /// while the CMK is disabled, AWS KMS does not rotate the backing key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending deletion: While a CMK is pending deletion, its key rotation status is <code>false</code>
        /// and AWS KMS does not rotate the backing key. If you cancel the deletion, the original
        /// key rotation status is restored.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// in the value of the <code>KeyId</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyRotationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyRotationStatus service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyRotationStatus">REST API Reference for GetKeyRotationStatus Operation</seealso>
        public virtual Task<GetKeyRotationStatusResponse> GetKeyRotationStatusAsync(GetKeyRotationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyRotationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyRotationStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetKeyRotationStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetParametersForImport

        internal virtual GetParametersForImportResponse GetParametersForImport(GetParametersForImportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParametersForImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParametersForImportResponseUnmarshaller.Instance;

            return Invoke<GetParametersForImportResponse>(request, options);
        }



        /// <summary>
        /// Returns the items you need to import key material into a symmetric, customer managed
        /// customer master key (CMK). For more information about importing key material into
        /// AWS KMS, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// This operation returns a public key and an import token. Use the public key to encrypt
        /// the symmetric key material. Store the import token to send with a subsequent <a>ImportKeyMaterial</a>
        /// request.
        /// </para>
        ///  
        /// <para>
        /// You must specify the key ID of the symmetric CMK into which you will import key material.
        /// This CMK's <code>Origin</code> must be <code>EXTERNAL</code>. You must also specify
        /// the wrapping algorithm and type of wrapping key (public key) that you will use to
        /// encrypt the key material. You cannot perform this operation on an asymmetric CMK or
        /// on any CMK in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// To import key material, you must use the public key and import token from the same
        /// response. These items are valid for 24 hours. The expiration date and time appear
        /// in the <code>GetParametersForImport</code> response. You cannot use an expired token
        /// in an <a>ImportKeyMaterial</a> request. If your key and token expire, send another
        /// <code>GetParametersForImport</code> request.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParametersForImport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetParametersForImport service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetParametersForImport">REST API Reference for GetParametersForImport Operation</seealso>
        public virtual Task<GetParametersForImportResponse> GetParametersForImportAsync(GetParametersForImportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParametersForImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParametersForImportResponseUnmarshaller.Instance;

            return InvokeAsync<GetParametersForImportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPublicKey

        internal virtual GetPublicKeyResponse GetPublicKey(GetPublicKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicKeyResponseUnmarshaller.Instance;

            return Invoke<GetPublicKeyResponse>(request, options);
        }



        /// <summary>
        /// Returns the public key of an asymmetric CMK. Unlike the private key of a asymmetric
        /// CMK, which never leaves AWS KMS unencrypted, callers with <code>kms:GetPublicKey</code>
        /// permission can download the public key of an asymmetric CMK. You can share the public
        /// key to allow others to encrypt messages and verify signatures outside of AWS KMS.
        /// For information about symmetric and asymmetric CMKs, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric CMKs</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// You do not need to download the public key. Instead, you can use the public key within
        /// AWS KMS by calling the <a>Encrypt</a>, <a>ReEncrypt</a>, or <a>Verify</a> operations
        /// with the identifier of an asymmetric CMK. When you use the public key within AWS KMS,
        /// you benefit from the authentication, authorization, and logging that are part of every
        /// AWS KMS operation. You also reduce of risk of encrypting data that cannot be decrypted.
        /// These features are not effective outside of AWS KMS. For details, see <a href="kms/latest/developerguide/get-public-key.html#get-public-key-considerations">Special
        /// Considerations for Downloading Public Keys</a>.
        /// </para>
        ///  
        /// <para>
        /// To help you use the public key safely outside of AWS KMS, <code>GetPublicKey</code>
        /// returns important information about the public key in the response, including:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_GetPublicKey.html#KMS-GetPublicKey-response-CustomerMasterKeySpec">CustomerMasterKeySpec</a>:
        /// The type of key material in the public key, such as <code>RSA_4096</code> or <code>ECC_NIST_P521</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_GetPublicKey.html#KMS-GetPublicKey-response-KeyUsage">KeyUsage</a>:
        /// Whether the key is used for encryption or signing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_GetPublicKey.html#KMS-GetPublicKey-response-EncryptionAlgorithms">EncryptionAlgorithms</a>
        /// or <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_GetPublicKey.html#KMS-GetPublicKey-response-SigningAlgorithms">SigningAlgorithms</a>:
        /// A list of the encryption algorithms or the signing algorithms for the key.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Although AWS KMS cannot enforce these restrictions on external operations, it is crucial
        /// that you use this information to prevent the public key from being used improperly.
        /// For example, you can prevent a public signing key from being used encrypt data, or
        /// prevent a public key from being used with an encryption algorithm that is not supported
        /// by AWS KMS. You can also avoid errors, such as using the wrong signing algorithm in
        /// a verification operation.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPublicKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the CMK is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the CMK <code>(CustomerMasterKeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a CMK, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular CMK, use the
        /// <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified CMK was not available. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetPublicKey">REST API Reference for GetPublicKey Operation</seealso>
        public virtual Task<GetPublicKeyResponse> GetPublicKeyAsync(GetPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPublicKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicKeyResponseUnmarshaller.Instance;

            return InvokeAsync<GetPublicKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportKeyMaterial

        internal virtual ImportKeyMaterialResponse ImportKeyMaterial(ImportKeyMaterialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportKeyMaterialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportKeyMaterialResponseUnmarshaller.Instance;

            return Invoke<ImportKeyMaterialResponse>(request, options);
        }



        /// <summary>
        /// Imports key material into an existing symmetric AWS KMS customer master key (CMK)
        /// that was created without key material. After you successfully import key material
        /// into a CMK, you can <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html#reimport-key-material">reimport
        /// the same key material</a> into that CMK, but you cannot import different key material.
        /// 
        ///  
        /// <para>
        /// You cannot perform this operation on an asymmetric CMK or on any CMK in a different
        /// AWS account. For more information about creating CMKs with no key material and then
        /// importing key material, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Before using this operation, call <a>GetParametersForImport</a>. Its response includes
        /// a public key and an import token. Use the public key to encrypt the key material.
        /// Then, submit the import token from the same <code>GetParametersForImport</code> response.
        /// </para>
        ///  
        /// <para>
        /// When calling this operation, you must specify the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key ID or key ARN of a CMK with no key material. Its <code>Origin</code> must
        /// be <code>EXTERNAL</code>.
        /// </para>
        ///  
        /// <para>
        /// To create a CMK with no key material, call <a>CreateKey</a> and set the value of its
        /// <code>Origin</code> parameter to <code>EXTERNAL</code>. To get the <code>Origin</code>
        /// of a CMK, call <a>DescribeKey</a>.)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encrypted key material. To get the public key to encrypt the key material, call
        /// <a>GetParametersForImport</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The import token that <a>GetParametersForImport</a> returned. You must use a public
        /// key and token from the same <code>GetParametersForImport</code> response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether the key material expires and if so, when. If you set an expiration date, AWS
        /// KMS deletes the key material from the CMK on the specified date, and the CMK becomes
        /// unusable. To use the CMK again, you must reimport the same key material. The only
        /// way to change an expiration date is by reimporting the same key material and specifying
        /// a new expiration date. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When this operation is successful, the key state of the CMK changes from <code>PendingImport</code>
        /// to <code>Enabled</code>, and you can use the CMK.
        /// </para>
        ///  
        /// <para>
        /// If this operation fails, use the exception to help determine the problem. If the error
        /// is related to the key material, the import token, or wrapping key, use <a>GetParametersForImport</a>
        /// to get a new public key and import token for the CMK and repeat the import procedure.
        /// For help, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html#importing-keys-overview">How
        /// To Import Key Material</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyMaterial service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportKeyMaterial service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.ExpiredImportTokenException">
        /// The request was rejected because the specified import token is expired. Use <a>GetParametersForImport</a>
        /// to get a new import token and public key, use the new public key to encrypt the key
        /// material, and then try the request again.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.IncorrectKeyMaterialException">
        /// The request was rejected because the key material in the request is, expired, invalid,
        /// or is not the same key material that was previously imported into this customer master
        /// key (CMK).
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// From the <a>Decrypt</a> or <a>ReEncrypt</a> operation, the request was rejected because
        /// the specified ciphertext, or additional authenticated data incorporated into the ciphertext,
        /// such as the encryption context, is corrupted, missing, or otherwise invalid.
        /// 
        ///  
        /// <para>
        /// From the <a>ImportKeyMaterial</a> operation, the request was rejected because AWS
        /// KMS could not decrypt the encrypted (wrapped) key material. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidImportTokenException">
        /// The request was rejected because the provided import token is invalid or is associated
        /// with a different customer master key (CMK).
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ImportKeyMaterial">REST API Reference for ImportKeyMaterial Operation</seealso>
        public virtual Task<ImportKeyMaterialResponse> ImportKeyMaterialAsync(ImportKeyMaterialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportKeyMaterialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportKeyMaterialResponseUnmarshaller.Instance;

            return InvokeAsync<ImportKeyMaterialResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAliases

        internal virtual ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAliasesResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of aliases in the caller's AWS account and region. You cannot list aliases
        /// in other accounts. For more information about aliases, see <a>CreateAlias</a>.
        /// 
        ///  
        /// <para>
        /// By default, the ListAliases command returns all aliases in the account and region.
        /// To get only the aliases that point to a particular customer master key (CMK), use
        /// the <code>KeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// The <code>ListAliases</code> response can include aliases that you created and associated
        /// with your customer managed CMKs, and aliases that AWS created and associated with
        /// AWS managed CMKs in your account. You can recognize AWS aliases because their names
        /// have the format <code>aws/&lt;service-name&gt;</code>, such as <code>aws/dynamodb</code>.
        /// </para>
        ///  
        /// <para>
        /// The response might also include aliases that have no <code>TargetKeyId</code> field.
        /// These are predefined aliases that AWS has created but has not yet associated with
        /// a CMK. Aliases that AWS creates in your account, including predefined aliases, do
        /// not count against your <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html#aliases-limit">AWS
        /// KMS aliases limit</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAliasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGrants

        internal virtual ListGrantsResponse ListGrants(ListGrantsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGrantsResponseUnmarshaller.Instance;

            return Invoke<ListGrantsResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of all grants for the specified customer master key (CMK).
        /// 
        ///  
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// in the value of the <code>KeyId</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGrants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListGrants">REST API Reference for ListGrants Operation</seealso>
        public virtual Task<ListGrantsResponse> ListGrantsAsync(ListGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGrantsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGrantsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListKeyPolicies

        internal virtual ListKeyPoliciesResponse ListKeyPolicies(ListKeyPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeyPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeyPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListKeyPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Gets the names of the key policies that are attached to a customer master key (CMK).
        /// This operation is designed to get policy names that you can use in a <a>GetKeyPolicy</a>
        /// operation. However, the only valid policy name is <code>default</code>. You cannot
        /// perform this operation on a CMK in a different AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeyPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKeyPolicies service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListKeyPolicies">REST API Reference for ListKeyPolicies Operation</seealso>
        public virtual Task<ListKeyPoliciesResponse> ListKeyPoliciesAsync(ListKeyPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeyPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeyPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListKeyPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListKeys

        internal virtual ListKeysResponse ListKeys(ListKeysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeysResponseUnmarshaller.Instance;

            return Invoke<ListKeysResponse>(request, options);
        }



        /// <summary>
        /// Gets a list of all customer master keys (CMKs) in the caller's AWS account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKeys service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListKeys">REST API Reference for ListKeys Operation</seealso>
        public virtual Task<ListKeysResponse> ListKeysAsync(ListKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ListKeysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourceTags

        internal virtual ListResourceTagsResponse ListResourceTags(ListResourceTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceTagsResponseUnmarshaller.Instance;

            return Invoke<ListResourceTagsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all tags for the specified customer master key (CMK).
        /// 
        ///  
        /// <para>
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceTags service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListResourceTags">REST API Reference for ListResourceTags Operation</seealso>
        public virtual Task<ListResourceTagsResponse> ListResourceTagsAsync(ListResourceTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRetirableGrants

        internal virtual ListRetirableGrantsResponse ListRetirableGrants(ListRetirableGrantsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRetirableGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRetirableGrantsResponseUnmarshaller.Instance;

            return Invoke<ListRetirableGrantsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of all grants for which the grant's <code>RetiringPrincipal</code>
        /// matches the one specified.
        /// 
        ///  
        /// <para>
        /// A typical use is to list all grants that you are able to retire. To retire a grant,
        /// use <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        /// <param name="retiringPrincipal">The retiring principal for which to list grants. To specify the retiring principal, use the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Name (ARN)</a> of an AWS principal. Valid AWS principals include AWS accounts (root), IAM users, federated users, and assumed role users. For examples of the ARN syntax for specifying a principal, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-iam">AWS Identity and Access Management (IAM)</a> in the Example ARNs section of the <i>Amazon Web Services General Reference</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        public virtual Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(string retiringPrincipal, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListRetirableGrantsRequest();
            request.RetiringPrincipal = retiringPrincipal;
            return ListRetirableGrantsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns a list of all grants for which the grant's <code>RetiringPrincipal</code>
        /// matches the one specified.
        /// 
        ///  
        /// <para>
        /// A typical use is to list all grants that you are able to retire. To retire a grant,
        /// use <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        public virtual Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListRetirableGrantsRequest();
            return ListRetirableGrantsAsync(request, cancellationToken);
        }



        /// <summary>
        /// Returns a list of all grants for which the grant's <code>RetiringPrincipal</code>
        /// matches the one specified.
        /// 
        ///  
        /// <para>
        /// A typical use is to list all grants that you are able to retire. To retire a grant,
        /// use <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRetirableGrants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        public virtual Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(ListRetirableGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRetirableGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRetirableGrantsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRetirableGrantsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutKeyPolicy

        internal virtual PutKeyPolicyResponse PutKeyPolicy(PutKeyPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutKeyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutKeyPolicyResponseUnmarshaller.Instance;

            return Invoke<PutKeyPolicyResponse>(request, options);
        }


        /// <summary>
        /// Attaches a key policy to the specified customer master key (CMK). You cannot perform
        /// this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about key policies, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Key
        /// Policies</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="policy">The key policy to attach to the CMK. The key policy must meet the following criteria: <ul> <li> If you don't set <code>BypassPolicyLockoutSafetyCheck</code> to true, the key policy must allow the principal that is making the <code>PutKeyPolicy</code> request to make a subsequent <code>PutKeyPolicy</code> request on the CMK. This reduces the risk that the CMK becomes unmanageable. For more information, refer to the scenario in the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html#key-policy-default-allow-root-enable-iam">Default Key Policy</a> section of the <i>AWS Key Management Service Developer Guide</i>. </li> <li> Each statement in the key policy must contain one or more principals. The principals in the key policy must exist and be visible to AWS KMS. When you create a new AWS principal (for example, an IAM user or role), you might need to enforce a delay before including the new principal in a key policy because the new principal might not be immediately visible to AWS KMS. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/troubleshoot_general.html#troubleshoot_general_eventual-consistency">Changes that I make are not always immediately visible</a> in the <i>AWS Identity and Access Management User Guide</i>. </li> </ul> The key policy size limit is 32 kilobytes (32768 bytes).</param>
        /// <param name="policyName">The name of the key policy. The only valid value is <code>default</code>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/PutKeyPolicy">REST API Reference for PutKeyPolicy Operation</seealso>
        public virtual Task<PutKeyPolicyResponse> PutKeyPolicyAsync(string keyId, string policy, string policyName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutKeyPolicyRequest();
            request.KeyId = keyId;
            request.Policy = policy;
            request.PolicyName = policyName;
            return PutKeyPolicyAsync(request, cancellationToken);
        }



        /// <summary>
        /// Attaches a key policy to the specified customer master key (CMK). You cannot perform
        /// this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about key policies, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Key
        /// Policies</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutKeyPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/PutKeyPolicy">REST API Reference for PutKeyPolicy Operation</seealso>
        public virtual Task<PutKeyPolicyResponse> PutKeyPolicyAsync(PutKeyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutKeyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutKeyPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutKeyPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReEncrypt

        internal virtual ReEncryptResponse ReEncrypt(ReEncryptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReEncryptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReEncryptResponseUnmarshaller.Instance;

            return Invoke<ReEncryptResponse>(request, options);
        }



        /// <summary>
        /// Decrypts ciphertext and then reencrypts it entirely within AWS KMS. You can use this
        /// operation to change the customer master key (CMK) under which data is encrypted, such
        /// as when you <a href="kms/latest/developerguide/rotate-keys.html#rotate-keys-manually">manually
        /// rotate</a> a CMK or change the CMK that protects a ciphertext. You can also use it
        /// to reencrypt ciphertext under the same CMK, such as to change the encryption context
        /// of a ciphertext. 
        /// 
        ///  
        /// <para>
        /// The <code>ReEncrypt</code> operation can decrypt ciphertext that was encrypted by
        /// using an AWS KMS CMK in an AWS KMS operation, such as <a>Encrypt</a> or <a>GenerateDataKey</a>.
        /// It can also decrypt ciphertext that was encrypted by using the public key of an asymmetric
        /// CMK outside of AWS KMS. However, it cannot decrypt ciphertext produced by other libraries,
        /// such as the <a href="https://docs.aws.amazon.com/encryption-sdk/latest/developer-guide/">AWS
        /// Encryption SDK</a> or <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingClientSideEncryption.html">Amazon
        /// S3 client-side encryption</a>. These libraries return a ciphertext format that is
        /// incompatible with AWS KMS.
        /// </para>
        ///  
        /// <para>
        /// When you use the <code>ReEncrypt</code> operation, you need to provide information
        /// for the decrypt operation and the subsequent encrypt operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If your ciphertext was encrypted under an asymmetric CMK, you must identify the <i>source
        /// CMK</i>, that is, the CMK that encrypted the ciphertext. You must also supply the
        /// encryption algorithm that was used. This information is required to decrypt the data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It is optional, but you can specify a source CMK even when the ciphertext was encrypted
        /// under a symmetric CMK. This ensures that the ciphertext is decrypted only by using
        /// a particular CMK. If the CMK that you specify cannot decrypt the ciphertext, the <code>ReEncrypt</code>
        /// operation fails.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To reencrypt the data, you must specify the <i>destination CMK</i>, that is, the CMK
        /// that re-encrypts the data after it is decrypted. You can select a symmetric or asymmetric
        /// CMK. If the destination CMK is an asymmetric CMK, you must also provide the encryption
        /// algorithm. The algorithm that you choose must be compatible with the CMK.
        /// </para>
        ///  <important> 
        /// <para>
        /// When you use an asymmetric CMK to encrypt or reencrypt data, be sure to record the
        /// CMK and encryption algorithm that you choose. You will be required to provide the
        /// same CMK and encryption algorithm when you decrypt the data. If the CMK and algorithm
        /// do not match the values used to encrypt the data, the decrypt operation fails.
        /// </para>
        ///  
        /// <para>
        /// You are not required to supply the CMK ID and encryption algorithm when you decrypt
        /// with symmetric CMKs because AWS KMS stores this information in the ciphertext blob.
        /// AWS KMS cannot store metadata in ciphertext generated with asymmetric keys. The standard
        /// format for asymmetric key ciphertext does not include configurable fields.
        /// </para>
        ///  </important> </li> </ul> 
        /// <para>
        /// Unlike other AWS KMS API operations, <code>ReEncrypt</code> callers must have two
        /// permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>kms:EncryptFrom</code> permission on the source CMK
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>kms:EncryptTo</code> permission on the destination CMK
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To permit reencryption from
        /// </para>
        ///  
        /// <para>
        ///  or to a CMK, include the <code>"kms:ReEncrypt*"</code> permission in your <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">key
        /// policy</a>. This permission is automatically included in the key policy when you use
        /// the console to create a CMK. But you must include it manually when you create a CMK
        /// programmatically or when you use the <a>PutKeyPolicy</a> operation set a key policy.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReEncrypt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReEncrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.IncorrectKeyException">
        /// The request was rejected because the specified CMK cannot decrypt the data. The <code>KeyId</code>
        /// in a <a>Decrypt</a> request and the <code>SourceKeyId</code> in a <a>ReEncrypt</a>
        /// request must identify the same CMK that was used to encrypt the ciphertext.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// From the <a>Decrypt</a> or <a>ReEncrypt</a> operation, the request was rejected because
        /// the specified ciphertext, or additional authenticated data incorporated into the ciphertext,
        /// such as the encryption context, is corrupted, missing, or otherwise invalid.
        /// 
        ///  
        /// <para>
        /// From the <a>ImportKeyMaterial</a> operation, the request was rejected because AWS
        /// KMS could not decrypt the encrypted (wrapped) key material. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the CMK is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the CMK <code>(CustomerMasterKeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a CMK, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular CMK, use the
        /// <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified CMK was not available. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ReEncrypt">REST API Reference for ReEncrypt Operation</seealso>
        public virtual Task<ReEncryptResponse> ReEncryptAsync(ReEncryptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReEncryptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReEncryptResponseUnmarshaller.Instance;

            return InvokeAsync<ReEncryptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RetireGrant

        internal virtual RetireGrantResponse RetireGrant(RetireGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetireGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetireGrantResponseUnmarshaller.Instance;

            return Invoke<RetireGrantResponse>(request, options);
        }


        /// <summary>
        /// Retires a grant. To clean up, you can retire a grant when you're done using it. You
        /// should revoke a grant when you intend to actively deny operations that depend on it.
        /// The following are permitted to call this API:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The AWS account (root user) under which the grant was created
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>RetiringPrincipal</code>, if present in the grant
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>GranteePrincipal</code>, if <code>RetireGrant</code> is an operation specified
        /// in the grant
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You must identify the grant to retire by its grant token or by a combination of the
        /// grant ID and the Amazon Resource Name (ARN) of the customer master key (CMK). A grant
        /// token is a unique variable-length base64-encoded string. A grant ID is a 64 character
        /// unique identifier of a grant. The <a>CreateGrant</a> operation returns both.
        /// </para>
        /// </summary>
        /// <param name="grantToken">Token that identifies the grant to be retired.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetireGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RetireGrant">REST API Reference for RetireGrant Operation</seealso>
        public virtual Task<RetireGrantResponse> RetireGrantAsync(string grantToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RetireGrantRequest();
            request.GrantToken = grantToken;
            return RetireGrantAsync(request, cancellationToken);
        }



        /// <summary>
        /// Retires a grant. To clean up, you can retire a grant when you're done using it. You
        /// should revoke a grant when you intend to actively deny operations that depend on it.
        /// The following are permitted to call this API:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The AWS account (root user) under which the grant was created
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>RetiringPrincipal</code>, if present in the grant
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>GranteePrincipal</code>, if <code>RetireGrant</code> is an operation specified
        /// in the grant
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You must identify the grant to retire by its grant token or by a combination of the
        /// grant ID and the Amazon Resource Name (ARN) of the customer master key (CMK). A grant
        /// token is a unique variable-length base64-encoded string. A grant ID is a 64 character
        /// unique identifier of a grant. The <a>CreateGrant</a> operation returns both.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetireGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetireGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RetireGrant">REST API Reference for RetireGrant Operation</seealso>
        public virtual Task<RetireGrantResponse> RetireGrantAsync(RetireGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetireGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetireGrantResponseUnmarshaller.Instance;

            return InvokeAsync<RetireGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeGrant

        internal virtual RevokeGrantResponse RevokeGrant(RevokeGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeGrantResponseUnmarshaller.Instance;

            return Invoke<RevokeGrantResponse>(request, options);
        }


        /// <summary>
        /// Revokes the specified grant for the specified customer master key (CMK). You can revoke
        /// a grant to actively deny operations that depend on it.
        /// 
        ///  
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// in the value of the <code>KeyId</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="grantId">Identifier of the grant to be revoked.</param>
        /// <param name="keyId">A unique identifier for the customer master key associated with the grant. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. To specify a CMK in a different AWS account, you must use the key ARN. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RevokeGrant">REST API Reference for RevokeGrant Operation</seealso>
        public virtual Task<RevokeGrantResponse> RevokeGrantAsync(string grantId, string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RevokeGrantRequest();
            request.GrantId = grantId;
            request.KeyId = keyId;
            return RevokeGrantAsync(request, cancellationToken);
        }



        /// <summary>
        /// Revokes the specified grant for the specified customer master key (CMK). You can revoke
        /// a grant to actively deny operations that depend on it.
        /// 
        ///  
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// in the value of the <code>KeyId</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RevokeGrant">REST API Reference for RevokeGrant Operation</seealso>
        public virtual Task<RevokeGrantResponse> RevokeGrantAsync(RevokeGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeGrantResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ScheduleKeyDeletion

        internal virtual ScheduleKeyDeletionResponse ScheduleKeyDeletion(ScheduleKeyDeletionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ScheduleKeyDeletionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ScheduleKeyDeletionResponseUnmarshaller.Instance;

            return Invoke<ScheduleKeyDeletionResponse>(request, options);
        }


        /// <summary>
        /// Schedules the deletion of a customer master key (CMK). You may provide a waiting period,
        /// specified in days, before deletion occurs. If you do not provide a waiting period,
        /// the default period of 30 days is used. When this operation is successful, the key
        /// state of the CMK changes to <code>PendingDeletion</code>. Before the waiting period
        /// ends, you can use <a>CancelKeyDeletion</a> to cancel the deletion of the CMK. After
        /// the waiting period ends, AWS KMS deletes the CMK and all AWS KMS data associated with
        /// it, including all aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a CMK is a destructive and potentially dangerous operation. When a CMK is
        /// deleted, all data that was encrypted under the CMK is unrecoverable. To prevent the
        /// use of a CMK without deleting it, use <a>DisableKey</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you schedule deletion of a CMK from a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>, when the waiting period expires, <code>ScheduleKeyDeletion</code> deletes
        /// the CMK from AWS KMS. Then AWS KMS makes a best effort to delete the key material
        /// from the associated AWS CloudHSM cluster. However, you might need to manually <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups.
        /// </para>
        ///  
        /// <para>
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// For more information about scheduling a CMK for deletion, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier of the customer master key (CMK) to delete. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        public virtual Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ScheduleKeyDeletionRequest();
            request.KeyId = keyId;
            return ScheduleKeyDeletionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Schedules the deletion of a customer master key (CMK). You may provide a waiting period,
        /// specified in days, before deletion occurs. If you do not provide a waiting period,
        /// the default period of 30 days is used. When this operation is successful, the key
        /// state of the CMK changes to <code>PendingDeletion</code>. Before the waiting period
        /// ends, you can use <a>CancelKeyDeletion</a> to cancel the deletion of the CMK. After
        /// the waiting period ends, AWS KMS deletes the CMK and all AWS KMS data associated with
        /// it, including all aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a CMK is a destructive and potentially dangerous operation. When a CMK is
        /// deleted, all data that was encrypted under the CMK is unrecoverable. To prevent the
        /// use of a CMK without deleting it, use <a>DisableKey</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you schedule deletion of a CMK from a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>, when the waiting period expires, <code>ScheduleKeyDeletion</code> deletes
        /// the CMK from AWS KMS. Then AWS KMS makes a best effort to delete the key material
        /// from the associated AWS CloudHSM cluster. However, you might need to manually <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups.
        /// </para>
        ///  
        /// <para>
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// For more information about scheduling a CMK for deletion, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier of the customer master key (CMK) to delete. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="pendingWindowInDays">The waiting period, specified in number of days. After the waiting period ends, AWS KMS deletes the customer master key (CMK). This value is optional. If you include a value, it must be between 7 and 30, inclusive. If you do not include a value, it defaults to 30.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        public virtual Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(string keyId, int pendingWindowInDays, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ScheduleKeyDeletionRequest();
            request.KeyId = keyId;
            request.PendingWindowInDays = pendingWindowInDays;
            return ScheduleKeyDeletionAsync(request, cancellationToken);
        }



        /// <summary>
        /// Schedules the deletion of a customer master key (CMK). You may provide a waiting period,
        /// specified in days, before deletion occurs. If you do not provide a waiting period,
        /// the default period of 30 days is used. When this operation is successful, the key
        /// state of the CMK changes to <code>PendingDeletion</code>. Before the waiting period
        /// ends, you can use <a>CancelKeyDeletion</a> to cancel the deletion of the CMK. After
        /// the waiting period ends, AWS KMS deletes the CMK and all AWS KMS data associated with
        /// it, including all aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a CMK is a destructive and potentially dangerous operation. When a CMK is
        /// deleted, all data that was encrypted under the CMK is unrecoverable. To prevent the
        /// use of a CMK without deleting it, use <a>DisableKey</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you schedule deletion of a CMK from a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a>, when the waiting period expires, <code>ScheduleKeyDeletion</code> deletes
        /// the CMK from AWS KMS. Then AWS KMS makes a best effort to delete the key material
        /// from the associated AWS CloudHSM cluster. However, you might need to manually <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups.
        /// </para>
        ///  
        /// <para>
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// For more information about scheduling a CMK for deletion, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ScheduleKeyDeletion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        public virtual Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(ScheduleKeyDeletionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ScheduleKeyDeletionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ScheduleKeyDeletionResponseUnmarshaller.Instance;

            return InvokeAsync<ScheduleKeyDeletionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Sign

        internal virtual SignResponse Sign(SignRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignResponseUnmarshaller.Instance;

            return Invoke<SignResponse>(request, options);
        }



        /// <summary>
        /// Creates a <a href="https://en.wikipedia.org/wiki/Digital_signature">digital signature</a>
        /// for a message or message digest by using the private key in an asymmetric CMK. To
        /// verify the signature, use the <a>Verify</a> operation, or use the public key in the
        /// same asymmetric CMK outside of AWS KMS. For information about symmetric and asymmetric
        /// CMKs, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric CMKs</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// Digital signatures are generated and verified by using asymmetric key pair, such as
        /// an RSA or ECC pair that is represented by an asymmetric customer master key (CMK).
        /// The key owner (or an authorized user) uses their private key to sign a message. Anyone
        /// with the public key can verify that the message was signed with that particular private
        /// key and that the message hasn't changed since it was signed. 
        /// </para>
        ///  
        /// <para>
        /// To use the <code>Sign</code> operation, provide the following information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use the <code>KeyId</code> parameter to identify an asymmetric CMK with a <code>KeyUsage</code>
        /// value of <code>SIGN_VERIFY</code>. To get the <code>KeyUsage</code> value of a CMK,
        /// use the <a>DescribeKey</a> operation. The caller must have <code>kms:Sign</code> permission
        /// on the CMK.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <code>Message</code> parameter to specify the message or message digest to
        /// sign. You can submit messages of up to 4096 bytes. To sign a larger message, generate
        /// a hash digest of the message, and then provide the hash digest in the <code>Message</code>
        /// parameter. To indicate whether the message is a full message or a digest, use the
        /// <code>MessageType</code> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Choose a signing algorithm that is compatible with the CMK. 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// When signing a message, be sure to record the CMK and the signing algorithm. This
        /// information is required to verify the signature.
        /// </para>
        ///  </important> 
        /// <para>
        /// To verify the signature that this operation generates, use the <a>Verify</a> operation.
        /// Or use the <a>GetPublicKey</a> operation to download the public key and then use the
        /// public key to verify the signature outside of AWS KMS. 
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Sign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Sign service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the CMK is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the CMK <code>(CustomerMasterKeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a CMK, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular CMK, use the
        /// <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified CMK was not available. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Sign">REST API Reference for Sign Operation</seealso>
        public virtual Task<SignResponse> SignAsync(SignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignResponseUnmarshaller.Instance;

            return InvokeAsync<SignResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds or edits tags for a customer master key (CMK). You cannot perform this operation
        /// on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a tag key and a tag value. Tag keys and tag values are both required,
        /// but tag values can be empty (null) strings.
        /// </para>
        ///  
        /// <para>
        /// You can only use a tag key once for each CMK. If you use the tag key again, AWS KMS
        /// replaces the current tag value with the specified value.
        /// </para>
        ///  
        /// <para>
        /// For information about the rules that apply to tag keys and tag values, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/allocation-tag-restrictions.html">User-Defined
        /// Tag Restrictions</a> in the <i>AWS Billing and Cost Management User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.TagException">
        /// The request was rejected because one or more tags are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified tags from the specified customer master key (CMK). You cannot
        /// perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// To remove a tag, specify the tag key. To change the tag value of an existing tag key,
        /// use <a>TagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.TagException">
        /// The request was rejected because one or more tags are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAlias

        internal virtual UpdateAliasResponse UpdateAlias(UpdateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateAliasResponse>(request, options);
        }


        /// <summary>
        /// Associates an existing AWS KMS alias with a different customer master key (CMK). Each
        /// alias is associated with only one CMK at a time, although a CMK can have multiple
        /// aliases. The alias and the CMK must be in the same AWS account and region. You cannot
        /// perform this operation on an alias in a different AWS account. 
        /// 
        ///  
        /// <para>
        /// The current and new CMK must be the same type (both symmetric or both asymmetric),
        /// and they must have the same key usage (<code>ENCRYPT_DECRYPT</code> or <code>SIGN_VERIFY</code>).
        /// This restriction prevents errors in code that uses aliases. If you must assign an
        /// alias to a different type of CMK, use <a>DeleteAlias</a> to delete the old alias and
        /// <a>CreateAlias</a> to create a new alias.
        /// </para>
        ///  
        /// <para>
        /// You cannot use <code>UpdateAlias</code> to change an alias name. To change an alias
        /// name, use <a>DeleteAlias</a> to delete the old alias and <a>CreateAlias</a> to create
        /// a new alias.
        /// </para>
        ///  
        /// <para>
        /// Because an alias is not a property of a CMK, you can create, update, and delete the
        /// aliases of a CMK without affecting the CMK. Also, aliases do not appear in the response
        /// from the <a>DescribeKey</a> operation. To get the aliases of all CMKs in the account,
        /// use the <a>ListAliases</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="aliasName">Identifies the alias that is changing its CMK. This value must begin with <code>alias/</code> followed by the alias name, such as <code>alias/ExampleAlias</code>. You cannot use UpdateAlias to change the alias name.</param>
        /// <param name="targetKeyId">Identifies the CMK to associate with the alias. When the update operation completes, the alias will point to this CMK.  The CMK must be in the same AWS account and Region as the alias. Also, the new target CMK must be the same type as the current target CMK (both symmetric or both asymmetric) and they must have the same key usage.  Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>. To verify that the alias is mapped to the correct CMK, use <a>ListAliases</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual Task<UpdateAliasResponse> UpdateAliasAsync(string aliasName, string targetKeyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateAliasRequest();
            request.AliasName = aliasName;
            request.TargetKeyId = targetKeyId;
            return UpdateAliasAsync(request, cancellationToken);
        }



        /// <summary>
        /// Associates an existing AWS KMS alias with a different customer master key (CMK). Each
        /// alias is associated with only one CMK at a time, although a CMK can have multiple
        /// aliases. The alias and the CMK must be in the same AWS account and region. You cannot
        /// perform this operation on an alias in a different AWS account. 
        /// 
        ///  
        /// <para>
        /// The current and new CMK must be the same type (both symmetric or both asymmetric),
        /// and they must have the same key usage (<code>ENCRYPT_DECRYPT</code> or <code>SIGN_VERIFY</code>).
        /// This restriction prevents errors in code that uses aliases. If you must assign an
        /// alias to a different type of CMK, use <a>DeleteAlias</a> to delete the old alias and
        /// <a>CreateAlias</a> to create a new alias.
        /// </para>
        ///  
        /// <para>
        /// You cannot use <code>UpdateAlias</code> to change an alias name. To change an alias
        /// name, use <a>DeleteAlias</a> to delete the old alias and <a>CreateAlias</a> to create
        /// a new alias.
        /// </para>
        ///  
        /// <para>
        /// Because an alias is not a property of a CMK, you can create, update, and delete the
        /// aliases of a CMK without affecting the CMK. Also, aliases do not appear in the response
        /// from the <a>DescribeKey</a> operation. To get the aliases of all CMKs in the account,
        /// use the <a>ListAliases</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCustomKeyStore

        internal virtual UpdateCustomKeyStoreResponse UpdateCustomKeyStore(UpdateCustomKeyStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomKeyStoreResponseUnmarshaller.Instance;

            return Invoke<UpdateCustomKeyStoreResponse>(request, options);
        }



        /// <summary>
        /// Changes the properties of a custom key store. Use the <code>CustomKeyStoreId</code>
        /// parameter to identify the custom key store you want to edit. Use the remaining parameters
        /// to change the properties of the custom key store.
        /// 
        ///  
        /// <para>
        /// You can only update a custom key store that is disconnected. To disconnect the custom
        /// key store, use <a>DisconnectCustomKeyStore</a>. To reconnect the custom key store
        /// after the update completes, use <a>ConnectCustomKeyStore</a>. To find the connection
        /// state of a custom key store, use the <a>DescribeCustomKeyStores</a> operation.
        /// </para>
        ///  
        /// <para>
        /// Use the parameters of <code>UpdateCustomKeyStore</code> to edit your keystore settings.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use the <b>NewCustomKeyStoreName</b> parameter to change the friendly name of the
        /// custom key store to the value that you specify.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <b>KeyStorePassword</b> parameter tell AWS KMS the current password of the
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-concepts.html#concept-kmsuser">
        /// <code>kmsuser</code> crypto user (CU)</a> in the associated AWS CloudHSM cluster.
        /// You can use this parameter to <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-password">fix
        /// connection failures</a> that occur when AWS KMS cannot log into the associated cluster
        /// because the <code>kmsuser</code> password has changed. This value does not change
        /// the password in the AWS CloudHSM cluster.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <b>CloudHsmClusterId</b> parameter to associate the custom key store with
        /// a different, but related, AWS CloudHSM cluster. You can use this parameter to repair
        /// a custom key store if its AWS CloudHSM cluster becomes corrupted or is deleted, or
        /// when you need to create or restore a cluster from a backup. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the operation succeeds, it returns a JSON object with no properties.
        /// </para>
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in AWS KMS, which combines the convenience and extensive
        /// integration of AWS KMS with the isolation and control of a single-tenant key store.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomKeyStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInvalidConfigurationException">
        /// The request was rejected because the associated AWS CloudHSM cluster did not meet
        /// the configuration requirements for a custom key store.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The cluster must be configured with private subnets in at least two different Availability
        /// Zones in the Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">security
        /// group for the cluster</a> (cloudhsm-cluster-<i>&lt;cluster-id&gt;</i>-sg) must include
        /// inbound rules and outbound rules that allow TCP traffic on ports 2223-2225. The <b>Source</b>
        /// in the inbound rules and the <b>Destination</b> in the outbound rules must match the
        /// security group ID. These rules are set by default when you create the cluster. Do
        /// not delete or change them. To get information about a particular security group, use
        /// the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSecurityGroups.html">DescribeSecurityGroups</a>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The cluster must contain at least as many HSMs as the operation requires. To add HSMs,
        /// use the AWS CloudHSM <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For the <a>CreateCustomKeyStore</a>, <a>UpdateCustomKeyStore</a>, and <a>CreateKey</a>
        /// operations, the AWS CloudHSM cluster must have at least two active HSMs, each in a
        /// different Availability Zone. For the <a>ConnectCustomKeyStore</a> operation, the AWS
        /// CloudHSM must contain at least one active HSM.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about the requirements for an AWS CloudHSM cluster that is associated
        /// with a custom key store, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
        /// the Prerequisites</a> in the <i>AWS Key Management Service Developer Guide</i>. For
        /// information about creating a private subnet for an AWS CloudHSM cluster, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/create-subnets.html">Create
        /// a Private Subnet</a> in the <i>AWS CloudHSM User Guide</i>. For information about
        /// cluster security groups, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">Configure
        /// a Default Security Group</a> in the <i> <i>AWS CloudHSM User Guide</i> </i>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotActiveException">
        /// The request was rejected because the AWS CloudHSM cluster that is associated with
        /// the custom key store is not active. Initialize and activate the cluster and try the
        /// command again. For detailed instructions, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/getting-started.html">Getting
        /// Started</a> in the <i>AWS CloudHSM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotFoundException">
        /// The request was rejected because AWS KMS cannot find the AWS CloudHSM cluster with
        /// the specified cluster ID. Retry the request with a different cluster ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotRelatedException">
        /// The request was rejected because the specified AWS CloudHSM cluster has a different
        /// cluster certificate than the original cluster. You cannot use the operation to specify
        /// an unrelated cluster.
        /// 
        ///  
        /// <para>
        /// Specify a cluster that shares a backup history with the original cluster. This includes
        /// clusters that were created from a backup of the current cluster, and clusters that
        /// were created from the same backup that produced the current cluster.
        /// </para>
        ///  
        /// <para>
        /// Clusters that share a backup history have the same cluster certificate. To view the
        /// cluster certificate of a cluster, use the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
        /// operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNameInUseException">
        /// The request was rejected because the specified custom key store name is already assigned
        /// to another custom key store in the account. Try again with a custom key store name
        /// that is unique in the account.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because AWS KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateCustomKeyStore">REST API Reference for UpdateCustomKeyStore Operation</seealso>
        public virtual Task<UpdateCustomKeyStoreResponse> UpdateCustomKeyStoreAsync(UpdateCustomKeyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomKeyStoreResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCustomKeyStoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateKeyDescription

        internal virtual UpdateKeyDescriptionResponse UpdateKeyDescription(UpdateKeyDescriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateKeyDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKeyDescriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateKeyDescriptionResponse>(request, options);
        }


        /// <summary>
        /// Updates the description of a customer master key (CMK). To see the description of
        /// a CMK, use <a>DescribeKey</a>. 
        /// 
        ///  
        /// <para>
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="description">New description for the CMK.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateKeyDescription service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateKeyDescription">REST API Reference for UpdateKeyDescription Operation</seealso>
        public virtual Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(string keyId, string description, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateKeyDescriptionRequest();
            request.KeyId = keyId;
            request.Description = description;
            return UpdateKeyDescriptionAsync(request, cancellationToken);
        }



        /// <summary>
        /// Updates the description of a customer master key (CMK). To see the description of
        /// a CMK, use <a>DescribeKey</a>. 
        /// 
        ///  
        /// <para>
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyDescription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateKeyDescription service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i> <i>AWS Key Management
        /// Service Developer Guide</i> </i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateKeyDescription">REST API Reference for UpdateKeyDescription Operation</seealso>
        public virtual Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(UpdateKeyDescriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateKeyDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKeyDescriptionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateKeyDescriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Verify

        internal virtual VerifyResponse Verify(VerifyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyResponseUnmarshaller.Instance;

            return Invoke<VerifyResponse>(request, options);
        }



        /// <summary>
        /// Verifies a digital signature that was generated by the <a>Sign</a> operation. This
        /// operation requires an asymmetric CMK with a <code>KeyUsage</code> value of <code>SIGN_VERIFY</code>.
        /// 
        ///   
        /// <para>
        /// Verification confirms that an authorized user signed the message with the specified
        /// key and signing algorithm, and the message hasn't changed since it was signed. A digital
        /// signature is generated by using the private key in an asymmetric CMK. The signature
        /// is verified by using the public key in the same asymmetric CMK. For information about
        /// symmetric and asymmetric CMKs, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric CMKs</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To verify a digital signature, you can use the <code>Verify</code> operation. Specify
        /// the same asymmetric CMK that was used by the <code>Sign</code> operation to generate
        /// the digital signature.
        /// </para>
        ///  
        /// <para>
        /// You can also verify the digital signature by using the public key of the CMK outside
        /// of AWS KMS. Use the <a>GetPublicKey</a> operation to download the public key in the
        /// asymmetric CMK and then use the public key to verify the signature outside of AWS
        /// KMS.
        /// </para>
        ///  
        /// <para>
        /// The advantage of using the <code>Verify</code> operation is that it is performed within
        /// AWS KMS. As a result, it's easy to call, the operation is performed within the FIPS
        /// boundary, it is logged in AWS CloudTrail, and you can use key policy and IAM policy
        /// to determine who is authorized to use the CMK to verify signatures.
        /// </para>
        ///  <important> 
        /// <para>
        /// The result of the <code>Verify</code> operation, which is represented by its HTTP
        /// status code, does not indicate whether the signature verification succeeded or failed.
        /// To determine whether the signature was verified, see the <code>SignatureValid</code>
        /// field in the response. 
        /// </para>
        ///  </important> 
        /// <para>
        /// The CMK that you use for this operation must be in a compatible key state. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Verify service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Verify service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <code>KeyUsage</code> value of the CMK is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the CMK <code>(CustomerMasterKeySpec</code>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <code>KeyUsage</code>
        /// must be <code>ENCRYPT_DECRYPT</code>. For signing and verifying, the <code>KeyUsage</code>
        /// must be <code>SIGN_VERIFY</code>. To find the <code>KeyUsage</code> of a CMK, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular CMK, use the
        /// <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified CMK was not available. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Verify">REST API Reference for Verify Operation</seealso>
        public virtual Task<VerifyResponse> VerifyAsync(VerifyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = VerifyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyResponseUnmarshaller.Instance;

            return InvokeAsync<VerifyResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}