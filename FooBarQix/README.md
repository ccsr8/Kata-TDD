# FooBarQix

## Rules

- If the number is divisible by 3, write "Foo" instead of the number
- If the number is divisible by 5, add "Bar"
- If the number is divisible by 7, add "Qix"
- For each digit 3, 5, 7, add "Foo", "Bar", "Qix" in the digits order.

## Test Case

| Scenario                 | Input |  Output   | Output                                     |
| ------------------------ | ----: | :-------: | ------------------------------------------ |
| Not Divisible by 3, 5, 7 |     1 |     1     |                                            |
|                          |     2 |     2     |                                            |
|                          |     4 |     4     |                                            |
| Divisible by 3           |     6 |    Foo    |                                            |
| Divisible by 5           |    10 |    Bar    |                                            |
| Divisible by 7           |    14 |    Qix    |                                            |
| Replace digit 3, 5, 7    |     3 |  FooFoo   | divisible by 3, contains 3                 |
|                          |     5 |  BarBar   | divisible by 5, contains 5                 |
|                          |     7 |  QixQix   | divisible by 7, contains 7                 |
| Multiple condition       |    15 | FooBarBar | divisible by 3, divisible by 5, contains 5 |
|                          |    33 | FooFooFoo | divisible by 3, contains two 3             |
|                          |    21 |  FooQix   | divisible by 3, 7                          |
|                          |    51 |  FooBar   | divisible by 3, contains 5                 |
|                          |    53 |  BarFoo   | contains by 5, contains 3                  |
