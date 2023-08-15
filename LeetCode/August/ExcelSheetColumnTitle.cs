using System.Text;

namespace LeetCode;

public class ExcelSheetColumnTitle {
    public string ConvertToTitle(int columnNumber)
    {
        var result = new StringBuilder();
        while (columnNumber > 0)
        {
            columnNumber--;
            var currentChar = (char)('A' + columnNumber % 26);
            result.Insert(0, currentChar);
            columnNumber /= 26;
        }

        return result.ToString();
    }
}