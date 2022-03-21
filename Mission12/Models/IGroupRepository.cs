using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public interface IGroupRepository
    {
        public IQueryable<Group> Groups { get; }

        public void SaveGroup(Group group);
        public void CreateGroup(Group group);
        public void DeleteGroup(Group group);
    }
}
