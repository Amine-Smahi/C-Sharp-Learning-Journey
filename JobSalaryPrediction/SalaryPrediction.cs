using Microsoft.ML.Runtime.Api;

namespace JobSalaryPrediction {
    public class SalaryPrediction {
        [ColumnName ("Score")]
        public float PredictedSalary;
    }
}