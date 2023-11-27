using System;
using System.Data;

Console.WriteLine("КАЛЬКУЛЯТОР\n");

Console.Write("Пример: ");
string problem = Console.ReadLine();

var result = EvaluateExpression(problem);
Console.Write($"Ответ: {result}\n");

List<string> problems = new List<string>();
List<int> results = new List<int>();

bool trigger = true;
int action;

while (trigger)
{
    Console.WriteLine("\nЧто бы Вы хотели сделать?\n" + "1. Решить новый пример.\n" + "2. Выйти из приложения.\n");

    Console.Write("Выберите действие: ");
    action = Convert.ToInt32(Console.ReadLine());

    switch (action)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("КАЛЬКУЛЯТОР\n");

            Console.Write("Пример: ");
            problem = Console.ReadLine();

            result = EvaluateExpression(problem);
            Console.Write($"Ответ: {result}\n");

            problems.Add(problem);
            results.Add(Convert.ToInt32(result));

            break;

        case 2:
            Console.Clear();
            Console.WriteLine("Благодарим за использование нашего калькулятора!");
            trigger = false;
            break;
    }
}

static double EvaluateExpression(string expression)
{
    expression = expression.Replace(" ", "");

    DataTable data = new DataTable();
    data.Columns.Add("expression", typeof(string), expression);
    DataRow row = data.NewRow();
    data.Rows.Add(row);
    return Convert.ToDouble((string)row["expression"]);
}

//-----------------------------------------------------------------------------------------

// Ниже решение, если не зачтете первое 😔😔

//Console.WriteLine("КАЛЬКУЛЯТОР\n");

//Console.Write("Пример: ");
//string problem = Console.ReadLine();

//string[] symbols = problem.Split(' ');

//Solution();
//Console.WriteLine("Ответ: " + symbols[0]);

//bool trigger = true;
//int action;

//while (trigger)
//{
//    Console.WriteLine("\nЧто бы Вы хотели сделать?\n" + "1. Решить новый пример.\n" + "2. Выйти из приложения.\n");

//    Console.Write("Выберите действие: ");
//    action = Convert.ToInt32(Console.ReadLine());

//    switch (action)
//    {
//        case 1:
//            Console.Clear();
//            Console.WriteLine("КАЛЬКУЛЯТОР\n");
//            Console.Write("Пример: ");
//            problem = Console.ReadLine();
//            symbols = problem.Split(' ');
//            Solution();
//            Console.WriteLine("Ответ: " + symbols[0]);
//            break;

//        case 2:
//            Console.Clear();
//            Console.WriteLine("Благодарим за использование нашего калькулятора!");
//            trigger = false;
//            break;
//    }
//}

//// РЕШЕНИЕ ПРИМЕРА
//void Solution()
//{
//    while (symbols.Length > 1)
//    {
//        for (int i = 0; i < symbols.Length; i++)
//        {
//            if (symbols[i] == "*" || symbols[i] == "/")
//            {
//                symbols = Multi_Div(symbols);
//            }
//        }

//        for (int i = 0; i < symbols.Length; i++)
//        {
//            if (symbols[i] == "+" || symbols[i] == "-")
//            {
//                int left = Convert.ToInt32((symbols[i - 1]));
//                int right = Convert.ToInt32((symbols[i + 1]));
//                int result;

//                if (symbols[i] == "+")
//                {
//                    result = left + right;
//                }
//                else
//                {
//                    result = left - right;
//                }

//                string[] newSymbols = new string[symbols.Length - 2];
//                Array.Copy(symbols, 0, newSymbols, 0, i - 1);
//                newSymbols[i - 1] = result.ToString();
//                Array.Copy(symbols, i + 2, newSymbols, i, symbols.Length - i - 2);

//                symbols = newSymbols;
//                break;
//            }
//        }
//    }
//}

//// ПРИОРИТЕТ ОПЕРАЦИЙ * и /
//string[] Multi_Div(string[] symbols)
//{
//    for (int i = 0; i < symbols.Length; i++)
//    {
//        if (symbols[i] == "*" || symbols[i] == "/")
//        {
//            int left = Convert.ToInt32((symbols[i - 1]));
//            int right = Convert.ToInt32((symbols[i + 1]));
//            int result;

//            if (symbols[i] == "*")
//            {
//                result = left * right;
//            }
//            else
//            {
//                result = left / right;
//            }

//            string[] newSymbols = new string[symbols.Length - 2];
//            Array.Copy(symbols, 0, newSymbols, 0, i - 1);
//            newSymbols[i - 1] = result.ToString();
//            Array.Copy(symbols, i + 2, newSymbols, i, symbols.Length - i - 2);

//            symbols = newSymbols;
//            break;
//        }
//    }

//    return symbols;
//}