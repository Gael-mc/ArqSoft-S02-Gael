Console.WriteLine("¿Que juego quieres jugar?");
Console.WriteLine("  1 — Ahorcado");
Console.WriteLine("  2 — Viborita");
Console.Write("Opcion: ");
var opcion = Console.ReadLine();

if (opcion == "2")
{
    var motor = new Ahorcado.MotorViborita();
    var ui = new Ahorcado.ConsolaUIViborita(motor);

    Console.CursorVisible = false;

    while (!motor.Ganado() && !motor.Perdido())
    {
        ui.MostrarTablero();
        var tecla = ui.LeerTecla();

        if (tecla == ConsoleKey.Q) break;
        if (tecla != ConsoleKey.NoName)
            motor.CambiarDireccion(tecla);

        motor.Avanzar();
        Thread.Sleep(150);
    }

    ui.MostrarTablero();
    ui.MostrarMensaje(motor.Ganado()
        ? "\n¡Ganaste! Llegaste a 10 puntos."
        : "\nGame over.");
}
else
{
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
}