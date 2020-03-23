module QueenAttack

let create ((a, b): int * int) =
    a >= 0 && a < 8 && b >= 0 && b < 8

let canAttack ((q1_row, q1_column): int * int) ((q2_row, q2_column): int * int) =
    q1_row = q2_row || q1_column = q2_column || abs (q1_row - q2_row) = abs (q1_column - q2_column)