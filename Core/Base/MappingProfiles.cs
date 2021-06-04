using AutoMapper;
using Core.DTOs;
using Domain.Entities;

namespace Core.Base
{
  public class MappingProfiles : Profile
  {
    public MappingProfiles()
    {
      CreateMap<User, UserDTO>();
      CreateMap<User, LoginDTO>();
    }
  }
}