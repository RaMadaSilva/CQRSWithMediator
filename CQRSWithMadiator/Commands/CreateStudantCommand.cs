using MediatR;

namespace CQRSWithMadiator.Commands
{
    public class CreateStudantCommand : IRequest<CommandResult>
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Course { get; set; }
    }
}
