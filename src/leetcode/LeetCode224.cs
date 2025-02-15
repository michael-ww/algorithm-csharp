namespace Algorithm.LeetCode;

public class LeetCode224
{
    public int Calculate(string s)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(s);
        int where = 0;
        return this.Calculate(s.ToCharArray(), 0, ref where);
    }

    private int Calculate(char[] input, int index, ref int where)
    {
        int current = 0;
        List<int> numbers = new();
        List<char> operators = new();
        while (index < input.Length && input[index] != ')')
        {
            if (input[index] >= '0' && input[index] <= '9')
            {
                current = current * 10 + input[index++] - '0';
            }
            else if (input[index] == '+' || input[index] == '-' || input[index] == '*' || input[index] == '/')
            {
                this.Push(numbers, operators, current, input[index++]);
                current = 0;
            }
            else if (input[index] == '(')
            {
                current = this.Calculate(input, index + 1, ref where);
                index = where + 1;
            }
        }
        this.Push(numbers, operators, current, '+');
        where = index;
        return this.Compute(numbers, operators);
    }

    private void Push(List<int> numbers, List<char> operators, int current, char op)
    {
        if (numbers.Count <= 0 || operators.Last() == '+' || operators.Last() == '-')
        {
            numbers.Add(current);
            operators.Add(op);
        }
        else
        {
            int lastNumber = numbers.Last();
            int lastOperator = operators.Last();
            if (lastOperator == '*')
            {
                numbers[^1] = lastNumber * current;
            }
            else if (lastOperator == '/')
            {
                numbers[^1] = lastNumber / current;
            }
            operators[^1] = op;
        }
    }

    private int Compute(List<int> numbers, List<char> operators)
    {
        int answer = numbers[0];
        for (int i = 1; i < numbers.Count; i++)
        {
            answer = operators[i - 1] == '+' ? answer + numbers[i] : answer - numbers[i];
        }
        return answer;
    }
}
