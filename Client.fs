namespace OOAD19.Coding.W04

open System

module Client =

    type Invoice =
        { total: decimal
          customer: int
          date: DateTime }

    // Removes all billing data
    let wipeall() : unit = failwith "not imlemented yet"

    // Adds billing record for given customer, service, date, and total amount (cost $)
    let bill (service: int) (customer: int) (date: DateTime) (amount: decimal): unit = failwith "not imlemented yet"

    // Generates invoice(s) for the given customer and period (from/till)
    // Rule: Only 1 invoice per month. If period spans over several months, several invoices should be generated.
    // Rule: No empty invoices. Invoice is generated only if there is billing data for the month.
    // Rule: Invoice date is the last day of the month.
    let invoice (customer: int) (from: DateTime) (till: DateTime): Invoice list = failwith "not imlemented yet"
