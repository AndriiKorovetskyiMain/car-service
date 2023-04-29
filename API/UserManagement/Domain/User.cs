namespace UserManagementDomain;

public record User
{

    public int Id { get; init; } = -1;
    public string Username { get; init; } = string.Empty;
    public string Password { get; init; } = string.Empty;
    public string Email { get; init; } = string.Empty;
    public bool IsActive { get; init; } = false;
    public DateTime CreatedDate { get; init; } = DateTime.Now;
    public DateTime? LastModifiedDate { get; init; } = DateTime.Now;
}