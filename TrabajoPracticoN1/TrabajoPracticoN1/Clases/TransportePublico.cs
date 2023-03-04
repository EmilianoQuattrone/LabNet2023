namespace TrabajoPracticoN1.Clases
{
    public abstract class TransportePublico
    {

        public int Pasajeros { set; get; }

        public int Id { set; get; }
        public abstract void Avanzar();
        public abstract void Detenerse();
    }
}