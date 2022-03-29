using NormativeApp.Common.Entities;
using NormativeApp.Core.Dtos.Sql;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NormativeApp.Services
{
    public interface IIngredientService
    {
        Task<ServiceResponse<List<GetIngredientDto>>> GetAllIngredients();
    }
}