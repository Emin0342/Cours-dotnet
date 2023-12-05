namespace webapi;

public class Emprunt
{
    public int Id { get; set; }

    public int IdBook { get; set; }

    public int IdUser { get; set; }

    public DateTime DateEmprunt { get; set; }

    public DateTime DateRetour { get; set; }

    public string? Commentaire { get; set; }

    public bool Rendu { get; set; }
}