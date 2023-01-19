using DAL.Interfaces;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class LaboratoryWorkRepository : ILaboratoryWorkRepository
    {
        private readonly GradingSystemContext _dbContext;

        public LaboratoryWorkRepository(GradingSystemContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateAsync(LaboratoryWork entity)
        {
            await _dbContext.LaboratoryWorks.AddAsync(entity);

            if (await _dbContext.SaveChangesAsync() != 0)
            {
                return entity.Id;
            }

            return 0;
        }

        public async Task<bool> DeleteAsync(LaboratoryWork entity)
        {
            _dbContext.LaboratoryWorks.Remove(entity);

            if (await _dbContext.SaveChangesAsync() != 0)
            {
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<LaboratoryWork>> GetAllAsync()
        {
            return await _dbContext.LaboratoryWorks.ToListAsync();
        }

        public async Task<LaboratoryWork> GetAsync(int id)
        {
            return await _dbContext.LaboratoryWorks.AsQueryable().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> UpdateAsync(LaboratoryWork entity)
        {
            _dbContext.LaboratoryWorks.Update(entity);

            if (await _dbContext.SaveChangesAsync() != 0)
            {
                return true;
            }

            return false;
        }
    }
}
