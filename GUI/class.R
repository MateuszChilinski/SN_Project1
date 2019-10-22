library(stringr)
library("dplyr")
library("ggplot2")
library(gtools)
args = commandArgs(trailingOnly=TRUE)

path = args[1]

fileToAnalyse = "xD.csv"
file2d = "2d_area.csv"
problem = read.table(paste(path, fileToAnalyse, sep=""), 
                     colClasses = c("numeric", "numeric", "character", "numeric", "numeric"), sep=",")

d2_solution = read.table(paste(path, file2d, sep=""), 
                         colClasses = c("numeric", "numeric", "character"), sep=",")

colnames(d2_solution) <- c("x1", "x2", "y_nn")

colnames(problem) <- c("x1", "x2", "y", "y_nn", "err_nn")

# Change the point size, and shape
plot <- ggplot(d2_solution, aes(x=x1, y=x2, color=y_nn)) +
  geom_point(size=5.65, shape=15, alpha = 0.3) +
  geom_point(data = problem, aes(x = x1 , y = x2, color=y))

myFun <- function(n = 5000) {
  a <- do.call(paste0, replicate(5, sample(LETTERS, n, TRUE), FALSE))
  paste0(a, sprintf("%04d", sample(9999, n, TRUE)), sample(LETTERS, n, TRUE))
}
name = myFun(1)
ggsave(paste(path, paste(name, ".png", sep=""), sep=""), width=12, height=12)

print(name)