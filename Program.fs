// For more information see https://aka.ms/fsharp-console-apps
open Lexer
open FSharp.Text.Lexing
open System.IO


let ls = 
    do printf "Super lexer"
    let lexbuff = LexBuffer<char>.FromString @"""test\n"""
    let tok = lexer_main "" lexbuff
    do printfn "%A" tok

