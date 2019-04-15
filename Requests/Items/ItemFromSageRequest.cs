namespace Clarity.Sage.Items
{
    using System;

    public abstract class ItemFromSageRequest<T> : RecordFromSageRequest<T>
        where T : Item
    {
        private static readonly string _defaultFilter = $"ItemType$=\"{(int)ItemTypes.RegularItem}\"";

        protected ItemFromSageRequest(
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
                filter: !string.IsNullOrEmpty(filter) ? filter : _defaultFilter,
                begin: begin,
                end: end)
        {
        }
    }
}
