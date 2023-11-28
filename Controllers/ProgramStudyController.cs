using Microsoft.AspNetCore.Mvc;
using Web.Api.DTO.ProgramStudy.Request;
using Web.Api.DTO.ProgramStudy.Response;
using Web.Api.Service.ProgramStudy.Command;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route("")]
    public class ProgramStudyController : ControllerBase
    {
        private readonly ProgramStudyCommand programStudyCommand;

        public ProgramStudyController(ProgramStudyCommand programStudyCommand)
        {
            this.programStudyCommand = programStudyCommand;
        }

        [HttpPost("program-study")]
        public async Task<ProgramStudyCreateResponse> Create(ProgramStudyCreateRequest request)
        {
            return await programStudyCommand.CreateProgramStudy(request);
        }
    }
}