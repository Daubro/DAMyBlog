﻿using Microsoft.AspNetCore.Identity;

namespace MyBlog.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public List<Post>? Posts { get; set; }
    }
}
