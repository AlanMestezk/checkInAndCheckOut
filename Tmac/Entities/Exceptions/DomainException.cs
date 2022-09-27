
namespace Tmac.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string mensage): base(mensage)
        {
        }
    }
}
