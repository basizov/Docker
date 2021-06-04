using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Core.Base;
using Core.DTOs;
using Domain.Entities;
using Infrstructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Core.Users
{
  public class List
  {
    public class Query : IRequest<Result<List<UserDTO>>> { }
    public class Handler : IRequestHandler<Query, Result<List<UserDTO>>>
    {
      private readonly DataContext _context;
      private readonly IMapper _mapper;

      public Handler(DataContext context, IMapper mapper)
      {
        _mapper = mapper;
        _context = context;
      }

      public async Task<Result<List<UserDTO>>> Handle(Query request, CancellationToken cancellationToken)
      {
        var users = await _context.Users
          .ProjectTo<UserDTO>(_mapper.ConfigurationProvider)
          .ToListAsync();

        return Result<List<UserDTO>>.Success(users);
      }
    }
  }
}