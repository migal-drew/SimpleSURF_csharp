|===========================================|
|      Simple SURF (S-Surf)      	        |
|===========================================|
This is a simplified version of            
SURF algorithm(the same principles and
calculations of Hessian filters).
--------------------------------------------
-Algorithm is sensitive to rotation and scale
(max rotation angle is 15 degrees)
-Now uses only one custom octave
(bottom octave) and 4 intervals
-Hessian values are computed for each pixel
(interpolation isn't implemented)
-For large images requires lots of time
=============================================