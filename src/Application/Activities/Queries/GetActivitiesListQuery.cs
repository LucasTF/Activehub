using Domain.Entities;
using MediatR;

namespace Application.Activities.Queries
{
    public record GetActivitiesListQuery() : IRequest<List<Activity>>;
}