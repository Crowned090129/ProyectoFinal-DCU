using System;

namespace BusApp.Data.Entities
{
    public class User
	{
		public int UserId { get; set; }
		public int PersonId { get; set; }
		public string UserName { get; set; }
		public string UPassword { get; set; }
		public DateTime Ctrl_F_Inserted { get; set; }
		public DateTime Ctrl_L_Deleted { get; set; }
	}
}
