using AutoMapper;
using CQRSWithMadiator.queries;
using CQRSWithMadiator.Repositories;
using MediatR;

namespace CQRSWithMadiator.Handlers
{
    public class StudantsQueryHandler : IRequestHandler<StudantQuery, IEnumerable<StudantQueryResult>>
    {
        private readonly IStudanteReadRepository _repository;
        private readonly IMapper _mapper; 

        public StudantsQueryHandler(IStudanteReadRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<StudantQueryResult>> Handle(StudantQuery request, 
                CancellationToken cancellationToken)
        {
            var studants =  await _repository.GetStudants();

           return  _mapper.Map<IEnumerable<StudantQueryResult>>(studants); 
        }
    }
}
