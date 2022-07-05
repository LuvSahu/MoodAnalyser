using ModeAnalyzer;
namespace MoodAnalyzerTestCode
{
    
        public class Tests
        {
             MoodAnalyser moodAnalyser;

            [SetUp]
            public void Setup()
            {
                moodAnalyser = new MoodAnalyser();
            }
            /// <summary>
            /// TC1.1 Given “I am in Sad Mood” message Should Return SAD
            /// </summary>
            [Test]
            public void GivenMessage_WhenSad_ShouldReturnSadParameterLess_Constructor()
            {
                //Arrange
                moodAnalyser = new MoodAnalyser();
                string msg = "I am in SAD mood";
                //Act
                string message = moodAnalyser.AnalyseMoodWithoutConstructor(msg);
                //Assert
                Assert.AreEqual("SAD", message);
            }
            /// <summary>
            /// TC1.2 Given “I am in Any Mood” message Should Return HAPPY
            /// </summary>
            [Test]
            public void GivenMessage_WhenAnyMood_ShouldReturnHappyParameterLess_Constructor()
            {
                moodAnalyser = new MoodAnalyser();
                string msg = "I am in Any mood";
                string message = moodAnalyser.AnalyseMoodWithoutConstructor(msg);
                Assert.AreEqual("HAPPY", message);
            }
            /// <summary>
            /// TC1.1 Given “I am in Sad Mood” message in Constructor Should Return SAD
            /// </summary>
            [Test]
            public void GivenMessage_WhenSad_ShouldReturnSad()
            {
                moodAnalyser = new MoodAnalyser("I am Sad mood");
                string message = moodAnalyser.AnalyseMood();
                Assert.AreEqual("SAD", message);
            }
            /// <summary>
            /// TC1.2 Given “I am in Happy Mood” message in Constructor Should Return SAD
            /// </summary>
            [Test]
            public void GivenMessage_WhenHappy_ShouldReturnHappy()
            {
                moodAnalyser = new MoodAnalyser("I am in Happy mood");
                string message = moodAnalyser.AnalyseMood();
                Assert.AreEqual("HAPPY", message);
            }

            [Test]
            public void GivenMessage_WhenNull_ShouldReturnHappy()
            {
                moodAnalyser = new MoodAnalyser();
                string message = moodAnalyser.AnalyseMood();
                Assert.AreEqual("SAD", message);
            }
            [Test]
            public void GivenMessage_WhenNull_USingCustomException_ShouldReturnNullMood()
            {
                moodAnalyser = new MoodAnalyser();
                try
                {
                    string message = moodAnalyser.AnalyseMood();
                }
                catch (MoodAnalyzerException exception)
                {
                    Assert.AreEqual(MoodAnalyzerException.ExceptionType.NULL_MOOD, exception.exceptionType);
                }

            }
            [Test]
            public void GivenMessage_WhenEmpty_USingCustomException_ShouldReturnNullMood()
            {
                moodAnalyser = new MoodAnalyser("");
                try
                {
                    string message = moodAnalyser.AnalyseMood();
                }
                catch (MoodAnalyzerException exception)
                {
                    Assert.AreEqual(MoodAnalyzerException.ExceptionType.EMPTY_MOOD, exception.exceptionType);
                }
            }
        }
}