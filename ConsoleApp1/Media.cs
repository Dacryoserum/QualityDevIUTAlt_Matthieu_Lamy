namespace ConsoleApp1;

public class Media
{
    public String Titre { get; set;  }
    public int numReference { get; set; }
    public int nbrExemplaireDispo { get; set; }

    public virtual void AfficherInfos()
    {
        Console.WriteLine("Titre : " + Titre);
        Console.WriteLine("NumReference : " + numReference);
        Console.WriteLine("nbr d'exemplaire : "+ nbrExemplaireDispo);
    }
}
