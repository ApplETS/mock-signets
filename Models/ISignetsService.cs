using System.ServiceModel;

namespace Models;

[ServiceContract(Namespace = "http://etsmtl.ca/")]
public interface ISignetsService
{
  [OperationContract]
  string HelloWorld();

  [OperationContract]
  string echo(string chaine);

  [OperationContract]
  string donneesAuthentificationValides(string codeAccesUniversel, string motPasse);


  [OperationContract]
  string infoEtudiant(string codeAccesUniversel, string motPasse);

  [OperationContract]
  string lireEvaluationCours(string codeAccesUniversel, string motPasse, string pSession);

  [OperationContract]
  string lireHoraire(string pSession, string prefixSigleCours);

  [OperationContract]
  string lireHoraireDesSeances(string codeAccesUniversel, string motPasse, string pCoursGroupe, string pSession, string pDateDebut, string pDateFin);

  [OperationContract]
  string lireJoursRemplaces(string pSession);

  [OperationContract]
  string listeCoequipiers(string codeAccesUniversel, string motPasse, string pSigle, string pGroupe, string pSession, string pNomElementEval);

  [OperationContract]
  string listeCours(string codeAccesUniversel, string motPasse);

  [OperationContract]
  string listeCoursIntervalleSessions(string codeAccesUniversel, string motPasse);

  [OperationContract]
  string listeElementsEvaluation(string codeAccesUniversel, string motPasse, string pSigle, string pGroupe, string pSession);
}