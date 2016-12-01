#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998
[assembly: global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0")]
[assembly: global::Orleans.CodeGeneration.OrleansCodeGenerationTargetAttribute("Ceiba.OrleansStart.Comms, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
namespace Ceiba.OrleansStart.Comms
{
    using global::Orleans.Async;
    using global::Orleans;
    using global::System.Reflection;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Ceiba.OrleansStart.Comms.ICompanyLookupGrain))]
    internal class OrleansCodeGenCompanyLookupGrainReference : global::Orleans.Runtime.GrainReference, global::Ceiba.OrleansStart.Comms.ICompanyLookupGrain
    {
        protected @OrleansCodeGenCompanyLookupGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenCompanyLookupGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -1147265987;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Ceiba.OrleansStart.Comms.ICompanyLookupGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -1147265987;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -1147265987:
                    switch (@methodId)
                    {
                        case -335449724:
                            return "LookupCompany";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1147265987 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<global::Ceiba.OrleansStart.Comms.Company>> @LookupCompany(global::System.String @name)
        {
            return base.@InvokeMethodAsync<global::System.Collections.Generic.IEnumerable<global::Ceiba.OrleansStart.Comms.Company>>(-335449724, new global::System.Object[]{@name});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Ceiba.OrleansStart.Comms.ICompanyLookupGrain", -1147265987, typeof (global::Ceiba.OrleansStart.Comms.ICompanyLookupGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenCompanyLookupGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -1147265987:
                        switch (methodId)
                        {
                            case -335449724:
                                return ((global::Ceiba.OrleansStart.Comms.ICompanyLookupGrain)@grain).@LookupCompany((global::System.String)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1147265987 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -1147265987;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Ceiba.OrleansStart.Comms.Stock)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenCeiba_OrleansStart_Comms_StockSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Ceiba.OrleansStart.Comms.Stock input = ((global::Ceiba.OrleansStart.Comms.Stock)original);
            global::Ceiba.OrleansStart.Comms.Stock result = new global::Ceiba.OrleansStart.Comms.Stock();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            result.@Provider = input.@Provider;
            result.@Quota = (global::Ceiba.OrleansStart.Comms.StockQuota)global::Orleans.Serialization.SerializationManager.@DeepCopyInner(input.@Quota);
            result.@Symbol = input.@Symbol;
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Ceiba.OrleansStart.Comms.Stock input = (global::Ceiba.OrleansStart.Comms.Stock)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Provider, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Quota, stream, typeof (global::Ceiba.OrleansStart.Comms.StockQuota));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Symbol, stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Ceiba.OrleansStart.Comms.Stock result = new global::Ceiba.OrleansStart.Comms.Stock();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Provider = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Quota = (global::Ceiba.OrleansStart.Comms.StockQuota)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::Ceiba.OrleansStart.Comms.StockQuota), stream);
            result.@Symbol = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            return (global::Ceiba.OrleansStart.Comms.Stock)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Ceiba.OrleansStart.Comms.Stock), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenCeiba_OrleansStart_Comms_StockSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Ceiba.OrleansStart.Comms.StockQuota)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenCeiba_OrleansStart_Comms_StockQuotaSerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Ceiba.OrleansStart.Comms.StockQuota input = ((global::Ceiba.OrleansStart.Comms.StockQuota)original);
            global::Ceiba.OrleansStart.Comms.StockQuota result = new global::Ceiba.OrleansStart.Comms.StockQuota();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            result.@Change = input.@Change;
            result.@Company = input.@Company;
            result.@Exchange = input.@Exchange;
            result.@Price = input.@Price;
            result.@Symbol = input.@Symbol;
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Ceiba.OrleansStart.Comms.StockQuota input = (global::Ceiba.OrleansStart.Comms.StockQuota)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Change, stream, typeof (global::System.Decimal));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Company, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Exchange, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Price, stream, typeof (global::System.Decimal));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Symbol, stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Ceiba.OrleansStart.Comms.StockQuota result = new global::Ceiba.OrleansStart.Comms.StockQuota();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Change = (global::System.Decimal)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Decimal), stream);
            result.@Company = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Exchange = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Price = (global::System.Decimal)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Decimal), stream);
            result.@Symbol = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            return (global::Ceiba.OrleansStart.Comms.StockQuota)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Ceiba.OrleansStart.Comms.StockQuota), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenCeiba_OrleansStart_Comms_StockQuotaSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Ceiba.OrleansStart.Comms.Company)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenCeiba_OrleansStart_Comms_CompanySerializer
    {
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            global::Ceiba.OrleansStart.Comms.Company input = ((global::Ceiba.OrleansStart.Comms.Company)original);
            global::Ceiba.OrleansStart.Comms.Company result = new global::Ceiba.OrleansStart.Comms.Company();
            global::Orleans.@Serialization.@SerializationContext.@Current.@RecordObject(original, result);
            result.@Name = input.@Name;
            result.@Symbol = input.@Symbol;
            return result;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Ceiba.OrleansStart.Comms.Company input = (global::Ceiba.OrleansStart.Comms.Company)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Name, stream, typeof (global::System.String));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Symbol, stream, typeof (global::System.String));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Ceiba.OrleansStart.Comms.Company result = new global::Ceiba.OrleansStart.Comms.Company();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            result.@Name = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            result.@Symbol = (global::System.String)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.String), stream);
            return (global::Ceiba.OrleansStart.Comms.Company)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Ceiba.OrleansStart.Comms.Company), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenCeiba_OrleansStart_Comms_CompanySerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Ceiba.OrleansStart.Comms.IStockGrain))]
    internal class OrleansCodeGenStockGrainReference : global::Orleans.Runtime.GrainReference, global::Ceiba.OrleansStart.Comms.IStockGrain
    {
        protected @OrleansCodeGenStockGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenStockGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1244368052;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Ceiba.OrleansStart.Comms.IStockGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1244368052 || @interfaceId == -1277021679;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1244368052:
                    switch (@methodId)
                    {
                        case 511554609:
                            return "GetQuotaAsync";
                        case 1571021319:
                            return "UpdateStockAsync";
                        case 262562692:
                            return "SubscribeForUpdates";
                        case -1267655965:
                            return "UnsubscribeForUpdates";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1244368052 + ",methodId=" + @methodId);
                    }

                case -1277021679:
                    switch (@methodId)
                    {
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task<global::Ceiba.OrleansStart.Comms.StockQuota> @GetQuotaAsync(global::Ceiba.OrleansStart.Comms.Stock @stock)
        {
            return base.@InvokeMethodAsync<global::Ceiba.OrleansStart.Comms.StockQuota>(511554609, new global::System.Object[]{@stock});
        }

        public global::System.Threading.Tasks.Task @UpdateStockAsync(global::Ceiba.OrleansStart.Comms.StockRequest @request)
        {
            return base.@InvokeMethodAsync<global::System.Object>(1571021319, new global::System.Object[]{@request});
        }

        public global::System.Threading.Tasks.Task @SubscribeForUpdates(global::Ceiba.OrleansStart.Comms.IStockObserver @subscriber)
        {
            global::Orleans.CodeGeneration.GrainFactoryBase.@CheckGrainObserverParamInternal(@subscriber);
            return base.@InvokeMethodAsync<global::System.Object>(262562692, new global::System.Object[]{@subscriber is global::Orleans.Grain ? @subscriber.@AsReference<global::Ceiba.OrleansStart.Comms.IStockObserver>() : @subscriber});
        }

        public global::System.Threading.Tasks.Task @UnsubscribeForUpdates(global::Ceiba.OrleansStart.Comms.IStockObserver @subscriber)
        {
            global::Orleans.CodeGeneration.GrainFactoryBase.@CheckGrainObserverParamInternal(@subscriber);
            return base.@InvokeMethodAsync<global::System.Object>(-1267655965, new global::System.Object[]{@subscriber is global::Orleans.Grain ? @subscriber.@AsReference<global::Ceiba.OrleansStart.Comms.IStockObserver>() : @subscriber});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Ceiba.OrleansStart.Comms.IStockGrain", 1244368052, typeof (global::Ceiba.OrleansStart.Comms.IStockGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenStockGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1244368052:
                        switch (methodId)
                        {
                            case 511554609:
                                return ((global::Ceiba.OrleansStart.Comms.IStockGrain)@grain).@GetQuotaAsync((global::Ceiba.OrleansStart.Comms.Stock)arguments[0]).@Box();
                            case 1571021319:
                                return ((global::Ceiba.OrleansStart.Comms.IStockGrain)@grain).@UpdateStockAsync((global::Ceiba.OrleansStart.Comms.StockRequest)arguments[0]).@Box();
                            case 262562692:
                                return ((global::Ceiba.OrleansStart.Comms.IStockGrain)@grain).@SubscribeForUpdates((global::Ceiba.OrleansStart.Comms.IStockObserver)arguments[0]).@Box();
                            case -1267655965:
                                return ((global::Ceiba.OrleansStart.Comms.IStockGrain)@grain).@UnsubscribeForUpdates((global::Ceiba.OrleansStart.Comms.IStockObserver)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1244368052 + ",methodId=" + methodId);
                        }

                    case -1277021679:
                        switch (methodId)
                        {
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -1277021679 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1244368052;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.SerializerAttribute(typeof (global::Ceiba.OrleansStart.Comms.StockRequest)), global::Orleans.CodeGeneration.RegisterSerializerAttribute]
    internal class OrleansCodeGenCeiba_OrleansStart_Comms_StockRequestSerializer
    {
        private static readonly global::System.Reflection.FieldInfo field1 = typeof (global::Ceiba.OrleansStart.Comms.StockRequest).@GetTypeInfo().@GetField("<Stocks>k__BackingField", (System.@Reflection.@BindingFlags.@Instance | System.@Reflection.@BindingFlags.@NonPublic | System.@Reflection.@BindingFlags.@Public));
        private static readonly global::System.Action<global::Ceiba.OrleansStart.Comms.StockRequest, global::System.Collections.Generic.HashSet<global::Ceiba.OrleansStart.Comms.Stock>> setField1 = (global::System.Action<global::Ceiba.OrleansStart.Comms.StockRequest, global::System.Collections.Generic.HashSet<global::Ceiba.OrleansStart.Comms.Stock>>)global::Orleans.Serialization.SerializationManager.@GetReferenceSetter(field1);
        [global::Orleans.CodeGeneration.CopierMethodAttribute]
        public static global::System.Object DeepCopier(global::System.Object original)
        {
            return original;
        }

        [global::Orleans.CodeGeneration.SerializerMethodAttribute]
        public static void Serializer(global::System.Object untypedInput, global::Orleans.Serialization.BinaryTokenStreamWriter stream, global::System.Type expected)
        {
            global::Ceiba.OrleansStart.Comms.StockRequest input = (global::Ceiba.OrleansStart.Comms.StockRequest)untypedInput;
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@Stocks, stream, typeof (global::System.Collections.Generic.HashSet<global::Ceiba.OrleansStart.Comms.Stock>));
            global::Orleans.Serialization.SerializationManager.@SerializeInner(input.@TraderId, stream, typeof (global::System.Guid));
        }

        [global::Orleans.CodeGeneration.DeserializerMethodAttribute]
        public static global::System.Object Deserializer(global::System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            global::Ceiba.OrleansStart.Comms.StockRequest result = new global::Ceiba.OrleansStart.Comms.StockRequest();
            global::Orleans.@Serialization.@DeserializationContext.@Current.@RecordObject(result);
            setField1(result, (global::System.Collections.Generic.HashSet<global::Ceiba.OrleansStart.Comms.Stock>)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Collections.Generic.HashSet<global::Ceiba.OrleansStart.Comms.Stock>), stream));
            result.@TraderId = (global::System.Guid)global::Orleans.Serialization.SerializationManager.@DeserializeInner(typeof (global::System.Guid), stream);
            return (global::Ceiba.OrleansStart.Comms.StockRequest)result;
        }

        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.@Register(typeof (global::Ceiba.OrleansStart.Comms.StockRequest), DeepCopier, Serializer, Deserializer);
        }

        static OrleansCodeGenCeiba_OrleansStart_Comms_StockRequestSerializer()
        {
            Register();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Ceiba.OrleansStart.Comms.IStockObserver))]
    internal class OrleansCodeGenStockObserverReference : global::Orleans.Runtime.GrainReference, global::Ceiba.OrleansStart.Comms.IStockObserver
    {
        protected @OrleansCodeGenStockObserverReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenStockObserverReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return -2164450;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Ceiba.OrleansStart.Comms.IStockObserver";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == -2164450;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case -2164450:
                    switch (@methodId)
                    {
                        case 1956075889:
                            return "UpdateStocks";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + -2164450 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public void @UpdateStocks(global::System.Collections.Generic.IEnumerable<global::Ceiba.OrleansStart.Comms.Stock> @stocks)
        {
            base.@InvokeOneWayMethod(1956075889, new global::System.Object[]{@stocks});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Ceiba.OrleansStart.Comms.IStockObserver", -2164450, typeof (global::Ceiba.OrleansStart.Comms.IStockObserver)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenStockObserverMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case -2164450:
                        switch (methodId)
                        {
                            case 1956075889:
                                ((global::Ceiba.OrleansStart.Comms.IStockObserver)@grain).@UpdateStocks((global::System.Collections.Generic.IEnumerable<global::Ceiba.OrleansStart.Comms.Stock>)arguments[0]);
                                return global::Orleans.Async.TaskUtility.@Completed();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + -2164450 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return -2164450;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::System.SerializableAttribute, global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute, global::Orleans.CodeGeneration.GrainReferenceAttribute(typeof (global::Ceiba.OrleansStart.Comms.ITraderGrain))]
    internal class OrleansCodeGenTraderGrainReference : global::Orleans.Runtime.GrainReference, global::Ceiba.OrleansStart.Comms.ITraderGrain
    {
        protected @OrleansCodeGenTraderGrainReference(global::Orleans.Runtime.GrainReference @other): base (@other)
        {
        }

        protected @OrleansCodeGenTraderGrainReference(global::System.Runtime.Serialization.SerializationInfo @info, global::System.Runtime.Serialization.StreamingContext @context): base (@info, @context)
        {
        }

        protected override global::System.Int32 InterfaceId
        {
            get
            {
                return 1892483569;
            }
        }

        public override global::System.String InterfaceName
        {
            get
            {
                return "global::Ceiba.OrleansStart.Comms.ITraderGrain";
            }
        }

        public override global::System.Boolean @IsCompatible(global::System.Int32 @interfaceId)
        {
            return @interfaceId == 1892483569;
        }

        protected override global::System.String @GetMethodName(global::System.Int32 @interfaceId, global::System.Int32 @methodId)
        {
            switch (@interfaceId)
            {
                case 1892483569:
                    switch (@methodId)
                    {
                        case -1351730175:
                            return "FollowStockAsync";
                        case 511554609:
                            return "GetQuotaAsync";
                        default:
                            throw new global::System.NotImplementedException("interfaceId=" + 1892483569 + ",methodId=" + @methodId);
                    }

                default:
                    throw new global::System.NotImplementedException("interfaceId=" + @interfaceId);
            }
        }

        public global::System.Threading.Tasks.Task @FollowStockAsync(global::Ceiba.OrleansStart.Comms.IStockGrain @stock)
        {
            return base.@InvokeMethodAsync<global::System.Object>(-1351730175, new global::System.Object[]{@stock is global::Orleans.Grain ? @stock.@AsReference<global::Ceiba.OrleansStart.Comms.IStockGrain>() : @stock});
        }

        public global::System.Threading.Tasks.Task<global::Ceiba.OrleansStart.Comms.StockQuota> @GetQuotaAsync(global::Ceiba.OrleansStart.Comms.Stock @stock)
        {
            return base.@InvokeMethodAsync<global::Ceiba.OrleansStart.Comms.StockQuota>(511554609, new global::System.Object[]{@stock});
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.3.0.0"), global::Orleans.CodeGeneration.MethodInvokerAttribute("global::Ceiba.OrleansStart.Comms.ITraderGrain", 1892483569, typeof (global::Ceiba.OrleansStart.Comms.ITraderGrain)), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal class OrleansCodeGenTraderGrainMethodInvoker : global::Orleans.CodeGeneration.IGrainMethodInvoker
    {
        public global::System.Threading.Tasks.Task<global::System.Object> @Invoke(global::Orleans.Runtime.IAddressable @grain, global::Orleans.CodeGeneration.InvokeMethodRequest @request)
        {
            global::System.Int32 interfaceId = @request.@InterfaceId;
            global::System.Int32 methodId = @request.@MethodId;
            global::System.Object[] arguments = @request.@Arguments;
            try
            {
                if (@grain == null)
                    throw new global::System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 1892483569:
                        switch (methodId)
                        {
                            case -1351730175:
                                return ((global::Ceiba.OrleansStart.Comms.ITraderGrain)@grain).@FollowStockAsync((global::Ceiba.OrleansStart.Comms.IStockGrain)arguments[0]).@Box();
                            case 511554609:
                                return ((global::Ceiba.OrleansStart.Comms.ITraderGrain)@grain).@GetQuotaAsync((global::Ceiba.OrleansStart.Comms.Stock)arguments[0]).@Box();
                            default:
                                throw new global::System.NotImplementedException("interfaceId=" + 1892483569 + ",methodId=" + methodId);
                        }

                    default:
                        throw new global::System.NotImplementedException("interfaceId=" + interfaceId);
                }
            }
            catch (global::System.Exception exception)
            {
                return global::Orleans.Async.TaskUtility.@Faulted(exception);
            }
        }

        public global::System.Int32 InterfaceId
        {
            get
            {
                return 1892483569;
            }
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
