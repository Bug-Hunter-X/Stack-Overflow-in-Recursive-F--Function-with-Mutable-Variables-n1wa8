# F# Stack Overflow Bug

This repository demonstrates a potential stack overflow error in F# that can occur when using mutable variables within recursive functions. The `bug.fs` file contains the buggy code. The `bugSolution.fs` file shows how to fix the bug.

## Description

The `loop` function uses mutable variables `x` and `y`.  In the original implementation, the function recursively calls itself until x reaches 1,000,000.  This creates a very deep call stack that can lead to a stack overflow exception on some systems.

## Solution

The solution uses tail recursion to solve this issue. Tail recursive functions are optimized by the compiler to avoid excessive stack usage.  The solution file uses an accumulator and modifies the loop function to always call itself as the last operation in the function.

## How to reproduce the bug

1. Compile and run `bug.fs`.
2. Observe the stack overflow exception (on some systems) or observe the correct output (on systems with larger stack sizes).

## How to run the solution

1. Compile and run `bugSolution.fs`. 
2. Observe the correct output without a stack overflow.