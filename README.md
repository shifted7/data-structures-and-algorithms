# data-structures-and-algorithms

## Table of Contents

- Class 01 - Array Reverse
- Class 02 - Array Shift
- Class 03 - Array Binary Search

## 401 Code Challenges - Found in challenges directory

### Code challenge class 01: Array Reverse
- Write a function called reverseArray which takes an array as an argument. Without utilizing any of the built-in methods available to your language, return an array with elements in reversed order.

#### Approach and Efficiency
- This code uses a for loop to iterate over the new array, and set its index values in ascending order. It sets these values equal to the input array's index values in descending order.
- The big O is O(n) time

#### Solution
- \challenges\ArrayReverse\assets\array-reverse.jpg


### Code challenge class 02: Array Shift
- Write a function called insertShiftArray which takes in an array and the value to be added. Without utilizing any of the built-in methods available to your language, return an array with the new value added at the middle index.

#### Approach and Efficiency
- This code creates a new array with a length one longer than the current array. It then finds the value of the middle index of the new array based on its length. The method then loops over the new array, and for indexes less than the middle index, enters the values at those indexes from the current array. At the middle index, it enters the new value. At indexes greater than the middle index, it enters the values from the current array at the new array index - 1.
- The big O is O(n) time

#### Solution
- \challenges\ArrayShift\assets\ArrayShift Working.png

### Code challenge class 03: Array Binary Search
- Write a function called BinarySearch which takes in 2 parameters: a sorted array and the search key. Without utilizing any of the built-in methods available to your language, return the index of the array’s element that is equal to the search key, or -1 if the element does not exist.

#### Approach and Efficiency
- This code takes the given array and first sets upper and lower limits equal to the array's highest and lowest indexes of 0 and it's length -1. It also initializes a middle index. It enters a loop, which will run as long as the lower limit is less than or equal to the upper limit. The middle index now gets set as the index in the middle of the two limits. The code compares the value at the middle index to the key. If the value is less than the key, it moves the lower limit to the middle index + 1, since we know the key cannot be at lower index. If the value is more than the key, it moves the upper limit to the middle index - 1, since we know the key cannot be at a higher index. If the value is equal to the key, we return the middle index, because we have found our value. If the lower and upper limits are the same and the value is not at that index, the whole array has been searched, the loop is exited, and -1 is returned.
- The big O is O(log n) time O(1) space

#### Solution
[array binary search whiteboard](https://github.com/shifted7/data-structures-and-algorithms/blob/master/challenges/BinarySearch/assets/array-binary-search.jpg)
