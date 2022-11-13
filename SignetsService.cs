using Models;
using System;
using System.Xml.Linq;

public class SignetsService : ISignetsService
{
  public string echo(string chaine)
  {
    Console.WriteLine($"Test Method Executed! {chaine}");
    return chaine;
  }
  public string HelloWorld()
  {
    throw new NotImplementedException();
  }

  public string donneesAuthentificationValides(string codeAccesUniversel, string motPasse)
  {
    throw new NotImplementedException();
  }

  public string infoEtudiant(string codeAccesUniversel, string motPasse)
  {
    throw new NotImplementedException();
  }

  public string lireEvaluationCours(string codeAccesUniversel, string motPasse, string pSession)
  {
    throw new NotImplementedException();
  }

  public string lireHoraire(string pSession, string prefixSigleCours)
  {
    throw new NotImplementedException();
  }

  public string lireHoraireDesSeances(string codeAccesUniversel, string motPasse, string pCoursGroupe, string pSession, string pDateDebut, string pDateFin)
  {
    throw new NotImplementedException();
  }

  public string lireJoursRemplaces(string pSession)
  {
    throw new NotImplementedException();
  }

  public string listeCoequipiers(string codeAccesUniversel, string motPasse, string pSigle, string pGroupe, string pSession, string pNomElementEval)
  {
    throw new NotImplementedException();
  }

  public string listeCours(string codeAccesUniversel, string motPasse)
  {
    throw new NotImplementedException();
  }

  public string listeCoursIntervalleSessions(string codeAccesUniversel, string motPasse)
  {
    throw new NotImplementedException();
  }

  public string listeElementsEvaluation(string codeAccesUniversel, string motPasse, string pSigle, string pGroupe, string pSession)
  {
    throw new NotImplementedException();
  }
}