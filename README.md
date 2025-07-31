# 📚 Herencia

Este es un proyecto de consola en C# para practicar herencia de clases mediante la gestión de diferentes tipos de vehículos.

## 🚗 Descripción

Se implementa una clase base `Vehiculo` con propiedades comunes como marca, modelo y año, y clases derivadas:

- `Carro`: incluye número de puertas y tipo de combustible.
- `Moto`: incluye cilindrada y si tiene maletero.
- `Bicicleta`: incluye tipo de bicicleta (ej. montaña, ruta).

Cada clase tiene un método `MostrarInformacion()` que imprime los datos en la consola.

## 📁 Estructura del Proyecto

CursoVehiculos/
├── Program.cs
├── Vehiculo.cs
├── Carro.cs
├── Moto.cs
├── Bicicleta.cs
├── CursoVehiculos.csproj
├── .gitignore

markdown
Mostrar siempre los detalles

Copiar

## ▶️ Ejecución

### Requisitos:
- [.NET SDK](https://dotnet.microsoft.com/en-us/download) instalado (recomendado .NET 6 o superior)
- Terminal o Visual Studio Code

### Pasos:

1. Abre la terminal en la carpeta del proyecto.
2. Ejecuta:

```bash
dotnet build
dotnet run
Verás impresa la información de varios vehículos precargados.

👨‍💻 Autor
Kevin Alvarenga – @kevindoblea1
