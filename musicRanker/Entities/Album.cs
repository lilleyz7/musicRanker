namespace musicRanker.Entities;

public class Album
{
    public required string AlbumName { get; set; }
    public required int ReleaseYear { get; set; }
    
    public required Band CreatedBy { get; set; }
    public required int BandId { get; set; }
}