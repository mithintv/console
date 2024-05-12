# Passing Variables by Value

Variables in Go are passed by value (except for a few data types we haven't covered yet). "Pass by value" means that when a variable is passed into a function, that function receives a *copy* of the variable. The function is unable to mutate the caller's data.

```go
func main(){
    x := 5
    increment(x)

    fmt.Println(x)
    // still prints 5,
    // because the increment function
    // received a copy of x
}

func increment(x int){
    x++
}
```

## Assignment

It's critical in Textio that we keep track of how many SMS messages we send on behalf of our clients. Fix the bug to accurately track the number of SMS messages sent.

1. Alter the `incrementSends` function so that it returns the result after incrementing the `sendsSoFar`.
2. Alter `main()` to capture the return value from `incrementSends()` and overwrite the previous `sendsSoFar` value.


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
