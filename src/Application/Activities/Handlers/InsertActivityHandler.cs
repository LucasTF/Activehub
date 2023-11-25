using Application.Activities.Commands;
using MediatR;
using Persistence;

namespace Application.Activities.Handlers
{
    public class InsertActivityHandler : IRequestHandler<InsertActivityCommand>
    {

        private readonly ApplicationDbContext _context;

        public InsertActivityHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(InsertActivityCommand request, CancellationToken cancellationToken)
        {
            _context.Activities.Add(request.Activity);

            await _context.SaveChangesAsync();
        }
    }
}