using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuRegistrarBandas : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registro de bandas");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (!bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = new Banda(nomeDaBanda);
            bandasRegistradas.Add(banda.Nome, banda);
            Console.WriteLine($"Banda {nomeDaBanda} registrada com sucesso!");
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} já está registrada.");
        }

        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}