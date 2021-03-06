using YuraSoft.QueryBuilder.Renderers;

#nullable enable

namespace YuraSoft.QueryBuilder.Interfaces
{
	public interface IColumn : IIdentificator, IExpression
	{
		public string RenderColumn(IRenderer renderer);
	}
}
