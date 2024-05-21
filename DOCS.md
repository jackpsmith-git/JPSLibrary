# JPS Library Docs
The JPS library is my own personal library for common methods that I use across my .NET projects. The JPS library is free and open-source software (FOSS) published under the MIT License. See LICENSE.txt for details. 
<p>&nbsp</p>

## Table of Contents
* 1.0.0.0 - Application
* 2.0.0.0 - Data
	* 2.1.0.0 - Cryptography
		* 2.1.1.0 - AES
		* 2.1.2.0 - RSA
		* 2.1.3.0 - SHA512
	* 2.2.0.0 - Encoding
		* 2.2.1.0 - ASCII
		* 2.2.2.0 - UTF8
	* 2.3.0.0 - Serialization
		* 2.3.1.0 XML
	* 2.4.0.0 Process
* 3.0.0.0 - File
	* 3.1.0.0 - Directory
* 4.0.0.0 - Math
	* 4.1.0.0 - Algorithm
		* 4.1.1.0 - Pathfinding
			* 4.1.1.1 - AStar
			* 4.1.1.2 - Dijkstra
		* 4.1.2.0 - Search
		* 4.1.3.0 - Sort
	* 4.2.0.0 - Random
		* 4.2.1.0 - Bool
		* 4.2.2.0 - Char
		* 4.2.3.0 - Int
		* 4.2.4.0 - String
<p>&nbsp</p>

## 1.0.0.0 Application
	namespace JPS.Application
provides classes containing application methods
<p>&nbsp</p>

## 2.0.0.0 Data
	namespace JPS.Data
provides classes for managing data
<p>&nbsp</p>

### 2.1.0.0 Cryptography
	namespace JPS.Data.Cryptography
provides classes containing cryptographic methods
<p>&nbsp</p>

#### 2.1.1.0 AES
	public static class JPS.Data.Cryptography.AES
provides static methods for encrypting and decrypting data with the Advanced Encryption Standard (AES)
<p>&nbsp</p>

    public static byte[] Encrypt(byte[] data, byte[] key, byte[] iv)
encrypts the given data using the given key and initialization vector 

data = data to encrypt
key = encryption key
iv = initialization vector

returns byte array containing encrypted data
<p>&nbsp</p>

	public static byte[] Decrypt(byte[] cipher, byte[] key, byte[] iv)
decrypts the given cipher using the given key and initialization vector

cipher = data to decrypt
key = decryption key
iv = initialization vector

returns byte array containing decrypted data
<p>&nbsp</p>

#### 2.1.2.0 RSA
	public static class JPS.Data.Cryptography.RSA
provides static methods for encrypting and decrypting data with the Rivest-Shamir-Adleman (RSA) algorithm
<p>&nbsp</p>

    public static byte[] Encrypt(byte[] data, RSAParameters key)
encrypts the given data using the given key

data = data to encrypt
key = encryption key

returns byte array containing encrypted data
<p>&nbsp</p>

    public static byte[] Decrypt(byte[] cipher, RSAParameters key)
decrypts the given data using the given key

cipher = data to decrypt
key = decryption key

returns byte array containing decrypted data
<p>&nbsp</p>

#### 2.1.3.0 SHA512
	public static class JPS.Data.Cryptography.SHA512
provides static methods for hashing data with the SHA512 algorithm
<p>&nbsp</p>

    public static byte[] Hash(byte[] exposed)
computes a hash for the given data

exposed = exposed data

returns byte array containing the computed hash
<p>&nbsp</p>

### 2.2.0.0 Encoding
	namespace JPS.Data.Encoding
provides classes containing encoding and decoding methods
<p>&nbsp</p>

#### 2.2.1.0 ASCII
	public static class JPS.Data.Encoding.ASCII
provides static methods for encoding and decoding data with the ASCII format
<p>&nbsp</p>

    public static byte[] Encode(string data)
encodes the given string into a byte array

data = the string to encode

returns byte array containing encoded data
<p>&nbsp</p>

    public static string Decode(byte[] data)
decodes the given byte array into a string

data = the byte array to decode

returns string containing decoded data
<p>&nbsp</p>

#### 2.2.2.0 UTF8
	public static class JPS.Data.Encoding.UTF8
provides static methods for encoding and decoding data with the UTF-8 format
<p>&nbsp</p>

    public static byte[] Encode(string data)
encodes the given string into a byte array

data = the string to encode

returns byte array containing encoded data
<p>&nbsp</p>

    public static string Decode(byte[] data)
decodes the given byte array into a string

data = the byte array to decode

returns string containing decoded data
<p>&nbsp</p>

### 2.3.0.0 Serialization
	namespace JPS.Data.Serialization
