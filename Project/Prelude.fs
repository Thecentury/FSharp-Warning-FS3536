module Prelude

// This open directive is crucial to produce the FS3536 warning, though no code from that namespace is actually used.
open FSharp.Core.Fluent

// Function produces a warning
// Prelude.fs(8, 18): [FS3536] 'IEnumerable<_>' is normally used as a type constraint in generic code, e.g. "'T when ISomeInterface<'T>" or "let f (x: #ISomeInterface<_>)". See https://aka.ms/fsharp-iwsams for guidance. You can disable this warning by using '#nowarn "3536"' or '--nowarn:3536'.
let listAsSeq (l : List<'a>) = l :> seq<'a>
