using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assign5.Models
{
    public class EFProjectRepository : IProjectRepository
    {
        private ProjectDBContext _context;

        //constructor
        public EFProjectRepository (ProjectDBContext context)
        {
            _context = context;
        }
        public IQueryable<Project> Projects => _context.Projects;
    }
}
