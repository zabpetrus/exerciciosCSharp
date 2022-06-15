using HotelJuanApp.Domain.Entities;
using System;
using System.Collections.Generic;

namespace HotelJuanApp.Domain
{
    public interface IAppServiceBase<TEntity> where TEntity : Entity
    {
        void Add(TEntity obj);

        TEntity GetById(int id);

        List<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);
    }
}
