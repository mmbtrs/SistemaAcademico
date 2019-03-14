using SistemaAcademico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAcademico.Data
{
    public class DbInitializer
    {
        public static void Initialize(SistemaAcademicoContext context)
        {
            context.Database.EnsureCreated(); //Se crea la base dedatos 

            //Buscar si existen registros en la tabla Categoria
            if (context.Categoria.Any())
            {
                return;
            }
            var categorias = new Categoria[]
            {
                new Categoria{Nombre="Programación", Descripcion="Curso de Programación", Estado=true},
                new Categoria{Nombre="Diseño gráfico", Descripcion="Curso de diseño gráfico", Estado=true}
            };

            foreach (Categoria categoria in categorias)
            {
                context.Categoria.Add(categoria);
            }

            context.SaveChanges();
        }
    }
}
