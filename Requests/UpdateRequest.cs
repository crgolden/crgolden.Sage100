namespace crgolden.Sage100
{
    using MediatR;

    public abstract class UpdateRequest<TModel> : IRequest
        where TModel : class
    {
        public readonly TModel Model;

        public readonly string Key;

        public readonly string ModuleName;

        public readonly string ProgramName;

        public readonly string BusObjName;

        public UpdateRequest(TModel model, string key, string moduleName, string programName, string busObjName)
        {
            Model = model;
            Key = key;
            ModuleName = moduleName;
            ProgramName = programName;
            BusObjName = busObjName;
        }
    }
}