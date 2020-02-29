using System;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Models;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms;

namespace JobSalaryPrediction {
    class Program {
        private const int PREDICTION_YEARS = 8;
        static void Main (string[] args) {
            var dataset = MLNetUtilities.GetDataPathByDatasetName ("SalaryData.csv");
            var testDataset = MLNetUtilities.GetDataPathByDatasetName ("SalaryData-test.csv");

            var pipeline = new LearningPipeline {
                new TextLoader (dataset).CreateFrom<SalaryData> (useHeader: true, separator: ','),
                new ColumnConcatenator ("Features", "YearsExperience"),
                new GeneralizedAdditiveModelRegressor ()
            };

            Console.WriteLine ("--------------Training----------------");
            var model = pipeline.Train<SalaryData, SalaryPrediction> ();

            model.WriteAsync (MLNetUtilities.GetModelFilePath ("model.zip"));

            Console.WriteLine (Environment.NewLine);
            Console.WriteLine ("--------------Evaluating----------------");
            var testData = new TextLoader (testDataset).CreateFrom<SalaryData> (useHeader: true, separator: ',');

            var evaluator = new RegressionEvaluator ();
            var metrics = evaluator.Evaluate (model, testData);

            Console.WriteLine ($"Root Mean Squared: {metrics.Rms}");
            Console.WriteLine ($"R^2: {metrics.RSquared}");

            Console.WriteLine (Environment.NewLine);
            Console.WriteLine ("--------------Predicting----------------");
            var prediction = model.Predict (new SalaryData { YearsExperience = PREDICTION_YEARS });

            Console.WriteLine ($"After {PREDICTION_YEARS} years you would earn around {String.Format("{0:C}", prediction.PredictedSalary)}");

            Console.ReadLine ();
        }
    }
}