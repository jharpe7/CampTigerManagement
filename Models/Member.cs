using System.ComponentModel.DataAnnotations;
namespace CampTiger.Models{
    public class Member{
        public int MemberId{get;set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password {get; set;}
        public string DOB {get; set;}
        public string Address {get; set;}
        public string City {get; set;}
        public string State {get; set;}
    }
}