﻿using System.Collections.Generic;

namespace PWABlog.ViewModels.Admin
{
    public class AdminAutoresListarViewModel : ViewModelAreaAdministrativa
    {

        public ICollection<AutorAdminAutores> Autores { get; set; }

        public AdminAutoresListarViewModel()
        {
            TituloPagina = "Autores - Administrador";
            Autores = new List<AutorAdminAutores>();
        }
    }

    public class AutorAdminAutores
    {
        public int Id { get; set; }
        public string Nome { get; set; }
       
    }
}