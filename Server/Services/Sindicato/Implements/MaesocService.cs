using System.Collections.Generic;
using System.Threading.Tasks;
using Data;
using Microsoft.EntityFrameworkCore;
using Server.Services.Sindicato.Interfaces;
using Shared.Models.Sindicato;

namespace Server.Services.Sindicato.Implements
{
    public class MaesocService : IMaesocService
    {
        private readonly SindicatoDBcontext _context;

        public MaesocService(SindicatoDBcontext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Maesoc>> GetAllAsync()
        {
            return await _context.Maesoc.ToListAsync();
        }

        public async Task<Maesoc> GetByIdAsync(int id)
        {
            return await _context.Maesoc.FindAsync(id);
        }

        public async Task<Maesoc> GetByDniAsync(string dni)
        {
            Console.WriteLine("DNI BACKEND: " + dni);
            return await _context.Maesoc.Where(x => x.MAESOC_NRODOC == dni).FirstOrDefaultAsync();
            // if (soc == null)
            // {
            //     return null;
            // }
            // else
            // {
            //     return soc;
            // }
            // return await _context.Maesoc.Where(x =>
            //     x.MAESOC_NRODOC.Trim() == dni.Trim()
            // ).FirstOrDefaultAsync();
        }

        public async Task<Maesoc> AddAsync(Maesoc maesoc)
        {
            _context.Maesoc.Add(maesoc);
            await _context.SaveChangesAsync();
            return maesoc;
        }

        public async Task<Maesoc> UpdateAsync(Maesoc maesoc)
        {
            _context.Maesoc.Update(maesoc);
            await _context.SaveChangesAsync();
            return maesoc;
        }

        public async Task DeleteAsync(int id)
        {
            var maesoc = await _context.Maesoc.FindAsync(id);
            if (maesoc != null)
            {
                _context.Maesoc.Remove(maesoc);
                await _context.SaveChangesAsync();
            }
        }
    }
}
