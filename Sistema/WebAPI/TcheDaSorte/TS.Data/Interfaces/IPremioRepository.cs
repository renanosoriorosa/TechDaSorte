﻿using TS.Model.Models;
using TS.Models.Models;

namespace TS.Data.Interfaces
{
    public interface IPremioRepository : IRepository<Premio>
    {
        Task<Premio> ObterPorCodigo(string codigo);
        Task<bool> CodigoExistente(string codigo);
        Task<List<Premio>> ObterPremiosDisponiveisAsNoTracking();
    }
}