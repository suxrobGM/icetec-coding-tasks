# Icetec Interview Coding Tasks
Icetec interview coding problems and solutions

## Tasks (Codecraft, Problem Solving):
1.	(Elixir) Create a program in Elixir that returns a list of all numbers from 1 to 100. However, for each number that is divisible by three, return “Div3”. Also, for each number divisible by 5 return “Div5”. For numbers that are divisible by both 3 and 5 the program should return “Div3&5”. Show and explain the operation.

Solution in Elixir: [Task1](./src/Task1/Task1.ex)

2.	(Using tool of choice) Given a CSV file containing some customer’s 5 min load profile, determine the hourly peak demand for each month (peak demand = date and hour of the highest usage during the given time window).
    * What if their bill goes from the 15th to the 15th of each month?
    * What if demand is only determined during on-peak hours? (on-peak defined as weekdays, 7AM-8PM) (files: rbhs-campus-load-april-2023-data.csv)

Solution in C# (.NET 8): [Task2](./src/Task2/Program.cs)

3.	(Using tool of choice) Convert 2 given JSON files (weather time series) to CSV time-series. First column should be human-readable datetime (New York timezone). 
(files: Princeton(40.35,-74.66)-15min-e.json, Wilmington(39.74,-75.55).json)

Solution in C# (.NET 8): [Task3](./src/Task3/Program.cs)

