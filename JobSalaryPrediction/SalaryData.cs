using Microsoft.ML.Runtime.Api;

namespace JobSalaryPrediction {
    public class SalaryData {
        [Column ("0")]
        public float YearsExperience;

        [Column ("1", name: "Label")]
        public float Salary;
    }
}