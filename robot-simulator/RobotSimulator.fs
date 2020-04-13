module RobotSimulator

type Direction = North | East | South | West
type Position = int * int
type Robot = { direction: Direction; position: Position }

let create direction position =
    {direction = direction; position = position} 

let move (instructions: string) robot =
    let turnRight robot =
        match robot.direction with
        | Direction.North -> create Direction.East robot.position
        | Direction.East -> create Direction.South robot.position
        | Direction.South -> create Direction.West robot.position
        | Direction.West -> create Direction.North robot.position

    let turnLeft =
        turnRight >> turnRight >> turnRight

    let advance {direction = dir; position = (x, y)} = 
        match dir with
        | Direction.North -> create Direction.North (x, y + 1)
        | Direction.East -> create Direction.East (x + 1, y)
        | Direction.South -> create Direction.South (x, y - 1)
        | Direction.West -> create Direction.West (x - 1, y)

    let convertInstructions robot letter =
        match letter with
        | 'R' -> turnRight robot
        | 'L' -> turnLeft robot
        | 'A' -> advance robot
        | _ -> robot

    Seq.toList instructions
    |> List.fold (convertInstructions) robot