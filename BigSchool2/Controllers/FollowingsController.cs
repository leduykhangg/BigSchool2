using BigSchool2.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BigSchool2.Controllers
{
    public class FollowingsController : ApiController
    {
        BigSchoolContext context = new BigSchoolContext();
        [HttpPost]
        public IHttpActionResult Follow(following follow)
        {
            //user login là người theo dõi, follow.FolloweeId là người được theo dõi

            var userID = User.Identity.GetUserId();
            if (userID == null)

                return BadRequest("Please login first!");
            if (userID == follow.followeeId)
                return BadRequest("Can not follow myself!");
            BigSchoolContext context = new BigSchoolContext();
            //kiểm tra xem mã userID đã được theo dõi chưa

            following find = context.followings.FirstOrDefault(p => p.followerId ==

            userID && p.followeeId == follow.followeeId);

            if (find != null)

            {
                context.followings.Remove(context.followings.SingleOrDefault(p => p.followerId == userID && p.followeeId == follow.followeeId));
                context.SaveChanges();
                return Ok("cancel");
            }
            //set object follow
            follow.followerId = userID;
            context.followings.Add(follow);
            context.SaveChanges();
            return Ok();
        }
    }
}
