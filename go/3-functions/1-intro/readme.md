# Functions

Functions in Go can take zero or more arguments.

To make Go code easier to read, the variable type comes *after* the variable name.

For example, the following function:

```go
func sub(x int, y int) int {
  return x-y
}
```

Accepts two integer parameters and returns another integer.

Here, `func sub(x int, y int) int` is known as the "function signature".

## Assignment

We often will need to manipulate strings in our messaging app. For example, adding some personalization by using a customer's name within a template. The `concat` function should take two strings and smash them together.

* `hello` + `world` = `helloworld`

Fix the [function signature](https://www.devx.com/open-source-zone/programming-basics-the-function-signature/#:~:text=A%20function%20signature%20includes%20the%20function%20name%2C%20its%20arguments%2C%20and%20in%20some%20languages%2C%20the%20return%20type.) of `concat` to reflect its behavior.


# Multiple Parameters

When multiple arguments are of the same type, the type only needs to be declared after the last one, assuming they are in order.

For example:

```go
func add(x, y int) int {
  return x + y
}
```

If they are not in order they need to be defined separately.


# Declaration Syntax

Developers often wonder why the declaration syntax in Go is different from the tradition established in the C family of languages.

## C-Style syntax

The C language describes types with an expression including the name to be declared, and states what type that expression will have.

```c
int y;
```

The code above declares `y` as an `int`. In general, the type goes on the left and the expression on the right.

Interestingly, the creators of the Go language agreed that the C-style of declaring types in signatures gets confusing really fast - take a look at this nightmare.

```c
int (*fp)(int (*ff)(int x, int y), int b)
```

## Go-style syntax

Go's declarations are clear, you just read them left to right, just like you would in English.

```go
x int
p *int
a [3]int
```

It's nice for more complex signatures, it makes them easier to read.

```go
f func(func(int,int) int, int) int
```

## Reference

The [following post on the Go blog](https://blog.golang.org/declaration-syntax) is a great resource for further reading on declaration syntax.
