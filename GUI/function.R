library(stringr)
library("dplyr")
library("ggplot2")
library(gtools)

args = commandArgs(trailingOnly=TRUE)

path = args[1]

fileToAnalyse = "xD.csv"
file2d = "function.csv"
problem = read.table(paste(path, fileToAnalyse, sep=""), 
                     colClasses = c("numeric", "numeric", "numeric", "numeric"), sep=",")

d2_solution = read.table(paste(path, file2d, sep=""), 
                         colClasses = c("numeric", "numeric"), sep=",")

colnames(d2_solution) <- c("x", "y_nn")

colnames(problem) <- c("x", "y", "y_nn", "err_nn")

# Change the point size, and shape
plot <- ggplot(problem, aes(x=x, y=y)) +
  geom_point(size=0.2, shape=15) +
  geom_line(data = problem, aes(x = x , y = y_nn))


myFun <- function(n = 5000) {
  a <- do.call(paste0, replicate(5, sample(LETTERS, n, TRUE), FALSE))
  paste0(a, sprintf("%04d", sample(9999, n, TRUE)), sample(LETTERS, n, TRUE))
}
name = myFun(1)
ggsave(paste(path, paste(name, ".png", sep=""), sep=""), width=12, height=12)

print(name)