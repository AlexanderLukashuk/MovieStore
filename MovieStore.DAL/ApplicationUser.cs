using System;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MovieStore.DAL
{
	public class ApplicationUser : IdentityUser
	{
		public string? Name { get; set; }
	}
}