provides classes containing serialization and deserialization methods
<p>&nbsp</p>

#### 2.3.1.0 XML
	public static class JPS.Data.Serialization.XML
provides static methods for serializing and deserializing data to and from the XML format
<p>&nbsp</p>

    public static string Serialize(object obj)
serializes the given object to XML

obj = object to serialize

returns string containing serialized XML object data
<p>&nbsp</p>

    public static object? Deserialize(string str)
deserializes the given XML string into an object

str = the XML data to deserialize

returns deserialized object
<p>&nbsp</p>

### 2.4.0.0 Process
	public static class JPS.Data.Process
provides static methods for reading and writing data to and from a file
<p>&nbsp</p>

    public static void Write(byte[] data, string path)
writes the given data to the given file path

data = data to write
path = file path to write to

returns void
<p>&nbsp</p>

    public static byte[] Read(string path)
reads all data from the file in the given file path

path = file path containing file to read data from

returns byte array containing data read from file
<p>&nbsp</p>

## 3.0.0.0 File
	namespace JPS.File
provides classes cotaning file management methods.
<p>&nbsp</p>

### 3.1.0.0 Directory
	public static class JPS.File.Directory
provides static methods for manipulating directories and file paths.
<p>&nbsp</p>

    public static DirectoryInfo GetDirectoryInfo(string path)
creates an instance of the DirectoryInfo class for the given file path

path = file path

returns DirectoryInfo for the given file path
<p>&nbsp</p>

    public static FileInfo GetFileInfo(string path)
creates an instance of the FileInfo class for the given file path

path = file path

returns FileInfo for the given file path
<p>&nbsp</p>

    public static FileAttributes GetFileAttributes(string path)
creates an instance of the FileAttributes class for the given file path

path = file path

returns FileAttributes for the given file path
<p>&nbsp</p>

    public static void Clear(DirectoryInfo di)
deletes all files and directories in the given directory

di = the DirectoryInfo for the directory to clear

returns void
<p>&nbsp</p>

    public static void Hide(DirectoryInfo di)
hides the given directory

di = the DirectoryInfo for the directory to clear

returns void
<p>&nbsp</p>

    public static bool Exists(string path)
gets whether the given file path exists

path = file path

returns true if the file path exists, otherwise false
<p>&nbsp</p>

    public static bool IsDirectory(FileAttributes fa)
gets whether the given file path is a directory or a file

fa = the FileAttributes for the file path to check

returns true if the file path is a directory
returns false if the file path is a file
<p>&nbsp</p>

## 4.0.0.0 Math
	namespace JPS.Math
provides classes containing mathematic methods
<p>&nbsp</p>

### 4.1.0.0 Algorithm
	namespace JPS.Math.Algorithm
provides classes containing common computer science algorithms
<p>&nbsp</p>

#### 4.1.1.0 Pathfinding
	namespace JPS.Math.Algorithm.Pathfinding
provides classes containing pathfinding algorithms
<p>&nbsp</p>

##### 4.1.1.1a AStar
	public static class JPS.Math.Algorithm.Pathfinding.AStar
provides static methods for performing AStar pathfinding
<p>&nbsp</p>

    public static Stack<Node>? Execute(List<List<Node>> grid, Vector2 start, Vector2 end, int size)
executes A* pathfinding algorithm

grid = grid of nodes to navigate
start = starting node
end = ending node
size = grid size

returns stack of nodes to navigate from start to end
<p>&nbsp</p>

##### 4.1.1.1b Node
	public class JPS.Math.Algorithn.Pathfinding.AStar.Node
represents a node on a 2D weighted graph
<p>&nbsp</p>

	public int size;
node size
<p>&nbsp</p>

	pubic Node? parent;
parent node
<p>&nbsp</p>

	public Vector2 position;
node position
<p>&nbsp</p>

	public Vector2 center { get { return new Vector2(position.X + size / 2, position.Y + size / 2); } }
center of the graph relative to the node
<p>&nbsp</p>

	public float distance;
distance to end
<p>&nbsp</p>

	public float cost;
distance from start
<p>&nbsp</p>

	public float weight;
weight on the graph
<p>&nbsp</p>

	public float F;
weighted float
<p>&nbsp</p>

	public bool walkable;
true if the node is walkable, otherwise false
<p>&nbsp</p>

	public Node(Vector2 pos, bool walkable, float weight = 1)
node constructor

pos = node position
walkable = true if the node is walkable, otherwise false
weight = node weight on the graph

returns constructed node
<p>&nbsp</p>

##### 4.1.1.2 Dijkstra
	public static class JPS.Math.Algorithm.Pathfinding.Dijkstra
