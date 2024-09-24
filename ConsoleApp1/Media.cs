namespace ConsoleApp1;

public class Media
{
    private String Titre { get; set;  }
    private int numReference { get; set; }
    public int nbrExemplaireDispo { get; set; }

    public virtual void AfficherInfos()
    {
        Console.WriteLine("Titre : " + Titre);
        Console.WriteLine("NumReference : " + numReference);
        Console.WriteLine("nbr d'exemplaire : "+ nbrExemplaireDispo);
    }
}
