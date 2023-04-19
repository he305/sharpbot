using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstracts;

public interface IUserRepository
{
    Task<IReadOnlyCollection<User>> GetAllAsync();
    Task CreateAsync(User user);

}

