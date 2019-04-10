using Capitulo01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capitulo01.Data
{
    public class IESDbInitializer
    {
        public static void Initialize(IESContext context)
        {
            context.Database.EnsureCreated();

            InicializarDepartamentos(context);
            InicializarInstituicoes(context);
        }

        private static void InicializarInstituicoes(IESContext context)
        {
            if (context.Instituicoes.Any())
            {
                return;
            }

            var instituicoes = new Instituicao[]
            {
                new Instituicao()
                {
                    InstituicaoID = 1,
                    Nome = "UniParaná",
                    Endereco = "Paraná"
                },
                new Instituicao()
                {
                    InstituicaoID = 2,
                    Nome = "UniSanta",
                    Endereco = "Santa Catarina"
                },
                new Instituicao()
                {
                    InstituicaoID = 3,
                    Nome = "UniSaoPaulo",
                    Endereco = "São Paulo"
                },
                new Instituicao()
                {
                    InstituicaoID = 4,
                    Nome = "UniSulgrandense",
                    Endereco = "Rio Grande do Sul"
                },
                new Instituicao()
                {
                    InstituicaoID = 5,
                    Nome = "UniCarioca",
                    Endereco = "Rio de Janeiro"
                }
            };
            foreach (Instituicao i in instituicoes)
            {
                context.Instituicoes.Add(i);
            }
            context.SaveChanges();
        }

        private static void InicializarDepartamentos(IESContext context)
        {
            if (context.Departamentos.Any())
            {
                return;
            }

            var departamentos = new Departamento[]
            {
                new Departamento {Nome="Ciência da Computação" },
                new Departamento {Nome="Ciência de Alimento"}
            };

            foreach (Departamento d in departamentos)
            {
                context.Departamentos.Add(d);
            }
            context.SaveChanges();
        }
    }
}
