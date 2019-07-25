namespace crgolden.Sage100.Items
{
    public abstract class ItemCreateRequest<T> : CreateRequest<T>
        where T : class
    {
        protected ItemCreateRequest(
            T model,
            string key = null) : base(
            model: model,
            moduleName: "C/I",
            programName: "CI_ItemCode_ui",
            busObjName: "CI_ItemCode_bus",
            key: key)
        {
        }
    }
}