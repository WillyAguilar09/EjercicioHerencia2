

namespace EjercicioHerencia
{
    public class Triangulo:Valores
    {
        public double area { get; set; }
        public void Imprimir()
        {

            area = (Valor1 * Valor2)/2;
            Console.WriteLine($"El Area del Triangulo es:{area}");

        }
    }
}
