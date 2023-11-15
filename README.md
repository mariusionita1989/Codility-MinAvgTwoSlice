# Codility-MinAvgTwoSlice
A non-empty array A consisting of N integers is given.</br>
A pair of integers (P, Q), such that 0 ≤ P < Q < N, is called a slice of array A (notice that the slice contains at least two elements).</br>
The average of a slice (P, Q) is the sum of A[P] + A[P + 1] + ... + A[Q] divided by the length of the slice.</br>
To be precise, the average equals (A[P] + A[P + 1] + ... + A[Q]) / (Q − P + 1).

For example, array A such that:</br>
A[0] = 4</br>
A[1] = 2</br>
A[2] = 2</br>
A[3] = 5</br>
A[4] = 1</br>
A[5] = 5</br>
A[6] = 8</br>
contains the following example slices:</br>
slice (1, 2), whose average is (2 + 2) / 2 = 2;</br>
slice (3, 4), whose average is (5 + 1) / 2 = 3;</br>
slice (1, 4), whose average is (2 + 2 + 5 + 1) / 4 = 2.5.</br>
The goal is to find the starting position of a slice whose average is minimal.

Write a function:</br>
class Solution { public int solution(int[] A); }</br>
that, given a non-empty array A consisting of N integers, returns the starting position of the slice with the minimal average.</br> 
If there is more than one slice with a minimal average, you should return the smallest starting position of such a slice.

For example, given array A such that:</br>
A[0] = 4</br>
A[1] = 2</br>
A[2] = 2</br>
A[3] = 5</br>
A[4] = 1</br>
A[5] = 5</br>
A[6] = 8</br>
the function should return 1, as explained above.

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [2..100,000];</br>
each element of array A is an integer within the range [−10,000..10,000].
