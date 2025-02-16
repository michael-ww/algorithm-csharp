namespace Belly.Algorithm.LeetCode;

public class LeetCode168
{
    public string ConvertToTitle(int columnNumber)
    {
        if (columnNumber <= 0)
        {
            return string.Empty;
        }

        StringBuilder sb = new();
        while (columnNumber > 0)
        {
            columnNumber--;
            sb.Append((char)(columnNumber % 26 + 'A'));
            columnNumber /= 26;
        }

        string answer = sb.ToString();
        sb.Clear();
        for (int i = answer.Length - 1; i >= 0; i--)
        {
            sb.Append(answer[i]);
        }
        return sb.ToString();
    }

    private string GetAlpha(int index)
    {
        string answer = string.Empty;
        switch (index)
        {
            case 1:
                answer = "A";
                break;
            case 2:
                answer = "B";
                break;
            case 3:
                answer = "C";
                break;
            case 4:
                answer = "D";
                break;
            case 5:
                answer = "E";
                break;
            case 6:
                answer = "F";
                break;
            case 7:
                answer = "G";
                break;
            case 8:
                answer = "H";
                break;
            case 9:
                answer = "I";
                break;
            case 10:
                answer = "J";
                break;
            case 11:
                answer = "K";
                break;
            case 12:
                answer = "L";
                break;
            case 13:
                answer = "M";
                break;
            case 14:
                answer = "N";
                break;
            case 15:
                answer = "O";
                break;
            case 16:
                answer = "P";
                break;
            case 17:
                answer = "Q";
                break;
            case 18:
                answer = "R";
                break;
            case 19:
                answer = "S";
                break;
            case 20:
                answer = "T";
                break;
            case 21:
                answer = "U";
                break;
            case 22:
                answer = "V";
                break;
            case 23:
                answer = "W";
                break;
            case 24:
                answer = "X";
                break;
            case 25:
                answer = "Y";
                break;
            case 26:
                answer = "Z";
                break;
            default:
                break;
        }
        return answer;
    }
}
