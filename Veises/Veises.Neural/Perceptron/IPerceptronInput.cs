﻿namespace Veises.Neural.Perceptron
{
	public interface IPerceptronInput
	{
		void AdjustWeight(double localError);

		double CalculateOutput();

		void SetInput(double input);
	}
}