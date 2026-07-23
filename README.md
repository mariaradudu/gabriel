
# Crystal Growth Simulator

Crystal Growth Simulator is a C# console application that demonstrates a simple cellular growth model inspired by crystal formation.

The simulation starts with several crystal seeds and gradually expands them across a grid. Although simplified, it illustrates neighborhood-based growth and visualization using ASCII characters.

## Features

- Random crystal seeds
- Step-by-step growth
- ASCII visualization
- Growth statistics
- Export final state

## Legend

```
. Empty cell
* Crystal
```

## Example

```
Initial

............
.....*......
............
...*........
............

Iteration 10

..*****.....
.*******....
*********...
.*******....
..*****.....

Crystal cells: 47
Coverage: 31%
```

Run

```bash
dotnet run
```
