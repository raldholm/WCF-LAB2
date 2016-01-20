﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Denna kod har genererats av ett verktyg.
//     Körtidsversion:4.0.30319.42000
//
//     Ändringar i denna fil kan orsaka fel och kommer att förloras om
//     koden återgenereras.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://BMIService", ConfigurationName="IBmiCalculatorService")]
public interface IBmiCalculatorService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://BMIService/IBmiCalculatorService/CalculateBmi", ReplyAction="http://BMIService/IBmiCalculatorService/CalculateBmiResponse")]
    double CalculateBmi(double weight, double length);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://BMIService/IBmiCalculatorService/CalculateBmi", ReplyAction="http://BMIService/IBmiCalculatorService/CalculateBmiResponse")]
    System.Threading.Tasks.Task<double> CalculateBmiAsync(double weight, double length);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IBmiCalculatorServiceChannel : IBmiCalculatorService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class BmiCalculatorServiceClient : System.ServiceModel.ClientBase<IBmiCalculatorService>, IBmiCalculatorService
{
    
    public BmiCalculatorServiceClient()
    {
    }
    
    public BmiCalculatorServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public BmiCalculatorServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public BmiCalculatorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public BmiCalculatorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public double CalculateBmi(double weight, double length)
    {
        return base.Channel.CalculateBmi(weight, length);
    }
    
    public System.Threading.Tasks.Task<double> CalculateBmiAsync(double weight, double length)
    {
        return base.Channel.CalculateBmiAsync(weight, length);
    }
}