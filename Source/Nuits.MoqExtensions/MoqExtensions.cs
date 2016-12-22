using System;
using System.ComponentModel;
using System.Linq.Expressions;
using Moq;
using Moq.Language.Flow;

namespace Nuits.Moq
{
    public static class MoqExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="mock"></param>
        /// <param name="expression"></param>
        /// <param name="setupValue"></param>
        /// <returns></returns>
        public static IReturnsResult<T> NotifyPropertyChanged<T, TResult>(this Mock<T> mock, Expression<Func<T, TResult>> expression, TResult setupValue) where T : class, INotifyPropertyChanged
        {
            var memberExpression = expression.Body as MemberExpression;
            if (memberExpression == null) throw new ArgumentException("expression.Body is not MemberExpression");

            var returnResult = mock.Setup(expression).Returns(setupValue);

            mock.Raise(m => m.PropertyChanged += null, new PropertyChangedEventArgs(memberExpression.Member.Name));

            return returnResult;
        }
    }
}
