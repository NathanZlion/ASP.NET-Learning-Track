
public static class UtilMethods
{

    public static string GetGrade(double points)
    {
        if (points >= 90.0)
            return "A";
        else if (points >= 80.0)
            return "B";
        else if (points >= 70.0)
            return "C";
        else if (points >= 60.0)
            return "D";
        else if (points >= 50.0)
            return "E";
        else
            return "F";
    }

    public static bool IsValidPoint(double point)
    {
        return 0.0 <= point && point <= 100.0;
    }
}
