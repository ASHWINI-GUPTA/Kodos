using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kodos.Models
{
    public class SkiCard
    {
        public int Id { get; set; }
        /// <summary>
        /// The Id of the ApplicationUser who owns the Ski Card 
        /// </summary>
        public string ApplicationUserId { get; set; }

        public DateTime CreatedOn { get; set; }

        [Required]
        [MaxLength(70)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(70)]
        public string LastName { get; set; }

        public DateTime CardHolderBirthDate { get; set; }

        [Phone] public string CardHolderPhoneNumber { get; set; }

    }
}
