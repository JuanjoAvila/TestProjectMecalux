using NUnit.Framework;
using Autofac;
using TestProjectMecalux.Interface;
using TestProjectMecaluxTextTests.Methods;

namespace TestProjectMecalux.Methods.Tests
{
    [TestFixture]
    public class TextPhraseMethodsTests
    {
        private readonly ITextMethods methods;
        private readonly ContainerBuilder builder;
        private readonly IContainer container;
        private readonly TextStatistics textStatistics;

        public TextPhraseMethodsTests()
        {
            builder = new ContainerBuilder();
            Register.RegisterTypes(builder);
            container = builder.Build();
            methods = container.Resolve<ITextMethods>();
            textStatistics = new TextStatistics(0, 5, 4);
        }
        //No more time to do more tests
        [TestCase("Hello my name is Juanjo", "AlphabeticAsc")]
        public void TextSortedTest(string textIntroduced, string sortedOption)
        {
            //Try that are equal the example in test case and the text introduced ordered asc
            Assert.AreEqual(methods.TextSorted(textIntroduced, sortedOption), textIntroduced);
        }

        [TestCase("Hello my name is Juanjo")]
        public void TextStaticsTest(string textIntroduced)
        {
            Assert.AreEqual(methods.TextStatics(textIntroduced), textStatistics);
        }
    }
}