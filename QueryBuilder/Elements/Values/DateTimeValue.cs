using System;

using YuraSoft.QueryBuilder.Abstractions;
using YuraSoft.QueryBuilder.Renderers;

#nullable enable

namespace YuraSoft.QueryBuilder
{
	public class DateTimeValue : Value<DateTime>
	{
		private string _format;

		public DateTimeValue(DateTime value, string? format = null) : base(value)
		{
			_format = string.IsNullOrEmpty(format) ? "s" : format;
		}

		public static implicit operator DateTimeValue(DateTime value) => new DateTimeValue(value);

		public string Format
		{
			get => _format;
			set => _format = string.IsNullOrEmpty(value) ? "s" : value;
		}

		public override string RenderValue(IRenderer renderer) => renderer.RenderValue(this);
	}
}
