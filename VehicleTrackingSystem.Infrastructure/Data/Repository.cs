using System;
using System.Collections.Generic;
using System.Text;
using Emarket.Application.Kernel;
using Emarket.Application.kernel.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using VehicleTrackingSystem.Infrastructure.Data;

namespace Emarket.Infrastructure.Data
{
    public class Repository : IRepository
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public T GetById<T>(int id) where T : BaseEntity
        {
            return _context.Set<T>().SingleOrDefault(e => e.Id == id);
        }

        public List<T> List<T>() where T : BaseEntity
        {
            return _context.Set<T>().ToList();
        }

        public T Add<T>(T entity) where T : BaseEntity
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();

            return entity;
        }

        public void Delete<T>(T entity) where T : BaseEntity
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Update<T>(T entity) where T : BaseEntity
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
