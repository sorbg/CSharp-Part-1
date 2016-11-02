# Number of Pages

## Description

A book has **N** pages, numbered **from 1 to N** (1, 2, 3, ... N - 1, N).

The total number of **digits** in the page numbers is **D**.

Write a program to find the number **D** by given number of pages (**N**).

## Input

- On the only input line, there will be the number - **N** - the number of the pages in the book.
- The input data will always be valid and in the format described. There is no need to check it explicitly.

## Output

- On the only output line, write the number **D** (the number of digits used for numbering the book pages)

## Constraints

- `1 < N < 1,000,000`
- Allowed working time for your program: **0.1s**
- Allowed memory: **16MB**

## Sample tests

|  Input  |  Output  |
|---------|----------|
| 4       | 4        |
| 100     | 192      |
| 1990    | 6853     |
| 185184  | 999999   |

# Hints
You can solve this task in at least 3 ways.

### Using one loop
1. You have to read **N** from the console.
    - What data type is appropriate?
1. You can use a loop from 1 to **N**.
    - That way you will get every page number.
1. Can you get the number of digits for every number from 1 to **N** using strings?
1. You'll need to sum every digit count in a variable.
    - What is the appropriate data type for the sum variable?
1. Lastly, you'll need to print the sum.

### Using nested loops
1. You have to read **N** from the console.
    - What data type is appropriate?
1. You can use a loop from 1 to **N**.
1. Can you get the number of digits for every number from 1 to **N** using a loop?(the operator `/` will help you here :))
1. You'll need to sum every digit count in a variable.
    - What is the appropriate data type for the sum variable?
1. Lastly, you'll need to print the sum.

### Without using loops
1. You have to read **N** from the console.
    - What data type is appropriate?
1. Look at the constraints.
1. You can use some conditional statements and some maths to calculate the result. Thinking about the following might help you:
    - Can you design a formula that calculates how many digits are there when **N** is below 100?
    - Can you design a formula that calculates how many digits are there when **N** is below 1000?
1. After you've calculated the result, you'll need to print it on the console.
    - What is the appropriate data type for the result variable?