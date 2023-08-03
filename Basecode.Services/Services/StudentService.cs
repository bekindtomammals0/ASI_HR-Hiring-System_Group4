using Basecode.Data.ViewModels;
using Basecode.Services.Interfaces;

namespace Basecode.Services.Services
{
    public class StudentService : ErrorHandling, IStudentService
    {
        public Log Register(StudentModel? studentModel)
        {
            Log log =  new Log();

            if (!studentModel.PhoneNumber.StartsWith("09"))
            {
                log.Result = false;
                log.ErrorCode = "ALARM1";
                log.Message = "Phone Number doesn't start with 09";
            }
            return log; 
        }

    }
}
