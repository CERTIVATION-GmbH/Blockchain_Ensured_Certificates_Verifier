// <copyright file="ICertificateService.cs" company="Rosen Group">
// Copyright (c) Rosen Group. All rights reserved.
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
