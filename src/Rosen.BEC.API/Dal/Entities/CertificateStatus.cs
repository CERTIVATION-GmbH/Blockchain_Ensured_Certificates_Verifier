// <copyright file="CertificateStatus.cs" company="Rosen Group">
// Copyright (c) Rosen Group. All rights reserved.
// </copyright>

namespace Rosen.BEC.API.Dal.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class CertificateStatus
    {
        public enum StatusValue
        {
            ENSURING, ENSURED, ENSURE_FAILED, DELETED
        }

        [Key]
        public int StatusId { get; set; }

        public string Value
        {
            get => this.Status.ToString();
            set
            {
                StatusValue parsingResult = this.Status;
                if (Enum.TryParse<StatusValue>(value, true, out parsingResult))
                {
                    this.Status = parsingResult;
                }
            }
        }

        public virtual ICollection<Certificate> Certificates { get; set; }

        [NotMapped]
        public StatusValue Status { get; set; }
    }
}
