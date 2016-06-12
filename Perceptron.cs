using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace IA_Proyecto_III
{
    class Perceptron
    {
        
        private ProcessUnit[] processUnitsOutput;// PROCESSING UNITS OUTPUT LAYER
	    private ProcessUnit[] processUnitHidden;// PROCESSING UNITS HIDDEN LAYER
	    private int inputLayerSize;// NUMBER OF INPUTS
	    private int hiddenLayerSize;// NUMBER PROCESSING UNITS IN HIDDEN LAYER
	    private int outputLayerSize;// NUMBER PROCESSING UNITS IN OUTPUT LAYER
	    private List<Double> errors;
	    private int periods;
	    private int maxPeriods;
	    private double maxError;
	    private double variationRate;
	    private double learningRate;

	    public double getVariationRate() {
		    return variationRate;
	    }

	    public double getLearningRate() {
		    return learningRate;
	    }

	    public int getInputLayerSize() {
		    return inputLayerSize;
	    }

	    public int getHiddenLayerSize() {
		    return hiddenLayerSize;
	    }

	    public int getOutputLayerSize() {
		    return outputLayerSize;
	    }

	    public double getMaxError() {
		    return maxError;
	    }

	    public List<Double> getErrors() {
		    return errors;
	    }

	    public int getPeriods() {
		    return periods;
	    }

	    public int getMaxPeriods() {
		    return maxPeriods;
	    }

	    public Perceptron(int inputLayerSize, int hiddenLayerSize, int outputLayerSize, double learningRate, double variationRate, int maxPeriods, double maxError) {
		    this.inputLayerSize = inputLayerSize;
		    this.hiddenLayerSize = hiddenLayerSize;
		    this.outputLayerSize = outputLayerSize;
		    this.maxPeriods = maxPeriods;
		    this.variationRate = variationRate;
		    this.learningRate = learningRate;
		    this.maxError = maxError;

		    // INIT HIDDEN LAYER
		    processUnitHidden = new ProcessUnit[hiddenLayerSize];

		    for (int i = 0; i < processUnitHidden.Length; i++) {
			    processUnitHidden[i] = new ProcessUnit(learningRate, variationRate);
			    processUnitHidden[i].initWeights(inputLayerSize);
		    }

		    // INIT OUTPUT LAYER

		    processUnitsOutput = new ProcessUnit[outputLayerSize];

		    for (int i = 0; i < processUnitsOutput.Length; i++) {
			    processUnitsOutput[i] = new ProcessUnit(learningRate, variationRate);
			    processUnitsOutput[i].initWeights(hiddenLayerSize);
		    }
	    }

	    public double[] output(double[] input) {
		    // CALCULATE OUTPUT LAYER HIDDEN
		    double[] V = new double[hiddenLayerSize];
		    for (int i = 0; i < processUnitHidden.Length; i++) {
			    double activation = processUnitHidden[i].activation(input);
			    V[i] = processUnitHidden[i].output(activation);
		    }

		    // CALCULATE OUTPUT
		    double[] O = new double[outputLayerSize];
		    for (int i = 0; i < processUnitsOutput.Length; i++) {
			    double activation = processUnitsOutput[i].activation(V);
			    O[i] = processUnitsOutput[i].output(activation);
		    }

		    return O;
	    }

	    public double calculateError(double[][] desiredOutput, double[][] inputs) {
		    double error = 0;
		    for (int i = 0; i < desiredOutput.Length; i++) {

			    double[] thisoutput = output(inputs[i]);

			    for (int j = 0; j < desiredOutput.Length; j++) {
				    error += Math.Pow(desiredOutput[i][j] - thisoutput[j], 2) / 2;
			    }

		    }

		    return error;
	    }

	    public int training(Bitmap trainingimage, Bitmap desiredimage) {

            double[][] trainingValues = GetBitMapColorMatrix(trainingimage);
            double[][] desiredOutput = GetBitMapColorMatrix(desiredimage);
		    periods = 0;
		    errors = new List<Double>();
		    double error = 0;
		    do {

			    double[] activationHiddenLayer = new double[hiddenLayerSize];
			    double[] activationOutputLayer = new double[outputLayerSize];

			    double[] deltaHiddenLayer = new double[hiddenLayerSize];
			    double[] deltaOutputLayer = new double[outputLayerSize];

			    double[] V = new double[hiddenLayerSize];
			    double[] O = new double[outputLayerSize];

			    for (int e = 0; e < desiredOutput.Length; e++) {

				    // CALCULATE OUTPUT FORWARD
				    for (int i = 0; i < processUnitHidden.Length; i++) {
					    activationHiddenLayer[i] = processUnitHidden[i].activation(trainingValues[e]);
					    V[i] = processUnitHidden[i].output(activationHiddenLayer[i]);
				    }

				    for (int i = 0; i < processUnitsOutput.Length; i++) {
					    activationOutputLayer[i] = processUnitsOutput[i].activation(V);
					    O[i] = processUnitsOutput[i].output(activationOutputLayer[i]);
				    }

				    // UPDATE WEIGHTS BACKWARDS

				    for (int i = 0; i < deltaOutputLayer.Length; i++) {
					    deltaOutputLayer[i] = processUnitsOutput[i].delta(desiredOutput[e][i], O[i]);
					    processUnitsOutput[i].updateWeights(V, deltaOutputLayer[i], activationOutputLayer[i]);
				    }

				    for (int i = 0; i < processUnitHidden.Length; i++) {

					    double[] W = new double[outputLayerSize];

					    for (int j = 0; j < processUnitsOutput.Length; j++) {
						    W[j] = processUnitsOutput[j].getWeights()[i];
					    }

					    deltaHiddenLayer[i] = processUnitHidden[i].delta(deltaOutputLayer, W);
					    processUnitHidden[i].updateWeights(trainingValues[e], deltaHiddenLayer[i], activationHiddenLayer[i]);
				    }
			    }
			    periods++;

			    // CCALCULATE ERROR
			    error = calculateError(desiredOutput, trainingValues);
			    errors.Add(error);
		    } while (error > maxError && periods < maxPeriods);
		    return periods;
	    }
        public double[][] GetBitMapColorMatrix(Bitmap b1)
        {
            int hight = b1.Height;
            int width = b1.Width;
            

            double[][] colorMatrix = new double[width][];
            
            
            for (int i = 0; i < width; i++)
            {
                colorMatrix[i] = new double[hight];
                for (int j = 0; j < hight; j++)
                {
                    Color black= Color.White;
                    Color estecolor = b1.GetPixel(i, j);
                    if (estecolor.Name == "ffffffff")
                        colorMatrix[i][j] = 0;
                    else
                        colorMatrix[i][j] = 1;
                }
            }
            return colorMatrix;
        }
        }

    }


