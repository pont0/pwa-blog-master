using System.Collections.Generic;

namespace PWABlog.ViewModels.Admin
{
    public class AdminEtiquetasCriarViewModel : ViewModelAreaAdministrativa
    {
       
        public ICollection<CategoriaAdminEtiquetas> Categorias { get; set; }


        public AdminEtiquetasCriarViewModel()
        {
            TituloPagina = "Criar nova Etiqueta";
            Categorias = new List<CategoriaAdminEtiquetas>();
        }

        public string Erro { get; set; }
    }

    public class CategoriaAdminEtiquetas
    {
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
    }
}