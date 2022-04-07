using BenchmarkDotNet.Running;
using SubstringSpan;

BenchmarkRunner.Run<BenchmarkSubstringSpan>();

const string text = "Lorem ipsum dolor sit amet.";
var substring1 = text.Substring(6, 5);
var substring2 = text.Substring(18, 3);
var substring3 = string.Concat(substring1, substring2);
Console.WriteLine($"Substring: {substring3}");

var textSpan = text.AsSpan();
var spanSlice1 = textSpan.Slice(6, 5);
var spanSlice2 = textSpan.Slice(18, 3);
var spanSlice3 = string.Concat(spanSlice1, spanSlice2);
Console.WriteLine($"Span.Slice: {spanSlice3}");