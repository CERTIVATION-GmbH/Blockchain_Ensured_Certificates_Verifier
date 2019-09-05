// <copyright file="CertificateValidatorController.cs" company="Rosen Group">
// Copyright (c) Rosen Group. All rights reserved.
// </copyright>

using Rosen.BEC.API.AppService;
using Rosen.BEC.API.Contract;

namespace Rosen.BEC.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/certificate-validator")]
    [ApiController]
    public class CertificateValidatorController : ControllerBase
    {
        private readonly ICertificateService certService;

        public CertificateValidatorController(ICertificateService certService)
        {
            this.certService = certService;
        }

        [HttpGet("{hash}")]
        public IActionResult ValidateCertificate(string hash)
        {
            return this.Ok(this.certService.ValidateCertificate(hash));
        }
    }
}
