using System.Collections.Generic;

namespace PWABlog.ViewModels.Admin
{
    public class AdminCategoriasEditarViewModel : ViewModelAreaAdministrativa
    {
        public string Erro { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<CategoriaAdminCategorias> Categorias { get; set; }


        public AdminCategoriasEditarViewModel()
        {
            TituloPagina = "Editar Categoria";
            Categorias = new List<CategoriaAdminCategorias>();
        }
    }
}

 
