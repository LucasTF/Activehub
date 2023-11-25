using Application.Activities.Commands;
using Application.Activities.Queries;
using Domain.Entities;
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
            return await Mediator.Send(new GetActivityByIdQuery(id));
        }

        [HttpPost]  // api/activities
        public async Task<IActionResult> CreateActivity(Activity activity)
        {
            await Mediator.Send(new InsertActivityCommand { Activity = activity });

            return Ok();
        }

        [HttpPut("{id}")]   // api/activities
        public async Task<IActionResult> EditActivity(Guid id, Activity activity)
        {
            activity.Id = id;
            await Mediator.Send(new EditActivityCommand { Activity = activity });

            return Ok();
        }

    }
}