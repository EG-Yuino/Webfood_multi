using Microsoft.EntityFrameworkCore;
using System;

namespace APIglobal.Base.BaseInterface
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> Repository { get; }
        DbContext DbContext { get; }

        Task<List<T>> GetAllAsync();
        
    }
}