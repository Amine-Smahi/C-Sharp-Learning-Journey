using System;
using System.IO;
using System.Linq;

namespace JobSalaryPrediction {
    public class MLNetUtilities {
        public static string GetDataPathByDatasetName (string datasetName) {
            var appPath = Path.GetDirectoryName (Environment.GetCommandLineArgs ().First ());
            var parentDir = Directory.GetParent (appPath).Parent.Parent;

            var datasetPath = Path.Combine (parentDir.FullName, "datasets", datasetName);
            return datasetPath;
        }

        public static string GetModelFilePath (string fileName) {
            var appPath = Path.GetDirectoryName (Environment.GetCommandLineArgs ().First ());
            var parentDir = Directory.GetParent (appPath).Parent.Parent.Parent.Parent;

            var fileDir = Path.Combine (parentDir.FullName, "models");

            if (!Directory.Exists (fileDir)) {
                Directory.CreateDirectory (fileDir);
            }

            var filePath = Path.Combine (parentDir.FullName, "models", fileName);

            return filePath;
        }
    }
}