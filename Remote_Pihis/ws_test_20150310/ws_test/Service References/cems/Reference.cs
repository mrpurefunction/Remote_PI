﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ws_test.cems {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="cems.cemsSoap")]
    public interface cemsSoap {
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 HelloWorldResult 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ws_test.cems.HelloWorldResponse HelloWorld(ws_test.cems.HelloWorldRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 pn 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddPiRecord", ReplyAction="*")]
        ws_test.cems.AddPiRecordResponse AddPiRecord(ws_test.cems.AddPiRecordRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 pn 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddRuleLogRd", ReplyAction="*")]
        ws_test.cems.AddRuleLogRdResponse AddRuleLogRd(ws_test.cems.AddRuleLogRdRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 pn 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdatePiRecord", ReplyAction="*")]
        ws_test.cems.UpdatePiRecordResponse UpdatePiRecord(ws_test.cems.UpdatePiRecordRequest request);
        
        // CODEGEN: 命名空间 http://tempuri.org/ 的元素名称 pn 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateRuleLogRd", ReplyAction="*")]
        ws_test.cems.UpdateRuleLogRdResponse UpdateRuleLogRd(ws_test.cems.UpdateRuleLogRdRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ws_test.cems.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ws_test.cems.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public ws_test.cems.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ws_test.cems.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddPiRecordRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddPiRecord", Namespace="http://tempuri.org/", Order=0)]
        public ws_test.cems.AddPiRecordRequestBody Body;
        
        public AddPiRecordRequest() {
        }
        
        public AddPiRecordRequest(ws_test.cems.AddPiRecordRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddPiRecordRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public System.DateTime ts;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string pn;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public float pv;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int mi;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int pi;
        
        public AddPiRecordRequestBody() {
        }
        
        public AddPiRecordRequestBody(System.DateTime ts, string pn, float pv, int mi, int pi) {
            this.ts = ts;
            this.pn = pn;
            this.pv = pv;
            this.mi = mi;
            this.pi = pi;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddPiRecordResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddPiRecordResponse", Namespace="http://tempuri.org/", Order=0)]
        public ws_test.cems.AddPiRecordResponseBody Body;
        
        public AddPiRecordResponse() {
        }
        
        public AddPiRecordResponse(ws_test.cems.AddPiRecordResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddPiRecordResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int AddPiRecordResult;
        
        public AddPiRecordResponseBody() {
        }
        
        public AddPiRecordResponseBody(int AddPiRecordResult) {
            this.AddPiRecordResult = AddPiRecordResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddRuleLogRdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddRuleLogRd", Namespace="http://tempuri.org/", Order=0)]
        public ws_test.cems.AddRuleLogRdRequestBody Body;
        
        public AddRuleLogRdRequest() {
        }
        
        public AddRuleLogRdRequest(ws_test.cems.AddRuleLogRdRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddRuleLogRdRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public System.DateTime ts;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string pn;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string rn;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string rt;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string rd;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int mi;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public int pi;
        
        public AddRuleLogRdRequestBody() {
        }
        
        public AddRuleLogRdRequestBody(System.DateTime ts, string pn, string rn, string rt, string rd, int mi, int pi) {
            this.ts = ts;
            this.pn = pn;
            this.rn = rn;
            this.rt = rt;
            this.rd = rd;
            this.mi = mi;
            this.pi = pi;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddRuleLogRdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddRuleLogRdResponse", Namespace="http://tempuri.org/", Order=0)]
        public ws_test.cems.AddRuleLogRdResponseBody Body;
        
        public AddRuleLogRdResponse() {
        }
        
        public AddRuleLogRdResponse(ws_test.cems.AddRuleLogRdResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddRuleLogRdResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int AddRuleLogRdResult;
        
        public AddRuleLogRdResponseBody() {
        }
        
        public AddRuleLogRdResponseBody(int AddRuleLogRdResult) {
            this.AddRuleLogRdResult = AddRuleLogRdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdatePiRecordRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdatePiRecord", Namespace="http://tempuri.org/", Order=0)]
        public ws_test.cems.UpdatePiRecordRequestBody Body;
        
        public UpdatePiRecordRequest() {
        }
        
        public UpdatePiRecordRequest(ws_test.cems.UpdatePiRecordRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdatePiRecordRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public System.DateTime ts;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string pn;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public float pv;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int mi;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int pi;
        
        public UpdatePiRecordRequestBody() {
        }
        
        public UpdatePiRecordRequestBody(System.DateTime ts, string pn, float pv, int mi, int pi) {
            this.ts = ts;
            this.pn = pn;
            this.pv = pv;
            this.mi = mi;
            this.pi = pi;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdatePiRecordResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdatePiRecordResponse", Namespace="http://tempuri.org/", Order=0)]
        public ws_test.cems.UpdatePiRecordResponseBody Body;
        
        public UpdatePiRecordResponse() {
        }
        
        public UpdatePiRecordResponse(ws_test.cems.UpdatePiRecordResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdatePiRecordResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int UpdatePiRecordResult;
        
        public UpdatePiRecordResponseBody() {
        }
        
        public UpdatePiRecordResponseBody(int UpdatePiRecordResult) {
            this.UpdatePiRecordResult = UpdatePiRecordResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateRuleLogRdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateRuleLogRd", Namespace="http://tempuri.org/", Order=0)]
        public ws_test.cems.UpdateRuleLogRdRequestBody Body;
        
        public UpdateRuleLogRdRequest() {
        }
        
        public UpdateRuleLogRdRequest(ws_test.cems.UpdateRuleLogRdRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateRuleLogRdRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public System.DateTime ts;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string pn;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string rn;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string rt;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string rd;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int mi;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=6)]
        public int pi;
        
        public UpdateRuleLogRdRequestBody() {
        }
        
        public UpdateRuleLogRdRequestBody(System.DateTime ts, string pn, string rn, string rt, string rd, int mi, int pi) {
            this.ts = ts;
            this.pn = pn;
            this.rn = rn;
            this.rt = rt;
            this.rd = rd;
            this.mi = mi;
            this.pi = pi;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateRuleLogRdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateRuleLogRdResponse", Namespace="http://tempuri.org/", Order=0)]
        public ws_test.cems.UpdateRuleLogRdResponseBody Body;
        
        public UpdateRuleLogRdResponse() {
        }
        
        public UpdateRuleLogRdResponse(ws_test.cems.UpdateRuleLogRdResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateRuleLogRdResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int UpdateRuleLogRdResult;
        
        public UpdateRuleLogRdResponseBody() {
        }
        
        public UpdateRuleLogRdResponseBody(int UpdateRuleLogRdResult) {
            this.UpdateRuleLogRdResult = UpdateRuleLogRdResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface cemsSoapChannel : ws_test.cems.cemsSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class cemsSoapClient : System.ServiceModel.ClientBase<ws_test.cems.cemsSoap>, ws_test.cems.cemsSoap {
        
        public cemsSoapClient() {
        }
        
        public cemsSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public cemsSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public cemsSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public cemsSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ws_test.cems.HelloWorldResponse ws_test.cems.cemsSoap.HelloWorld(ws_test.cems.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ws_test.cems.HelloWorldRequest inValue = new ws_test.cems.HelloWorldRequest();
            inValue.Body = new ws_test.cems.HelloWorldRequestBody();
            ws_test.cems.HelloWorldResponse retVal = ((ws_test.cems.cemsSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ws_test.cems.AddPiRecordResponse ws_test.cems.cemsSoap.AddPiRecord(ws_test.cems.AddPiRecordRequest request) {
            return base.Channel.AddPiRecord(request);
        }
        
        public int AddPiRecord(System.DateTime ts, string pn, float pv, int mi, int pi) {
            ws_test.cems.AddPiRecordRequest inValue = new ws_test.cems.AddPiRecordRequest();
            inValue.Body = new ws_test.cems.AddPiRecordRequestBody();
            inValue.Body.ts = ts;
            inValue.Body.pn = pn;
            inValue.Body.pv = pv;
            inValue.Body.mi = mi;
            inValue.Body.pi = pi;
            ws_test.cems.AddPiRecordResponse retVal = ((ws_test.cems.cemsSoap)(this)).AddPiRecord(inValue);
            return retVal.Body.AddPiRecordResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ws_test.cems.AddRuleLogRdResponse ws_test.cems.cemsSoap.AddRuleLogRd(ws_test.cems.AddRuleLogRdRequest request) {
            return base.Channel.AddRuleLogRd(request);
        }
        
        public int AddRuleLogRd(System.DateTime ts, string pn, string rn, string rt, string rd, int mi, int pi) {
            ws_test.cems.AddRuleLogRdRequest inValue = new ws_test.cems.AddRuleLogRdRequest();
            inValue.Body = new ws_test.cems.AddRuleLogRdRequestBody();
            inValue.Body.ts = ts;
            inValue.Body.pn = pn;
            inValue.Body.rn = rn;
            inValue.Body.rt = rt;
            inValue.Body.rd = rd;
            inValue.Body.mi = mi;
            inValue.Body.pi = pi;
            ws_test.cems.AddRuleLogRdResponse retVal = ((ws_test.cems.cemsSoap)(this)).AddRuleLogRd(inValue);
            return retVal.Body.AddRuleLogRdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ws_test.cems.UpdatePiRecordResponse ws_test.cems.cemsSoap.UpdatePiRecord(ws_test.cems.UpdatePiRecordRequest request) {
            return base.Channel.UpdatePiRecord(request);
        }
        
        public int UpdatePiRecord(System.DateTime ts, string pn, float pv, int mi, int pi) {
            ws_test.cems.UpdatePiRecordRequest inValue = new ws_test.cems.UpdatePiRecordRequest();
            inValue.Body = new ws_test.cems.UpdatePiRecordRequestBody();
            inValue.Body.ts = ts;
            inValue.Body.pn = pn;
            inValue.Body.pv = pv;
            inValue.Body.mi = mi;
            inValue.Body.pi = pi;
            ws_test.cems.UpdatePiRecordResponse retVal = ((ws_test.cems.cemsSoap)(this)).UpdatePiRecord(inValue);
            return retVal.Body.UpdatePiRecordResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ws_test.cems.UpdateRuleLogRdResponse ws_test.cems.cemsSoap.UpdateRuleLogRd(ws_test.cems.UpdateRuleLogRdRequest request) {
            return base.Channel.UpdateRuleLogRd(request);
        }
        
        public int UpdateRuleLogRd(System.DateTime ts, string pn, string rn, string rt, string rd, int mi, int pi) {
            ws_test.cems.UpdateRuleLogRdRequest inValue = new ws_test.cems.UpdateRuleLogRdRequest();
            inValue.Body = new ws_test.cems.UpdateRuleLogRdRequestBody();
            inValue.Body.ts = ts;
            inValue.Body.pn = pn;
            inValue.Body.rn = rn;
            inValue.Body.rt = rt;
            inValue.Body.rd = rd;
            inValue.Body.mi = mi;
            inValue.Body.pi = pi;
            ws_test.cems.UpdateRuleLogRdResponse retVal = ((ws_test.cems.cemsSoap)(this)).UpdateRuleLogRd(inValue);
            return retVal.Body.UpdateRuleLogRdResult;
        }
    }
}
