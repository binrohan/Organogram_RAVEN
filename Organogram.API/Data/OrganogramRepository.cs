using System.Threading.Tasks;
using ASP_React.Models;

namespace Organogram.API.Data
{
    public class OrganogramRepository : IOrganogramRepository
    {
        private readonly DataContext _context;
        public OrganogramRepository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public Task<Branch> GetBranchAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<System.Collections.Generic.IEnumerable<Branch>> GetBranchesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<System.Collections.Generic.IEnumerable<Company>> GetCompaniesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Company> GetCompanyAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Department> GetDepartmentAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<System.Collections.Generic.IEnumerable<Department>> GetDepartmentsAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Line> GetLineAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<System.Collections.Generic.IEnumerable<Line>> GetLinesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ProductionUnit> GetProductionUnitAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<System.Collections.Generic.IEnumerable<ProductionUnit>> GetProductionUnitsAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Section> GetSectionAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<System.Collections.Generic.IEnumerable<Section>> GetSectionsAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public Task<Branch> SetBranchAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Company> SetCompanyAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Department> SetDepartmentAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Line> SetLineAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ProductionUnit> SetProductionUnitAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Section> SetSectionAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}