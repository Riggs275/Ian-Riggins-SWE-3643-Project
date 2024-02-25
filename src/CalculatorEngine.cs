//using System.Runtime.CompilerServices;
namespace CalculatorEngine;
using System;

public class CalculatorEngine {

    public static CalculationResult Add(double inputA, double inputB) {
        //preq-ENGINE-3

        var sum = new CalculationResult();

        sum.IsSuccess = true;
        sum.Operation = (inputA + " + " + inputB + " = ");
        sum.Result = (inputA + inputB);

        return sum;
    }
    
    public static CalculationResult Subtract(double inputA, double inputB) {
        //preq-ENGINE-4

        var difference = new CalculationResult();

        difference.IsSuccess = true;
        difference.Operation = (inputA + " - " + inputB + " = ");
        difference.Result = (inputA - inputB);

        return difference;
    }

    public static CalculationResult Multiplication(double inputA, double inputB) {
        //preq-ENGINE-5

        var product = new CalculationResult();

        product.IsSuccess = true;
        product.Operation = (inputA + " * " + inputB + " = ");
        product.Result = (inputA * inputB);

        return product;
    }
    
    public static CalculationResult Division(double inputA, double inputB) {
        //preq-ENGINE-7

        var quotient = new CalculationResult();
        
        quotient.Operation = (inputA + " / " + inputB + " = ");

        if (inputB == 0) {
            quotient.Error = ("Not a Number!");
            quotient.IsSuccess = false;
        }
        else {
            quotient.IsSuccess = true;
            quotient.Result = (inputA / inputB);
        }
        
        return quotient;
    }

    public static CalculationResult Equals(double inputA, double inputB) {
        //preq-ENGINE-8

        var same = new CalculationResult();
        var percision = Math.Pow(10, -8);

        same.IsSuccess = true;

        if ((inputA - inputB) <= percision) {
            same.Operation = (inputA + " = " + inputB + " =>\nTrue");
            same.Result = 1;
        }
        else {
            same.Operation = (inputA + " = " + inputB + " =>\nFalse");
            same.Result = 0;
        }

        return same;
    }

    public static CalculationResult RaiseToPower(double inputA, double inputB) {
        //preq-ENGINE-9

        var power = new CalculationResult();

        power.IsSuccess = true;
        power.Operation = (inputA + " ^ " + inputB + " = ");
        power.Result = (Math.Pow(inputA, inputB));

        return power;
    }

    public static CalculationResult LogarithmOfNumber(double inputA, double inputB) {
        //preq-ENGINE-10

        var logarithm = new CalculationResult();

        logarithm.Operation = (inputA + " log " + inputB + " = ");

        if ((inputA <= 0 || inputB <= 0)) {
            logarithm.Error = ("Imaginary Number");
            logarithm.IsSuccess = false;
        }
        else {
            logarithm.IsSuccess = true;
            logarithm.Result = (Math.Log(inputA, inputB));
        }

        return logarithm;
    }

    public static CalculationResult RootOfNumber(double inputA, double inputB) {
        //preq-ENGINE-11

        var nRoot = new CalculationResult();

        nRoot.Operation = (inputB + "th root of " + inputA + " = ");

        if (inputB == 0) {
            nRoot.IsSuccess = false;
            nRoot.Error = ("Not a Number");
        }
        else {
            nRoot.IsSuccess = true;
            nRoot.Result = (Math.Pow(inputA, (1 / inputB)));
        }

        return nRoot;
    }

    public static CalculationResult FactorialOfNumber(int inputA) {
        //preq-ENGINE-12

        var factorial = new CalculationResult();

        factorial.Operation = (inputA + "! = ");

        if (inputA < 0) {
            factorial.Error = ("Not a Number");
            factorial.IsSuccess = false;
        }
        else {
            factorial.IsSuccess = true;
            factorial.Result = 1;
            while (inputA != 0) {
                factorial.Result *= inputA;
                inputA--;
            }
        }

        return factorial;
    }

    public static CalculationResult Sine(double inputA) {
        //preq-ENGINE-13

        var sin = new CalculationResult();

        sin.Operation = ("sin(" + inputA + ") = ");
        sin.IsSuccess = true;
        sin.Result = (Math.Sin(inputA));

        return sin;
    }
    
    public static CalculationResult Cosine(double inputA) {
        //preq-ENGINE-14

        var cos = new CalculationResult();

        cos.Operation = ("cos(" + inputA + ") = ");
        cos.IsSuccess = true;
        cos.Result = (Math.Cos(inputA));

        return cos;
    }
    
    public static CalculationResult Tangent(double inputA) {
        //preq-ENGINE-15

        var tan = new CalculationResult();

        tan.Operation = ("tan(" + inputA + ") = ");
        tan.IsSuccess = true;
        tan.Result = (Math.Tan(inputA));

        return tan;
    }

    public static CalculationResult ReciprocalOfNumber(double inputA) {
        //preq-ENGINE-16

        var reciprocal = new CalculationResult();

        reciprocal.Operation = ("1 / " + inputA + " = ");

        if (inputA == 0) {
            reciprocal.Error = ("Not a Number");
            reciprocal.IsSuccess = false;
        }
        else {
            reciprocal.IsSuccess = true;
            reciprocal.Result = (1 / inputA);
        }

        return reciprocal;
    }
}