namespace ConsoleApp1;

public class dvd : Media
{
    private String titre { get; set; }
    private String duree { get; set; }


    public override void AfficherInfos()
    {
        base.AfficherInfos();
        Console.WriteLine("Titre : " + titre);
    }

}

