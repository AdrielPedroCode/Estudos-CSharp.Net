using InterfaceExercise.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace InterfaceExercise.Entities;

internal class Installment {
    public DateTime DueDate { get; set; }
    public double Amount { get; set; }

    public Installment(DateTime duedate,double amount) {
    DueDate = duedate;
    Amount = amount;
    }

    public override string ToString() {
        return DueDate.ToString("dd/MM/yyyy") 
            + " - " + Amount.ToString("F2",CultureInfo.CurrentCulture);
    }



}





