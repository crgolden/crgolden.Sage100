namespace Clarity.Sage
{
    using System;
    using System.Reflection;
    using System.Runtime.InteropServices;

    // https://sagecity.na.sage.com/support_communities/sage100_erp/f/sage-100-business-object-interface/41828/help-sample-code-c
    public class SageBoiService : IDisposable
    {
        protected readonly Type Type;

        protected object Instance;

        private readonly BindingFlags _method = BindingFlags.Public | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.InvokeMethod;

        private readonly BindingFlags _getProperty = BindingFlags.Public | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.GetProperty;

        private readonly BindingFlags _setProperty = BindingFlags.Public | BindingFlags.Static | BindingFlags.IgnoreCase | BindingFlags.SetProperty;

        protected SageBoiService()
        {
        }

        public SageBoiService(string programID)
        {
            Type = Type.GetTypeFromProgID(programID, true);
            Instance = Activator.CreateInstance(Type);
        }

        public SageBoiService(string programID, string server)
        {
            Type = Type.GetTypeFromProgID(programID, server, true);
            Instance = Activator.CreateInstance(Type);
        }

        public SageBoiService(Guid classID)
        {
            Type = Type.GetTypeFromCLSID(classID, true);
            Instance = Activator.CreateInstance(Type);
        }

        public SageBoiService(Guid classID, string server)
        {
            Type = Type.GetTypeFromCLSID(classID, server, true);
            Instance = Activator.CreateInstance(Type);
        }

        public SageBoiService(object @object)
        {
            var typeHandle = Type.GetTypeHandle(@object);
            Type = Type.GetTypeFromHandle(typeHandle);
            Instance = @object;
        }

        ~SageBoiService()
        {
            Dispose();
        }

        public object InvokeMethodByRef(string name, object[] args)
        {
            var modifiers = new [] { GetParameterModifier(args.Length, true) };
            return Type.InvokeMember(name, _method, null, Instance, args, modifiers, null, null);
        }

        public object InvokeMethod(string name, params object[] args)
        {
            return Type.InvokeMember(name, _method, null, Instance, args);
        }

        public object InvokeMethod(string name, object[] args, ParameterModifier[] modifiers)
        {
            return Type.InvokeMember(name, _method, null, Instance, args, modifiers, null, null);
        }

        public object GetProperty(string name)
        {
            return Type.InvokeMember(name, _getProperty, null, Instance, null);
        }

        public object SetProperty(string name, object value)
        {
            return Type.InvokeMember(name, _setProperty, null, Instance, new[] { value });
        }

        public object GetObject()
        {
            return Instance;
        }

        public virtual void Dispose()
        {
            if (Instance == null) return;
            Marshal.ReleaseComObject(Instance);
            Instance = null;
            GC.SuppressFinalize(this);
        }

        public static ParameterModifier GetParameterModifier(int parameterCount, bool initialValue)
        {
            var mod = new ParameterModifier(parameterCount);
            for (var x = 0; x < parameterCount; x++) mod[x] = initialValue;
            return mod;
        }
    }
}
