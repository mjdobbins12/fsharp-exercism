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

    let convertInstructions robot letter =
        match letter with
        | 'R' -> turnRight robot
        | _ -> robot

    Seq.toList instructions
    |> List.fold (convertInstructions) robot