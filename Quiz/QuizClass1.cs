namespace Quiz
{
    public string GradeArray(string grd)
    {
        switch (grd)
        {
            case "":
                goto default;
            case "E":
                return "Excellent";
            case "V":
                return "Very Good";
            case "G":
                return "Good";
            case "A":
                return "Average";
            case "F":
                return "Fail";
            default:
                return "Not a Valid Grade";
        }

    }
}