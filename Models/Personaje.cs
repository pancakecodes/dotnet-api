using System.ComponentModel.DataAnnotations;

namespace BackendAternaNet.Models;
public class PersonajeModel
{
    /// <summary>
    /// Represent Personaje's unique identifier 
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Represent Personaje's Name 
    /// </summary>
    [MaxLength(150)]
    [MinLength(3)]
    public string Nombre { get; set; } = string.Empty;
    
    /// <summary>
    /// Represent Personaje's AlterEgo 
    /// </summary>
    [Required]
    public string Alte { get; set; } = string.Empty;

    public string Rol { get; set; } = string.Empty;
}