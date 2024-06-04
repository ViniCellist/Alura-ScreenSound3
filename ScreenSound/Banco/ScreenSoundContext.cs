using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;

internal class ScreenSoundContext: DbContext
{
    public DbSet<Artista> Artistas { get; set; }

    private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

       protected override void OnConfigure(DbContextOptionsBuilder optionsBuilder)
       {
            optionsBuilder.UseSqlServer(connectionString);
       }

}
