namespace Models.Entities;
public class EvaluationCours
{
    public int Id { get; set; }
    public string Sigle { get; set; }
    public string Groupe { get; set; }
    public string Enseignant { get; set; }
    public DateTime CodeProf { get; set; }
    public DateTime CodeEtudiant { get; set; }
    public string TypeEvaluation { get; set; }
    public bool EstComplete { get; set; }

    public User user { get; set; }
}
