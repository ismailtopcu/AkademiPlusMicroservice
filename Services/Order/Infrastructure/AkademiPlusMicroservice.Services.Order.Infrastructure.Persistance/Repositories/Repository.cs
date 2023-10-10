﻿using Microsoft.EntityFrameworkCore;
using Services.Order.Core.Application.Interfaces;
using Services.Order.Infrastructure.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Order.Infrastructure.Persistance.Repositories
{
	public class Repository<T> : IRepository<T> where T : class
    {
		private readonly OrderContext _context;

		public Repository(OrderContext context)
		{
			_context = context;
		}

        public async Task<T> CreateAsync(T entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> DeleteAsync(T entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public Task<List<T>> GetOrdersById(Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
