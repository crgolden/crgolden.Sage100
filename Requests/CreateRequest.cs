namespace crgolden.Sage100
{
    using MediatR;

    public abstract class CreateRequest<TModel> : IRequest<TModel>
        where TModel : class
    {
        public readonly TModel Model;

        public readonly string ModuleName;

        public readonly string ProgramName;

        public readonly string BusObjName;

        public readonly string Key;

        public readonly string GetKeyName;

        public CreateRequest(TModel model, string moduleName, string programName, string busObjName, string key = null, string getKeyName = null)
        {
            Model = model;
            ModuleName = moduleName;
            ProgramName = programName;
            BusObjName = busObjName;
            Key = key;
            GetKeyName = getKeyName;
        }
    }
}