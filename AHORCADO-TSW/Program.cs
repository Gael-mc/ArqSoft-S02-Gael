Console.WriteLine("=== AHORCADO ===");
string categoria = Ahorcado.ConsolaUI.PedirCategoria();
var repositorio = new Ahorcado.PalabrasEnMemoria(categoria);

do
{
    var motor = new Ahorcado.MotorAhorcado(repositorio);
    var ui = new Ahorcado.ConsolaUI(motor);

    while (!motor.Ganado() && !motor.Perdido())
    {
        ui.MostrarTablero();
        char letra = ui.PedirLetra();
        if (motor.LetraYaUsada(letra))
        {
            ui.MostrarMensaje("Ya usaste esa letra.");
            continue;
        }
        motor.RegistrarLetra(letra);
    }

    ui.MostrarTablero();
    if (motor.Ganado())
        ui.MostrarMensaje($"\n¡Ganaste! La palabra era: {motor.PalabraSecreta}");
    else
        ui.MostrarMensaje($"\nPerdiste. La palabra era: {motor.PalabraSecreta}");

} while (new Ahorcado.ConsolaUI(new Ahorcado.MotorAhorcado(repositorio)).PreguntarOtraVez());

Console.WriteLine("\n¡Hasta luego!");