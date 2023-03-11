using System;
using System.ComponentModel.DataAnnotations;

namespace APIglobal.Base
{
    public interface IEntityBase<TKey>
    {
        public TKey id { get; set; }
    }

    public abstract class EntityBase<TKey> : IEntityBase<TKey>
    {
        [Key]
        public virtual TKey id { get; set; }
    }
}
