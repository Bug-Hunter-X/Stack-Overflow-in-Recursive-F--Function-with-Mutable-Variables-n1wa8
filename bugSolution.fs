let rec loop acc x y =
    if x < 1000000 then
        loop (x + 1) (x + 1) (y + 1)
    else
        printfn "%d %d" x y

loop 0 0 0