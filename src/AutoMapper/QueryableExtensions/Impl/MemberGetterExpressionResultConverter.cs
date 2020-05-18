using System.ComponentModel;

namespace AutoMapper.QueryableExtensions.Impl
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class MemberGetterExpressionResultConverter : IExpressionResultConverter
    {
        public ExpressionResolutionResult GetExpressionResolutionResult(ExpressionResolutionResult expressionResolutionResult, IMemberMap propertyMap, LetPropertyMaps letPropertyMaps)
            => new ExpressionResolutionResult(propertyMap.SourceMembers.MemberAccesses(
                propertyMap.CustomSource == null ? expressionResolutionResult.ResolutionExpression : letPropertyMaps.GetSubQueryMarker(propertyMap.CustomSource)));
        public bool CanGetExpressionResolutionResult(ExpressionResolutionResult expressionResolutionResult, IMemberMap propertyMap) => propertyMap.SourceMembers.Count > 0;
    }
}