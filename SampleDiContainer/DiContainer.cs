using System;
using System.Collections.Generic;
using System.Reflection;

namespace SampleDiContainer
{
    public class DIContainer
    {
        private Dictionary<Type, Type> _types = new Dictionary<Type, Type>();

        private object GetImplementation(Type type)
        {
            if (!_types.ContainsKey(type))
                throw new Exception("Type Does Not exists");

            Type implementation = _types.GetValueOrDefault(type);
            ConstructorInfo constructorInfo = implementation.GetConstructors()[0];
            var constructorParamTypes = constructorInfo.GetParameters();
            List<object> constructorParamImplementations = new List<object>();
            foreach (var param in constructorParamTypes)
            {
                constructorParamImplementations.Add(this.GetImplementation(param.ParameterType));
            }
            return constructorInfo.Invoke(constructorParamImplementations.ToArray());

        }

        public void Register<TInterface, TType>()
        {
            if (_types.ContainsKey(typeof(TInterface)))
                throw new Exception("Type Alread Register");
            _types.Add(typeof(TInterface), typeof(TType));
        }

        public TInterface Resolve<TInterface>()
        {
            return (TInterface)this.GetImplementation(typeof(TInterface));
        }
    }
}