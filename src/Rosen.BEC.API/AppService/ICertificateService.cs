// <copyright file="ICertificateService.cs" company="ROSEN Group">
// Copyright (c) ROSEN Group. All rights reserved.
// </copyright>

using Rosen.BEC.API.Contract.Dtos;

namespace Rosen.BEC.API.AppService
{
    using System;
    using System.Threading.Tasks;

    public interface ICertificateService
    {
        ValidateCertificateDto ValidateCertificate(string hash);
    }

}
