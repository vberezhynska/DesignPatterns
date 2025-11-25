// See https://aka.ms/new-console-template for more information
using Adapter;

Console.WriteLine("Hello, Adapter pattern!");

var roundHole = new RoundHole(8);
var roundPeg = new RoundPeg(5);
var squareToRadius = new SquareRoundPegAdapter(new SquarePeg(10));
var triangleToRadius = new TriangleRoundPegAdapter(new TrianglePeg(4, 6, 7));
Console.WriteLine($"Round peg with radius {roundHole.GetRadius()} {roundHole.FitsSt(roundPeg)} round hole with radius {roundPeg.GetRadius()}.");
Console.WriteLine($"Square peg with radius {roundHole.GetRadius()} {roundHole.FitsSt(squareToRadius)} round hole with radius {squareToRadius.GetRadius()}.");
Console.WriteLine($"Triangle peg with radius {roundHole.GetRadius()} {roundHole.FitsSt(triangleToRadius)} round hole with radius {triangleToRadius.GetRadius()}.");