using PasswordGen;
using System;
using Xunit;

namespace Test
{
    public class BuilderTest
    {
        [Fact]
        public void Createできるかな()
        {
            var builder = new PasswordGeneratorBuilder();
        }

        [Fact]
        public void Generatorを生成できるかな()
        {
            var builder = new PasswordGeneratorBuilder();

            var generator = builder.Build();

            Assert.IsType(typeof(PasswordGenerator), generator);
        }
    }

    public class GeneratorTest
    {
        [Fact]
        public void Createできるかな()
        {
            var builder = new PasswordGeneratorBuilder();
            var generator = builder.Build();
        }

        [Fact]
        public void Generateできるかな()
        {
            var builder = new PasswordGeneratorBuilder();
            builder.SetRequiredLength(8)
                   .SetRequireDigit(true)
                   .SetRequiredUniqueChars(2)
                   .SetRequireLowercase(true)
                   .SetRequireUppercase(true)
                   .SetRequireNonAlphanumeric(true);
            var generator = builder.Build();
            var pw = generator.Generate();

            Assert.True(!string.IsNullOrEmpty(pw));
        }

        [Fact]
        public void 長さ0にしたらstringEmptyが返る()
        {
            var builder = new PasswordGeneratorBuilder();
            builder.SetRequiredLength(0)
                   .SetRequireDigit(true)
                   .SetRequiredUniqueChars(2)
                   .SetRequireLowercase(true)
                   .SetRequireUppercase(true)
                   .SetRequireNonAlphanumeric(true);
            var generator = builder.Build();
            var pw = generator.Generate();

            Assert.True(string.IsNullOrEmpty(pw));
        }
    }
}
