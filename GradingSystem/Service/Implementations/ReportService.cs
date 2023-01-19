using DAL.Interfaces;
using Domain.Entity;
using Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Implementations
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository _repository;

        public ReportService(IReportRepository repository)
        {
            _repository = repository;
        }

        public async Task<int> CreateAsync(Report entity)
        {
            return await _repository.CreateAsync(entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var report = await _repository.GetAsync(id);

            return await _repository.DeleteAsync(report);
        }

        public async Task<IEnumerable<Report>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Report> GetAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<bool> UpdateAsync(Report entity)
        {
            return await _repository.UpdateAsync(entity);
        }
    }
}
