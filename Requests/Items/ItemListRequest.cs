namespace crgolden.Sage100.Items
{
    using System;

    public abstract class ItemListRequest<T> : ListRequest<T>
        where T : Item
    {
        protected static readonly string RegularItemsFilter = $"ItemType$=\"1\"";

        protected ItemListRequest(
            DateTime? compareDate,
            string descColumn = Item.DefaultDesc,
            string defaultDescColumn = Record.DefaultDesc,
            string filter = "",
            string begin = "",
            string end = "") : base(
            compareDate: compareDate,
            moduleName: "C/I",
            programName: "CI_ItemCode_ui",
            busObjName: "CI_ItemCode_bus",
            keyColumn: "ItemCode$",
            descColumn: descColumn,
            defaultDescColumn: defaultDescColumn,
            filter: filter,
            begin: begin,
            end: end)
        {
        }
    }
}