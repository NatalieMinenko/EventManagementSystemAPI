using Moq;
using EventManagementSystem.DAL.Repositories.Interfaces;
using EventManagementSystem.DAL.DTOs;
using EventManagementSystem.BLL.Interfaces;
using EventManagementSystem.BLL.Exceptions;

namespace EventManagementSystem.BLL.Tetst;

public class UsersServicesTests
{
    private readonly Mock<IUserRepository> _userRepositoryMock;
    private readonly Mock<IEventRepository> _eventRepositoryMock;
    private readonly Mock<IRegisterRepository> _registerRepositoryMock;
    private readonly UsersServices _sut;

    public UsersServicesTests() 
    {
        _userRepositoryMock = new Mock<IUserRepository>();
        _eventRepositoryMock = new Mock<IEventRepository>();
        _registerRepositoryMock = new Mock<IRegisterRepository>();
        _sut = new UsersServices(_userRepositoryMock.Object, _eventRepositoryMock.Object, _registerRepositoryMock.Object);
    }
    [Fact]
    public void Test1()
    {

        // Arrange
        

        // Act
        

        // Assert

    }
}