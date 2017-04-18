namespace GameOfLife

open System

type Cell() =
    let X = 0
    let Y = 0

    interface IComparable<Cell> with
        member this.CompareTo(obj: Cell): int = 
            0


type GameOfLife() = 
    member this.Evolve (set: Set<Cell>) = 
        null    

