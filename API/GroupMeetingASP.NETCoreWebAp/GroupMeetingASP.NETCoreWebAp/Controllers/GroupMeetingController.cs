using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupMeetingASP.NETCoreWebAp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GroupMeetingASP.NETCoreWebAp.Controllers
{
    public class GroupMeetingController : Controller
    {
        // GET: GroupMeeting
        public IActionResult Index()
        {
            return View(GroupMeeting.GetGroupMeetings());
        }

        // GET: GroupMeeting/Details/5
        public IActionResult GroupMeetingDetails(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var group = GroupMeeting.GetGroupMeetingById(id);
            if (group == null)
            {
                return NotFound();
            }
            return View(group);
        }

        // GET: GroupMeeting/Create
        public IActionResult AddGroupMeeting()
        {
            return View();
        }

        // POST: GroupMeeting/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddGroupMeeting(GroupMeeting groupMeeting)
        {
            if (ModelState.IsValid)
            {
                if (GroupMeeting.InsertGroupMeeting(groupMeeting) > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(groupMeeting);
          
        }

        // GET: GroupMeeting/Edit/5
        public IActionResult UpdateGroupMeeting(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var group = GroupMeeting.GetGroupMeetingById(id);
            if (group == null)
            {
                return NotFound();
            }
            return View(group);
        }

        // POST: GroupMeeting/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult UpdateGroupMeeting(int id ,[Bind] GroupMeeting groupMeeting)
        {
            if (id != groupMeeting.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                GroupMeeting.UpdateGroupMeeting(groupMeeting);
                return RedirectToAction(nameof(Index));
            }
            return View(groupMeeting);
        }
      
        public IActionResult DeleteGroupMeeting(int id)
        {
            var group = GroupMeeting.GetGroupMeetingById(id);
            if (group==null)
            {
                return NotFound();
            }
            return View(group);
        }

        // POST: GroupMeeting/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteGroupMeeting(int id, GroupMeeting groupMeeting)
        {
            if (GroupMeeting.DeleteGroupMeeting(id) > 0)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(groupMeeting);
          
        }
    }
}