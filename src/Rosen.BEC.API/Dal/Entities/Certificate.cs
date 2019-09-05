// <copyright file="Certificate.cs" company="ROSEN Group">
// Copyright (c) ROSEN Group. All rights reserved.
// </copyright>

namespace Rosen.BEC.API.Dal.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Certificate
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CertificateId { get; set; }

        public int StatusId { get; set; }

        public int CertificateTypeId { get; set; }

        public Guid UserId { get; set; }

        public DateTime CreateDate { get; set; }

        public string CertificateOriginalId { get; set; }

        public Guid? OriginalFileId { get; set; }

        public string TransactionId { get; set; }

        public string HashValue { get; set; }

        public string SmartContractAddress { get; set; }

        public double? TransactionCost { get; set; }
        
        public virtual CertificateStatus CertificateStatus { get; set; }

    }
}
