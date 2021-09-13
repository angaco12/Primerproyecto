using System;
namespace AspNetCoreWebAPI.Infrastructure.Models
{
    public class User
    {
        public string NickName { get; set; }

        public string Id { get; set; }
        public string FirtsName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}