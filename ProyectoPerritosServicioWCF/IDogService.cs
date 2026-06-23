using System.ServiceModel;

namespace ProyectoPerritosServicioWCF
{
    /// Contrato del servicio WCF.
    /// Define las operaciones que podrán ser consumidas
    /// desde el proyecto MVC.
    [ServiceContract]
    public interface IDogService
    {
        /// Obtiene una imagen aleatoria de perro
        /// desde la API Dog CEO.
        [OperationContract]
        string ObtenerImagenAleatoriaPerro();
    }
}