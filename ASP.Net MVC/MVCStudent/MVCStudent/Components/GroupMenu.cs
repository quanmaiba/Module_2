using Microsoft.AspNetCore.Mvc;
using MVCStudent.Models;
using System.Linq;

namespace MVCStudent.Components
{
    public class GroupMenu : ViewComponent
    {
        private readonly IGroupRepository groupRepository;

        public GroupMenu(IGroupRepository groupRepository)
        {
            this.groupRepository = groupRepository;
        }

        public IViewComponentResult Invoke()
        {
            var group = groupRepository.GetGroupsAll.OrderBy(g => g.GroupName);

            return View(group);
        }
    }
}
