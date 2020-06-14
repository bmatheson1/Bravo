using NUnit.Framework;
using Project.Models;

namespace Tests
{
    [TestFixture]
    public class Test
    {
        //
        // todo: A lot more tests...
        //

        private readonly ICorporateJargonGenerator _corporateJargonGenerator;

        public Test()
        {
            _corporateJargonGenerator = new CorporateJargonGenerator();
        }

        [Test]
        public void GetFluff_ShouldGenerateJargon()
        {
            string result = _corporateJargonGenerator.GetFluff();

            Assert.IsNotEmpty(result);
        }


    }
}