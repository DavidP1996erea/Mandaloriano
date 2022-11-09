using DAL;
using Entidades;

namespace BL
{
    /// <summary>
    /// Método que retorna una lista completa de misiones, que recoge de la DAL
    /// Precondición: Nada
    /// Postcondición: Retorna una lista completa de misiones
    /// </summary>
    public class clsListaMisionesBL
    {
        public static List<clsMisiones> listaMisionesCompletaBL()
        {

            return clsListaMisiones.listaMisionesCompleta();
        }
    }
}