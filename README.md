# DQ

![build status](https://github.com/moreal/DQ/workflows/build%20test/badge.svg)

.NET Library for query to dictionary effectively

## Example

If there was a dictionary and a query like below, the process of the query should return `true`.

```c#
var query = ".name == 'Kevin'";
var dictionaries = new Dictionary<string, string> {
    ["name"] = "Kevin",
};
```

The interface was not yet. it just has presented prototype of query interface.