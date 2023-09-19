using AutoMapper;
using CQRSWithMadiator.queries;
using CQRSWithMadiator.Repositories;
using MediatR;

namespace CQRSWithMadiator.Handlers
{
    public class StudantQueryByIdHandler : IRequestHandler<StudanteQueryById, StudantQueryResult>
    {
        private readonly IStudanteReadRepository _repository;
        private readonly IMapper _mapper;

        public StudantQueryByIdHandler(IStudanteReadRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<StudantQueryResult> Handle(StudanteQueryById request, 
            CancellationToken cancellationToken)
        {
            var studant = await _repository.GetStudantById(request.Id); 

            return _mapper.Map<StudantQueryResult>(studant);
        }
    }
}
