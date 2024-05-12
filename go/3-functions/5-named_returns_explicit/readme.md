# Named Return Values - Implicit Returns

Even though a function has named return values, we can still explicitly return values if we want to.

```go
func getCoords() (x, y int){
  return x, y // this is explicit
}
```

Using this explicit pattern we can even overwrite the return values:

```go
func getCoords() (x, y int){
  return 5, 6 // this is explicit, x and y are NOT returned
}
```

Otherwise, if we want to return the values defined in the function signature we can just use a naked `return` (blank return):

```go
func getCoords() (x, y int){
  return // implicitly returns x and y
}
```

## Assignment

Fix the function to return the named values *implicitly*.


# The Benefits of Named Returns

## Good For Documentation (Understanding)

Named return parameters are great for documenting a function. We know what the function is returning directly from its signature, no need for a comment.

Named return parameters are particularly important in longer functions with many return values.

```go
func calculator(a, b int) (mul, div int, err error) {
    if b == 0 {
      return 0, 0, errors.New("Can't divide by zero")
    }
    mul = a * b
    div = a / b
    return mul, div, nil
}
```

Which is easier to understand than:

```go
func calculator(a, b int) (int, int, error) {
    if b == 0 {
      return 0, 0, errors.New("Can't divide by zero")
    }
    mul := a * b
    div := a / b
    return mul, div, nil
}
```

We know *the meaning* of each return value just by looking at the function signature: `func calculator(a, b int) (mul, div int, err error)`

## Less Code (Sometimes)

If there are multiple return statements in a function, you don’t need to write all the return values each time, though you *probably* should.

When you choose to omit return values, it's called a *naked* return. Naked returns should only be used in short and simple functions.


# Early Returns

Go supports the ability to return early from a function. This is a powerful feature that can clean up code, especially when used as guard clauses.

Guard Clauses leverage the ability to `return` early from a function (or `continue` through a loop) to make nested conditionals one-dimensional. Instead of using if/else chains, we just return early from the function at the end of each conditional block.

```go
func divide(dividend, divisor int) (int, error) {
	if divisor == 0 {
		return 0, errors.New("Can't divide by zero")
	}
	return dividend/divisor, nil
}
```

Error handling in Go naturally encourages developers to make use of guard clauses. When I started writing more JavaScript, I was disappointed to see how many nested conditionals existed in the code I was working on.

Let’s take a look at an exaggerated example of nested conditional logic:

```go
func getInsuranceAmount(status insuranceStatus) int {
  amount := 0
  if !status.hasInsurance(){
    amount = 1
  } else {
    if status.isTotaled(){
      amount = 10000
    } else {
      if status.isDented(){
        amount = 160
        if status.isBigDent(){
          amount = 270
        }
      } else {
        amount = 0
      }
    }
  }
  return amount
}
```

This could be written with guard clauses instead:

```go
func getInsuranceAmount(status insuranceStatus) int {
  if !status.hasInsurance(){
    return 1
  }
  if status.isTotaled(){
    return 10000
  }
  if !status.isDented(){
    return 0
  }
  if status.isBigDent(){
    return 270
  }
  return 160
}
```

The example above is *much* easier to read and understand. When writing code, it’s important to try to reduce the cognitive load on the reader by reducing the number of entities they need to think about at any given time.

In the first example, if the developer is trying to figure out `when` 270 is returned, they need to think about each branch in the logic tree and try to remember which cases matter and which cases don’t. With the one-dimensional structure offered by guard clauses, it’s as simple as stepping through each case in order.
