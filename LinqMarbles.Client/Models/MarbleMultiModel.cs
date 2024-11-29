using LinqMarbles.Client.Helpers;
using MudBlazor;

namespace LinqMarbles.Client.Models;

public record MarbleMultiModel(int Number, string Content, GlobalObject global)
{
    public string Color { get; init; } = ColorsHelper.GetRandomColor(global);
}