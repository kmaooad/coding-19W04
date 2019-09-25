# Coding assignment. Week 4 (2019).

[![Join the chat at https://gitter.im/kmaooad/coding-19W04](https://badges.gitter.im/kmaooad/coding-19W04.svg)](https://gitter.im/kmaooad/coding-19W04?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
![](https://github.com/<REPOSITORY>/workflows/Grading/badge.svg)

### Task

Implement simple billing and invoicing app (see `Client.fs`).
App should support 3 operations:
 - Add billing record to the file (`bill()` function)
 - Read billing records from the file and produce invoices (`invoice()` function, `Invoice` type)
 - Wipe all recorded billing data (`wipe()` function)

There are also some business rules: 
 - Only one invoice should be generated per customer per month
 - Invoice contains all billing records for one month and has total amount - sum of all lines
 - Invoice has date which is the last day of the month

### Implementation hints

To write and read files, you might use standard operations:

`System.IO.File.AppendAllLines(*filename*, *lines list*)`

`System.IO.File.AppendAllText(*filename*, *text*)`

`System.IO.File.ReadAllLines(*filename*)`

`System.IO.File.ReadAllText(*filename*)`

To convert your types to/from text, you can choose whichever format you like, but JSON is recommended. One easy way to work with JSON in this task is use library [FSharp.Json](https://github.com/vsapronov/FSharp.Json), e.g.

`let str = Json.serialize bill`

`let bill = Json.deserialize<Bill> json`

### (Optional) Peer review

Though not mandatory, it is recommended to do some code review for your classmates and ask for code review from others. Discuss your points of view and chosen approaches.

### (Optional) Analyze dependencies

Not mandatory, but very recommended to train automatic 'design thinking' and enable intuitive understanding of many inherent issues in code/design. Dependency is relation between any two code/design entities (functions, types, even single code lines) when one entity (typically called *client*) somehow consumes or relies on another entity (typically called *server*). For your solution, think about what dependencies exist and what draw a simple diagram to depict them. Try to find **all** dependencies, even the most hidden ones. (Also, try to think about *implicit* dependencies - when some code entity depends on non-code entity or process.)

