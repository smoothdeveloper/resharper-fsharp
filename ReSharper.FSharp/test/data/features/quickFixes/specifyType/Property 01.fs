type A(b: B) =
    let _ = b.X.Length{caret}

and B() =
    member _.X = ""
