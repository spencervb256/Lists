COIS 2020H Assignment 2
For Brian Srivastava
bsrivastava@trentu.ca

Programming Question
As with A1, please put testing for each method listed in a Word (or similar) document along with your theory answers.  
In Assignment 1 you created an Array and a Linked List using built in arrays and linked lists of Mobile Objects which you defined yourself.
In this assignment, you are to build your own ArrayList and a DOUBLY Linked List based on the labs
Replace your Grid class from A1 with a multi dimensional array list (which you’ve implemented yourself) – still of cells, and replace your list of mobile objects with a doubly linked list you implement yourself.  
You can make other methods you need as well, you need to develop a test case to show how each works and relevant edge cases, but you must have the following (some are from the labs obviously).  

If needed for the sake of ease of presentation or convenience you can trim down on the number of objects or their sets of properties etc.  
Mobile Objects:
	Modify your mobile objects to have a public abstract ‘toString’ method which creates a string which could then be printed by the calling method that displays all properties of the object.  E.g. Console.WriteLine(mob1.toString()); (You’ll need to override this in the cat and snake subclasses)

	Make a variant of toString called toStringS, as in toString, shortened – which prints only a couple of properties of the object, most likely just name and ID but use this method to reduce screen clutter, you can decide which are the key properties.  


 
ArrayList: 
	Create: this can create an empty list
	Private Grow:  this should double the size of the array when it Grows
	Append.  (assume that you can *only* append to add things), this adds at the last index, calls grow if needed… like the lab
	InPlaceSort.  This should sort the array list in place without making a new Array, use built in array sorting for this for now.  
	Swap(index1, index2): should swap the position of two elements in the array list
	DeleteLast:  Should delete the last element.  
	Public Static method Merge – this should take two ArrayLists, and produce a third which is the first two merged in an unsorted order.  
	StringPrintAllForward:  This returns a string which is the whole structure printed from beginning to end)
	StringPrintAllReverse:  Same as above but reverse order.  
	Deleteall



Doubly Linked List:
This should have a head and a tail node, and nodes should have references to both next and previous. 
	Create: Creates an empty list
	AddFront:  Adds a new node at the head
	AddLast:  Adds a new node at the tail
	GetCount – (Should be O(1) meaning you need to track the count in other methods
	InsertAtRandomLocation (keep track of the size of the list, generate a random # up to that size, insert at that position in the list)
	Merge, unlike ArrayList this should be a method of a single list and should merge another list onto the calling one at the end (and update the count correctly)
	FindClosest():  Searches (brute force) returns the closest object to the one which calls this method.  The equation for distance between two points is: 
√((〖x_1-x_2)〗^2+(〖y_1-y_2)〗^2+(〖z_1-z_2)〗^2 )
But obviously you don’t actually need to compute the square root to simply find which one is closest.  

	DeleteFirst
	DeleteLast
	PrintAllForward
	PrintAllReverse
	DeleteAll

Quick Theory Note:   I talked about this in class, but the two different approaches to merge(one in arraylist and one in linkedlist) are both valid in some sense.  Which one you should prefer depends a bit on the appropriate design/responsibility of the relevant classes and possibly any memory constraints.  

Program Testing
Test each method listed on the previous page, and put that in your documentation.   Some basic testing scenarios:  Add several elements to an empty structure, delete elements, add some more, delete some more.  InsertAtRandom should not crash on an empty list.  InPlaceSort should not crash on an empty list, that sort of thing.  

Theory Questions
Dynamic Binding (also known as late binding) is a core component of the windows COM (component object model), which later evolved into .NET, and is part of related frameworks including for Apple.  Give 5 examples of the sorts of problems that dynamic binding helps you solve, and how (1-3 sentences per answer, ~250-500 words ish, more is ok if you need it). 


Big Oh Notation Simple problems. 
	Give the order of growth (as a function of input size ‘N’ ) of the running times of each of the following code fragments (show your work, and yes, these are trivial examples, I know you can find solutions on the web or just run the code, which you should do to verify/explain the answer):
a.
int sum = 0;
for (int n = N; n > 0; n /= 2)
    for(int i = 0; i<n; i++)
        sum++;

b.
int sum = 0;
for (int i = 1 i<N; i *= 2)
    for (int j = 0; j<i; j++)
        sum++;

c.
int sum = 0;
for (int i = 1 i<N; i *= 2)
    for (int j = 0; j<N; j++)
        sum++;


Program/Algorithm Questions
The Following three questions are sample interview questions for programmers, students should probably know how to answer them
Write programs for each of these problems but keep them simple – focus on just solving the algorithm problem, don’t worry about making them pretty or advanced error checking weird edge cases or that sort of thing.   Show some minimal testing, such as the main test case described.  

	A) Write a program that, given an array a[] of N distinct integers, finds a local maximum: an index i such that a[i-1] < a[i] > a[i+1]. Your Algorithm should use ~2log N compares in the worst case (this is a binary search variant).  
B) Modify your algorithm to account for ‘plateaus’ (e.g. {1,2,3,4,5,5,5,5,5,5,4,3,2} as well.  


	A) Given an integer x and an unsorted array of integers, write a program to  determine whether two of the numbers in the array add up to x.   
B) Modify your answer so that the array is sorted (you should be able to efficiently search in this case).  


	Write a program that for a given array that will find the all possible (continuous) sub arrays with a sum less than some input value K.  Strictly speaking a sub array can contain only 1 element, but we’re interested in sub arrays of more than one element.   E.g. given an array {1, 2, 3, 4, 5, 6, 7, 8, 9, 10} and an input K =6, sub arrays {1,2}, {2,3} are both less than 6.  If K = 7 {1,2,3} now becomes a valid sub array as well.  


	1



