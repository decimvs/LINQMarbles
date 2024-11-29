using LinqMarbles.Client.Helpers;
using MudBlazor;

namespace LinqMarbles.Client.Models;

public record MarbleNumberModel(int Number, GlobalObject global)
{
    public string Color { get; init; } = ColorsHelper.GetRandomColor(global);

    public virtual bool Equals(MarbleNumberModel? other) => Number == other?.Number;

    public override int GetHashCode() => Number.GetHashCode();
}