using Microsoft.EntityFrameworkCore;
using TallerInfra.Modelo; 

namespace TallerInfra.Persistencia
{


    public class ContextoAutor: DbContext 
    {
        public ContextoAutor(DbContextOptions<ContextoAutor> options): base(options  
           )
        {

        }
        public DbSet<AutorLibro> AutorLibros { get; set;  }
        public DbSet<GradoAcademico> GradoAcademicos { get; set; }
    }
}
