using System.ComponentModel.DataAnnotations;

namespace ActivityCenter.Models
{
    public class Association
    {
        [Key]
        public int AssociationId{get;set;}
        public int UserId{get;set;}
        public int ActivityId{get;set;}
        public User NavigationalUser{get;set;}
        public Activ NavigationalActivity{get;set;}
    }
}