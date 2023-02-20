// For more information see https://aka.ms/fsharp-console-apps
open Lexer
open Parser
open FSharp.Text.Lexing
open System
open System.IO


let ls = 
    do printf "Super lexer"
    let lexbuff = LexBuffer<char>.FromString @" ""test\n"" "
    let rec lexing_loop acc =
        match lexer_main lexbuff with
        | EOF -> []
        | _ as tok -> tok :: (lexing_loop acc)
    let token_list = lexing_loop []
    do printfn "%A" token_list
