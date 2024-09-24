namespace ConsoleApp1;

public class cd : Media
{
    private String artiste { get; set; }


    public override void AfficherInfos()
    {
        base.AfficherInfos();
        Console.WriteLine("Artiste : " + artiste);
    }
}