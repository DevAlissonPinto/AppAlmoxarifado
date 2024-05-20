using AppAlmoxarifado.Domain.Entities.Base;
using AppAlmoxarifado.Domain.Interfaces;

namespace AppAlmoxarifado.Domain.Extensions;

public static class PagedListExtensions
{
    public static IPagedList<T> ToPagedList<T>(this IQueryable<T> queryable)
    {
        var list = queryable.ToList();

        return new PagedList<T>(list, list.Count);
    }

    public static IPagedList<T> ToPagedList<T>(this IQueryable<T> queryable, int total) => new PagedList<T>(queryable.AsEnumerable(), total);
    public static IPagedList<T> ToPagedList<T>(this IList<T> list, int total) => new PagedList<T>(list, total);
    public static IPagedList<T> ToPagedList<T>(this IList<T> list) => new PagedList<T>(list, list.Count);
    public static IPagedList<T> ToPagedList<T>(this IEnumerable<T> list, int total) => new PagedList<T>(list, total);
    public static IPagedList<T> ToPagedList<T>(this IEnumerable<T> list) => new PagedList<T>(list, list.Count());

}
