using MediatR;

namespace CQRSWithMadiator.queries
{
    public class StudantQueryResult : IRequest
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Course { get; set; }
    }
}
