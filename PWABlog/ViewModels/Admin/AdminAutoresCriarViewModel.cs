using PWABlog.ViewModels;
using System.Collections.Generic;



public class AdminAutoresCriarViewModel : ViewModelAreaAdministrativa
    {
       
        public ICollection<AutorAdminAutores> Autores { get; set; }

        public AdminAutoresCriarViewModel()
        {
            TituloPagina = "Criar novo autor";
            Autores = new List<AutorAdminAutores>();
        }

    public string Erro { get; set; }
}




    public class AutorAdminAutores
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

