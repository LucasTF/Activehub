using MediatR;

namespace Application.Activities.Commands
{
    public class DeleteActivityCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}