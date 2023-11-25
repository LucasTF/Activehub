using Domain.Entities;
using MediatR;

namespace Application.Activities.Queries
{
    public record GetActivityByIdQuery(Guid Id) : IRequest<Activity>;
}