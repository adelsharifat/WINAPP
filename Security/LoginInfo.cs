using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    public class LoginInfo
    {
        public static int Id { get; set; } = 2348;
        public static string UserName { get; set; }
        public static string FirstName { get; set; } = "حسینعلی";
        public static string LastName { get; set; } = "خلیفه";
        public static string JobTitle { get; set; } = "کارشناس  دفتر فنی برق";
        public static DateTime? LastLogin { get; set; } = DateTime.Now;
        public static string Company { get; set; }
        public static int CompanyId { get; set; }
        public static string FullName => $"{FirstName} {LastName}";
        public static bool LoggedIn => Id != 0;
        public static int ProjectId { get; set; } = 1;
        public static string ProjectName { get; set; } = "Arup-1071";
        public static string Email { get; set; } = "test@test.com";
    }
}
