using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TechTest01.Domain;

namespace TechTest01.Repository
{
  public interface IRepository<TEntity> where TEntity : BaseEntity
  {
    TEntity GetById(object id);
    void Insert(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    IQueryable<TEntity> Table { get; }
  }
}
