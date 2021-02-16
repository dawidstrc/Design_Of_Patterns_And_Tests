using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    public interface ILogger
    {
        void Log(string message);
    }


    public class EvaluationValidator
    {
        private ILogger _logger;

        public EvaluationValidator(ILogger logger)
        {
            this._logger = logger;
        }

        public bool Validate(double evaluation)
        {
            if (evaluation < 3.0)
            {
                this._logger.Log("Student's thesis didn't pass promoter evaluation");
                return false;
            }
            return true;
        }
    }
}
