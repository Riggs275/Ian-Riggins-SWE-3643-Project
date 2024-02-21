namespace CalculatorEngine;
using System;

public class CalculatorEngine {

    public CalculationResult CR = new CalculationResult();

    public CalculationResult Add(double InputA, double InputB) {
        //preq-ENGINE-3
    }


    public CalculationResult Subtraction(double InputA, double InputB) {
        //preq-ENGINE-4
    }
    
    public CalculationResult Multiplication(double InputA, double InputB) {
        //preq-ENGINE-5
    }
    
    public CalculationResult Division(double InputA, double InputB) {
        //preq-ENGINE-7

        CR.Operation = (InputA + " / " + InputB + " = ");

        if (InputB == 0) {
            CR.IsSuccess = false;
            CR.Error = ("Not a Number!");
        }
        else {
            CR.IsSuccess = true;
            CR.Result = (InputA / InputB);
        }

        return CR;

    }
    
    public CalculationResult Equals(double InputA, double InputB) {
        //preq-ENGINE-8
    }
    
    public CalculationResult RaiseToPower(double InputA, double InputB) {
        //preq-ENGINE-9
    }
    
    public CalculationResult Logarithm(double InputA, double InputB) {
        //preq-ENGINE-10
    }
    
    public CalculationResult Root(double InputA, double InputB) {
        //preq-ENGINE-11
    }
    
    public CalculationResult Factorial(double InputA) {
        //preq-ENGINE-12

    }
    
    public CalculationResult Sine(double InputA) {
        //preq-ENGINE-13
    }
    
    public CalculationResult Cosine(double InputA) {
        //preq-ENGINE-14
    }
    
    public CalculationResult Tangent(double InputA) {
        //preq-ENGINE-15
    }
    
    public CalculationResult Reciprocal(double InputA) {
        //preq-ENGINE-16
    }
    
}