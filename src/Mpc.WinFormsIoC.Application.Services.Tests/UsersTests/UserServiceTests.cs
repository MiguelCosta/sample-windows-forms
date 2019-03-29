using System.Threading.Tasks;
using AutoFixture;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Mpc.WinFormsIoC.Application.Dto;
using Mpc.WinFormsIoC.Application.Services.Mappings;
using Mpc.WinFormsIoC.Application.Services.Security;
using Mpc.WinFormsIoC.Application.Services.Users;
using Mpc.WinFormsIoC.Domain.Core;

namespace Mpc.WinFormsIoC.Application.Services.Tests.UsersTests
{
    [TestClass]
    public class UserServiceTests
    {
        private Fixture _fixture;
        private Mock<IUnitOfWork> _unitOfWorkMok;
        private Mock<IEncryptText> _encryptTextMock;
        private UserService _userService;

        [TestInitialize]
        public void Begin()
        {
            _fixture = new Fixture();
            _unitOfWorkMok = new Mock<IUnitOfWork>();
            _encryptTextMock = new Mock<IEncryptText>();
            _userService = new UserService(_encryptTextMock.Object, _unitOfWorkMok.Object);
        }

        [TestMethod]
        public async Task CreateAsync_InsertValidInformation_PassordIsEncryptedAndUserIsCreated()
        {
            // Arrange
            const string plainTestPassword = "PlainTextPassword";
            const string encryptedPassword = "EncryptedPassword";

            var userDto = _fixture
                .Build<UserDto>()
                .With(x => x.Password, plainTestPassword)
                .Create();

            _encryptTextMock
                .Setup(s => s.Encrypt(plainTestPassword))
                .Returns(encryptedPassword);

            _unitOfWorkMok
                .Setup(s => s.UsersRepository.InsertAsync(
                    It.Is<Domain.Models.UserModel>(u => u.Password == encryptedPassword)))
                .Returns(Task.CompletedTask);

            _unitOfWorkMok
                .Setup(s => s.SaveChangesAsync())
                .Returns(Task.CompletedTask);

            // Act
            var result = await _userService.CreateAsync(userDto);

            // Assert
            _unitOfWorkMok.VerifyAll();
            result.Password.Should().Be(UserMapping.HidePassword);
        }

        [TestMethod]
        public void CreateAsync_InsertUserWithoudPassword_ThrowBadRequestException()
        {
            // Arrange

            // Act

            // Assert
        }
    }
}
