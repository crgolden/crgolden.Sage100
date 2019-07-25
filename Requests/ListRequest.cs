namespace crgolden.Sage100
{
    using System;
    using System.Collections.Generic;
    using MediatR;

    public abstract class ListRequest<TModel> : IRequest<TModel[]>
        where TModel : class
    {
        public readonly DateTime? CompareDate;

        public readonly string ModuleName;

        public readonly string ProgramName;

        public readonly string BusObjName;

        public readonly string KeyColumn;

        public readonly string DescColumn;

        public readonly string DefaultDescColumn;

        public readonly string Filter;

        public readonly string Begin;

        public readonly string End;

        public readonly string KeyValue;

        public virtual Func<
            IEnumerable<string>,
            string,
            string
        > KeyFilter => (keys, keyColumn) => $"{keyColumn}=\"{string.Join($"\" OR {keyColumn}=\"", keys)}\"";

        protected ListRequest(
            DateTime? compareDate,
            string moduleName,
            string programName,
            string busObjName,
            string keyColumn,
            string descColumn,
            string defaultDescColumn,
            string filter,
            string begin,
            string end,
            string keyValue = "")
        {
            CompareDate = compareDate;
            ModuleName = moduleName;
            ProgramName = programName;
            BusObjName = busObjName;
            KeyColumn = keyColumn;
            DescColumn = descColumn;
            DefaultDescColumn = defaultDescColumn;
            Filter = filter;
            Begin = begin;
            End = end;
            KeyValue = keyValue;
        }
    }
}