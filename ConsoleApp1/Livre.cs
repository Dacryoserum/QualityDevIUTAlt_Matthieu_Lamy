
namespace ConsoleApp1;


public class Livre : Media
{
    public String titre { get; set; }
    public String auteur { get; set; }
    
    public override void AfficherInfos()
    {
        base.AfficherInfos();
        Console.WriteLine("Titre : " + titre);
        Console.WriteLine("Auteur : " + auteur);
    }
}