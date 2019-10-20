import numpy as np
import random
import sys

class Network:
    def __init__(self, trainingFile, testingFile, neuronsByLayer, layers, epochs, learningRate, seed, afunction, tasktype, step):
        self.f_w=open('weights.dat','ab')
        self.f_dw=open('weights_d.dat','ab')
        self.afunction = afunction
        self.tasktype = tasktype
        self.trainingFile = trainingFile
        self.testingFile = testingFile
        self.Layers = layers # must be greater than 2 - we always want to have at least 1 hidden layer
        self.NeuronsByLayer = neuronsByLayer
        self.stepGen = step
        self.a = []
        self.weights = []
        self.biases = [] 
        self.learningRate = learningRate
        self.epochs = epochs
        self.initialiseData()
        np.random.seed(seed)
        self.weights.append(np.random.randn(self.x.shape[1], self.NeuronsByLayer))
        for i in range(self.Layers-3):
            self.weights.append(np.random.randn(self.NeuronsByLayer, self.NeuronsByLayer))
        for i in range(self.Layers-2):
            self.biases.append(np.random.randn(self.NeuronsByLayer))

        self.weights.append(np.random.randn(self.NeuronsByLayer, self.y.shape[1]))
        self.biases.append(np.random.randn(self.y.shape[1]))

        np.savetxt(self.f_w, ["Initial weights"], fmt='%s')
        np.savetxt(self.f_w, self.weights, fmt='%s')
    def initialiseData(self):
        my_data = np.genfromtxt(self.trainingFile, delimiter=',')
        self.mydata = my_data[1:]
        self.x = self.normaliseDataInput(self.mydata[:,:2])
        self.y = self.normaliseDataOutput(self.mydata[:,2:3])

    def normaliseDataOutput(self, data):
        if(self.afunction == "sig"):
            return ((data-np.min(data))/(np.max(data)-np.min(data)))
        return 2*((data-np.min(data))/(np.max(data)-np.min(data)))-1

    def normaliseDataInput(self, data):
        #if(self.afunction == "sig"):
        #    return ((data-np.min(data))/(np.max(data)-np.min(data)))
        return 2*((data-np.min(data))/(np.max(data)-np.min(data)))-1
    

    def denormaliseDataOutput(self, data):
        prev_data = self.mydata[:,2:3]
        if(self.afunction == "sig"):
            return ((data)/(np.max(prev_data)-np.min(prev_data)))+np.min(prev_data)
        return ((data+1)/2*(np.max(prev_data)-np.min(prev_data)))+np.min(prev_data)

    def trainNetwork(self):
        for ep in range(0, self.epochs):
            print(ep/self.epochs)
            biases_d = [np.zeros(b.shape) for b in self.biases]
            weight_d = [np.zeros(w.shape) for w in self.weights]

            mydata = random.sample(list(self.mydata), len(self.mydata))
            self.x = self.normaliseDataInput(self.mydata[:,:2])
            self.y = self.normaliseDataOutput(self.mydata[:,2:3])
            #print(self.x)
            for x,y in zip(self.x,self.y):
                #print(x)
                activation_list, z_list = self.forward(x)
                # get delta for output
                # output error
                delta = (activation_list[-1]-y) * self.activateFunctionDeriv(z_list[-1])
                #print(delta)
                biases_d[-1] = biases_d[-1]+delta
                weight_d[-1] = np.asarray([w+wd for w, wd in zip(weight_d[-1], np.dot(np.asmatrix(delta), np.asmatrix(activation_list[-2])))])[0].transpose()

                #backpropagate
                for l in range(2, self.Layers):
                    delta = np.dot(self.weights[1-l], delta) * self.activateFunctionDeriv(z_list[-l])
                    biases_d[-l] = biases_d[-l] + delta
                    weight_d[-l] = weight_d[-l]+np.dot(np.asmatrix(delta).transpose(), np.asmatrix(activation_list[-l-1])).transpose()
            self.weights = [w-self.learningRate/len(self.x)*(np.asarray(wd)) for w, wd in zip(self.weights, weight_d)]
            self.biases = [b-self.learningRate/len(self.x)*bd for b, bd in zip(self.biases, biases_d)]
            np.savetxt(self.f_w, ["Weights after iteration " + str(ep+1) + "/" + str(epochs)], fmt='%s')
            np.savetxt(self.f_w, self.weights, fmt='%s')
            np.savetxt(self.f_dw, ["Weights deltas after iteration " + str(ep+1) + "/" + str(epochs)], fmt='%s')
            np.savetxt(self.f_dw, weight_d, fmt='%s')

    def forward(self, x):
        activation_list = [np.copy(x)]
        z_list = []
        for l in range(self.Layers-1): # hidden layers
            z = np.dot(self.weights[l].transpose(), activation_list[-1])+self.biases[l]
            activation_list.append(self.activationFunction(z))
            z_list.append(z)
        return activation_list, z_list

    def testNetwork(self):
        test_data = np.genfromtxt(self.testingFile, delimiter=',')
        normal_x = self.normaliseDataInput(test_data[1:,:2])
        normal_y = self.normaliseDataOutput(test_data[1:,2:3])
        results = []
        for x,y in zip(normal_x,normal_y):
            a_list, z_list = self.forward(x)
            result = self.denormaliseDataOutput(a_list[-1])[0]
            if(tasktype == "class"):
                result = round(result)
            results.append(result)
        toSave = test_data[1:, :]
        errors = test_data[1:, 2:3]-np.asmatrix(results).transpose()
        toSave = np.column_stack((toSave, results, errors))
        np.savetxt("xD.csv", toSave, delimiter=",", fmt='%.5e')
        print("1.0")
        errors_abs = np.abs(errors)
        errors_num = np.count_nonzero(errors_abs < 0.5)
        print(errors_num/len(errors_abs))

    def generateRegions(self):
        test_data = np.genfromtxt(self.testingFile, delimiter=',')[1:,:2]
        x1_min = np.min(test_data[:,0])
        x2_min = np.min(test_data[:,1])
        x1_max = np.max(test_data[:,0])
        x2_max = np.max(test_data[:,1])
        x1s = np.arange(-1.5,1.5,self.stepGen)
        x2s = np.arange(-1.5,1.5,self.stepGen)
        normal_x1 = self.normaliseDataInput(x1s)
        normal_x2 = self.normaliseDataInput(x2s)
        normal_x = cartesian_product(np.array(normal_x1), np.array(normal_x2))
        results = []
        for x in normal_x:
            a_list, z_list = self.forward(x)
            result = self.denormaliseDataOutput(a_list[-1])[0]
            if(tasktype == "class"):
                result = round(result)
            results.append(result)
        toSave = np.column_stack((cartesian_product(x1s, x2s), np.asmatrix(results).transpose()))
        np.savetxt("2d_area.csv", toSave, delimiter=",", fmt='%.5e')

        
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


"""
start
"""
#z = [-6.42405464, -0.5816109,  -2.59580427,  0.02229016, -5.68224804,  1.81542828,
# -2.27152521, -2.11979715,  0.68543369,  3.58075488,  5.40923552,  1.458885,
#  6.06240861,  0.84906063,  2.81378707,  5.3062817,   0.52349386, -1.11544142, -1.5262414,  -3.17440911]
#print(np.exp(z))
#exit()
trainingFile = sys.argv[1]
testingFile = sys.argv[2]
neuronsByLayer = int(sys.argv[3])
layers = int(sys.argv[4])
epochs = int(sys.argv[5])
learningRate = float(sys.argv[6])
seed = int(sys.argv[7])
afunc = sys.argv[8]
tasktype = sys.argv[9]
step = float(sys.argv[10])

myNetwork = Network(trainingFile, testingFile, neuronsByLayer, layers, epochs, learningRate, seed, afunc, tasktype, step)
myNetwork.trainNetwork()
myNetwork.testNetwork()
if(tasktype == "class"):
    myNetwork.generateRegions()