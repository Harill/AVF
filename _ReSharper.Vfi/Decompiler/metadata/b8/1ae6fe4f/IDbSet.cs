// Type: System.Data.Entity.IDbSet`1
// Assembly: EntityFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: D:\Visual Studio 2010\Projects\Vfi\Assemblies\EntityFramework.dll

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace System.Data.Entity
{
  [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "Casing is intentional")]
  [SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix", Justification = "Name is intentional")]
  public interface IDbSet<TEntity> : IQueryable<TEntity>, IEnumerable<TEntity>, IQueryable, IEnumerable where TEntity : class
  {
    TEntity Find(params object[] keyValues);
    TEntity Add(TEntity entity);
    TEntity Remove(TEntity entity);
    TEntity Attach(TEntity entity);
    TEntity Create();
    TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, TEntity;
    ObservableCollection<TEntity> Local { get; }
  }
}
