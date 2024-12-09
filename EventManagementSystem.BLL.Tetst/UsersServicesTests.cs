using Moq;
using EventManagementSystem.DAL.Repositories.Interfaces;
using EventManagementSystem.DAL.DTOs;
using EventManagementSystem.BLL.Interfaces;
using EventManagementSystem.BLL.Exceptions;
using EventManagementSystem.BLL.Mappings;
using EventManagementSystem.BLL.ExceptionMiddleware;
using AutoMapper;
using System;
using System.Data;

namespace EventManagementSystem.BLL.Tetst;

public class UsersServicesTests
{
    private readonly Mock<IUserRepository> _userRepositoryMock;
    private readonly Mapper _mapper;
    private readonly UsersServices _sut;

    public UsersServicesTests() 
    {
        _userRepositoryMock = new();
        var config = new MapperConfiguration(
        cfg =>
        {
            cfg.AddProfile(new UserMapperProfile());
        });
        _mapper = new Mapper(config);
        _sut = new(_userRepositoryMock.Object, _mapper);
    }
    //[Fact]
    //public Test()
    //{
    //    //Arrange
       
    //    //Act

    //    //Assert
        
    //}
}