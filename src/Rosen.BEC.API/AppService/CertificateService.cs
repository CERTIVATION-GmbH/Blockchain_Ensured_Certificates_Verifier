// <copyright file="CertificateService.cs" company="ROSEN Group">
// Copyright (c) ROSEN Group. All rights reserved.
// </copyright>

using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Rosen.BEC.API.AppService;
using Rosen.BEC.API.Contract.Dtos;
using Rosen.BEC.API.Dal.Entities;
using Rosen.BEC.API.Dal.Repositories;

namespace Rosen.BEC.API.AppService
{
    public class CertificateService
    {
        private readonly ICertificateRepository certificateRepository;
        private readonly IHashValueComputationService hashValueComputationService;
        private readonly IEthereumService ethereumService;

        public CertificateService(
            IConfiguration configuration,
            ICertificateRepository certificateRepository,
            IHashValueComputationService hashValueComputationService,
            IEthereumService ethereumService
            )
        {
            this.certificateRepository = certificateRepository;
            this.hashValueComputationService = hashValueComputationService;
            this.ethereumService = ethereumService;
        }

        public ValidateCertificateDto ValidateCertificate(string hash)
        {
            ValidateCertificateDto validateResult = new ValidateCertificateDto();

            // Search certificate in database based on the given hash-value 
            Certificate certificate = this.certificateRepository.GetCertificateByHashValue(hash);

            if (certificate == null ||
                CertificateStatus.StatusValue.DELETED.Equals(certificate.CertificateStatus.Status))
            {
                throw new Exception("Certificate is not found");
            }

            byte[] recomputeHashInBytes = this.hashValueComputationService.ComputeHashValue(certificate);
            string recomputedHash = BitConverter.ToString(recomputeHashInBytes).Replace("-", string.Empty);

            // Fetch the hash-value from blockchain
            Task<string> hashValue = this.ethereumService.GetHashValue(certificate.SmartContractAddress);

            if (hashValue.Result.Equals(null))
            {
                throw new Exception("Certificate is not found");
            }

            validateResult.Fetched = true;

            // Compare the recomputed hash-value and the fetched hash-value from database
            if (recomputedHash.Equals(hashValue.Result))
            {
                validateResult.Equal = true;
            }

            return validateResult;
        }
    }
}