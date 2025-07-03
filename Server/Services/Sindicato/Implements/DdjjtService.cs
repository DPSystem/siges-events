using System.Collections.Generic;
using System.Threading.Tasks;
using Data;
using Microsoft.EntityFrameworkCore;
using Server.Services.Sindicato.Interfaces;
using Shared.Models.Sindicato;

namespace Server.Services.Sindicato.Implements
{
    public class DdjjtService : IDdjjt
    {
        private readonly SindicatoDBcontext _context;

        public DdjjtService(SindicatoDBcontext context)
        {
            _context = context;
        }

        public Task<Ddjjt> GetByDni(int id)
        {
            throw new NotImplementedException();
        }
    }
}
