﻿public class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Año { get; set; }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Año: {Año}");
    }
}