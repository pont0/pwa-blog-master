using System.Collections.Generic;

namespace PWABlog.ViewModels.Admin
{
    public class AdminCategoriasListarViewModel : ViewModelAreaAdministrativa
    {


        public ICollection<CategoriaAdminCategorias> Categorias { get; set; }

        public AdminCategoriasListarViewModel()
        {
            TituloPagina = "Categorias - Administrador";
            Categorias = new List<CategoriaAdminCategorias>();
        }
    }

    public class CategoriaAdminCategorias
    {
        public int Id { get; set; }
        public string Nome { get; set; }

    }
}