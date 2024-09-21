namespace AccountManagement.Domain.RoleAgg;

public class Permission
{
    public Permission(int code)
    {
        Code = code;
    }

    public Permission(int code, string name)
    {
        Code = code;
        Name = name;
    }

    protected Permission()
    {

    }

    public long Id { get; }
    public int Code { get; private set; }
    public string Name { get; private set; }
    public long RoleId { get; }
    public Role Role { get; }
}