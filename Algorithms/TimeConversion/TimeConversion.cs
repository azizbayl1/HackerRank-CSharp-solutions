class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string TimeConversion(string s)
    {
        s = s.Insert(s.Length - 2, " ");
        DateTime dateTime = DateTime.ParseExact(s, "h:mm:ss tt", null);
        string formattedTime = dateTime.ToString("HH:mm:ss");
        return formattedTime;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.TimeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
