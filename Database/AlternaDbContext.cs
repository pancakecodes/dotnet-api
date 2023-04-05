using BackendAternaNet.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendAternaNet.Database;
public class AlternaDbContext : DbContext
{
   ///<summary>
   /// Represent a Entity Repository for manipulate Personaje's table
   ///</summary>
    public DbSet<PersonajeModel> Personaje { get; }
    public AlternaDbContext(DbContextOptions<AlternaDbContext> options) : base(options)
    {
        Personaje = Set<PersonajeModel>();
    }
}