using MediatR;

namespace CQRSWithMadiator.queries
{
    public record StudanteQueryById : IRequest<StudantQueryResult>
    {
        public int Id { get; set; }
    }
}
