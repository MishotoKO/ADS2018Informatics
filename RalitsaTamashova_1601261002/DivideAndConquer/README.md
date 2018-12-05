Examples of Divide and Conquer algorithms:

Quick sort: It picks an element as pivot and partitions the given array around the picked pivot. Target of partitions is, given an array and an element x of array as pivot, put x at its correct position in sorted array and put all smaller elements (smaller than x) before x, and put all greater elements (greater than x) after x. 

Heap sort: Heap sort is a comparison based sorting technique based on Binary Heap data structure. It is similar to selection sort where we first find the maximum element and place the maximum element at the end. Partially this algorithm is divide and conquer algorithm, because when the maximum element is placed at the end of the array, the algorithm separates the array to sorted and unsorted parts and iterates only the unsorted part.

Binary search: Search a sorted array by repeatedly dividing the search interval in half. Begin with an interval covering the whole array. If the value of the search key is less than the item in the middle of the interval, narrow the interval to the lower half. Otherwise narrow it to the upper half. Repeatedly check until the value is found or the interval is empty.

Fibonacci Search: Fibonacci search is similar to binary search � both of them are used for sorted arrays, they are divide and conquer algorithms. One of the differences is the way of picking up the element from the array to compare with. The idea is to first find the smallest Fibonacci number that is greater than or equal to the length of given array. Let the found Fibonacci number be fib (m�th Fibonacci number). We use (m-2)�th Fibonacci number as the index (If it is a valid index). Let (m-2)�th Fibonacci Number be i, we compare arr[i] with x, if x is same, we return i. Else if x is greater, we recur for subarray after i, else we recur for subarray before i.

Interpolation Search: The Interpolation Search is an improvement over Binary Search for instances, where the values in a sorted array are uniformly distributed. Binary Search always goes to the middle element to check. On the other hand, interpolation search may go to different locations according to the value of the key being searched. For example, if the value of the key is closer to the last element, interpolation search is likely to start search toward the end side.