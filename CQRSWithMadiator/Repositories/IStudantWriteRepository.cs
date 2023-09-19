using CQRSWithMadiator.Models;

namespace CQRSWithMadiator.Repositories
{
    public interface IStudantWriteRepository
    {
        Task SaveStudant(Studant studant); 
        Task UpdateStudant(int id);
        Task DeleteStudant(int id);
    }
}
