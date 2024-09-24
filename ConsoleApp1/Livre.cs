
namespace ConsoleApp1;


public class Livre : Media
{
    private String titre { get; set; }
    private String auteur { get; set; }
    
    public override void AfficherInfos()
    {
        base.AfficherInfos();
        Console.WriteLine("Titre : " + titre);
        Console.WriteLine("Auteur : " + auteur);
    }
}