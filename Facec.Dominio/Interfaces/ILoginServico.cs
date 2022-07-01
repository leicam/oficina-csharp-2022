using Facec.Dominio.Entidades;

namespace Facec.Dominio.Interfaces
{
    public interface ILoginServico
    {
        string Autenticacao(Usuario usuario);
    }

}