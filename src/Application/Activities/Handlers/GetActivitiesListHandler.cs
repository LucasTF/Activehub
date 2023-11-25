using Application.Activities.Queries;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Activities.Handlers
{
    public class GetActivitiesListHandler : IRequestHandler<GetActivitiesListQuery, List<Activity>>
    {
        private readonly ApplicationDbContext _context;

        public GetActivitiesListHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Activity>> Handle(GetActivitiesListQuery request, CancellationToken cancellationToken)
        {
            return await _context.Activities.ToListAsync();
        }
    }
}