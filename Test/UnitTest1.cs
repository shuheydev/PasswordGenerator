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
            var generator = new PasswordGenerator();
        }

        [Fact]
        public void Generateできるかな()
        {
            var generator = new PasswordGenerator();
            var pw = generator.Generate();

            Assert.True(!string.IsNullOrEmpty(pw));
        }
    }
}
