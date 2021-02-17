using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assign5.Models
{
    public interface IProjectRepository
    {
        IQueryable<Project> Projects { get; }
    }
}
