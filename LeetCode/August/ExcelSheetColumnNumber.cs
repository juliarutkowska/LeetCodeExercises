namespace LeetCode;

public class ExcelSheetColumnNumber 
{
    public int TitleToNumber(string columnTitle)
    {
        return columnTitle.Select(t => t - 'A' + 1).Aggregate(0, (current, value) => current * 26 + value);
    }
}