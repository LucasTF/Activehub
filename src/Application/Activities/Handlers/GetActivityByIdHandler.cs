using Application.Activities.Queries;
using Domain.Entities;
using MediatR;
using Persistence;

namespace Application.Activities.Handlers
{
    public class GetActivityByIdHandler : IRequestHandler<GetActivityByIdQuery, Activity>
    {

        private readonly ApplicationDbContext _context;

        public GetActivityByIdHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Activity> Handle(GetActivityByIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Activities.FindAsync(request.Id);
        }
    }
}