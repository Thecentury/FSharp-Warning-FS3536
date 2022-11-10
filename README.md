# Reproduction of the F# 7.0 compiler warning FS3536 "IEnumerable<_>' is normally used as a type constraint in generic code"

The warning is produced for the [function](https://github.com/Thecentury/FSharp-Warning-FS3536/blob/master/Project/Prelude.fs#L8)
```fsharp
let listAsSeq (l : List<'a>) = l :> seq<'a>
```

It's crucial to have an open directive for the `FSharp.Core.Fluent` namespace of the `FSharp.Core.Fluent` package to get the warning - it is not produced when this directive is not present.

## Versions of tools

- MSBuild - `C:\Program Files\dotnet\sdk\7.0.100\MSBuild.dll`
    
    `MSBuild version 17.4.0+18d5aef85 for .NET`
