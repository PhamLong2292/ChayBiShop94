//using ChayBiShop94.Repositories.Interfaces;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ChayBiShop94.Repositories.Implementation
//{
//    public class GenericRepository<T>: IDisposable, IGenericRepository<T> where T : class
//    {
//        private readonly AppDbContext _context;
//        internal DbSet<T> dbSet;
//        public GenericRepository(AppDbContext context)
//        {
//            _context = context;
//            dbSet = _context.Set<T>();
//        }
//        public void Add(T entity)
//        {
//            dbSet.Add(entity);
//        }
//        public async Task<T> AddAsync(T entiy)
//        {
//            dbSet.Attach(entiy);
//            return entiy;
//        }
//        public void Delete(T entity)
//        {
//            if (dbSet != null)
//            {
//                dbSet.Add(entity);
//            }
//            dbSet.Remove(entity);
//        }
//        public async Task<T> DeleteAsync(T entity)
//        {
//            if (_context.Entry(entity).State != null)
//            {
//                dbSet.Add(entity);
//            }
//            dbSet.Remove(entity);
//            return entity;
//        }
//    }
//}
