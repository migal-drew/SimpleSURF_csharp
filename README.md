|==========================================|
|      Simple SURF (S-Surf)      	       |
|==========================================|
This is a simplified version of            
SURF algorithm(the same principles and
calculations of Hessian filters).
Changes:
-Algorithm is sensitive to rotation and scale
(max rotation angle is 15 degrees)
-It's possible to use custom range of scales
(octaves)
-Hessian values are computed for each pixel
(interpolation isn't implemented)
============================================