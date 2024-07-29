

namespace EjercicioHerencia
{
    internal class Cuadrado:Valores
    {
        public double area {  get; set; }


        public void Imprimir()
        {

            area = Valor1 * Valor2;
            Console.WriteLine($"El Area del Cuadrado es:{area}");
            
        }
    }
}
