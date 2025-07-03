using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Services.Sindicato.Interfaces;
using Shared.Models.Sindicato;

namespace Server.Services.Sindicato.Implements
{
    public class DdjjService : IDdjjService
    {
        private readonly SindicatoDBcontext _context;

        public DdjjService(SindicatoDBcontext context)
        {
            _context = context;
        }

        public async Task<bool> GetCarenciaByCuil(string cuil, string fecha)
        {
            DateTime MesDeCarencia = Convert.ToDateTime(fecha);

            var carencia = await _context
                .ddjj.Where(x => x.CUIL_STR == cuil && x.Periodo >= MesDeCarencia)
                .ToListAsync();

            if (carencia.Count > 0)
            {
                var car = carencia.OrderByDescending(x => x.Periodo).FirstOrDefault();
                return car.Item2;
            }
            return false;
        }
    }
}
