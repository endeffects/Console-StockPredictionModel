using System;
using MarketPredictionML.Model;

namespace MarketPrediction
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new ModelInput();
            ModelOutput result = ConsumeModel.Predict(input);
        }
    }
}
