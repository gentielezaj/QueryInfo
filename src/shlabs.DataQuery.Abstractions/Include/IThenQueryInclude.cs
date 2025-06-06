namespace shlabs.DataQuery.Abstractions;

public interface IThenQueryInclude<TPreviousProperty> : IQueryInclude<TPreviousProperty>
    where TPreviousProperty : class
{
    Type GetNextPropertyType();
}