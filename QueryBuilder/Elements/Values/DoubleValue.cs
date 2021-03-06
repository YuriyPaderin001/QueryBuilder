using YuraSoft.QueryBuilder.Abstractions;
using YuraSoft.QueryBuilder.Renderers;

#nullable enable

namespace YuraSoft.QueryBuilder
{
	public class DoubleValue : Value<double>
	{
		public DoubleValue(double value) : base(value)
		{
		}

		public static implicit operator DoubleValue(double value) => new DoubleValue(value);

		public override string RenderValue(IRenderer renderer) => renderer.RenderValue(this);
	}
}
