using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace aafeben.Models
{
    public enum SupportedLanguages
    {
        en,fr
    }

    public class BlogModel
    {
        public int Id { get; set;}

        public required string Title {get; set;}

        public required SupportedLanguages Lang {get; set;}

        public required string Content { get; set;}



        public DateTime CreatedOn {get; set;}
        public DateTime updatedOn {get; set;}

        public bool Draft { get; set;}

        // relationships
        public int UserId { get; set;}
        public UserModel User {get; set;}

    }
}