provides static methods for performing Dijkstra's algorithm
<p>&nbsp</p>

	public static int[] Execute(int[,] graph, int src, int weight)
performs Dijkstra's algorithm on an adjacency matrix representation of a graph

graph = the graph to perform Dijkstra's algorithm on
src = source vertex
weight = graph weight

returns constructed distance array
<p>&nbsp</p>

#### 4.1.2.0 Search
	public static class JPS.Math.Algorithm.Search
provides static methods for common search algorithms
<p>&nbsp</p>

	public static object? Linear(object element, object[] pool)
performs a linear search for the given element in the given pool

element = element to search for
pool = array to search through

returns object that has been found in pool
<p>&nbsp</p>

	public static object? Binary(object element, object[] pool)
performs a binary search for the given element in the given pool

element = element to search for
pool = array to search through

returns object that has been found in pool
<p>&nbsp</p>

	public static int Binary(int[] pool, int lo, int hi, int element)
performs a binary search for the given element in the given pool

pool = array to search through
lo = starting index
hi = ending index
element = the element to search for

returns the index of the found element in the pool
returns -1 if no element found
<p>&nbsp</p>

	public static int Interpolation(int n, int[] pool, int lo, int hi)
performs an interpolation search for the given element in the given pool

n = element to search for
pool = array to search through
lo = starting index
hi = ending index

returns the index of the found element in the pool
returns -1 if no element found
<p>&nbsp</p>

	public static int Jump(int n, int[] pool, int element)
performs a jump search for the given element in the given pool

pool = array to search through
element = element to search for

returns the index of found element in the pool
returns -1 if no element found
<p>&nbsp</p>

	public static int Exponentional(int element, int[] pool, int hi)
performs an exponential search for the given element in the given pool

element = element to search for
pool = array to search through
hi = ending index

returns the index of found element in the pool
returns -1 if no element found
<p>&nbsp</p>

	public static int Ternary(int lo, int hi, int element, int[] pool)
performs a ternary search for the given element in the given pool

lo = starting index
hi = ending index
element = element to search for
pool = array to search through

returns the index of found element in the pool
returns -1 if no element found
<p>&nbsp</p>

	public static int Fibonacci(int[] pool, int element, int hi)
performs a fibonacci search for the given element in the given pool

pool = array to search through
element = element to search for
hi = ending index

returns the index of found element in the pool
returns -1 if no element found
<p>&nbsp</p>

#### 4.1.3.0 Sort
	public static class JPS.Math.Algorithm.Sort
provides static methods for common sort algorithms
<p>&nbsp</p>

	public static int[] Insertion(int[] pool)
performs an insertion sort on the given pool

pool = array to sort

returns array containing sorted pool
<p>&nbsp</p>

	public static int[] Selection(int[] pool)
performs a selection sort on the given pool

pool = array to sort

returns array containing sorted pool
<p>&nbsp</p>

	public static int[] Bubble(int[] pool)
performs a bubble sort on the given pool

pool = array to sort

returns array containing sorted pool
<p>&nbsp</p>

	public static int[] Merge(int[] pool, int left, int right)
performs a merge sort on the given pool

pool = array to sort
left = left boundary
right = right boundary

returns array containing sorted pool
<p>&nbsp</p>

	public static int[] Quick(int[] pool, int left, int right)
performs a quicksort on the given pool

pool = array to sort
left = left boundary
right = right boundary

returns array containing sorted pool
<p>&nbsp</p>

### 4.2.0.0 Random
	namespace JPS.Math.Random
provides classes containing methods for generating random data
<p>&nbsp</p>

#### 4.2.1.0 Bool
	public static class JPS.Math.Random.Bool
provides static methods for generating random boolean values
<p>&nbsp</p>

	public static bool Generate()
generates a random boolean value

returns random boolean value
<p>&nbsp</p>

#### 4.2.2.0 Char
	public static class JPS.Math.Random.Char
provides static methods for generating random boolean values
<p>&nbsp</p>

	public static char Generate()
generates a random character

returns random character
<p>&nbsp</p>

#### 4.2.3.0 Int
	public static class JPS.Math.Random.Int
provides static methods for generating random integers
<p>&nbsp</p>

	public static int Generate()
generates a random integer

returns random integer
<p>&nbsp</p>

	public static int Generate(int upper, int lower)
generates a random integer between the given boundaries

upper = upper boundary
lower = lower boundary

returns random integer
<p>&nbsp</p>

#### 4.2.4.0 String
	public static class JPS.Math.Random.String
provides static methods for generating random strings
<p>&nbsp</p>

	public static string Generate(int length)
generates a random string of the given length

length = string length

returns random string
<p>&nbsp</p>