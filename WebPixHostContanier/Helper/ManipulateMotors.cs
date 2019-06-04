using System;
using System.Collections.Generic;
using System.Text;
using WpHostEntidade;

namespace WebPixHostContanier.Helper
{
    public static class ManipulateMotors
    {
        public static List<Motores> getMotors()
        {
            List<Motores> motores = new List<Motores>();
            Motores obj1 = new Motores
            {
                ArquivoBat = @"C:\Users\Matheus Ferreira\Desktop\testeAPI.bat",
                IDProcesso = "1",
                Ativo = true,
                DataCriacao = DateTime.Now,
                DateAlteracao = DateTime.Now,
                Descricao = "teste",
                ID = 1,
                idCliente = 0,
                Metodo = "",
                Nome = "APIIN",
                Status = 4, //Ativo para publicação
                Url = "localhost:5300",
                UsuarioCriacao = 1,
                UsuarioEdicao = 1
            };
            Motores obj2 = new Motores
            {
                ArquivoBat = @"C:\Users\Matheus Ferreira\Desktop\testeAPI2.bat",
                IDProcesso = "1",
                Ativo = true,
                DataCriacao = DateTime.Now,
                DateAlteracao = DateTime.Now,
                Descricao = "teste",
                ID = 1,
                idCliente = 0,
                Metodo = "",
                Nome = "APIIN",
                Status = 4, //Ativo para publicação
                Url = "localhost:5300",
                UsuarioCriacao = 1,
                UsuarioEdicao = 1
            };
            motores.Add(obj1);
            motores.Add(obj2);
            return motores;
        }
    }
}
