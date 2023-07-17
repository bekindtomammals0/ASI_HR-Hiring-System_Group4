using Basecode.Data.ViewModels;
using static Basecode.Services.Services.ErrorHandling;

namespace Basecode.Services.Interfaces
{
    public interface IStudentService
    {
        Log Register(StudentModel studentModel);
    }
}
