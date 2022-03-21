using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class EFGroupRepository : IGroupRepository
    {
        private GroupContext context;

        public EFGroupRepository(GroupContext temp)
        {
            context = temp;
        }

        public IQueryable<Group> Groups => context.Groups;

        public void SaveGroup(Group group)
        {
            context.SaveChanges();
        }

        public void CreateGroup(Group group)
        {
            context.Add(group);
            context.SaveChanges();
        }

        public void DeleteGroup(Group group)
        {
            context.Remove(group);
            context.SaveChanges();
        }
    }
}
