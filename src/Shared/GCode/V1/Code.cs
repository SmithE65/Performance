namespace Shared.GCode.V1;

public record Code(string? GCode, IEnumerable<(char, float?)>? Parameters, string? Comment)
{
    public static Code? Parse(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return null;
        }

        var splits = text.Split(';');

        var comment = splits.Length > 1 ? string.Join(";", splits[1..]) : null;

        if (string.IsNullOrWhiteSpace(splits[0]))
        {
            return new Code(null, null, comment);
        }

        var parts = splits[0].Split(' ', StringSplitOptions.TrimEntries);

        var command = ValidateCommand(parts[0]);
        var parameters = parts[1..]
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .Select(ParseParameter)
            .ToList();

        return new Code(command, parameters, comment);
    }

    private static string? ValidateCommand(string? code)
    {
        if (string.IsNullOrWhiteSpace(code))
        {
            return null;
        }

        if (!char.IsLetter(code.First()))
        {
            throw new Exception($"'{code}' is not a valid G-Code.");
        }

        if (!int.TryParse(code[1..], out _))
        {
            throw new Exception($"'{code}' is not a valid G-Code.");
        }

        return code;
    }

    private static (char Name, float? Value) ParseParameter(string parameter)
    {
        if (!char.IsLetter(parameter.First()))
        {
            throw new Exception($"'{parameter}' is not a valid G-Code parameter.");
        }

        return new(parameter.First(), float.TryParse(parameter[1..], out var value) ? value : null);
    }
}
