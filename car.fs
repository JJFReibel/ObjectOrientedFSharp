(*
MIT License

Copyright (c) 2020 Jean-Jacques François Reibel

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*)

type Car() =
    [<DefaultValue>] val mutable wheels : int
    [<DefaultValue>] val mutable doors : int
    [<DefaultValue>] val mutable cylinders : int
    member this.addWheels(wheelsIn: int) =
       this.wheels <- this.wheels + wheelsIn
    member this.addDoors(doorsIn: int) =
       this.doors <- this.doors + doorsIn
    member this.addCylinders(cylindersIn: int) =
       this.cylinders <- this.cylinders + cylindersIn
    member this.deleteWheels(wheelsIn: int) =
       this.wheels <- this.wheels - wheelsIn
    member this.deleteDoors(doorsIn: int) =
       this.doors <- this.doors - doorsIn
    member this.deleteCylinders(cylindersIn: int) =
       this.cylinders <- this.cylinders - cylindersIn

printfn "\nCreating car."
let subaru = new Car(wheels = 4, doors = 4, cylinders = 4)
printfn "Wheels check: %d" (subaru.wheels)
printfn "Doors check: %d" (subaru.doors)
printfn "Cylinders check: %d" (subaru.cylinders)
printfn ""
printfn "Adding wheel directly to car object."
subaru.wheels <- 5
printfn "Wheels check: %d" (subaru.wheels)
printfn "Doors check: %d" (subaru.doors)
printfn "Cylinders check: %d" (subaru.cylinders)
printfn ""
printfn "Removing wheel using class method."
subaru.deleteWheels(1)
printfn "Wheels check: %d" (subaru.wheels)
printfn "Doors check: %d" (subaru.doors)
printfn "Cylinders check: %d" (subaru.cylinders)
printfn ""
