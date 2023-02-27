namespace Shared.GCode.V2;

public record Code(string? GCode, IEnumerable<(char, string)>? Parameters, string? Comment)
{
    public static Code? Parse(string text)
    {
        var line = text.AsSpan();
        var commentIndex = line.IndexOf(';');
        var comment = commentIndex < 0 ? null : line[commentIndex..].ToString();
        var nonComment = commentIndex < 0 ? line : line[..commentIndex];

        if (nonComment.IsWhiteSpace())
        {
            return new Code(null, null, comment);
        }

        var parts = nonComment.ToString().Split(' ', StringSplitOptions.TrimEntries);

        var command = ValidateCommand(parts[0]);
        var parameters = parts[1..]
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .Select(x => ParseParameter(x.AsSpan()))
            .ToList();

        return new Code(command, parameters, comment);
    }

    private static string? ValidateCommand(ReadOnlySpan<char> code)
    {
        if (code.IsEmpty || code.IsWhiteSpace())
            return null;

        if (!char.IsLetter(code[0]))
        {
            throw new Exception($"'{code}' is not a valid G-Code.");
        }

        if (!int.TryParse(code[1..], out _))
        {
            throw new Exception($"'{code}' is not a valid G-Code.");
        }

        return code.ToString();
    }

    private static string? GetCode(ReadOnlySpan<char> code) => code switch
    {
        "G0" => "G0",
        "G1" => "G1",
        "G28" => "G28",
        "G90" => "G90",
        "G91" => "G91",
        "G92" => "G92",
        "M104" => "M104",
        "M105" => "M105",
        "M106" => "M106",
        "M107" => "M107",
        "M109" => "M109",
        "M140" => "M140",
        "M190" => "M190",
        "M201" => "M201",
        "M203" => "M203",
        "M204" => "M204",
        "M205" => "M205",
        "M220" => "M220",
        "M221" => "M221",
        "M420" => "M420",
        "M82" => "M82",
        "M84" => "M84",
            _ => null
    };

    private static (char Name, string Value) ParseParameter(ReadOnlySpan<char> parameter)
    {
        if (!char.IsLetter(parameter[0]))
        {
            throw new Exception($"'{parameter}' is not a valid G-Code parameter.");
        }

        return new(parameter[0], parameter[1..].ToString());
    }
}
