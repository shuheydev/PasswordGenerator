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
            var generator = new PasswordGenerator();
        }

        [Fact]
        public void Generate‚Å‚«‚é‚©‚È()
        {
            var generator = new PasswordGenerator();
            var pw = generator.Generate();

            Assert.True(!string.IsNullOrEmpty(pw));
        }
    }
}
