namespace HotChocolate.Data.Neo4J.Language;

public enum ClauseKind
{
    Default,
    AliasedExpression,
    BooleanFunctionCondition,
    BooleanLiteral,
    Comparison,
    CompoundCondition,
    Condition,
    Create,
    Delete,
    Distinct,
    DistinctExpression,
    ExcludePattern,
    Exists,
    ExistentialSubquery,
    Expression,
    ExpressionCondition,
    ExpressionList,
    Foreach,
    FunctionDefinition,
    FunctionInvocation,
    HasLabelCondition,
    KeyValueMapEntry,
    Limit,
    ListComprehension,
    ListExpression,
    ListPredicate,
    Literal,
    LoadCsv,
    MapExpression,
    MapProjection,
    Match,
    Merge,
    MergeAction,
    NestedExpression,
    Node,
    NodeLabel,
    NodeLabels,
    NotCondition,
    Operation,
    Operator,
    OptionalMatch,
    OrderBy,
    Parameter,
    Pattern,
    PatternComprehension,
    ProjectionBody,
    Properties,
    Property,
    PropertyLookup,
    Relationship,
    RelationshipChain,
    RelationshipDetails,
    RelationshipLength,
    RelationshipPatternCondition,
    RelationshipTypes,
    Remove,
    Return,
    Set,
    Skip,
    SortDirection,
    SortItem,
    Statement,
    StatementPrefix,
    StringLiteral,
    SymbolicName,
    TypedSubtree,
    Union,
    UnionPart,
    UnionQuery,
    Unwind,
    Use,
    Visitable,
    Where,
    With,
    YieldItems
}