// <copyright file="IEthereumService.cs" company="ROSEN Group">
// Copyright (c) ROSEN Group. All rights reserved.
// </copyright>

using System.Threading.Tasks;

namespace Rosen.BEC.API.AppService
{
    public interface IEthereumService
    {
        Task<string> GetHashValue(string individualSmartContract);
    }
}