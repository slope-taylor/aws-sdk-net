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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the ReEncrypt operation.
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
    public partial class ReEncryptRequest : AmazonKeyManagementServiceRequest
    {
        private MemoryStream _ciphertextBlob;
        private EncryptionAlgorithmSpec _destinationEncryptionAlgorithm;
        private Dictionary<string, string> _destinationEncryptionContext = new Dictionary<string, string>();
        private string _destinationKeyId;
        private List<string> _grantTokens = new List<string>();
        private EncryptionAlgorithmSpec _sourceEncryptionAlgorithm;
        private Dictionary<string, string> _sourceEncryptionContext = new Dictionary<string, string>();
        private string _sourceKeyId;

        /// <summary>
        /// Gets and sets the property CiphertextBlob. 
        /// <para>
        /// Ciphertext of the data to reencrypt.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=6144)]
        public MemoryStream CiphertextBlob
        {
            get { return this._ciphertextBlob; }
            set { this._ciphertextBlob = value; }
        }

        // Check to see if CiphertextBlob property is set
        internal bool IsSetCiphertextBlob()
        {
            return this._ciphertextBlob != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationEncryptionAlgorithm. 
        /// <para>
        /// Specifies the encryption algorithm that AWS KMS will use to reecrypt the data after
        /// it has decrypted it. The default value, <code>SYMMETRIC_DEFAULT</code>, represents
        /// the encryption algorithm used for symmetric CMKs.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required only when the destination CMK is an asymmetric CMK.
        /// </para>
        /// </summary>
        public EncryptionAlgorithmSpec DestinationEncryptionAlgorithm
        {
            get { return this._destinationEncryptionAlgorithm; }
            set { this._destinationEncryptionAlgorithm = value; }
        }

        // Check to see if DestinationEncryptionAlgorithm property is set
        internal bool IsSetDestinationEncryptionAlgorithm()
        {
            return this._destinationEncryptionAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationEncryptionContext. 
        /// <para>
        /// Specifies that encryption context to use when the reencrypting the data.
        /// </para>
        ///  
        /// <para>
        /// A destination encryption context is valid only when the destination CMK is a symmetric
        /// CMK. The standard ciphertext format for asymmetric CMKs does not include fields for
        /// metadata.
        /// </para>
        ///  
        /// <para>
        /// An <i>encryption context</i> is a collection of non-secret key-value pairs that represents
        /// additional authenticated data. When you use an encryption context to encrypt data,
        /// you must specify the same (an exact case-sensitive match) encryption context to decrypt
        /// the data. An encryption context is optional when encrypting with a symmetric CMK,
        /// but it is highly recommended.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// Context</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> DestinationEncryptionContext
        {
            get { return this._destinationEncryptionContext; }
            set { this._destinationEncryptionContext = value; }
        }

        // Check to see if DestinationEncryptionContext property is set
        internal bool IsSetDestinationEncryptionContext()
        {
            return this._destinationEncryptionContext != null && this._destinationEncryptionContext.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DestinationKeyId. 
        /// <para>
        /// A unique identifier for the CMK that is used to reencrypt the data. Specify a symmetric
        /// or asymmetric CMK with a <code>KeyUsage</code> value of <code>ENCRYPT_DECRYPT</code>.
        /// To find the <code>KeyUsage</code> value of a CMK, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To specify a CMK, use its key ID, Amazon Resource Name (ARN), alias name, or alias
        /// ARN. When using an alias name, prefix it with <code>"alias/"</code>. To specify a
        /// CMK in a different AWS account, you must use the key ARN or alias ARN.
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name: <code>alias/ExampleAlias</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias ARN: <code>arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.
        /// To get the alias name and alias ARN, use <a>ListAliases</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string DestinationKeyId
        {
            get { return this._destinationKeyId; }
            set { this._destinationKeyId = value; }
        }

        // Check to see if DestinationKeyId property is set
        internal bool IsSetDestinationKeyId()
        {
            return this._destinationKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property GrantTokens. 
        /// <para>
        /// A list of grant tokens.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token">Grant
        /// Tokens</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> GrantTokens
        {
            get { return this._grantTokens; }
            set { this._grantTokens = value; }
        }

        // Check to see if GrantTokens property is set
        internal bool IsSetGrantTokens()
        {
            return this._grantTokens != null && this._grantTokens.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceEncryptionAlgorithm. 
        /// <para>
        /// Specifies the encryption algorithm that AWS KMS will use to decrypt the ciphertext
        /// before it is reencrypted. The default value, <code>SYMMETRIC_DEFAULT</code>, represents
        /// the algorithm used for symmetric CMKs.
        /// </para>
        ///  
        /// <para>
        /// Specify the same algorithm that was used to encrypt the ciphertext. If you specify
        /// a different algorithm, the decrypt attempt fails.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required only when the ciphertext was encrypted under an asymmetric
        /// CMK.
        /// </para>
        /// </summary>
        public EncryptionAlgorithmSpec SourceEncryptionAlgorithm
        {
            get { return this._sourceEncryptionAlgorithm; }
            set { this._sourceEncryptionAlgorithm = value; }
        }

        // Check to see if SourceEncryptionAlgorithm property is set
        internal bool IsSetSourceEncryptionAlgorithm()
        {
            return this._sourceEncryptionAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property SourceEncryptionContext. 
        /// <para>
        /// Specifies the encryption context to use to decrypt the ciphertext. Enter the same
        /// encryption context that was used to encrypt the ciphertext.
        /// </para>
        ///  
        /// <para>
        /// An <i>encryption context</i> is a collection of non-secret key-value pairs that represents
        /// additional authenticated data. When you use an encryption context to encrypt data,
        /// you must specify the same (an exact case-sensitive match) encryption context to decrypt
        /// the data. An encryption context is optional when encrypting with a symmetric CMK,
        /// but it is highly recommended.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// Context</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> SourceEncryptionContext
        {
            get { return this._sourceEncryptionContext; }
            set { this._sourceEncryptionContext = value; }
        }

        // Check to see if SourceEncryptionContext property is set
        internal bool IsSetSourceEncryptionContext()
        {
            return this._sourceEncryptionContext != null && this._sourceEncryptionContext.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceKeyId. 
        /// <para>
        /// A unique identifier for the CMK that is used to decrypt the ciphertext before it reencrypts
        /// it using the destination CMK.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required only when the ciphertext was encrypted under an asymmetric
        /// CMK. Otherwise, AWS KMS uses the metadata that it adds to the ciphertext blob to determine
        /// which CMK was used to encrypt the ciphertext. However, you can use this parameter
        /// to ensure that a particular CMK (of any kind) is used to decrypt the ciphertext before
        /// it is reencrypted.
        /// </para>
        ///  
        /// <para>
        /// If you specify a <code>KeyId</code> value, the decrypt part of the <code>ReEncrypt</code>
        /// operation succeeds only if the specified CMK was used to encrypt the ciphertext.
        /// </para>
        ///  
        /// <para>
        /// To specify a CMK, use its key ID, Amazon Resource Name (ARN), alias name, or alias
        /// ARN. When using an alias name, prefix it with <code>"alias/"</code>.
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name: <code>alias/ExampleAlias</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias ARN: <code>arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.
        /// To get the alias name and alias ARN, use <a>ListAliases</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string SourceKeyId
        {
            get { return this._sourceKeyId; }
            set { this._sourceKeyId = value; }
        }

        // Check to see if SourceKeyId property is set
        internal bool IsSetSourceKeyId()
        {
            return this._sourceKeyId != null;
        }

    }
}