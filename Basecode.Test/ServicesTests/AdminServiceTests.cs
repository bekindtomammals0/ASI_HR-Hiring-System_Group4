using Basecode.Data.Interfaces;
using Basecode.Services.Services;
using Microsoft.AspNetCore.Identity;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace Basecode.Services.Tests
{
    public class AdminServiceTests
    {
        private readonly AdminService _adminService;
        private readonly Mock<IAdminRepository> _adminRepositoryMock;

        public AdminServiceTests()
        {
            // Arrange: Initialize the mocks and dependencies for each test
            _adminRepositoryMock = new Mock<IAdminRepository>();
            _adminService = new AdminService(_adminRepositoryMock.Object);
        }

        [Fact]
        public async Task CreateRole_ReturnsIdentityResult_WhenRoleNameIsValid()
        {
            // Arrange
            // ...

            // Act
            // ...

            // Assert
            // ...
        }

        [Fact]
        public async Task CreateRole_ReturnsIdentityResult_WhenRoleNameIsInvalid()
        {
            // Arrange
            // ...

            // Act
            // ...

            // Assert
            // ...
        }
    }
}
