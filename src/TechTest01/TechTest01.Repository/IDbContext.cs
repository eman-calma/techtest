using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain;

namespace TechTest01.Repository
{
  public interface IDbContext
  {
    IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;
    int SaveChanges();
  }
}
