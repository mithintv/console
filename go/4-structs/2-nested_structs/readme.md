# Nested structs in Go

Structs can be nested to represent more complex entities:

```go
type car struct {
  Make string
  Model string
  Height int
  Width int
  FrontWheel Wheel
  BackWheel Wheel
}

type Wheel struct {
  Radius int
  Material string
}
```

The fields of a struct can be accessed using the dot `.` operator.

```go
myCar := car{}
myCar.FrontWheel.Radius = 5
```

## Assignment

Textio has a bug, we've been sending texts with information missing! Before we send text messages in Textio, we should check to make sure the required fields have non-zero values.

Notice that the `user` struct is a nested struct within the `messageToSend` struct. Both `sender` and `recipient` are `user` struct types.

Complete the `canSendMessage` function. It should return `true` only if the `sender` and `recipient` fields each contain a `name` and a `number`. If any of the default zero values are present, return `false` instead.


# Anonymous Structs in Go

An anonymous struct is just like a normal struct, but it is defined without a name and therefore cannot be referenced elsewhere in the code.

To create an anonymous struct, just instantiate the instance immediately using a second pair of brackets after declaring the type:

```go
myCar := struct {
  Make string
  Model string
} {
  Make: "tesla",
  Model: "model 3"
}
```

You can even nest anonymous structs as fields within other structs:

```go
type car struct {
  Make string
  Model string
  Height int
  Width int
  // Wheel is a field containing an anonymous struct
  Wheel struct {
    Radius int
    Material string
  }
}
```

## When should you use an anonymous struct?

In general, *prefer named structs*. Named structs make it easier to read and understand your code, and they have the nice side-effect of being reusable. I sometimes use anonymous structs when I *know* I won't ever need to use a struct again. For example, sometimes I'll use one to create the shape of some JSON data in HTTP handlers.

If a struct is only meant to be used once, then it makes sense to declare it in such a way that developers down the road won’t be tempted to accidentally use it again.

You can read more about [anonymous structs here](https://blog.boot.dev/golang/anonymous-structs-golang/) if you're curious.
