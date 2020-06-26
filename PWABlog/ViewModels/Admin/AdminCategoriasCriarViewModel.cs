using System.Collections.Generic;

namespace PWABlog.ViewModels.Admin
{
    public class AdminCategoriasCriarViewModel : ViewModelAreaAdministrativa
    {
        public string Erro { get; set; }

        public ICollection<CategoriaAdminCategorias> Categorias { get; set; }


        public AdminCategoriasCriarViewModel()
        {
            TituloPagina = "Criar nova Categoria";
            Categorias = new List<CategoriaAdminCategorias>();
        }
    }
}



    public class CategoriaAdminCategorias
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
