import numpy as np
import random
import sys
import struct
import mnist
import time

class Network:
    def __init__(self):
        self.f_w=open('weights.dat','ab')
        self.f_dw=open('weights_d.dat','ab')
        self.afunction = "sig"
        self.tasktype = "class"
        self.Layers = 5 # must be greater than 2 - we always want to have at least 1 hidden layer
        self.NeuronsByLayer = 200
        self.biasesEx = 0
        self.a = []
        self.weights = []
        self.biases = [] 
        self.learningRate = 0.01
        self.epochs = 30
        self.initialiseData()
        np.random.seed(3123123)
        self.weights.append(np.random.randn(self.x.shape[1], 200))
        #for i in range(self.Layers-3):
        #    self.weights.append(np.random.randn(self.NeuronsByLayer, self.NeuronsByLayer))
        #if(self.biasesEx == 1):
        #    for i in range(self.Layers-2):
        #        self.biases.append(np.random.randn(self.NeuronsByLayer))
        self.weights.append(np.random.randn(200, 80))
        self.weights.append(np.random.randn(80, 10))
        #self.weights.append(np.random.randn(200, 200))
        #
        self.weights.append(np.random.randn(10, 1))
        for i in range(len(self.weights)):
            self.weights[i] = np.clip(self.weights[i], -1, 1)
        if(self.biasesEx == 1):
            self.biases.append(np.random.randn(1))

        np.savetxt(self.f_w, ["Initial weights"], fmt='%s') 
        np.savetxt(self.f_w, self.weights, fmt='%s')
    def initialiseData(self):
        self.train_images = mnist.train_images()
        self.train_images = self.train_images.reshape(self.train_images.shape[0],28*28)
        self.train_labels = mnist.train_labels()
        #test_images = mnist.test_images()
        #test_labels = mnist.test_labels()
        self.x = self.normaliseDataInput(self.train_images)
        self.y = self.normaliseDataInput(self.train_labels)


    def normaliseDataOutput(self, data):
        if(self.afunction == "sig"):
            return ((data-np.min(data))/(np.max(data)-np.min(data)))
        return 2*((data-np.min(data))/(np.max(data)-np.min(data)))-1

    def normaliseDataInput(self, data):
        if(self.afunction == "sig"):
            return ((data-np.min(data))/(np.max(data)-np.min(data)))
        return 2*((data-np.min(data))/(np.max(data)-np.min(data)))-1
    

    def denormaliseDataOutput(self, data):
        prev_data = self.train_labels
        #print(prev_data)
        if(self.afunction == "sig"):
            return (data * (np.max(prev_data)-np.min(prev_data))) + np.min(prev_data)
            #return ((data)/(np.max(prev_data)-np.min(prev_data)))+np.min(prev_data)
        return ((data+1)/2*(np.max(prev_data)-np.min(prev_data)))+np.min(prev_data)

    def trainNetwork(self):
        #print(self.y)
        self.coptions = np.unique(self.normaliseDataOutput(self.y))
        #print(self.coptions)
        for ep in range(0, self.epochs):
            print(ep/self.epochs)
            if(self.biasesEx == 1):
                biases_d = [np.zeros(b.shape) for b in self.biases]
            weight_d = [np.zeros(w.shape) for w in self.weights]

            for x,y in zip(self.x,self.y):
                #print(x)
                activation_list, z_list = self.forward(x)
                # get delta for output
                # output error
                delta = (activation_list[-1]-y) * self.activateFunctionDeriv(z_list[-1])
                #print(delta)
                if(self.biasesEx == 1):
                    biases_d[-1] = biases_d[-1]+delta
                weight_d[-1] = delta

                #backpropagate
                for l in range(2, self.Layers):
                    delta = np.dot(self.weights[1-l], delta) * self.activateFunctionDeriv(z_list[-l])
                    if(self.biasesEx == 1):
                        biases_d[-l] = biases_d[-l] + delta
                    weight_d[-l] = np.dot(np.asmatrix(delta).transpose(), np.asmatrix(activation_list[-l-1])).transpose()
                self.weights = [w-self.learningRate*(np.asarray(wd)) for w, wd in zip(self.weights, weight_d)]
                #print(weight_d)
            #self.weights = [w-self.learningRate/len(self.x)*(np.asarray(wd)) for w, wd in zip(self.weights, weight_d)]
            if(self.biasesEx == 1):
                self.biases = [b-self.learningRate*bd for b, bd in zip(self.biases, biases_d)]
            np.savetxt(self.f_w, ["Weights after iteration " + str(ep+1) + "/" + str(self.epochs)], fmt='%s')
            np.savetxt(self.f_w, self.weights, fmt='%s')
            np.savetxt(self.f_dw, ["Weights deltas after iteration " + str(ep+1) + "/" + str(self.epochs)], fmt='%s')
            np.savetxt(self.f_dw, weight_d, fmt='%s')
            self.testNetwork()

    def forward(self, x):
        activation_list = [np.copy(x)]
        z_list = []
        for l in range(self.Layers-1): # hidden layers
            if(self.biasesEx == 1):
                z = np.dot(self.weights[l].transpose(), activation_list[-1])+self.biases[l]
            else:
                z = np.dot(self.weights[l].transpose(), activation_list[-1])
            activation_list.append(self.activationFunction(z))
            z_list.append(z)
        #print(activation_list[-1])
        return activation_list, z_list

    def testNetwork(self):
        test_images = mnist.train_images()
        test_images = self.train_images.reshape(self.train_images.shape[0],28*28)
        test_labels = mnist.train_labels()
        #test_images = mnist.test_images()
        #test_labels = mnist.test_labels()
        normal_x = self.normaliseDataInput(test_images)
        normal_y = self.normaliseDataInput(test_labels)

        #print(normal_x)
        results = []
        results2 = []
        for x,y in zip(normal_x,normal_y):
            a_list, z_list = self.forward(x)
            result = self.denormaliseDataOutput(rounder(self.coptions)(a_list[-1]))[0]
            result2 = a_list[-1][0]
            results.append(result)
            results2.append(result2)
        errors = (test_labels-results).transpose()
        toSave = np.column_stack((test_labels, results, results2, errors))
        np.savetxt("xD.csv", toSave, delimiter=",", fmt='%.5e')
        errors_abs = np.abs(errors)
        errors_num = np.count_nonzero(errors_abs < 0.1)
        print("Correct guesses: " + str(errors_num/len(errors_abs)*100.0))
        
    def sigm(self, z):
        return (1./(1. + np.exp(-z)))

    def activationFunction(self, z): 
        if(self.afunction == "tanh"):
            return np.tanh(z)
        if(self.afunction == "arctan"):
            return np.arctan(z)
        return self.sigm(z)

    def activateFunctionDeriv(self, z):
        if(self.afunction == "tanh"):
            return 1-np.tanh(z)**2
        if(self.afunction == "arctan"):
            return 1/(1+z**2)
        return (self.sigm(z))*(1-self.sigm(z))

    def runNetwork(self, x, y):
        c = x
        return c

def cartesian_product(*arrays):
    la = len(arrays)
    dtype = np.result_type(*arrays)
    arr = np.empty([len(a) for a in arrays] + [la], dtype=dtype)
    for i, a in enumerate(np.ix_(*arrays)):
        arr[...,i] = a
    return arr.reshape(-1, la)

def rounder(values):
    def f(x):
        idx = np.argmin(np.abs(values - x))
        return values[idx]
    return np.frompyfunc(f, 1, 1)

"""
start
"""
#z = [-6.42405464, -0.5816109,  -2.59580427,  0.02229016, -5.68224804,  1.81542828,
# -2.27152521, -2.11979715,  0.68543369,  3.58075488,  5.40923552,  1.458885,
#  6.06240861,  0.84906063,  2.81378707,  5.3062817,   0.52349386, -1.11544142, -1.5262414,  -3.17440911]
#print(np.exp(z))
#exit()
start = time.time()
myNetwork = Network()
myNetwork.trainNetwork()
print("1.0")
end = time.time()
print(end - start)