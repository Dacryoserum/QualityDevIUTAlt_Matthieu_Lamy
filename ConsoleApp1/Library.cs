using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1;

public class Library
{
    private List<Media> ListeMedia = new List<Media>();
    
    public Media this[int numReference]
    {
        get
        {
            return ListeMedia.FirstOrDefault(m => m.numReference == numReference);
        }
    }

    public void AjouterMedia(Media media)
    {
        ListeMedia.Add(media);
        Console.WriteLine($"Le média '{media.Titre}' a été ajouté à la bibliothèque.");
    }

    public void RetirerMedia(int numReference)
    {
        var media = ListeMedia.FirstOrDefault(m => m.numReference == numReference);
        if (media != null)
        {
            ListeMedia.Remove(media);
            Console.WriteLine($"Le média '{media.Titre}' a été retiré de la bibliothèque.");
        }
        else
        {
            Console.WriteLine("Aucun média trouvé avec ce numéro de référence.");
        }
    }

    public void EmprunterMedia(int numReference)
    {
        var media = this[numReference];
        if (media != null)
        {
            if (media.nbrExemplaireDispo > 0)
            {
                media.nbrExemplaireDispo--;
                Console.WriteLine($"Le média '{media.Titre}' a été emprunté. Il reste {media.nbrExemplaireDispo} exemplaire(s).");
            }
            else
            {
                Console.WriteLine($"Désolé, le média '{media.Titre}' n'est pas disponible pour l'emprunt.");
            }
        }
        else
        {
            Console.WriteLine("Aucun média trouvé avec ce numéro de référence.");
        }
    }

    public void RetournerMedia(int numReference)
    {
        var media = this[numReference];
        if (media != null)
        {
            media.nbrExemplaireDispo++;
            Console.WriteLine($"Le média '{media.Titre}' a été retourné. Il y a maintenant {media.nbrExemplaireDispo} exemplaire(s) disponible(s).");
        }
        else
        {
            Console.WriteLine("Aucun média trouvé avec ce numéro de référence.");
        }
    }

    public List<Media> RechercherMedia(string critere)
    {
        var resultats = ListeMedia.Where(m => 
            m.Titre.Contains(critere, StringComparison.OrdinalIgnoreCase) ||
            (m is Livre livre && livre.auteur.Contains(critere, StringComparison.OrdinalIgnoreCase)) ||
            (m is cd cd && cd.artiste.Contains(critere, StringComparison.OrdinalIgnoreCase)) ||
            (m is dvd dvd && dvd.titre.Contains(critere, StringComparison.OrdinalIgnoreCase))
        ).ToList();

        if (resultats.Any())
        {
            Console.WriteLine($"Résultats de la recherche pour '{critere}':");
            foreach (var media in resultats)
            {
                media.AfficherInfos();
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine($"Aucun résultat trouvé pour '{critere}'.");
        }

        return resultats;
    }
}