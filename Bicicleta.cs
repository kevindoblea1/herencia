public class Bicicleta : Vehiculo
{
    public string Tipo { get; set; }  // Ej: "Montaña", "Ruta"

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Tipo de Bicicleta: {Tipo}");
    }
}
