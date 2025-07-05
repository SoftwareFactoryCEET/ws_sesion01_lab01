namespace BLL
{
    public static class Validacion
    {
        public static void ValidarRadio(double radio)
        {
            if (radio < 0)
            {
                throw new ArgumentException("El valor del radio no debe ser menor que cero (0)");
            }
        }
    }
}
