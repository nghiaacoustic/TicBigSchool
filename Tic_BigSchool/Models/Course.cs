using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Tic_BigSchool.Models;

namespace TiC_BigSchool.Models
{
    public class Course
    {
   //     [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
   //     [Key]
        public int Id { get; set; }
        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerId { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime DateTime { get; set; }
        public CateGory Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }
      //  public int UserId { get; set; }
    }
}