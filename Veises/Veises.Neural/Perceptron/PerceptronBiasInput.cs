﻿using Veises.Neural.Properties;

namespace Veises.Neural.Perceptron
{
	public sealed class PerceptronBiasInput: IPerceptronInput
	{
		public const double Bias = 1d;

		public double Weight { get; private set; }

		public PerceptronBiasInput(double weight)
		{
			Weight = weight;
		}

		public double CalculateOutput() => Bias * Weight;

		public void AdjustWeight(double desiredOutput)
		{
			var localOutput = CalculateOutput();

			var localError = desiredOutput - localOutput;

			Weight += Settings.Default.LearningRate * localError * Bias;
		}
	}
}