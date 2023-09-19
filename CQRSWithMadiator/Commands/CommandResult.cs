using MediatR;

namespace CQRSWithMadiator.Commands
{
    public class CommandResult: IRequest
    {
        public bool Sucess { get; set; }
        public string Message { get; set; }
        public object Object { get; set; }
    }
}
