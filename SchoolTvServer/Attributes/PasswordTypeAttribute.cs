using SchoolTvServer.Types;

namespace SchoolTvServer.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public class PasswordTypeAttribute(AccessType accessType) : Attribute
{
    public AccessType AccessType { get; } = accessType;
}