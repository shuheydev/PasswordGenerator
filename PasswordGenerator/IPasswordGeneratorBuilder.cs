using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGen
{
    public interface IPasswordGeneratorBuilder
    {
        int RequiredLength { get; }
        int RequiredUniqueChars { get; }
        bool RequireNonAlphanumeric { get; }
        bool RequireLowercase { get; }
        bool RequireUppercase { get; }
        bool RequireDigit { get; }

        IPasswordGeneratorBuilder SetRequiredLength(int length);
        IPasswordGeneratorBuilder SetRequiredUniqueChars(int n);
        IPasswordGeneratorBuilder SetRequireNonAlphanumeric(bool require);
        IPasswordGeneratorBuilder SetRequireLowercase(bool require);
        IPasswordGeneratorBuilder SetRequireUppercase(bool require);
        IPasswordGeneratorBuilder SetRequireDigit(bool require);

        IPasswordGenerator Build();
    }
}
