﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VisualBasicWinFormsCoreApp.Data.Entities
{
    public partial class Territories
    {
        public Territories()
        {
            Employee = new HashSet<Employees>();
        }

        [Key]
        [StringLength(20)]
        public string TerritoryID { get; set; }
        [Required]
        [StringLength(50)]
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }

        [ForeignKey("RegionID")]
        [InverseProperty("Territories")]
        public virtual Region Region { get; set; }

        [ForeignKey("TerritoryID")]
        [InverseProperty("Territory")]
        public virtual ICollection<Employees> Employee { get; set; }
    }
}