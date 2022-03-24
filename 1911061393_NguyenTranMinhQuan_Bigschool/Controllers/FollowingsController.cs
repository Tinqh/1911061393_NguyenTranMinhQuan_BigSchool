using _1911061393_NguyenTranMinhQuan_Bigschool.DTOs;
using _1911061393_NguyenTranMinhQuan_Bigschool.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1911061393_NguyenTranMinhQuan_Bigschool.Controllers
{
    public class FollowingsController : ApiController
    {
        
            private readonly ApplicationDbContext _dbContext;
            public FollowingsController() { _dbContext = new ApplicationDbContext(); }

            //commit lusc 13h20 ngay 22/03

            public IHttpActionResult Follow(FollowingDto followingDto)
            {
                var userId = User.Identity.GetUserId();
                if (_dbContext.Followings.Any(f => f.FolloweeId == userId && f.FolloweeId == followingDto.FolloweeId))
                    return BadRequest("The Attendance already exists!");
                var folowing = new Following
                {
                    FollowerId = userId,
                    FolloweeId = followingDto.FolloweeId

                };

                _dbContext.Followings.Add(folowing);
                _dbContext.SaveChanges();

                return Ok();
            }
    }
}
