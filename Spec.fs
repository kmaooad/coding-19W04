namespace OOAD19.Coding.W04

open System
open Xunit
open FsCheck.Xunit
open Client

module Spec =

    [<Property>]
    let ``Empty billing returns no invoices`` (customer: int) (from: DateTime) (till: DateTime) =
        wipeall()
        let invoices = invoice customer from till
        Assert.True(List.isEmpty invoices)
    
    let private billMonth service customer month cost = 
        [ 1..28 ]
        |> List.iter (fun d -> bill service customer (DateTime(2018, month, d)) cost)

    [<Property>]
    let ``One invoice per month`` (s: byte) (c: uint16) (m: byte) (p: byte) =
        wipeall()
        
        let service = s |> int
        let customer = c |> int
        let cost = p |> decimal
        
        let month = (m |> int) % 12 + 1
        let month2 = (month + 4 ) % 12 + 1

        billMonth service customer month cost
        billMonth service customer month2 cost

        let invoices = invoice customer (DateTime(2018,1,1)) (DateTime(2018,12,31))

        Assert.True((List.length invoices) = 2)
        Assert.True(invoices |> List.forall (fun i -> i.total |> int = ((p |> int) * 28)))
        Assert.True(invoices |> List.forall (fun i -> i.customer = customer))
