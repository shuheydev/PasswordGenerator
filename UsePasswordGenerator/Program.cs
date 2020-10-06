using PasswordGen;
using System;

namespace UsePasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new PasswordGeneratorBuilder();
            builder.SetRequireDigit(true)
                .SetRequiredLength(10)
                .SetRequiredUniqueChars(5)
                .SetRequireLowercase(true)
                .SetRequireNonAlphanumeric(true)
                .SetRequireUppercase(true);

            var generator = builder.Build();

            for (int i = 0; i < 100; i++)
                Console.WriteLine(generator.Generate());
        }
    }
}
