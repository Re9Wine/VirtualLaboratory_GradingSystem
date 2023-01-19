using DAL.Interfaces;
using Domain.Entity;
using Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Implementations
{
    public class LaboratoryWorkService : ILaboratoryWorkService
    {
        private readonly ILaboratoryWorkRepository _repository;

        public async Task<int> CreateAsync(LaboratoryWork entity)
        {
            return await _repository.CreateAsync(entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var work = await _repository.GetAsync(id);

            return await _repository.DeleteAsync(work);
        }

        public async Task<IEnumerable<LaboratoryWork>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<LaboratoryWork> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<bool> UpdateAsync(LaboratoryWork entity)
        {
            return await _repository.UpdateAsync(entity);
        }
    }
}
