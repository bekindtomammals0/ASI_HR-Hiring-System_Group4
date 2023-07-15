using AutoMapper;
using Basecode.Data.Interfaces;
using Basecode.Data.ViewModels;
using Basecode.Services.Interfaces;
using Basecode.Services.Services;
using Basecode.WebApp.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Basecode.Test
{
    public class UnitTest1
    {
        private readonly IJobOpeningRepository _repository;
        private readonly IStudentService _service;
        private readonly IMapper _mapper;


        //Controller
        [Fact]
        public void Test1()
        {
            //Arrange

            var serviceMock = new Mock<IStudentService>();

            StudentModel studentModel = new StudentModel();
            serviceMock.Setup(s => s.Register(studentModel)).Returns(new ErrorHandling.Log { Result = true });

            var controller = new StudentController(serviceMock.Object);

            // Act
            var result = controller.Register(studentModel);

            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Home", redirectToActionResult.ControllerName);
            Assert.Equal("Index", redirectToActionResult.ActionName);
        }

        //Service
        [Fact]
        public void Test2()
        {
            // Arrange
            var service = new StudentService();
            var studentModel = new StudentModel
            {
                PhoneNumber = "1234567890" // Assuming an invalid phone number
            };

            // Act
            var result = service.Register(studentModel);

            // Assert
            Assert.False(result.Result);
            Assert.Equal("ALARM1", result.ErrorCode);
            Assert.Equal("Phone Number doesn't start with 09", result.Message);
        }
    }
}