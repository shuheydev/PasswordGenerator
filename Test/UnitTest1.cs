using PasswordGen;
using System;
using Xunit;

namespace Test
{
    public class BuilderTest
    {
        [Fact]
        public void Create�ł��邩��()
        {
            var builder = new PasswordGeneratorBuilder();
        }

        [Fact]
        public void Generator�𐶐��ł��邩��()
        {
            var builder = new PasswordGeneratorBuilder();

            var generator = builder.Build();

            Assert.IsType(typeof(PasswordGenerator), generator);
        }
    }

    public class GeneratorTest
    {
        [Fact]
        public void Create�ł��邩��()
        {
            var builder = new PasswordGeneratorBuilder();
            var generator = builder.Build();
        }

        [Fact]
        public void Generate�ł��邩��()
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
        public void ����0�ɂ�����stringEmpty���Ԃ�()
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
