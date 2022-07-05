using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeAnalyzer
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser()
        {
            this.message = "I am in SAD mood";
        }

        public MoodAnalyser(string message)
        {
            this.message = message.ToUpper();
        }
        public string AnalyseMood()
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                    return "SAD";
                else if (message.Equals(string.Empty))
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_MOOD, "Mood should not be empty");
                else return "HAPPY";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_MOOD, "Mood Should Not Be Null");
                //return "HAPPY";
            }

        }
        public string AnalyseMoodWithoutConstructor(string message)
        {
            if (message.ToLower().Contains("sad"))
                return "SAD";

            else return "HAPPY";

        }
    }
}
