public class Carro : Vehiculo
{
    public int NumeroPuertas { get; set; }
    public string TipoCombustible { get; set; }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Número de Puertas: {NumeroPuertas}, Tipo de Combustible: {TipoCombustible}");
    }
}