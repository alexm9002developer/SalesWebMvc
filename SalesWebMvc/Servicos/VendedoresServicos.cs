using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Servicos.Excecoes;

namespace SalesWebMvc.Servicos
{
    public class VendedoresServicos
    {
        private readonly SalesWebMvcContext _context;
        public VendedoresServicos(SalesWebMvcContext context)
        {
            _context = context;
        }
        public async Task<List<Vendedor>> FindAllAsync()
        {
            return await _context.Vendedor.OrderBy(x => x.Nome).ToListAsync();
        }
        public async Task InsertAsync(Vendedor obj)
        {
            
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        public async Task<Vendedor> FindByIdAsync(int id)
        {
            return await _context.Vendedor.Include(obj => obj.Departamentos).FirstOrDefaultAsync(obj => obj.Id == id);
            // Include(obj => obj.Departamentos) - Usar "Include" para o EntityFrameWork buscar
            // também o Departamento do vendedor.
        }
        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Vendedor.FindAsync(id);
                _context.Vendedor.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Esse vendedor possui vendas e não pode ser excluído!");
            }
        }
        public async Task UpdateAsync(Vendedor obj)
        {
            bool TemAlgum = await _context.Vendedor.AnyAsync(x => x.Id == obj.Id);
            if (!TemAlgum)
            {
                throw new NotFoundException("Código não localizado");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
