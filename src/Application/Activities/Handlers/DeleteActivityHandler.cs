using Application.Activities.Commands;
using MediatR;
using Persistence;

namespace Application.Activities.Handlers
{
    public class DeleteActivityHandler : IRequestHandler<DeleteActivityCommand>
    {
        private readonly ApplicationDbContext _context;

        public DeleteActivityHandler(ApplicationDbContext context)
        {
            _context = context;

        }

        public async Task Handle(DeleteActivityCommand request, CancellationToken cancellationToken)
        {
            var activity = await _context.Activities.FindAsync(request.Id);

            _context.Remove(activity);

            await _context.SaveChangesAsync();
        }
    }
}