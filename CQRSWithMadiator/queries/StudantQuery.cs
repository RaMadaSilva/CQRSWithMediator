using MediatR;

namespace CQRSWithMadiator.queries
{
    public record StudantQuery() : IRequest<IEnumerable<StudantQueryResult>>
    {
    }
}
