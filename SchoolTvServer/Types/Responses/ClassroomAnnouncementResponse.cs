namespace SchoolTvServer.Types.Responses;

public record ClassroomAnnouncementResponse
{
    public required string UserName { get; set; }
    public required string UserPhotoUrl { get; set; }
    public required string Text { get; set; }
    public required DateTimeOffset CreationDate { get; set; }
    public required DateTimeOffset LastModifiedDate { get; set; }
}