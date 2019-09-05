// <copyright file="ICertificateRepository.cs" company="ROSEN Group">
// Copyright (c) ROSEN Group. All rights reserved.
// </copyright>

namespace Rosen.BEC.API.Dal.Repositories
{
    using System;
    using System.Collections.Generic;
    using Entities;

    public interface ICertificateRepository : IGenericRepository<Certificate>
    {
        Certificate GetCertificateByHashValue(string hash);
    }
}
