using Domain.Entities;
using MediatR;

namespace Application.Activities.Commands
{
    public class InsertActivityCommand : IRequest
    {
        public Activity Activity { get; set; }
    }
}