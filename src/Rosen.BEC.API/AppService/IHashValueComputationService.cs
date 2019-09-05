// <copyright file="IHashValueComputationService.cs" company="ROSEN Group">
// Copyright (c) ROSEN Group. All rights reserved.
// </copyright>

namespace Rosen.BEC.API.AppService
{
    using Dal.Entities;

    public interface IHashValueComputationService
    {
        byte[] ComputeHashValue(Certificate certificate);
    }
}