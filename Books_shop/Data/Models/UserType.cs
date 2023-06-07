using Microsoft.AspNetCore.Identity;
using Books_shop.Data.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Providers.Entities;

namespace Books_shop.Data.Models
{
    public class UserType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<User> Users { get; set; }
    }
}