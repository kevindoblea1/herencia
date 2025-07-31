public class Moto : Vehiculo
{
    public int Cilindrada { get; set; }
    public bool TieneMaletero { get; set; }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Cilindrada: {Cilindrada}cc, Tiene Maletero: {(TieneMaletero ? "Sí" : "No")}");
    }
}