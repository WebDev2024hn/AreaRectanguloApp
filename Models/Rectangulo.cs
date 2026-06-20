namespace AreaRectanguloApp.Models;

public class Rectangulo
{
    public double Base { get; set; }

    public double Altura { get; set; }

    public double Area => Base * Altura;
}