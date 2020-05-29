using System;
using Ml__net_hellowroldML.Model;

namespace Ml_.net_hellowrold
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new ModelInput();
            input.SentimentText = "That is rude";



            ModelOutput result = ConsumeModel.Predict(input);

            Console.WriteLine($"Text: {input.SentimentText}\n is is Toxic: {result.Prediction}");
        }
    }
}
