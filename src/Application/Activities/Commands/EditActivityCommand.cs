using Domain.Entities;
using MediatR;

namespace Application.Activities.Commands
{
    public class EditActivityCommand : IRequest
    {
        public Activity Activity { get; set; }
    }
}