using Application.Activities.Queries;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {

        [HttpGet]   // api/activities
        public async Task<ActionResult<List<Activity>>> GetActivities()
        {
            return await Mediator.Send(new GetActivitiesListQuery());
        }

        [HttpGet("{id}")]   // api/activities/{id}
        public async Task<ActionResult<Activity>> GetActivity(Guid id)
        {
            return Ok();
        }

    }
}