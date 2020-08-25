# Gods2x2
A program to brute-force a solution to your 2x2 cube, potentially using ZERO ALGORITHMS!

This program first brute-forces a solution to the first layer of the 2x2 cube.
From there, it permutes the top corners using a single commutator. If necessary, the program will apply a singular algorithm to fix the back two corners on the top.
Then, the program orients the top corners using a single commutator, solving the cube.

---

The goal of this project was the solve a 2x2 cube using the least amount of algorithms as we can, instead relying on brute-force whenever possible, only resorting to commutators and (at worst) a singular algorithm when absolutely necessary.

Contrary to what you'd might think, this program can solve a 2x2 cube reasonably fast (considering its inherent slowness as a result of its reliance on brute-force).
However if you're looking for speed, check out my more efficent algorithm, CubeBot2.0.

Enjoy,
iBoot32

# How to use
`Gods2x2.exe <cubestring>`

## What is a cubestring?
A cubestring is used in both cube-solving algorithms I've written. Simply put, it's a way for my algorithm to know what your cube looks like, without visually showing a cube.
For a 2x2 cube, a cubestring is a string of 24 characters, each character representing the color of a specific sticker on the cube.

## How to format a cubestring?

Simply put, all you do is enter the colors of each piece on the cube with a defined order, which is as follows:
Pieces are read in this order: 

Start reading pieces with the top, back, left corner. Whenever you are reading a piece on the top face, you read the piece's sticker colors `top`, `left/right`, and then `back/front`. 
Going clockwise, read the next piece on the top face of the cube (in the same way).
After reading all the pieces on the top face, go to the bottom and do the same thing (starting with bottom, back, left), but read the colors `bottom`, `left/right`, and then `back/front`.

For example, the moves `R U D F B` on a 2x2 produces the cubestring: `BWOYBRYGRBYOGYOWGRWBRGWO`


---

License:

You may do whatever you would like using this program, as long as the following conditions are met:

- You email me (iboot32@gmail.com) prior to using this program (regardless of personal/commercial use)
- You credit me somewhere in the application using my program (preferably in the ReadMe)


