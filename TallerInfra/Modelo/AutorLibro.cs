namespace TallerInfra.Modelo
{
    public class AutorLibro
    {
        public int  IdAutorLibro { get; set; }
        public string Nombre { get; set;  }
        public string Apellido { get; set;  }

        public ICollection <GradoAcademico> GradosAcademicos { get; set;  }
        public DateTime FechaNacimiento { get; set;  }

        public String CentroAcademico { get; set; }
        public Guid GuidAutorLibro { get; set; }


   
    }



}
