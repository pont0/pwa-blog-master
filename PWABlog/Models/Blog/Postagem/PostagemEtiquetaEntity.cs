using PWABlog.Models.Blog.Etiqueta;
using System.ComponentModel.DataAnnotations;

namespace PWABlog.Models.Blog.Postagem
{
    public class PostagemEtiquetaEntity
    {
        [Key]
        public int Id { get; set; }

        public PostagemEntity Postagem { get; set; }

        public EtiquetaEntity Etiqueta { get; set; }
    }
}