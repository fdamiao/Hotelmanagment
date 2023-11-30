using HotelManagment.Modelos;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hotelmanagment.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
        public DbSet<Quartos> quartos { get; set; } 
     public DbSet<Salas> Salas { get; set; } 
     public DbSet<Servicos> Servicos { get; set; } 
     public DbSet<Suprimentos> Suprimentos { get; set; } 
     public DbSet<Booking> Bookings { get; set; } 
     public DbSet<QurtosSuprimetos> QuartosSuprimetos { get; set; } 
     public DbSet<SalasSuprimetos> SalasSuprimetos { get; set; } 
     public DbSet<SalaaddSupri> SalaadedSupris { get; set; } 

public DbSet<Clientes> Clientes { get; set; } = default!;

public DbSet<HotelManagment.Modelos.Tiposdequarto> Tiposdequarto { get; set; }
}
