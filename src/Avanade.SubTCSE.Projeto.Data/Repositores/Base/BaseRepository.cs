﻿using Avanade.SubTCSE.Projeto.Domain.Aggregates;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Infra.Data.Repositores.Base
{
    public abstract class BaseRepository<TEntity, TId> : IBaseRepository<TEntity, TId> 
        where TEntity : BaseEntity<TId>
    {
        private readonly IMongoCollection<TEntity> _mongoCollection;



        public virtual async Task<TEntity> Add(TEntity entity)
        {
            await _mongoCollection.InsertOneAsync(entity);

            return entity;
        }

        public virtual async Task<TEntity> FindById(TId id)
        {
            throw new System.NotImplementedException();
        }
    }
}
