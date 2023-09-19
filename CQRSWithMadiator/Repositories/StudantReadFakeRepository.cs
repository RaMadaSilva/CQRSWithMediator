using CQRSWithMadiator.Models;

namespace CQRSWithMadiator.Repositories
{
    public class StudantReadFakeRepository : IStudanteReadRepository
    {
        private  readonly List<Studant> _studants;
        public StudantReadFakeRepository()
        {
            _studants = new()
            {
                new Studant(1, "Raul Mateia", "Matematica"),
                new Studant(2, "Joana jandira", "Eng. Geografica"),
                new Studant(3, "pedro Passos", "Biologia"),
                new Studant(4, "Maria Coelho", "Direito")
            }; 
        }
        public async Task<Studant> GetStudantById(int id)
        {
            var studant = _studants.FirstOrDefault(x=>x.Id==id);
            await Task.CompletedTask;

            return studant; 
        }

        public async Task<IEnumerable<Studant>> GetStudants()
        {
            await Task.CompletedTask;
            return _studants; 
        }
    }
}
