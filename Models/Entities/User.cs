namespace Models.Entities;
public class User
{
    public int Id { get; set; }
    public string CodeAccesUniversel { get; set; }
    public string MotPasse { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string CodePermanent { get; set; }
    public string SoldeTotal { get; set; }
    public bool Masculin { get; set; }
}