using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeAnalyzer
{
    public class MoodAnalyzerException : Exception
    {
        public enum ExceptionType
        {
            EMPTY_MOOD,
            NULL_MOOD,
        }

        public ExceptionType exceptionType;
        public MoodAnalyzerException(ExceptionType exceptionType, string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }

    }
}
