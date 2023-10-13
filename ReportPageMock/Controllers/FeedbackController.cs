using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReportPageMock.Models;
using ReportPageMock.Payload;
using ReportPageMock.Services;

namespace ReportPageMock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class FeedbackController : ControllerBase
    {
        FeedbackService _feedbackService = new FeedbackService();
        public FeedbackController()
        {
        }
        [HttpGet("analysis")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult GetFeedbackAnalysisAsync([FromQuery] FeedbackAnalysisPayload payload)
        {
            var result = _feedbackService.GetData();
            return Ok(result);
        }
    }
}
