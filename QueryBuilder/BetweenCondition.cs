﻿using YuraSoft.QueryBuilder.Abstractions;
using YuraSoft.QueryBuilder.Exceptions;
using YuraSoft.QueryBuilder.Interfaces;
using YuraSoft.QueryBuilder.Renderers;

namespace YuraSoft.QueryBuilder
{
	public class BetweenCondition : ICondition
	{
		private IExpression _expression;
		private IExpression _lessExpression;
		private IExpression _hightExpression;

		public BetweenCondition(IExpression expression, IExpression lessExpression, IExpression hightExpression)
		{
			_expression = expression ?? throw new ArgumentShouldNotBeNullException(nameof(expression));
			_lessExpression = lessExpression ?? throw new ArgumentShouldNotBeNullException(nameof(lessExpression));
			_hightExpression = hightExpression ?? throw new ArgumentShouldNotBeNullException(nameof(hightExpression));
		}

		public IExpression Expression
		{
			get => _expression;
			set => _expression = value ?? throw new ArgumentShouldNotBeNullException(nameof(Expression));
		}

		public IExpression LessExpression
		{
			get => _lessExpression;
			set => _lessExpression = value ?? throw new ArgumentShouldNotBeNullException(nameof(LessExpression));
		}

		public IExpression HightExpression
		{
			get => _hightExpression;
			set => _hightExpression = value ?? throw new ArgumentShouldNotBeNullException(nameof(HightExpression));
		}

		public string RenderCondition(IRenderer renderer) => renderer.RenderCondition(this);
	}
}