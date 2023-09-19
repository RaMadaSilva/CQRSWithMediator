using CQRSWithMadiator.Models;

namespace CQRSWithMadiator.Repositories
{
    public class StudantWriteFakeRepository : IStudantWriteRepository
    {
        private readonly List<Studant> _studants;

        public StudantWriteFakeRepository()
        {
            _studants = new List<Studant>()
            {
                new Studant(1, "Raul Mateia", "Matematica"),
                new Studant(1, "Joana jandira", "Eng. Geografica")
            }; 
        }

        public async Task SaveStudant(Studant studant)
        {
           _studants.Add(studant);
            await Task.CompletedTask; 
        }

        public  async Task UpdateStudant(int id)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteStudant(int id)
        {
            throw new NotImplementedException();
        }
    }
}
