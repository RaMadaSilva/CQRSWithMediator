using CQRSWithMadiator.Commands;
using CQRSWithMadiator.Models;
using CQRSWithMadiator.Repositories;
using MediatR;

namespace CQRSWithMadiator.Handlers
{
    public class CreateStudantCommandHandler : IRequestHandler<CreateStudantCommand, CommandResult>
    {
        private readonly IStudantWriteRepository _repository;

        public CreateStudantCommandHandler(IStudantWriteRepository repository)
        {
            _repository = repository;
        }

        public async Task<CommandResult> Handle(CreateStudantCommand request, CancellationToken cancellationToken)
        {
            var studant = new Studant(request.Id,request.FullName, request.Course); 
            await _repository.SaveStudant(studant);

            return new CommandResult
            {
                Sucess = true, 
                Message = "Estudante Salvo com sucesso", 
                Object = studant
            }; 
        }
    }
}
