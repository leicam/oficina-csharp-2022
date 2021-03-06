using Facec.Dominio.Interfaces;
using Facec.Servicos.Classes;
using Infraestrutura.Repositorio.Classes;
using SimpleInjector;
using System;

namespace Facec.IoC
{
    public static class Instalador
    {
        public static void Registrar(ref Container container)
        {
            container
                .Register<IUsuarioRepositorio, UsuarioRepositorio>(Lifestyle.Singleton);

            container
                .Register<IUsuarioServico, UsuarioServico>(Lifestyle.Singleton);

            container
                .Register<ILoginServico, LoginServico>(Lifestyle.Singleton);
        }
    }
}