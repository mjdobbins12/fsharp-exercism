module GradeSchool

type School = Map<int, string list>

let empty: School = Map.empty

let add (student: string) (grade: int) (school: School): School =
    school.Add(grade, [student])

let roster (school: School): string list =
    school
    |> Map.toList
    |> List.collect (fun (_, students) -> List.sort students)

let grade (number: int) (school: School): string list = failwith "You need to implement this function."
