using Application.Activities.Commands;
using AutoMapper;
using MediatR;
using Persistence;

namespace Application.Activities.Handlers
{
    public class EditActivityHandler : IRequestHandler<EditActivityCommand>
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public EditActivityHandler(ApplicationDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task Handle(EditActivityCommand request, CancellationToken cancellationToken)
        {
            var activity = await _context.Activities.FindAsync(request.Activity.Id);

            _mapper.Map(request.Activity, activity);

            await _context.SaveChangesAsync();
        }
    }
}