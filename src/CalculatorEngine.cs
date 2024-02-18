namespace CalculatorEngine;
using System;

public class CalculatorEngine {

    public double Result { get; set;} = 0.0;
    public bool IsSuccess { get; set;}
    public string Operation { get; set;}
    public string Error { get; set;}

    public double Add(double InputA, double InputB) {
        //preq-ENGINE-3
    }


    public double Subtraction(double InputA, double InputB) {
        //preq-ENGINE-4
    }
    
    public double Multiplication(double InputA, double InputB) {
        //preq-ENGINE-5
    }
    
    public double Division(double InputA, double InputB) {
        //preq-ENGINE-7

        Result = (InputA / InputB);
    }
    
    public double Equals(double InputA, double InputB) {
        //preq-ENGINE-8
    }
    
    public double RaiseToPower(double InputA, double InputB) {
        //preq-ENGINE-9
    }
    
    public double Logarithm(double InputA, double InputB) {
        //preq-ENGINE-10
    }
    
    public double Root(double InputA, double InputB) {
        //preq-ENGINE-11
    }
    
    public double Factorial(double InputA) {
        //preq-ENGINE-12
    }
    
    public double Sine(double InputA) {
        //preq-ENGINE-13
    }
    
    public double Cosine(double InputA) {
        //preq-ENGINE-14
    }
    
    public double Tangent(double InputA) {
        //preq-ENGINE-15
    }
    
    public double Reciprocal(double InputA) {
        //preq-ENGINE-16
    }
    
}