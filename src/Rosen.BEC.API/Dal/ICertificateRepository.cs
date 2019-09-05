// <copyright file="ICertificateRepository.cs" company="Rosen Group">
// Copyright (c) Rosen Group. All rights reserved.
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
