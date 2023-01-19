using DAL.Interfaces;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly GradingSystemContext _dbContext;

        public ReportRepository(GradingSystemContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateAsync(Report entity)
        {
            await _dbContext.Reports.AddAsync(entity);

            if (await _dbContext.SaveChangesAsync() != 0)
            {
                return entity.Id;
            }

            return 0;
        }

        public async Task<bool> DeleteAsync(Report entity)
        {
            _dbContext.Reports.Remove(entity);

            if (await _dbContext.SaveChangesAsync() != 0)
            {
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<Report>> GetAllAsync()
        {
            return await _dbContext.Reports.ToListAsync();
        }

        public async Task<Report> GetAsync(int id)
        {
            return await _dbContext.Reports.AsQueryable().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> UpdateAsync(Report entity)
        {
            _dbContext.Reports.Update(entity);

            if (await _dbContext.SaveChangesAsync() != 0)
            {
                return true;
            }

            return false;
        }
    }
}
