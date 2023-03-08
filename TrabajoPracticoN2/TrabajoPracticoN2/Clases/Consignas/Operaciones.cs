namespace TrabajoPracticoN2.Clases.Consignas
{
    public class Operaciones
    {
        public static decimal DivisionEJN1(decimal dividendo)
        {
            decimal division;
            decimal divisor = 0;
            division = (dividendo / divisor);
            return division;
        }

        public static decimal DivisionEJN2(decimal dividendo, decimal divisor)
        {
            decimal operacion;
            operacion = (dividendo / divisor);
            Mensajes.MensajeResultadoDivision(operacion);
            return operacion;
        }
    }
}