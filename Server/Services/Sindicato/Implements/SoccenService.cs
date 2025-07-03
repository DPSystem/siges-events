using System.Collections.Generic;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Services.Sindicato.Interfaces;
using Shared.Models.Sindicato;

namespace Server.Services.Sindicato.Implements
{
    public class SoccenService : ISoccenService
    {
        private readonly SindicatoDBcontext _context;

        public SoccenService(SindicatoDBcontext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Soccen>> GetAllAsync()
        {
            return await _context.Soccen.ToListAsync();
        }

        public async Task<Soccen> GetByIdAsync(int id)
        {
            return await _context.Soccen.FindAsync(id);
        }

        public async Task<Soccen> AddAsync(Soccen soccen)
        {
            _context.Soccen.Add(soccen);
            await _context.SaveChangesAsync();
            return soccen;
        }

        public async Task<Soccen> UpdateAsync(Soccen soccen)
        {
            _context.Soccen.Update(soccen);
            await _context.SaveChangesAsync();
            return soccen;
        }

        public async Task DeleteAsync(int id)
        {
            var soccen = await _context.Soccen.FindAsync(id);
            if (soccen != null)
            {
                _context.Soccen.Remove(soccen);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Soccen> GetSocioByCuil(double cuil)
        {
            Console.WriteLine("CUIL: " + cuil);
            var soc = await _context.Soccen.Where(x => x.SOCCEN_CUIL == cuil).FirstOrDefaultAsync();
            Console.WriteLine($"SOC:  {soc.SOCCEN_CUIL}");
            if (soc == null)
            {
                return null;
                // return await Task.FromResult(new Soccen());
            }
            else
            {
                return soc;
            }
        }
    }
}
