using Microsoft.AspNetCore.Mvc;
using Web.Api.DTO;
using Web.Api.DTO.Export;
using Web.Api.Service.Export.Command;


namespace Web.Api.Controllers
{
    public class ExportController : ControllerBase
    {
        private readonly ExportCommand exportCommand;

        public ExportController(ExportCommand exportCommand)
        {
            this.exportCommand = exportCommand;
        }

        [HttpPost("export")]
        public async Task<FileResult> Export([FromBody] ExportRequest exportRequest)
        {
            return await exportCommand.ExportData(exportRequest);
        }
    }
}

