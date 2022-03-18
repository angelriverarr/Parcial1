using Lab1_Notas.Models;
namespace Lab1_Notas.Bussines
{
    public class Operaciones
    {
        public int index(Acciones acciones)
        {
            if (acciones.Monto % 5 == 0)
            {
                int descuento = (acciones.Monto - 5000); //estableci un monto incial
                return descuento;
            }
            else {
                int descuento = 0;
                return descuento;
            }
        }
      

    }
}
