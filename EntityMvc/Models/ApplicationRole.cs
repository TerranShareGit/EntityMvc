﻿using Microsoft.AspNet.Identity.EntityFramework;

namespace EntityMvc.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() { }

        public string Description { get; set; }
    }
}