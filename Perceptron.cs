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
        public double proba=0;

        /// <summary>
        /// Getters
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="inputLayerSize"> tamaño de los parametros de entrada</param>
        /// <param name="hiddenLayerSize">Cantidad de capas ocultas</param>
        /// <param name="outputLayerSize">Tamaño de los parametros de salida esperados</param>
        /// <param name="learningRate"> tasa de aprendisaje, se usa generalmente 0.9</param>
        /// <param name="variationRate"> tasa de variacion</param>
        /// <param name="maxPeriods"> poner un limite a las iteraciones</param>
        /// <param name="maxError"> maximo error que se acepta</param>

	    public Perceptron(int inputLayerSize, int hiddenLayerSize, int outputLayerSize, double learningRate, double variationRate, int maxPeriods, double maxError) {
		    this.inputLayerSize = inputLayerSize;
		    this.hiddenLayerSize = hiddenLayerSize;
		    this.outputLayerSize = outputLayerSize;
		    this.maxPeriods = maxPeriods;
		    this.variationRate = variationRate;
		    this.learningRate = learningRate;
		    this.maxError = maxError;

		    // inicializa las capas ocultas
		    processUnitHidden = new ProcessUnit[hiddenLayerSize];

		    for (int i = 0; i < processUnitHidden.Length; i++) {
			    processUnitHidden[i] = new ProcessUnit(learningRate, variationRate);
			    processUnitHidden[i].initWeights(inputLayerSize);
		    }

		    // inicializa las capas de salida

		    processUnitsOutput = new ProcessUnit[outputLayerSize];

		    for (int i = 0; i < processUnitsOutput.Length; i++) {
			    processUnitsOutput[i] = new ProcessUnit(learningRate, variationRate);
			    processUnitsOutput[i].initWeights(hiddenLayerSize);
		    }
	    }
        /// <summary>
        /// Calculo de salidas
        /// </summary>
        /// <param name="input">Obtiene la entrada</param>
        /// <returns>Retorna con el calculo de la salida</returns>
	    public double[] output(double[] input) {
		    
		    double[] V = new double[hiddenLayerSize];
		    for (int i = 0; i < processUnitHidden.Length; i++) {
			    double activation = processUnitHidden[i].activation(input);
			    V[i] = processUnitHidden[i].output(activation);
		    }

		    //calcular output
		    double[] O = new double[outputLayerSize];
		    for (int i = 0; i < processUnitsOutput.Length; i++) {
			    double activation = processUnitsOutput[i].activation(V);
			    O[i] = processUnitsOutput[i].output(activation);
		    }
            //proba = sumarprobas(O);
		    return O;
	    }

        /// <summary>
        /// Calcular el error
        /// </summary>
        /// <param name="desiredOutput">Entrada esperada</param>
        /// <param name="inputs">entrada recivida</param>
        /// <returns>formula para calcular error</returns>
	    public double calculateError(double[][] desiredOutput, double[][] inputs) {
		    double error = 0;
		    for (int i = 0; i < desiredOutput.Length; i++) {

			    double[] thisoutput = output(inputs[i]);

			    for (int j = 0; j < desiredOutput.Length-1&&j<thisoutput.Length; j++) {
				    error += Math.Pow(desiredOutput[i][j] - thisoutput[j], 2) / 2;
			    }

		    }

		    return error;
	    }
        /// <summary>
        /// Entrenamiento de la red
        /// </summary>
        /// <param name="trainingimage">imagen de entrada</param>
        /// <param name="desiredimage">valor esperado</param>
        /// <returns>cantidad de iteraciones, no es necesaria pero se usa con motivos informativos</returns>
	    public int training(Bitmap trainingimage, Bitmap desiredimage) {

            double[][] trainingValues = GetBitMapColorMatrix(trainingimage);
            double[][] desiredOutput = GetBitMapColorMatrix(desiredimage);
		    periods = 0;
            proba = 0;
		    errors = new List<Double>();
            double M = 0;
            for (int rows = 0; rows < desiredOutput.Length &&rows<trainingValues.Length; rows++)
            {
                for (int columns = 0; columns < trainingValues[rows].Length &&columns<desiredOutput[rows].Length; columns++)
                {
                    if (desiredOutput[rows][columns] == trainingValues[rows][columns])
                        M++;
                }
            }
            proba += M;
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

				    for (int i = 0; i < activationHiddenLayer.Length; i++) {
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
                M -= error;
		    } while (error > maxError && periods < maxPeriods);
            M = M / trainingValues.Length;
		    return periods;
	    }

        /// <summary>
        /// se usa para pasar el bitmap a una matriz de double de 1.0s y 0.0s
        /// </summary>
        /// <param name="b1">bitmap</param>
        /// <returns>matriz de dobles del bitmap</returns>
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
        /// <summary>
        /// Suma de probas
        /// </summary>
        /// <param name="outp">outputs</param>
        /// <returns>valor sumado</returns>
        public double sumarprobas(double[] outp)
        {
            double valor = 0;
            for (int i = 0; i < outp.Length; i++)
            {
                valor = outp[i];
            }
            return valor;
            }

        }

    }


