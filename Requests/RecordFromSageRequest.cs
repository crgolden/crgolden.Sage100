namespace Clarity.Sage
{
    using System;
    using MediatR;

    public abstract class RecordFromSageRequest<TEntity> : IRequest
        where TEntity : Record
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

        protected RecordFromSageRequest(
            DateTime? compareDate,
            string moduleName,
            string programName,
            string busObjName,
            string keyColumn,
            string descColumn,
            string defaultDescColumn,
            string filter,
            string begin,
            string end)
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
        }
    }
}
