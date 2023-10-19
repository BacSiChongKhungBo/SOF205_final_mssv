using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.DomainClass;

[Table("SINHVIEN")]
[Index("Email", Name = "UQ__SINHVIEN__AB6E6164A6DA5B20", IsUnique = true)]
public partial class Sinhvien
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("ten")]
    [StringLength(50)]
    public string Ten { get; set; } = null!;

    [Column("email")]
    [StringLength(50)]
    [Unicode(false)]
    public string Email { get; set; } = null!;

    [Column("sdt")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Sdt { get; set; }

    [Column("diachi")]
    [StringLength(100)]
    public string? Diachi { get; set; }

    [Column("idPH")]
    public int? IdPh { get; set; }

    [ForeignKey("IdPh")]
    [InverseProperty("Sinhviens")]
    public virtual Phuhuynh? IdPhNavigation { get; set; }
}
