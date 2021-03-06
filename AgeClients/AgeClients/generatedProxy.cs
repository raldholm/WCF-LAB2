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
[System.ServiceModel.ServiceContractAttribute(Namespace="http://AgeService", ConfigurationName="IAgeCalculatorService")]
public interface IAgeCalculatorService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://AgeService/IAgeCalculatorService/CalculateAgedays", ReplyAction="http://AgeService/IAgeCalculatorService/CalculateAgedaysResponse")]
    double CalculateAgedays(System.DateTime date);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://AgeService/IAgeCalculatorService/CalculateAgedays", ReplyAction="http://AgeService/IAgeCalculatorService/CalculateAgedaysResponse")]
    System.Threading.Tasks.Task<double> CalculateAgedaysAsync(System.DateTime date);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://AgeService/IAgeCalculatorService/CalculateEvenBirthday", ReplyAction="http://AgeService/IAgeCalculatorService/CalculateEvenBirthdayResponse")]
    string CalculateEvenBirthday(System.DateTime date);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://AgeService/IAgeCalculatorService/CalculateEvenBirthday", ReplyAction="http://AgeService/IAgeCalculatorService/CalculateEvenBirthdayResponse")]
    System.Threading.Tasks.Task<string> CalculateEvenBirthdayAsync(System.DateTime date);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IAgeCalculatorServiceChannel : IAgeCalculatorService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class AgeCalculatorServiceClient : System.ServiceModel.ClientBase<IAgeCalculatorService>, IAgeCalculatorService
{
    
    public AgeCalculatorServiceClient()
    {
    }
    
    public AgeCalculatorServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public AgeCalculatorServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public AgeCalculatorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public AgeCalculatorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public double CalculateAgedays(System.DateTime date)
    {
        return base.Channel.CalculateAgedays(date);
    }
    
    public System.Threading.Tasks.Task<double> CalculateAgedaysAsync(System.DateTime date)
    {
        return base.Channel.CalculateAgedaysAsync(date);
    }
    
    public string CalculateEvenBirthday(System.DateTime date)
    {
        return base.Channel.CalculateEvenBirthday(date);
    }
    
    public System.Threading.Tasks.Task<string> CalculateEvenBirthdayAsync(System.DateTime date)
    {
        return base.Channel.CalculateEvenBirthdayAsync(date);
    }
}
