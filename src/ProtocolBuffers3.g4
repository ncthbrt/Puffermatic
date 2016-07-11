grammar ProtocolBuffers3;
    WS: [ \n\t\r]+ -> skip;

    COMMENT
        :   '/*' .*? '*/' -> skip
        ;

    LINE_COMMENT
        :   '//' ~[\r\n]* -> skip
        ;
// Keywords and constants

    BuiltInTypes: 'double' | 'float' | 'int32' | 'int64' | 'uint32' | 'uint64'| 'sint32' | 'sint64' | 'fixed32'|
                  'fixed64' | 'sfixed32' | 'sfixed64' | 'bool' | 'string' | 'bytes';

    AssignmentOperator: '=';
    ExpressionSeparator: ';';

    SyntaxKeyword: 'syntax';
    LanguageVersionConstant: '\'proto3\''|'"proto3"';

    ImportKeyword: 'import';
    ImportModifier: 'weak'| 'public';

    RepeatedKeyword: 'repeated';

    PackageKeyword: 'package';

    OneOfKeyword: 'oneof';
    MapKeyword: 'map';

    OptionKeyword: 'option';

    EnumKeyword: 'enum';

    MessageKeyword: 'message';

    ServiceKeyword: 'service';
    RpcKeyword: 'rpc';
    StreamKeyword: 'stream';
    ReturnsKeyword: 'returns';

    GenericTypeOpen: '<';
    GenericTypeClose: '>';

    ToKeyword: 'to';

    ReservedKeyword: 'reserved';

    ListSeparator: ',';

    OptionsOpen: '[';
    OptionsClose: ']';

    BodyOpen: '{';
    BodyClose: '}';


    GroupingOpen:'(';
    GroupingClose:')';

// Begin Lexical Elements
    // Letters & digits

    // Bool Literals
    BooleanLiteral: 'true' | 'false';

    // Identifiers
    Identifier: (Letter (Letter | DecimalDigit | '_')*);
    FullIdentifier: Identifier (Dot Identifier)*;
    Dot: '.';
    Letter: [A-Za-z];

    Sign: '+' | '-';
    // Integer literals
    IntegerLiteral: DecimalLiteral
                    | OctalLiteral
                    | HexLiteral;

    DecimalLiteral: NonZeroDecimalDigit (DecimalDigit)*;
    DecimalDigit: [0-9];
    NonZeroDecimalDigit:[1-9];
    OctalDigit: '0'..'7';
    HexDigit: '0'..'9'
             | 'A'..'F'
             | 'a'..'f';

    OctalLiteral: '0' | '0' OctalDigit+;
    HexLiteral: '0' ('x'|'X') HexDigit+;

    // Float literals
    FloatLiteral:  (Decimals Dot Decimals? Exponent? | Decimals Exponent | Dot Decimals Exponent?);
    Exponent: [eE] Sign? Decimals;
    Decimals: DecimalDigit+;

    // String Literals
    SingleQuote: '\'';
    DoubleQuote: '"';
    CharValue: HexEscape | OctalEscape | CharEscape | ~[\0\n\\];
    HexEscape: '\\' ('x'|'X') HexDigit HexDigit;
    OctalEscape: '\\' OctalDigit OctalDigit OctalDigit;
    CharEscape: '\\' [abfnrtv\\\'"];
    StringLiteral: SingleQuote CharValue* SingleQuote | DoubleQuote CharValue* DoubleQuote;

    // Empty Statement
    EmptyStatement: ';' -> skip;


// Begin Lexical Elements

// Begin syntactic primatives

    // Names
    optionName: (fieldName | (GroupingOpen (FullIdentifier | fieldName) GroupingClose)) ('.' Identifier)*  | Keyword;
    typeName: Identifier;
    fieldName: BuiltInTypes | ImportKeyword | ImportModifier | PackageKeyword | OneOfKeyword | MapKeyword | OptionKeyword
             | EnumKeyword | MessageKeyword | ToKeyword | ReservedKeyword |  BooleanLiteral | ServiceKeyword
             | RpcKeyword | StreamKeyword| ReturnsKeyword | Identifier;

    //Syntax
    syntax: SyntaxKeyword AssignmentOperator LanguageVersionConstant ExpressionSeparator;

    // Import Statement
    importStatement: ImportKeyword ImportModifier? StringLiteral ExpressionSeparator;

    // Package
    package: PackageKeyword FullIdentifier ExpressionSeparator;

    // Option
    optionValue:  BooleanLiteral| FullIdentifier | (Sign? IntegerLiteral) | (Sign? FloatLiteral) | StringLiteral;

    option: OptionKeyword optionName AssignmentOperator optionValue ExpressionSeparator;



    messageType: Dot? (Identifier Dot)* typeName;

    enumType: Dot? Identifier (Identifier Dot)* typeName;
    // Fields
    type:  messageType | enumType | BuiltInTypes;

    fieldNumber:  IntegerLiteral;
    fieldOption: optionName AssignmentOperator optionValue;
    fieldOptions: fieldOption (ListSeparator fieldOption)*;



    repeated: RepeatedKeyword;
    field: RepeatedKeyword? type fieldName AssignmentOperator fieldNumber (OptionsOpen fieldOptions OptionsClose)? ExpressionSeparator;

    // One of field
    oneofField: type fieldName AssignmentOperator fieldNumber fieldOptions? ExpressionSeparator;
    oneof: OneOfKeyword fieldName BodyOpen ( oneofField )* BodyClose;

    // Map field
    keyType: BuiltInTypes;
    map: MapKeyword GenericTypeOpen keyType ListSeparator type GenericTypeClose fieldName AssignmentOperator fieldNumber fieldOptions? ExpressionSeparator;

    //Reserved fields
    range: fieldNumber
         | (fieldNumber ToKeyword fieldNumber);
    ranges: range (ListSeparator range)*;
    reservedField: StringLiteral;
    reservedFields: reservedField (ListSeparator reservedField)*;
    reserved: ReservedKeyword (ranges | reservedFields) ExpressionSeparator;

// End syntactic primatives

// Begin top level definitions
    // Enums
    enum: 'enum' typeName enumBody;
    enumBody: BodyOpen (option | enumField )* BodyClose;
    enumField: fieldName AssignmentOperator fieldNumber (OptionsOpen fieldOptions OptionsClose)? ExpressionSeparator;

    //Messages
    message: MessageKeyword typeName messageBody;
    messageBody: BodyOpen (field| enum | message | option | oneof | map | reserved)* BodyClose;

    //Services
    service: ServiceKeyword typeName  BodyOpen (option | rpc )* BodyClose;
    rpc: RpcKeyword fieldName
         GroupingOpen StreamKeyword? typeName GroupingClose
         ReturnsKeyword
         GroupingOpen StreamKeyword? typeName GroupingClose
         (OptionsOpen fieldOptions OptionsClose)? ExpressionSeparator;

    topLevelDefinition: message | enum | service;
    proto: syntax ( importStatement | package | option | topLevelDefinition)* EOF;
