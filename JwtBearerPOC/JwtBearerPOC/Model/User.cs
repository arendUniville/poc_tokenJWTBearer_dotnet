namespace JwtBearerPOC.Model;

public record User(Guid Id, string Email, string Password, string[] Roles, string[] Tenant);
