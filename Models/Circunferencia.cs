using BLL;

namespace Models
{
    public class Circunferencia
    {
        // Encapsulación. Un Campo es encapsulado por un Getter y un Setter para validar el cumplimiento de relas de negocop. Radio > 0
        //Campo
        private double radio;

        //Getter
        public double GetRadio()
        {
            return this.radio;

        }

        // Setter
        public void SetRadio(double radio) {
            try
            {
                Validacion.ValidarRadio(radio);
            }catch (Exception ex) {
                throw new ArgumentException(ex.Message);
            }
            this.radio = radio; //Validar Radio MAyor a cero
        }

        public double Area()
        {
            return Math.PI * Math.Pow(this.radio, 2);
        }

        public double Perimetro()
        {
            return 2 *Math.PI * this.radio;
        }
    }
}
