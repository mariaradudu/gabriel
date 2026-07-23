var repository =
    new Repository();

var crystal =
    repository.Create();

Console.WriteLine(
    "Initial Crystal");

new Renderer().Draw(
    crystal);

new GrowthEngine()
    .Simulate(
        crystal);

Console.WriteLine(
    "Final Crystal");

new Renderer().Draw(
    crystal);

new Statistics()
    .Print(
        crystal);

new Exporter()
    .Save(
        crystal);
