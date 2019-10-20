import numpy as np

import random

class Network:
    def __init__(self):
        self.Layers = 10 # must be greater than 2 - we always want to have at least 1 hidden layer
        self.NeuronsByLayer = 20
        self.a = []
        self.weights = []
        self.biases = [] 
        self.learningRate = 0.1
        self.epochs = 1000
        self.initialiseData()
        np.random.seed(69142)
        
        self.weights.append(np.random.randn(self.x.shape[1], self.NeuronsByLayer))
        for i in range(self.Layers-3):
            self.weights.append(np.random.randn(self.NeuronsByLayer, self.NeuronsByLayer))
        for i in range(self.Layers-2):
            self.biases.append(np.random.randn(self.NeuronsByLayer))

        self.weights.append(np.random.randn(self.NeuronsByLayer, self.y.shape[1]))
        self.biases.append(np.random.randn(self.y.shape[1]))
    def initialiseData(self):
        my_data = np.genfromtxt('c:/Users/Mateusz/Desktop/SN_Proj1/classification/data.three_gauss.train.100.csv', delimiter=',')
        self.mydata = my_data[1:]
        self.x = self.normaliseData(self.mydata[:,:2])
        self.y = self.normaliseData(self.mydata[:,2:3])

    def normaliseData(self, data):
        return 2*((data-np.min(data))/(np.max(data)-np.min(data)))-1

    def denormaliseData(self, data, data_prev):
        return ((data+1)/2*(np.max(data_prev)-np.min(data_prev)))+np.min(data_prev)

    def trainNetwork(self):
        for ep in range(1, self.epochs):
            print(ep/self.epochs)
            biases_d = [np.zeros(b.shape) for b in self.biases]
            weight_d = [np.zeros(w.shape) for w in self.weights]

            mydata = random.sample(list(self.mydata), len(self.mydata))
            self.x = self.normaliseData(self.mydata[:,:2])
            self.y = self.normaliseData(self.mydata[:,2:3])
            for x,y in zip(self.x,self.y):
                activation_list, z_list = self.forward(x)
                # get delta for output
                # output error
                delta = (activation_list[-1]-y) * self.activateFunctionDeriv(z_list[-1])
                biases_d[-1] = biases_d[-1]+delta
                weight_d[-1] = np.asarray([w+wd for w, wd in zip(weight_d[-1], np.dot(np.asmatrix(delta), np.asmatrix(activation_list[-2])))])[0].transpose()
                #backpropagate
                for l in range(2, self.Layers):
                    delta = np.dot(self.weights[1-l], delta) * self.activateFunctionDeriv(z_list[-l])
                    biases_d[-l] = biases_d[-l] + delta
                    weight_d[-l] = weight_d[-l]+np.dot(np.asmatrix(delta).transpose(), np.asmatrix(activation_list[-l-1])).transpose()
            self.weights = [w-self.learningRate/len(self.x)*(np.asarray(wd)) for w, wd in zip(self.weights, weight_d)]
            self.biases = [b-self.learningRate/len(self.x)*bd for b, bd in zip(self.biases, biases_d)]

    def forward(self, x):
        activation_list = [np.copy(x)]
        z_list = []
        for l in range(self.Layers-1): # hidden layers
            z = np.dot(self.weights[l].transpose(), activation_list[-1])+self.biases[l]
            activation_list.append(self.activationFunction(z))
            z_list.append(z)
        return activation_list, z_list

    def testNetwork(self):
        test_data = np.genfromtxt('c:/Users/Mateusz/Desktop/SN_Proj1/classification/data.three_gauss.test.100.csv', delimiter=',')
        normal_x = self.normaliseData(test_data[1:,:2])
        normal_y = self.normaliseData(test_data[1:,2:3])
        for x,y in zip(normal_x,normal_y):
            a_list, z_list = self.forward(x)
            print(self.denormaliseData(a_list[-1], test_data[1:,2:3]))

        


    "todo - more functions"
    @staticmethod
    def activationFunction(z): 
        return np.tanh(z)

    @staticmethod
    def activateFunctionDeriv(z):
        return 1-np.tanh(z)**2

    def runNetwork(self, x, y):
        c = x
        return c

"""
start
"""

myNetwork = Network()
myNetwork.trainNetwork()
myNetwork.testNetwork()