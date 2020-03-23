# data-structures-and-algorithms

## Table of Contents

- Class 01 - Array Reverse
- Class 02 - Array Shift
- Class 03 - Array Binary Search
- Class 05 - Linked List

## 401 Code Challenges - Found in challenges directory

### Code Challenge Class 01: Array Reverse
- Write a function called reverseArray which takes an array as an argument. Without utilizing any of the built-in methods available to your language, return an array with elements in reversed order.

#### Approach and Efficiency
- This code uses a for loop to iterate over the new array, and set its index values in ascending order. It sets these values equal to the input array's index values in descending order.
- The big O is O(n) time

#### Solution
![Array Reverse Solution Whiteboard](https://github.com/shifted7/data-structures-and-algorithms/blob/master/challenges/ArrayReverse/assets/array-reverse.jpg)


### Code Challenge Class 02: Array Shift
- Write a function called insertShiftArray which takes in an array and the value to be added. Without utilizing any of the built-in methods available to your language, return an array with the new value added at the middle index.

#### Approach and Efficiency
- This code creates a new array with a length one longer than the current array. It then finds the value of the middle index of the new array based on its length. The method then loops over the new array, and for indexes less than the middle index, enters the values at those indexes from the current array. At the middle index, it enters the new value. At indexes greater than the middle index, it enters the values from the current array at the new array index - 1.
- The big O is O(n) time

#### Solution
![Array Shift Solution Whiteboard](https://github.com/shifted7/data-structures-and-algorithms/blob/master/challenges/ArrayShift/assets/array-shift.jpg)

### Code Challenge Class 03: Array Binary Search
- Write a function called BinarySearch which takes in 2 parameters: a sorted array and the search key. Without utilizing any of the built-in methods available to your language, return the index of the array’s element that is equal to the search key, or -1 if the element does not exist.

#### Approach and Efficiency
- This code takes the given array and first sets upper and lower limits equal to the array's highest and lowest indexes of 0 and it's length -1. It also initializes a middle index. It enters a loop, which will run as long as the lower limit is less than or equal to the upper limit. The middle index now gets set as the index in the middle of the two limits. The code compares the value at the middle index to the key. If the value is less than the key, it moves the lower limit to the middle index + 1, since we know the key cannot be at lower index. If the value is more than the key, it moves the upper limit to the middle index - 1, since we know the key cannot be at a higher index. If the value is equal to the key, we return the middle index, because we have found our value. If the lower and upper limits are the same and the value is not at that index, the whole array has been searched, the loop is exited, and -1 is returned.
- The big O is O(log n) time O(1) space

#### Solution
![Array Binary Search Solution Whiteboard](https://github.com/shifted7/data-structures-and-algorithms/blob/master/challenges/BinarySearch/assets/array-binary-search.jpg)

### Code Challenge Class 05: Linked List
- Create a Node class that has properties for the value stored in the Node, and a pointer to the next Node.
- Within your LinkedList class, include a head property. Upon instantiation, an empty Linked List should be created.
- Define a method called insert which takes any value as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.
- Define a method called includes which takes any value as an argument and returns a boolean result depending on whether that value exists as a Node’s value somewhere within the list.
- Define a method called toString which takes in no arguments and returns a string representing all the values in the Linked List, formatted as:
`"{ a } -> { b } -> { c } -> NULL"`
- Any exceptions or errors that come from your code should be semantic, capturable errors. For example, rather than a default error thrown by your language, your code should raise/throw a custom, semantic error that describes what went wrong in calling the methods you wrote for this lab.
- Be sure to follow your language/frameworks standard naming conventions (e.g. C# uses PascalCasing for all method and class names).

#### Approach and Efficiency
- This code has two classes, Node and LinkList. It gives Node two properties: a value and the next node in the list (which is a reference). The LinkList class has two properties which are used in its methods: Head, which references the first Node in the LinkList, and Current, which references the specific Node on which the LinkList is currently operating. LinkList has three methods which make up the bulk of its functionality. Insert creates a new node and sets that Node as the new head, making sure to first set the new Node's Next property to the old Head so that it is not cleaned up during garbage collection. Includes loops over the list while checking each Node for the given value, using that Node's Next property to iterate along the whole list. ToString also loops over the whole list, using StringBuilder to put the string together, making sure to properly append NULL to the end. All three methods have exception handling. For testing, there is one test for each method, and two for includes (testing the negative case).

#### Solution
(Whiteboarding not required for this implementation)
