using CNTK;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Numerics;

namespace Digitz
{
    class DigitRecognizer
    {
        private static readonly DeviceDescriptor CpuDevice = DeviceDescriptor.CPUDevice;
        private Function _mnistFunction;
        private Variable _mnistInput;

        public DigitRecognizer()
        {
            // This example requires the MNISTConvolution.model.
            LoadModel("digit.model");
        }

        /// <summary>
        /// Returns the digit represented by the image.
        /// </summary>
        public List<DigitResult> Evaluate(Bitmap image)
        {
            Tensor<float> imageData = ConvertImageToTensorData(image);

            return Evaluate(imageData);
        }

        /// <summary>
        /// Converts the image into the expected data for the MNIST model.
        /// </summary>
        private Tensor<float> ConvertImageToTensorData(Bitmap image)
        {
            int width = _mnistInput.Shape.Dimensions[0];
            int height = _mnistInput.Shape.Dimensions[1];
            image = ResizeImage(image, new Size(width, height));

            Tensor<float> imageData = new DenseTensor<float>(new[] { width, height }, true); // CNTK uses ColumnMajor layout

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color color = image.GetPixel(x, y);
                    float pixelValue = (color.R + color.G + color.B) / 3;

                    // Turn to black background and white digit like MNIST model expects
                    imageData[x, y] = (255 - pixelValue);
                }
            }

            return imageData;
        }

        private List<DigitResult> Evaluate(Tensor<float> imageData)
        {
            try
            {
                // Get output variable
                Variable outputVar = _mnistFunction.Output;

                var inputDataMap = new Dictionary<Variable, Value>();
                var outputDataMap = new Dictionary<Variable, Value>();

                // Create input data map
                Value inputVal = Value.CreateBatch(_mnistInput.Shape, imageData, CpuDevice);
                inputDataMap.Add(_mnistInput, inputVal);

                // Create output data map
                outputDataMap.Add(outputVar, null);

                // Start evaluation on the device
                _mnistFunction.Evaluate(inputDataMap, outputDataMap, CpuDevice);

                // Get evaluate result as dense output
                Value outputVal = outputDataMap[outputVar];

                // The model has only one single output - a list of 10 floats
                // representing the likelihood of that index being the digit
                IList<float> outputData = outputVal.GetDenseData<float>(outputVar).Single();

                List<DigitResult> results = new List<DigitResult>(outputData.Count);
                for (int i = 0; i < outputData.Count; i++)
                {
                    results.Add(new DigitResult() { Digit = i, Confidence = outputData[i] });
                }

                // sort so the highest confidence is first
                results = results.OrderByDescending(r => r.Confidence).ToList();

                return results;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return new List<DigitResult>();
            }
        }

        private void LoadModel(string modelFilePath)
        {
            if (!File.Exists(modelFilePath))
            {
                throw new FileNotFoundException(
                    modelFilePath,
                    $"Error: The model '{modelFilePath}' does not exist. Please follow instructions in README.md in <CNTK>/Examples/Image/ConvNet to create the model.");
            }

            _mnistFunction = Function.Load(modelFilePath, CpuDevice);

            // Get input variable. The model has only one single input.
            _mnistInput = _mnistFunction.Arguments.Single();
        }

        private static Bitmap ResizeImage(Bitmap imgToResize, Size size)
        {
            Bitmap b = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(b))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(imgToResize, 0, 0, size.Width, size.Height);
            }
            return b;
        }
    }

    public class DigitResult
    {
        public int Digit { get; set; }
        public float Confidence { get; set; }
    }
}
