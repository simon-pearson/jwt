﻿#if NETSTANDARD2_0
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace JWT.Algorithms
{
    /// <summary>
    /// ECDSA P-256 using SHA-256
    /// </summary>
    public sealed class ECDSA256Algorithm : ECDSAAlgorithm
    {
        /// <summary>
        /// Creates an instance of <see cref="ECDSA256Algorithm" /> using the provided pair of public and private keys.
        /// </summary>
        /// <param name="publicKey">The public key for verifying the data.</param>
        /// <param name="privateKey">The private key for signing the data.</param>
        public ECDSA256Algorithm(ECDsa publicKey, ECDsa privateKey)
            : base(publicKey, privateKey)
        {
        }

        /// <summary>
        /// Creates an instance of <see cref="ECDSA256Algorithm" /> using the provided public key only.
        /// </summary>
        /// <remarks>
        /// An instance created using this constructor can only be used for verifying the data, not for signing it.
        /// </remarks>
        /// <param name="publicKey">The public key for verifying the data.</param>
        public ECDSA256Algorithm(ECDsa publicKey)
            : base(publicKey)
        {
        }

        /// <summary>
        /// Creates an instance using the provided certificate.
        /// </summary>
        /// <param name="cert">The certificate having a public key and an optional private key.</param>
        public ECDSA256Algorithm(X509Certificate2 cert)
            : base(cert)
        {
        }

        /// <inheritdoc />
        public override string Name => JwtAlgorithmName.ES256.ToString();

        protected override HashAlgorithmName HashAlgorithmInternal => HashAlgorithmName.SHA256;
    }
}
#endif