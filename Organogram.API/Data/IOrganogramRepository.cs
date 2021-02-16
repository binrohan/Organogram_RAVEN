using System.Collections.Generic;
using System.Threading.Tasks;
using ASP_React.Models;

namespace Organogram.API.Data
{
    public interface IOrganogramRepository
    {
        void Add<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        Task<bool> SaveAll();

        Task<IEnumerable<Company>> GetCompaniesAsync();
        Task<Company> GetCompanyAsync();
        Task<Company> SetCompanyAsync();

        Task<IEnumerable<Branch>> GetBranchesAsync();
        Task<Branch> GetBranchAsync();
        Task<Branch> SetBranchAsync();

        Task<IEnumerable<Department>> GetDepartmentsAsync();
        Task<Department> GetDepartmentAsync();
        Task<Department> SetDepartmentAsync();

        Task<IEnumerable<ProductionUnit>> GetProductionUnitsAsync();
        Task<ProductionUnit> GetProductionUnitAsync();
        Task<ProductionUnit> SetProductionUnitAsync();

        Task<IEnumerable<Section>> GetSectionsAsync();
        Task<Section> GetSectionAsync();
        Task<Section> SetSectionAsync();

        Task<IEnumerable<Line>> GetLinesAsync();
        Task<Line> GetLineAsync();
        Task<Line> SetLineAsync();
    }
}