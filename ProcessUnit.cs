using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_Proyecto_III
{
    class ProcessUnit
    {
        private double variationRate;
        private double learningRate;
        private double[] weights;
        private double[] previousVariation;

        public ProcessUnit(double learningRate, double variationRate)
        {
            this.variationRate = learningRate;
            this.learningRate = variationRate;
        }
        /// <summary>
        /// getters y setters
        /// </summary>
        /// <returns></returns>
        public double getLearningRate()
        {
            return variationRate;
        }

        public void setLearningRate(double learningRate)
        {
            this.variationRate = learningRate;
        }

        public double getVariationRate()
        {
            return learningRate;
        }

        public void setVariationRate(double variationRate)
        {
            this.learningRate = variationRate;
        }

        public double[] getWeights()
        {
            return weights;
        }

        public void setWeights(double[] weights)
        {
            this.weights = weights;
        }
        /// <summary>
        /// se inicializan los pesos iniciales
        /// </summary>
        /// <param name="n"></param>
        public void initWeights(int n)
        {
            weights = new double[n];
            previousVariation = new double[n];
            for (int i = 0; i < weights.Length; i++)
            {
                Random rnd = new Random();
                weights[i] = rnd.Next(weights.Length);
                previousVariation[i] = 0;
            }
        }
        /// <summary>
        /// Activacion hace el calculo que se usa en el output, multiplica los valores del imput
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public double activation(double[] inputs)
        {
            double activation = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                activation += weights[i] * inputs[i];
            }
            return activation;
        }
        /// <summary>
        /// calcular las salidas
        /// </summary>
        /// <param name="activation"></param>
        /// <returns></returns>
        public double output(double activation)
        {
            return activationFunction(activation);
        }
        /// <summary>
        /// calcular salidas
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double activationFunction(double x)
        {
            return sigmoid(x);
        }
        /// <summary>
        /// calcular salidas
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double activationFunctionDerivative(double x)
        {
            return sigmoidDerivative(x);
        }
        /// <summary>
        /// calcular coeficiente entre salida deseada y salida
        /// </summary>
        /// <param name="desiredOutput"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        public double delta(double desiredOutput, double output)
        {
            return (desiredOutput - output);
        }
        /// <summary>
        /// calcular coeficientes pero en listas
        /// </summary>
        /// <param name="d"></param>
        /// <param name="W"></param>
        /// <returns></returns>
        public double delta(double[] d, double[] W)
        {
            double totalDelta = 0;
            for (int i = 0; i < d.Length; i++)
            {
                totalDelta += W[i] * d[i];
            }
            return totalDelta;
        }
        /// <summary>
        /// Actualizar los pesos segun el coeficientes
        /// </summary>
        /// <param name="inputs"></param>
        /// <param name="delta"></param>
        /// <param name="activation"></param>
        public void updateWeights(double[] inputs, double delta, double activation)
        {
            double variation;
            for (int i = 0; i < weights.Length; i++)
            {
                variation = (learningRate * inputs[i] * delta * activationFunctionDerivative(activation)) + previousVariation[i] * variationRate;
                previousVariation[i] = variation;
                weights[i] += variation;
            }
        }

        public double sigmoid(double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }

        public double sigmoidDerivative(double x)
        {
            return sigmoid(x) * (1 - sigmoid(x));
        }
    
    }
}
