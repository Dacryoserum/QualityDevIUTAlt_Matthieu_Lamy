namespace ConsoleApp1;

public class cd : Media
{
    public String artiste { get; set; }


    public override void AfficherInfos()
    {
        base.AfficherInfos();
        Console.WriteLine("Artiste : " + artiste);
    }
}