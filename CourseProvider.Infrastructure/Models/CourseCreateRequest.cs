using CourseProvider.Infrastructure.Data.Entities;

namespace CourseProvider.Infrastructure.Models;

public class CourseCreateRequest
{ 
    public string? ImageUri { get; set; }
    public string? ImageHeaderUri { get; set; }
    public bool IsBestseller { get; set; }
    public bool IsDigital { get; set; }
    public string Title { get; set; } = null!;
    public string? Ingress { get; set; }
    public decimal StarRating { get; set; }
    public string? Reviews { get; set; }
    public string? Hours { get; set; }
    public string LikesInProcent { get; set; } = null!;
    public string LikesInNumbers { get; set; } = null!;
    public string[]? Categories { get; set; }

    public virtual List<AuthorCreateRequest>? Authors { get; set; }
    public virtual PriceCreateRequest? Prices { get; set; }
    public virtual ContentCreateRequest? Content { get; set; }
}
public class AuthorCreateRequest
{
    public string? Name { get; set; }
}
public class PriceCreateRequest
{
    public string? Currency { get; set; }
    public decimal Price { get; set; }
    public decimal Discount { get; set; }
}
public class ContentCreateRequest
{
    public string? Description { get; set; }
    public string[]? Includes { get; set; }
    public virtual List<ProgramDetailItemCreateRequest>? ProgramDetails { get; set; }
}
public class ProgramDetailItemCreateRequest
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}
