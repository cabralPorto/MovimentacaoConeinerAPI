﻿namespace ProjetoAPICore.Modelos
{
    public class PassagemConteiner : Entidade 
    {
        public int IdPassagemConteiner { get; set; }
        public int IdConteiner { get; set; }
        public string Categoria { get; set; }

        public string Status { get; set; }

        
    }
}
