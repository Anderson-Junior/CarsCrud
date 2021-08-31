using CRUD_Marcas.Api.DomainInterfaces;
using CRUD_Marcas.Api.Models;
using CRUD_Marcas.Api.Models.InputModels;
using CRUD_Marcas.Api.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRUD_Marcas.Api.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly Context _context;

        public BrandRepository(Context context)
        {
            _context = context;
        }

        public async Task<Brand> AddAsync(Brand brand)
        {
            _context.Add(brand);
            await _context.SaveChangesAsync();
            return brand;
        }

        public async Task<Brand> DeleteAsync(Brand brand)
        {
            _context.Remove(brand);
            await _context.SaveChangesAsync();
            return brand;
        }

        public async Task<List<Brand>> GetAllAsync()
        {
            return await _context.Brands.ToListAsync();
        }

        public async Task<Brand> GetByIdAsync(int id)
        {
            return await _context.Brands.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Brand> UpdateAsync(Brand brand)
        {
            _context.Update(brand);
            await _context.SaveChangesAsync();
            return brand;
        }
    }
}
