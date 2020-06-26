using PWABlog.ViewModels;
using System.Collections.Generic;


    public class AdminPostagensCriarViewModel : ViewModelAreaAdministrativa
    {
       
        public ICollection<PostagemAdminPostagens> Postagens { get; set; }


        public AdminPostagensCriarViewModel()
        {
            TituloPagina = "Criar nova Postagem";
            Postagens = new List<PostagemAdminPostagens>();
        }

        public string Erro { get; set; }
    }



    public class PostagemAdminPostagens
    {
    public int Id { get; set; }

    public string Titulo { get; set; }

    public string Descricao { get; set; }

    public string NomeAutor { get; set; }

    public string NomeCategoria { get; set; }
}
