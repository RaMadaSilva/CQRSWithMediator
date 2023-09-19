using CQRSWithMadiator.Models;

namespace CQRSWithMadiator.Repositories
{
    public interface IStudanteReadRepository
    {
        Task<IEnumerable<Studant>> GetStudants(); 
        Task<Studant> GetStudantById(int id);
    }
}
