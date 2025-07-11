﻿using System.Diagnostics;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;
using SalesWebMvc3.Data;
using SalesWebMvc3.Models;
using SalesWebMvc3.Services.Exceptions;

namespace SalesWebMvc3.Services
{
    public class SallerService
    {
        public SallerService(SalesWebMvc3Context dbContext)
        {
            _dbcontext = dbContext;
        }

        private readonly SalesWebMvc3Context _dbcontext;

        public async Task<List<Saller>> FindAllAsync()
            => await _dbcontext.Saller.ToListAsync();

        public async Task<Saller> FindByIdAsync(int? Id)
            => await _dbcontext.Saller.Include(obj => obj.Departament).FirstOrDefaultAsync(x=>x.Id == Id);

        public async Task RemoveAsync(int Id)
        {
            Saller obj = await FindByIdAsync(Id);
            _dbcontext.Remove(obj);
            await _dbcontext.SaveChangesAsync();
        }

        public void AddSallerRepository(Saller saller)
        {
            _dbcontext.Add(saller);
            _dbcontext.SaveChanges();
        }
        public async Task UpdateAsync(Saller obj)
        {
            if (!await _dbcontext.Saller.AnyAsync(x => x.Id == obj.Id))
                throw new NotFoundException(" Id Not Found.");
            try
            {
                _dbcontext.Update(obj);
                await _dbcontext.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
