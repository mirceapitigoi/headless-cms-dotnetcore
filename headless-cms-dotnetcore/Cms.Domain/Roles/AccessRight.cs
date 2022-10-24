using Cms.Domain.Contracts;

namespace Cms.Domain.Roles
{
    internal class AccessRight : ValueObject
    {
    }

    internal class EditRight: AccessRight
    { }

    internal class DeleteRight: AccessRight
        {}

    internal class CreateRight: AccessRight
    { }

    internal class ReadRight : AccessRight
    { }
}