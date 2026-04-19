namespace Application.DTOs.UserDTO.Responses;

public class UserResponse
{
    public int? Id { get; set; }
    public string? UserId { get; set; }
    public string? FullName { get; set; }
    public string? MailAddress { get; set; }
    public SectionResponse? Section { get; set; }
}

public class SectionResponse
{
    public int? Id { get; set; }
    public string? Name { get; set; }
    public DepartmentResponse? Department { get; set; }
}

public class DepartmentResponse
{
    public int? Id { get; set; }
    public string? Name { get; set; }
}
