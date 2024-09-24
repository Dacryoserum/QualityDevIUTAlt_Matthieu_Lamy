namespace ConsoleApp1;

public class dvd : Media
{
    public String titre { get; set; }
    private String duree { get; set; }


    public override void AfficherInfos()
    {
        base.AfficherInfos();
        Console.WriteLine("Titre : " + titre);
    }

}

