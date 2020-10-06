using PasswordGen;
using System;
using Xunit;

namespace Test
{
    public class BuilderTest
    {
        [Fact]
        public void Create‚Å‚«‚é‚©‚È()
        {
            var builder = new PasswordGeneratorBuilder();
        }

        [Fact]
        public void Generator‚ğ¶¬‚Å‚«‚é‚©‚È()
        {
            var builder = new PasswordGeneratorBuilder();

            var generator = builder.Build();

            Assert.IsType(typeof(PasswordGenerator), generator);
        }
    }

    public class GeneratorTest
    {
        [Fact]
        public void Create‚Å‚«‚é‚©‚È()
        {
            var builder = new PasswordGeneratorBuilder();
            var generator = builder.Build();
        }

        [Fact]
        public void Generate‚Å‚«‚é‚©‚È()
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
        public void ’·‚³0‚É‚µ‚½‚çstringEmpty‚ª•Ô‚é()
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
