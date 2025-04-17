# CircularBuffer

A simple, generic circular buffer (ring buffer) in C# for practicing and demonstrating data structures.

## Features

- Fixed-size buffer with generic type support
- FIFO behavior (First-In-First-Out)
- Overwrites old values when the buffer is full
- Optional visualization methods for debugging

## Example

```csharp
CircularBuffer<int> buffer = new(3);
buffer.Add(1);
buffer.Add(2);
buffer.Add(3);
buffer.Add(4); // overwrites 1
var value = buffer.Dequeue(); // returns 2
Console.WriteLine(buffer.Read().ToString());
Console.WriteLine(buffer.ToString());
