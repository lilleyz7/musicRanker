namespace musicRanker.Entities;

class Band
{
    public required string Name { get; set; }
    public required int YearFormed { get; set; }

    public required List<Album> Albums { get; set; } = new List<Album>();
}