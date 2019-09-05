// <copyright file="IGenericRepository.cs" company="ROSEN Group">
// Copyright (c) ROSEN Group. All rights reserved.
// </copyright>

namespace Rosen.BEC.API.Dal.Repositories
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using Microsoft.EntityFrameworkCore;

    public interface IGenericRepository<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Get DbContext object from current repository
        /// </summary>
        /// <returns>
        /// The <see cref="DbContext"/>.
        /// </returns>
        DbContext GetDbContext();

        /// <summary>
        /// A reference to specific class of Entity in DbContext
        /// </summary>
        /// <returns>
        /// The <see cref="IQueryable"/>.
        /// </returns>
        IQueryable<TEntity> Set();

        /// <summary>
        /// The where.
        /// </summary>
        /// <param name="predicate">
        /// The predicate.
        /// </param>
        /// <returns>
        /// The <see cref="IQueryable"/>.
        /// </returns>
        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// The insert.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        void Insert(TEntity entity);

        void Add(TEntity entity);

        /// <summary>
        /// The insert get entity.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns>
        /// The <see cref="TEntity"/>.
        /// </returns>
        TEntity InsertGetEntity(TEntity entity);

        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        void Delete(TEntity entity);

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        void Update(TEntity entity);

        /// <summary>
        /// The insert or update.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        void InsertOrUpdate(TEntity entity);

        /// <summary>
        /// The save.
        /// </summary>
        void Save();

        IQueryable<TEntity> GetAll();
    }
}
