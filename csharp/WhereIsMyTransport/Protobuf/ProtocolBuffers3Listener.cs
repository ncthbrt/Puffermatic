//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Users/NickCuthbert/IdeaProjects/ProtobufGrammar/src\ProtocolBuffers3.g4 by ANTLR 4.5.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace WhereIsMyTransport.Protobuf {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="ProtocolBuffers3Parser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public interface IProtocolBuffers3Listener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.optionName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptionName([NotNull] ProtocolBuffers3Parser.OptionNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.optionName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptionName([NotNull] ProtocolBuffers3Parser.OptionNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeName([NotNull] ProtocolBuffers3Parser.TypeNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.typeName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeName([NotNull] ProtocolBuffers3Parser.TypeNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.fieldName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldName([NotNull] ProtocolBuffers3Parser.FieldNameContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.fieldName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldName([NotNull] ProtocolBuffers3Parser.FieldNameContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.syntax"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSyntax([NotNull] ProtocolBuffers3Parser.SyntaxContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.syntax"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSyntax([NotNull] ProtocolBuffers3Parser.SyntaxContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.importStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterImportStatement([NotNull] ProtocolBuffers3Parser.ImportStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.importStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitImportStatement([NotNull] ProtocolBuffers3Parser.ImportStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.package"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPackage([NotNull] ProtocolBuffers3Parser.PackageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.package"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPackage([NotNull] ProtocolBuffers3Parser.PackageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.optionValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOptionValue([NotNull] ProtocolBuffers3Parser.OptionValueContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.optionValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOptionValue([NotNull] ProtocolBuffers3Parser.OptionValueContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOption([NotNull] ProtocolBuffers3Parser.OptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.option"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOption([NotNull] ProtocolBuffers3Parser.OptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.messageType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMessageType([NotNull] ProtocolBuffers3Parser.MessageTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.messageType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMessageType([NotNull] ProtocolBuffers3Parser.MessageTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.enumType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumType([NotNull] ProtocolBuffers3Parser.EnumTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.enumType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumType([NotNull] ProtocolBuffers3Parser.EnumTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType([NotNull] ProtocolBuffers3Parser.TypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType([NotNull] ProtocolBuffers3Parser.TypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.fieldNumber"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldNumber([NotNull] ProtocolBuffers3Parser.FieldNumberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.fieldNumber"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldNumber([NotNull] ProtocolBuffers3Parser.FieldNumberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.fieldOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldOption([NotNull] ProtocolBuffers3Parser.FieldOptionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.fieldOption"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldOption([NotNull] ProtocolBuffers3Parser.FieldOptionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.fieldOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldOptions([NotNull] ProtocolBuffers3Parser.FieldOptionsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.fieldOptions"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldOptions([NotNull] ProtocolBuffers3Parser.FieldOptionsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.repeated"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRepeated([NotNull] ProtocolBuffers3Parser.RepeatedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.repeated"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRepeated([NotNull] ProtocolBuffers3Parser.RepeatedContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterField([NotNull] ProtocolBuffers3Parser.FieldContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.field"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitField([NotNull] ProtocolBuffers3Parser.FieldContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.oneofField"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOneofField([NotNull] ProtocolBuffers3Parser.OneofFieldContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.oneofField"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOneofField([NotNull] ProtocolBuffers3Parser.OneofFieldContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.oneof"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOneof([NotNull] ProtocolBuffers3Parser.OneofContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.oneof"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOneof([NotNull] ProtocolBuffers3Parser.OneofContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.keyType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterKeyType([NotNull] ProtocolBuffers3Parser.KeyTypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.keyType"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitKeyType([NotNull] ProtocolBuffers3Parser.KeyTypeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.map"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMap([NotNull] ProtocolBuffers3Parser.MapContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.map"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMap([NotNull] ProtocolBuffers3Parser.MapContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.range"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRange([NotNull] ProtocolBuffers3Parser.RangeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.range"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRange([NotNull] ProtocolBuffers3Parser.RangeContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.ranges"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRanges([NotNull] ProtocolBuffers3Parser.RangesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.ranges"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRanges([NotNull] ProtocolBuffers3Parser.RangesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.reservedField"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReservedField([NotNull] ProtocolBuffers3Parser.ReservedFieldContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.reservedField"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReservedField([NotNull] ProtocolBuffers3Parser.ReservedFieldContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.reservedFields"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReservedFields([NotNull] ProtocolBuffers3Parser.ReservedFieldsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.reservedFields"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReservedFields([NotNull] ProtocolBuffers3Parser.ReservedFieldsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.reserved"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReserved([NotNull] ProtocolBuffers3Parser.ReservedContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.reserved"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReserved([NotNull] ProtocolBuffers3Parser.ReservedContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.enum"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnum([NotNull] ProtocolBuffers3Parser.EnumContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.enum"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnum([NotNull] ProtocolBuffers3Parser.EnumContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.enumBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumBody([NotNull] ProtocolBuffers3Parser.EnumBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.enumBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumBody([NotNull] ProtocolBuffers3Parser.EnumBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.enumField"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEnumField([NotNull] ProtocolBuffers3Parser.EnumFieldContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.enumField"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEnumField([NotNull] ProtocolBuffers3Parser.EnumFieldContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMessage([NotNull] ProtocolBuffers3Parser.MessageContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.message"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMessage([NotNull] ProtocolBuffers3Parser.MessageContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.messageBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMessageBody([NotNull] ProtocolBuffers3Parser.MessageBodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.messageBody"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMessageBody([NotNull] ProtocolBuffers3Parser.MessageBodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.service"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterService([NotNull] ProtocolBuffers3Parser.ServiceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.service"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitService([NotNull] ProtocolBuffers3Parser.ServiceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.rpc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterRpc([NotNull] ProtocolBuffers3Parser.RpcContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.rpc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitRpc([NotNull] ProtocolBuffers3Parser.RpcContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.topLevelDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTopLevelDefinition([NotNull] ProtocolBuffers3Parser.TopLevelDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.topLevelDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTopLevelDefinition([NotNull] ProtocolBuffers3Parser.TopLevelDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ProtocolBuffers3Parser.proto"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProto([NotNull] ProtocolBuffers3Parser.ProtoContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ProtocolBuffers3Parser.proto"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProto([NotNull] ProtocolBuffers3Parser.ProtoContext context);
}
} // namespace WhereIsMyTransport.Protobuf
