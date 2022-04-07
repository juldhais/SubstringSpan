using BenchmarkDotNet.Attributes;

namespace SubstringSpan;

[MemoryDiagnoser]
public class BenchmarkSubstringSpan
{
    private const string Text = "Lorem ipsum dolor sit amet.";
    
    [Benchmark]
    public string Substring()
    {
        var substring1 = Text.Substring(6, 5);
        var substring2 = Text.Substring(18, 3);
        var substring3 = string.Concat(substring1, substring2);
        return substring3;
    }

    [Benchmark]
    public string Span()
    {
        var textSpan = Text.AsSpan();
        var spanSlice1 = textSpan.Slice(6, 5);
        var spanSlice2 = textSpan.Slice(18, 3);
        var spanSlice3 = string.Concat(spanSlice1, spanSlice2);
        return spanSlice3;
    }
}