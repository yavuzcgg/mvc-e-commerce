using System.ComponentModel.DataAnnotations;

namespace Mvc_E_Commerce.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    public int ParentCategoryId { get; set; }
    [Required]
    public string CategoryName { get; set; }
    public string CategoryImage { get; set; }
    public int DisplayOrder { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
}