library(stringr)
library("dplyr")
library("ggplot2")
library(gtools)

path = "C:/Users/Mateusz/source/repos/MateuszChilinski/SN_Project1/GUI/"
fileToAnalyse = "xD.csv"

problem = read.table(paste(path, fileToAnalyse, sep=""), 
                     colClasses = c("numeric", "numeric", "numeric", "numeric", "numeric"), sep=",")

colnames(problem) <- c("x1", "x2", "y", "y_nn", "err_nn")

# Change the point size, and shape
plot <- ggplot(problem, aes(x=x1, y=x2)) +
  geom_point(size=2, shape=23)
print(plot)