using PWABlog.ViewModels;
using System.Collections.Generic;


    public class AdminPostagensEditarViewModel : ViewModelAreaAdministrativa
    {


    public int Id { get; set; }

    public string Titulo { get; set; }

    public string NomeAutor { get; set; }

    public string NomeCategoria { get; set; }

    public ICollection<PostagemAdminPostagens> Postagens { get; set; }


        public AdminPostagensEditarViewModel()
        {
            TituloPagina = "Editar Postagem";
            Postagens = new List<PostagemAdminPostagens>();
        }

        public string Erro { get; set; }
    }



  
    

