using Web.Api.DTO.ProgramStudy.Request;
using Web.Api.DTO.ProgramStudy.Response;
using Web.Api.Entities.ProgramStudy;
using Web.Api.Helpers;
using Web.Api.Infrastucture.Context;

namespace Web.Api.Service.ProgramStudy.Command
{
    public class ProgramStudyCommand
    {
        private readonly DataContext contex;

        public ProgramStudyCommand(DataContext context)
        {
            this.contex = context;
        }

        public async Task<ProgramStudyCreateResponse> CreateProgramStudy(ProgramStudyCreateRequest request)
        {
            var programStudyRequest = new ProgramStudyEntity()
            {
                programStudyName = request.programStudyName,
                headOfTheStudyProgram = request.headOfTheStudyProgram,
                studyProgramSecretary = request.studyProgramSecretary,
                prgramStudyAccreditation = request.prgramStudyAccreditation,
                educationalLevel = request.educationalLevel,
                dateOfEstablishment = request.dateOfEstablishment,
                establishmentDecreeNumber = request.establishmentDecreeNumber,
                emailProgramStudy = request.emailProgramStudy,
                facultyId = Guid.Parse(request.faculty.value),
                facultyName = request.faculty.label,
                createdBy = "Admin",
                createdAt = DateTimeOffset.Now
            };
            
            contex.ProgramStudys.Add(programStudyRequest);

            await contex.SaveChangesAsync();

            var response = new ProgramStudyCreateResponse()
            {
                id = Guid.NewGuid(),
                programStudyName = request.programStudyName,
                headOfTheStudyProgram = request.headOfTheStudyProgram,
                studyProgramSecretary = request.studyProgramSecretary,
                prgramStudyAccreditation = request.prgramStudyAccreditation,
                educationalLevel = request.educationalLevel,
                dateOfEstablishment = request.dateOfEstablishment,
                establishmentDecreeNumber = request.establishmentDecreeNumber,
                emailProgramStudy = request.emailProgramStudy,
                faculty = new DropdownResponse()
                {
                    label = request.faculty.label,
                    value = request.faculty.value
                }
            };
            return response;

        }

    }
}