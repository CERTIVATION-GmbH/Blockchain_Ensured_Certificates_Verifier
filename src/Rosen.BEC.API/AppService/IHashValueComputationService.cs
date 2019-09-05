// <copyright file="IHashValueComputationService.cs" company="Rosen Group">
// Copyright (c) Rosen Group. All rights reserved.
// </copyright>

namespace Rosen.BEC.API.AppService
{
    using Dal.Entities;

    public interface IHashValueComputationService
    {
        byte[] ComputeHashValue(Certificate certificate);
    }
}