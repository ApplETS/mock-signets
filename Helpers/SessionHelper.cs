namespace Helpers;

public class Session
{
  
  public enum SessionTime {
    H = 0,
    E = 1,
    A= 2
  }
  public string Code { get; set; }
}

public static class DateTimeSessionExtensions 
{
  public static string ToSession(this DateTime date)
  {
    var year = date.Year;
    var month = date.Month;
    var session = month < 9 ? "H" : "A";
    return $"{year}{session}";
  }

  public static Session GetSessionFromDate(this DateTime dateTime)
  {
    if (dateTime.Month >= 1 && dateTime.Month <= 4)
    {
      return new Session { Code = "H" + dateTime.Year };
    }
    else if (dateTime.Month >= 5 && dateTime.Month <= 8)
    {
      return new Session { Code = "E" + dateTime.Year };
    }
    else
    {
      return new Session { Code = "A" + dateTime.Year };
    }
  }
}


public static class SessionExtensions
{
    public static Session AddSessions(this Session session, int nbOfSession)
    {
        // Add the number of session to the current session to create a new session in past or future
        var year = int.Parse(session.Code.Substring(1));
        var sessionCode = session.Code.Substring(0, 1);

        var sessionTime = (Session.SessionTime)Enum.Parse(typeof(Session.SessionTime), sessionCode);
        var newSessionTime = (int)sessionTime + nbOfSession;
        var addThisManyYears = newSessionTime / 3;
        var newSessionTimeModulo = newSessionTime % 3;

        return new Session()
        {
            Code = ((Session.SessionTime)newSessionTimeModulo).ToString() + (year + addThisManyYears)
        };
    }
}